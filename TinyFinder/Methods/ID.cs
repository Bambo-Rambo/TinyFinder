namespace TinyFinder
{
    class ID : Index
    {
        public ID(uint[] current, bool advance)
        {
            current.CopyTo(temp, 0);
            if (advance)
                AdvanceOnce();
            randhex = tiny.temper(temp);
            trainerID = (ushort)randhex;
            secretID = (ushort)(randhex >> 16);
            TSV = (ushort)((trainerID ^ secretID) >> 4);
            TRV = (byte)((trainerID ^ secretID) & 0xF);
        }

    }
}