namespace TinyFinder
{
    class Horde : Index
    {
        public byte HA, NPC;
        public bool Trigger_only;
        public byte[] flutes = new byte[5]; //items = new byte[5];

        public void HordeTurn(uint[] currentState, bool oras, bool XY_TallGrass, byte ratio)
        {
            currentState.CopyTo(temp, 0);

            for (byte i = 0; i < NPC; i++)          //NPC Influence taken into account before everything else
                Advance();

            rand100 = RandCall(100);

            Advance();                              //+1 in order to avoid using the same rand100 for Horde trigger check and Sync
            Sync = CurrentRand(100) < 50;           //Every horde, triggered by step, would be synced otherwise

            encounter = RandCall(100);

            trigger =  rand100 < 5 && encounter < ratio;

            if (!trigger && Trigger_only)
                return;

            if (XY_TallGrass)                       //Unknown reason
                Advance();

            FinalizeIndex(oras);
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't make use of memories)
        public void HordeHoney(uint[] currentState2, bool oras)
        {
            currentState2.CopyTo(temp, 0);

            rand100 = RandCall(100);

            /*Number of Bag advances calculated only once in FindResults.cs:        // 3 if Cave / ORAS underwater
                                                                                    // 27 if XY
            for (byte i = 0; i < Bag_advances + (3 * party); i++)                   // 15 if ORAS
              Advance();                                                            */

            Sync = CurrentRand(100) < 50;

            FinalizeIndex(oras);
        }

        public void FinalizeIndex(bool oras)
        {
            slot = data.getSlot(RandCall(100), 3);

            if (RandCall(100) < 20)
                HA = (byte)(RandCall(5) + 1);
            else
                HA = 0;

            Advance();
            if (oras)
            {
                for (byte i = 0; i < 5; i++)
                {
                    if (CurrentRand(100) < 40)
                        flutes[i] = 1;
                    else if (CurrentRand(100) < 70)
                        flutes[i] = 2;
                    else if (CurrentRand(100) < 90)
                        flutes[i] = 3;
                    else 
                        flutes[i] = 4;
                    Advance();
                }
            }

            /*Advance();
            for (byte i = 0; i < 5; i++)
            {
                if (CurrentRand(100) < 50)
                    items[i] = 50;
                else if (CurrentRand(100) < 55)
                    items[i] = 5;
                else if (CurrentRand(100) < 56)
                    items[i] = 1;
                else 
                    items[i] = 0;
            }*/
        }
    }
}