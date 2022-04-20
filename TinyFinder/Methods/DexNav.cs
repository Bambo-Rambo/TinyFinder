namespace TinyFinder
{
    //https://github.com/wwwwwwzx/3DSRNGTool/blob/master/3DSRNGTool/Gen6/DexNav.cs
    class DexNav
    {
        public bool sync, boost, HA, eggMove, shiny, trigger, charm, exclusives, Trigger_only;
        public sbyte right, down;
        public byte levelBoost, flute, potential, rand100, noise, chain;
        public int TargetValue, CheckCount, Index, slot, EnctrType, slotType;    //EnctrType -> Normal/DexNav, slotType -> Land(12)/Water(5)
        public ushort searchlevel;
        public string encounter;
        public uint[] temp = new uint[4];

        private static TinyMT tinynav = new TinyMT();
        private uint Rand(ulong n) => (uint)((tinynav.Nextuint(temp) * n) >> 32);

        public void results(uint[] current)
        {
            current.CopyTo(temp, 0);
            rand100 = (byte)Rand(100);

            for (byte i = 0; i < noise; i++)
                tinynav.nextState(temp);

            //The chance of hitting a successful index is 50%
            //The actual chance of generating a patch successfully, depends on your current tile along with the patch's exact location
            //(20 steps/turns required )
            trigger = Rand(100) < 50;
            //rate = tinydexnav.Rand(temp, 100); //Apparently not necessary

            if (!trigger && Trigger_only)
                return;

            //The coordinates for a patch are generated inside the ring [-9, 9].
            //Currently unknown for caves, water and desert and varies for every tile
            right = down = 0;
            switch (Rand(4))
            {
                case 0:
                    right = (sbyte)(-9 + Rand(18));
                    down = (sbyte)-(-9 + Rand(3));
                    break;
                case 1:
                    right = (sbyte)(-9 + Rand(3));
                    down = (sbyte)-(-7 + Rand(14));
                    break;
                case 2:
                    right = (sbyte)(7 + Rand(3));
                    down = (sbyte)-(-7 + Rand(14));
                    break;
                case 3:
                    right = (sbyte)(-9 + Rand(18));
                    down = (sbyte)-(7 + Rand(3));
                    break;
            }

            //If DexNav exclusives exist for the target encounter type (Grass or Surf), then a DexNav slot has 30% chance of occuring
            EnctrType = Rand(100) < 30 && exclusives ? 2 : slotType;
            encounter = EnctrType == 2 ? "DexNav" : "Normal";

            /*The special Boost has 4% chance of occuring unless the current chain length is [4, 9, 14, 19, 24 etc]
            In this case, it is guaranteed and improves the chances of getting forced shiny indexes as well as higher perfect IV counts
            When occurs, it also guarantees a +10 Level Boost, an egg move, as well as at least 1 perfect IV*/
            boost = chain > 0 && (chain + 1) % 5 == 0 || Rand(100) < 4;

            //Self explanatory
            sync = (byte)Rand(100) < 50;

            //The rarity of the slots is reversed. The last slot for a given encounter type (Normal Grass [12], Normal Surf [5] and DexNav [3]),
            //is the most common and has 30% chance of occuring. If it doesn't, the game checks the previous slot whose chance is 30% as well etc
            for (slot = SlotNum[EnctrType]; slot > 0; slot--)
                if (Rand(100) < 30)
                    break;
            //Slot 2 is the most rare because a possible slot 0, becomes slot 1
            if (slot == 0)
                slot++;

            tinynav.nextState(temp);

            /*
             * The Grade's possible values are 6 (0-5) and depend on the current Search Level of the Pokemon
             * It affects HA, Potential, Egg Move, Shininess and the Held Item which is not calculated here
             * It is being used to get the rate of something
             * The random generated number should be lower than the rate's value in order to trigger the event
             */
            byte Grade = GetGrade(searchlevel);

            /*
             * The Level of the Pokemon increases by 1 for every 5 added to the chain
             * +1 when 5 =< chain < 10
             * +2 when 10 =< chain < 15 etc
             * +10 also whenever (chain + 1) % 5 == 0 as explained above
             */
            levelBoost = (byte)(chain / 5 + (boost ? 10 : 0));

            /*
             * White Flute chances:
             * 1 => 40%
             * 2 => 30%
             * 3 => 20%
             * 4 => 10%
             */
            flute = getFlute(Rand(100));


            HA = Rand(100) < HARate[Grade];

            //Index's final value will be the number of perfect IV count (max 3)
            for (Index = 2; Index >= 0; Index--)
                if (Rand(100) < IVRate[3 * Grade + Index])
                    break;
            //If boost has been triggered, +2 perfect IVs, otherwise +1
            Index += boost ? 2 : 1;                     //This guarantees that the value will never be < 0
            potential = (byte)(Index < 3 ? Index : 3);  //This guarantees that the value will never be > 3

            eggMove = Rand(100) < EggMoveRate[Grade] || boost;

            tinynav.nextState(temp); //Held Item, not calculated

            /*
             * The game does various RNG calls (checks) and compares the random generated number with the Target Value
             * The Target Value depends on the current Search Level
             * If random number < Target Value / 100 => Shiny
             * The number of the total checks (RNG calls) depends on the current circumstances
             */

            CheckCount = charm ? 3 : 1;     //+3 checks if the user has the shiny charm otherwise +1
            if (boost)
                CheckCount += 4;            //+4 checks if the boost has been triggered
            if (chain == 49)
                CheckCount += 5;            //+5 checks if chain length = 49
            else if (chain == 99)
                CheckCount += 10;           //+10 checks if chain length = 99

            if (searchlevel > 200)
                TargetValue = searchlevel + 600;
            else if (searchlevel > 100)
                TargetValue = 2 * searchlevel + 400;
            else
                TargetValue = 6 * searchlevel;

            for (int i = 0; i < CheckCount; i++)
            {
                if (Rand(10000) < TargetValue * 0.01)
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

        public static byte[] GradeRange = { 5, 10, 25, 50, 100 }; //These numbers refer to the current Search Level
        public static sbyte[] SlotNum = { 12, 5, 3 }; // Grass / Surf / DexNav
        public static byte[] HARate = { 0, 0, 5, 15, 20, 25 }; // dword_7E6860[6]
        public static byte[] IVRate = // dword_7E6890[18]
        {
            0,0,0,
            10,0,0,
            15,10,0,
            20,15,5,
            15,20,5,
            10,25,10,
        };

        public static byte[] EggMoveRate = { 20, 50, 55, 60, 65, 80 }; // dword_7E6878[6]
        public static byte[] HeldItemRate = // byte_7E68D8[12]
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
