
namespace TinyFinder.Main
{
    internal class UISettings
    {

        #region Settings
        public bool oras, surfing, longGrass, citra, radarGrass, bonusMusic, movingHordes, moving, charm, exclusives;
        public bool triggerOnly;
        public ushort searchLevel, DexNumberFS;
        public byte method, fluteOption, fishingRod, calibration, party, ratio, sType, chain, advances;

        public int delayRand, targetFrame, gameCorrection, dexNavLevel, TargetValue, Grade, maxEggRand;

        public ushort[] currentSlots, specialSlots;
        public int[] currentLevels;
        #endregion

        #region Preferences
        public bool SpecificTID, SpecificSID;
        public ushort TargetTID, TargetSID;

        public int Target_Flute, Target_Potential;
        public bool Wants_Sync;
        public sbyte Target_Horde_HA;

        public bool Wants_Exclusives, Wants_Shiny, Wants_HA, Wants_EggMove, Wants_Boost, Show_Alt_EggMove;

        public bool[] Target_Slots = new bool[13];      // If a slot has been selected, the array index for that slot/number becomes true
        public byte[] Horde_Flutes = new byte[5];
        #endregion


        public bool CheckCommon(Index index, bool triggerCheck)
        {
            if (Target_Slots[index.slot] == true)                                     // Check if slot matches / user didn't select any slots
                if ((Wants_Sync && index.Sync) || !Wants_Sync)                        // Check if sync works / user doesn't care
                    if (index.trigger || !triggerCheck)                               // Check if the encounter is successful
                        if ((Target_Flute == index.flute) || Target_Flute == 0)       // Check if flute matches / user doesn't care
                            return true;
            return false;
        }

        public bool CheckHorde(Index index, bool triggerCheck, bool oras)
        {
      //if (CheckCommon(index, triggerCheck))     <- Not good because it causes problems with the 1st flute check
            if (index.trigger || !triggerCheck)
                if (Target_Slots[index.slot] == true)
                    if ((Target_Horde_HA == index.HordeHA && Target_Horde_HA != 0) || (Target_Horde_HA == 0 && index.HordeHA != 0) || Target_Horde_HA == -1)
                        if ((Wants_Sync && index.Sync) || !Wants_Sync)
                        {
                            if (oras)
                                for (int i = 0; i < 5; i++)
                                    if (Horde_Flutes[i] != index.flutes[i] && Horde_Flutes[i] != 0)
                                        return false;
                            return true;
                        }
            return false;
        }

        public bool CheckRadar(Index index, byte chain)
        {
            if (chain > 0)
                return index.shiny;
            return CheckCommon(index, false);
        }

        public bool CheckDexNav(Index index)
        {
            if (index.shiny || !Wants_Shiny)
                if (index.potential == Target_Potential || Target_Potential == 0)
                    if (index.DexNavHA || !Wants_HA)
                        if (CheckCommon(index, true))
                            if (index.eggRands.Count != 0 || !Wants_EggMove)
                                if (index.Boost || !Wants_Boost)
                                    if ((Wants_Exclusives && index.EnctrType == 2) || (index.EnctrType != 2 && !Wants_Exclusives))
                                        return true;
            return false;
        }

        public bool CheckID(Index index)
        {
            return (index.trainerID == TargetTID || !SpecificTID) && (index.secretID == TargetSID || !SpecificSID);
        }
    }
}
