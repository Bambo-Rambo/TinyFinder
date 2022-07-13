namespace TinyFinder
{
    class Horde
    {
        public byte slot, HA, rand100, encounter, ratio, NPC;
        public bool sync, trigger, oras, XY_TallGrass, Trigger_only;
        public byte[] flutes = new byte[5]; //items = new byte[5];
        public uint[] temp = new uint[4];
        public TinyMT tiny = new TinyMT();
        public Data data = new Data();

        public void HordeTurn(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);

            for (byte i = 0; i < NPC; i++)          //NPC Influence taken into account before everything else
                tiny.nextState(temp);

            tiny.nextState(temp);
            rand100 = tiny.Rand(temp, 100);

            tiny.nextState(temp);              //+1 in order to avoid using the same rand100 for Horde trigger check and Sync
            sync = tiny.Rand(temp, 100) < 50;  //Every horde, triggered by step, would be synced otherwise

            tiny.nextState(temp);
            encounter = tiny.Rand(temp, 100);

            trigger =  rand100 < 5 && encounter < ratio;

            if (!trigger && Trigger_only)
                return;

            if (XY_TallGrass)                       //Unknown reason
                tiny.nextState(temp);

            FinalizeIndex();
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't make use of memories)
        public void HordeHoney(uint[] currentState2)
        {
            currentState2.CopyTo(temp, 0);
            tiny.nextState(temp);
            rand100 = tiny.Rand(temp, 100);

            /*Number of Bag advances calculated only once in FindResults.cs:        // 3 if Cave / ORAS underwater
                                                                                    // 27 if XY
            for (byte i = 0; i < Bag_advances + (3 * party); i++)                   // 15 if ORAS
              tinyhoney.nextState(temp);                                            */

            sync = tiny.Rand(temp, 100) < 50;

            FinalizeIndex();
        }

        public void FinalizeIndex()
        {
            tiny.nextState(temp);
            slot = data.getSlot(tiny.Rand(temp, 100), 3);

            HA = 0;
            tiny.nextState(temp);
            if (tiny.Rand(temp, 100) < 20)
            {
                tiny.nextState(temp);
                HA = (byte)(tiny.Rand(temp, 5) + 1);
            }

            tiny.nextState(temp);
            if (oras)
            {
                for (byte i = 0; i < 5; i++)
                {
                    if (tiny.Rand(temp, 100) < 40)
                        flutes[i] = 1;
                    else if (tiny.Rand(temp, 100) < 70)
                        flutes[i] = 2;
                    else if (tiny.Rand(temp, 100) < 90)
                        flutes[i] = 3;
                    else flutes[i] = 4;
                    tiny.nextState(temp);
                }
            }

            /*tinyhorde.nextState(temp);
            for (byte i = 0; i < 5; i++)
            {
                if (tinyhorde.Rand(temp, 100) < 50)
                    items[i] = 50;
                else if (tinyhorde.Rand(temp, 100) < 55)
                    items[i] = 5;
                else if (tinyhorde.Rand(temp, 100) < 56)
                    items[i] = 1;
                else items[i] = 0;
                tinyhorde.nextState(temp);
            }*/
        }
    }
}
