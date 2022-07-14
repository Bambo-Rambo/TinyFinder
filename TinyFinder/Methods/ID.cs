using System;

namespace TinyFinder
{
    class ID : Index
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
            randhex = Convert.ToUInt32(secretID.ToString("X") + trainerID.ToString("X").PadLeft(4, '0'), 16);
        }

        //Bad implementation, fix later
        public void GenerateIndex(uint[] current)
        {
            current.CopyTo(temp, 0);
            Advance();
            randhex = tiny.temper(temp);
            trainerID = (ushort)randhex;
            secretID = (ushort)(randhex >> 16);
            TSV = (ushort)((trainerID ^ secretID) >> 4);
            TRV = (byte)((trainerID ^ secretID) & 0xF);
        }

    }
}
