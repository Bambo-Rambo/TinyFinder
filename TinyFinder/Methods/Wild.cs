namespace TinyFinder
{
    class Wild : Index
    {
        //Normal, Fishing, Friend Safari
        //Rock Smash
        //Swooping

        //https://github.com/Bambo-Rambo/TinyFinder/blob/main/Notes.md#normal-wild---hordes-connection
        public void GenerateIndex(uint[] currentState, byte ratio, bool oras, bool MayStepHorde, bool XY_TallGrass)
        {
            currentState.CopyTo(temp, 0);

            for (byte i = 0; i < Noise; i++)                //NPC Noise taken into account before everything else
                Advance();

            rand100 = RandCall(100);                        //If (rand100 < 5) -> Horde

            if (MayStepHorde)                               //+1 to avoid using the same rand100 for Horde trigger and Sync
                Advance();                                  //Every horde, triggered by step, would be synced otherwise

            Sync = CurrentRand(100) < 50;

            encounter = RandCall(100);

            trigger = encounter < ratio && (!MayStepHorde || rand100 > 4);

            if (XY_TallGrass)                               //Unknown reason
                Advance();

            slot = data.getSlot(RandCall(100), slotType);

            if (oras)
                flute = Findflute();
        }

        public void RockSmash(uint[] currentState, bool oras)
        {
            currentState.CopyTo(temp, 0);

            rand100 = RandCall(100);

            encounter = CurrentRand(3);

            Sync = RandCall(100) < 50;

            slot = data.getSlot(RandCall(100), 4);

            if (oras)
                flute = Findflute();
        }

        public void Swooping(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);

            rand100 = CurrentRand(100);

            slot = data.getSlot(RandCall(100), 0);

            Sync = RandCall(100) < 50;

        }

        public byte Findflute()
        {
            Advance();

            if (CurrentRand(100) < 40)
                return 1;

            else if (CurrentRand(100) < 70)
                return 2;

            else if (CurrentRand(100) < 90)
                return 3;

            else 
                return 4;


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