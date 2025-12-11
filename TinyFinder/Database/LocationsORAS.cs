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
                    Map = 210,

                    FirstLongBlinkRand = 66,        // 68, 66, 66, 68
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Cave of Origin",
                    Map = 112,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Dewford Town",
                    Map = 8,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Ever Grande City",
                    Map = 21,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Fiery Path",
                    Map = 85,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Granite Cave - 1F",
                    Map = 78,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Granite Cave - B1F",
                    Map = 79,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Granite Cave - B2F",
                    Map = 80,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Jagged Pass",
                    Map = 84,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Lilycove City",
                    Map = 18,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Meteor Falls - 1F 1R",
                    Map = 71,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,        // 54, 52, 48, 50, 50, 56, 52, 56, 56, 
                    FirstLongBlinkRand_Emu = 44,
                },

                new Location
                {
                    Name = "Meteor Falls - 1F 2R, B1F 1R",
                    Map = 72,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 44,
                },

                new Location
                {
                    Name = "Meteor Falls - B1F2",
                    Map = 74,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 52,        // 52, 50, 50, 52
                    FirstLongBlinkRand_Emu = 44,
                },

                new Location
                {
                    Name = "M. Cave - North of Fallarbor",
                    Map = 515,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - North of Fortree",
                    Map = 509,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - North of 124",
                    Map = 512,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - North of 132",
                    Map = 513,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - South of Pacifidlog",
                    Map = 510,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - South of 107",
                    Map = 511,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - West of Rustboro",
                    Map = 508,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Cave - Southeast of 129",
                    Map = 514,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "M. Forest - East of Mossdeep",
                    Map = 184,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - North of Lilycove",
                    Map = 187,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - North of 111",
                    Map = 191,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - West of 114",
                    Map = 186,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - North of 124",
                    Map = 185,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - West of 105",
                    Map = 189,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - South of 109",
                    Map = 190,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Forest - South of 132",
                    Map = 188,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - South of 132",
                    Map = 205,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - North of 113",
                    Map = 206,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - North of 124",
                    Map = 202,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - North of 125",
                    Map = 207,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - West of 104",
                    Map = 200,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - West of Dewford",
                    Map = 203,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - South of Pacifidlog",
                    Map = 204,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Island - South of 134",
                    Map = 201,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },


                new Location
                {
                    Name = "M. Mountain - North of 125",
                    Map = 466,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - East of 125",
                    Map = 463,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - North of Lilycove",
                    Map = 460,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - Northeast of 125",
                    Map = 461,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - West of 104",
                    Map = 208,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - South of 129",
                    Map = 464,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - South of 131",
                    Map = 462,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "M. Mountain - Southeast of 129",
                    Map = 465,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Mossdeep City",
                    Map = 19,

                    FirstLongBlinkRand = 64,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Mt. Pyre - Inside",
                    Map = 86,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Mt. Pyre - Outside",
                    Map = 90,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Mt. Pyre - Summit",
                    Map = 91,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "New Mauville",
                    Map = 139,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Pacifidlog Town",
                    Map = 12,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Petalburg City",
                    Map = 13,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Petalburg Woods",
                    Map = 82,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 101",
                    Map = 23,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Route 102",
                    Map = 24,

                    FirstLongBlinkRand = 60,    // 58, 58, 58, 56, 58
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 103",
                    Map = 25,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 104 - North",
                    Map = 26,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Route 104 - South",
                    Map = 27,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 105",
                    Map = 28,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 106",
                    Map = 29,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 107",
                    Map = 30,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Route 107 - Underwater",
                    Map = 64,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 108",
                    Map = 31,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Route 109",
                    Map = 32,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Route 110",
                    Map = 33,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Route 111",
                    Map = 37,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 111 - Desert",
                    Map = 35,
                    NPC = 1,
                    Enc_Ratio = 1,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Route 112 - North",
                    Map = 38,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 112 - South",
                    Map = 39,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 113",
                    Map = 40,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 114",
                    Map = 41,
                    Bag_Advances = 16,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 115",
                    Map = 42,

                    FirstLongBlinkRand = 60,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 116",
                    Map = 43,

                    FirstLongBlinkRand = 62,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 117",
                    Map = 44,
                    NPC = 1,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 54,
                },

                new Location
                {
                    Name = "Route 118",
                    Map = 45,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Route 119",
                    Map = 46,

                    FirstLongBlinkRand = 64,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 120 - East",
                    Map = 48,
                },

                new Location
                {
                    Name = "Route 120 - West",
                    Map = 49,
                },

                new Location
                {
                    Name = "Route 121",
                    Map = 50,
                    Bag_Advances = 16,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 122",
                    Map = 51,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 123",
                    Map = 52,
                    NPC = 1,

                    FirstLongBlinkRand = 52,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Route 124",
                    Map = 53,

                    FirstLongBlinkRand = 64,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 124 - Underwater",
                    Map = 65,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Route 125",
                    Map = 54,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 58,
                },

                new Location
                {
                    Name = "Route 126",
                    Map = 55,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 126 - Underwater",
                    Map = 66,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Route 127",
                    Map = 56,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 128",
                    Map = 57,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 128 - Underwater",
                    Map = 68,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Route 129",
                    Map = 58,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 129 - Underwater",
                    Map = 69,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 130",
                    Map = 59,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 130 - Underwater",
                    Map = 70,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 56,
                },

                new Location
                {
                    Name = "Route 131",
                    Map = 60,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 132",
                    Map = 61,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 133",
                    Map = 62,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Route 134",
                    Map = 63,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Rusturf Tunnel",
                    Map = 75,
                    Enc_Ratio = 7,

                    FirstLongBlinkRand_Emu = 52,
                    FirstLongBlinkRand = 52,
                },

                new Location
                {
                    Name = "Safari Zone - Area 1",
                    Map = 222,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Safari Zone - Area 2",
                    Map = 221,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Safari Zone - Area 3",
                    Map = 219,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Safari Zone - Area 4",
                    Map = 220,

                    FirstLongBlinkRand = 58,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Scorched Slab - 1F",
                    Map = 164,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 44,
                },

                new Location
                {
                    Name = "Scorched Slab - B1F",
                    Map = 165,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Scorched Slab - B2F-BF3",
                    Map = 166,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Sea Mauville - Outside",
                    Map = 145,
                    Bag_Advances = 16,

                    FirstLongBlinkRand = 66,
                    FirstLongBlinkRand_Emu = 60,
                },

                new Location
                {
                    Name = "Sea Mauville - Inside",
                    Map = 146,
                },

                new Location
                {
                    Name = "Sealed Chamber",
                    Map = 162,
                    Bag_Advances = 3,

                    //FirstLongBlinkRand = ,
                    //FirstLongBlinkRand_Emu = ,
                },

                new Location
                {
                    Name = "Seafloor Cavern - Entrance",
                    Map = 99,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 52,
                },

                new Location
                {
                    Name = "Seafloor Cavern - 1, 2, 4",
                    Map = 100,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 54,
                    FirstLongBlinkRand_Emu = 50,
                },

                new Location
                {
                    Name = "Seafloor Cavern - 3, 7, 8, 9",
                    Map = 104,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Seafloor Cavern - 5, 6",
                    Map = 102,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,
                },

                new Location
                {
                    Name = "Shoal Cave - Low tide",
                    Map = 130,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Shoal Cave - High tide",
                    Map = 132,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Shoal Cave - Ice room",
                    Map = 134,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 56,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Sky Pillar",
                    Map = 176,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 50,
                    FirstLongBlinkRand_Emu = 48,
                },

                new Location
                {
                    Name = "Slateport City",
                    Map = 14,

                    FirstLongBlinkRand_Emu = 54,
                    FirstLongBlinkRand = 62,
                },

                new Location
                {
                    Name = "Sootopolis City",
                    Map = 20,

                    FirstLongBlinkRand_Emu = 54,
                    FirstLongBlinkRand = 60,
                },

                new Location
                {
                    Name = "Team Magma/Aqua Hideout",
                    Map = 92,
                    Bag_Advances = 6,

                    //FirstLongBlinkRand = ,
                    //FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Victory Road - Default",
                    Map = 123,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

                new Location
                {
                    Name = "Victory Road - 2F",
                    Map = 126,
                    Enc_Ratio = 7,
                    Bag_Advances = 3,

                    FirstLongBlinkRand = 48,
                    FirstLongBlinkRand_Emu = 46,
                },

            };

            return locations;

        }
    }
}

