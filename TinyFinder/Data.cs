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

        public List<Location> SetLocations(byte method, bool oras, bool hordeTurn)
        {
            Location area;
            List<Location> Areas = new List<Location>();
            if (oras)
            {
                if (method == 2)
                {
                    for (byte i = 0; i < FishingORASLocations.GetLength(0); i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(FishingORASLocations[i, 0].ToString()),
                            Bag_Advances = Convert.ToByte(FishingORASLocations[i, 1]),
                            CitraDelayRand = Convert.ToInt32(FishingORASLocations[i, 2]),
                            ConsoleDelayRand = Convert.ToInt32(FishingORASLocations[i, 3]),
                            CitraORASCorr = Convert.ToInt32(FishingORASLocations[i, 4]),
                            ConsoleORASCorr = Convert.ToInt32(FishingORASLocations[i, 5]),
                        };
                        Areas.Add(area);
                    }
                }
                else if (method == 4 && !hordeTurn)
                {
                    for (byte i = 3; i < 10; i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(Horde_Locations[i, 0].ToString()),
                            Bag_Advances = Convert.ToByte(Horde_Locations[i, 1])
                        };
                        Areas.Add(area);
                    }
                }
                else if (method == 1 || method == 4)
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
                else if (method == 5)
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
                if (method == 2)
                {
                    for (byte i = 0; i < FishingXYLocations.GetLength(0); i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(FishingXYLocations[i, 0].ToString()),
                            Bag_Advances = Convert.ToByte(FishingXYLocations[i, 1]),
                            CitraDelayRand = Convert.ToInt32(FishingXYLocations[i, 2]),
                            ConsoleDelayRand = Convert.ToInt32(FishingXYLocations[i, 3]),
                        };
                        Areas.Add(area);
                    }
                }
                else if (method == 4 && !hordeTurn)
                {
                    for (byte i = 0; i < 3; i++)
                    {
                        area = new Location
                        {
                            Name = string.Copy(Horde_Locations[i, 0].ToString()),
                            Bag_Advances = Convert.ToByte(Horde_Locations[i, 1])
                        };
                        Areas.Add(area);
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
            }
            return Areas;
        }

        public void Guides(string guide)
        {
            for (byte g = 0; g < GuideList.GetLength(0); g++)
            {
                if (guide.Equals(GuideList[g, 0]))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(GuideList[g, 1]);
                    }
                    catch 
                    {
                        System.Windows.Forms.MessageBox.Show
                            ("An error has occurred", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
        }

        public readonly static byte[][] SlotDistribution = new byte[][]
        {
            new byte[] { 10,10,10,10,10,10,10,10,10,5,4,1 },    // Wild / Radar
            new byte[] { 50,50 },                               // Friend Safari 2 slots
            new byte[] { 34,33,33 },                            // Friend Safari 3 slots
            new byte[] { 60,35,5 },                             // Horde / Fishing
            new byte[] { 50,30,15,4,1 },                        // Rock Smash / Surfing
        };

        public readonly static object[,] XY_Locations = new object[,]
        {
            //Name, NPC Noise, Has Hordes, Ratio, Tall Grass
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

        public readonly static object[,] ORAS_Locations = new object[,]
        {
            //Name, NPC Noise, Has Hordes/Long Grass, Ratio
            { "Elsewhere", 0, false, 13, },
            { "Mt Pyre Inside", 0, false, 7, },
            { "New Mauville", 0, false, 7, },
            { "Route 111 Desert", 1, false, 1, },    //Ratio is 7 but only 1 works every time
            { "Route 117", 1, false, 13, },
            { "Route 118", 0, true, 13, },
            { "Route 119", 0, true, 13, },
            { "Route 120", 0, true, 13, },
            { "Route 121", 0, true, 13, },
            { "Route 123", 1, true, 13, },
            { "Safari Zone", 0, true, 13, },
            { "Sky Pillar", 0, false, 7, },
            //Honey Wild Locations
            //Name, Bag/Honey Advances, null, null
            { "Elsewhere", 15, null, null, },
            { "Magma/Aqua Hideout", 6, null, null, },
            { "Underwater", 3, null, null, },
        };

        public readonly static object[,] Horde_Locations = new object[,]
        {
            //Name, Bag Advances
            { "Elsewhere", 27, }, //XY
            { "Reflection Cave", 6, },
            { "Route 20", 3, },
            { "Elsewhere", 15 }, //ORAS
            { "Mt Pyre Inside", 3, },
            { "New Mauville", 3, },
            { "Route 114", 16, },
            { "Route 121", 16, },
            { "Rusturf Tunnel", 15, },
            { "Sky Pillar", 3, },
        };

        public readonly static object[,] FishingXYLocations = new object[,]
        {
            //Name, Bag Advances, Frame in which the delay is decided (Delay Rand)
            { "Ambrette Town", 27, 228, 256, },                                                 //
            { "Azure Bay", 27, 216, 242, },                                                     //146??
            { "Couriway Town", 27, 216, 0, },                                                   //
            { "Cyllage City", 27, 228, 256, },                                                  //
            { "Frost Cavern", 3, 194, 210, },                                                   //
            { "Laverre City", 27, 214, 242, },                                                  //
            { "Parfum Palace", 27, 198, 216, },                                                 //
            //{ "Pokemon Village", 27, 198, 212, },  //Problematic                              //
            { "Route 3", 27, 224, 246, },                                                       //144
            { "Route 8", 27, 228, 256, },                                                       //
            { "Route 12", 27, 216, 242, },                                                      //146
            { "Route 14", 27, 214, 242, },                                                      //
            { "Route 15", 27, 204, 222, },                                                      //148?
            { "Route 16", 27, 204, 222, },                                                      //
            { "Route 19", 27, 198, 218, },                                                      //144?
            { "Route 21", 27, 200, 216, },                                                      //
            { "Route 22", 27, 224, 244, },                                                      //
            { "Shalour City", 27, 208, 230, },                                                  //
            { "Victory Road", 3, 212, 226, },                                                   //144?
        };

        //Ratio for cities is at least 67??
        public readonly static object[,] FishingORASLocations = new object[,]
        {
            //Name, Bag Advances, CitraDelayRand, ConsoleDelayRand, Citra correction, Console correction
            { "Battle Resort", 15, 204, 222, 154, 162, },
            //{ "Dewford Town", 15, 0, 0, },
            { "Ever Grande City", 15, 196, 208, 152, 156, },
            { "Lilycove City", 15, 204, 214, 154, 162, },
            //{ "Magma Hideout", 6, 196, 0, 0, 0, },                        //Very Problematic
            { "Meteor Falls - Not Entrance", 3, 194, 204, 152, 154, },
            //{ "Mossdeep City", 15, 0, 0, 0, 0, },
            //{ "Pacifidlog Town", 15, 0, 0, 0, 0, },
            { "Petalburg City", 15, 200, 212, 152, 162, },
            //{ "Route 102", 15, 0, 0, 0, 0, },
            //{ "Route 103", 15, 0, 0, 0, 0, },
            //{ "Route 104 North", 15, 202, 0, 0, 0, },
            //{ "Route 105", 15, 0, 0, 0, 0, },
            //{ "Route 106", 15, 0, 0, 0, 0, },
            //{ "Route 107", 15, 0, 0, 0, 0, },
            //{ "Route 108", 15, 0, 0, 0, 0, },
            //{ "Route 109", 15, 0, 0, 0, 0, },
            //{ "Route 110", 15, 0, 0, 0, 0, },
            //{ "Route 111", 15, 0, 0, 0, 0, },
            //{ "Route 114", 16, 0, 0, 0, 0, },
            //{ "Route 115", 15, 0, 0, 0, 0, },
            { "Route 117", 15, 202, 214, 152, 164, },                       //
            { "Route 118", 15, 196, 216, 154, 168, },                       //
            { "Route 119", 15, 204, 226, 152, 166, },
            //{ "Route 120", 15, 0, 0, 0, 0, },
            //{ "Route 122", 15, 0, 0, 0, 0, },
            { "Route 123", 15, 196, 214, 154, 166, },                       //Check citra again
            //{ "Route 124", 15, 0, 0, 0, 0, },
            //{ "Route 125", 15, 0, 0, 0, 0, },
            //{ "Route 126", 15, 0, 0, 0, 0, },
            //{ "Route 127", 15, 0, 0, 0, 0, },
            { "Route 128", 15, 196, 210, 152, 162, },
            //{ "Route 129", 15, 0, 0, 0, },
            { "Route 130", 15, 196, 208, 154, 162, },                       //
            //{ "Route 131", 15, 0, 0, 0, 0, },
            //{ "Route 132", 15, 0, 0, 0, 0, },
            //{ "Route 133", 15, 0, 0, 0, 0, },
            //{ "Route 134", 15, 0, 0, 0, 0, },
            { "Safari Zone", 15, 196, 210, 152, 156, },
            { "Scorched Slab", 3, 192, 202, 152, 156, },
            //{ "Sea Mauville", 15, 0, 0, 0, 0, },
            //{ "Seafloor Cavern - Entrance", 3, 0, 0, 0, 0, },
            //{ "Sealed Chamber", 15, 194, 204, 152, 164, },                //3ds????
            //{ "Shoal Cave", 3, 0, 0, 0, },
            { "Slateport City", 15, 204, 216, 154, 164, },                  //
            { "Sootopolis City", 15, 202, 212, 152, 156, },
            { "Victory Road - Entrance", 3, 194, 202, 152, 156, },
        };

        public readonly static string[,] GuideList = new string[,] 
        {
            { "Initial Seed RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6MTSeedRNG.md#gen-6-main-mt-seed-rng" },
            { "TID / SID RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6TidSidRNG.md#gen-6-tidsid-rng-on-citra" },
            { "Normal  Wild / FS RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/NormalWild-FS-RNG.md#normal-wild---friend-safari-rng" },
            { "Horde RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/HordeRNG.md#horde-encounter-rng-abuse-guide" },
            { "DexNav RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/DexNavRNG.md#dexnav-rng-abuse-guide" },
        };

        public string[] GetNatures() => Natures;

        private readonly static string[] Natures = 
        { 
            "Hardy",
            "Lonely",
            "Brave",
            "Adamant",
            "Naughty", 
            "Bold", 
            "Docile", 
            "Relaxed", 
            "Impish", 
            "Lax", 
            "Timid", 
            "Hasty", 
            "Serious",
            "Jolly", 
            "Naive", 
            "Modest", 
            "Mild", 
            "Quiet", 
            "Bashful", 
            "Rash", 
            "Calm", 
            "Gentle", 
            "Sassy", 
            "Careful", 
            "Quirky",
        };

        public object[,] GetFSSlots() => FS_Species;

        private readonly static object[,] FS_Species = new object[,]
        {
            { "Abra", 1, },
            { "Absol", 3, },
            { "Aipom", 1, },
            { "Audino", 2, },
            { "Ariados", 2, },
            { "Azumarill", 3, },
            { "Barbaracle", 3, },
            { "Beartic", 2, },
            { "Beautifly", 2, },
            { "Bergmite", 2, },
            { "Bibarel", 1, },
            { "Boldore", 1, },
            { "Braixen", 3, },
            { "Breloom", 3, },
            { "Bronzong", 3, },
            { "Butterfree", 1, },
            { "Cacturne", 2, },
            { "Camerupt", 2, },
            { "Cascoon", 1, },
            { "Chansey", 3, },
            { "Charmeleon", 2, },
            { "Clefairy", 3, },
            { "Cloyster", 3, },
            { "Combee", 1, },
            { "Corsola", 2, },
            { "Crawdaunt", 2, },
            { "Dedenne", 1, },
            { "Delibird", 1, },
            { "Dewgong", 3, },
            { "Diggersby", 3, },
            { "Ditto", 3, },
            { "Doduo", 1, },
            { "Dragonair", 2, },
            { "Drapion", 3, },
            { "Drifblim", 3, },
            { "Drowzee", 1, },
            { "Dugtrio", 2, },
            { "Dunsparce", 1, },
            { "Dousion", 3, },
            { "Druddigon", 3, },
            { "Dusclops", 3, },
            { "Dwebble", 1, },
            { "Eevee", 3, },
            { "Electabuzz", 2, },
            { "Electrode", 1, },
            { "Emolga", 1, },
            { "Espurr", 2, },
            { "Excadrill", 3, },
            { "Farfetch'd", 1, },
            { "Ferroseed", 1, },
            { "Fletchinder", 3, },
            { "Floatzel", 2, },
            { "Floette", 3, },
            { "Forretress", 2, },
            { "Fraxure", 1, },
            { "Frogadier", 3, },
            { "Gabite", 1, },
            { "Galvantula", 3, },
            { "Garbodor", 2, },
            { "Gastrodon", 3, },
            { "Girafarig", 3, },
            { "Gloom", 1, },
            { "Gogoat", 3, },
            { "Golurk", 3, },
            { "Gothorita", 3, },
            { "Growlithe", 1, },
            { "Grumpig", 1, },
            { "Gyarados", 2, },
            { "Hariyama", 3, },
            { "Hawlucha", 3, },
            { "Helioptile", 2, },
            { "Heracross", 3, },
            { "Hoothoot", 2, },
            { "Illumise", 2, },
            { "Inkay", 3, },
            { "Ivysaur", 2, },
            { "Jigglypuff", 2, },
            { "Kakuna", 1, },
            { "Kecleon", 2, },
            { "Kirlia", 1, },
            { "Klang", 2, },
            { "Klefki", 3, },
            { "Krabby", 1, },
            { "Lampent", 1, },
            { "Lapras", 3, },
            { "Larvesta", 2, },
            { "Ledyba", 1, },
            { "Liepard", 3, },
            { "Lillipup", 1, },
            { "Loudred", 2, },
            { "Luxio", 3, },
            { "Machoke", 1, },
            { "Magcargo", 2, },
            { "Magmar", 1, },
            { "Magneton", 1, },
            { "Manectric", 3, },
            { "Mankey", 1, },
            { "Maractus", 3, },
            { "Marowak", 2, },
            { "Masquerain", 2, },
            { "Mawile Fairy", 2, },
            { "Mawile Steel", 1, },
            { "Meditite", 1, },
            { "Metang", 2, },
            { "Miccino", 2, },
            { "Mienfoo", 1, },
            { "Mightyena", 1, },
            { "Muk", 3, },
            { "Munna", 1, },
            { "Nincada", 2, },
            { "Ninetales", 3, },
            { "Noibat", 2, },
            { "Nosepass", 1, },
            { "Nuzleaf", 1, },
            { "Octillery", 1, },
            { "Oddish", 1, },
            { "Onix", 2, },
            { "Pachirisu", 1, },
            { "Palpitoad", 3, },
            { "Pancham", 2, },
            { "Panpour", 1, },
            { "Pansage", 1, },
            { "Pansear", 1, },
            { "Paras", 1, },
            { "Pawniard", 1, },
            { "Petilil", 2, },
            { "Phanpy", 1, },
            { "Phantump", 2, },
            { "Pidgey", 1, },
            { "Pikachu", 2, },
            { "Piloswine", 3, },
            { "Pinsir", 3, },
            { "Poliwhirl", 3, },
            { "Ponyta", 1, },
            { "Pumpkaboo", 2, },
            { "Pupitar", 2, },
            { "Pyroar", 2, },
            { "Quagsire", 2, },
            { "Quilladin", 3, },
            { "Rhydon", 3, },
            { "Riolu", 3, },
            { "Rufflet", 3, },
            { "Sableye", 3, },
            { "Sandile", 2, },
            { "Sandshrew", 1, },
            { "Sawk", 2, },
            { "Sawsbuck", 2, },
            { "Seviper", 1, },
            { "Shelgon", 2, },
            { "Shuckle", 3, },
            { "Shuppet", 1, },
            { "Sigilyph", 2, },
            { "Skarmory", 2, },
            { "Sliggoo", 3, },
            { "Slugma", 2, },
            { "Smeargle", 3, },
            { "Sneasel", 2, },
            { "Snorunt", 1, },
            { "Snover", 1, },
            { "Snubbull", 1, },
            { "Spearow", 1, },
            { "Spheal", 1, },
            { "Spiritomb", 3, },
            { "Spritzee", 2, },
            { "Stunfisk", 2, },
            { "Sunkern", 1, },
            { "Swadloon", 2, },
            { "Swalot", 2, },
            { "Swanna", 2, },
            { "Swirlix", 2, },
            { "Tangela", 1, },
            { "Teddiursa", 1, },
            { "Throh", 2, },
            { "Togepi", 1, },
            { "Toxicroak", 3, },
            { "Tranquill", 2, },
            { "Trapinch", 1, },
            { "Tropius", 3, },
            { "Tyrogue", 3, },
            { "Vivillon", 3, },
            { "Venomoth Bug", 3, },
            { "Venomoth Poison", 2, },
            { "Volbeat", 2, },
            { "Vullaby", 1, },
            { "Wartortle", 2, },
            { "Whirlipede", 3, },
            { "Wobuffet", 2, },
            { "Woobat", 2, },
            { "Wooper", 1, },
            { "Xatu", 3, },
            { "Zebstrika", 3, },
        };

    }
}
