namespace TinyFinder
{
    class Wild
    {
        //Normal, Fishing, Friend Safari
        //Rock Smash
        //Swooping
        private TinyMT tinywild = new TinyMT();
        private Data data = new Data();
        private uint[] temp = new uint[4];
        public byte slot, encounter, flute, rand100, ratio, slotType, NPC; //public byte item;
        public bool Sync, trigger, oras, HasHordes, XY_TallGrass;

        //https://github.com/Bambo-Rambo/TinyFinder/blob/main/Notes.md#normal-wild---hordes-connection
        public void results(uint[] current)
        {
            current.CopyTo(temp, 0);

            for (byte i = 0; i < NPC; i++)          //NPC Influence taken into account before everything else
                tinywild.nextState(temp);

            tinywild.nextState(temp);
            rand100 = tinywild.Rand(temp, 100);     //If (rand100 < 5) -> Horde

            if (HasHordes)                          //+1 to avoid using the same rand100 for Horde trigger and Sync
                tinywild.nextState(temp);           //Every horde, triggered by step, would be synced otherwise

            Sync = tinywild.Rand(temp, 100) < 50;

            tinywild.nextState(temp);
            encounter = tinywild.Rand(temp, 100);

            trigger = encounter < ratio && (!HasHordes || rand100 > 4);

            if (XY_TallGrass)                       //Unknown reason
                tinywild.nextState(temp);

            tinywild.nextState(temp);
            slot = data.getSlot(tinywild.Rand(temp, 100), slotType);

            if (oras)
                Findflute();
        }

        public void RockSmash(uint[] current)
        {
            current.CopyTo(temp, 0);

            tinywild.nextState(temp);
            rand100 = tinywild.Rand(temp, 100);
            encounter = tinywild.Rand(temp, 3);

            tinywild.nextState(temp);
            Sync = tinywild.Rand(temp, 100) < 50;

            tinywild.nextState(temp);
            slot = data.getSlot(tinywild.Rand(temp, 100), 3);

            if (oras)
                Findflute();
        }

        public void Swooping(uint[] current)
        {
            current.CopyTo(temp, 0);
            rand100 = tinywild.Rand(temp, 100);

            tinywild.nextState(temp);
            slot = data.getSlot(tinywild.Rand(temp, 100), 0);

            tinywild.nextState(temp);
            Sync = tinywild.Rand(temp, 100) < 50;

        }

        public void Findflute()
        {
            tinywild.nextState(temp);
            if (tinywild.Rand(temp, 100) < 40)
                flute = 1;
            else if (tinywild.Rand(temp, 100) < 70)
                flute = 2;
            else if (tinywild.Rand(temp, 100) < 90)
                flute = 3;
            else flute = 4;

            /*tinywild.nextState(temp);
            tinywild.nextState(temp);
            if (tinywild.Rand(temp, 100) < 50)
                item = 50;
            else if (tinywild.Rand(temp, 100) < 55)
                item = 5;
            else if (tinywild.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;*/
        }
    }
}
