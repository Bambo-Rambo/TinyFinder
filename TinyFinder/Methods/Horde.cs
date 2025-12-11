using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TinyFinder.Controls;
using TinyFinder.Main;

namespace TinyFinder
{
    class Horde : Index
    {
        public Horde(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);

            if (current.moving)
                HordeTurn(current.oras, current.radarGrass, current.ratio, current.calibration, current.triggerOnly);
            else
                HordeHoney(current);
        }

        public void HordeTurn(bool oras, bool XY_TallGrass, int ratio, int NPC, bool Trigger_only)
        {
            Advance(NPC);                           //NPC Influence taken into account before everything else

            rand100 = RandCall(100);

            //+1 in order to avoid using the same rand100 for Horde trigger check and Sync
            //Every horde, triggered by step, would be synced otherwise
            Sync = RandCall(100) < 50;

            encounter = RandCall(100);

            trigger =  rand100 < 5 && encounter < ratio;

            if (!trigger && Trigger_only)
                return;

            if (XY_TallGrass)                       //Unknown reason
                AdvanceOnce();

            FinalizeHorde(oras);
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't make use of memories)
        public void HordeHoney(UISettings current)
        {
            rand100 = Current(100);
                                                // 3 if Cave / ORAS underwater
            Advance(current.advances);          // 27 if XY
                                                // 15 if ORAS

            BlinkSystem totalBlinks = new BlinkSystem(this);
            totalBlinks.Apply(current);

            Sync = RandCall(100) < 50;
            FinalizeHorde(current.oras);
        }

        public void FinalizeHorde(bool oras)
        {
            slot = data.getSlot(RandCall(100), 3);

            if (RandCall(100) < 20)
                HordeHA = RandCall(5) + 1;
            else
                HordeHA = 0;

            if (oras)
                for (int i = 0; i < 5; i++)
                    flutes[i] = Findflute();

            AdvanceOnce();
            for (int i = 0; i < 5; i++)
                itemSlots[i] = FindWildItem();

        }
    }
}