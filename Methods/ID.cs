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
        public ID(ushort t, ushort s)
        {
            trainerID = t;
            secretID = s;
            TSV = (ushort)((t ^ s) >> 4);
            TRV = (byte)((t ^ s) & 0xF);
            randhex = Convert.ToUInt32((secretID.ToString("X") + trainerID.ToString("X").PadLeft(4, '0')), 16);
        }

    }
}
