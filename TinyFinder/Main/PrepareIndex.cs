using System;
using System.Collections.Generic;
using System.Linq;
using TinyFinder.Controls;

namespace TinyFinder.Main
{
    internal class PrepareIndex
    {
        static Species pokemon;
        static Species[] HordePokemon;
        static int[] HordeLevels;
        static ushort DexNumber = 0;

        public static Index Prepare(Index index, UISettings current)
        {
            int slot = index.slot - 1;
            int tempLevel = 0;

            switch (current.method)
            {
                case 4:
                    HordePokemon = new Species[5];
                    HordeLevels = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        DexNumber = current.currentSlots[slot * 5 + i];
                        HordePokemon[i] = Species.SpeciesList.ElementAt(DexNumber);
                        HordeLevels[i] = current.currentLevels[slot];
                    }
                    break;

                case 6:
                    if (current.oras)
                    {
                        if (index.EnctrType == 2)   // Only when the result is DexNav exclusive
                        {
                            index.Type = "DexNav";
                            DexNumber = current.specialSlots[slot];
                            tempLevel = current.dexNavLevel;
                        }
                        else
                        {
                            index.Type = "Normal";
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


            // Actual Level calculation
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

            if (current.method == 4)
            {
                index.SpeciesName = string.Join(", ", HordePokemon.Select(species => species.Name).ToArray());
                index.Level = string.Join(", ", HordeLevels.Select(lvl => lvl.ToString()));
                string[] tempItems = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    tempItems[i] = GetItem(HordePokemon[i], index.itemSlots[i], current.oras);
                }
                index.item = string.Join(", ", tempItems.Select(item => item));
            }
            else
            {
                pokemon = Species.SpeciesList.ElementAt(DexNumber);
                index.SpeciesName = pokemon.Name;
                index.Level = tempLevel.ToString();
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
                    int eggRand = current.maxEggRand < 10 ? 1 : pokemon.eggRand;
                    if (current.Show_Alt_EggMove)
                        eggRand += 2;

                    if (!(pokemon.oras5.Length == 1 && pokemon.oras50.Length == 1 && pokemon.item5.Length == 1 && pokemon.item50.Length == 1))
                        if (index.item.Length == 1)     // Can have held item but doesn't
                            eggRand++;

                    int eggSlot = (int)((index.eggRands[eggRand] * pokemon.eggMoves.Count) >> 32);
                    string tempEggMove = pokemon.eggMoves.ElementAt(eggSlot);

                    List<string> LevelUpMoves = new List<string>();
                    foreach (var move in pokemon.moves)
                        LevelUpMoves.Add(move.Name);

                    if (LevelUpMoves.Contains(tempEggMove))
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
                        while (movesAtLevel.Contains(tempEggMove))
                        {
                            eggSlot++;
                            eggSlot %= pokemon.eggMoves.Count;
                            tempEggMove = pokemon.eggMoves.ElementAt(eggSlot);
                        }
                    }
                    /*else  // Not correct because it ignores cases where the next eggSlot was used
                    {
                        index.goodEggMove = !Move.LearnableMoves.Contains(tempEggMove);
                    }*/

                    index.eggMove = tempEggMove;
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
