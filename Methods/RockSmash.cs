namespace TinyFinder
{
    class RockSmash
    {
        public TinyMT tinysmash = new TinyMT();
        public SlotData data = new SlotData();
        public byte encounter, slot, item, randInt, flute;
        public bool Sync;
        public uint[] temp = new uint[4];
        public void results(uint[] current, bool oras)
        {
            current.CopyTo(temp, 0);

            tinysmash.nextState(temp);
            randInt = tinysmash.Rand(temp, 100);
            encounter = tinysmash.Rand(temp, 3);

            tinysmash.nextState(temp);
            Sync = tinysmash.Rand(temp, 100) < 50;

            tinysmash.nextState(temp);
            slot = data.getSlot(tinysmash.Rand(temp, 100), 3);

            if (oras)
            {
                tinysmash.nextState(temp);
                if (tinysmash.Rand(temp, 100) < 40)
                    flute = 1;
                else if (tinysmash.Rand(temp, 100) < 70)
                    flute = 2;
                else if (tinysmash.Rand(temp, 100) < 90)
                    flute = 3;
                else flute = 4;
            }

            tinysmash.nextState(temp);
            tinysmash.nextState(temp);
            if (tinysmash.Rand(temp, 100) < 50)
                item = 50;
            else if (tinysmash.Rand(temp, 100) < 55)
                item = 5;
            else if (tinysmash.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;
        }
    }
}
