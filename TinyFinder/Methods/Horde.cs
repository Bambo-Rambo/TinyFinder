using System.Collections.Generic;
using System.Linq;
using TinyFinder.Main;

namespace TinyFinder
{
    class Horde : Index
    {
        public Horde(List<uint> rngList, UISettings current)
        {
            if (current.moving)
                HordeTurn(rngList, current.oras, current.radarGrass, current.ratio, current.calibration, current.triggerOnly);
            else
                HordeHoney(rngList, current.oras, current.advances);
        }

        public void HordeTurn(List<uint> rngList, bool oras, bool XY_TallGrass, byte ratio, byte NPC, bool Trigger_only)
        {
            Advance(NPC);                           //NPC Influence taken into account before everything else

            rand100 = Current(rngList, 100);

            //+1 in order to avoid using the same rand100 for Horde trigger check and Sync
            //Every horde, triggered by step, would be synced otherwise
            Sync = Rand(rngList, 100) < 50;

            encounter = Rand(rngList, 100);

            trigger =  rand100 < 5 && encounter < ratio;

            if (!trigger && Trigger_only)
                return;

            if (XY_TallGrass)                       //Unknown reason
                Advance(1);

            FinalizeHorde(rngList, oras);
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't make use of memories)
        public void HordeHoney(List<uint> rngList, bool oras, byte TotalAdvances)
        {
            rand100 = Current(rngList, 100);
                                        // 3 if Cave / ORAS underwater
            Advance(TotalAdvances);     // 27 if XY
                                        // 15 if ORAS
            Sync = Current(rngList, 100) < 50;

            FinalizeHorde(rngList, oras);
        }

        public void FinalizeHorde(List<uint> rngList, bool oras)
        {
            slot = data.getSlot(Rand(rngList, 100), 3);

            if (Rand(rngList, 100) < 20)
                HordeHA = (byte)(Rand(rngList, 5) + 1);
            else
                HordeHA = 0;

            if (oras)
                for (byte i = 0; i < 5; i++)
                    flutes[i] = Findflute(rngList);

            for (byte i = 0; i < 5; i++)
                itemSlots[i] = FindItem(rngList);
        }

    }
}