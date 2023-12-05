using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TinyFinder.Main;
using TinyFinder.Properties;

namespace TinyFinder
{
    //https://github.com/wwwwwwzx/3DSRNGTool/blob/master/3DSRNGTool/Gen6/DexNav.cs
    class DexNav : Index
    {
        public int CheckCount, index;

        public DexNav(List<uint> rngList, UISettings current)
        {
            rand100 = Current(rngList, 100);

            Advance(current.calibration);

            trigger = Rand(rngList, 100) < 50;

            if (!trigger && current.triggerOnly)
                return;

            switch (Rand(rngList, 4))
            {
                case 0:
                    right = (sbyte)(-9 + Rand(rngList, 18));
                    up = (sbyte)-(-9 + Rand(rngList, 3));
                    break;
                case 1:
                    right = (sbyte)(-9 + Rand(rngList, 3));
                    up = (sbyte)-(-7 + Rand(rngList, 14));
                    break;
                case 2:
                    right = (sbyte)(7 + Rand(rngList, 3));
                    up = (sbyte)-(-7 + Rand(rngList, 14));
                    break;
                case 3:
                    right = (sbyte)(-9 + Rand(rngList, 18));
                    up = (sbyte)-(7 + Rand(rngList, 3));
                    break;
            }


            EnctrType = Rand(rngList, 100) < 30 && current.exclusives ? 2 : current.sType;
            Type = EnctrType == 2 ? "DexNav" : "Normal";

            Boost = current.chain > 0 && (current.chain + 1) % 5 == 0 || Rand(rngList, 100) < 4;

            Sync = Rand(rngList, 100) < 50;

            for (slot = SlotNum[EnctrType]; slot > 0; slot--)
                if (Rand(rngList, 100) < 30)
                    break;
            if (slot == 0)
                slot++;

            LevelRand = rngList[++pointer];

            //byte Grade = GetGrade(current.searchLevel);

            LevelBoost = current.chain / 5 + (Boost ? 10 : 0);

            flute = Findflute(rngList);

            DexNavHA = Rand(rngList, 100) < HARate[current.Grade];

            for (index = 2; index >= 0; index--)
                if (Rand(rngList, 100) < IVRate[3 * current.Grade + index])
                    break;
            index += Boost ? 2 : 1;
            potential = (byte)(index < 3 ? index : 3);

            bool HasEggMove = Rand(rngList, 100) < EggMoveRate[current.Grade] || Boost;

            int tmp = Rand(rngList, 100);
            for (index = 0; index < 2; index++)
            {
                tmp -= HeldItemRate[current.Grade * 2 + index];
                //if (CompoundEyes)
                    //tmp -= 5;
                if (tmp < 0)
                    break;
            }
            if (index >= 2)
                index = 3;
            itemSlot = index;


            CheckCount = current.charm ? 3 : 1;
            if (Boost)
                CheckCount += 4;
            if (current.chain == 49)
                CheckCount += 5;
            else if (current.chain == 99)
                CheckCount += 10;

            // We calculate the Target Value only once in FindResults.cs
            /*if (current.searchLevel > 200)
                current.TargetValue = current.searchLevel + 600;
            else if (current.searchLevel > 100)
                current.TargetValue = 2 * current.searchLevel + 400;
            else
                current.TargetValue = 6 * current.searchLevel;*/


            // It would make sense to break the loop when a shiny is found but this is not the case,
            // all rand calls must happen, otherwise egg move will be wrong
            for (int i = 0; i < CheckCount; i++)
                if (RandUint(rngList, 10000) < current.TargetValue * 0.01)
                    shiny = true;

            //Advance(1); // I prefer eggRands[1] to be the first element
            if (HasEggMove)
                for (int i = 0; i <= current.maxEggRand; i++)
                    eggRands.Add(rngList[pointer + i]);

        }

        //https://bulbapedia.bulbagarden.net/wiki/DexNav#Benefits


        /*public static byte GetGrade(ushort searchlevel)
        {
            for (byte g = 0; g < 5; g++)
                if (searchlevel < GradeRange[g])
                    return g;
            return 5;
        }
        public static byte[] GradeRange = { 5, 10, 25, 50, 100 };   //These numbers refer to the current Search Level*/


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