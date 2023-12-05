using System;
using System.Collections.Generic;
using System.Linq;
using TinyFinder.Controls;

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

            // Species Name and temp Level
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

                            int levelSlot = (int)((index.LevelRand * Levels.Count) >> 32);
                            tempLevel = Levels[levelSlot];
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


            // Level Finalize
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


            // Egg Move
            if (current.method == 6 && current.oras)
            {
                if (pokemon.eggMoves.Count == 0 || index.eggRands.Count == 0)
                    index.eggMove = "-";
                else
                {
                    // Base rand calls consumption is 1 for (long) grass, otherwise each Pokemon has its own
                    int eggRand = current.maxEggRand == 2 ? 1 : pokemon.eggRand;

                    if (!(pokemon.oras5.Length == 1 && pokemon.oras50.Length == 1 && pokemon.item5.Length == 1 && pokemon.item50.Length == 1))
                        if (index.item.Length == 1)     // Can have held item but doesn't
                            eggRand++;

                    int eggSlot = (int)((index.eggRands[eggRand] * pokemon.eggMoves.Count) >> 32);

                    List<string> LevelUpMoves = new List<string>();
                    foreach (var move in pokemon.moves)
                        LevelUpMoves.Add(move.Name);

                    if (LevelUpMoves.Contains(pokemon.eggMoves.ElementAt(eggSlot)))
                    {
                        // If the wild Pokemon already knows the egg move, the next egg slot will be used instead
                        List<string> movesAtLevel = new List<string>();
                        for (int i = pokemon.moves.Count - 1; i >= 0; i--)
                        {
                            if (pokemon.moves.ElementAt(i).At > tempLevel)
                                continue;

                            movesAtLevel.Add(pokemon.moves.ElementAt(i).Name);
                            if (movesAtLevel.Count == 4)
                                break;
                        }

                        // A loop is necessary because Krabby, Pelipper and Luvdisc might know 2 consecutive egg slot moves simultaneously
                        while (movesAtLevel.Contains(pokemon.eggMoves.ElementAt(eggSlot)))
                        {
                            eggSlot++;
                            eggSlot %= pokemon.eggMoves.Count;
                        }
                    }
                    /*else  // Not correct because it ignores cases where the next eggSlot was used
                    {
                        index.goodEggMove = !Move.LearnableMoves.Contains(pokemon.eggMoves.ElementAt(eggSlot));
                    }*/

                    index.eggMove = pokemon.eggMoves.ElementAt(eggSlot);
                    index.goodEggMove = !Move.ManualLearnMoves.Contains(index.eggMove) && !LevelUpMoves.Contains(index.eggMove);  // Correct
                }
            }

            return index;
        }


        private static string GetItem(Species pokemon, int itemSlot, bool oras)
        {
            // Length != 1 means the Pokemon may have an item (not '-')

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
