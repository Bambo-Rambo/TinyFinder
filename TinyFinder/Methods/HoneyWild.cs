namespace TinyFinder
{
    class HoneyWild
    {
        public byte slot, flute, rand100, slotCase;
      //public byte item;
        public bool Sync;
        public uint[] temp = new uint[4];

        TinyMT tinyhoney = new TinyMT();
        Data data = new Data();

        public void results(uint[] current, bool oras)
        {
            current.CopyTo(temp, 0);

            tinyhoney.nextState(temp);
            rand100 = tinyhoney.Rand(temp, 100);

            /*Number of Bag advances calculated only once in FindResults.cs:        // 3 if Cave / ORAS underwater
                                                                                    // 27 if XY
            for (byte i = 0; i < Bag_advances + (3 * party); i++)                   // 15 if ORAS
              tinyhoney.nextState(temp);                                            // 6 if ORAS Magma/Aqua Hideout*/

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

            /*tinyhoney.nextState(temp);
            tinyhoney.nextState(temp);
            if (tinyhoney.Rand(temp, 100) < 50)
                item = 50;
            else if (tinyhoney.Rand(temp, 100) < 55)
                item = 5;
            else if (tinyhoney.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;*/
        }
    }
}
