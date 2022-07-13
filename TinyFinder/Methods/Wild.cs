namespace TinyFinder
{
    class Wild
    {
        //Normal, Fishing, Friend Safari
        //Rock Smash
        //Swooping
        private TinyMT tiny = new TinyMT();
        private Data data = new Data();
        private uint[] temp = new uint[4];
        public byte slot, encounter, flute, rand100, ratio, slotType, Noise; //public byte item;
        public bool Sync, trigger, oras, CanStepHorde, XY_TallGrass;

        //https://github.com/Bambo-Rambo/TinyFinder/blob/main/Notes.md#normal-wild---hordes-connection
        public void GenerateIndex(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);

            for (byte i = 0; i < Noise; i++)          //NPC Influence taken into account before everything else
                tiny.nextState(temp);

            tiny.nextState(temp);
            rand100 = tiny.Rand(temp, 100);         //If (rand100 < 5) -> Horde

            if (CanStepHorde)                       //+1 to avoid using the same rand100 for Horde trigger and Sync
                tiny.nextState(temp);               //Every horde, triggered by step, would be synced otherwise

            Sync = tiny.Rand(temp, 100) < 50;

            tiny.nextState(temp);
            encounter = tiny.Rand(temp, 100);

            trigger = encounter < ratio && (!CanStepHorde || rand100 > 4);

            if (XY_TallGrass)                       //Unknown reason
                tiny.nextState(temp);

            tiny.nextState(temp);
            slot = data.getSlot(tiny.Rand(temp, 100), slotType);

            if (oras)
                Findflute();
        }

        public void RockSmash(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);

            tiny.nextState(temp);
            rand100 = tiny.Rand(temp, 100);
            encounter = tiny.Rand(temp, 3);

            tiny.nextState(temp);
            Sync = tiny.Rand(temp, 100) < 50;

            tiny.nextState(temp);
            slot = data.getSlot(tiny.Rand(temp, 100), 4);

            if (oras)
                Findflute();
        }

        public void Swooping(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);
            rand100 = tiny.Rand(temp, 100);

            tiny.nextState(temp);
            slot = data.getSlot(tiny.Rand(temp, 100), 0);

            tiny.nextState(temp);
            Sync = tiny.Rand(temp, 100) < 50;

        }

        public void Findflute()
        {
            tiny.nextState(temp);
            if (tiny.Rand(temp, 100) < 40)
                flute = 1;
            else if (tiny.Rand(temp, 100) < 70)
                flute = 2;
            else if (tiny.Rand(temp, 100) < 90)
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
