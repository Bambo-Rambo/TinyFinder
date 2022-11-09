using TinyFinder.Main;

namespace TinyFinder
{
    //https://github.com/wwwwwwzx/3DSRNGTool/blob/master/3DSRNGTool/Gen6/DexNav.cs
    class DexNav : Index
    {
        private uint RandUINT(int n) => (uint)((tiny.Nextuint(temp) * n) >> 32);
        public int TargetValue, CheckCount, index;    //EnctrType -> Normal/DexNav, slotType -> Land(12)/Water(5)

        public DexNav(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);
            rand100 = RandCall(100);

            for (byte i = 0; i < current.noise; i++)
                Advance();

            trigger = RandCall(100) < 50;

            if (!trigger && current.triggerOnly)       // Save some time here
                return;

            //The coordinates for a patch are generated inside the ring [-9, 9].
            //Currently unknown for caves, water and desert and varies for every tile
            switch (RandCall(4))
            {
                case 0:
                    right = (sbyte)(-9 + RandCall(18));
                    up = (sbyte)-(-9 + RandCall(3));
                    break;
                case 1:
                    right = (sbyte)(-9 + RandCall(3));
                    up = (sbyte)-(-7 + RandCall(14));
                    break;
                case 2:
                    right = (sbyte)(7 + RandCall(3));
                    up = (sbyte)-(-7 + RandCall(14));
                    break;
                case 3:
                    right = (sbyte)(-9 + RandCall(18));
                    up = (sbyte)-(7 + RandCall(3));
                    break;
            }

            //If DexNav exclusives exist for the target encounter type (Grass or Surf), then a DexNav slot has 30% chance of occuring
            EnctrType = RandCall(100) < 30 && current.exclusives ? 2 : current.sType;
            Type = EnctrType == 2 ? "DexNav" : "Normal";

            /*The special Boost has 4% chance of occuring unless the current chain length is [4, 9, 14, 19, 24 etc]
            In this case, it is guaranteed and improves the chances of getting forced shiny indexes as well as higher perfect IV counts
            When occurs, it also guarantees a +10 Level Boost, an egg move, as well as at least 1 perfect IV*/
            Boost = current.chain > 0 && (current.chain + 1) % 5 == 0 || RandCall(100) < 4;

            Sync = RandCall(100) < 50;

            //The rarity of the slots is reversed. The last slot for a given encounter type (Normal Grass [12], Normal Surf [5] and DexNav [3]),
            //is the most common and has 30% chance of occuring. If it doesn't, the game checks the previous slot whose chance is 30% as well etc
            for (slot = SlotNum[EnctrType]; slot > 0; slot--)
                if (RandCall(100) < 30)
                    break;
            //Slot 2 is the most rare because a possible slot 0, becomes slot 1
            if (slot == 0)
                slot++;

            Advance();

            /*
             * The Grade's possible values are 6 (0-5) and depend on the current Search Level of the Pokemon
             * It affects HA, Potential, Egg Move, Shininess and the Held Item which is not calculated here
             * It is being used to get the rate of something
             * The random generated number should be lower than the rate's value in order to trigger the event
             */
            byte Grade = GetGrade(current.searchLevel);

            /*
             * The Level of the Pokemon increases by 1 for every 5 added to the chain
             * +1 when 5 =< chain < 10
             * +2 when 10 =< chain < 15 etc
             * +10 also whenever (chain + 1) % 5 == 0 as explained above
             */
            LevelBoost = current.chain / 5 + (Boost ? 10 : 0);

            /*
             * White Flute chances:
             * 1 => 40%
             * 2 => 30%
             * 3 => 20%
             * 4 => 10%
             */
            flute = getFlute(RandCall(100));

            DexNavHA = RandCall(100) < HARate[Grade];

            //index's final value will be the number of perfect IV count (max 3)
            for (index = 2; index >= 0; index--)
                if (RandCall(100) < IVRate[3 * Grade + index])
                    break;
            //If boost has been triggered, +2 perfect IVs, otherwise +1
            index += Boost ? 2 : 1;                     //This guarantees that the value will never be < 0
            potential = (byte)(index < 3 ? index : 3);  //This guarantees that the value will never be > 3

            eggMove = RandCall(100) < EggMoveRate[Grade] || Boost;


            int tmp = RandCall(100);
            for (index = 0; index < 2; index++)
            {
                tmp -= HeldItemRate[Grade * 2 + index];
                //if (CompoundEyes)
                    //tmp -= 5;
                if (tmp < 0)
                    break;
            }
            if (index >= 2)
                index = 3;
            itemSlot = index;// == 0 ? "Common" : index == 1 ? "Rare" : "-";


            /*
             * The game does various RNG calls (checks) and compares the random generated number with the Target Value
             * The Target Value depends on the current Search Level
             * If random number < Target Value / 100 => Shiny
             * The number of the total checks (RNG calls) depends on the current circumstances
             */

            CheckCount = current.charm ? 3 : 1;     //+3 checks if the user has the shiny charm otherwise +1
            if (Boost)
                CheckCount += 4;            //+4 checks if the boost has been triggered
            if (current.chain == 49)
                CheckCount += 5;            //+5 checks if chain length = 49
            else if (current.chain == 99)
                CheckCount += 10;           //+10 checks if chain length = 99

            if (current.searchLevel > 200)
                TargetValue = current.searchLevel + 600;
            else if (current.searchLevel > 100)
                TargetValue = 2 * current.searchLevel + 400;
            else
                TargetValue = 6 * current.searchLevel;

            for (int i = 0; i < CheckCount; i++)
            {
                if (RandUINT(10000) < TargetValue * 0.01)
                {
                    shiny = true;
                    return;                  //No more checks if a shiny index is found obviously
                }
            }
            shiny = false;
        }

        //https://bulbapedia.bulbagarden.net/wiki/DexNav#Benefits

        public static byte getFlute(ulong Rand100)
        {
            if (Rand100 < 40)
                return 1;
            if (Rand100 < 70)
                return 2;
            if (Rand100 < 90)
                return 3;
            return 4;
        }

        public static byte GetGrade(ushort searchlevel)
        {
            for (byte g = 0; g < 5; g++)
                if (searchlevel < GradeRange[g])
                    return g;
            return 5;
        }

        public static byte[] GradeRange = { 5, 10, 25, 50, 100 };   //These numbers refer to the current Search Level
        public static byte[] SlotNum = { 12, 5, 3 };                // Grass / Surf / DexNav
        public static byte[] HARate = { 0, 0, 5, 15, 20, 25 };      // dword_7E6860[6]
        public static byte[] IVRate =                               // dword_7E6890[18]
        {
            0,0,0,
            10,0,0,
            15,10,0,
            20,15,5,
            15,20,5,
            10,25,10,
        };

        public static byte[] EggMoveRate = { 20, 50, 55, 60, 65, 80 };  // dword_7E6878[6]
        public static byte[] HeldItemRate =                             // byte_7E68D8[12]
        {
            40,10,
            40,10,
            45,15,
            50,20,
            50,20,
            50,30,
        };
    }
}