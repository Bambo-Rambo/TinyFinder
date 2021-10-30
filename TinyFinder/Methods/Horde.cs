namespace TinyFinder
{
    class Horde
    {
        public byte slot, HA, rand100, Bag_Advances, encounter;
        public bool sync, trigger;
        public byte[] flutes = new byte[5], items = new byte[5];
        public uint[] temp = new uint[4];
        public TinyMT tinyhorde = new TinyMT();
        public Data data = new Data();

        public void HordeTurn(uint[] current, bool oras, byte ratio, byte NPC, bool XY_TallGrass)
        {
            current.CopyTo(temp, 0);
            tinyhorde.nextState(temp);

            for (byte i = 0; i < NPC; i++)          //NPC Influence taken into account before everything else
                tinyhorde.nextState(temp);

            rand100 = tinyhorde.Rand(temp, 100);

            tinyhorde.nextState(temp);              //+1 to avoid using the same rand100 for Horde trigger and Sync
            sync = tinyhorde.Rand(temp, 100) < 50;  //Every horde, triggered by step, would be synced otherwise

            tinyhorde.nextState(temp);
            encounter = tinyhorde.Rand(temp, 100);

            trigger = encounter < ratio && rand100 < 5;

            if (XY_TallGrass)                       //Unknown reason
                tinyhorde.nextState(temp);

            results(oras);
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't makes use of memories)
        public void HordeHoney(uint[] current, bool oras)
        {
            current.CopyTo(temp, 0);
            tinyhorde.nextState(temp);
            rand100 = tinyhorde.Rand(temp, 100);

            for (byte i = 0; i < Bag_Advances; i++)
                tinyhorde.nextState(temp);

            sync = tinyhorde.Rand(temp, 100) < 50;
            trigger = true;

            results(oras);
        }

        public void results(bool oras)
        {
            tinyhorde.nextState(temp);
            slot = data.getSlot(tinyhorde.Rand(temp, 100), 2);

            HA = 0;
            tinyhorde.nextState(temp);
            if (tinyhorde.Rand(temp, 100) < 20)
            {
                tinyhorde.nextState(temp);
                HA = (byte)(tinyhorde.Rand(temp, 5) + 1);
            }

            tinyhorde.nextState(temp);
            if (oras)
            {
                for (byte i = 0; i < 5; i++)
                {
                    if (tinyhorde.Rand(temp, 100) < 40)
                        flutes[i] = 1;
                    else if (tinyhorde.Rand(temp, 100) < 70)
                        flutes[i] = 2;
                    else if (tinyhorde.Rand(temp, 100) < 90)
                        flutes[i] = 3;
                    else flutes[i] = 4;
                    tinyhorde.nextState(temp);
                }
            }

            tinyhorde.nextState(temp);
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
            }
        }
    }
}
