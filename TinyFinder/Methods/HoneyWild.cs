namespace TinyFinder
{
    class HoneyWild
    {
        public byte slot, flute, rand100, slotType;
      //public byte item;
        public bool Sync, oras;
        public uint[] temp = new uint[4];

        TinyMT tiny = new TinyMT();
        Data data = new Data();

        public void GenerateIndex(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);

            tiny.nextState(temp);
            rand100 = tiny.Rand(temp, 100);

            /*Number of Bag advances calculated only once in FindResults.cs:        // 3 if Cave / ORAS underwater
                                                                                    // 27 if XY
            for (byte i = 0; i < Bag_advances + (3 * party); i++)                   // 15 if ORAS
              tinyhoney.nextState(temp);                                            // 6 if ORAS Magma/Aqua Hideout*/

            Sync = tiny.Rand(temp, 100) < 50;

            tiny.nextState(temp);
            slot = data.getSlot(tiny.Rand(temp, 100), slotType);

            if (oras)
            {
                tiny.nextState(temp);
                if (tiny.Rand(temp, 100) < 40)
                    flute = 1;
                else if (tiny.Rand(temp, 100) < 70)
                    flute = 2;
                else if (tiny.Rand(temp, 100) < 90)
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
