using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFinder
{
    class ID
    {
        public ushort trainerID, secretID, TSV;
        public uint randhex;
        public byte TRV;
        public TinyMT tiny = new TinyMT();
        public uint[] temp = new uint[4];
        public ID(ushort t, ushort s)
        {
            trainerID = t;
            secretID = s;
            TSV = (ushort)((t ^ s) >> 4);
            TRV = (byte)((t ^ s) & 0xF);
            randhex = Convert.ToUInt32(secretID.ToString("X") + trainerID.ToString("X").PadLeft(4, '0'), 16);
        }

        //Bad implementation, fix later
        public void results(uint[] current)
        {
            current.CopyTo(temp, 0);
            tiny.nextState(temp);
            randhex = tiny.temper(temp);
            trainerID = (ushort)randhex;
            secretID = (ushort)(randhex >> 16);
            TSV = (ushort)((trainerID ^ secretID) >> 4);
            TRV = (byte)((trainerID ^ secretID) & 0xF);
        }

    }
}
