using System;
using System.Collections.Generic;

namespace TinyFinder
{
    class Data
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

        public static object[,] XY_Locations = new object[,]
        {
            //Name, NPC Influene, Has Hordes, Ratio, Tall Grass
            { "Elsewhere", 0, false, 13, false, },
            { "Azure Bay", 0, true, 13, true, },
            { "Lost Hotel", 2, false, 1, false, },
            { "Pokemon Village", 2, true, 13, true, },
            { "Route 2", 0, false, 13, true, },
            { "Route 3", 0, false, 13, true, },
            { "Route 4", 1, false, 13, true, },
            { "Route 5", 1, true, 13, true, },
            { "Route 7", 0, true, 13, true, },
            { "Route 8", 0, true, 13, true, },
            { "Route 9", 0, false, 7, false, },
            { "Route 10", 0, true, 13, true, },
            { "Route 11", 1, true, 13, true, },
            { "Route 12", 1, true, 13, true, },
            { "Route 14", 1, true, 13, true, },
            { "Route 15", 0, true, 13, true, },
            { "Route 17", 0, false, 7, false, },
            { "Route 18", 2, true, 13, true, },
            { "Route 19", 2, true, 13, true, },
            { "Route 20", 0, true, 13, true, },
            { "Route 21", 1, true, 13, true, },
            { "Route 22", 0, false, 13, true, },
            { "Santalune Forest", 0, false, 13, true, }
          //{ "Cave", 0, true, false }
        };

        public static object[,] ORAS_Locations = new object[,]
        {
            //Name, NPC Influence, Has Hordes/Long Grass, Ratio
            { "Elsewhere", 0, false, 13 },
            { "Mt Pyre Inside", 0, false, 7 },
            { "New Mauville", 0, false, 7 },
            { "Route 111 Desert", 1, false, 1 },    //Ratio is 7 but only 1 works every time
            { "Route 117", 1, false, 13 },
            { "Route 118", 0, true, 13 },
            { "Route 119", 0, true, 13 },
            { "Route 120", 0, true, 13 },
            { "Route 121", 0, true, 13 },
            { "Route 123", 1, true, 13 },
            { "Safari Zone", 0, true, 13 },
            { "Sky Pillar", 0, false, 7 },
            //Honey Wild Locations
            //Name, Bag/Honey Advances, null, null
            { "Elsewhere", 15, null, null },
            { "Magma/Aqua Hideout", 6, null, null },
            { "Underwater", 3, null, null },
        };


        public List<Location> SetLocations(byte method, bool oras)
        {
            Location area;
            List<Location> Areas = new List<Location>();
            if (oras)
            {
                if (method == 1 || method == 4)
                    for (byte i = 0; i < 11; i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(ORAS_Locations[i, 0].ToString()),
                            NPC = Convert.ToByte(ORAS_Locations[i, 1]),
                            Has_Hordes = (bool)ORAS_Locations[i, 2],
                            ratio = Convert.ToByte(ORAS_Locations[i, 3])
                        };
                        if (method == 1 || Equals(area.Name, "Elsewhere") || Equals(area.Name, "Route 123"))
                            Areas.Add(area);
                    }
                else //if (method == 5)
                {
                    for (byte i = 12; i < 15; i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(ORAS_Locations[i, 0].ToString()),
                            ratio = Convert.ToByte(ORAS_Locations[i, 1])
                        };
                        Areas.Add(area);
                    }
                }
            }
            else
            {
                for (byte i = 0; i < 23; i++)
                {
                    area = new Location
                    {
                        Name = string.Copy(XY_Locations[i, 0].ToString()),
                        NPC = Convert.ToByte(XY_Locations[i, 1]),
                        Has_Hordes = (bool)XY_Locations[i, 2],
                        ratio = Convert.ToByte(XY_Locations[i, 3]),
                        Tall_Grass = (bool)XY_Locations[i, 4]
                    };
                    if (method == 1 || (method == 4 && area.Has_Hordes))
                        Areas.Add(area);
                }
            }
            return Areas;
        }
    }
}
