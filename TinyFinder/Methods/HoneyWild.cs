namespace TinyFinder
{
    class HoneyWild : Index
    {
        public void GenerateIndex(uint[] currentState, bool oras)
        {
            currentState.CopyTo(temp, 0);

            rand100 = RandCall(100);

            /*Number of Bag advances calculated only once in FindResults.cs:        // 3 if Cave / ORAS underwater
                                                                                    // 27 if XY
            for (byte i = 0; i < Bag_advances + (3 * party); i++)                   // 15 if ORAS
               Advance();                                                           // 6 if ORAS Magma/Aqua Hideout*/

            Sync = CurrentRand(100) < 50;

            slot = data.getSlot(RandCall(100), slotType);

            if (oras)
            {
                Advance();

                if (CurrentRand(100) < 40)
                    flute = 1;

                else if (CurrentRand(100) < 70)
                    flute = 2;

                else if (CurrentRand(100) < 90)
                    flute = 3;

                else 
                    flute = 4;
            }

            /*Advance();
              Advance();

            if (CurrentRand(100) < 50)
                item = 50;

            else if (CurrentRand(100) < 55)
                item = 5;

            else if (CurrentRand(100) < 56)
                item = 1;

            else 
                item = 0;*/
        }
    }
}