using System;
using System.Collections.Generic;

namespace TinyFinder
{
    class SlotData
    {
        public byte getSlot(int rand, byte SlotType)
        {
            var SlotSplitter = SlotDistribution[SlotType];
            for (byte i = 1; i < SlotSplitter.Length; i++)
            {
                rand -= SlotSplitter[i - 1];
                if (rand < 0)
                    return i;
            }
            return (byte)SlotSplitter.Length;
        }

        public readonly static byte[][] SlotDistribution = new byte[][]
        {
            new byte[] { 10,10,10,10,10,10,10,10,10,5,4,1 },    // Wild / Radar
            new byte[] { 34,33,33 },                            // Friend Safari
            new byte[] { 60,35,5 },                             // Horde / Fishing
            new byte[] { 50,30,15,4,1 },                        // Rock Smash / Surfing
        };

        public static byte[,] Wild_Influence = new byte[,]
        {
            { 0, 0 },   //Elsewhere
            { 1, 1 },   //Azure Bay
            { 2, 0 },   //Lost Hotel
            { 3, 1 },   //Pokemon Village
            { 0, 1 },   //Route 2
            { 0, 1 },   //Route 3
            { 1, 1 },   //Route 4
            { 2, 1 },   //Route 5
            { 1, 1 },   //Route 7
            { 1, 1 },   //Route 8
            { 0, 0 },   //Route 9
            { 1, 1 },   //Route 10
            { 2, 1 },   //Route 11
            { 2, 1 },   //Route 12
            { 2, 1 },   //Route 14
            { 1, 1 },   //Route 15
            { 0, 0 },   //Route 17
            { 3, 1 },   //Route 18
            { 3, 1 },   //Route 19
            { 1, 1 },   //Route 20
            { 2, 1 },   //Route 21
            { 0, 1 },   //Route 22
            { 0, 1 }    //Santalune Forest
          //{ 1, 0 }    //Caves
        };
        public static byte[,] getWild_Influence() { return Wild_Influence; }

    }
}
