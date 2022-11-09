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
                    Bag_Advances = 27,

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,

                    SurfLevel = new int[]   { 25, 25, 26, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                    SmashLevel = new int[]  { 18, 18, 19, 20, 20, },
                },

                new Location
                {
                    Name = "Azure Bay",
                    Bag_Advances = 27,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 242,

                    WildLevel = new int[]   { 25, 26, 27, 25, 26, 27, 27, 26, 26, 27, 27, 27, },
                    HordeLevel = new int[]  { 13, 13, 14, },
                    SurfLevel = new int[]   { 25, 26, 27, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                    SmashLevel = new int[]  { 23, 23, 24, 25, 25, },
                },

                new Location
                {
                    Name = "Connecting Cave",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[]   { 13, 14, 15, 13, 14, 15, 13, 14, 15, 13, 14, 15, },
                    HordeLevel = new int[]  { 7, 8, 8, },
                },

                new Location
                {
                    Name = "Couriway Town",
                    Bag_Advances = 27,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 236,

                    SurfLevel = new int[]   { 44, 44, 45, 46, 46, },
                    OldLevel = new int[]    { 25, 25, 25, },
                    GoodLevel = new int[]   { 35, 35, 35, },
                    SuperLevel = new int[]  { 45, 45, 45, },
                },

                new Location
                {
                    Name = "Cyllage City",
                    Bag_Advances = 27,

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,

                    SurfLevel = new int[]   { 25, 25, 26, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                    SmashLevel = new int[]  { 15, 15, 17, 16, 17, },
                },

                new Location
                {
                    Name = "Frost Cavern",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 194,
                    ConsoleDelayRand = 210,

                    WildLevel = new int[]   { 38, 39, 39, 40, 39, 40, 39, 40, 38, 39, 40, 40, },
                    HordeLevel = new int[]  { 20, 20, 21, },
                    SurfLevel = new int[]   { 38, 38, 39, 40, 40, },
                    OldLevel = new int[]    { 20, 20, 20, },
                    GoodLevel = new int[]   { 30, 30, 30, },
                    SuperLevel = new int[]  { 40, 40, 40, },
                },

                new Location
                {
                    Name = "Glittering Cave",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    //WildLevel = new int[]   { 15, 16, 17, 17, 17, 15, 16, 17, 17, 17, 15, 16, },
                    SmashLevel = new int[]  { 15, 15, 17, 16, 17, },
                },

                new Location
                {
                    Name = "Laverre City",
                    Bag_Advances = 27,

                    CitraDelayRand = 214,
                    ConsoleDelayRand = 242,

                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Lost Hotel",
                    NPC = 2,
                    Enc_Ratio = 1,
                    Bag_Advances = 3,

                    WildLevel = new int[]   { 37, 38, 36, 37, 37, 38, 37, 38, 36, 37, 38, 38, },
                },

                new Location
                {
                    Name = "Parfum Palace",
                    Bag_Advances = 27,

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 216,

                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Pokemon Village",
                    NPC = 2,
                    Bag_Advances = 27,

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 212,

                    YellowLevel = new int[] { 48, 49, 50, 48, 49, 50, 50, 49, 50, 48, 49, 50, },
                    PurpleLevel = new int[] { 48, 49, 50, 48, 49, 50, 50, 49, 50, 48, 49, 50, },
                    HordeLevel = new int[]  { 25, 25, 25, },
                    SurfLevel = new int[]   { 48, 48, 49, 50, 50, },
                    OldLevel = new int[]    { 30, 30, 30, },
                    GoodLevel = new int[]   { 40, 40, 40, },
                    SuperLevel = new int[]  { 50, 50, 50, },
                },

                new Location
                {
                    Name = "Reflection Cave",
                    Enc_Ratio = 7,
                    Bag_Advances = 6,

                    WildLevel = new int[]   { 22, 23, 22, 23, 21, 22, 23, 21, 22, 22, 22, 23, },
                    HordeLevel = new int[]  { 11, 11, 11, },
                },

                new Location
                {
                    Name = "Route 2",
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 2, 3, 3, 2, 3, 3, 2, 3, 3, 4, 4, 4, },
                },

                new Location
                {
                    Name = "Route 3",
                    Bag_Advances = 27,

                    CitraDelayRand = 224,
                    ConsoleDelayRand = 246,

                    WildLevel = new int[]   { 3, 4, 3, 4, 3, 5, 4, 5, 5, 5, 4, 5, },
                    SurfLevel = new int[]   { 25, 26, 27, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Route 4",
                    NPC = 1,
                    Bag_Advances = 27,

                    RedLevel = new int[]    { 6, 7, 8, 6, 7, 8, 8, 8, 8, 8, 7, 8, },
                    YellowLevel = new int[] { 6, 7, 8, 6, 7, 8, 8, 8, 8, 8, 7, 8, },
                },

                new Location
                {
                    Name = "Route 5",
                    NPC = 1,
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 8, 9, 10, 8, 9, 10, 10, 10, 10, 10, 9, 10, },
                    PurpleLevel = new int[] { 8, 9, 10, 8, 9, 10, 10, 10, 10, 10, 9, 10, },
                    HordeLevel = new int[]  { 5, 5, 6, },
                },

                new Location
                {
                    Name = "Route 6",
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 10, 11, 12, 10, 11, 12, 11, 12, 11, 12, 11, 12, },
                },

                new Location
                {
                    Name = "Route 7",
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 12, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14, },
                    YellowLevel = new int[] { 13, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14, },
                    PurpleLevel = new int[] { 12, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14, },
                    HordeLevel = new int[]  { 7, 7, 8, },
                },

                new Location
                {
                    Name = "Route 8",
                    Bag_Advances = 27,

                    CitraDelayRand = 228,
                    ConsoleDelayRand = 256,

                    WildLevel = new int[]   { 13, 14, 15, 13, 14, 15, 15, 14, 14, 15, 14, 15, },
                    YellowLevel = new int[] { 13, 14, 15, 13, 14, 15, 15, 14, 14, 15, 14, 15, },
                    HordeLevel = new int[]  { 7, 8, 7, },
                    SurfLevel = new int[]   { 25, 25, 26, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                    SmashLevel = new int[]  { 18, 18, 19, 20, 20, },
                },

                new Location
                {
                    Name = "Route 9",
                    Enc_Ratio = 7,
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 15, 16, 16, 17, 15, 16, 16, 17, 15, 16, 16, 17, },
                },

                new Location
                {
                    Name = "Route 10",
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 19, 20, 21, 19, 20, 19, 20, 21, 21, 21, 19, 20, },
                    YellowLevel = new int[] { 19, 20, 21, 19, 20, 19, 20, 21, 21, 21, 19, 20, },
                    HordeLevel = new int[]  { 10, 10, 11, },
                },

                new Location
                {
                    Name = "Route 11",
                    NPC = 1,
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 22, 23, 22, 23, 22, 23, 21, 21, 21, 21, 21, 21, },
                    HordeLevel = new int[]  { 11, 11, 12, },
                },

                new Location
                {
                    Name = "Route 12",
                    NPC = 1,
                    Bag_Advances = 27,

                    CitraDelayRand = 216,
                    ConsoleDelayRand = 242,

                    WildLevel = new int[]   { 23, 24, 25, 23, 24, 25, 25, 25, 24, 25, 23, 24, },
                    YellowLevel = new int[] { 25, 26, 27, 25, 26, 27, 27, 27, 26, 27, 25, 26, },
                    HordeLevel = new int[]  { 13, 13, 14, },
                    SurfLevel = new int[]   { 25, 26, 27, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                    SmashLevel = new int[]  { 23, 23, 24, 25, 25, },
                },

                /*new Location
                {
                    Name = "Route 13",
                    Bag_Advances = ,

                    WildLevel = new int[]   { 26, 27, 27, 28, 26, 27, 27, 28, 26, 27, 27, 28, },
                    SmashLevel = new int[]  { 26, 26, 27, 28, 28, },
                },*/

                new Location
                {
                    Name = "Route 14",
                    NPC = 1,
                    Bag_Advances = 27,

                    CitraDelayRand = 214,
                    ConsoleDelayRand = 242,

                    WildLevel = new int[]   { 30, 31, 31, 32, 30, 30, 30, 30, 30, 31, 31, 32, },
                    SwampLevel = new int[]  { 30, 31, 32, 31, 32, 31, 32, 30, 30, 31, 31, 32, },
                    HordeLevel = new int[]  { 16, 16, 17, },
                    SurfLevel = new int[]   { 30, 30, 31, 31, 32, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Route 15",
                    Bag_Advances = 27,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 222,

                    WildLevel = new int[]   { 34, 35, 36, 34, 35, 36, 36, 34, 35, 34, 35, 36, },
                    RedLevel = new int[]    { 34, 35, 36, 34, 35, 36, 36, 34, 35, 34, 35, 36, },
                    HordeLevel = new int[]  { 18, 18, 19, },
                    SurfLevel = new int[]   { 34, 34, 35, 36, 36, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Route 16",
                    Bag_Advances = 27,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 222,

                    WildLevel = new int[]   { 34, 35, 36, 35, 36, 36, 35, 34, 36, 34, 35, 36, },
                    YellowLevel = new int[] { 35, 36, 34, 35, 35, 36, 36, 34, 36, 34, 35, 36, },
                    HordeLevel = new int[]  { 18, 18, 19, },
                    SurfLevel = new int[]   { 34, 34, 35, 36, 36, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Route 17",
                    Enc_Ratio = 7,
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 38, 39, 39, 39, 38, 39, 39, 40, 38, 40, 40, 40, },
                },

                new Location
                {
                    Name = "Route 18",
                    NPC = 2,
                    Bag_Advances = 27,

                    WildLevel = new int[]   { 44, 45, 46, 44, 45, 46, 46, 44, 45, 46, 45, 46, },
                    RedLevel = new int[]    { 44, 45, 46, 44, 45, 46, 46, 44, 45, 46, 45, 46, },
                    HordeLevel = new int[]  { 23, 23, 23, },
                    SmashLevel = new int[]  { 44, 45, 46, 44, 46, },
                },

                new Location
                {
                    Name = "Route 19",
                    NPC = 2,
                    Bag_Advances = 27,

                    CitraDelayRand = 198,
                    ConsoleDelayRand = 218,

                    YellowLevel = new int[] { 46, 47, 48, 46, 47, 48, 48, 47, 47, 47, 46, 48, },
                    PurpleLevel = new int[] { 46, 47, 48, 46, 47, 48, 48, 47, 47, 47, 46, 48, },
                    SwampLevel = new int[]  { 46, 47, 48, 47, 48, 47, 48, 47, 47, 47, 46, 48, },
                    HordeLevel = new int[]  { 24, 24, 25, },
                    SurfLevel = new int[]   { 46, 46, 47, 48, 48, },
                    OldLevel = new int[]    { 25, 25, 25, },
                    GoodLevel = new int[]   { 35, 35, 35, },
                    SuperLevel = new int[]  { 45, 45, 50, },
                },

                new Location
                {
                    Name = "Route 20",
                    Bag_Advances = 3,

                    WildLevel = new int[]   { 48, 49, 50, 48, 49, 50, 50, 48, 49, 50, 48, 50, },
                    RedLevel = new int[]    { 48, 49, 50, 48, 49, 50, 50, 48, 49, 50, 48, 50, },
                    HordeLevel = new int[]  { 25, 25, 25, },
                },

                new Location
                {
                    Name = "Route 21",
                    NPC = 1,
                    Bag_Advances = 27,

                    CitraDelayRand = 200,
                    ConsoleDelayRand = 216,

                    RedLevel = new int[]    { 50, 51, 52, 50, 51, 50, 50, 52, 52, 50, 51, 52, },
                    PurpleLevel = new int[] { 50, 51, 52, 50, 51, 50, 50, 52, 52, 50, 51, 52, },
                    HordeLevel = new int[]  { 26, 26, 27, },
                    SurfLevel = new int[]   { 50, 50, 51, 52, 52, },
                    OldLevel = new int[]    { 30, 30, 30, },
                    GoodLevel = new int[]   { 40, 40, 40, },
                    SuperLevel = new int[]  { 50, 50, 50, },
                },

                new Location
                {
                    Name = "Route 22",
                    Bag_Advances = 27,

                    CitraDelayRand = 224,
                    ConsoleDelayRand = 244,

                    WildLevel = new int[]   { 5, 6, 5, 6, 6, 6, 6, 7, 7, 7, 6, 7, },
                    YellowLevel = new int[] { 26, 27, 25, 26, 25, 27, 26, 27, 26, 26, 25, 26, },
                    SurfLevel = new int[]   { 26, 26, 27, 25, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Santalune Forest",
                    Bag_Advances = 3,

                    WildLevel = new int[]   { 2, 3, 2, 3, 4, 4, 4, 4, 2, 3, 4, 4, },

                },

                new Location
                {
                    Name = "Shalour City",
                    Bag_Advances = 27,

                    CitraDelayRand = 208,
                    ConsoleDelayRand = 230,

                    SurfLevel = new int[]   { 25, 26, 27, 27, 27, },
                    OldLevel = new int[]    { 15, 15, 15, },
                    GoodLevel = new int[]   { 25, 25, 25, },
                    SuperLevel = new int[]  { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Terminus Cave",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[]   { 45, 46, 45, 46, 44, 44, 45, 46, 44, 45, 46, 46, },
                    HordeLevel = new int[]  { 23, 23, 24, },
                    SmashLevel = new int[]  { 44, 45, 46, 44, 46, },
                },

                new Location
                {
                    Name = "Victory Road - Default",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,

                    WildLevel = new int[]   { 57, 58, 59, 58, 59, 58, 57, 58, 58, 59, 59, 59, },
                    HordeLevel = new int[]  { 28, 29, 30, },
                    SurfLevel = new int[]   { 57, 57, 58, 59, 59 },
                    OldLevel = new int[]    { 35, 35, 35, },
                    GoodLevel = new int[]   { 45, 45, 45, },
                    SuperLevel = new int[]  { 55, 55, 55, },
                    SmashLevel = new int[]  { 57, 58, 59, 57, 59, },
                },
                new Location
                {
                    Name = "Victory Road Inside 1/4",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    HordeLevel = new int[]  { 28, 29, 30, },
                },
                new Location
                {
                    Name = "Victory Road Outside",
                    Bag_Advances = 27,

                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,

                    SurfLevel = new int[]   { 57, 57, 58, 59, 59 },
                    OldLevel = new int[]    { 35, 35, 35, },
                    GoodLevel = new int[]   { 45, 45, 45, },
                    SuperLevel = new int[]  { 55, 55, 55, },
                    SwoopingLevel = new int[] { 57, 58, 59, 58, 59, 58, 57, 58, 57, 59, 59, 59, },
                },
                new Location
                {
                    Name = "Victory Road Exit",
                    Enc_Ratio = 7,
                    CitraDelayRand = 212,
                    ConsoleDelayRand = 226,

                    Bag_Advances = 3,
                    OldLevel = new int[]    { 35, 35, 35, },
                    GoodLevel = new int[]   { 45, 45, 45, },
                    SuperLevel = new int[]  { 55, 55, 60, },
                },

            };

            return locations;

        }
    }
}
