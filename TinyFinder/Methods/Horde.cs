using System.Linq;
using TinyFinder.Main;

namespace TinyFinder
{
    class Horde : Index
    {
        public Horde(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);

            if (current.moving)
                HordeTurn(current.oras, current.radarGrass, current.ratio, current.noise, current.triggerOnly);
            else
                HordeHoney(current.oras, current.advances);
        }

        public void HordeTurn(bool oras, bool XY_TallGrass, byte ratio, byte NPC, bool Trigger_only)
        {
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

            FinalizeHorde(oras);
        }

        //(Sweet Scent is different - probably ignores the party number since it doesn't make use of memories)
        public void HordeHoney(bool oras, byte TotalAdvances)
        {
            rand100 = RandCall(100);
                                                            // 3 if Cave / ORAS underwater
            for (byte i = 0; i < TotalAdvances; i++)        // 27 if XY
                Advance();                                  // 15 if ORAS

            Sync = CurrentRand(100) < 50;

            FinalizeHorde(oras);
        }

        public void FinalizeHorde(bool oras)
        {
            slot = data.getSlot(RandCall(100), 3);

            if (RandCall(100) < 20)
                HordeHA = (byte)(RandCall(5) + 1);
            else
                HordeHA = 0;

            if (oras)
                for (byte i = 0; i < 5; i++)
                    flutes[i] = Findflute();

            for (byte i = 0; i < 5; i++)
                itemSlots[i] = FindItem();
        }

    }
}