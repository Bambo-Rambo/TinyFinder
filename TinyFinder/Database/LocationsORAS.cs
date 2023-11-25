using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class LocationsORAS
    {
        public static List<Location> WildLocations()
        {
            List<Location> locations = new List<Location>()
            {
                new Location
                {
                    Name = "Battle Resort",
                    Bag_Advances = 15,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 222,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 162,

                    SurfLevel = new int[] { 35, 35, 35, 40, 40, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },

                },

                new Location
                {
                    Name = "Cave of Origin",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36, },
                    HordeLevel = new int[] { 18, 18, 18, },
                },

                new Location
                {
                    Name = "Dewford Town",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Ever Grande City",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 208,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Fiery Path",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 13, 14, 15, 16, 14, 15, 16, 15, 15, 15, 14, 14, },
                    HordeLevel = new int[] { 8, 8, 8, },
                    DexNavLevel = 15,
                },

                new Location
                {
                    Name = "Granite Cave - 1F",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 9, 10, 11, 12, 9, 10, 11, 12, 10, 12, 10, 12, },
                    HordeLevel = new int[] { 6, 6, 6, },
                    DexNavLevel = 12,
                },

                new Location
                {
                    Name = "Granite Cave - B1F",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 10, 11, 12, 10, 11, 12, 10, 12, 10, 12, 12, 12, },
                    HordeLevel = new int[] { 6, 6, 6, },
                    DexNavLevel = 12,
                },

                new Location
                {
                    Name = "Granite Cave - B2F",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 10, 11, 12, 10, 11, 12, 10, 12, 10, 12, 12, 12, },
                    HordeLevel = new int[] { 6, 6, 6, },
                    SmashLevel = new int[] { 10, 11, 10, 12, 12, },
                    DexNavLevel = 12,
                },

                new Location
                {
                    Name = "Jagged Pass",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 18, 19, 20, 21, 18, 19, 20, 21, 18, 19, 20, 21, },
                    HordeLevel = new int[] { 10, 10, 10, },
                    DexNavLevel = 21,
                },

                new Location
                {
                    Name = "Lilycove City",
                    Bag_Advances = 15,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 214,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 162,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    SmashLevel = new int[] { 28, 29, 30, 31, 31, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Meteor Falls - Entrance",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 16, 16, 17, 17, 18, 18, 16, 17, 19, 19, 18, 19, },
                    HordeLevel = new int[] { 9, 9, 9, },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 19,
                },

                new Location
                {
                    Name = "Meteor Falls - Not Entrance",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 194,
                    ConsoleDelayRand = 204,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 154,

                    WildLevel = new int[] { 37, 37, 38, 38, 39, 39, 37, 38, 40, 40, 39, 40, },
                    HordeLevel = new int[] { 20, 20, 20, },
                    SurfLevel = new int[] { 30, 35, 30, 35, 40, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 30, 30, 30, },
                    SuperLevel = new int[] { 30, 35, 40, },
                    DexNavLevel = 40,
                },

                new Location
                {
                    Name = "Meteor Falls - Deep",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 37, 38, 39, 40, 37, 37, 38, 38, 39, 40, 39, 40, },
                    HordeLevel = new int[] { 20, 20, 20, },
                    SurfLevel = new int[] { 30, 35, 30, 35, 40, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 30, 30, 30, },
                    SuperLevel = new int[] { 30, 35, 40, },
                    DexNavLevel = 40,
                },

                new Location
                {
                    Name = "M. Cave - North of Fallarbor",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - North of Fortree",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - North of 124",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - North of 132",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - South of Pacifidlog",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - South of 107",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - West of Rustboro",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Cave - Southeast of 129",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - East of Mossdeep",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - North of Lilycove",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - North of 111",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - West of 114",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - North of 124",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - West of 105",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 33, 34, 35, 36, 36, },
                },

                new Location
                {
                    Name = "M. Forest - South of 109",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Forest - South of 132",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - South of 132",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - North of 113",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - North of 124",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - North of 125",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - West of 104",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - West of Dewford",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - South of Pacifidlog",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Island - South of 134",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },


                new Location
                {
                    Name = "M. Mountain - North of 125",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - East of 125",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - North of Lilycove",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - Northeast of 125",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - West of 104",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - South of 129",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - South of 131",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                },

                new Location
                {
                    Name = "M. Mountain - Southeast of 129",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38, },
                    SmashLevel = new int[] { 35, 36, 37, 37, 38, },
                },

                new Location
                {
                    Name = "Mossdeep City",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 25, 30, 40, },
                },

                 new Location
                {
                    Name = "Mt. Pyre - Inside",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31, 31, },
                    HordeLevel = new int[] { 15, 15, 15, },
                },

                new Location
                {
                    Name = "Mt. Pyre - Outside",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 28, 29, 30, 31, 28, 29, 30, 31, 29, 31, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    DexNavLevel = 31,
                },

                new Location
                {
                    Name = "Mt. Pyre - Summit",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 28, 29, 30, 31, 28, 29, 30, 31, 29, 31, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    DexNavLevel = 31,
                },

                new Location
                {
                    Name = "New Mauville",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 22, 23, 24, 25, 25, 22, 23, 24, 25, 25, 25, 25, },
                    HordeLevel = new int[] { 12, 12, 12, },
                },

                new Location
                {
                    Name = "Pacifidlog Town",
                    Bag_Advances = 15,
                    
                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Petalburg City",
                    Bag_Advances = 15,

                    CitraDelayRand = 200,
                    ConsoleDelayRand = 212,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 162,

                    SurfLevel = new int[] { 15, 20, 15, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Petalburg Woods",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 4, 5, 6, 4, 5, 6, 6, 6, 5, 5, 5, 5, },
                    HordeLevel = new int[] { 3, 3, 3 },
                    DexNavLevel = 6,
                },

                new Location
                {
                    Name = "Route 101",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, },
                    HordeLevel = new int[] { 2, 2, 2, },
                    DexNavLevel = 2,
                },

                new Location
                {
                    Name = "Route 102",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 2, 3, 3, 2, 3, 3, 2, 3, 2, 3, 3, 3, },
                    HordeLevel = new int[] { 2, 2, 2, },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 3,
                },

                new Location
                {
                    Name = "Route 103",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 2, 2, 3, 3, 2, 2, 3, 3, 2, 3, 3, 3, },
                    HordeLevel = new int[] { 2, 2, 2, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 3,
                },

                new Location
                {
                    Name = "Route 104 - North",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 4, 5, 6, 7, 4, 5, 6, 7, 5, 7, 5, 7, },
                    HordeLevel = new int[] { 3, 3, 3 },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 7,
                },

                new Location
                {
                    Name = "Route 104 - South",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 2, 3, 4, 5, 2, 3, 4, 5, 3, 5, 3, 5, },
                    HordeLevel = new int[] { 2, 2, 2, },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 5,
                },

                new Location
                {
                    Name = "Route 105",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    DexNavLevel = 25,
                },

                new Location
                {
                    Name = "Route 106",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 25,
                },

                new Location
                {
                    Name = "Route 107",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 25,
                },

                new Location
                {
                    Name = "Route 108",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    DexNavLevel = 25,

                },

                new Location
                {
                    Name = "Route 109",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 25,
                },

                new Location
                {
                    Name = "Route 110",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 10, 11, 12, 13, 13, 13, 13, 13, 11, 12, 13, 13, },
                    HordeLevel = new int[] { 6, 6, 6, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 13,
                },

                new Location
                {
                    Name = "Route 111",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    SmashLevel = new int[] { 13, 14, 15, 16, 16, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Route 111 - Desert",
                    NPC = 1,
                    Enc_Ratio = 1,
                    Bag_Advances = 15,

                    WildLevel = new int[] { 20, 21, 22, 23, 20, 22, 21, 23, 21, 23, 23, 23, },
                    HordeLevel = new int[] { 11, 11, 11, },
                    DexNavLevel = 23,
                },

                new Location
                {
                    Name = "Route 112 - North",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 14, 15, 15, 16, 16, 17, 14, 15, 16, 17, 17, 17, },
                    HordeLevel = new int[] { 8, 8, 8, },
                    DexNavLevel = 17,
                },

                new Location
                {
                    Name = "Route 112 - South",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 13, 14, 14, 15, 15, 16, 13, 14, 15, 16, 16, 16, },
                    HordeLevel = new int[] { 8, 8, 8, },
                    DexNavLevel = 16,
                },

                new Location
                {
                    Name = "Route 113",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 15, 16, 16, 17, 17, 18, 15, 16, 17, 18, 16, 18, },
                    HordeLevel = new int[] { 9, 9, 9, },
                    DexNavLevel = 18,
                },

                new Location
                {
                    Name = "Route 114",
                    Bag_Advances = 16,

                    WildLevel = new int[] { 16, 17, 18, 19, 16, 17, 18, 19, 17, 19, 19, 19, },
                    HordeLevel = new int[] { 9, 9, 9 },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25 },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    SmashLevel = new int[] { 15, 10, 20, 5, 5 },
                    DexNavLevel = 19,
                },

                new Location
                {
                    Name = "Route 115",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 17, 18, 19, 20, 17, 18, 19, 20, 20, 18, 18, 20, },
                    HordeLevel = new int[] { 10, 10, 10, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 20,
                },

                new Location
                {
                    Name = "Route 116",
                    Bag_Advances = 16,

                    WildLevel = new int[] { 6, 7, 8, 5, 6, 7, 6, 8, 6, 8, 8, 8, },
                    HordeLevel = new int[] { 4, 4, 4, },
                    DexNavLevel = 8,
                },

                new Location
                {
                    Name = "Route 117",
                    NPC = 1,
                    Bag_Advances = 15,

                    CitraDelayRand = 202,
                    ConsoleDelayRand = 214,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 164,

                    WildLevel = new int[] { 12, 13, 14, 12, 14, 11, 13, 14, 11, 13, 14, 14, },
                    HordeLevel = new int[] { 7, 7, 7, },
                    SurfLevel = new int[] { 15, 20, 20, 25, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 14,
                },

                new Location
                {
                    Name = "Route 118",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 216,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 168,

                    WildLevel = new int[] { 21, 22, 23, 24, 21, 22, 23, 24, 22, 24, 24, 24, },
                    HordeLevel = new int[] { 12, 12, 12, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 24,
                },

                new Location
                {
                    Name = "Route 119",
                    Bag_Advances = 15,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 226,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 166,

                    WildLevel = new int[] { 22, 23, 24, 25, 22, 23, 24, 25, 23, 25, 25, 25, },
                    HordeLevel = new int[] { 12, 12, 12 },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30 },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25 },
                    SuperLevel = new int[] { 35, 40, 35 },
                },

                new Location
                {
                    Name = "Route 119 - Feebas",
                    Bag_Advances = 15,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 226,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 166,

                    WildLevel = new int[] { 22, 23, 24, 25, 22, 23, 24, 25, 23, 25, 25, 25, },
                    HordeLevel = new int[] { 12, 12, 12 },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30 },
                    OldLevel = new int[] { 15, 15, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 35, 35, },
                },

                new Location
                {
                    Name = "Route 120 - East",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 24, 25, 26, 27, 24, 25, 26, 27, 27, 27, 27, 27, },
                    HordeLevel = new int[] { 13, 13, 13, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Route 120 - West",
                    Bag_Advances = 15,

                    WildLevel = new int[] { 24, 25, 26, 27, 24, 25, 26, 27, 27, 27, 27, 27, },
                    HordeLevel = new int[] { 13, 13, 13, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Route 121",
                    Bag_Advances = 16,

                    WildLevel = new int[] { 28, 29, 30, 27, 28, 29, 28, 29, 30, 30, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15 },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 122",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 25,
                },

                new Location
                {
                    Name = "Route 123",
                    NPC = 1,
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 214,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 166,

                    WildLevel = new int[] { 29, 30, 31, 28, 29, 30, 29, 30, 31, 31, 31, 31, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Route 124",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 125",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 126",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 127",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 128",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 210,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 162,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 129",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 130",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 208,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 162,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 131",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 132",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 133",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Route 134",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Rusturf Tunnel",
                    Enc_Ratio = 7,
                    Bag_Advances = 15,

                    WildLevel = new int[] { 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10, },
                    HordeLevel = new int[] { 5, 5, 5, },
                    SmashLevel = new int[] { 14, 15, 16, 17, 17, },
                },

                new Location
                {
                    Name = "Safari Zone - Area 1",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 210,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15 },
                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Safari Zone - Area 2",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 210,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Safari Zone - Area 3",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 210,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Safari Zone - Area 4",
                    Bag_Advances = 15,

                    CitraDelayRand = 196,
                    ConsoleDelayRand = 210,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30, },
                    HordeLevel = new int[] { 15, 15, 15, },
                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15 },
                    GoodLevel = new int[] { 25, 25, 25},
                    SuperLevel = new int[] { 35, 30, 40 },
                    DexNavLevel = 30,
                },

                new Location
                {
                    Name = "Scorched Slab",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 192,
                    ConsoleDelayRand = 202,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 29, },
                    SurfLevel = new int[] { 20, 25, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 10, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Sea Mauville - Outside",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 15, 15, 20, 20, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Sea Mauville - Inside",
                    Bag_Advances = 15,

                    SurfLevel = new int[] { 15, 15, 20, 20, 25, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Sealed Chamber",
                    Bag_Advances = 3,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Seafloor Cavern - Entrance",
                    Bag_Advances = 3,

                    SurfLevel = new int[] { 25, 30, 35, 30, 35, },
                    SmashLevel = new int[] { 33, 34, 35, 36, 36, },
                    OldLevel = new int[] { 10, 10, 5, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 30, 35, 40, },
                },

                new Location
                {
                    Name = "Seafloor Cavern - Inside",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36, },
                    HordeLevel = new int[] { 18, 18, 18, },
                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    SmashLevel = new int[] { 33, 34, 35, 36, 36, },
                    OldLevel = new int[] { 10, 5, 10, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Shoal Cave - Low tide",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 31, 32, 33, 34, 31, 31, 32, 32, 33, 34, 34, 34, },
                    HordeLevel = new int[] { 17, 17, 17, },
                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    SmashLevel = new int[] { 31, 32, 33, 34, 34, },
                    DexNavLevel = 34,
                },

                new Location
                {
                    Name = "Shoal Cave - High tide",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 31, 32, 33, 34, 31, 31, 32, 32, 33, 34, 34, 34, },
                    HordeLevel = new int[] { 17, 17, 17, },
                    SurfLevel = new int[] { 25, 25, 30, 30, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                    DexNavLevel = 34,
                },

                new Location
                {
                    Name = "Shoal Cave - Frozen area",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 31, 32, 33, 34, 31, 32, 33, 34, 31, 32, 33, 34, },
                    HordeLevel = new int[] { 17, 17, 17, },
                },

                new Location
                {
                    Name = "Sky Pillar",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 44, 45, 46, 44, 45, 46, 44, 45, 46, 44, 45, 46, },
                    HordeLevel = new int[] { 23, 23, 23, },
                },

                new Location
                {
                    Name = "Slateport City",
                    Bag_Advances = 15,

                    CitraDelayRand = 204,
                    ConsoleDelayRand = 216,
                    CitraORASCorr = 154,
                    ConsoleORASCorr = 164,

                    SurfLevel = new int[] { 20, 20, 25, 25, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Sootopolis City",
                    Bag_Advances = 15,

                    CitraDelayRand = 202,
                    ConsoleDelayRand = 212,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    SurfLevel = new int[] { 30, 25, 35, 35, 35, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Team Aqua Hideout",
                    Bag_Advances = 6,

                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Team Magma Hideout",
                    Bag_Advances = 6,

                    SurfLevel = new int[] { 20, 20, 25, 30, 30, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Underwater - Route 128",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35, },
                },

                new Location
                {
                    Name = "Underwater - Elsewhere",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    WildLevel = new int[] { 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35, },
                },

                new Location
                {
                    Name = "Victory Road - Default",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    CitraDelayRand = 194,
                    ConsoleDelayRand = 202,
                    CitraORASCorr = 152,
                    ConsoleORASCorr = 156,

                    WildLevel = new int[] { 37, 39, 38, 40, 37, 39, 37, 39, 38, 40, 40, 40, },
                    HordeLevel = new int[] { 20, 20, 20, },
                    SurfLevel = new int[] { 25, 30, 35, 40, 40, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

                new Location
                {
                    Name = "Victory Road - 2F",
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    SurfLevel = new int[] { 25, 30, 35, 40, 40, },
                    OldLevel = new int[] { 10, 5, 15, },
                    GoodLevel = new int[] { 25, 25, 25, },
                    SuperLevel = new int[] { 35, 30, 40, },
                },

            };

            return locations;

        }
    }
}