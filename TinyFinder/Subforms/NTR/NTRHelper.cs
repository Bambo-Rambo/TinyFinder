using System;
using System.Windows.Forms;

namespace TinyFinder
{
    public partial class NTRHelper : Form
    {
        public static NtrClient ntrclient;
        public NTRHelper()
        {
            InitializeComponent();
            IP.Text = Properties.Settings.Default.IP;
            ntrclient = new NtrClient();
            ntrclient.Connect += OnConnected;
            ntrclient.Message += OnMsgArrival;
            ntrclient.setServer(IP.Text, 8000);
        }
        private void NTRHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = IP.Text;
            Properties.Settings.Default.Save();
        }
        public void HandleException()
        {
            B_OneClick.PerformClick();
        }
        public void Connect(bool OneClick)
        {
            B_Connect_Click(OneClick ? B_OneClick : null, null);
        }

        private void B_Connect_Click(object sender, EventArgs e)
        {
            ntrclient.OneClick = sender == B_OneClick;
            L_NTRLog.Text = "Connecting...";
            ntrclient.setServer(IP.Text, 8000);
            try
            {
                ntrclient.connectToServer();
            }
            catch
            {
                OnDisconnected(false);
                MessageBox.Show("Unable to connect the console", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void B_Disconnect_Click(object sender, EventArgs e)
        {
            ntrclient.disconnect();
            OnDisconnected();
        }

        private void OnDisconnected(bool Success = true)
        {
            NTR_Timer.Enabled = false;
            B_Connect.Enabled = true;
            L_NTRLog.Text = Success ? "Disconnected" : "No Connection";
            B_Disconnect.Enabled = false;
            Program.form.OnConnected_Changed(false);
        }

        private void OnConnected(object sender, EventArgs e)
        {
            if (ntrclient.port == 8000)
            {
                NTR_Timer.Enabled = true;
                L_NTRLog.Text = "Console Connected";
                B_Connect.Enabled = false;
                B_Disconnect.Enabled = true;
                Program.form.OnConnected_Changed(true);
                ntrclient.listprocess();
            }
        }

        private void OnMsgArrival(object sender, NtrClient.InfoEventArgs e)
        {
            Invoke(new Action(() =>
            {
                switch (e.info)
                {
                    case "Disconnect":
                        B_Disconnect_Click(null, null);
                        return;
                    case null:
                        L_NTRLog.Text = (string)e.data;
                        return;
                }
                Program.form.parseNTRInfo(e.info, e.data);
            }));
        }

        private void NTRTick(object sender, EventArgs e)
        {
            try { ntrclient.sendHeartbeatPacket(); } catch { }
        }

    }
}
