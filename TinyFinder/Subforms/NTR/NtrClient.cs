using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TinyFinder
{
    public partial class NtrClient
    {
        public Socket socket;
        public string host;
        public int port;
        public TcpClient tcp;
        public NetworkStream netStream;
        public Thread packetRecvThread;
        private object syncLock = new object();
        private bool heartbeatSendable;
        public byte Gameversion { get; private set; }
        public byte Pid { get; private set; } = 0x28;
        private uint TinyOffset, StepOffset, ChainOffset, RadarOffset, DexNavOffset;
        private bool DataReady;
        public byte[] Data { get; private set; }
        public bool OneClick;
        public event EventHandler<InfoEventArgs> Message;
        protected virtual void SendMsg(InfoEventArgs e) => Message?.Invoke(this, e);
        private void SendMsg(object _data, string _info = null)
            => SendMsg(new InfoEventArgs { info = _info, data = _data });
        public bool Connected => tcp?.Connected ?? false;
        public bool DebuggerEnabled => 5000 < port && port < 8000 && Connected;

        uint currentSeq;
        uint lastReadMemSeq;
        public volatile int progress = -1;

        public event EventHandler Connect;
        public class InfoEventArgs : EventArgs
        {
            public string info;
            public object data;
        }
        public void CheckSocket()
        {
            if (socket == null)
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0);
            if (!socket.Connected)
            {
                socket.Connect(host, 4950);
            }
        }

        protected virtual void OnConnected(EventArgs e)
        {
            Connect?.Invoke(this, e);
        }

        public void bpadd(uint addr, string type = "code.once")
        {
            switch (type)
            {
                case "code":
                    sendEmptyPacket(11, 1, addr, 1);
                    return;
                case "code.once":
                    sendEmptyPacket(11, 2, addr, 1);
                    return;
            }
        }

        public void resume() => sendEmptyPacket(11, 0, 0, 4);

        public void Read(uint addr, uint size = 4, int pid = -1)
        {
            if (size > 1024)
                size = 1024;
            sendReadMemPacket(addr, size, (uint)pid);
        }

        public void Write(uint addr, byte[] buf, int pid = -1)
        {
            sendWriteMemPacket(addr, (uint)pid, buf);
        }

        public void setServer(string serverHost, int serverPort)
        {
            host = serverHost;
            port = serverPort;
        }

        public void connectToServer()
        {
            if (tcp != null)
                disconnect();
            tcp = new TcpClient();
            tcp.NoDelay = true;
            tcp.Connect(host, port);
            currentSeq = 0;
            netStream = tcp.GetStream();
            heartbeatSendable = true;
            packetRecvThread = new Thread(new ThreadStart(packetRecvThreadStart));
            packetRecvThread.Start();
            log("Server connected.");
            OnConnected(null);
        }

        public void disconnect(bool waitPacketThread = true)
        {
            try
            {
                tcp?.Close();
                socket?.Disconnect(false);
                if (waitPacketThread)
                    packetRecvThread?.Join();
            }
            catch (Exception ex)
            {
                log(ex.Message);
            }
            tcp = null;
            socket = null;
        }

        public void listprocess() => sendEmptyPacket(5);

        private int readNetworkStream(NetworkStream stream, byte[] buf, int length)
        {
            int index = 0;
            bool useProgress = length > 100000;
            do
            {
                if (useProgress)
                    progress = (int)(((double)(index) / length) * 100);
                int len = stream.Read(buf, index, length - index);
                if (len == 0)
                    return 0;
                index += len;
            }
            while (index < length);
            progress = -1;
            return length;
        }

        private void packetRecvThreadStart()
        {
            byte[] buf = new byte[0x54];
            uint[] args = new uint[0x10];
            int ret;
            NetworkStream stream = netStream;

            while (true)
            {
                try
                {
                    ret = readNetworkStream(stream, buf, buf.Length);
                    if (ret == 0)
                        break;
                    uint magic = BitConverter.ToUInt32(buf, 0x0);
                    uint seq = BitConverter.ToUInt32(buf, 0x4);
                    uint type = BitConverter.ToUInt32(buf, 0x8);
                    uint cmd = BitConverter.ToUInt32(buf, 0xC);
                    for (int i = 0; i < args.Length; i++)
                        args[i] = BitConverter.ToUInt32(buf, 0x4 * i + 0x10);
                    uint dataLen = BitConverter.ToUInt32(buf, 0x50);

                    if (cmd != 0)
                        log(string.Format("packet: cmd = {0}, dataLen = {1}", cmd, dataLen));

                    if (magic != 0x12345678)
                    {
                        log(string.Format("broken protocol: magic = {0}, seq = {1}", magic, seq));
                        break;
                    }

                    if (cmd == 0)
                    {
                        if (dataLen != 0)
                        {
                            byte[] dataBuf = new byte[dataLen];
                            readNetworkStream(stream, dataBuf, dataBuf.Length);
                            string logMsg = Encoding.UTF8.GetString(dataBuf);
                            log(logMsg);
                        }
                        lock (syncLock)
                        {
                            heartbeatSendable = true;
                        }
                        continue;
                    }
                    if (dataLen != 0)
                    {
                        byte[] dataBuf = new byte[dataLen];
                        readNetworkStream(stream, dataBuf, dataBuf.Length);
                        handlePacket(cmd, seq, dataBuf);
                    }
                }
                catch (Exception e)
                {
                    log(e.Message);
                    break;
                }
            }
            log("Server disconnected.");
            disconnect(false);
        }

        private void handleReadMem(uint seq, byte[] dataBuf)
        {
            if (seq != lastReadMemSeq)
            {
                log("seq != lastReadMemSeq, ignored");
                return;
            }
            lastReadMemSeq = 0;
            GetData(dataBuf);
        }

        private void handlePacket(uint cmd, uint seq, byte[] dataBuf)
        {
            if (cmd == 9)
                handleReadMem(seq, dataBuf);
        }

        private void sendPacket(uint type, uint cmd, uint[] args, uint dataLen)
        {
            currentSeq += 1000;
            byte[] buf = new byte[0x54];
            BitConverter.GetBytes(0x12345678).CopyTo(buf, 0x0);
            BitConverter.GetBytes(currentSeq).CopyTo(buf, 0x4);
            BitConverter.GetBytes(type).CopyTo(buf, 0x8);
            BitConverter.GetBytes(cmd).CopyTo(buf, 0xC);
            for (int i = 0; i < 16; i++)
                BitConverter.GetBytes(args?[i] ?? 0).CopyTo(buf, 0x4 * i + 0x10);
            BitConverter.GetBytes(dataLen).CopyTo(buf, 0x50);
            netStream.Write(buf, 0, buf.Length);
        }

        private void sendReadMemPacket(uint addr, uint size, uint pid)
        {

            sendEmptyPacket(9, pid, addr, size);
            lastReadMemSeq = currentSeq;
        }

        private void sendWriteMemPacket(uint addr, uint pid, byte[] buf)
        {
            uint[] args = new uint[16];
            args[0] = pid;
            args[1] = addr;
            args[2] = (uint)buf.Length;
            sendPacket(1, 10, args, args[2]);
            netStream.Write(buf, 0, buf.Length);
        }

        public void sendHeartbeatPacket()
        {
            if (tcp != null)
            {
                lock (syncLock)
                {
                    if (heartbeatSendable)
                    {
                        heartbeatSendable = false;
                        sendPacket(0, 0, null, 0);
                    }
                }
            }
        }

        private void sendEmptyPacket(uint cmd, uint arg0 = 0, uint arg1 = 0, uint arg2 = 0)
        {
            uint[] args = new uint[16];

            args[0] = arg0;
            args[1] = arg1;
            args[2] = arg2;
            sendPacket(0, cmd, args, 0);
        }

        private void log(string msg)
        {
            new Task(() => parseLogMsg(msg)).Start();
#if DEBUG
            try
            {
                Console.WriteLine(msg);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
#endif
        }

        private void parseLogMsg(string logmsg)
        {
            getGame(logmsg);
            getBP(logmsg);
        }

        private static string[] pnamestr = { "kujira-1", "kujira-2", "sango-1", "sango-2", "salmon", "niji_loc", "niji_loc", "momiji", "momiji" };
        private bool getGame(string logmsg)
        {
            string pname;
            if (null == (pname = pnamestr.FirstOrDefault(logmsg.Contains)))
                return false;
            Gameversion = (byte)Array.IndexOf(pnamestr, pname);
            pname = ", pname:" + pname.PadLeft(9);
            string pidaddr = logmsg.Substring(logmsg.IndexOf(pname, StringComparison.Ordinal) - 10, 10);
            Pid = Convert.ToByte(pidaddr, 16);

            switch (Gameversion)
            {
                case 0:
                case 1:
                    TinyOffset = 0x08C52808;
                    RadarOffset = 0x8D1B2B8;
                    break;
                case 2:
                case 3:
                    TinyOffset = 0x08C59E04;
                    DexNavOffset = 0x8D3B4D4;
                    StepOffset = DexNavOffset + 0x34;
                    ChainOffset = DexNavOffset + 0xA8;
                    break;
            }
            SendMsg(Gameversion, "Version");
            return true;
        }
        private bool getBP(string logmsg)
        {
            string BPSTR = "breakpoint ";
            if (!(logmsg.Contains(BPSTR) && logmsg.Contains(" hit")))
                return false;
            resume();
            return true;
        }


        public byte[] SingleThreadRead(uint addr, uint size = 4)
        {
            DataReady = false;
            Read(addr, size, Pid);
            int timeout = 20;
            do
            {
                Thread.Sleep(100);
                timeout--;
            }
            while (!DataReady && timeout > 0);
            if (timeout == 0)
                return null;
            return Data;
        }

        private void GetData(byte[] datBuf)
        {
            Data = (byte[])datBuf.Clone();
            DataReady = true;
        }

        public byte[] ReadTiny(uint Offset) => SingleThreadRead(Offset, 0x10);

        public void ReadTiny(string Name)
        {
            byte[] tiny = new byte[0];
            switch (Name)
            {
                case "TTT":
                    tiny = ReadTiny(TinyOffset);
                    break;
                case "Step":
                    tiny = ReadTiny(StepOffset);
                    break;
                case "DexNavChain":
                    tiny = ReadTiny(ChainOffset);
                    break;
                case "RadarChain":
                    tiny = ReadTiny(RadarOffset);
                    break;
            }
            if (tiny == null)
                return;
            uint[] tinyseeds =
            {
                BitConverter.ToUInt32(tiny, 0),
                BitConverter.ToUInt32(tiny, 4),
                BitConverter.ToUInt32(tiny, 8),
                BitConverter.ToUInt32(tiny, 12),
             };
            SendMsg(tinyseeds, Name);
        }

        public void ReadStep()
        {
            var steps = SingleThreadRead(StepOffset, 0x4);
            if (steps == null)
                return;
            var step = BitConverter.ToUInt16(steps, 0);
            SendMsg(step, "Step");
        }
    }
}
