using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class LocationsXY
    {
        public static List<Location> WildLocations()
        {
            List<Location> locations = new List<Location>()
            {
                new Location
                {
                    Name = "Ambrette Town",
                    Map = 45,

                    FirstLongBlinkRand = 106,       // 104, 106, 104, 106, 104, 106
                    FirstLongBlinkRand_Emu = 96,    // 92, 90, 92, 92, 94, 94, 90
                },

                new Location
                {
                    Name = "Azure Bay",
                    Map = 357,

                    FirstLongBlinkRand = 94,        // 94, 92, 92, 96, 90, 94, 100, 94, 
                    FirstLongBlinkRand_Emu = 80,
                },

                new Location
                {
                    Name = "Connecting Cave",
                    Map = 334,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,        // 56, 56
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Couriway Town",
                    Map = 38,

                    FirstLongBlinkRand = 88,
                    FirstLongBlinkRand_Emu = 76,
                },

                new Location
                {
                    Name = "Cyllage City",
                    Map = 157,

                    FirstLongBlinkRand = 108,        // 106, 108, 102, 104
                    FirstLongBlinkRand_Emu = 98,
                },

                new Location
                {
                    Name = "Frost Cavern - Default",
                    Map = 314,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Frost Cavern - Main 2F",
                    Map = 315,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 68,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Glittering Cave",
                    Map = 303,
                    Enc_Ratio = 7,
                    Bag_Advances = 6,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Laverre City",
                    Map = 200,

                    FirstLongBlinkRand = 92,
                    FirstLongBlinkRand_Emu = 76,
                },

                new Location
                {
                    Name = "Lost Hotel",
                    Map = 349,
                    NPC = 2,
                    Enc_Ratio = 1,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Parfum Palace",
                    Map = 302,

                    FirstLongBlinkRand = 72,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Pokémon Village",
                    Map = 318,
                    NPC = 2,

                    FirstLongBlinkRand = 72,
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Reflection Cave",
                    Map = 305,
                    Enc_Ratio = 7,
                    Bag_Advances = 6,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 2",
                    Map = 259,

                    FirstLongBlinkRand = 86,
                    FirstLongBlinkRand_Emu = 76,
                },

                new Location
                {
                    Name = "Route 3",
                    Map = 260,

                    FirstLongBlinkRand = 100,
                    FirstLongBlinkRand_Emu = 90,
                },

                new Location
                {
                    Name = "Route 4",
                    Map = 261,
                    NPC = 1,

                    FirstLongBlinkRand = 98,
                    FirstLongBlinkRand_Emu = 90,
                },

                new Location
                {
                    Name = "Route 5",
                    Map = 262,
                    NPC = 1,

                    FirstLongBlinkRand = 92,    //90, 94, 92, 
                    FirstLongBlinkRand_Emu = 90,
                },

                new Location
                {
                    Name = "Route 6",
                    Map = 263,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 7",
                    Map = 264,

                    FirstLongBlinkRand = 90,
                    FirstLongBlinkRand_Emu = 88,
                },

                new Location
                {
                    Name = "Route 8",
                    Map = 266,

                    FirstLongBlinkRand = 108,
                    FirstLongBlinkRand_Emu = 90
                },

                new Location
                {
                    Name = "Route 9",
                    Map = 267,
                    Enc_Ratio = 7,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 10",
                    Map = 268,

                    FirstLongBlinkRand = 102,
                    FirstLongBlinkRand_Emu = 92,
                },

                new Location
                {
                    Name = "Route 11",
                    Map = 269,
                    NPC = 1,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 12",
                    Map = 270,
                    NPC = 1,

                    FirstLongBlinkRand = 96,
                    FirstLongBlinkRand_Emu = 82,
                },

                new Location
                {
                    Name = "Route 13",
                    Map = 272,
                },

                new Location
                {
                    Name = "Route 14",
                    Map = 273,
                    NPC = 1,

                    FirstLongBlinkRand = 90,
                    FirstLongBlinkRand_Emu = 76,
                },

                new Location
                {
                    Name = "Route 15",
                    Map = 275,

                    FirstLongBlinkRand = 76,
                    FirstLongBlinkRand_Emu = 68,
                },

                new Location
                {
                    Name = "Route 16",
                    Map = 276,

                    FirstLongBlinkRand = 76,
                    FirstLongBlinkRand_Emu = 64,
                },

                new Location
                {
                    Name = "Route 17",
                    Map = 278,
                    Enc_Ratio = 7,
                },

                new Location
                {
                    Name = "Route 18",
                    Map = 279,
                    NPC = 2,

                    FirstLongBlinkRand = 86,
                    FirstLongBlinkRand_Emu = 68,
                },

                new Location
                {
                    Name = "Route 19",
                    Map = 281,
                    NPC = 2,

                    FirstLongBlinkRand = 78,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 20",
                    Map = 282,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 21",
                    Map = 283,
                    NPC = 1,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 22",
                    Map = 285,

                    FirstLongBlinkRand = 94,
                    FirstLongBlinkRand_Emu = 78,
                },

                new Location
                {
                    Name = "Santalune Forest",
                    Map = 286,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Shalour City",
                    Map = 172,

                    FirstLongBlinkRand = 80,        // 84, 82, 80, 82, 82
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Terminus Cave",
                    Map = 343,
                    Enc_Ratio = 7,

                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,        // 58, 54, 56, 56, 56, 
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Victory Road - Entrance",
                    Map = 322,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand_Emu = 78,
                    FirstLongBlinkRand = 80,
                },

                new Location
                {
                    Name = "Victory Road - Middle",
                    Map = 324,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                    //Bag_Advances = 7,
                },

                new Location
                {
                    Name = "Victory Road - Exit",
                    Map = 328,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand_Emu = 76,
                    FirstLongBlinkRand = 80,
                },

                new Location
                {
                    Name = "Victory Road - Outside",
                    Map = 327,

                    //FirstLongBlinkRand = ,
                    //FirstLongBlinkRand_Emu = ,
                },

            };

            return locations;

        }
    }
}
