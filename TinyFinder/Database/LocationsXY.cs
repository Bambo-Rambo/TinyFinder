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

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,
                },

                new Location
                {
                    Name = "Azure Bay",
                    Map = 357,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 242,
                },

                new Location
                {
                    Name = "Connecting Cave",
                    Map = 334,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Couriway Town",
                    Map = 38,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 236,
                },

                new Location
                {
                    Name = "Cyllage City",
                    Map = 157,

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,
                },

                new Location
                {
                    Name = "Frost Cavern - Default",
                    Map = 314,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Frost Cavern - Main 2F",
                    Map = 315,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 194,
                    ConsoleDelayRand = 210,
                },

                new Location
                {
                    Name = "Glittering Cave",
                    Map = 303,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Laverre City",
                    Map = 200,

                    CitraDelayRand = 214,
                    ConsoleDelayRand = 242,
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

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 216,
                },

                new Location
                {
                    Name = "Pokémon Village",
                    Map = 318,
                    NPC = 2,

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 212,
                },

                new Location
                {
                    Name = "Reflection Cave",
                    Map = 305,
                    Enc_Ratio = 7,
                    Bag_Advances = 6,
                },

                new Location
                {
                    Name = "Route 2",
                    Map = 259,
                },

                new Location
                {
                    Name = "Route 3",
                    Map = 260,

                    CitraDelayRand = 224,
                    ConsoleDelayRand = 246,
                },

                new Location
                {
                    Name = "Route 4",
                    Map = 261,
                    NPC = 1,
                },

                new Location
                {
                    Name = "Route 5",
                    Map = 262,
                    NPC = 1,
                },

                new Location
                {
                    Name = "Route 6",
                    Map = 263,
                },

                new Location
                {
                    Name = "Route 7",
                    Map = 264,
                },

                new Location
                {
                    Name = "Route 8",
                    Map = 266,

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,
                },

                new Location
                {
                    Name = "Route 9",
                    Map = 267,
                    Enc_Ratio = 7,
                },

                new Location
                {
                    Name = "Route 10",
                    Map = 268,
                },

                new Location
                {
                    Name = "Route 11",
                    Map = 269,
                    NPC = 1,
                },

                new Location
                {
                    Name = "Route 12",
                    Map = 270,
                    NPC = 1,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 242,
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

                    CitraDelayRand = 214,
                    ConsoleDelayRand = 242,
                },

                new Location
                {
                    Name = "Route 15",
                    Map = 275,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 222,
                },

                new Location
                {
                    Name = "Route 16",
                    Map = 276,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 222,
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
                },

                new Location
                {
                    Name = "Route 19",
                    Map = 281,
                    NPC = 2,

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 218,
                },

                new Location
                {
                    Name = "Route 20",
                    Map = 282,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Route 21",
                    Map = 283,
                    NPC = 1,

                    CitraDelayRand = 200,
                    ConsoleDelayRand = 216,
                },

                new Location
                {
                    Name = "Route 22",
                    Map = 285,

                    CitraDelayRand = 224,
                    ConsoleDelayRand = 244,
                },

                new Location
                {
                    Name = "Santalune Forest",
                    Map = 286,
                    Bag_Advances = 3,

                },

                new Location
                {
                    Name = "Shalour City",
                    Map = 172,

                    CitraDelayRand = 208,
                    ConsoleDelayRand = 230,
                },

                new Location
                {
                    Name = "Terminus Cave",
                    Map = 343,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Victory Road - Entrance",
                    Map = 322,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,
                },

                new Location
                {
                    Name = "Victory Road - Middle",
                    Map = 324,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Victory Road - Exit",
                    Map = 328,
                    Enc_Ratio = 7,
                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,

                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Victory Road - Outside",
                    Map = 327,

                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,
                },

            };

            return locations;

        }
    }
}
