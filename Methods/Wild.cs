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

        public void results(uint[] current, bool oras, byte slotLine, byte NPC, byte Extra)
        {
            current.CopyTo(temp, 0);
            tinywild.nextState(temp);
            randInt = tinywild.Rand(temp, 100);

            for (byte i = 0; i < NPC; i++)
                tinywild.nextState(temp);

            Sync = tinywild.Rand(temp, 100) < 50;

            tinywild.nextState(temp);
            encounter = tinywild.Rand(temp, 100);

            for (byte i = 0; i < Extra; i++)
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
