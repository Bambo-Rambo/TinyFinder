using System;
using System.Collections.Generic;

namespace TinyFinder
{
    class Data
    {
        public int getSlot(int rand, int SlotType)
        {
            var SlotSplitter = SlotDistribution[SlotType];
            for (int i = 1; i < SlotSplitter.Length; i++)
            {
                rand -= SlotSplitter[i - 1];
                if (rand < 0)
                    return i;
            }
            return SlotSplitter.Length;
        }

        public readonly static int[][] SlotDistribution = new int[][]
        {
            new int[] { 10,10,10,10,10,10,10,10,10,5,4,1 },    // Wild / Radar / Swooping
            new int[] { 50,50 },                               // Friend Safari 2 slots
            new int[] { 34,33,33 },                            // Friend Safari 3 slots
            new int[] { 60,35,5 },                             // Horde / Fishing
            new int[] { 50,30,15,4,1 },                        // Rock Smash / Surfing
        };

        public readonly static string[,] GuideList = new string[,]
        {
            { "Initial Seed RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6MTSeedRNG.md#gen-6-main-mt-seed-rng" },
            { "TID / SID RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6TidSidRNG.md#gen-6-tidsid-rng-on-citra" },
            { "Normal  Wild / FS RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/NormalWild-FS-RNG.md#normal-wild---friend-safari-rng" },
            { "Horde RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/HordeRNG.md#horde-encounter-rng-abuse-guide" },
            { "DexNav RNG", "https://github.com/Bambo-Rambo/RNG-Guides/blob/main/DexNavRNG.md#dexnav-rng-abuse-guide" },
        };

        public void Guides(string guide)
        {
            for (int g = 0; g < GuideList.GetLength(0); g++)
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

    }
}
