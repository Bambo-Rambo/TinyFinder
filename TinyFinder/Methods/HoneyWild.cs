namespace TinyFinder
{
    class HoneyWild
    {
        public byte slot, flute, item, rand100, slotCase, Bag_Advances;
        public bool Sync;
        public uint[] temp = new uint[4];

        TinyMT tinyhoney = new TinyMT();
        Data data = new Data();

        public void results(uint[] current, bool oras, byte party)
        {
            current.CopyTo(temp, 0);

            tinyhoney.nextState(temp);
            rand100 = tinyhoney.Rand(temp, 100);

            for (byte i = 0; i < Bag_Advances + (3 * party); i++)
                tinyhoney.nextState(temp);

            Sync = tinyhoney.Rand(temp, 100) < 50;

            tinyhoney.nextState(temp);
            slot = data.getSlot(tinyhoney.Rand(temp, 100), slotCase);

            if (oras)
            {
                tinyhoney.nextState(temp);
                if (tinyhoney.Rand(temp, 100) < 40)
                    flute = 1;
                else if (tinyhoney.Rand(temp, 100) < 70)
                    flute = 2;
                else if (tinyhoney.Rand(temp, 100) < 90)
                    flute = 3;
                else flute = 4;
            }

            tinyhoney.nextState(temp);
            tinyhoney.nextState(temp);
            if (tinyhoney.Rand(temp, 100) < 50)
                item = 50;
            else if (tinyhoney.Rand(temp, 100) < 55)
                item = 5;
            else if (tinyhoney.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;
        }
    }
}
