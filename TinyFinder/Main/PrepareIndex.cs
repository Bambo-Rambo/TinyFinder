using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TinyFinder.Main
{
    internal class PrepareIndex
    {
        static int[] HordeLevels;
        static ushort DexNumber = 0;

        public static Index Prepare(Index index, UISettings current)
        {
            int slot = index.slot - 1;
            int tempLevel = 0;


            // Species Name
            switch (current.method)
            {
                case 4:
                    DexNumber = current.currentSlots[slot];
                    HordeLevels = new int[5];
                    for (int i = 0; i < 5; i++)
                        HordeLevels[i] = current.currentLevels[slot];
                    break;

                case 6:
                    if (current.oras)
                    {
                        if (index.EnctrType == 2)   // Only when the result is dexnav exclusive
                        {
                            DexNumber = current.specialSlots[slot];
                            tempLevel = current.dexNavLevel;
                        }
                        else
                        {
                            DexNumber = current.currentSlots[slot];

                            // A list of all level slots for a given species/location combo is created,
                            // then one of them is chosen "randomly"
                            List <int> Levels = new List <int>();
                            for (int i = 0; i < current.currentSlots.Length; i++)
                                if (current.currentSlots[i] == DexNumber)
                                    Levels.Add(current.currentLevels[i]);

                            int rand = (int)((index.LevelRand * Levels.Count) >> 32);
                            tempLevel = Levels[rand];
                        }
                        tempLevel += index.LevelBoost;
                    }
                    else
                    {
                        DexNumber = current.currentSlots[slot];
                        tempLevel = current.currentLevels[slot];
                    }
                    break;

                case 7:
                    DexNumber = current.DexNumberFS;
                    tempLevel = 30;
                    break;

                default:

                    DexNumber = current.currentSlots[slot];
                    tempLevel = current.currentLevels[slot];
                    break;
            }
            Species pokemon = Species.SpeciesList.ElementAt(DexNumber);
            index.SpeciesName = pokemon.Name;


            // Level
            switch (current.fluteOption)
            {
                case 1:     // Black Flute
                    if (current.method != 4)
                        tempLevel += index.flute;
                    else
                        for (int i = 0; i < 5; i++)
                            HordeLevels[i] += index.flutes[i];
                    break;

                case 2:     // White Flute
                    if (current.method != 4)
                    {
                        tempLevel -= index.flute;
                        if (tempLevel < 1)
                            tempLevel = 1;
                    }  
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            HordeLevels[i] -= index.flutes[i];
                            if (HordeLevels[i] < 1)
                                HordeLevels[i] = 1;
                        }
                            
                    }
                    break;
            }
            if (current.method != 4)
                index.Level = tempLevel.ToString();
            else
                index.Level = string.Join(", ", HordeLevels.Select(lvl => lvl.ToString()));


            // Held Item
            if (current.method == 4)
            {
                string[] tempItems = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    tempItems[i] = GetItem(pokemon, index.itemSlots[i], current.oras);
                }
                index.item = string.Join(", ", tempItems.Select(item => item));
            }
            else
            {
                index.item = GetItem(pokemon, index.itemSlot, current.oras);
            }

            return index;
        }


        private static string GetItem(Species pokemon, int itemSlot, bool oras)
        {
            string itemName = "-";
            if (pokemon.item100.Length != 1)                // Lapras from Azure Bay and Pumpkaboo super
                itemName = pokemon.item100;
            else if (!oras && pokemon.xy100.Length != 1)    // Seviper in XY hordes only
                itemName = pokemon.xy100;

            else if (itemSlot == 0)
            {
                if (oras && pokemon.oras50.Length != 1)
                {
                    itemName = pokemon.oras50;
                }
                else if (!oras && pokemon.xy50.Length != 1)
                {
                    itemName = pokemon.xy50;
                }
                else
                {
                    itemName = pokemon.item50;
                }
            }
            else if (itemSlot == 1)
            {
                if (oras && pokemon.oras5.Length != 1)
                {
                    itemName = pokemon.oras5;
                }
                else if (!oras && pokemon.xy5.Length != 1)
                {
                    itemName = pokemon.xy5;
                }
                else
                {
                    itemName = pokemon.item5;
                }
            }
            return itemName;
        }
    }
}
