using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TinyFinder.Controls;
using TinyFinder.Main;
using TinyFinder.Properties;
namespace TinyFinder
{
    //https://github.com/wwwwwwzx/3DSRNGTool/blob/master/3DSRNGTool/Gen6/DexNav.cs
    class DexNav : Index
    {
        public int CheckCount, index;

        public static int[] SlotNum = { 12, 5, 3 };                // Grass / Surf / DexNav
        public static int[] HARate = { 0, 0, 5, 15, 20, 25 };      // dword_7E6860[6]
        public static int[] IVRate =                               // dword_7E6890[18]
        {
            0,0,0,
            10,0,0,
            15,10,0,
            20,15,5,
            15,20,5,
            10,25,10,
        };

        public static int[] EggMoveRate = { 20, 50, 55, 60, 65, 80 };  // dword_7E6878[6]
        public static int[] HeldItemRate =                             // byte_7E68D8[12]
        {
            40,10,
            40,10,
            45,15,
            50,20,
            50,20,
            50,30,
        };

        public static int[] SearchLevelTable = { 5, 10, 25, 50, 100 }; //https://bulbapedia.bulbagarden.net/wiki/DexNav#Benefits
        public static int GetGrade(ushort searchlevel)
        {
            for (int g = 0; g < 5; g++)
                if (searchlevel < SearchLevelTable[g])
                    return g;
            return 5;
        }

        public static int GetTargetValue(ushort searchlevel)
        {
            if (searchlevel > 200)
                return searchlevel + 600;
            else if (searchlevel > 100)
                return 2 * searchlevel + 400;
            return 6 * searchlevel;
        }

        public DexNav(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);
            rand100 = Current(100);

            if (current.DNsearching)
            {
                BlinkSystem totalBlinks = new BlinkSystem(this);
                totalBlinks.Apply(current);
            }
            else
            {
                AdvanceOnce();
                Advance(current.calibration);
                
                trigger = RandCall(100) < 50;
                if (!trigger && current.triggerOnly)
                    return;
            }
            
            switch (RandCall(4))
            {
                case 0:
                    right = -9 + RandCall(18);
                    up = -(-9 + RandCall(3));
                    break;
                case 1:
                    right = -9 + RandCall(3);
                    up = -(-7 + RandCall(14));
                    break;
                case 2:
                    right = 7 + RandCall(3);
                    up = -(-7 + RandCall(14));
                    break;
                case 3:
                    right = -9 + RandCall(18);
                    up = -(7 + RandCall(3));
                    break;
            }

            // If search method, current.exclusives is true when selected species is exclusive
            // If moving method, current.exclusives is true when target species is exclusive
            // This RandCall always happens regardless
            EnctrType = ((RandCall(100) < 30) || current.DNsearching) && current.exclusives ? 2 : current.sType;

            Boost = current.chain > 0 && (current.chain + 1) % 5 == 0 || RandCall(100) < 4;

            Sync = RandCall(100) < 50;

            if (!current.DNsearching)
            {
                for (slot = SlotNum[EnctrType]; slot > 0; slot--)
                    if (RandCall(100) < 30)
                        break;
                if (slot == 0)
                    slot++;
            }
                
            LevelRand = RandU32();

            LevelBoost = current.chain / 5 + (Boost ? 10 : 0);

            flute = Findflute();

            DexNavHA = RandCall(100) < HARate[current.Grade];

            for (index = 2; index >= 0; index--)
                if (RandCall(100) < IVRate[3 * current.Grade + index])
                    break;
            index += Boost ? 2 : 1;
            potential = index < 3 ? index : 3;

            bool HasEggMove = RandCall(100) < EggMoveRate[current.Grade] || Boost;

            int tmp = RandCall(100);
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

            // It would make sense to break the loop when a shiny is found but this is not the case,
            // all rand calls must happen, otherwise egg move will be wrong
            for (int i = 0; i < CheckCount; i++)
                if (RandCallUint(10000) < current.TargetValue * 0.01)
                    shiny = true;

            if (HasEggMove)
                for (uint i = 0; i <= current.maxEggRand; i++)
                {
                    eggRands.Add(CurrentU32());
                    AdvanceOnce();
                }

        }

    }
}