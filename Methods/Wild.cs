namespace TinyFinder
{
    class Wild
    {
        //Normal, Fishing and Friend Safari
        private TinyMT tinywild = new TinyMT();
        private SlotData data = new SlotData();
        private uint[] temp = new uint[4];
        public byte slot, encounter, flute, randInt, item;
        public bool Sync;

        public void results(uint[] current, bool oras, bool cave, byte slotLine, byte ES)
        {
            current.CopyTo(temp, 0);
            tinywild.nextState(temp);
            randInt = tinywild.Rand(temp, 100);

            if (!oras)
            {
                if (cave)
                    tinywild.nextState(temp);
                else
                    for (byte i = 1; i < ES; i++)
                        tinywild.nextState(temp);
            }

            Sync = tinywild.Rand(temp, 100) < 50;

            tinywild.nextState(temp);
            encounter = tinywild.Rand(temp, 100);

            if (ES != 0 && !cave)
                tinywild.nextState(temp);

            tinywild.nextState(temp);
            slot = data.getSlot(tinywild.Rand(temp, 100), slotLine);

            if (oras)
            {
                tinywild.nextState(temp);
                if (tinywild.Rand(temp, 100) < 40)
                    flute = 1;
                else if (tinywild.Rand(temp, 100) < 70)
                    flute = 2;
                else if (tinywild.Rand(temp, 100) < 90)
                    flute = 3;
                else flute = 4;
            }

            tinywild.nextState(temp);
            tinywild.nextState(temp);
            if (tinywild.Rand(temp, 100) < 50)
                item = 50;
            else if (tinywild.Rand(temp, 100) < 55)
                item = 5;
            else if (tinywild.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;
        }
    }
}
