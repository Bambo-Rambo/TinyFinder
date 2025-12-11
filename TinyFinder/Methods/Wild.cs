using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TinyFinder.Controls;
using TinyFinder.Main;

namespace TinyFinder
{
    class Wild : Index
    {
        public Wild(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);

            //slotType = current.sType;
            switch (current.encounterKey)
            {
                case EnctrKey.Wild:
                case EnctrKey.FS:
                    NormalWild(current);
                    break;

                case EnctrKey.Fishing:

                    FishingWild(current);
                    break;

                case EnctrKey.RockSmash:

                    RockSmash(current);
                    break;

                case EnctrKey.Honey:
                    HoneyWild(current);
                    break;

                case EnctrKey.Ambush:

                    Ambush();
                    break;
            }
        }

        public void NormalWild(UISettings current)
        {
            for (int i = 0; i < current.calibration; i++)           //NPC influence taken into account before everything else
                AdvanceOnce();

            rand100 = RandCall(100);                                //If (rand100 < 5) -> Horde

            if (current.possibleHorde)                               //+1 to avoid using the same rand100 for Horde trigger and Sync
                AdvanceOnce();                                      //Every horde, triggered by step, would be synced otherwise

            Sync = Current(100) < 50;

            encounter = RandCall(100);
            trigger = encounter < current.ratio && (!current.possibleHorde || rand100 > 4);

            if (current.radarGrass)
                AdvanceOnce();

            slot = data.getSlot(RandCall(100), current.sType);

            if (current.oras)
                flute = Findflute();

            AdvanceOnce();
            itemSlot = FindWildItem();
        }

        public void FishingWild(UISettings current)
        {
            rand100 = Current(100);

            BlinkSystem totalBlinks = new BlinkSystem(this);
            totalBlinks.Apply(current);

            NormalWild(current);
        }

        public void RockSmash(UISettings current)
        {
            rand100 = Current(100);

            BlinkSystem totalBlinks = new BlinkSystem(this);
            totalBlinks.Apply(current);

            encounter = RandCall(3);
            trigger = encounter == 0;       // 0 => Pokemon, 1 => item, 2 => nothing

            Sync = RandCall(100) < 50;

            slot = data.getSlot(RandCall(100), 4);

            if (current.oras)
                flute = Findflute();

            AdvanceOnce();
            itemSlot = FindWildItem();
        }

        public void HoneyWild(UISettings current)
        {
            rand100 = Current(100);

                                                            // 3 if Cave / ORAS underwater
            for (int i = 0; i < current.advances; i++)      // 27 if XY
                AdvanceOnce();                              // 15 if ORAS
                                                            // 6 if ORAS Magma/Aqua Hideout

            BlinkSystem totalBlinks = new BlinkSystem(this);
            totalBlinks.Apply(current);

            Sync = RandCall(100) < 50;

            slot = data.getSlot(RandCall(100), current.sType);

            if (current.oras)
                flute = Findflute();

            AdvanceOnce();
            itemSlot = FindWildItem();
        }

        public void Ambush()
        {
            //rand100 = Current(100);

            slot = data.getSlot(RandCall(100), 0);

            rand100 = Current(100);     // Show the slot rand (for testing)

            Sync = RandCall(100) < 50;

            AdvanceOnce();
            itemSlot = FindWildItem();
        }

    }

}