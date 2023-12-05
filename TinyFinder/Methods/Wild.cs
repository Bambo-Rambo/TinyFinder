using TinyFinder.Main;

namespace TinyFinder
{
    class Wild : Index
    {
        public Wild(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);

            //slotType = current.sType;
            switch (current.method)
            {
                case 1:                 // Normal Wild
                    NormalWild(current.ratio, current.calibration, current.oras, current.movingHordes, current.radarGrass, current.sType);
                    break;

                case 2:                 // Fishing

                    NormalWild(current.ratio, 0, current.oras, false, false, 3);
                    break;

                case 3:                 // Rock Smash

                    RockSmash(current.oras);
                    break;

                case 5:                 // Honey Wild
                    HoneyWild(current.oras, current.advances, current.sType);
                    break;

                case 7:                 // Friend Safari
                    NormalWild(current.ratio, 0, false, false, false, current.sType);
                    break;

                case 8:                 // Swooping

                    Swooping();
                    break;
            }
        }

        //https://github.com/Bambo-Rambo/TinyFinder/blob/main/Notes.md#normal-wild---hordes-connection
        public void NormalWild(byte ratio, byte Calibration, bool oras, bool MayStepHorde, bool RadarGrass, byte SlotType)
        {
            for (byte i = 0; i < Calibration; i++)          //NPC influence taken into account before everything else
                AdvanceOnce();

            rand100 = RandCall(100);                        //If (rand100 < 5) -> Horde

            if (MayStepHorde)                               //+1 to avoid using the same rand100 for Horde trigger and Sync
                AdvanceOnce();                              //Every horde, triggered by step, would be synced otherwise

            Sync = CurrentRand(100) < 50;

            encounter = RandCall(100);
            trigger = encounter < ratio && (!MayStepHorde || rand100 > 4);

            if (RadarGrass)
                AdvanceOnce();

            slot = data.getSlot(RandCall(100), SlotType);

            if (oras)
                flute = Findflute();

            itemSlot = FindItem();
        }

        public void RockSmash(bool oras)
        {
            rand100 = RandCall(100);

            encounter = CurrentRand(3);
            trigger = encounter == 0;       // 0 => Pokemon, 1 => item, 2 => nothing

            Sync = RandCall(100) < 50;

            slot = data.getSlot(RandCall(100), 4);

            if (oras)
                flute = Findflute();

            itemSlot = FindItem();
        }

        public void HoneyWild(bool oras, byte advances, byte SlotType)
        {
            rand100 = RandCall(100);

            // 3 if Cave / ORAS underwater
            for (byte i = 0; i < advances; i++)       // 27 if XY
                AdvanceOnce();                            // 15 if ORAS
                                                      // 6 if ORAS Magma/Aqua Hideout

            Sync = CurrentRand(100) < 50;

            slot = data.getSlot(RandCall(100), SlotType);

            if (oras)
                flute = Findflute();

            itemSlot = FindItem();
        }

        public void Swooping()
        {
            //rand100 = CurrentRand(100);

            slot = data.getSlot(RandCall(100), 0);

            rand100 = CurrentRand(100);     // Show the slot rand (for testing)

            Sync = RandCall(100) < 50;

            itemSlot = FindItem();
        }

        public byte Findflute()
        {
            AdvanceOnce();

            if (CurrentRand(100) < 40)
                return 1;

            else if (CurrentRand(100) < 70)
                return 2;

            else if (CurrentRand(100) < 90)
                return 3;

            else
                return 4;

        }

        public byte FindItem()
        {
            AdvanceOnce();
            AdvanceOnce();

            if (CurrentRand(100) < 50)
                return 0;

            else if (CurrentRand(100) < 55)
                return 1;

            else
                return 2;
        }

    }

}