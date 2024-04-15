using System;
using System.Collections.Generic;
using System.Linq;
using TinyFinder.Controls;

namespace TinyFinder
{
    internal class Species
    {
        public string Name;
        public int eggRand;
        public bool FS;

        public string item100 = "-";
        public string item50 = "-";
        public string item5 = "-";

        public string xy100 = "-";
        public string xy50 = "-";
        public string xy5 = "-";

        //public string oras100= "-";
        public string oras50 = "-";
        public string oras5 = "-";

        public List<string> eggMoves = new List<string>();
        public List<Move> moves = new List<Move>();
        public static List<ushort> getFSList()
        {
            List<ushort> FSList = new List<ushort>();
            for (ushort i = 0; i < SpeciesList.Count; i++)
                if (SpeciesList.ElementAt(i).FS)
                    FSList.Add(i);
            return FSList;
        }


        public readonly static List<Species> SpeciesList = new List<Species>()
            {
                new Species() {
                    Name = "None",
                },

                new Species() {
                    Name = "Bulbasaur",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Leech Seed", At = 7 }, new Move { Name = "Vine Whip", At = 9 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Sleep Powder", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Razor Leaf", At = 19 }, new Move { Name = "Sweet Scent", At = 21 }, new Move { Name = "Growth", At = 25 }, new Move { Name = "Double-Edge", At = 27 }, new Move { Name = "Worry Seed", At = 31 }, new Move { Name = "Synthesis", At = 33 }, new Move { Name = "Seed Bomb", At = 37 }, },
                    eggMoves = { "Skull Bash", "Charm", "Petal Dance", "Magical Leaf", "Grass Whistle", "Curse", "Ingrain", "Nature Power", "Amnesia", "Leaf Storm", "Power Whip", "Sludge", "Endure", "Giga Drain", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Ivysaur",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Leech Seed", At = 7 }, new Move { Name = "Vine Whip", At = 9 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Sleep Powder", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Razor Leaf", At = 20 }, new Move { Name = "Sweet Scent", At = 23 }, new Move { Name = "Growth", At = 28 }, new Move { Name = "Double-Edge", At = 31 }, new Move { Name = "Worry Seed", At = 36 }, new Move { Name = "Synthesis", At = 39 }, new Move { Name = "Solar Beam", At = 44 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Venusaur",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Leech Seed", At = 7 }, new Move { Name = "Vine Whip", At = 9 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Sleep Powder", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Razor Leaf", At = 20 }, new Move { Name = "Sweet Scent", At = 23 }, new Move { Name = "Growth", At = 28 }, new Move { Name = "Double-Edge", At = 31 }, new Move { Name = "Petal Dance", At = 32 }, new Move { Name = "Worry Seed", At = 39 }, new Move { Name = "Synthesis", At = 45 }, new Move { Name = "Petal Blizzard", At = 50 }, new Move { Name = "Solar Beam", At = 53 }, },
                },

                new Species() {
                    Name = "Charmander",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Smokescreen", At = 10 }, new Move { Name = "Dragon Rage", At = 16 }, new Move { Name = "Scary Face", At = 19 }, new Move { Name = "Fire Fang", At = 25 }, new Move { Name = "Flame Burst", At = 28 }, new Move { Name = "Slash", At = 34 }, new Move { Name = "Flamethrower", At = 37 }, new Move { Name = "Fire Spin", At = 43 }, new Move { Name = "Inferno", At = 46 }, },
                    eggMoves = { "Belly Drum", "Ancient Power", "Bite", "Outrage", "Beat Up", "Dragon Dance", "Crunch", "Dragon Rush", "Metal Claw", "Flare Blitz", "Counter", "Dragon Pulse", "Focus Punch", "Air Cutter", },
                },

                new Species() {
                    Name = "Charmeleon",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Smokescreen", At = 10 }, new Move { Name = "Dragon Rage", At = 17 }, new Move { Name = "Scary Face", At = 21 }, new Move { Name = "Fire Fang", At = 28 }, new Move { Name = "Flame Burst", At = 32 }, new Move { Name = "Slash", At = 39 }, new Move { Name = "Flamethrower", At = 43 }, new Move { Name = "Fire Spin", At = 50 }, new Move { Name = "Inferno", At = 54 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Charizard",
                    moves = { new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Heat Wave", At = 1 }, new Move { Name = "Dragon Claw", At = 1 }, new Move { Name = "Shadow Claw", At = 1 }, new Move { Name = "Air Slash", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Smokescreen", At = 10 }, new Move { Name = "Dragon Rage", At = 17 }, new Move { Name = "Scary Face", At = 21 }, new Move { Name = "Fire Fang", At = 28 }, new Move { Name = "Flame Burst", At = 32 }, new Move { Name = "Wing Attack", At = 36 }, new Move { Name = "Slash", At = 41 }, new Move { Name = "Flamethrower", At = 47 }, new Move { Name = "Fire Spin", At = 56 }, new Move { Name = "Inferno", At = 62 }, new Move { Name = "Heat Wave", At = 71 }, new Move { Name = "Flare Blitz", At = 77 }, },
                },

                new Species() {
                    Name = "Squirtle",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Withdraw", At = 10 }, new Move { Name = "Bubble", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Rapid Spin", At = 19 }, new Move { Name = "Protect", At = 22 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Aqua Tail", At = 28 }, new Move { Name = "Skull Bash", At = 31 }, new Move { Name = "Iron Defense", At = 34 }, new Move { Name = "Rain Dance", At = 37 }, new Move { Name = "Hydro Pump", At = 40 }, },
                    eggMoves = { "Mirror Coat", "Haze", "Mist", "Foresight", "Flail", "Refresh", "Mud Sport", "Yawn", "Muddy Water", "Fake Out", "Aqua Ring", "Aqua Jet", "Water Spout", "Brine", "Dragon Pulse", "Aura Sphere", },
                },

                new Species() {
                    Name = "Wartortle",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Withdraw", At = 10 }, new Move { Name = "Bubble", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Rapid Spin", At = 20 }, new Move { Name = "Protect", At = 24 }, new Move { Name = "Water Pulse", At = 28 }, new Move { Name = "Aqua Tail", At = 32 }, new Move { Name = "Skull Bash", At = 36 }, new Move { Name = "Iron Defense", At = 40 }, new Move { Name = "Rain Dance", At = 44 }, new Move { Name = "Hydro Pump", At = 48 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Blastoise",
                    moves = { new Move { Name = "Flash Cannon", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Withdraw", At = 10 }, new Move { Name = "Bubble", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Rapid Spin", At = 20 }, new Move { Name = "Protect", At = 24 }, new Move { Name = "Water Pulse", At = 28 }, new Move { Name = "Aqua Tail", At = 32 }, new Move { Name = "Skull Bash", At = 39 }, new Move { Name = "Iron Defense", At = 46 }, new Move { Name = "Rain Dance", At = 53 }, new Move { Name = "Hydro Pump", At = 60 }, },
                },

                new Species() {
                    Name = "Caterpie",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Bug Bite", At = 15 }, },
                },

                new Species() {
                    Name = "Metapod",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Harden", At = 7 }, },
                },

                new Species() {
                    Name = "Butterfree",
                    moves = { new Move { Name = "Confusion", At = 1 }, new Move { Name = "Confusion", At = 10 }, new Move { Name = "Poison Powder", At = 12 }, new Move { Name = "Stun Spore", At = 12 }, new Move { Name = "Sleep Powder", At = 12 }, new Move { Name = "Gust", At = 16 }, new Move { Name = "Supersonic", At = 18 }, new Move { Name = "Whirlwind", At = 22 }, new Move { Name = "Psybeam", At = 24 }, new Move { Name = "Silver Wind", At = 28 }, new Move { Name = "Tailwind", At = 30 }, new Move { Name = "Rage Powder", At = 34 }, new Move { Name = "Safeguard", At = 36 }, new Move { Name = "Captivate", At = 40 }, new Move { Name = "Bug Buzz", At = 42 }, new Move { Name = "Quiver Dance", At = 46 }, },
                    FS = true,
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Weedle",
                    moves = { new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Bug Bite", At = 15 }, },
                },

                new Species() {
                    Name = "Kakuna",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Harden", At = 7 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Beedrill",
                    moves = { new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Fury Attack", At = 10 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Twineedle", At = 16 }, new Move { Name = "Rage", At = 19 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Toxic Spikes", At = 25 }, new Move { Name = "Pin Missile", At = 28 }, new Move { Name = "Agility", At = 31 }, new Move { Name = "Assurance", At = 34 }, new Move { Name = "Poison Jab", At = 37 }, new Move { Name = "Endeavor", At = 40 }, new Move { Name = "Fell Stinger", At = 45 }, },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Pidgey",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Gust", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Whirlwind", At = 17 }, new Move { Name = "Twister", At = 21 }, new Move { Name = "Feather Dance", At = 25 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Wing Attack", At = 33 }, new Move { Name = "Roost", At = 37 }, new Move { Name = "Tailwind", At = 41 }, new Move { Name = "Mirror Move", At = 45 }, new Move { Name = "Air Slash", At = 49 }, new Move { Name = "Hurricane", At = 53 }, },
                    eggMoves = { "Pursuit", "Feint Attack", "Foresight", "Steel Wing", "Air Cutter", "Air Slash", "Brave Bird", "Uproar", "Defog", },
                    FS = true,
                },

                new Species() {
                    Name = "Pidgeotto",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Gust", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Whirlwind", At = 17 }, new Move { Name = "Twister", At = 22 }, new Move { Name = "Feather Dance", At = 27 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Wing Attack", At = 37 }, new Move { Name = "Roost", At = 42 }, new Move { Name = "Tailwind", At = 47 }, new Move { Name = "Mirror Move", At = 52 }, new Move { Name = "Air Slash", At = 57 }, new Move { Name = "Hurricane", At = 62 }, },
                    eggMoves = { "Pursuit", "Feint Attack", "Foresight", "Steel Wing", "Air Cutter", "Air Slash", "Brave Bird", "Uproar", "Defog", },
                },

                new Species() {
                    Name = "Pidgeot",
                    moves = { new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Gust", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Whirlwind", At = 17 }, new Move { Name = "Twister", At = 22 }, new Move { Name = "Feather Dance", At = 27 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Wing Attack", At = 38 }, new Move { Name = "Roost", At = 44 }, new Move { Name = "Tailwind", At = 50 }, new Move { Name = "Mirror Move", At = 56 }, new Move { Name = "Air Slash", At = 62 }, new Move { Name = "Hurricane", At = 68 }, },
                },

                new Species() {
                    Name = "Rattata",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Quick Attack", At = 4 }, new Move { Name = "Focus Energy", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Hyper Fang", At = 16 }, new Move { Name = "Sucker Punch", At = 19 }, new Move { Name = "Crunch", At = 22 }, new Move { Name = "Assurance", At = 25 }, new Move { Name = "Super Fang", At = 28 }, new Move { Name = "Double-Edge", At = 31 }, new Move { Name = "Endeavor", At = 34 }, },
                    eggMoves = { "Screech", "Flame Wheel", "Fury Swipes", "Bite", "Counter", "Reversal", "Uproar", "Last Resort", "Me First", "Revenge", "Final Gambit", },
                },

                new Species() {
                    Name = "Raticate",
                    moves = { new Move { Name = "Swords Dance", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Quick Attack", At = 4 }, new Move { Name = "Focus Energy", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Hyper Fang", At = 16 }, new Move { Name = "Sucker Punch", At = 19 }, new Move { Name = "Scary Face", At = 20 }, new Move { Name = "Crunch", At = 24 }, new Move { Name = "Assurance", At = 29 }, new Move { Name = "Super Fang", At = 34 }, new Move { Name = "Double-Edge", At = 39 }, new Move { Name = "Endeavor", At = 44 }, },
                    eggMoves = { "Screech", "Flame Wheel", "Fury Swipes", "Bite", "Counter", "Reversal", "Uproar", "Last Resort", "Me First", "Revenge", "Final Gambit", },
                },

                new Species() {
                    Name = "Spearow",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leer", At = 5 }, new Move { Name = "Fury Attack", At = 9 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Aerial Ace", At = 17 }, new Move { Name = "Mirror Move", At = 21 }, new Move { Name = "Agility", At = 25 }, new Move { Name = "Assurance", At = 29 }, new Move { Name = "Roost", At = 33 }, new Move { Name = "Drill Peck", At = 37 }, },
                    eggMoves = { "Feint Attack", "Scary Face", "Quick Attack", "Tri Attack", "Astonish", "Sky Attack", "Whirlwind", "Uproar", "Feather Dance", "Steel Wing", "Razor Wind", },
                    FS = true,
                },

                new Species() {
                    Name = "Fearow",
                    moves = { new Move { Name = "Drill Run", At = 1 }, new Move { Name = "Pluck", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Leer", At = 5 }, new Move { Name = "Fury Attack", At = 9 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Aerial Ace", At = 17 }, new Move { Name = "Mirror Move", At = 23 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Assurance", At = 35 }, new Move { Name = "Roost", At = 41 }, new Move { Name = "Drill Peck", At = 47 }, new Move { Name = "Drill Run", At = 53 }, },
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Ekans",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Poison Sting", At = 4 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Glare", At = 12 }, new Move { Name = "Screech", At = 17 }, new Move { Name = "Acid", At = 20 }, new Move { Name = "Stockpile", At = 25 }, new Move { Name = "Swallow", At = 25 }, new Move { Name = "Spit Up", At = 25 }, new Move { Name = "Acid Spray", At = 28 }, new Move { Name = "Mud Bomb", At = 33 }, new Move { Name = "Gastro Acid", At = 36 }, new Move { Name = "Belch", At = 38 }, new Move { Name = "Haze", At = 41 }, new Move { Name = "Coil", At = 44 }, new Move { Name = "Gunk Shot", At = 49 }, },
                    eggMoves = { "Pursuit", "Slam", "Spite", "Beat Up", "Poison Fang", "Scary Face", "Poison Tail", "Disable", "Switcheroo", "Iron Tail", "Sucker Punch", "Snatch", },
                },

                new Species() {
                    Name = "Arbok",
                    moves = { new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Poison Sting", At = 4 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Glare", At = 12 }, new Move { Name = "Screech", At = 17 }, new Move { Name = "Acid", At = 20 }, new Move { Name = "Crunch", At = 22 }, new Move { Name = "Stockpile", At = 27 }, new Move { Name = "Swallow", At = 27 }, new Move { Name = "Spit Up", At = 27 }, new Move { Name = "Acid Spray", At = 32 }, new Move { Name = "Mud Bomb", At = 39 }, new Move { Name = "Gastro Acid", At = 44 }, new Move { Name = "Belch", At = 48 }, new Move { Name = "Haze", At = 51 }, new Move { Name = "Coil", At = 56 }, new Move { Name = "Gunk Shot", At = 63 }, },
                },

                new Species() {
                    Name = "Pikachu",
                    moves = { new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Play Nice", At = 7 }, new Move { Name = "Quick Attack", At = 10 }, new Move { Name = "Electro Ball", At = 13 }, new Move { Name = "Thunder Wave", At = 18 }, new Move { Name = "Feint", At = 21 }, new Move { Name = "Double Team", At = 23 }, new Move { Name = "Spark", At = 26 }, new Move { Name = "Nuzzle", At = 29 }, new Move { Name = "Discharge", At = 34 }, new Move { Name = "Slam", At = 37 }, new Move { Name = "Thunderbolt", At = 42 }, new Move { Name = "Agility", At = 45 }, new Move { Name = "Wild Charge", At = 50 }, new Move { Name = "Light Screen", At = 53 }, new Move { Name = "Thunder", At = 58 }, },
                    eggMoves = { "Reversal", "Bide", "Present", "Encore", "Double Slap", "Wish", "Charge", "Fake Out", "Thunder Punch", "Tickle", "Flail", "Endure", "Lucky Chant", "Bestow", "Disarming Voice", },
                    FS = true,
                    item5 = "Light Ball",
                },

                new Species() {
                    Name = "Raichu",
                    moves = { new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Thunderbolt", At = 1 }, },
                },

                new Species() {
                    Name = "Sandshrew",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Sand Attack", At = 3 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Rapid Spin", At = 9 }, new Move { Name = "Fury Cutter", At = 11 }, new Move { Name = "Magnitude", At = 14 }, new Move { Name = "Swift", At = 17 }, new Move { Name = "Fury Swipes", At = 20 }, new Move { Name = "Sand Tomb", At = 23 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "Dig", At = 30 }, new Move { Name = "Gyro Ball", At = 34 }, new Move { Name = "Swords Dance", At = 38 }, new Move { Name = "Sandstorm", At = 42 }, new Move { Name = "Earthquake", At = 46 }, },
                    eggMoves = { "Flail", "Counter", "Rapid Spin", "Metal Claw", "Crush Claw", "Night Slash", "Mud Shot", "Endure", "Chip Away", "Rock Climb", "Rototiller", },
                    eggRand = 7,
                    FS = true,
                    xy5 = "Quick Claw",
                    oras5 = "Grip Claw",
                },

                new Species() {
                    Name = "Sandslash",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Sand Attack", At = 3 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Rapid Spin", At = 9 }, new Move { Name = "Fury Cutter", At = 11 }, new Move { Name = "Magnitude", At = 14 }, new Move { Name = "Swift", At = 17 }, new Move { Name = "Fury Swipes", At = 20 }, new Move { Name = "Crush Claw", At = 22 }, new Move { Name = "Sand Tomb", At = 24 }, new Move { Name = "Slash", At = 28 }, new Move { Name = "Dig", At = 33 }, new Move { Name = "Gyro Ball", At = 38 }, new Move { Name = "Swords Dance", At = 43 }, new Move { Name = "Sandstorm", At = 48 }, new Move { Name = "Earthquake", At = 53 }, },
                    xy5 = "Quick Claw",
                    oras5 = "Grip Claw",
                },

                new Species() {
                    Name = "Nidoran♀",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 7 }, new Move { Name = "Double Kick", At = 9 }, new Move { Name = "Poison Sting", At = 13 }, new Move { Name = "Fury Swipes", At = 19 }, new Move { Name = "Bite", At = 21 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Toxic Spikes", At = 31 }, new Move { Name = "Flatter", At = 33 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Captivate", At = 43 }, new Move { Name = "Poison Fang", At = 45 }, },
                    eggMoves = { "Supersonic", "Disable", "Take Down", "Focus Energy", "Charm", "Counter", "Beat Up", "Pursuit", "Skull Bash", "Iron Tail", "Poison Tail", "Endure", "Chip Away", "Venom Drench", },
                },

                new Species() {
                    Name = "Nidorina",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 7 }, new Move { Name = "Double Kick", At = 9 }, new Move { Name = "Poison Sting", At = 13 }, new Move { Name = "Fury Swipes", At = 20 }, new Move { Name = "Bite", At = 23 }, new Move { Name = "Helping Hand", At = 28 }, new Move { Name = "Toxic Spikes", At = 35 }, new Move { Name = "Flatter", At = 38 }, new Move { Name = "Crunch", At = 43 }, new Move { Name = "Captivate", At = 50 }, new Move { Name = "Poison Fang", At = 58 }, },
                },

                new Species() {
                    Name = "Nidoqueen",
                    moves = { new Move { Name = "Superpower", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Double Kick", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Chip Away", At = 23 }, new Move { Name = "Body Slam", At = 35 }, new Move { Name = "Earth Power", At = 43 }, new Move { Name = "Superpower", At = 58 }, },
                },

                new Species() {
                    Name = "Nidoran♂",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Focus Energy", At = 7 }, new Move { Name = "Double Kick", At = 9 }, new Move { Name = "Poison Sting", At = 13 }, new Move { Name = "Fury Attack", At = 19 }, new Move { Name = "Horn Attack", At = 21 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Toxic Spikes", At = 31 }, new Move { Name = "Flatter", At = 33 }, new Move { Name = "Poison Jab", At = 37 }, new Move { Name = "Captivate", At = 43 }, new Move { Name = "Horn Drill", At = 45 }, },
                    eggMoves = { "Counter", "Disable", "Supersonic", "Take Down", "Amnesia", "Confusion", "Beat Up", "Sucker Punch", "Head Smash", "Iron Tail", "Poison Tail", "Endure", "Chip Away", "Venom Drench", },
                },

                new Species() {
                    Name = "Nidorino",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Focus Energy", At = 7 }, new Move { Name = "Double Kick", At = 9 }, new Move { Name = "Poison Sting", At = 13 }, new Move { Name = "Fury Attack", At = 20 }, new Move { Name = "Horn Attack", At = 23 }, new Move { Name = "Helping Hand", At = 28 }, new Move { Name = "Toxic Spikes", At = 35 }, new Move { Name = "Flatter", At = 38 }, new Move { Name = "Poison Jab", At = 43 }, new Move { Name = "Captivate", At = 50 }, new Move { Name = "Horn Drill", At = 58 }, },
                },

                new Species() {
                    Name = "Nidoking",
                    moves = { new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Double Kick", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Chip Away", At = 23 }, new Move { Name = "Thrash", At = 35 }, new Move { Name = "Earth Power", At = 43 }, new Move { Name = "Megahorn", At = 58 }, },
                },

                new Species() {
                    Name = "Clefairy",
                    moves = { new Move { Name = "After You", At = 1 }, new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Disarming Voice", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Encore", At = 1 }, new Move { Name = "Sing", At = 7 }, new Move { Name = "Double Slap", At = 10 }, new Move { Name = "Defense Curl", At = 13 }, new Move { Name = "Follow Me", At = 16 }, new Move { Name = "Bestow", At = 19 }, new Move { Name = "Wake-Up Slap", At = 22 }, new Move { Name = "Minimize", At = 25 }, new Move { Name = "Stored Power", At = 28 }, new Move { Name = "Metronome", At = 31 }, new Move { Name = "Cosmic Power", At = 34 }, new Move { Name = "Lucky Chant", At = 37 }, new Move { Name = "Body Slam", At = 40 }, new Move { Name = "Moonlight", At = 43 }, new Move { Name = "Moonblast", At = 46 }, new Move { Name = "Gravity", At = 49 }, new Move { Name = "Meteor Mash", At = 50 }, new Move { Name = "Healing Wish", At = 55 }, new Move { Name = "After You", At = 58 }, },
                    eggMoves = { "Present", "Metronome", "Amnesia", "Belly Drum", "Splash", "Mimic", "Wish", "Fake Tears", "Covet", "Aromatherapy", "Stored Power", "Tickle", "Misty Terrain", "Heal Pulse", },
                    eggRand = 5,
                    FS = true,
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Clefable",
                    moves = { new Move { Name = "Disarming Voice", At = 1 }, new Move { Name = "Sing", At = 1 }, new Move { Name = "Double Slap", At = 1 }, new Move { Name = "Minimize", At = 1 }, new Move { Name = "Metronome", At = 1 }, },
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Vulpix",
                    moves = { new Move { Name = "Ember", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Roar", At = 7 }, new Move { Name = "Baby-Doll Eyes", At = 9 }, new Move { Name = "Quick Attack", At = 10 }, new Move { Name = "Confuse Ray", At = 12 }, new Move { Name = "Fire Spin", At = 15 }, new Move { Name = "Payback", At = 18 }, new Move { Name = "Will-O-Wisp", At = 20 }, new Move { Name = "Feint Attack", At = 23 }, new Move { Name = "Hex", At = 26 }, new Move { Name = "Flame Burst", At = 28 }, new Move { Name = "Extrasensory", At = 31 }, new Move { Name = "Safeguard", At = 34 }, new Move { Name = "Flamethrower", At = 36 }, new Move { Name = "Imprison", At = 39 }, new Move { Name = "Fire Blast", At = 42 }, new Move { Name = "Grudge", At = 44 }, new Move { Name = "Captivate", At = 47 }, new Move { Name = "Inferno", At = 50 }, },
                    eggMoves = { "Feint Attack", "Hypnosis", "Flail", "Spite", "Disable", "Howl", "Heat Wave", "Flare Blitz", "Extrasensory", "Power Swap", "Secret Power", "Hex", "Tail Slap", "Captivate", },
                    oras5 = "Charcoal",
                },

                new Species() {
                    Name = "Ninetales",
                    moves = { new Move { Name = "Imprison", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Flamethrower", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Safeguard", At = 1 }, },
                    FS = true,
                    oras5 = "Charcoal",
                },

                new Species() {
                    Name = "Jigglypuff",
                    moves = { new Move { Name = "Sing", At = 1 }, new Move { Name = "Defense Curl", At = 3 }, new Move { Name = "Pound", At = 5 }, new Move { Name = "Play Nice", At = 8 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Disable", At = 15 }, new Move { Name = "Double Slap", At = 18 }, new Move { Name = "Rollout", At = 21 }, new Move { Name = "Round", At = 24 }, new Move { Name = "Wake-Up Slap", At = 28 }, new Move { Name = "Rest", At = 32 }, new Move { Name = "Body Slam", At = 35 }, new Move { Name = "Mimic", At = 37 }, new Move { Name = "Gyro Ball", At = 40 }, new Move { Name = "Hyper Voice", At = 44 }, new Move { Name = "Double-Edge", At = 49 }, },
                    eggMoves = { "Perish Song", "Present", "Feint Attack", "Wish", "Fake Tears", "Last Resort", "Covet", "Gravity", "Sleep Talk", "Captivate", "Punishment", "Misty Terrain", "Heal Pulse", },
                    FS = true,
                },

                new Species() {
                    Name = "Wigglytuff",
                    moves = { new Move { Name = "Double-Edge", At = 1 }, new Move { Name = "Play Rough", At = 1 }, new Move { Name = "Sing", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Double Slap", At = 1 }, },
                },

                new Species() {
                    Name = "Zubat",
                    moves = { new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Wing Attack", At = 13 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Air Cutter", At = 19 }, new Move { Name = "Swift", At = 23 }, new Move { Name = "Poison Fang", At = 25 }, new Move { Name = "Mean Look", At = 29 }, new Move { Name = "Acrobatics", At = 31 }, new Move { Name = "Haze", At = 35 }, new Move { Name = "Venoshock", At = 37 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Quick Guard", At = 43 }, },
                    eggMoves = { "Quick Attack", "Pursuit", "Feint Attack", "Gust", "Whirlwind", "Curse", "Nasty Plot", "Hypnosis", "Zen Headbutt", "Brave Bird", "Giga Drain", "Steel Wing", "Defog", "Venom Drench", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Golbat",
                    moves = { new Move { Name = "Screech", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Wing Attack", At = 13 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Air Cutter", At = 19 }, new Move { Name = "Swift", At = 24 }, new Move { Name = "Poison Fang", At = 27 }, new Move { Name = "Mean Look", At = 32 }, new Move { Name = "Acrobatics", At = 35 }, new Move { Name = "Haze", At = 40 }, new Move { Name = "Venoshock", At = 43 }, new Move { Name = "Air Slash", At = 48 }, new Move { Name = "Quick Guard", At = 51 }, },
                    eggMoves = { "Quick Attack", "Pursuit", "Feint Attack", "Gust", "Whirlwind", "Curse", "Nasty Plot", "Hypnosis", "Zen Headbutt", "Brave Bird", "Giga Drain", "Steel Wing", "Defog", "Venom Drench", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Oddish",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Sweet Scent", At = 5 }, new Move { Name = "Acid", At = 9 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Stun Spore", At = 14 }, new Move { Name = "Sleep Powder", At = 15 }, new Move { Name = "Mega Drain", At = 19 }, new Move { Name = "Lucky Chant", At = 23 }, new Move { Name = "Moonlight", At = 27 }, new Move { Name = "Giga Drain", At = 31 }, new Move { Name = "Toxic", At = 35 }, new Move { Name = "Natural Gift", At = 39 }, new Move { Name = "Moonblast", At = 43 }, new Move { Name = "Grassy Terrain", At = 47 }, new Move { Name = "Petal Dance", At = 51 }, },
                    eggMoves = { "Razor Leaf", "Flail", "Synthesis", "Charm", "Ingrain", "Tickle", "Teeter Dance", "Secret Power", "Nature Power", "After You", },
                    FS = true,
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Gloom",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Acid", At = 1 }, new Move { Name = "Sweet Scent", At = 5 }, new Move { Name = "Acid", At = 9 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Stun Spore", At = 14 }, new Move { Name = "Sleep Powder", At = 15 }, new Move { Name = "Mega Drain", At = 19 }, new Move { Name = "Lucky Chant", At = 24 }, new Move { Name = "Moonlight", At = 29 }, new Move { Name = "Giga Drain", At = 34 }, new Move { Name = "Toxic", At = 39 }, new Move { Name = "Natural Gift", At = 44 }, new Move { Name = "Petal Blizzard", At = 49 }, new Move { Name = "Grassy Terrain", At = 54 }, new Move { Name = "Petal Dance", At = 59 }, },
                    eggMoves = { "Razor Leaf", "Flail", "Synthesis", "Charm", "Ingrain", "Tickle", "Teeter Dance", "Secret Power", "Nature Power", "After You", },
                    FS = true,
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Vileplume",
                    moves = { new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Aromatherapy", At = 1 }, new Move { Name = "Poison Powder", At = 1 }, new Move { Name = "Stun Spore", At = 1 }, new Move { Name = "Petal Blizzard", At = 49 }, new Move { Name = "Petal Dance", At = 59 }, new Move { Name = "Solar Beam", At = 64 }, },
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Paras",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Stun Spore", At = 6 }, new Move { Name = "Poison Powder", At = 6 }, new Move { Name = "Leech Life", At = 11 }, new Move { Name = "Fury Cutter", At = 17 }, new Move { Name = "Spore", At = 22 }, new Move { Name = "Slash", At = 27 }, new Move { Name = "Growth", At = 33 }, new Move { Name = "Giga Drain", At = 38 }, new Move { Name = "Aromatherapy", At = 43 }, new Move { Name = "Rage Powder", At = 49 }, new Move { Name = "X-Scissor", At = 54 }, },
                    eggMoves = { "Screech", "Counter", "Psybeam", "Flail", "Sweet Scent", "Pursuit", "Metal Claw", "Bug Bite", "Cross Poison", "Agility", "Endure", "Natural Gift", "Leech Seed", "Wide Guard", "Rototiller", "Fell Stinger", },
                    FS = true,
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Parasect",
                    moves = { new Move { Name = "Cross Poison", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Stun Spore", At = 1 }, new Move { Name = "Poison Powder", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Stun Spore", At = 6 }, new Move { Name = "Poison Powder", At = 6 }, new Move { Name = "Leech Life", At = 11 }, new Move { Name = "Fury Cutter", At = 17 }, new Move { Name = "Spore", At = 22 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Growth", At = 37 }, new Move { Name = "Giga Drain", At = 44 }, new Move { Name = "Aromatherapy", At = 51 }, new Move { Name = "Rage Powder", At = 59 }, new Move { Name = "X-Scissor", At = 66 }, },
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Venonat",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Confusion", At = 11 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Leech Life", At = 17 }, new Move { Name = "Stun Spore", At = 23 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Sleep Powder", At = 29 }, new Move { Name = "Signal Beam", At = 35 }, new Move { Name = "Zen Headbutt", At = 37 }, new Move { Name = "Poison Fang", At = 41 }, new Move { Name = "Psychic", At = 47 }, },
                    eggMoves = { "Baton Pass", "Screech", "Giga Drain", "Signal Beam", "Agility", "Morning Sun", "Toxic Spikes", "Bug Bite", "Secret Power", "Skill Swap", "Rage Powder", },
                },

                new Species() {
                    Name = "Venomoth",
                    moves = { new Move { Name = "Quiver Dance", At = 1 }, new Move { Name = "Bug Buzz", At = 1 }, new Move { Name = "Silver Wind", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Confusion", At = 11 }, new Move { Name = "Poison Powder", At = 13 }, new Move { Name = "Leech Life", At = 17 }, new Move { Name = "Stun Spore", At = 23 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Sleep Powder", At = 29 }, new Move { Name = "Gust", At = 31 }, new Move { Name = "Signal Beam", At = 37 }, new Move { Name = "Zen Headbutt", At = 41 }, new Move { Name = "Poison Fang", At = 47 }, new Move { Name = "Psychic", At = 55 }, new Move { Name = "Bug Buzz", At = 59 }, new Move { Name = "Quiver Dance", At = 63 }, },
                    eggMoves = { "Baton Pass", "Screech", "Giga Drain", "Signal Beam", "Agility", "Morning Sun", "Toxic Spikes", "Bug Bite", "Secret Power", "Skill Swap", "Rage Powder", },
                    FS = true,
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Diglett",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Mud-Slap", At = 12 }, new Move { Name = "Magnitude", At = 15 }, new Move { Name = "Bulldoze", At = 18 }, new Move { Name = "Sucker Punch", At = 23 }, new Move { Name = "Mud Bomb", At = 26 }, new Move { Name = "Earth Power", At = 29 }, new Move { Name = "Dig", At = 34 }, new Move { Name = "Slash", At = 37 }, new Move { Name = "Earthquake", At = 40 }, new Move { Name = "Fissure", At = 45 }, },
                    eggMoves = { "Feint Attack", "Screech", "Ancient Power", "Pursuit", "Beat Up", "Uproar", "Mud Bomb", "Astonish", "Reversal", "Headbutt", "Endure", "Final Gambit", "Memento", },
                    eggRand = 5,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Dugtrio",
                    moves = { new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Tri Attack", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Mud-Slap", At = 12 }, new Move { Name = "Magnitude", At = 15 }, new Move { Name = "Bulldoze", At = 18 }, new Move { Name = "Sucker Punch", At = 23 }, new Move { Name = "Sand Tomb", At = 26 }, new Move { Name = "Mud Bomb", At = 28 }, new Move { Name = "Earth Power", At = 33 }, new Move { Name = "Dig", At = 40 }, new Move { Name = "Slash", At = 45 }, new Move { Name = "Earthquake", At = 50 }, new Move { Name = "Fissure", At = 57 }, },
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Meowth",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bite", At = 6 }, new Move { Name = "Fake Out", At = 9 }, new Move { Name = "Fury Swipes", At = 14 }, new Move { Name = "Screech", At = 17 }, new Move { Name = "Feint Attack", At = 22 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Pay Day", At = 30 }, new Move { Name = "Slash", At = 33 }, new Move { Name = "Nasty Plot", At = 38 }, new Move { Name = "Assurance", At = 41 }, new Move { Name = "Captivate", At = 46 }, new Move { Name = "Night Slash", At = 49 }, new Move { Name = "Feint", At = 50 }, },
                    eggMoves = { "Spite", "Charm", "Hypnosis", "Amnesia", "Assist", "Odor Sleuth", "Flail", "Last Resort", "Punishment", "Tail Whip", "Snatch", "Iron Tail", "Foul Play", },
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Persian",
                    moves = { new Move { Name = "Play Rough", At = 1 }, new Move { Name = "Switcheroo", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Bite", At = 6 }, new Move { Name = "Fake Out", At = 9 }, new Move { Name = "Fury Swipes", At = 14 }, new Move { Name = "Screech", At = 17 }, new Move { Name = "Feint Attack", At = 22 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Swift", At = 28 }, new Move { Name = "Power Gem", At = 32 }, new Move { Name = "Slash", At = 37 }, new Move { Name = "Nasty Plot", At = 44 }, new Move { Name = "Assurance", At = 49 }, new Move { Name = "Captivate", At = 56 }, new Move { Name = "Night Slash", At = 61 }, new Move { Name = "Feint", At = 65 }, },
                    eggMoves = { "Spite", "Charm", "Hypnosis", "Amnesia", "Assist", "Odor Sleuth", "Flail", "Last Resort", "Punishment", "Tail Whip", "Snatch", "Iron Tail", "Foul Play", },
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Psyduck",
                    moves = { new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Water Gun", At = 8 }, new Move { Name = "Confusion", At = 11 }, new Move { Name = "Fury Swipes", At = 15 }, new Move { Name = "Water Pulse", At = 18 }, new Move { Name = "Disable", At = 22 }, new Move { Name = "Screech", At = 25 }, new Move { Name = "Aqua Tail", At = 29 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Soak", At = 36 }, new Move { Name = "Psych Up", At = 39 }, new Move { Name = "Amnesia", At = 43 }, new Move { Name = "Hydro Pump", At = 46 }, new Move { Name = "Wonder Room", At = 50 }, },
                    eggMoves = { "Hypnosis", "Psybeam", "Foresight", "Future Sight", "Cross Chop", "Refresh", "Confuse Ray", "Yawn", "Mud Bomb", "Encore", "Secret Power", "Sleep Talk", "Synchronoise", "Simple Beam", "Clear Smog", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Golduck",
                    moves = { new Move { Name = "Aqua Jet", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Water Gun", At = 8 }, new Move { Name = "Confusion", At = 11 }, new Move { Name = "Fury Swipes", At = 15 }, new Move { Name = "Water Pulse", At = 18 }, new Move { Name = "Disable", At = 22 }, new Move { Name = "Zen Headbutt", At = 25 }, new Move { Name = "Screech", At = 29 }, new Move { Name = "Aqua Tail", At = 32 }, new Move { Name = "Soak", At = 38 }, new Move { Name = "Psych Up", At = 43 }, new Move { Name = "Amnesia", At = 49 }, new Move { Name = "Hydro Pump", At = 54 }, new Move { Name = "Wonder Room", At = 60 }, },
                },

                new Species() {
                    Name = "Mankey",
                    moves = { new Move { Name = "Covet", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Fury Swipes", At = 9 }, new Move { Name = "Karate Chop", At = 13 }, new Move { Name = "Seismic Toss", At = 17 }, new Move { Name = "Screech", At = 21 }, new Move { Name = "Assurance", At = 25 }, new Move { Name = "Swagger", At = 33 }, new Move { Name = "Cross Chop", At = 37 }, new Move { Name = "Thrash", At = 41 }, new Move { Name = "Punishment", At = 45 }, new Move { Name = "Close Combat", At = 49 }, new Move { Name = "Final Gambit", At = 53 }, },
                    eggMoves = { "Foresight", "Meditate", "Counter", "Reversal", "Beat Up", "Revenge", "Smelling Salts", "Close Combat", "Encore", "Focus Punch", "Sleep Talk", "Night Slash", },
                    FS = true,
                },

                new Species() {
                    Name = "Primeape",
                    moves = { new Move { Name = "Final Gambit", At = 1 }, new Move { Name = "Fling", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Fury Swipes", At = 9 }, new Move { Name = "Karate Chop", At = 13 }, new Move { Name = "Seismic Toss", At = 17 }, new Move { Name = "Screech", At = 21 }, new Move { Name = "Assurance", At = 25 }, new Move { Name = "Rage", At = 28 }, new Move { Name = "Swagger", At = 35 }, new Move { Name = "Cross Chop", At = 41 }, new Move { Name = "Thrash", At = 47 }, new Move { Name = "Punishment", At = 53 }, new Move { Name = "Close Combat", At = 59 }, new Move { Name = "Final Gambit", At = 63 }, },
                },

                new Species() {
                    Name = "Growlithe",
                    moves = { new Move { Name = "Bite", At = 1 }, new Move { Name = "Roar", At = 1 }, new Move { Name = "Ember", At = 6 }, new Move { Name = "Leer", At = 8 }, new Move { Name = "Odor Sleuth", At = 10 }, new Move { Name = "Helping Hand", At = 12 }, new Move { Name = "Flame Wheel", At = 17 }, new Move { Name = "Reversal", At = 19 }, new Move { Name = "Fire Fang", At = 21 }, new Move { Name = "Take Down", At = 23 }, new Move { Name = "Flame Burst", At = 28 }, new Move { Name = "Agility", At = 30 }, new Move { Name = "Retaliate", At = 32 }, new Move { Name = "Flamethrower", At = 34 }, new Move { Name = "Crunch", At = 39 }, new Move { Name = "Heat Wave", At = 41 }, new Move { Name = "Outrage", At = 43 }, new Move { Name = "Flare Blitz", At = 45 }, },
                    eggMoves = { "Body Slam", "Crunch", "Thrash", "Fire Spin", "Howl", "Heat Wave", "Double-Edge", "Flare Blitz", "Morning Sun", "Covet", "Iron Tail", "Double Kick", "Close Combat", },
                    FS = true,
                },

                new Species() {
                    Name = "Arcanine",
                    moves = { new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Roar", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Extreme Speed", At = 34 }, },
                },

                new Species() {
                    Name = "Poliwag",
                    moves = { new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Water Gun", At = 5 }, new Move { Name = "Hypnosis", At = 8 }, new Move { Name = "Bubble", At = 11 }, new Move { Name = "Double Slap", At = 15 }, new Move { Name = "Rain Dance", At = 18 }, new Move { Name = "Body Slam", At = 21 }, new Move { Name = "Bubble Beam", At = 25 }, new Move { Name = "Mud Shot", At = 28 }, new Move { Name = "Belly Drum", At = 31 }, new Move { Name = "Wake-Up Slap", At = 35 }, new Move { Name = "Hydro Pump", At = 38 }, new Move { Name = "Mud Bomb", At = 41 }, },
                    eggMoves = { "Mist", "Splash", "Bubble Beam", "Haze", "Mind Reader", "Water Sport", "Ice Ball", "Mud Shot", "Refresh", "Endeavor", "Encore", "Endure", "Water Pulse", },
                },

                new Species() {
                    Name = "Poliwhirl",
                    moves = { new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Water Gun", At = 5 }, new Move { Name = "Hypnosis", At = 8 }, new Move { Name = "Bubble", At = 11 }, new Move { Name = "Double Slap", At = 15 }, new Move { Name = "Rain Dance", At = 18 }, new Move { Name = "Body Slam", At = 21 }, new Move { Name = "Bubble Beam", At = 27 }, new Move { Name = "Mud Shot", At = 32 }, new Move { Name = "Belly Drum", At = 37 }, new Move { Name = "Wake-Up Slap", At = 43 }, new Move { Name = "Hydro Pump", At = 48 }, new Move { Name = "Mud Bomb", At = 53 }, },
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Poliwrath",
                    moves = { new Move { Name = "Circle Throw", At = 1 }, new Move { Name = "Bubble Beam", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Double Slap", At = 1 }, new Move { Name = "Submission", At = 1 }, new Move { Name = "Dynamic Punch", At = 32 }, new Move { Name = "Mind Reader", At = 43 }, new Move { Name = "Circle Throw", At = 53 }, },
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Abra",
                    moves = { new Move { Name = "Teleport", At = 1 }, },
                    eggMoves = { "Encore", "Barrier", "Knock Off", "Fire Punch", "Thunder Punch", "Ice Punch", "Power Trick", "Guard Swap", "Skill Swap", "Guard Split", "Psycho Shift", "Ally Switch", },
                    eggRand = 9,
                    FS = true,
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Kadabra",
                    moves = { new Move { Name = "Teleport", At = 1 }, new Move { Name = "Kinesis", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Confusion", At = 16 }, new Move { Name = "Disable", At = 18 }, new Move { Name = "Psybeam", At = 21 }, new Move { Name = "Miracle Eye", At = 23 }, new Move { Name = "Reflect", At = 26 }, new Move { Name = "Psycho Cut", At = 28 }, new Move { Name = "Recover", At = 31 }, new Move { Name = "Telekinesis", At = 33 }, new Move { Name = "Ally Switch", At = 36 }, new Move { Name = "Psychic", At = 38 }, new Move { Name = "Role Play", At = 41 }, new Move { Name = "Future Sight", At = 43 }, new Move { Name = "Trick", At = 46 }, },
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Alakazam",
                    moves = { new Move { Name = "Teleport", At = 1 }, new Move { Name = "Kinesis", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Confusion", At = 16 }, new Move { Name = "Disable", At = 18 }, new Move { Name = "Psybeam", At = 21 }, new Move { Name = "Miracle Eye", At = 23 }, new Move { Name = "Reflect", At = 26 }, new Move { Name = "Psycho Cut", At = 28 }, new Move { Name = "Recover", At = 31 }, new Move { Name = "Telekinesis", At = 33 }, new Move { Name = "Ally Switch", At = 36 }, new Move { Name = "Psychic", At = 38 }, new Move { Name = "Calm Mind", At = 41 }, new Move { Name = "Future Sight", At = 43 }, new Move { Name = "Trick", At = 46 }, },
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Machop",
                    moves = { new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 3 }, new Move { Name = "Karate Chop", At = 7 }, new Move { Name = "Foresight", At = 9 }, new Move { Name = "Low Sweep", At = 13 }, new Move { Name = "Seismic Toss", At = 15 }, new Move { Name = "Revenge", At = 19 }, new Move { Name = "Knock Off", At = 21 }, new Move { Name = "Vital Throw", At = 25 }, new Move { Name = "Wake-Up Slap", At = 27 }, new Move { Name = "Dual Chop", At = 31 }, new Move { Name = "Submission", At = 33 }, new Move { Name = "Bulk Up", At = 37 }, new Move { Name = "Cross Chop", At = 39 }, new Move { Name = "Scary Face", At = 43 }, new Move { Name = "Dynamic Punch", At = 45 }, },
                    eggMoves = { "Meditate", "Rolling Kick", "Encore", "Smelling Salts", "Counter", "Close Combat", "Fire Punch", "Thunder Punch", "Ice Punch", "Bullet Punch", "Power Trick", "Heavy Slam", "Knock Off", "Tickle", "Quick Guard", },
                    oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Machoke",
                    moves = { new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Karate Chop", At = 1 }, new Move { Name = "Focus Energy", At = 3 }, new Move { Name = "Karate Chop", At = 7 }, new Move { Name = "Foresight", At = 9 }, new Move { Name = "Low Sweep", At = 13 }, new Move { Name = "Seismic Toss", At = 15 }, new Move { Name = "Revenge", At = 19 }, new Move { Name = "Knock Off", At = 21 }, new Move { Name = "Vital Throw", At = 25 }, new Move { Name = "Wake-Up Slap", At = 27 }, new Move { Name = "Dual Chop", At = 33 }, new Move { Name = "Submission", At = 37 }, new Move { Name = "Bulk Up", At = 43 }, new Move { Name = "Cross Chop", At = 47 }, new Move { Name = "Scary Face", At = 53 }, new Move { Name = "Dynamic Punch", At = 57 }, },
                    FS = true,
                    oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Machamp",
                    moves = { new Move { Name = "Wide Guard", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Karate Chop", At = 1 }, new Move { Name = "Focus Energy", At = 3 }, new Move { Name = "Karate Chop", At = 7 }, new Move { Name = "Foresight", At = 9 }, new Move { Name = "Low Sweep", At = 13 }, new Move { Name = "Seismic Toss", At = 15 }, new Move { Name = "Revenge", At = 19 }, new Move { Name = "Knock Off", At = 21 }, new Move { Name = "Vital Throw", At = 25 }, new Move { Name = "Wake-Up Slap", At = 27 }, new Move { Name = "Dual Chop", At = 33 }, new Move { Name = "Submission", At = 37 }, new Move { Name = "Bulk Up", At = 43 }, new Move { Name = "Cross Chop", At = 47 }, new Move { Name = "Scary Face", At = 53 }, new Move { Name = "Dynamic Punch", At = 57 }, },
                     oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Bellsprout",
                    moves = { new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Wrap", At = 11 }, new Move { Name = "Sleep Powder", At = 13 }, new Move { Name = "Poison Powder", At = 15 }, new Move { Name = "Stun Spore", At = 17 }, new Move { Name = "Acid", At = 23 }, new Move { Name = "Knock Off", At = 27 }, new Move { Name = "Sweet Scent", At = 29 }, new Move { Name = "Gastro Acid", At = 35 }, new Move { Name = "Razor Leaf", At = 39 }, new Move { Name = "Slam", At = 41 }, new Move { Name = "Wring Out", At = 47 }, },
                    eggMoves = { "Encore", "Synthesis", "Leech Life", "Ingrain", "Magical Leaf", "Worry Seed", "Tickle", "Weather Ball", "Bullet Seed", "Natural Gift", "Giga Drain", "Clear Smog", "Power Whip", "Acid Spray", "Belch", },
                },

                new Species() {
                    Name = "Weepinbell",
                    moves = { new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Wrap", At = 11 }, new Move { Name = "Sleep Powder", At = 13 }, new Move { Name = "Poison Powder", At = 15 }, new Move { Name = "Stun Spore", At = 17 }, new Move { Name = "Acid", At = 23 }, new Move { Name = "Knock Off", At = 27 }, new Move { Name = "Sweet Scent", At = 29 }, new Move { Name = "Gastro Acid", At = 35 }, new Move { Name = "Razor Leaf", At = 39 }, new Move { Name = "Slam", At = 41 }, new Move { Name = "Wring Out", At = 47 }, },
                },

                new Species() {
                    Name = "Victreebel",
                    moves = { new Move { Name = "Stockpile", At = 1 }, new Move { Name = "Swallow", At = 1 }, new Move { Name = "Spit Up", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Sleep Powder", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Leaf Tornado", At = 27 }, new Move { Name = "Leaf Storm", At = 47 }, new Move { Name = "Leaf Blade", At = 47 }, },
                },

                new Species() {
                    Name = "Tentacool",
                    moves = { new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Supersonic", At = 4 }, new Move { Name = "Constrict", At = 7 }, new Move { Name = "Acid", At = 10 }, new Move { Name = "Toxic Spikes", At = 13 }, new Move { Name = "Water Pulse", At = 16 }, new Move { Name = "Wrap", At = 19 }, new Move { Name = "Acid Spray", At = 22 }, new Move { Name = "Bubble Beam", At = 25 }, new Move { Name = "Barrier", At = 28 }, new Move { Name = "Poison Jab", At = 31 }, new Move { Name = "Brine", At = 34 }, new Move { Name = "Screech", At = 37 }, new Move { Name = "Hex", At = 40 }, new Move { Name = "Sludge Wave", At = 43 }, new Move { Name = "Hydro Pump", At = 46 }, new Move { Name = "Wring Out", At = 49 }, },
                    eggMoves = { "Aurora Beam", "Mirror Coat", "Rapid Spin", "Haze", "Confuse Ray", "Knock Off", "Acupressure", "Muddy Water", "Bubble", "Aqua Ring", "Tickle", },
                    eggRand = 9,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Tentacruel",
                    moves = { new Move { Name = "Reflect Type", At = 1 }, new Move { Name = "Wring Out", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Acid", At = 1 }, new Move { Name = "Supersonic", At = 4 }, new Move { Name = "Constrict", At = 7 }, new Move { Name = "Acid", At = 10 }, new Move { Name = "Toxic Spikes", At = 13 }, new Move { Name = "Water Pulse", At = 16 }, new Move { Name = "Wrap", At = 19 }, new Move { Name = "Acid Spray", At = 22 }, new Move { Name = "Bubble Beam", At = 25 }, new Move { Name = "Barrier", At = 28 }, new Move { Name = "Poison Jab", At = 32 }, new Move { Name = "Brine", At = 36 }, new Move { Name = "Screech", At = 40 }, new Move { Name = "Hex", At = 44 }, new Move { Name = "Sludge Wave", At = 48 }, new Move { Name = "Hydro Pump", At = 52 }, new Move { Name = "Wring Out", At = 56 }, },
                    eggMoves = { "Aurora Beam", "Mirror Coat", "Rapid Spin", "Haze", "Confuse Ray", "Knock Off", "Acupressure", "Muddy Water", "Bubble", "Aqua Ring", "Tickle", },
                    eggRand = 9,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Geodude",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Mud Sport", At = 4 }, new Move { Name = "Rock Polish", At = 6 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Magnitude", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Smack Down", At = 18 }, new Move { Name = "Bulldoze", At = 22 }, new Move { Name = "Self-Destruct", At = 24 }, new Move { Name = "Stealth Rock", At = 28 }, new Move { Name = "Rock Blast", At = 30 }, new Move { Name = "Earthquake", At = 34 }, new Move { Name = "Explosion", At = 36 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Stone Edge", At = 42 }, },
                    eggMoves = { "Mega Punch", "Block", "Hammer Arm", "Flail", "Curse", "Focus Punch", "Rock Climb", "Endure", "Autotomize", "Wide Guard", },
                    eggRand = 9,
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Graveler",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Rock Polish", At = 1 }, new Move { Name = "Mud Sport", At = 4 }, new Move { Name = "Rock Polish", At = 6 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Magnitude", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Smack Down", At = 18 }, new Move { Name = "Bulldoze", At = 22 }, new Move { Name = "Self-Destruct", At = 24 }, new Move { Name = "Stealth Rock", At = 30 }, new Move { Name = "Rock Blast", At = 34 }, new Move { Name = "Earthquake", At = 40 }, new Move { Name = "Explosion", At = 44 }, new Move { Name = "Double-Edge", At = 50 }, new Move { Name = "Stone Edge", At = 54 }, },
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Golem",
                    moves = { new Move { Name = "Heavy Slam", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Rock Polish", At = 1 }, new Move { Name = "Mud Sport", At = 4 }, new Move { Name = "Rock Polish", At = 6 }, new Move { Name = "Steamroller", At = 10 }, new Move { Name = "Magnitude", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Smack Down", At = 18 }, new Move { Name = "Bulldoze", At = 22 }, new Move { Name = "Self-Destruct", At = 24 }, new Move { Name = "Stealth Rock", At = 30 }, new Move { Name = "Rock Blast", At = 34 }, new Move { Name = "Earthquake", At = 40 }, new Move { Name = "Explosion", At = 44 }, new Move { Name = "Double-Edge", At = 50 }, new Move { Name = "Stone Edge", At = 54 }, new Move { Name = "Heavy Slam", At = 60 }, },
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Ponyta",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Ember", At = 9 }, new Move { Name = "Flame Wheel", At = 13 }, new Move { Name = "Stomp", At = 17 }, new Move { Name = "Flame Charge", At = 21 }, new Move { Name = "Fire Spin", At = 25 }, new Move { Name = "Take Down", At = 29 }, new Move { Name = "Inferno", At = 33 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Fire Blast", At = 41 }, new Move { Name = "Bounce", At = 45 }, new Move { Name = "Flare Blitz", At = 49 }, },
                    eggMoves = { "Flame Wheel", "Thrash", "Double Kick", "Hypnosis", "Charm", "Double-Edge", "Horn Drill", "Morning Sun", "Low Kick", "Captivate", "Ally Switch", },
                    FS = true,
                },

                new Species() {
                    Name = "Rapidash",
                    moves = { new Move { Name = "Poison Jab", At = 1 }, new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Ember", At = 9 }, new Move { Name = "Flame Wheel", At = 13 }, new Move { Name = "Stomp", At = 17 }, new Move { Name = "Flame Charge", At = 21 }, new Move { Name = "Fire Spin", At = 25 }, new Move { Name = "Take Down", At = 29 }, new Move { Name = "Inferno", At = 33 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Fury Attack", At = 40 }, new Move { Name = "Fire Blast", At = 41 }, new Move { Name = "Bounce", At = 45 }, new Move { Name = "Flare Blitz", At = 49 }, },
                },

                new Species() {
                    Name = "Slowpoke",
                    moves = { new Move { Name = "Curse", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Confusion", At = 14 }, new Move { Name = "Disable", At = 19 }, new Move { Name = "Headbutt", At = 23 }, new Move { Name = "Water Pulse", At = 28 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Slack Off", At = 36 }, new Move { Name = "Amnesia", At = 41 }, new Move { Name = "Psychic", At = 45 }, new Move { Name = "Rain Dance", At = 49 }, new Move { Name = "Psych Up", At = 54 }, new Move { Name = "Heal Pulse", At = 58 }, },
                    eggMoves = { "Belly Drum", "Future Sight", "Stomp", "Mud Sport", "Sleep Talk", "Snore", "Me First", "Block", "Zen Headbutt", "Wonder Room", "Belch", },
                    eggRand = 5,
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Slowbro",
                    moves = { new Move { Name = "Heal Pulse", At = 1 }, new Move { Name = "Curse", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Confusion", At = 14 }, new Move { Name = "Disable", At = 19 }, new Move { Name = "Headbutt", At = 23 }, new Move { Name = "Water Pulse", At = 28 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Slack Off", At = 36 }, new Move { Name = "Withdraw", At = 37 }, new Move { Name = "Amnesia", At = 43 }, new Move { Name = "Psychic", At = 49 }, new Move { Name = "Rain Dance", At = 55 }, new Move { Name = "Psych Up", At = 62 }, new Move { Name = "Heal Pulse", At = 68 }, },
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Magnemite",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Thunder Shock", At = 7 }, new Move { Name = "Sonic Boom", At = 11 }, new Move { Name = "Thunder Wave", At = 13 }, new Move { Name = "Magnet Bomb", At = 17 }, new Move { Name = "Spark", At = 19 }, new Move { Name = "Mirror Shot", At = 23 }, new Move { Name = "Metal Sound", At = 25 }, new Move { Name = "Electro Ball", At = 29 }, new Move { Name = "Flash Cannon", At = 31 }, new Move { Name = "Screech", At = 35 }, new Move { Name = "Discharge", At = 37 }, new Move { Name = "Lock-On", At = 41 }, new Move { Name = "Magnet Rise", At = 43 }, new Move { Name = "Gyro Ball", At = 47 }, new Move { Name = "Zap Cannon", At = 49 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Magneton",
                    moves = { new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Electric Terrain", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Thunder Shock", At = 7 }, new Move { Name = "Sonic Boom", At = 11 }, new Move { Name = "Thunder Wave", At = 13 }, new Move { Name = "Magnet Bomb", At = 17 }, new Move { Name = "Spark", At = 19 }, new Move { Name = "Mirror Shot", At = 23 }, new Move { Name = "Metal Sound", At = 25 }, new Move { Name = "Electro Ball", At = 29 }, new Move { Name = "Tri Attack", At = 30 }, new Move { Name = "Flash Cannon", At = 33 }, new Move { Name = "Screech", At = 39 }, new Move { Name = "Discharge", At = 43 }, new Move { Name = "Lock-On", At = 49 }, new Move { Name = "Magnet Rise", At = 53 }, new Move { Name = "Gyro Ball", At = 59 }, new Move { Name = "Zap Cannon", At = 63 }, },
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Farfetch’d",
                    moves = { new Move { Name = "Brave Bird", At = 1 }, new Move { Name = "Poison Jab", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Cutter", At = 1 }, new Move { Name = "Fury Attack", At = 7 }, new Move { Name = "Aerial Ace", At = 9 }, new Move { Name = "Knock Off", At = 13 }, new Move { Name = "Slash", At = 19 }, new Move { Name = "Air Cutter", At = 21 }, new Move { Name = "Swords Dance", At = 25 }, new Move { Name = "Agility", At = 31 }, new Move { Name = "Night Slash", At = 33 }, new Move { Name = "Acrobatics", At = 37 }, new Move { Name = "Feint", At = 43 }, new Move { Name = "False Swipe", At = 45 }, new Move { Name = "Air Slash", At = 49 }, new Move { Name = "Brave Bird", At = 55 }, },
                    eggMoves = { "Steel Wing", "Foresight", "Mirror Move", "Gust", "Quick Attack", "Flail", "Feather Dance", "Curse", "Covet", "Mud-Slap", "Night Slash", "Leaf Blade", "Revenge", "Roost", "Trump Card", "Simple Beam", },
                    item5 = "Stick",
                },

                new Species() {
                    Name = "Doduo",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Rage", At = 9 }, new Move { Name = "Fury Attack", At = 13 }, new Move { Name = "Pursuit", At = 17 }, new Move { Name = "Pluck", At = 21 }, new Move { Name = "Double Hit", At = 25 }, new Move { Name = "Acupressure", At = 29 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Drill Peck", At = 37 }, new Move { Name = "Uproar", At = 41 }, new Move { Name = "Endeavor", At = 45 }, new Move { Name = "Thrash", At = 49 }, },
                    eggMoves = { "Quick Attack", "Supersonic", "Haze", "Feint Attack", "Flail", "Endeavor", "Mirror Move", "Brave Bird", "Natural Gift", "Assurance", },
                    FS = true,
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Dodrio",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Rage", At = 9 }, new Move { Name = "Fury Attack", At = 13 }, new Move { Name = "Pursuit", At = 17 }, new Move { Name = "Pluck", At = 21 }, new Move { Name = "Tri Attack", At = 25 }, new Move { Name = "Acupressure", At = 29 }, new Move { Name = "Agility", At = 35 }, new Move { Name = "Drill Peck", At = 41 }, new Move { Name = "Uproar", At = 47 }, new Move { Name = "Endeavor", At = 53 }, new Move { Name = "Thrash", At = 59 }, },
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Seel",
                    moves = { new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Icy Wind", At = 11 }, new Move { Name = "Encore", At = 13 }, new Move { Name = "Ice Shard", At = 17 }, new Move { Name = "Rest", At = 21 }, new Move { Name = "Aqua Ring", At = 23 }, new Move { Name = "Aurora Beam", At = 27 }, new Move { Name = "Aqua Jet", At = 31 }, new Move { Name = "Brine", At = 33 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Dive", At = 41 }, new Move { Name = "Aqua Tail", At = 43 }, new Move { Name = "Ice Beam", At = 47 }, new Move { Name = "Safeguard", At = 51 }, new Move { Name = "Hail", At = 53 }, },
                    eggMoves = { "Lick", "Perish Song", "Disable", "Horn Drill", "Slam", "Encore", "Fake Out", "Icicle Spear", "Signal Beam", "Stockpile", "Swallow", "Spit Up", "Water Pulse", "Iron Tail", "Sleep Talk", "Belch", "Entrainment", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Dewgong",
                    moves = { new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Signal Beam", At = 1 }, new Move { Name = "Icy Wind", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Signal Beam", At = 7 }, new Move { Name = "Icy Wind", At = 11 }, new Move { Name = "Encore", At = 13 }, new Move { Name = "Ice Shard", At = 17 }, new Move { Name = "Rest", At = 21 }, new Move { Name = "Aqua Ring", At = 23 }, new Move { Name = "Aurora Beam", At = 27 }, new Move { Name = "Aqua Jet", At = 31 }, new Move { Name = "Brine", At = 33 }, new Move { Name = "Sheer Cold", At = 34 }, new Move { Name = "Take Down", At = 39 }, new Move { Name = "Dive", At = 45 }, new Move { Name = "Aqua Tail", At = 49 }, new Move { Name = "Ice Beam", At = 55 }, new Move { Name = "Safeguard", At = 61 }, new Move { Name = "Hail", At = 65 }, },
                    eggMoves = { "Lick", "Perish Song", "Disable", "Horn Drill", "Slam", "Encore", "Fake Out", "Icicle Spear", "Signal Beam", "Stockpile", "Swallow", "Spit Up", "Water Pulse", "Iron Tail", "Sleep Talk", "Belch", "Entrainment", },
                    eggRand = 5,
                    FS = true,
                },

                new Species() {
                    Name = "Grimer",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Mud-Slap", At = 7 }, new Move { Name = "Disable", At = 12 }, new Move { Name = "Sludge", At = 15 }, new Move { Name = "Mud Bomb", At = 18 }, new Move { Name = "Minimize", At = 21 }, new Move { Name = "Fling", At = 26 }, new Move { Name = "Sludge Bomb", At = 29 }, new Move { Name = "Sludge Wave", At = 32 }, new Move { Name = "Screech", At = 37 }, new Move { Name = "Gunk Shot", At = 40 }, new Move { Name = "Acid Armor", At = 43 }, new Move { Name = "Belch", At = 46 }, new Move { Name = "Memento", At = 48 }, },
                    eggMoves = { "Haze", "Mean Look", "Lick", "Imprison", "Curse", "Shadow Punch", "Shadow Sneak", "Stockpile", "Swallow", "Spit Up", "Scary Face", "Acid Spray", },
                    eggRand = 5,
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Muk",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Mud-Slap", At = 7 }, new Move { Name = "Disable", At = 12 }, new Move { Name = "Sludge", At = 15 }, new Move { Name = "Mud Bomb", At = 18 }, new Move { Name = "Minimize", At = 21 }, new Move { Name = "Fling", At = 26 }, new Move { Name = "Sludge Bomb", At = 29 }, new Move { Name = "Sludge Wave", At = 32 }, new Move { Name = "Screech", At = 37 }, new Move { Name = "Venom Drench", At = 38 }, new Move { Name = "Gunk Shot", At = 40 }, new Move { Name = "Acid Armor", At = 46 }, new Move { Name = "Belch", At = 52 }, new Move { Name = "Memento", At = 57 }, },
                    FS = true,
                    item50 = "Black Sludge",
                },

                new Species() {
                    Name = "Shellder",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Withdraw", At = 4 }, new Move { Name = "Supersonic", At = 8 }, new Move { Name = "Icicle Spear", At = 13 }, new Move { Name = "Protect", At = 16 }, new Move { Name = "Leer", At = 20 }, new Move { Name = "Clamp", At = 25 }, new Move { Name = "Ice Shard", At = 28 }, new Move { Name = "Razor Shell", At = 32 }, new Move { Name = "Aurora Beam", At = 37 }, new Move { Name = "Whirlpool", At = 40 }, new Move { Name = "Brine", At = 44 }, new Move { Name = "Iron Defense", At = 49 }, new Move { Name = "Ice Beam", At = 52 }, new Move { Name = "Shell Smash", At = 56 }, new Move { Name = "Hydro Pump", At = 61 }, },
                    eggMoves = { "Bubble Beam", "Take Down", "Barrier", "Rapid Spin", "Screech", "Icicle Spear", "Mud Shot", "Rock Blast", "Water Pulse", "Aqua Ring", "Avalanche", "Twineedle", },
                    item5 = "Big Pearl",
                    item50 = "Pearl",
                },

                new Species() {
                    Name = "Cloyster",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Shell Smash", At = 1 }, new Move { Name = "Toxic Spikes", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Aurora Beam", At = 1 }, new Move { Name = "Spike Cannon", At = 13 }, new Move { Name = "Spikes", At = 28 }, new Move { Name = "Icicle Crash", At = 50 }, },
                    FS = true,
                    item5 = "Big Pearl",
                    item50 = "Pearl",
                },

                new Species() {
                    Name = "Gastly",
                    moves = { new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Spite", At = 5 }, new Move { Name = "Mean Look", At = 8 }, new Move { Name = "Curse", At = 12 }, new Move { Name = "Night Shade", At = 15 }, new Move { Name = "Confuse Ray", At = 19 }, new Move { Name = "Sucker Punch", At = 22 }, new Move { Name = "Payback", At = 26 }, new Move { Name = "Shadow Ball", At = 29 }, new Move { Name = "Dream Eater", At = 33 }, new Move { Name = "Dark Pulse", At = 36 }, new Move { Name = "Destiny Bond", At = 40 }, new Move { Name = "Hex", At = 43 }, new Move { Name = "Nightmare", At = 47 }, },
                    eggMoves = { "Psywave", "Perish Song", "Haze", "Astonish", "Grudge", "Fire Punch", "Ice Punch", "Thunder Punch", "Disable", "Scary Face", "Clear Smog", "Smog", "Reflect Type", },
                },

                new Species() {
                    Name = "Haunter",
                    moves = { new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Spite", At = 1 }, new Move { Name = "Spite", At = 5 }, new Move { Name = "Mean Look", At = 8 }, new Move { Name = "Curse", At = 12 }, new Move { Name = "Night Shade", At = 15 }, new Move { Name = "Confuse Ray", At = 19 }, new Move { Name = "Sucker Punch", At = 22 }, new Move { Name = "Shadow Punch", At = 25 }, new Move { Name = "Payback", At = 28 }, new Move { Name = "Shadow Ball", At = 33 }, new Move { Name = "Dream Eater", At = 39 }, new Move { Name = "Dark Pulse", At = 44 }, new Move { Name = "Destiny Bond", At = 50 }, new Move { Name = "Hex", At = 55 }, new Move { Name = "Nightmare", At = 61 }, },
                },

                new Species() {
                    Name = "Gengar",
                    moves = { new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Spite", At = 1 }, new Move { Name = "Spite", At = 5 }, new Move { Name = "Mean Look", At = 8 }, new Move { Name = "Curse", At = 12 }, new Move { Name = "Night Shade", At = 15 }, new Move { Name = "Confuse Ray", At = 19 }, new Move { Name = "Sucker Punch", At = 22 }, new Move { Name = "Shadow Punch", At = 25 }, new Move { Name = "Payback", At = 28 }, new Move { Name = "Shadow Ball", At = 33 }, new Move { Name = "Dream Eater", At = 39 }, new Move { Name = "Dark Pulse", At = 44 }, new Move { Name = "Destiny Bond", At = 50 }, new Move { Name = "Hex", At = 55 }, new Move { Name = "Nightmare", At = 61 }, },
                },

                new Species() {
                    Name = "Onix",
                    moves = { new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Bind", At = 1 }, new Move { Name = "Curse", At = 4 }, new Move { Name = "Rock Throw", At = 7 }, new Move { Name = "Rock Tomb", At = 10 }, new Move { Name = "Rage", At = 13 }, new Move { Name = "Stealth Rock", At = 16 }, new Move { Name = "Rock Polish", At = 19 }, new Move { Name = "Gyro Ball", At = 20 }, new Move { Name = "Smack Down", At = 22 }, new Move { Name = "Dragon Breath", At = 25 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Screech", At = 31 }, new Move { Name = "Rock Slide", At = 34 }, new Move { Name = "Sand Tomb", At = 37 }, new Move { Name = "Iron Tail", At = 40 }, new Move { Name = "Dig", At = 43 }, new Move { Name = "Stone Edge", At = 46 }, new Move { Name = "Double-Edge", At = 49 }, new Move { Name = "Sandstorm", At = 52 }, },
                    eggMoves = { "Flail", "Block", "Defense Curl", "Rollout", "Rock Blast", "Rock Climb", "Heavy Slam", "Stealth Rock", "Rototiller", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Drowzee",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Disable", At = 5 }, new Move { Name = "Confusion", At = 9 }, new Move { Name = "Headbutt", At = 13 }, new Move { Name = "Poison Gas", At = 17 }, new Move { Name = "Meditate", At = 21 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Headbutt", At = 29 }, new Move { Name = "Psych Up", At = 33 }, new Move { Name = "Synchronoise", At = 37 }, new Move { Name = "Zen Headbutt", At = 41 }, new Move { Name = "Swagger", At = 45 }, new Move { Name = "Psychic", At = 49 }, new Move { Name = "Nasty Plot", At = 53 }, new Move { Name = "Psyshock", At = 57 }, new Move { Name = "Future Sight", At = 61 }, },
                    eggMoves = { "Barrier", "Assist", "Role Play", "Fire Punch", "Thunder Punch", "Ice Punch", "Nasty Plot", "Flatter", "Psycho Cut", "Guard Swap", "Secret Power", "Skill Swap", },
                    FS = true,
                },

                new Species() {
                    Name = "Hypno",
                    moves = { new Move { Name = "Future Sight", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Nightmare", At = 1 }, new Move { Name = "Switcheroo", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Disable", At = 5 }, new Move { Name = "Confusion", At = 9 }, new Move { Name = "Headbutt", At = 13 }, new Move { Name = "Poison Gas", At = 17 }, new Move { Name = "Meditate", At = 21 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Headbutt", At = 29 }, new Move { Name = "Psych Up", At = 33 }, new Move { Name = "Synchronoise", At = 37 }, new Move { Name = "Zen Headbutt", At = 41 }, new Move { Name = "Swagger", At = 45 }, new Move { Name = "Psychic", At = 49 }, new Move { Name = "Nasty Plot", At = 53 }, new Move { Name = "Psyshock", At = 57 }, new Move { Name = "Future Sight", At = 61 }, },
                    eggMoves = { "Barrier", "Assist", "Role Play", "Fire Punch", "Thunder Punch", "Ice Punch", "Nasty Plot", "Flatter", "Psycho Cut", "Guard Swap", "Secret Power", "Skill Swap", },
                },

                new Species() {
                    Name = "Krabby",
                    moves = { new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Vice Grip", At = 5 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Harden", At = 11 }, new Move { Name = "Bubble Beam", At = 15 }, new Move { Name = "Mud Shot", At = 19 }, new Move { Name = "Metal Claw", At = 21 }, new Move { Name = "Stomp", At = 25 }, new Move { Name = "Protect", At = 29 }, new Move { Name = "Guillotine", At = 31 }, new Move { Name = "Slam", At = 35 }, new Move { Name = "Brine", At = 39 }, new Move { Name = "Crabhammer", At = 41 }, new Move { Name = "Flail", At = 45 }, },
                    eggMoves = { "Haze", "Amnesia", "Flail", "Slam", "Knock Off", "Tickle", "Ancient Power", "Agility", "Endure", "Chip Away", "Bide", "Ally Switch", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Kingler",
                    moves = { new Move { Name = "Wide Guard", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Vice Grip", At = 5 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Harden", At = 11 }, new Move { Name = "Bubble Beam", At = 15 }, new Move { Name = "Mud Shot", At = 19 }, new Move { Name = "Metal Claw", At = 21 }, new Move { Name = "Stomp", At = 25 }, new Move { Name = "Protect", At = 32 }, new Move { Name = "Guillotine", At = 37 }, new Move { Name = "Slam", At = 44 }, new Move { Name = "Brine", At = 51 }, new Move { Name = "Crabhammer", At = 56 }, new Move { Name = "Flail", At = 63 }, },
                },

                new Species() {
                    Name = "Voltorb",
                    moves = { new Move { Name = "Charge", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sonic Boom", At = 4 }, new Move { Name = "Eerie Impulse", At = 6 }, new Move { Name = "Spark", At = 9 }, new Move { Name = "Rollout", At = 11 }, new Move { Name = "Screech", At = 13 }, new Move { Name = "Charge Beam", At = 16 }, new Move { Name = "Swift", At = 20 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Self-Destruct", At = 26 }, new Move { Name = "Light Screen", At = 29 }, new Move { Name = "Magnet Rise", At = 34 }, new Move { Name = "Discharge", At = 37 }, new Move { Name = "Explosion", At = 41 }, new Move { Name = "Gyro Ball", At = 46 }, new Move { Name = "Mirror Coat", At = 48 }, },
                },

                new Species() {
                    Name = "Electrode",
                    moves = { new Move { Name = "Magnetic Flux", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Spark", At = 1 }, new Move { Name = "Sonic Boom", At = 4 }, new Move { Name = "Eerie Impulse", At = 6 }, new Move { Name = "Spark", At = 9 }, new Move { Name = "Rollout", At = 11 }, new Move { Name = "Screech", At = 13 }, new Move { Name = "Charge Beam", At = 16 }, new Move { Name = "Swift", At = 20 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Self-Destruct", At = 26 }, new Move { Name = "Light Screen", At = 29 }, new Move { Name = "Magnet Rise", At = 36 }, new Move { Name = "Discharge", At = 41 }, new Move { Name = "Explosion", At = 47 }, new Move { Name = "Gyro Ball", At = 54 }, new Move { Name = "Mirror Coat", At = 58 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Exeggcute",
                    moves = { new Move { Name = "Barrage", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Reflect", At = 7 }, new Move { Name = "Leech Seed", At = 11 }, new Move { Name = "Bullet Seed", At = 17 }, new Move { Name = "Stun Spore", At = 19 }, new Move { Name = "Poison Powder", At = 21 }, new Move { Name = "Sleep Powder", At = 23 }, new Move { Name = "Confusion", At = 27 }, new Move { Name = "Worry Seed", At = 33 }, new Move { Name = "Natural Gift", At = 37 }, new Move { Name = "Solar Beam", At = 43 }, new Move { Name = "Extrasensory", At = 47 }, new Move { Name = "Bestow", At = 50 }, },
                    eggMoves = { "Synthesis", "Moonlight", "Ancient Power", "Ingrain", "Curse", "Nature Power", "Lucky Chant", "Leaf Storm", "Power Swap", "Giga Drain", "Skill Swap", "Natural Gift", "Block", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Exeggutor",
                    moves = { new Move { Name = "Seed Bomb", At = 1 }, new Move { Name = "Barrage", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Stomp", At = 1 }, new Move { Name = "Psyshock", At = 17 }, new Move { Name = "Egg Bomb", At = 27 }, new Move { Name = "Wood Hammer", At = 37 }, new Move { Name = "Leaf Storm", At = 47 }, },
                },

                new Species() {
                    Name = "Cubone",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Bone Club", At = 7 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Leer", At = 13 }, new Move { Name = "Focus Energy", At = 17 }, new Move { Name = "Bonemerang", At = 21 }, new Move { Name = "Rage", At = 23 }, new Move { Name = "False Swipe", At = 27 }, new Move { Name = "Thrash", At = 31 }, new Move { Name = "Fling", At = 33 }, new Move { Name = "Bone Rush", At = 37 }, new Move { Name = "Endeavor", At = 41 }, new Move { Name = "Double-Edge", At = 43 }, new Move { Name = "Retaliate", At = 47 }, },
                    eggMoves = { "Ancient Power", "Belly Drum", "Screech", "Skull Bash", "Perish Song", "Double Kick", "Iron Head", "Detect", "Endure", "Chip Away", },
                    item5 = "Thick Club",
                },

                new Species() {
                    Name = "Marowak",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Bone Club", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Bone Club", At = 7 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Leer", At = 13 }, new Move { Name = "Focus Energy", At = 17 }, new Move { Name = "Bonemerang", At = 21 }, new Move { Name = "Rage", At = 23 }, new Move { Name = "False Swipe", At = 27 }, new Move { Name = "Thrash", At = 33 }, new Move { Name = "Fling", At = 37 }, new Move { Name = "Bone Rush", At = 43 }, new Move { Name = "Endeavor", At = 49 }, new Move { Name = "Double-Edge", At = 53 }, new Move { Name = "Retaliate", At = 59 }, },
                    FS = true,
                    item5 = "Thick Club",
                },

                new Species() {
                    Name = "Hitmonlee",
                    moves = { new Move { Name = "Reversal", At = 1 }, new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Mega Kick", At = 1 }, new Move { Name = "Revenge", At = 1 }, new Move { Name = "Double Kick", At = 1 }, new Move { Name = "Meditate", At = 5 }, new Move { Name = "Rolling Kick", At = 9 }, new Move { Name = "Jump Kick", At = 13 }, new Move { Name = "Brick Break", At = 17 }, new Move { Name = "Focus Energy", At = 21 }, new Move { Name = "Feint", At = 25 }, new Move { Name = "High Jump Kick", At = 29 }, new Move { Name = "Mind Reader", At = 33 }, new Move { Name = "Foresight", At = 37 }, new Move { Name = "Wide Guard", At = 41 }, new Move { Name = "Blaze Kick", At = 45 }, new Move { Name = "Endure", At = 49 }, new Move { Name = "Mega Kick", At = 53 }, new Move { Name = "Close Combat", At = 57 }, new Move { Name = "Reversal", At = 61 }, },
                },

                new Species() {
                    Name = "Hitmonchan",
                    moves = { new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Counter", At = 1 }, new Move { Name = "Focus Punch", At = 1 }, new Move { Name = "Revenge", At = 1 }, new Move { Name = "Comet Punch", At = 1 }, new Move { Name = "Agility", At = 6 }, new Move { Name = "Pursuit", At = 11 }, new Move { Name = "Mach Punch", At = 16 }, new Move { Name = "Bullet Punch", At = 16 }, new Move { Name = "Feint", At = 21 }, new Move { Name = "Vacuum Wave", At = 26 }, new Move { Name = "Quick Guard", At = 31 }, new Move { Name = "Thunder Punch", At = 36 }, new Move { Name = "Ice Punch", At = 36 }, new Move { Name = "Fire Punch", At = 36 }, new Move { Name = "Sky Uppercut", At = 41 }, new Move { Name = "Mega Punch", At = 46 }, new Move { Name = "Detect", At = 50 }, new Move { Name = "Focus Punch", At = 56 }, new Move { Name = "Counter", At = 61 }, new Move { Name = "Close Combat", At = 66 }, },
                },

                new Species() {
                    Name = "Lickitung",
                    moves = { new Move { Name = "Lick", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Defense Curl", At = 9 }, new Move { Name = "Knock Off", At = 13 }, new Move { Name = "Wrap", At = 17 }, new Move { Name = "Stomp", At = 21 }, new Move { Name = "Disable", At = 25 }, new Move { Name = "Slam", At = 29 }, new Move { Name = "Rollout", At = 33 }, new Move { Name = "Chip Away", At = 37 }, new Move { Name = "Me First", At = 41 }, new Move { Name = "Refresh", At = 45 }, new Move { Name = "Screech", At = 49 }, new Move { Name = "Power Whip", At = 53 }, new Move { Name = "Wring Out", At = 57 }, },
                    eggMoves = { "Belly Drum", "Magnitude", "Body Slam", "Curse", "Smelling Salts", "Sleep Talk", "Snore", "Amnesia", "Hammer Arm", "Muddy Water", "Zen Headbutt", "Belch", },
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Koffing",
                    moves = { new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Smog", At = 4 }, new Move { Name = "Smokescreen", At = 7 }, new Move { Name = "Assurance", At = 12 }, new Move { Name = "Clear Smog", At = 15 }, new Move { Name = "Sludge", At = 18 }, new Move { Name = "Self-Destruct", At = 23 }, new Move { Name = "Haze", At = 26 }, new Move { Name = "Gyro Ball", At = 29 }, new Move { Name = "Sludge Bomb", At = 34 }, new Move { Name = "Explosion", At = 37 }, new Move { Name = "Destiny Bond", At = 40 }, new Move { Name = "Belch", At = 42 }, new Move { Name = "Memento", At = 45 }, },
                    eggMoves = { "Screech", "Psywave", "Psybeam", "Destiny Bond", "Pain Split", "Grudge", "Spite", "Curse", "Stockpile", "Swallow", "Spit Up", "Toxic Spikes", },
                    eggRand = 9,
                    item5 = "Smoke Ball",
                },

                new Species() {
                    Name = "Weezing",
                    moves = { new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Smog", At = 4 }, new Move { Name = "Smokescreen", At = 7 }, new Move { Name = "Assurance", At = 12 }, new Move { Name = "Clear Smog", At = 15 }, new Move { Name = "Sludge", At = 18 }, new Move { Name = "Self-Destruct", At = 23 }, new Move { Name = "Haze", At = 26 }, new Move { Name = "Double Hit", At = 29 }, new Move { Name = "Sludge Bomb", At = 34 }, new Move { Name = "Explosion", At = 40 }, new Move { Name = "Destiny Bond", At = 46 }, new Move { Name = "Belch", At = 51 }, new Move { Name = "Memento", At = 57 }, },
                    item5 = "Smoke Ball",
                },

                new Species() {
                    Name = "Rhyhorn",
                    moves = { new Move { Name = "Horn Attack", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Scary Face", At = 9 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Stomp", At = 17 }, new Move { Name = "Bulldoze", At = 21 }, new Move { Name = "Chip Away", At = 25 }, new Move { Name = "Rock Blast", At = 29 }, new Move { Name = "Drill Run", At = 33 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Stone Edge", At = 41 }, new Move { Name = "Earthquake", At = 45 }, new Move { Name = "Megahorn", At = 49 }, new Move { Name = "Horn Drill", At = 53 }, },
                    eggMoves = { "Crunch", "Reversal", "Counter", "Magnitude", "Curse", "Crush Claw", "Dragon Rush", "Ice Fang", "Fire Fang", "Thunder Fang", "Skull Bash", "Iron Tail", "Rock Climb", "Rototiller", "Metal Burst", "Guard Split", },
                },

                new Species() {
                    Name = "Rhydon",
                    moves = { new Move { Name = "Horn Drill", At = 1 }, new Move { Name = "Horn Attack", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Scary Face", At = 9 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Stomp", At = 17 }, new Move { Name = "Bulldoze", At = 21 }, new Move { Name = "Chip Away", At = 25 }, new Move { Name = "Rock Blast", At = 29 }, new Move { Name = "Drill Run", At = 33 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Stone Edge", At = 41 }, new Move { Name = "Hammer Arm", At = 42 }, new Move { Name = "Earthquake", At = 48 }, new Move { Name = "Megahorn", At = 55 }, new Move { Name = "Horn Drill", At = 62 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Chansey",
                    moves = { new Move { Name = "Double-Edge", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Refresh", At = 9 }, new Move { Name = "Double Slap", At = 12 }, new Move { Name = "Soft-Boiled", At = 16 }, new Move { Name = "Bestow", At = 20 }, new Move { Name = "Minimize", At = 23 }, new Move { Name = "Take Down", At = 27 }, new Move { Name = "Sing", At = 31 }, new Move { Name = "Fling", At = 34 }, new Move { Name = "Heal Pulse", At = 38 }, new Move { Name = "Egg Bomb", At = 42 }, new Move { Name = "Light Screen", At = 46 }, new Move { Name = "Healing Wish", At = 50 }, new Move { Name = "Double-Edge", At = 54 }, },
                    eggMoves = { "Present", "Metronome", "Heal Bell", "Aromatherapy", "Counter", "Helping Hand", "Gravity", "Mud Bomb", "Natural Gift", "Endure", "Seismic Toss", },
                    FS = true,
                    item5 = "Lucky Egg",
                    item50 = "Lucky Punch",
                },

                new Species() {
                    Name = "Tangela",
                    moves = { new Move { Name = "Ingrain", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Sleep Powder", At = 4 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Absorb", At = 10 }, new Move { Name = "Poison Powder", At = 14 }, new Move { Name = "Bind", At = 17 }, new Move { Name = "Growth", At = 20 }, new Move { Name = "Mega Drain", At = 23 }, new Move { Name = "Knock Off", At = 27 }, new Move { Name = "Stun Spore", At = 30 }, new Move { Name = "Natural Gift", At = 33 }, new Move { Name = "Giga Drain", At = 36 }, new Move { Name = "Ancient Power", At = 38 }, new Move { Name = "Slam", At = 41 }, new Move { Name = "Tickle", At = 44 }, new Move { Name = "Wring Out", At = 46 }, new Move { Name = "Grassy Terrain", At = 48 }, new Move { Name = "Power Whip", At = 50 }, },
                    eggMoves = { "Flail", "Confusion", "Mega Drain", "Amnesia", "Leech Seed", "Nature Power", "Endeavor", "Leaf Storm", "Power Swap", "Giga Drain", "Rage Powder", "Natural Gift", },
                    FS = true,
                },

                new Species() {
                    Name = "Kangaskhan",
                    moves = { new Move { Name = "Comet Punch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fake Out", At = 7 }, new Move { Name = "Tail Whip", At = 10 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Double Hit", At = 19 }, new Move { Name = "Rage", At = 22 }, new Move { Name = "Mega Punch", At = 25 }, new Move { Name = "Chip Away", At = 31 }, new Move { Name = "Dizzy Punch", At = 34 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Endure", At = 43 }, new Move { Name = "Outrage", At = 46 }, new Move { Name = "Sucker Punch", At = 49 }, new Move { Name = "Reversal", At = 50 }, },
                    eggMoves = { "Stomp", "Foresight", "Focus Energy", "Disable", "Counter", "Crush Claw", "Double-Edge", "Endeavor", "Hammer Arm", "Focus Punch", "Trump Card", "Uproar", "Circle Throw", },
                },

                new Species() {
                    Name = "Horsea",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Smokescreen", At = 5 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Water Gun", At = 13 }, new Move { Name = "Twister", At = 17 }, new Move { Name = "Bubble Beam", At = 21 }, new Move { Name = "Focus Energy", At = 26 }, new Move { Name = "Brine", At = 31 }, new Move { Name = "Agility", At = 36 }, new Move { Name = "Dragon Pulse", At = 41 }, new Move { Name = "Dragon Dance", At = 46 }, new Move { Name = "Hydro Pump", At = 52 }, },
                    eggMoves = { "Flail", "Aurora Beam", "Octazooka", "Disable", "Splash", "Dragon Rage", "Dragon Breath", "Signal Beam", "Razor Wind", "Muddy Water", "Water Pulse", "Clear Smog", "Outrage", },
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Seadra",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Smokescreen", At = 5 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Water Gun", At = 13 }, new Move { Name = "Twister", At = 17 }, new Move { Name = "Bubble Beam", At = 21 }, new Move { Name = "Focus Energy", At = 26 }, new Move { Name = "Brine", At = 31 }, new Move { Name = "Agility", At = 38 }, new Move { Name = "Dragon Pulse", At = 45 }, new Move { Name = "Dragon Dance", At = 52 }, new Move { Name = "Hydro Pump", At = 60 }, },
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Goldeen",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Horn Attack", At = 8 }, new Move { Name = "Flail", At = 13 }, new Move { Name = "Water Pulse", At = 16 }, new Move { Name = "Aqua Ring", At = 21 }, new Move { Name = "Fury Attack", At = 24 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Waterfall", At = 32 }, new Move { Name = "Horn Drill", At = 37 }, new Move { Name = "Soak", At = 40 }, new Move { Name = "Megahorn", At = 45 }, },
                    eggMoves = { "Psybeam", "Haze", "Hydro Pump", "Sleep Talk", "Mud Sport", "Mud-Slap", "Aqua Tail", "Body Slam", "Mud Shot", "Skull Bash", "Signal Beam", },
                    oras5 = "Mystic Water",
                },

                new Species() {
                    Name = "Seaking",
                    moves = { new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Poison Jab", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Horn Attack", At = 8 }, new Move { Name = "Flail", At = 13 }, new Move { Name = "Water Pulse", At = 16 }, new Move { Name = "Aqua Ring", At = 21 }, new Move { Name = "Fury Attack", At = 24 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Waterfall", At = 32 }, new Move { Name = "Horn Drill", At = 40 }, new Move { Name = "Soak", At = 46 }, new Move { Name = "Megahorn", At = 54 }, },
                    oras5 = "Mystic Water",
                },

                new Species() {
                    Name = "Staryu",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Rapid Spin", At = 7 }, new Move { Name = "Recover", At = 10 }, new Move { Name = "Psywave", At = 13 }, new Move { Name = "Swift", At = 16 }, new Move { Name = "Bubble Beam", At = 18 }, new Move { Name = "Camouflage", At = 22 }, new Move { Name = "Gyro Ball", At = 24 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Minimize", At = 31 }, new Move { Name = "Reflect Type", At = 35 }, new Move { Name = "Power Gem", At = 37 }, new Move { Name = "Confuse Ray", At = 40 }, new Move { Name = "Psychic", At = 42 }, new Move { Name = "Light Screen", At = 46 }, new Move { Name = "Cosmic Power", At = 49 }, new Move { Name = "Hydro Pump", At = 53 }, },
                    item5 = "Star Piece",
                    item50 = "Stardust",
                },

                new Species() {
                    Name = "Starmie",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rapid Spin", At = 1 }, new Move { Name = "Recover", At = 1 }, new Move { Name = "Swift", At = 1 }, new Move { Name = "Confuse Ray", At = 40 }, },
                    item5 = "Star Piece",
                    item50 = "Stardust",
                },

                new Species() {
                    Name = "Mr. Mime",
                    moves = { new Move { Name = "Misty Terrain", At = 1 }, new Move { Name = "Magical Leaf", At = 1 }, new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Wide Guard", At = 1 }, new Move { Name = "Power Swap", At = 1 }, new Move { Name = "Guard Swap", At = 1 }, new Move { Name = "Barrier", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Copycat", At = 4 }, new Move { Name = "Meditate", At = 8 }, new Move { Name = "Double Slap", At = 11 }, new Move { Name = "Mimic", At = 15 }, new Move { Name = "Psywave", At = 15 }, new Move { Name = "Encore", At = 18 }, new Move { Name = "Light Screen", At = 22 }, new Move { Name = "Reflect", At = 22 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Substitute", At = 29 }, new Move { Name = "Recycle", At = 32 }, new Move { Name = "Trick", At = 36 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Role Play", At = 43 }, new Move { Name = "Baton Pass", At = 46 }, new Move { Name = "Safeguard", At = 50 }, },
                    eggMoves = { "Future Sight", "Hypnosis", "Mimic", "Fake Out", "Trick", "Confuse Ray", "Wake-Up Slap", "Teeter Dance", "Nasty Plot", "Power Split", "Magic Room", "Icy Wind", },
                },

                new Species() {
                    Name = "Scyther",
                    moves = { new Move { Name = "Vacuum Wave", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 5 }, new Move { Name = "Pursuit", At = 9 }, new Move { Name = "False Swipe", At = 13 }, new Move { Name = "Agility", At = 17 }, new Move { Name = "Wing Attack", At = 21 }, new Move { Name = "Fury Cutter", At = 25 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Razor Wind", At = 33 }, new Move { Name = "Double Team", At = 37 }, new Move { Name = "X-Scissor", At = 41 }, new Move { Name = "Night Slash", At = 45 }, new Move { Name = "Double Hit", At = 49 }, new Move { Name = "Air Slash", At = 50 }, new Move { Name = "Swords Dance", At = 57 }, new Move { Name = "Feint", At = 61 }, },
                    eggMoves = { "Counter", "Baton Pass", "Razor Wind", "Reversal", "Endure", "Silver Wind", "Bug Buzz", "Night Slash", "Defog", "Steel Wing", "Quick Guard", },
                },

                new Species() {
                    Name = "Jynx",
                    moves = { new Move { Name = "Draining Kiss", At = 1 }, new Move { Name = "Perish Song", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Lovely Kiss", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Lick", At = 5 }, new Move { Name = "Lovely Kiss", At = 8 }, new Move { Name = "Powder Snow", At = 11 }, new Move { Name = "Double Slap", At = 15 }, new Move { Name = "Ice Punch", At = 18 }, new Move { Name = "Heart Stamp", At = 21 }, new Move { Name = "Mean Look", At = 25 }, new Move { Name = "Fake Tears", At = 28 }, new Move { Name = "Wake-Up Slap", At = 33 }, new Move { Name = "Avalanche", At = 39 }, new Move { Name = "Body Slam", At = 44 }, new Move { Name = "Wring Out", At = 49 }, new Move { Name = "Perish Song", At = 55 }, new Move { Name = "Blizzard", At = 60 }, },
                },

                new Species() {
                    Name = "Electabuzz",
                    moves = { new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Thunder Shock", At = 5 }, new Move { Name = "Low Kick", At = 8 }, new Move { Name = "Swift", At = 12 }, new Move { Name = "Shock Wave", At = 15 }, new Move { Name = "Thunder Wave", At = 19 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Light Screen", At = 26 }, new Move { Name = "Thunder Punch", At = 29 }, new Move { Name = "Discharge", At = 36 }, new Move { Name = "Screech", At = 42 }, new Move { Name = "Thunderbolt", At = 49 }, new Move { Name = "Thunder", At = 55 }, },
                    FS = true,
                    item5 = "Electirizer",
                },

                new Species() {
                    Name = "Magmar",
                    moves = { new Move { Name = "Smog", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Smokescreen", At = 8 }, new Move { Name = "Feint Attack", At = 12 }, new Move { Name = "Fire Spin", At = 15 }, new Move { Name = "Clear Smog", At = 19 }, new Move { Name = "Flame Burst", At = 22 }, new Move { Name = "Confuse Ray", At = 26 }, new Move { Name = "Fire Punch", At = 29 }, new Move { Name = "Lava Plume", At = 36 }, new Move { Name = "Sunny Day", At = 42 }, new Move { Name = "Flamethrower", At = 49 }, new Move { Name = "Fire Blast", At = 55 }, },
                    FS = true,
                    item5 = "Magmarizer",
                },

                new Species() {
                    Name = "Pinsir",
                    moves = { new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Bind", At = 4 }, new Move { Name = "Seismic Toss", At = 8 }, new Move { Name = "Harden", At = 11 }, new Move { Name = "Revenge", At = 15 }, new Move { Name = "Vital Throw", At = 18 }, new Move { Name = "Double Hit", At = 22 }, new Move { Name = "Brick Break", At = 26 }, new Move { Name = "Submission", At = 29 }, new Move { Name = "X-Scissor", At = 33 }, new Move { Name = "Storm Throw", At = 36 }, new Move { Name = "Swords Dance", At = 40 }, new Move { Name = "Thrash", At = 43 }, new Move { Name = "Superpower", At = 47 }, new Move { Name = "Guillotine", At = 50 }, },
                    eggMoves = { "Fury Attack", "Flail", "Feint Attack", "Quick Attack", "Close Combat", "Feint", "Me First", "Bug Bite", "Superpower", },
                    FS = true,
                },

                new Species() {
                    Name = "Tauros",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Rage", At = 5 }, new Move { Name = "Horn Attack", At = 8 }, new Move { Name = "Scary Face", At = 11 }, new Move { Name = "Pursuit", At = 15 }, new Move { Name = "Rest", At = 19 }, new Move { Name = "Payback", At = 24 }, new Move { Name = "Work Up", At = 29 }, new Move { Name = "Zen Headbutt", At = 35 }, new Move { Name = "Take Down", At = 41 }, new Move { Name = "Swagger", At = 48 }, new Move { Name = "Thrash", At = 50 }, new Move { Name = "Giga Impact", At = 63 }, },
                },

                new Species() {
                    Name = "Magikarp",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Tackle", At = 15 }, new Move { Name = "Flail", At = 30 }, },
                },

                new Species() {
                    Name = "Gyarados",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Bite", At = 20 }, new Move { Name = "Dragon Rage", At = 23 }, new Move { Name = "Leer", At = 26 }, new Move { Name = "Twister", At = 29 }, new Move { Name = "Ice Fang", At = 32 }, new Move { Name = "Aqua Tail", At = 35 }, new Move { Name = "Rain Dance", At = 38 }, new Move { Name = "Crunch", At = 41 }, new Move { Name = "Hydro Pump", At = 44 }, new Move { Name = "Dragon Dance", At = 47 }, new Move { Name = "Hyper Beam", At = 50 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Lapras",
                    moves = { new Move { Name = "Sing", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mist", At = 4 }, new Move { Name = "Confuse Ray", At = 7 }, new Move { Name = "Ice Shard", At = 10 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Body Slam", At = 18 }, new Move { Name = "Rain Dance", At = 22 }, new Move { Name = "Perish Song", At = 27 }, new Move { Name = "Ice Beam", At = 32 }, new Move { Name = "Brine", At = 37 }, new Move { Name = "Safeguard", At = 43 }, new Move { Name = "Hydro Pump", At = 47 }, new Move { Name = "Sheer Cold", At = 50 }, },
                    eggMoves = { "Foresight", "Tickle", "Refresh", "Dragon Dance", "Curse", "Sleep Talk", "Horn Drill", "Ancient Power", "Whirlpool", "Fissure", "Dragon Pulse", "Avalanche", "Future Sight", "Freeze-Dry", },
                    FS = true,
                    item100 = "Mystic Water",
                },

                new Species() {
                    Name = "Ditto",
                    moves = { new Move { Name = "Transform", At = 1 }, },
                    FS = true,
                    item5 = "Metal Powder",
                    item50 = "Quick Powder",
                },

                new Species() {
                    Name = "Eevee",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Baby-Doll Eyes", At = 9 }, new Move { Name = "Swift", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Refresh", At = 20 }, new Move { Name = "Covet", At = 23 }, new Move { Name = "Take Down", At = 25 }, new Move { Name = "Charm", At = 29 }, new Move { Name = "Baton Pass", At = 33 }, new Move { Name = "Double-Edge", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Trump Card", At = 45 }, },
                    eggMoves = { "Charm", "Flail", "Endure", "Curse", "Tickle", "Wish", "Yawn", "Fake Tears", "Covet", "Detect", "Natural Gift", "Stored Power", "Synchronoise", "Captivate", },
                    FS = true,
                },

                new Species() {
                    Name = "Vaporeon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Water Pulse", At = 17 }, new Move { Name = "Aurora Beam", At = 20 }, new Move { Name = "Aqua Ring", At = 25 }, new Move { Name = "Acid Armor", At = 29 }, new Move { Name = "Haze", At = 33 }, new Move { Name = "Muddy Water", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Hydro Pump", At = 45 }, },
                },

                new Species() {
                    Name = "Jolteon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Thunder Shock", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Double Kick", At = 17 }, new Move { Name = "Thunder Fang", At = 20 }, new Move { Name = "Pin Missile", At = 25 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Thunder Wave", At = 33 }, new Move { Name = "Discharge", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Thunder", At = 45 }, },
                },

                new Species() {
                    Name = "Flareon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Ember", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Fire Fang", At = 20 }, new Move { Name = "Fire Spin", At = 25 }, new Move { Name = "Scary Face", At = 29 }, new Move { Name = "Smog", At = 33 }, new Move { Name = "Lava Plume", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Flare Blitz", At = 45 }, },
                },

                new Species() {
                    Name = "Porygon",
                    moves = { new Move { Name = "Conversion 2", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Conversion", At = 1 }, new Move { Name = "Sharpen", At = 1 }, new Move { Name = "Psybeam", At = 7 }, new Move { Name = "Agility", At = 12 }, new Move { Name = "Recover", At = 18 }, new Move { Name = "Magnet Rise", At = 23 }, new Move { Name = "Signal Beam", At = 29 }, new Move { Name = "Recycle", At = 34 }, new Move { Name = "Discharge", At = 40 }, new Move { Name = "Lock-On", At = 45 }, new Move { Name = "Tri Attack", At = 50 }, new Move { Name = "Magic Coat", At = 56 }, new Move { Name = "Zap Cannon", At = 62 }, },
                },

                new Species() {
                    Name = "Omanyte",
                    moves = { new Move { Name = "Constrict", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Water Gun", At = 10 }, new Move { Name = "Rollout", At = 16 }, new Move { Name = "Leer", At = 19 }, new Move { Name = "Mud Shot", At = 25 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Protect", At = 34 }, new Move { Name = "Ancient Power", At = 37 }, new Move { Name = "Tickle", At = 43 }, new Move { Name = "Rock Blast", At = 46 }, new Move { Name = "Shell Smash", At = 50 }, new Move { Name = "Hydro Pump", At = 55 }, },
                    eggMoves = { "Bubble Beam", "Aurora Beam", "Slam", "Supersonic", "Haze", "Spikes", "Knock Off", "Wring Out", "Toxic Spikes", "Muddy Water", "Bide", "Water Pulse", "Whirlpool", "Reflect Type", },
                },

                new Species() {
                    Name = "Omastar",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Water Gun", At = 10 }, new Move { Name = "Rollout", At = 16 }, new Move { Name = "Leer", At = 19 }, new Move { Name = "Mud Shot", At = 25 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Protect", At = 34 }, new Move { Name = "Ancient Power", At = 37 }, new Move { Name = "Spike Cannon", At = 40 }, new Move { Name = "Tickle", At = 48 }, new Move { Name = "Rock Blast", At = 56 }, new Move { Name = "Shell Smash", At = 67 }, new Move { Name = "Hydro Pump", At = 75 }, },
                },

                new Species() {
                    Name = "Kabuto",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Absorb", At = 6 }, new Move { Name = "Leer", At = 11 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Sand Attack", At = 21 }, new Move { Name = "Endure", At = 26 }, new Move { Name = "Aqua Jet", At = 31 }, new Move { Name = "Mega Drain", At = 36 }, new Move { Name = "Metal Sound", At = 41 }, new Move { Name = "Ancient Power", At = 46 }, new Move { Name = "Wring Out", At = 50 }, },
                    eggMoves = { "Bubble Beam", "Aurora Beam", "Rapid Spin", "Flail", "Knock Off", "Confuse Ray", "Mud Shot", "Icy Wind", "Screech", "Giga Drain", "Foresight", "Take Down", },
                },

                new Species() {
                    Name = "Kabutops",
                    moves = { new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Feint", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 6 }, new Move { Name = "Leer", At = 11 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Sand Attack", At = 21 }, new Move { Name = "Endure", At = 26 }, new Move { Name = "Aqua Jet", At = 31 }, new Move { Name = "Mega Drain", At = 36 }, new Move { Name = "Slash", At = 40 }, new Move { Name = "Metal Sound", At = 45 }, new Move { Name = "Ancient Power", At = 54 }, new Move { Name = "Wring Out", At = 63 }, new Move { Name = "Night Slash", At = 72 }, },
                },

                new Species() {
                    Name = "Aerodactyl",
                    moves = { new Move { Name = "Iron Head", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Roar", At = 9 }, new Move { Name = "Agility", At = 17 }, new Move { Name = "Ancient Power", At = 25 }, new Move { Name = "Crunch", At = 33 }, new Move { Name = "Take Down", At = 41 }, new Move { Name = "Sky Drop", At = 49 }, new Move { Name = "Iron Head", At = 57 }, new Move { Name = "Hyper Beam", At = 65 }, new Move { Name = "Rock Slide", At = 73 }, new Move { Name = "Giga Impact", At = 81 }, },
                    eggMoves = { "Whirlwind", "Pursuit", "Foresight", "Steel Wing", "Dragon Breath", "Curse", "Assurance", "Roost", "Tailwind", "Wide Guard", },
                },

                new Species() {
                    Name = "Snorlax",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Defense Curl", At = 4 }, new Move { Name = "Amnesia", At = 9 }, new Move { Name = "Lick", At = 12 }, new Move { Name = "Chip Away", At = 17 }, new Move { Name = "Yawn", At = 20 }, new Move { Name = "Body Slam", At = 25 }, new Move { Name = "Rest", At = 28 }, new Move { Name = "Snore", At = 28 }, new Move { Name = "Sleep Talk", At = 33 }, new Move { Name = "Rollout", At = 36 }, new Move { Name = "Block", At = 41 }, new Move { Name = "Belly Drum", At = 44 }, new Move { Name = "Crunch", At = 49 }, new Move { Name = "Heavy Slam", At = 50 }, new Move { Name = "Giga Impact", At = 57 }, },
                    eggMoves = { "Lick", "Charm", "Double-Edge", "Curse", "Fissure", "Whirlwind", "Pursuit", "Counter", "Natural Gift", "After You", "Belch", },
                    item100 = "Leftovers",
                },

                new Species() {
                    Name = "Articuno",
                    moves = { new Move { Name = "Roost", At = 1 }, new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Freeze-Dry", At = 1 }, new Move { Name = "Tailwind", At = 1 }, new Move { Name = "Sheer Cold", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Mist", At = 8 }, new Move { Name = "Ice Shard", At = 15 }, new Move { Name = "Mind Reader", At = 22 }, new Move { Name = "Ancient Power", At = 29 }, new Move { Name = "Agility", At = 36 }, new Move { Name = "Ice Beam", At = 43 }, new Move { Name = "Reflect", At = 50 }, new Move { Name = "Hail", At = 57 }, new Move { Name = "Tailwind", At = 64 }, new Move { Name = "Blizzard", At = 71 }, new Move { Name = "Sheer Cold", At = 78 }, new Move { Name = "Roost", At = 85 }, new Move { Name = "Hurricane", At = 92 }, },
                },

                new Species() {
                    Name = "Zapdos",
                    moves = { new Move { Name = "Roost", At = 1 }, new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Drill Peck", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Thunder Wave", At = 8 }, new Move { Name = "Detect", At = 15 }, new Move { Name = "Pluck", At = 22 }, new Move { Name = "Ancient Power", At = 29 }, new Move { Name = "Charge", At = 36 }, new Move { Name = "Agility", At = 43 }, new Move { Name = "Discharge", At = 50 }, new Move { Name = "Rain Dance", At = 57 }, new Move { Name = "Light Screen", At = 64 }, new Move { Name = "Drill Peck", At = 71 }, new Move { Name = "Thunder", At = 78 }, new Move { Name = "Roost", At = 85 }, new Move { Name = "Zap Cannon", At = 92 }, },
                },

                new Species() {
                    Name = "Moltres",
                    moves = { new Move { Name = "Roost", At = 1 }, new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Sky Attack", At = 1 }, new Move { Name = "Heat Wave", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Fire Spin", At = 8 }, new Move { Name = "Agility", At = 15 }, new Move { Name = "Endure", At = 22 }, new Move { Name = "Ancient Power", At = 29 }, new Move { Name = "Flamethrower", At = 36 }, new Move { Name = "Safeguard", At = 43 }, new Move { Name = "Air Slash", At = 50 }, new Move { Name = "Sunny Day", At = 57 }, new Move { Name = "Heat Wave", At = 64 }, new Move { Name = "Solar Beam", At = 71 }, new Move { Name = "Sky Attack", At = 78 }, new Move { Name = "Roost", At = 85 }, new Move { Name = "Hurricane", At = 92 }, },
                },

                new Species() {
                    Name = "Dratini",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Wave", At = 5 }, new Move { Name = "Twister", At = 11 }, new Move { Name = "Dragon Rage", At = 15 }, new Move { Name = "Slam", At = 21 }, new Move { Name = "Agility", At = 25 }, new Move { Name = "Dragon Tail", At = 31 }, new Move { Name = "Aqua Tail", At = 35 }, new Move { Name = "Dragon Rush", At = 41 }, new Move { Name = "Safeguard", At = 45 }, new Move { Name = "Dragon Dance", At = 51 }, new Move { Name = "Outrage", At = 55 }, new Move { Name = "Hyper Beam", At = 61 }, },
                    eggMoves = { "Mist", "Haze", "Supersonic", "Dragon Breath", "Dragon Dance", "Dragon Rush", "Extreme Speed", "Water Pulse", "Aqua Jet", "Dragon Pulse", "Iron Tail", },
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Dragonair",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Twister", At = 1 }, new Move { Name = "Thunder Wave", At = 5 }, new Move { Name = "Twister", At = 11 }, new Move { Name = "Dragon Rage", At = 15 }, new Move { Name = "Slam", At = 21 }, new Move { Name = "Agility", At = 25 }, new Move { Name = "Dragon Tail", At = 33 }, new Move { Name = "Aqua Tail", At = 39 }, new Move { Name = "Dragon Rush", At = 47 }, new Move { Name = "Safeguard", At = 53 }, new Move { Name = "Dragon Dance", At = 61 }, new Move { Name = "Outrage", At = 67 }, new Move { Name = "Hyper Beam", At = 75 }, },
                    FS = true,
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Dragonite",
                    moves = { new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Roost", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Twister", At = 1 }, new Move { Name = "Thunder Wave", At = 5 }, new Move { Name = "Twister", At = 11 }, new Move { Name = "Dragon Rage", At = 15 }, new Move { Name = "Slam", At = 21 }, new Move { Name = "Agility", At = 25 }, new Move { Name = "Dragon Tail", At = 33 }, new Move { Name = "Aqua Tail", At = 39 }, new Move { Name = "Dragon Rush", At = 47 }, new Move { Name = "Safeguard", At = 53 }, new Move { Name = "Wing Attack", At = 55 }, new Move { Name = "Dragon Dance", At = 61 }, new Move { Name = "Outrage", At = 67 }, new Move { Name = "Hyper Beam", At = 75 }, new Move { Name = "Hurricane", At = 81 }, },
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Mewtwo",
                    moves = { new Move { Name = "Confusion", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Safeguard", At = 1 }, new Move { Name = "Swift", At = 8 }, new Move { Name = "Future Sight", At = 15 }, new Move { Name = "Psych Up", At = 22 }, new Move { Name = "Miracle Eye", At = 29 }, new Move { Name = "Psycho Cut", At = 36 }, new Move { Name = "Power Swap", At = 43 }, new Move { Name = "Guard Swap", At = 43 }, new Move { Name = "Recover", At = 50 }, new Move { Name = "Psychic", At = 57 }, new Move { Name = "Barrier", At = 64 }, new Move { Name = "Aura Sphere", At = 70 }, new Move { Name = "Amnesia", At = 79 }, new Move { Name = "Mist", At = 86 }, new Move { Name = "Me First", At = 93 }, new Move { Name = "Psystrike", At = 100 }, },
                },

                new Species() {
                    Name = "Mew",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Reflect Type", At = 1 }, new Move { Name = "Transform", At = 1 }, new Move { Name = "Mega Punch", At = 10 }, new Move { Name = "Metronome", At = 20 }, new Move { Name = "Psychic", At = 30 }, new Move { Name = "Barrier", At = 40 }, new Move { Name = "Ancient Power", At = 50 }, new Move { Name = "Amnesia", At = 60 }, new Move { Name = "Me First", At = 70 }, new Move { Name = "Baton Pass", At = 80 }, new Move { Name = "Nasty Plot", At = 90 }, new Move { Name = "Aura Sphere", At = 100 }, },
                    item5 = "Lum Berry",
                },

                new Species() {
                    Name = "Chikorita",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Razor Leaf", At = 6 }, new Move { Name = "Poison Powder", At = 9 }, new Move { Name = "Synthesis", At = 12 }, new Move { Name = "Reflect", At = 17 }, new Move { Name = "Magical Leaf", At = 20 }, new Move { Name = "Natural Gift", At = 23 }, new Move { Name = "Sweet Scent", At = 28 }, new Move { Name = "Light Screen", At = 31 }, new Move { Name = "Body Slam", At = 34 }, new Move { Name = "Safeguard", At = 39 }, new Move { Name = "Aromatherapy", At = 42 }, new Move { Name = "Solar Beam", At = 45 }, },
                    eggMoves = { "Vine Whip", "Leech Seed", "Counter", "Ancient Power", "Flail", "Nature Power", "Ingrain", "Grass Whistle", "Leaf Storm", "Aromatherapy", "Wring Out", "Body Slam", "Refresh", "Heal Pulse", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Bayleef",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Poison Powder", At = 1 }, new Move { Name = "Razor Leaf", At = 6 }, new Move { Name = "Poison Powder", At = 9 }, new Move { Name = "Synthesis", At = 12 }, new Move { Name = "Reflect", At = 18 }, new Move { Name = "Magical Leaf", At = 22 }, new Move { Name = "Natural Gift", At = 26 }, new Move { Name = "Sweet Scent", At = 32 }, new Move { Name = "Light Screen", At = 36 }, new Move { Name = "Body Slam", At = 40 }, new Move { Name = "Safeguard", At = 46 }, new Move { Name = "Aromatherapy", At = 50 }, new Move { Name = "Solar Beam", At = 54 }, },
                },

                new Species() {
                    Name = "Meganium",
                    moves = { new Move { Name = "Petal Blizzard", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Poison Powder", At = 1 }, new Move { Name = "Razor Leaf", At = 6 }, new Move { Name = "Poison Powder", At = 9 }, new Move { Name = "Synthesis", At = 12 }, new Move { Name = "Reflect", At = 18 }, new Move { Name = "Magical Leaf", At = 22 }, new Move { Name = "Natural Gift", At = 26 }, new Move { Name = "Petal Dance", At = 32 }, new Move { Name = "Sweet Scent", At = 34 }, new Move { Name = "Light Screen", At = 40 }, new Move { Name = "Body Slam", At = 46 }, new Move { Name = "Safeguard", At = 54 }, new Move { Name = "Aromatherapy", At = 60 }, new Move { Name = "Solar Beam", At = 66 }, new Move { Name = "Petal Blizzard", At = 70 }, },
                },

                new Species() {
                    Name = "Cyndaquil",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Smokescreen", At = 6 }, new Move { Name = "Ember", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Flame Wheel", At = 19 }, new Move { Name = "Defense Curl", At = 22 }, new Move { Name = "Flame Charge", At = 28 }, new Move { Name = "Swift", At = 31 }, new Move { Name = "Lava Plume", At = 37 }, new Move { Name = "Flamethrower", At = 40 }, new Move { Name = "Inferno", At = 46 }, new Move { Name = "Rollout", At = 49 }, new Move { Name = "Double-Edge", At = 55 }, new Move { Name = "Eruption", At = 58 }, },
                    eggMoves = { "Fury Swipes", "Quick Attack", "Reversal", "Thrash", "Foresight", "Covet", "Howl", "Crush Claw", "Double-Edge", "Double Kick", "Flare Blitz", "Extrasensory", "Nature Power", "Flame Burst", },
                },

                new Species() {
                    Name = "Quilava",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Smokescreen", At = 6 }, new Move { Name = "Ember", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Flame Wheel", At = 20 }, new Move { Name = "Defense Curl", At = 24 }, new Move { Name = "Swift", At = 31 }, new Move { Name = "Flame Charge", At = 35 }, new Move { Name = "Lava Plume", At = 42 }, new Move { Name = "Flamethrower", At = 46 }, new Move { Name = "Inferno", At = 53 }, new Move { Name = "Rollout", At = 57 }, new Move { Name = "Double-Edge", At = 64 }, new Move { Name = "Eruption", At = 68 }, },
                },

                new Species() {
                    Name = "Typhlosion",
                    moves = { new Move { Name = "Eruption", At = 1 }, new Move { Name = "Double-Edge", At = 1 }, new Move { Name = "Gyro Ball", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Smokescreen", At = 6 }, new Move { Name = "Ember", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Flame Wheel", At = 20 }, new Move { Name = "Defense Curl", At = 24 }, new Move { Name = "Swift", At = 31 }, new Move { Name = "Flame Charge", At = 35 }, new Move { Name = "Lava Plume", At = 43 }, new Move { Name = "Flamethrower", At = 48 }, new Move { Name = "Inferno", At = 56 }, new Move { Name = "Rollout", At = 61 }, new Move { Name = "Double-Edge", At = 69 }, new Move { Name = "Eruption", At = 74 }, },
                },

                new Species() {
                    Name = "Totodile",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Water Gun", At = 6 }, new Move { Name = "Rage", At = 8 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Scary Face", At = 15 }, new Move { Name = "Ice Fang", At = 20 }, new Move { Name = "Flail", At = 22 }, new Move { Name = "Crunch", At = 27 }, new Move { Name = "Chip Away", At = 29 }, new Move { Name = "Slash", At = 34 }, new Move { Name = "Screech", At = 36 }, new Move { Name = "Thrash", At = 41 }, new Move { Name = "Aqua Tail", At = 43 }, new Move { Name = "Superpower", At = 48 }, new Move { Name = "Hydro Pump", At = 50 }, },
                    eggMoves = { "Crunch", "Thrash", "Hydro Pump", "Ancient Power", "Mud Sport", "Water Sport", "Ice Punch", "Metal Claw", "Dragon Dance", "Aqua Jet", "Fake Tears", "Block", "Water Pulse", "Flatter", },
                },

                new Species() {
                    Name = "Croconaw",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Gun", At = 6 }, new Move { Name = "Rage", At = 8 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Scary Face", At = 15 }, new Move { Name = "Ice Fang", At = 21 }, new Move { Name = "Flail", At = 24 }, new Move { Name = "Crunch", At = 30 }, new Move { Name = "Chip Away", At = 33 }, new Move { Name = "Slash", At = 39 }, new Move { Name = "Screech", At = 42 }, new Move { Name = "Thrash", At = 48 }, new Move { Name = "Aqua Tail", At = 51 }, new Move { Name = "Superpower", At = 57 }, new Move { Name = "Hydro Pump", At = 60 }, },
                },

                new Species() {
                    Name = "Feraligatr",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Water Gun", At = 6 }, new Move { Name = "Rage", At = 8 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Scary Face", At = 15 }, new Move { Name = "Ice Fang", At = 21 }, new Move { Name = "Flail", At = 24 }, new Move { Name = "Agility", At = 30 }, new Move { Name = "Crunch", At = 32 }, new Move { Name = "Chip Away", At = 37 }, new Move { Name = "Slash", At = 45 }, new Move { Name = "Screech", At = 50 }, new Move { Name = "Thrash", At = 58 }, new Move { Name = "Aqua Tail", At = 63 }, new Move { Name = "Superpower", At = 71 }, new Move { Name = "Hydro Pump", At = 76 }, },
                },

                new Species() {
                    Name = "Sentret",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Defense Curl", At = 4 }, new Move { Name = "Quick Attack", At = 7 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Helping Hand", At = 16 }, new Move { Name = "Follow Me", At = 19 }, new Move { Name = "Slam", At = 25 }, new Move { Name = "Rest", At = 28 }, new Move { Name = "Sucker Punch", At = 31 }, new Move { Name = "Amnesia", At = 36 }, new Move { Name = "Baton Pass", At = 39 }, new Move { Name = "Me First", At = 42 }, new Move { Name = "Hyper Voice", At = 47 }, },
                    eggMoves = { "Double-Edge", "Pursuit", "Slash", "Focus Energy", "Reversal", "Trick", "Assist", "Last Resort", "Charm", "Covet", "Natural Gift", "Iron Tail", "Captivate", },
                },

                new Species() {
                    Name = "Furret",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Defense Curl", At = 4 }, new Move { Name = "Quick Attack", At = 7 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Helping Hand", At = 17 }, new Move { Name = "Follow Me", At = 21 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Rest", At = 32 }, new Move { Name = "Sucker Punch", At = 36 }, new Move { Name = "Amnesia", At = 42 }, new Move { Name = "Baton Pass", At = 46 }, new Move { Name = "Me First", At = 50 }, new Move { Name = "Hyper Voice", At = 56 }, },
                },

                new Species() {
                    Name = "Hoothoot",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Hypnosis", At = 5 }, new Move { Name = "Peck", At = 9 }, new Move { Name = "Uproar", At = 13 }, new Move { Name = "Reflect", At = 17 }, new Move { Name = "Confusion", At = 21 }, new Move { Name = "Echoed Voice", At = 25 }, new Move { Name = "Take Down", At = 29 }, new Move { Name = "Air Slash", At = 33 }, new Move { Name = "Zen Headbutt", At = 37 }, new Move { Name = "Synchronoise", At = 41 }, new Move { Name = "Extrasensory", At = 45 }, new Move { Name = "Psycho Shift", At = 49 }, new Move { Name = "Roost", At = 53 }, new Move { Name = "Dream Eater", At = 57 }, },
                    eggMoves = { "Mirror Move", "Supersonic", "Feint Attack", "Wing Attack", "Whirlwind", "Sky Attack", "Feather Dance", "Agility", "Night Shade", "Defog", },
                    FS = true,
                },

                new Species() {
                    Name = "Noctowl",
                    moves = { new Move { Name = "Dream Eater", At = 1 }, new Move { Name = "Sky Attack", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Hypnosis", At = 5 }, new Move { Name = "Peck", At = 9 }, new Move { Name = "Uproar", At = 13 }, new Move { Name = "Reflect", At = 17 }, new Move { Name = "Confusion", At = 22 }, new Move { Name = "Echoed Voice", At = 27 }, new Move { Name = "Take Down", At = 32 }, new Move { Name = "Air Slash", At = 37 }, new Move { Name = "Zen Headbutt", At = 42 }, new Move { Name = "Synchronoise", At = 47 }, new Move { Name = "Extrasensory", At = 52 }, new Move { Name = "Psycho Shift", At = 57 }, new Move { Name = "Roost", At = 62 }, new Move { Name = "Dream Eater", At = 67 }, },
                },

                new Species() {
                    Name = "Ledyba",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Supersonic", At = 6 }, new Move { Name = "Comet Punch", At = 9 }, new Move { Name = "Light Screen", At = 14 }, new Move { Name = "Reflect", At = 14 }, new Move { Name = "Safeguard", At = 14 }, new Move { Name = "Mach Punch", At = 17 }, new Move { Name = "Baton Pass", At = 22 }, new Move { Name = "Silver Wind", At = 25 }, new Move { Name = "Agility", At = 30 }, new Move { Name = "Swift", At = 33 }, new Move { Name = "Double-Edge", At = 38 }, new Move { Name = "Bug Buzz", At = 41 }, },
                    eggMoves = { "Psybeam", "Bide", "Silver Wind", "Bug Buzz", "Screech", "Encore", "Knock Off", "Bug Bite", "Focus Punch", "Drain Punch", "Dizzy Punch", "Tailwind", },
                    FS = true,
                },

                new Species() {
                    Name = "Ledian",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Comet Punch", At = 1 }, new Move { Name = "Supersonic", At = 6 }, new Move { Name = "Comet Punch", At = 9 }, new Move { Name = "Light Screen", At = 14 }, new Move { Name = "Reflect", At = 14 }, new Move { Name = "Safeguard", At = 14 }, new Move { Name = "Mach Punch", At = 17 }, new Move { Name = "Baton Pass", At = 24 }, new Move { Name = "Silver Wind", At = 29 }, new Move { Name = "Agility", At = 36 }, new Move { Name = "Swift", At = 41 }, new Move { Name = "Double-Edge", At = 48 }, new Move { Name = "Bug Buzz", At = 53 }, },
                },

                new Species() {
                    Name = "Spinarak",
                    moves = { new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Scary Face", At = 5 }, new Move { Name = "Constrict", At = 8 }, new Move { Name = "Leech Life", At = 12 }, new Move { Name = "Night Shade", At = 15 }, new Move { Name = "Shadow Sneak", At = 19 }, new Move { Name = "Fury Swipes", At = 22 }, new Move { Name = "Sucker Punch", At = 26 }, new Move { Name = "Spider Web", At = 29 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Pin Missile", At = 36 }, new Move { Name = "Psychic", At = 40 }, new Move { Name = "Poison Jab", At = 43 }, new Move { Name = "Cross Poison", At = 47 }, new Move { Name = "Sticky Web", At = 50 }, },
                    eggMoves = { "Psybeam", "Disable", "Sonic Boom", "Baton Pass", "Pursuit", "Signal Beam", "Toxic Spikes", "Twineedle", "Electroweb", "Rage Powder", "Night Slash", "Megahorn", },
                },

                new Species() {
                    Name = "Ariados",
                    moves = { new Move { Name = "Venom Drench", At = 1 }, new Move { Name = "Fell Stinger", At = 1 }, new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Scary Face", At = 5 }, new Move { Name = "Constrict", At = 8 }, new Move { Name = "Leech Life", At = 12 }, new Move { Name = "Night Shade", At = 15 }, new Move { Name = "Shadow Sneak", At = 19 }, new Move { Name = "Fury Swipes", At = 23 }, new Move { Name = "Sucker Punch", At = 28 }, new Move { Name = "Spider Web", At = 32 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Pin Missile", At = 41 }, new Move { Name = "Psychic", At = 46 }, new Move { Name = "Poison Jab", At = 50 }, new Move { Name = "Cross Poison", At = 55 }, new Move { Name = "Sticky Web", At = 58 }, },
                    eggMoves = { "Psybeam", "Disable", "Sonic Boom", "Baton Pass", "Pursuit", "Signal Beam", "Toxic Spikes", "Twineedle", "Electroweb", "Rage Powder", "Night Slash", "Megahorn", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Crobat",
                    moves = { new Move { Name = "Cross Poison", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Wing Attack", At = 13 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Air Cutter", At = 19 }, new Move { Name = "Swift", At = 24 }, new Move { Name = "Poison Fang", At = 27 }, new Move { Name = "Mean Look", At = 32 }, new Move { Name = "Acrobatics", At = 35 }, new Move { Name = "Haze", At = 40 }, new Move { Name = "Venoshock", At = 43 }, new Move { Name = "Air Slash", At = 48 }, new Move { Name = "Quick Guard", At = 51 }, },
                },

                new Species() {
                    Name = "Chinchou",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Thunder Wave", At = 6 }, new Move { Name = "Electro Ball", At = 9 }, new Move { Name = "Water Gun", At = 12 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Bubble Beam", At = 20 }, new Move { Name = "Spark", At = 23 }, new Move { Name = "Signal Beam", At = 28 }, new Move { Name = "Flail", At = 31 }, new Move { Name = "Discharge", At = 34 }, new Move { Name = "Take Down", At = 39 }, new Move { Name = "Aqua Ring", At = 42 }, new Move { Name = "Hydro Pump", At = 45 }, new Move { Name = "Ion Deluge", At = 47 }, new Move { Name = "Charge", At = 50 }, },
                    eggMoves = { "Flail", "Screech", "Amnesia", "Psybeam", "Whirlpool", "Agility", "Mist", "Shock Wave", "Brine", "Water Pulse", "Soak", },
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Lanturn",
                    moves = { new Move { Name = "Eerie Impulse", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Electro Ball", At = 1 }, new Move { Name = "Thunder Wave", At = 6 }, new Move { Name = "Electro Ball", At = 9 }, new Move { Name = "Water Gun", At = 12 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Bubble Beam", At = 20 }, new Move { Name = "Spark", At = 23 }, new Move { Name = "Stockpile", At = 27 }, new Move { Name = "Swallow", At = 27 }, new Move { Name = "Spit Up", At = 27 }, new Move { Name = "Signal Beam", At = 29 }, new Move { Name = "Flail", At = 33 }, new Move { Name = "Discharge", At = 37 }, new Move { Name = "Take Down", At = 43 }, new Move { Name = "Aqua Ring", At = 47 }, new Move { Name = "Hydro Pump", At = 51 }, new Move { Name = "Ion Deluge", At = 54 }, new Move { Name = "Charge", At = 58 }, },
                    eggMoves = { "Flail", "Screech", "Amnesia", "Psybeam", "Whirlpool", "Agility", "Mist", "Shock Wave", "Brine", "Water Pulse", "Soak", },
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Pichu",
                    moves = { new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Sweet Kiss", At = 10 }, new Move { Name = "Nasty Plot", At = 13 }, new Move { Name = "Thunder Wave", At = 18 }, },
                    eggMoves = { "Reversal", "Bide", "Present", "Encore", "Double Slap", "Wish", "Charge", "Fake Out", "Thunder Punch", "Tickle", "Flail", "Endure", "Lucky Chant", "Bestow", "Disarming Voice", },
                },

                new Species() {
                    Name = "Cleffa",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Encore", At = 4 }, new Move { Name = "Sing", At = 7 }, new Move { Name = "Sweet Kiss", At = 10 }, new Move { Name = "Copycat", At = 13 }, new Move { Name = "Magical Leaf", At = 16 }, },
                    eggMoves = { "Present", "Metronome", "Amnesia", "Belly Drum", "Splash", "Mimic", "Wish", "Fake Tears", "Covet", "Aromatherapy", "Stored Power", "Tickle", "Misty Terrain", "Heal Pulse", },
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Igglybuff",
                    moves = { new Move { Name = "Sing", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Defense Curl", At = 3 }, new Move { Name = "Pound", At = 5 }, new Move { Name = "Sweet Kiss", At = 9 }, new Move { Name = "Copycat", At = 11 }, },
                    eggMoves = { "Perish Song", "Present", "Feint Attack", "Wish", "Fake Tears", "Last Resort", "Covet", "Gravity", "Sleep Talk", "Captivate", "Punishment", "Misty Terrain", "Heal Pulse", },
                },

                new Species() {
                    Name = "Togepi",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Metronome", At = 5 }, new Move { Name = "Sweet Kiss", At = 9 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Encore", At = 17 }, new Move { Name = "Follow Me", At = 21 }, new Move { Name = "Bestow", At = 25 }, new Move { Name = "Wish", At = 29 }, new Move { Name = "Ancient Power", At = 33 }, new Move { Name = "Safeguard", At = 37 }, new Move { Name = "Baton Pass", At = 41 }, new Move { Name = "Double-Edge", At = 45 }, new Move { Name = "Last Resort", At = 49 }, new Move { Name = "After You", At = 53 }, },
                    eggMoves = { "Present", "Mirror Move", "Peck", "Foresight", "Future Sight", "Nasty Plot", "Psycho Shift", "Lucky Chant", "Extrasensory", "Secret Power", "Stored Power", "Morning Sun", },
                    FS = true,
                },

                new Species() {
                    Name = "Togetic",
                    moves = { new Move { Name = "Magical Leaf", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Metronome", At = 1 }, new Move { Name = "Sweet Kiss", At = 1 }, new Move { Name = "Metronome", At = 5 }, new Move { Name = "Sweet Kiss", At = 9 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Fairy Wind", At = 14 }, new Move { Name = "Encore", At = 17 }, new Move { Name = "Follow Me", At = 21 }, new Move { Name = "Bestow", At = 25 }, new Move { Name = "Wish", At = 29 }, new Move { Name = "Ancient Power", At = 33 }, new Move { Name = "Safeguard", At = 37 }, new Move { Name = "Baton Pass", At = 41 }, new Move { Name = "Double-Edge", At = 45 }, new Move { Name = "Last Resort", At = 49 }, new Move { Name = "After You", At = 53 }, },
                },

                new Species() {
                    Name = "Natu",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Night Shade", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Lucky Chant", At = 12 }, new Move { Name = "Stored Power", At = 17 }, new Move { Name = "Ominous Wind", At = 20 }, new Move { Name = "Confuse Ray", At = 23 }, new Move { Name = "Wish", At = 28 }, new Move { Name = "Psychic", At = 33 }, new Move { Name = "Miracle Eye", At = 36 }, new Move { Name = "Psycho Shift", At = 39 }, new Move { Name = "Future Sight", At = 44 }, new Move { Name = "Power Swap", At = 47 }, new Move { Name = "Guard Swap", At = 47 }, new Move { Name = "Me First", At = 50 }, },
                    eggMoves = { "Haze", "Drill Peck", "Quick Attack", "Feint Attack", "Steel Wing", "Feather Dance", "Refresh", "Zen Headbutt", "Sucker Punch", "Synchronoise", "Roost", "Skill Swap", "Simple Beam", "Ally Switch", },
                },

                new Species() {
                    Name = "Xatu",
                    moves = { new Move { Name = "Tailwind", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Teleport", At = 1 }, new Move { Name = "Night Shade", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Lucky Chant", At = 12 }, new Move { Name = "Stored Power", At = 17 }, new Move { Name = "Ominous Wind", At = 20 }, new Move { Name = "Confuse Ray", At = 23 }, new Move { Name = "Air Slash", At = 25 }, new Move { Name = "Wish", At = 29 }, new Move { Name = "Psychic", At = 35 }, new Move { Name = "Miracle Eye", At = 39 }, new Move { Name = "Psycho Shift", At = 43 }, new Move { Name = "Future Sight", At = 49 }, new Move { Name = "Power Swap", At = 53 }, new Move { Name = "Guard Swap", At = 53 }, new Move { Name = "Me First", At = 57 }, },
                    eggMoves = { "Haze", "Drill Peck", "Quick Attack", "Feint Attack", "Steel Wing", "Feather Dance", "Refresh", "Zen Headbutt", "Sucker Punch", "Synchronoise", "Roost", "Skill Swap", "Simple Beam", "Ally Switch", },
                    FS = true,
                },

                new Species() {
                    Name = "Mareep",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Thunder Wave", At = 4 }, new Move { Name = "Thunder Shock", At = 8 }, new Move { Name = "Cotton Spore", At = 11 }, new Move { Name = "Charge", At = 15 }, new Move { Name = "Take Down", At = 18 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Confuse Ray", At = 25 }, new Move { Name = "Power Gem", At = 29 }, new Move { Name = "Discharge", At = 32 }, new Move { Name = "Cotton Guard", At = 36 }, new Move { Name = "Signal Beam", At = 39 }, new Move { Name = "Light Screen", At = 43 }, new Move { Name = "Thunder", At = 46 }, },
                    eggMoves = { "Take Down", "Body Slam", "Screech", "Odor Sleuth", "Charge", "Flatter", "Sand Attack", "Iron Tail", "After You", "Agility", "Eerie Impulse", "Electric Terrain", },
                },

                new Species() {
                    Name = "Flaaffy",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Thunder Wave", At = 4 }, new Move { Name = "Thunder Shock", At = 8 }, new Move { Name = "Cotton Spore", At = 11 }, new Move { Name = "Charge", At = 16 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Electro Ball", At = 25 }, new Move { Name = "Confuse Ray", At = 29 }, new Move { Name = "Power Gem", At = 34 }, new Move { Name = "Discharge", At = 38 }, new Move { Name = "Cotton Guard", At = 43 }, new Move { Name = "Signal Beam", At = 47 }, new Move { Name = "Light Screen", At = 52 }, new Move { Name = "Thunder", At = 56 }, },
                },

                new Species() {
                    Name = "Ampharos",
                    moves = { new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Magnetic Flux", At = 1 }, new Move { Name = "Ion Deluge", At = 1 }, new Move { Name = "Dragon Pulse", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Thunder Wave", At = 4 }, new Move { Name = "Thunder Shock", At = 8 }, new Move { Name = "Cotton Spore", At = 11 }, new Move { Name = "Charge", At = 16 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Electro Ball", At = 25 }, new Move { Name = "Confuse Ray", At = 29 }, new Move { Name = "Thunder Punch", At = 30 }, new Move { Name = "Power Gem", At = 35 }, new Move { Name = "Discharge", At = 40 }, new Move { Name = "Cotton Guard", At = 46 }, new Move { Name = "Signal Beam", At = 51 }, new Move { Name = "Light Screen", At = 57 }, new Move { Name = "Thunder", At = 62 }, new Move { Name = "Dragon Pulse", At = 65 }, },
                },

                new Species() {
                    Name = "Bellossom",
                    moves = { new Move { Name = "Leaf Storm", At = 1 }, new Move { Name = "Leaf Blade", At = 1 }, new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Stun Spore", At = 1 }, new Move { Name = "Sunny Day", At = 1 }, new Move { Name = "Magical Leaf", At = 24 }, new Move { Name = "Petal Blizzard", At = 49 }, new Move { Name = "Leaf Storm", At = 64 }, },
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Marill",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 2 }, new Move { Name = "Water Sport", At = 5 }, new Move { Name = "Bubble", At = 7 }, new Move { Name = "Defense Curl", At = 10 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Helping Hand", At = 16 }, new Move { Name = "Aqua Tail", At = 20 }, new Move { Name = "Play Rough", At = 23 }, new Move { Name = "Aqua Ring", At = 28 }, new Move { Name = "Rain Dance", At = 31 }, new Move { Name = "Double-Edge", At = 37 }, new Move { Name = "Superpower", At = 40 }, new Move { Name = "Hydro Pump", At = 47 }, },
                  //eggMoves = { "Present", "Amnesia", "Future Sight", "Belly Drum", "Perish Song", "Supersonic", "Aqua Jet", "Superpower", "Refresh", "Body Slam", "Water Sport", "Muddy Water", "Camouflage", },
                    eggMoves = { "Encore", "Sing", "Refresh", "Slam", "Tickle", "Fake Tears", "Body Slam", "Water Sport", "Soak", "Muddy Water", "Copycat", "Camouflage", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Azumarill",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Tail Whip", At = 2 }, new Move { Name = "Water Sport", At = 5 }, new Move { Name = "Bubble", At = 7 }, new Move { Name = "Defense Curl", At = 10 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Helping Hand", At = 16 }, new Move { Name = "Aqua Tail", At = 21 }, new Move { Name = "Play Rough", At = 25 }, new Move { Name = "Aqua Ring", At = 31 }, new Move { Name = "Rain Dance", At = 35 }, new Move { Name = "Double-Edge", At = 42 }, new Move { Name = "Superpower", At = 46 }, new Move { Name = "Hydro Pump", At = 55 }, },
                  //eggMoves = { "Present", "Amnesia", "Future Sight", "Belly Drum", "Perish Song", "Supersonic", "Aqua Jet", "Superpower", "Refresh", "Body Slam", "Water Sport", "Muddy Water", "Camouflage", },
                    eggMoves = { "Encore", "Sing", "Refresh", "Slam", "Tickle", "Fake Tears", "Body Slam", "Water Sport", "Soak", "Muddy Water", "Copycat", "Camouflage", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Sudowoodo",
                    moves = { new Move { Name = "Wood Hammer", At = 1 }, new Move { Name = "Copycat", At = 1 }, new Move { Name = "Flail", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Flail", At = 5 }, new Move { Name = "Low Kick", At = 8 }, new Move { Name = "Rock Throw", At = 12 }, new Move { Name = "Mimic", At = 15 }, new Move { Name = "Slam", At = 15 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Rock Tomb", At = 22 }, new Move { Name = "Block", At = 26 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Counter", At = 33 }, new Move { Name = "Sucker Punch", At = 36 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Stone Edge", At = 43 }, new Move { Name = "Hammer Arm", At = 47 }, },
                    eggMoves = { "Self-Destruct", "Headbutt", "Harden", "Defense Curl", "Rollout", "Sand Tomb", "Stealth Rock", "Curse", "Endure", },
                },

                new Species() {
                    Name = "Politoed",
                    moves = { new Move { Name = "Bubble Beam", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Double Slap", At = 1 }, new Move { Name = "Perish Song", At = 1 }, new Move { Name = "Swagger", At = 27 }, new Move { Name = "Bounce", At = 37 }, new Move { Name = "Hyper Voice", At = 48 }, },
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Hoppip",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Synthesis", At = 4 }, new Move { Name = "Tail Whip", At = 6 }, new Move { Name = "Tackle", At = 8 }, new Move { Name = "Fairy Wind", At = 10 }, new Move { Name = "Poison Powder", At = 12 }, new Move { Name = "Stun Spore", At = 14 }, new Move { Name = "Sleep Powder", At = 16 }, new Move { Name = "Bullet Seed", At = 19 }, new Move { Name = "Leech Seed", At = 22 }, new Move { Name = "Mega Drain", At = 25 }, new Move { Name = "Acrobatics", At = 28 }, new Move { Name = "Rage Powder", At = 31 }, new Move { Name = "Cotton Spore", At = 34 }, new Move { Name = "U-turn", At = 37 }, new Move { Name = "Worry Seed", At = 40 }, new Move { Name = "Giga Drain", At = 43 }, new Move { Name = "Bounce", At = 46 }, new Move { Name = "Memento", At = 49 }, },
                    eggMoves = { "Confusion", "Encore", "Double-Edge", "Amnesia", "Helping Hand", "Aromatherapy", "Worry Seed", "Cotton Guard", "Seed Bomb", "Endure", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Skiploom",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Synthesis", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Synthesis", At = 4 }, new Move { Name = "Tail Whip", At = 6 }, new Move { Name = "Tackle", At = 8 }, new Move { Name = "Fairy Wind", At = 10 }, new Move { Name = "Poison Powder", At = 12 }, new Move { Name = "Stun Spore", At = 14 }, new Move { Name = "Sleep Powder", At = 16 }, new Move { Name = "Bullet Seed", At = 20 }, new Move { Name = "Leech Seed", At = 24 }, new Move { Name = "Mega Drain", At = 28 }, new Move { Name = "Acrobatics", At = 32 }, new Move { Name = "Rage Powder", At = 36 }, new Move { Name = "Cotton Spore", At = 40 }, new Move { Name = "U-turn", At = 44 }, new Move { Name = "Worry Seed", At = 48 }, new Move { Name = "Giga Drain", At = 52 }, new Move { Name = "Bounce", At = 56 }, new Move { Name = "Memento", At = 60 }, },
                },

                new Species() {
                    Name = "Jumpluff",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Synthesis", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Synthesis", At = 4 }, new Move { Name = "Tail Whip", At = 6 }, new Move { Name = "Tackle", At = 8 }, new Move { Name = "Fairy Wind", At = 10 }, new Move { Name = "Poison Powder", At = 12 }, new Move { Name = "Stun Spore", At = 14 }, new Move { Name = "Sleep Powder", At = 16 }, new Move { Name = "Bullet Seed", At = 20 }, new Move { Name = "Leech Seed", At = 24 }, new Move { Name = "Mega Drain", At = 29 }, new Move { Name = "Acrobatics", At = 34 }, new Move { Name = "Rage Powder", At = 39 }, new Move { Name = "Cotton Spore", At = 44 }, new Move { Name = "U-turn", At = 49 }, new Move { Name = "Worry Seed", At = 54 }, new Move { Name = "Giga Drain", At = 59 }, new Move { Name = "Bounce", At = 64 }, new Move { Name = "Memento", At = 69 }, },
                },

                new Species() {
                    Name = "Aipom",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Baton Pass", At = 11 }, new Move { Name = "Tickle", At = 15 }, new Move { Name = "Fury Swipes", At = 18 }, new Move { Name = "Swift", At = 22 }, new Move { Name = "Screech", At = 25 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Double Hit", At = 32 }, new Move { Name = "Fling", At = 36 }, new Move { Name = "Nasty Plot", At = 39 }, new Move { Name = "Last Resort", At = 43 }, },
                    eggMoves = { "Counter", "Screech", "Pursuit", "Agility", "Spite", "Slam", "Double Slap", "Beat Up", "Fake Out", "Covet", "Bounce", "Revenge", "Switcheroo", "Quick Guard", },
                    FS = true,
                },

                new Species() {
                    Name = "Sunkern",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Ingrain", At = 4 }, new Move { Name = "Grass Whistle", At = 7 }, new Move { Name = "Mega Drain", At = 10 }, new Move { Name = "Leech Seed", At = 13 }, new Move { Name = "Razor Leaf", At = 16 }, new Move { Name = "Worry Seed", At = 19 }, new Move { Name = "Giga Drain", At = 22 }, new Move { Name = "Endeavor", At = 25 }, new Move { Name = "Synthesis", At = 28 }, new Move { Name = "Natural Gift", At = 31 }, new Move { Name = "Solar Beam", At = 34 }, new Move { Name = "Double-Edge", At = 37 }, new Move { Name = "Sunny Day", At = 40 }, new Move { Name = "Seed Bomb", At = 43 }, },
                    eggMoves = { "Grass Whistle", "Encore", "Leech Seed", "Nature Power", "Curse", "Helping Hand", "Ingrain", "Sweet Scent", "Endure", "Bide", "Natural Gift", "Morning Sun", "Grassy Terrain", },
                    FS = true,
                },

                new Species() {
                    Name = "Sunflora",
                    moves = { new Move { Name = "Flower Shield", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Ingrain", At = 4 }, new Move { Name = "Grass Whistle", At = 7 }, new Move { Name = "Mega Drain", At = 10 }, new Move { Name = "Leech Seed", At = 13 }, new Move { Name = "Razor Leaf", At = 16 }, new Move { Name = "Worry Seed", At = 19 }, new Move { Name = "Giga Drain", At = 22 }, new Move { Name = "Bullet Seed", At = 25 }, new Move { Name = "Petal Dance", At = 28 }, new Move { Name = "Natural Gift", At = 31 }, new Move { Name = "Solar Beam", At = 34 }, new Move { Name = "Double-Edge", At = 37 }, new Move { Name = "Sunny Day", At = 40 }, new Move { Name = "Leaf Storm", At = 43 }, new Move { Name = "Petal Blizzard", At = 50 }, },
                },

                new Species() {
                    Name = "Yanma",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Double Team", At = 11 }, new Move { Name = "Sonic Boom", At = 14 }, new Move { Name = "Detect", At = 17 }, new Move { Name = "Supersonic", At = 22 }, new Move { Name = "Uproar", At = 27 }, new Move { Name = "Pursuit", At = 30 }, new Move { Name = "Ancient Power", At = 33 }, new Move { Name = "Hypnosis", At = 38 }, new Move { Name = "Wing Attack", At = 43 }, new Move { Name = "Screech", At = 46 }, new Move { Name = "U-turn", At = 49 }, new Move { Name = "Air Slash", At = 54 }, new Move { Name = "Bug Buzz", At = 57 }, },
                    eggMoves = { "Whirlwind", "Reversal", "Leech Life", "Signal Beam", "Silver Wind", "Feint", "Feint Attack", "Pursuit", "Double-Edge", "Secret Power", },
                    item5 = "Wide Lens",
                },

                new Species() {
                    Name = "Wooper",
                    moves = { new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Mud Sport", At = 5 }, new Move { Name = "Mud Shot", At = 9 }, new Move { Name = "Slam", At = 15 }, new Move { Name = "Mud Bomb", At = 19 }, new Move { Name = "Amnesia", At = 23 }, new Move { Name = "Yawn", At = 29 }, new Move { Name = "Earthquake", At = 33 }, new Move { Name = "Rain Dance", At = 37 }, new Move { Name = "Mist", At = 43 }, new Move { Name = "Haze", At = 43 }, new Move { Name = "Muddy Water", At = 47 }, },
                    eggMoves = { "Body Slam", "Ancient Power", "Curse", "Mud Sport", "Stockpile", "Swallow", "Spit Up", "Counter", "Encore", "Double Kick", "Recover", "After You", "Sleep Talk", "Acid Spray", "Guard Swap", "Eerie Impulse", },
                    FS = true,
                },

                new Species() {
                    Name = "Quagsire",
                    moves = { new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Mud Sport", At = 5 }, new Move { Name = "Mud Shot", At = 9 }, new Move { Name = "Slam", At = 15 }, new Move { Name = "Mud Bomb", At = 19 }, new Move { Name = "Amnesia", At = 24 }, new Move { Name = "Yawn", At = 31 }, new Move { Name = "Earthquake", At = 36 }, new Move { Name = "Rain Dance", At = 41 }, new Move { Name = "Mist", At = 48 }, new Move { Name = "Haze", At = 48 }, new Move { Name = "Muddy Water", At = 53 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Espeon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Confusion", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Swift", At = 17 }, new Move { Name = "Psybeam", At = 20 }, new Move { Name = "Future Sight", At = 25 }, new Move { Name = "Psych Up", At = 29 }, new Move { Name = "Morning Sun", At = 33 }, new Move { Name = "Psychic", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Power Swap", At = 45 }, },
                },

                new Species() {
                    Name = "Umbreon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Pursuit", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Confuse Ray", At = 17 }, new Move { Name = "Feint Attack", At = 20 }, new Move { Name = "Assurance", At = 25 }, new Move { Name = "Screech", At = 29 }, new Move { Name = "Moonlight", At = 33 }, new Move { Name = "Mean Look", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Guard Swap", At = 45 }, },
                },

                new Species() {
                    Name = "Murkrow",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Pursuit", At = 5 }, new Move { Name = "Haze", At = 11 }, new Move { Name = "Wing Attack", At = 15 }, new Move { Name = "Night Shade", At = 21 }, new Move { Name = "Assurance", At = 25 }, new Move { Name = "Taunt", At = 31 }, new Move { Name = "Feint Attack", At = 35 }, new Move { Name = "Mean Look", At = 41 }, new Move { Name = "Foul Play", At = 45 }, new Move { Name = "Tailwind", At = 50 }, new Move { Name = "Sucker Punch", At = 55 }, new Move { Name = "Torment", At = 61 }, new Move { Name = "Quash", At = 65 }, },
                    eggMoves = { "Whirlwind", "Drill Peck", "Mirror Move", "Wing Attack", "Sky Attack", "Confuse Ray", "Feather Dance", "Perish Song", "Psycho Shift", "Screech", "Feint Attack", "Brave Bird", "Roost", "Assurance", "Flatter", },
                },

                new Species() {
                    Name = "Slowking",
                    moves = { new Move { Name = "Heal Pulse", At = 1 }, new Move { Name = "Power Gem", At = 1 }, new Move { Name = "Hidden Power", At = 1 }, new Move { Name = "Curse", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Confusion", At = 14 }, new Move { Name = "Disable", At = 19 }, new Move { Name = "Headbutt", At = 23 }, new Move { Name = "Water Pulse", At = 28 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Nasty Plot", At = 36 }, new Move { Name = "Swagger", At = 41 }, new Move { Name = "Psychic", At = 45 }, new Move { Name = "Trump Card", At = 49 }, new Move { Name = "Psych Up", At = 54 }, new Move { Name = "Heal Pulse", At = 58 }, },
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Misdreavus",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Psywave", At = 1 }, new Move { Name = "Spite", At = 5 }, new Move { Name = "Astonish", At = 10 }, new Move { Name = "Confuse Ray", At = 14 }, new Move { Name = "Mean Look", At = 19 }, new Move { Name = "Hex", At = 23 }, new Move { Name = "Psybeam", At = 28 }, new Move { Name = "Pain Split", At = 32 }, new Move { Name = "Payback", At = 37 }, new Move { Name = "Shadow Ball", At = 41 }, new Move { Name = "Perish Song", At = 46 }, new Move { Name = "Grudge", At = 50 }, new Move { Name = "Power Gem", At = 55 }, },
                    eggMoves = { "Screech", "Destiny Bond", "Imprison", "Memento", "Sucker Punch", "Shadow Sneak", "Curse", "Spite", "Ominous Wind", "Nasty Plot", "Skill Swap", "Wonder Room", "Me First", },
                },

                new Species() {
                    Name = "Unown",
                    moves = { new Move { Name = "Hidden Power", At = 1 }, },
                },

                new Species() {
                    Name = "Wobbuffet",
                    moves = { new Move { Name = "Counter", At = 1 }, new Move { Name = "Mirror Coat", At = 1 }, new Move { Name = "Safeguard", At = 1 }, new Move { Name = "Destiny Bond", At = 1 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Girafarig",
                    moves = { new Move { Name = "Power Swap", At = 1 }, new Move { Name = "Guard Swap", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Odor Sleuth", At = 5 }, new Move { Name = "Assurance", At = 10 }, new Move { Name = "Stomp", At = 14 }, new Move { Name = "Psybeam", At = 19 }, new Move { Name = "Agility", At = 23 }, new Move { Name = "Double Hit", At = 28 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Baton Pass", At = 41 }, new Move { Name = "Nasty Plot", At = 46 }, new Move { Name = "Psychic", At = 50 }, },
                    eggMoves = { "Take Down", "Amnesia", "Foresight", "Future Sight", "Beat Up", "Wish", "Magic Coat", "Double Kick", "Mirror Coat", "Razor Wind", "Skill Swap", "Secret Power", "Mean Look", },
                    FS = true,
                },

                new Species() {
                    Name = "Pineco",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Self-Destruct", At = 6 }, new Move { Name = "Bug Bite", At = 9 }, new Move { Name = "Take Down", At = 12 }, new Move { Name = "Rapid Spin", At = 17 }, new Move { Name = "Bide", At = 20 }, new Move { Name = "Natural Gift", At = 23 }, new Move { Name = "Spikes", At = 28 }, new Move { Name = "Payback", At = 31 }, new Move { Name = "Explosion", At = 34 }, new Move { Name = "Iron Defense", At = 39 }, new Move { Name = "Gyro Ball", At = 42 }, new Move { Name = "Double-Edge", At = 45 }, },
                    eggMoves = { "Pin Missile", "Flail", "Swift", "Counter", "Sand Tomb", "Revenge", "Double-Edge", "Toxic Spikes", "Power Trick", "Endure", "Stealth Rock", },
                },

                new Species() {
                    Name = "Forretress",
                    moves = { new Move { Name = "Heavy Slam", At = 1 }, new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Magnet Rise", At = 1 }, new Move { Name = "Toxic Spikes", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Self-Destruct", At = 1 }, new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Take Down", At = 12 }, new Move { Name = "Rapid Spin", At = 17 }, new Move { Name = "Bide", At = 20 }, new Move { Name = "Natural Gift", At = 23 }, new Move { Name = "Spikes", At = 28 }, new Move { Name = "Mirror Shot", At = 31 }, new Move { Name = "Autotomize", At = 32 }, new Move { Name = "Payback", At = 36 }, new Move { Name = "Explosion", At = 42 }, new Move { Name = "Iron Defense", At = 46 }, new Move { Name = "Gyro Ball", At = 50 }, new Move { Name = "Double-Edge", At = 56 }, new Move { Name = "Magnet Rise", At = 60 }, new Move { Name = "Zap Cannon", At = 64 }, new Move { Name = "Heavy Slam", At = 70 }, },
                    eggMoves = { "Pin Missile", "Flail", "Swift", "Counter", "Sand Tomb", "Revenge", "Double-Edge", "Toxic Spikes", "Power Trick", "Endure", "Stealth Rock", },
                    FS = true,
                },

                new Species() {
                    Name = "Dunsparce",
                    moves = { new Move { Name = "Rage", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Rollout", At = 4 }, new Move { Name = "Spite", At = 7 }, new Move { Name = "Pursuit", At = 10 }, new Move { Name = "Screech", At = 13 }, new Move { Name = "Yawn", At = 16 }, new Move { Name = "Ancient Power", At = 19 }, new Move { Name = "Take Down", At = 22 }, new Move { Name = "Roost", At = 25 }, new Move { Name = "Glare", At = 28 }, new Move { Name = "Dig", At = 31 }, new Move { Name = "Double-Edge", At = 34 }, new Move { Name = "Coil", At = 37 }, new Move { Name = "Endure", At = 40 }, new Move { Name = "Drill Run", At = 43 }, new Move { Name = "Endeavor", At = 46 }, new Move { Name = "Flail", At = 49 }, },
                    eggMoves = { "Bide", "Ancient Power", "Bite", "Headbutt", "Astonish", "Curse", "Trump Card", "Magic Coat", "Snore", "Agility", "Secret Power", "Sleep Talk", "Hex", },
                    FS = true,
                },

                new Species() {
                    Name = "Gligar",
                    moves = { new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Harden", At = 7 }, new Move { Name = "Knock Off", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Fury Cutter", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Acrobatics", At = 22 }, new Move { Name = "Slash", At = 27 }, new Move { Name = "U-turn", At = 30 }, new Move { Name = "Screech", At = 35 }, new Move { Name = "X-Scissor", At = 40 }, new Move { Name = "Sky Uppercut", At = 45 }, new Move { Name = "Swords Dance", At = 50 }, new Move { Name = "Guillotine", At = 55 }, },
                    eggMoves = { "Metal Claw", "Wing Attack", "Razor Wind", "Counter", "Sand Tomb", "Agility", "Baton Pass", "Double-Edge", "Feint", "Night Slash", "Cross Poison", "Power Trick", "Rock Climb", "Poison Tail", },
                },

                new Species() {
                    Name = "Steelix",
                    moves = { new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Bind", At = 1 }, new Move { Name = "Curse", At = 4 }, new Move { Name = "Rock Throw", At = 7 }, new Move { Name = "Rock Tomb", At = 10 }, new Move { Name = "Rage", At = 13 }, new Move { Name = "Stealth Rock", At = 16 }, new Move { Name = "Autotomize", At = 19 }, new Move { Name = "Gyro Ball", At = 20 }, new Move { Name = "Smack Down", At = 22 }, new Move { Name = "Dragon Breath", At = 25 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Screech", At = 31 }, new Move { Name = "Rock Slide", At = 34 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Iron Tail", At = 40 }, new Move { Name = "Dig", At = 43 }, new Move { Name = "Stone Edge", At = 46 }, new Move { Name = "Double-Edge", At = 49 }, new Move { Name = "Sandstorm", At = 52 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Snubbull",
                    moves = { new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Lick", At = 13 }, new Move { Name = "Headbutt", At = 19 }, new Move { Name = "Roar", At = 25 }, new Move { Name = "Rage", At = 31 }, new Move { Name = "Play Rough", At = 37 }, new Move { Name = "Payback", At = 43 }, new Move { Name = "Crunch", At = 49 }, },
                    eggMoves = { "Metronome", "Feint Attack", "Present", "Crunch", "Heal Bell", "Snore", "Smelling Salts", "Close Combat", "Ice Fang", "Fire Fang", "Thunder Fang", "Focus Punch", "Double-Edge", "Mimic", "Fake Tears", },
                    FS = true,
                },

                new Species() {
                    Name = "Granbull",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Lick", At = 13 }, new Move { Name = "Headbutt", At = 19 }, new Move { Name = "Roar", At = 27 }, new Move { Name = "Rage", At = 35 }, new Move { Name = "Play Rough", At = 43 }, new Move { Name = "Payback", At = 51 }, new Move { Name = "Crunch", At = 59 }, new Move { Name = "Outrage", At = 67 }, },
                },

                new Species() {
                    Name = "Qwilfish",
                    moves = { new Move { Name = "Fell Stinger", At = 1 }, new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Destiny Bond", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Spikes", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Harden", At = 9 }, new Move { Name = "Minimize", At = 9 }, new Move { Name = "Bubble", At = 13 }, new Move { Name = "Rollout", At = 17 }, new Move { Name = "Toxic Spikes", At = 21 }, new Move { Name = "Stockpile", At = 25 }, new Move { Name = "Spit Up", At = 25 }, new Move { Name = "Revenge", At = 29 }, new Move { Name = "Brine", At = 33 }, new Move { Name = "Pin Missile", At = 37 }, new Move { Name = "Take Down", At = 41 }, new Move { Name = "Aqua Tail", At = 45 }, new Move { Name = "Poison Jab", At = 49 }, new Move { Name = "Destiny Bond", At = 53 }, new Move { Name = "Hydro Pump", At = 57 }, new Move { Name = "Fell Stinger", At = 60 }, },
                    eggMoves = { "Flail", "Haze", "Bubble Beam", "Supersonic", "Astonish", "Signal Beam", "Aqua Jet", "Water Pulse", "Brine", "Acid Spray", },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Scizor",
                    moves = { new Move { Name = "Feint", At = 1 }, new Move { Name = "Bullet Punch", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 5 }, new Move { Name = "Pursuit", At = 9 }, new Move { Name = "False Swipe", At = 13 }, new Move { Name = "Agility", At = 17 }, new Move { Name = "Metal Claw", At = 21 }, new Move { Name = "Fury Cutter", At = 25 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Razor Wind", At = 33 }, new Move { Name = "Iron Defense", At = 37 }, new Move { Name = "X-Scissor", At = 41 }, new Move { Name = "Night Slash", At = 45 }, new Move { Name = "Double Hit", At = 49 }, new Move { Name = "Iron Head", At = 50 }, new Move { Name = "Swords Dance", At = 57 }, new Move { Name = "Feint", At = 61 }, },
                },

                new Species() {
                    Name = "Shuckle",
                    moves = { new Move { Name = "Sticky Web", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Encore", At = 5 }, new Move { Name = "Wrap", At = 9 }, new Move { Name = "Struggle Bug", At = 12 }, new Move { Name = "Safeguard", At = 16 }, new Move { Name = "Rest", At = 20 }, new Move { Name = "Rock Throw", At = 23 }, new Move { Name = "Gastro Acid", At = 27 }, new Move { Name = "Power Trick", At = 31 }, new Move { Name = "Shell Smash", At = 34 }, new Move { Name = "Rock Slide", At = 38 }, new Move { Name = "Bug Bite", At = 42 }, new Move { Name = "Power Split", At = 45 }, new Move { Name = "Guard Split", At = 45 }, new Move { Name = "Stone Edge", At = 49 }, new Move { Name = "Sticky Web", At = 53 }, },
                    eggMoves = { "Sweet Scent", "Knock Off", "Helping Hand", "Acupressure", "Sand Tomb", "Mud-Slap", "Acid", "Rock Blast", "Final Gambit", },
                    FS = true,
                    item100 = "Berry Juice",
                },

                new Species() {
                    Name = "Heracross",
                    moves = { new Move { Name = "Arm Thrust", At = 1 }, new Move { Name = "Bullet Seed", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Horn Attack", At = 1 }, new Move { Name = "Endure", At = 1 }, new Move { Name = "Feint", At = 7 }, new Move { Name = "Aerial Ace", At = 10 }, new Move { Name = "Chip Away", At = 16 }, new Move { Name = "Counter", At = 19 }, new Move { Name = "Fury Attack", At = 25 }, new Move { Name = "Brick Break", At = 28 }, new Move { Name = "Pin Missile", At = 31 }, new Move { Name = "Take Down", At = 34 }, new Move { Name = "Megahorn", At = 37 }, new Move { Name = "Close Combat", At = 43 }, new Move { Name = "Reversal", At = 46 }, },
                    eggMoves = { "Harden", "Bide", "Flail", "Revenge", "Pursuit", "Double-Edge", "Seismic Toss", "Focus Punch", "Megahorn", "Rock Blast", },
                    FS = true,
                },

                new Species() {
                    Name = "Sneasel",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Quick Attack", At = 8 }, new Move { Name = "Feint Attack", At = 10 }, new Move { Name = "Icy Wind", At = 14 }, new Move { Name = "Fury Swipes", At = 16 }, new Move { Name = "Agility", At = 20 }, new Move { Name = "Metal Claw", At = 22 }, new Move { Name = "Hone Claws", At = 25 }, new Move { Name = "Beat Up", At = 28 }, new Move { Name = "Screech", At = 32 }, new Move { Name = "Slash", At = 35 }, new Move { Name = "Snatch", At = 40 }, new Move { Name = "Punishment", At = 44 }, new Move { Name = "Ice Shard", At = 47 }, },
                    eggMoves = { "Counter", "Spite", "Foresight", "Bite", "Crush Claw", "Fake Out", "Double Hit", "Punishment", "Pursuit", "Ice Shard", "Ice Punch", "Assist", "Avalanche", "Feint", "Icicle Crash", },
                    FS = true,
                    item5 = "Quick Claw",
                    xy50 = "Grip Claw",
                },

                new Species() {
                    Name = "Teddiursa",
                    moves = { new Move { Name = "Fling", At = 1 }, new Move { Name = "Covet", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Baby-Doll Eyes", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Fake Tears", At = 1 }, new Move { Name = "Fury Swipes", At = 8 }, new Move { Name = "Feint Attack", At = 15 }, new Move { Name = "Sweet Scent", At = 22 }, new Move { Name = "Play Nice", At = 25 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Charm", At = 36 }, new Move { Name = "Rest", At = 43 }, new Move { Name = "Snore", At = 43 }, new Move { Name = "Thrash", At = 50 }, new Move { Name = "Fling", At = 57 }, },
                    eggMoves = { "Crunch", "Take Down", "Seismic Toss", "Counter", "Metal Claw", "Fake Tears", "Yawn", "Sleep Talk", "Cross Chop", "Double-Edge", "Close Combat", "Night Slash", "Belly Drum", "Chip Away", "Play Rough", },
                    FS = true,
                },

                new Species() {
                    Name = "Ursaring",
                    moves = { new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Covet", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Fake Tears", At = 1 }, new Move { Name = "Fury Swipes", At = 8 }, new Move { Name = "Feint Attack", At = 15 }, new Move { Name = "Sweet Scent", At = 22 }, new Move { Name = "Play Nice", At = 25 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Scary Face", At = 38 }, new Move { Name = "Rest", At = 47 }, new Move { Name = "Snore", At = 49 }, new Move { Name = "Thrash", At = 58 }, new Move { Name = "Hammer Arm", At = 67 }, },
                },

                new Species() {
                    Name = "Slugma",
                    moves = { new Move { Name = "Yawn", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Ember", At = 6 }, new Move { Name = "Rock Throw", At = 8 }, new Move { Name = "Harden", At = 13 }, new Move { Name = "Incinerate", At = 15 }, new Move { Name = "Clear Smog", At = 20 }, new Move { Name = "Ancient Power", At = 22 }, new Move { Name = "Flame Burst", At = 27 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Lava Plume", At = 34 }, new Move { Name = "Amnesia", At = 36 }, new Move { Name = "Body Slam", At = 41 }, new Move { Name = "Recover", At = 43 }, new Move { Name = "Flamethrower", At = 48 }, new Move { Name = "Earth Power", At = 50 }, },
                    eggMoves = { "Acid Armor", "Heat Wave", "Curse", "Smokescreen", "Memento", "Stockpile", "Spit Up", "Swallow", "Rollout", "Inferno", "Earth Power", "Guard Swap", },
                    eggRand = 5,
                    FS = true,
                },

                new Species() {
                    Name = "Magcargo",
                    moves = { new Move { Name = "Earth Power", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Ember", At = 6 }, new Move { Name = "Rock Throw", At = 8 }, new Move { Name = "Harden", At = 13 }, new Move { Name = "Incinerate", At = 15 }, new Move { Name = "Clear Smog", At = 20 }, new Move { Name = "Ancient Power", At = 22 }, new Move { Name = "Flame Burst", At = 27 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Lava Plume", At = 34 }, new Move { Name = "Amnesia", At = 36 }, new Move { Name = "Shell Smash", At = 38 }, new Move { Name = "Body Slam", At = 43 }, new Move { Name = "Recover", At = 47 }, new Move { Name = "Flamethrower", At = 54 }, new Move { Name = "Earth Power", At = 58 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Swinub",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Mud Sport", At = 5 }, new Move { Name = "Powder Snow", At = 8 }, new Move { Name = "Mud-Slap", At = 11 }, new Move { Name = "Endure", At = 14 }, new Move { Name = "Mud Bomb", At = 18 }, new Move { Name = "Icy Wind", At = 21 }, new Move { Name = "Ice Shard", At = 24 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Mist", At = 35 }, new Move { Name = "Earthquake", At = 37 }, new Move { Name = "Flail", At = 40 }, new Move { Name = "Blizzard", At = 44 }, new Move { Name = "Amnesia", At = 48 }, },
                    eggMoves = { "Take Down", "Bite", "Body Slam", "Ancient Power", "Mud Shot", "Icicle Spear", "Double-Edge", "Fissure", "Curse", "Mud Shot", "Avalanche", "Stealth Rock", "Icicle Crash", "Freeze-Dry", },
                },

                new Species() {
                    Name = "Piloswine",
                    moves = { new Move { Name = "Ancient Power", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Mud Sport", At = 5 }, new Move { Name = "Powder Snow", At = 8 }, new Move { Name = "Mud-Slap", At = 11 }, new Move { Name = "Endure", At = 14 }, new Move { Name = "Mud Bomb", At = 18 }, new Move { Name = "Icy Wind", At = 21 }, new Move { Name = "Ice Fang", At = 24 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Fury Attack", At = 33 }, new Move { Name = "Mist", At = 37 }, new Move { Name = "Thrash", At = 41 }, new Move { Name = "Earthquake", At = 46 }, new Move { Name = "Blizzard", At = 52 }, new Move { Name = "Amnesia", At = 58 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Corsola",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Bubble", At = 4 }, new Move { Name = "Recover", At = 8 }, new Move { Name = "Bubble Beam", At = 10 }, new Move { Name = "Refresh", At = 13 }, new Move { Name = "Ancient Power", At = 17 }, new Move { Name = "Spike Cannon", At = 20 }, new Move { Name = "Lucky Chant", At = 23 }, new Move { Name = "Brine", At = 27 }, new Move { Name = "Iron Defense", At = 29 }, new Move { Name = "Rock Blast", At = 31 }, new Move { Name = "Endure", At = 35 }, new Move { Name = "Aqua Ring", At = 38 }, new Move { Name = "Power Gem", At = 41 }, new Move { Name = "Mirror Coat", At = 45 }, new Move { Name = "Earth Power", At = 47 }, new Move { Name = "Flail", At = 50 }, },
                    eggMoves = { "Screech", "Mist", "Amnesia", "Barrier", "Ingrain", "Confuse Ray", "Icicle Spear", "Nature Power", "Aqua Ring", "Curse", "Bide", "Water Pulse", "Head Smash", "Camouflage", },
                    FS = true,
                    xy5 = "Hard Stone",
                    oras5 = "Luminous Moss",
                },

                new Species() {
                    Name = "Remoraid",
                    moves = { new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Lock-On", At = 6 }, new Move { Name = "Psybeam", At = 10 }, new Move { Name = "Aurora Beam", At = 14 }, new Move { Name = "Bubble Beam", At = 18 }, new Move { Name = "Focus Energy", At = 22 }, new Move { Name = "Water Pulse", At = 26 }, new Move { Name = "Signal Beam", At = 30 }, new Move { Name = "Ice Beam", At = 34 }, new Move { Name = "Bullet Seed", At = 38 }, new Move { Name = "Hydro Pump", At = 42 }, new Move { Name = "Hyper Beam", At = 46 }, new Move { Name = "Soak", At = 50 }, },
                    eggMoves = { "Aurora Beam", "Octazooka", "Supersonic", "Haze", "Screech", "Rock Blast", "Snore", "Flail", "Water Spout", "Mud Shot", "Swift", "Acid Spray", "Water Pulse", "Entrainment", },
                },

                new Species() {
                    Name = "Octillery",
                    moves = { new Move { Name = "Gunk Shot", At = 1 }, new Move { Name = "Rock Blast", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Psybeam", At = 1 }, new Move { Name = "Aurora Beam", At = 1 }, new Move { Name = "Constrict", At = 6 }, new Move { Name = "Psybeam", At = 10 }, new Move { Name = "Aurora Beam", At = 14 }, new Move { Name = "Bubble Beam", At = 18 }, new Move { Name = "Focus Energy", At = 22 }, new Move { Name = "Octazooka", At = 25 }, new Move { Name = "Wring Out", At = 28 }, new Move { Name = "Signal Beam", At = 34 }, new Move { Name = "Ice Beam", At = 40 }, new Move { Name = "Bullet Seed", At = 46 }, new Move { Name = "Hydro Pump", At = 52 }, new Move { Name = "Hyper Beam", At = 58 }, new Move { Name = "Soak", At = 64 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Delibird",
                    moves = { new Move { Name = "Present", At = 1 }, },
                    eggMoves = { "Aurora Beam", "Quick Attack", "Future Sight", "Splash", "Rapid Spin", "Ice Ball", "Ice Shard", "Ice Punch", "Fake Out", "Bestow", "Icy Wind", "Freeze-Dry", "Destiny Bond", "Spikes", },
                    eggRand = 7,
                    FS = true,
                },

                new Species() {
                    Name = "Mantine",
                    moves = { new Move { Name = "Psybeam", At = 1 }, new Move { Name = "Bullet Seed", At = 1 }, new Move { Name = "Signal Beam", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Bubble Beam", At = 1 }, new Move { Name = "Supersonic", At = 3 }, new Move { Name = "Bubble Beam", At = 7 }, new Move { Name = "Confuse Ray", At = 11 }, new Move { Name = "Wing Attack", At = 14 }, new Move { Name = "Headbutt", At = 16 }, new Move { Name = "Water Pulse", At = 19 }, new Move { Name = "Wide Guard", At = 23 }, new Move { Name = "Take Down", At = 27 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Air Slash", At = 36 }, new Move { Name = "Aqua Ring", At = 39 }, new Move { Name = "Bounce", At = 46 }, new Move { Name = "Hydro Pump", At = 49 }, },
                  //eggMoves = { "Twister", "Hydro Pump", "Haze", "Slam", "Mud Sport", "Mirror Coat", "Water Sport", "Splash", "Wide Guard", "Amnesia", },
                    eggMoves = { "Twister", "Hydro Pump", "Haze", "Slam", "Mud Sport", "Mirror Coat", "Water Sport", "Splash", "Signal Beam", "Wide Guard", "Amnesia", "Tailwind", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Skarmory",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Sand Attack", At = 6 }, new Move { Name = "Metal Claw", At = 9 }, new Move { Name = "Air Cutter", At = 12 }, new Move { Name = "Fury Attack", At = 17 }, new Move { Name = "Feint", At = 20 }, new Move { Name = "Swift", At = 23 }, new Move { Name = "Spikes", At = 28 }, new Move { Name = "Agility", At = 31 }, new Move { Name = "Steel Wing", At = 34 }, new Move { Name = "Slash", At = 39 }, new Move { Name = "Metal Sound", At = 42 }, new Move { Name = "Air Slash", At = 45 }, new Move { Name = "Autotomize", At = 50 }, new Move { Name = "Night Slash", At = 53 }, },
                    eggMoves = { "Drill Peck", "Pursuit", "Whirlwind", "Sky Attack", "Curse", "Brave Bird", "Assurance", "Guard Swap", "Stealth Rock", "Endure", },
                    FS = true,
                    oras5 = "Metal Coat",
                },

                new Species() {
                    Name = "Houndour",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Howl", At = 4 }, new Move { Name = "Smog", At = 8 }, new Move { Name = "Roar", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Odor Sleuth", At = 20 }, new Move { Name = "Beat Up", At = 25 }, new Move { Name = "Fire Fang", At = 28 }, new Move { Name = "Feint Attack", At = 32 }, new Move { Name = "Embargo", At = 37 }, new Move { Name = "Foul Play", At = 40 }, new Move { Name = "Flamethrower", At = 44 }, new Move { Name = "Crunch", At = 49 }, new Move { Name = "Nasty Plot", At = 52 }, new Move { Name = "Inferno", At = 56 }, },
                    eggMoves = { "Fire Spin", "Rage", "Pursuit", "Counter", "Spite", "Reversal", "Beat Up", "Fire Fang", "Thunder Fang", "Nasty Plot", "Punishment", "Feint", "Sucker Punch", "Destiny Bond", },
                },

                new Species() {
                    Name = "Houndoom",
                    moves = { new Move { Name = "Inferno", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Howl", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Howl", At = 4 }, new Move { Name = "Smog", At = 8 }, new Move { Name = "Roar", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Odor Sleuth", At = 20 }, new Move { Name = "Beat Up", At = 26 }, new Move { Name = "Fire Fang", At = 30 }, new Move { Name = "Feint Attack", At = 35 }, new Move { Name = "Embargo", At = 41 }, new Move { Name = "Foul Play", At = 45 }, new Move { Name = "Flamethrower", At = 50 }, new Move { Name = "Crunch", At = 56 }, new Move { Name = "Nasty Plot", At = 60 }, new Move { Name = "Inferno", At = 65 }, },
                },

                new Species() {
                    Name = "Kingdra",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Smokescreen", At = 5 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Water Gun", At = 13 }, new Move { Name = "Twister", At = 17 }, new Move { Name = "Bubble Beam", At = 21 }, new Move { Name = "Focus Energy", At = 26 }, new Move { Name = "Brine", At = 31 }, new Move { Name = "Agility", At = 38 }, new Move { Name = "Dragon Pulse", At = 45 }, new Move { Name = "Dragon Dance", At = 52 }, new Move { Name = "Hydro Pump", At = 60 }, },
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Phanpy",
                    moves = { new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Flail", At = 6 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Natural Gift", At = 15 }, new Move { Name = "Endure", At = 19 }, new Move { Name = "Slam", At = 24 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Charm", At = 33 }, new Move { Name = "Last Resort", At = 37 }, new Move { Name = "Double-Edge", At = 42 }, },
                    eggMoves = { "Focus Energy", "Body Slam", "Ancient Power", "Snore", "Counter", "Fissure", "Endeavor", "Ice Shard", "Head Smash", "Mud-Slap", "Heavy Slam", "Play Rough", },
                    FS = true,
                },

                new Species() {
                    Name = "Donphan",
                    moves = { new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Horn Attack", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Rapid Spin", At = 6 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Assurance", At = 15 }, new Move { Name = "Knock Off", At = 19 }, new Move { Name = "Slam", At = 24 }, new Move { Name = "Fury Attack", At = 25 }, new Move { Name = "Magnitude", At = 30 }, new Move { Name = "Scary Face", At = 37 }, new Move { Name = "Earthquake", At = 43 }, new Move { Name = "Giga Impact", At = 50 }, },
                    eggMoves = { "Focus Energy", "Body Slam", "Ancient Power", "Snore", "Counter", "Fissure", "Endeavor", "Ice Shard", "Head Smash", "Mud-Slap", "Heavy Slam", "Play Rough", },
                },

                new Species() {
                    Name = "Porygon2",
                    moves = { new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Magic Coat", At = 1 }, new Move { Name = "Conversion 2", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Conversion", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Psybeam", At = 7 }, new Move { Name = "Agility", At = 12 }, new Move { Name = "Recover", At = 18 }, new Move { Name = "Magnet Rise", At = 23 }, new Move { Name = "Signal Beam", At = 29 }, new Move { Name = "Recycle", At = 34 }, new Move { Name = "Discharge", At = 40 }, new Move { Name = "Lock-On", At = 45 }, new Move { Name = "Tri Attack", At = 50 }, new Move { Name = "Magic Coat", At = 56 }, new Move { Name = "Zap Cannon", At = 62 }, new Move { Name = "Hyper Beam", At = 67 }, },
                },

                new Species() {
                    Name = "Stantler",
                    moves = { new Move { Name = "Me First", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 3 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Hypnosis", At = 10 }, new Move { Name = "Stomp", At = 13 }, new Move { Name = "Sand Attack", At = 16 }, new Move { Name = "Take Down", At = 21 }, new Move { Name = "Confuse Ray", At = 23 }, new Move { Name = "Calm Mind", At = 27 }, new Move { Name = "Role Play", At = 33 }, new Move { Name = "Zen Headbutt", At = 38 }, new Move { Name = "Jump Kick", At = 43 }, new Move { Name = "Imprison", At = 49 }, new Move { Name = "Captivate", At = 50 }, new Move { Name = "Me First", At = 55 }, },
                    eggMoves = { "Spite", "Disable", "Bite", "Extrasensory", "Thrash", "Double Kick", "Zen Headbutt", "Megahorn", "Mud Sport", "Rage", "Me First", },
                },

                new Species() {
                    Name = "Smeargle",
                    moves = { new Move { Name = "Sketch", At = 1 }, new Move { Name = "Sketch", At = 11 }, new Move { Name = "Sketch", At = 21 }, new Move { Name = "Sketch", At = 31 }, new Move { Name = "Sketch", At = 41 }, new Move { Name = "Sketch", At = 51 }, new Move { Name = "Sketch", At = 61 }, new Move { Name = "Sketch", At = 71 }, new Move { Name = "Sketch", At = 81 }, new Move { Name = "Sketch", At = 91 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Tyrogue",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Foresight", At = 1 }, },
                    eggMoves = { "Rapid Spin", "High Jump Kick", "Mach Punch", "Mind Reader", "Helping Hand", "Counter", "Vacuum Wave", "Bullet Punch", "Endure", "Pursuit", "Feint", },
                    FS = true,
                },

                new Species() {
                    Name = "Hitmontop",
                    moves = { new Move { Name = "Endeavor", At = 1 }, new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Revenge", At = 1 }, new Move { Name = "Rolling Kick", At = 1 }, new Move { Name = "Focus Energy", At = 6 }, new Move { Name = "Pursuit", At = 10 }, new Move { Name = "Quick Attack", At = 15 }, new Move { Name = "Triple Kick", At = 19 }, new Move { Name = "Rapid Spin", At = 24 }, new Move { Name = "Counter", At = 28 }, new Move { Name = "Feint", At = 33 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Gyro Ball", At = 42 }, new Move { Name = "Wide Guard", At = 46 }, new Move { Name = "Quick Guard", At = 46 }, new Move { Name = "Detect", At = 50 }, new Move { Name = "Close Combat", At = 55 }, new Move { Name = "Endeavor", At = 60 }, },
                },

                new Species() {
                    Name = "Smoochum",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Lick", At = 5 }, new Move { Name = "Sweet Kiss", At = 8 }, new Move { Name = "Powder Snow", At = 11 }, new Move { Name = "Confusion", At = 15 }, new Move { Name = "Sing", At = 18 }, new Move { Name = "Heart Stamp", At = 21 }, new Move { Name = "Mean Look", At = 25 }, new Move { Name = "Fake Tears", At = 28 }, new Move { Name = "Lucky Chant", At = 31 }, new Move { Name = "Avalanche", At = 35 }, new Move { Name = "Psychic", At = 38 }, new Move { Name = "Copycat", At = 41 }, new Move { Name = "Perish Song", At = 45 }, new Move { Name = "Blizzard", At = 48 }, },
                    eggMoves = { "Meditate", "Fake Out", "Wish", "Ice Punch", "Miracle Eye", "Nasty Plot", "Wake-Up Slap", "Captivate", },
                },

                new Species() {
                    Name = "Elekid",
                    moves = { new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Shock", At = 5 }, new Move { Name = "Low Kick", At = 8 }, new Move { Name = "Swift", At = 12 }, new Move { Name = "Shock Wave", At = 15 }, new Move { Name = "Thunder Wave", At = 19 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Light Screen", At = 26 }, new Move { Name = "Thunder Punch", At = 29 }, new Move { Name = "Discharge", At = 33 }, new Move { Name = "Screech", At = 36 }, new Move { Name = "Thunderbolt", At = 40 }, new Move { Name = "Thunder", At = 43 }, },
                    eggMoves = { "Karate Chop", "Barrier", "Rolling Kick", "Meditate", "Cross Chop", "Fire Punch", "Ice Punch", "Dynamic Punch", "Feint", "Hammer Arm", "Focus Punch", },
                    oras5 = "Electirizer",
                },

                new Species() {
                    Name = "Magby",
                    moves = { new Move { Name = "Smog", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Smokescreen", At = 8 }, new Move { Name = "Feint Attack", At = 12 }, new Move { Name = "Fire Spin", At = 15 }, new Move { Name = "Clear Smog", At = 19 }, new Move { Name = "Flame Burst", At = 22 }, new Move { Name = "Confuse Ray", At = 26 }, new Move { Name = "Fire Punch", At = 29 }, new Move { Name = "Lava Plume", At = 33 }, new Move { Name = "Sunny Day", At = 36 }, new Move { Name = "Flamethrower", At = 40 }, new Move { Name = "Fire Blast", At = 43 }, },
                    eggMoves = { "Karate Chop", "Mega Punch", "Barrier", "Screech", "Cross Chop", "Thunder Punch", "Mach Punch", "Dynamic Punch", "Flare Blitz", "Belly Drum", "Iron Tail", "Focus Energy", "Power Swap", "Belch", },
                    oras5 = "Magmarizer",
                },

                new Species() {
                    Name = "Miltank",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Defense Curl", At = 5 }, new Move { Name = "Stomp", At = 8 }, new Move { Name = "Milk Drink", At = 11 }, new Move { Name = "Bide", At = 15 }, new Move { Name = "Rollout", At = 19 }, new Move { Name = "Body Slam", At = 24 }, new Move { Name = "Zen Headbutt", At = 29 }, new Move { Name = "Captivate", At = 35 }, new Move { Name = "Gyro Ball", At = 41 }, new Move { Name = "Heal Bell", At = 48 }, new Move { Name = "Wake-Up Slap", At = 50 }, },
                    eggMoves = { "Present", "Reversal", "Seismic Toss", "Endure", "Curse", "Helping Hand", "Sleep Talk", "Dizzy Punch", "Hammer Arm", "Double-Edge", "Punishment", "Natural Gift", "Heart Stamp", "Belch", },
                },

                new Species() {
                    Name = "Blissey",
                    moves = { new Move { Name = "Double-Edge", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Refresh", At = 9 }, new Move { Name = "Double Slap", At = 12 }, new Move { Name = "Soft-Boiled", At = 16 }, new Move { Name = "Bestow", At = 20 }, new Move { Name = "Minimize", At = 23 }, new Move { Name = "Take Down", At = 27 }, new Move { Name = "Sing", At = 31 }, new Move { Name = "Fling", At = 34 }, new Move { Name = "Heal Pulse", At = 38 }, new Move { Name = "Egg Bomb", At = 42 }, new Move { Name = "Light Screen", At = 46 }, new Move { Name = "Healing Wish", At = 50 }, new Move { Name = "Double-Edge", At = 54 }, },
                },

                new Species() {
                    Name = "Raikou",
                    moves = { new Move { Name = "Extrasensory", At = 1 }, new Move { Name = "Discharge", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Shock", At = 8 }, new Move { Name = "Roar", At = 15 }, new Move { Name = "Quick Attack", At = 22 }, new Move { Name = "Spark", At = 29 }, new Move { Name = "Reflect", At = 36 }, new Move { Name = "Crunch", At = 43 }, new Move { Name = "Thunder Fang", At = 50 }, new Move { Name = "Discharge", At = 57 }, new Move { Name = "Extrasensory", At = 64 }, new Move { Name = "Rain Dance", At = 71 }, new Move { Name = "Calm Mind", At = 78 }, new Move { Name = "Thunder", At = 85 }, },
                },

                new Species() {
                    Name = "Entei",
                    moves = { new Move { Name = "Sacred Fire", At = 1 }, new Move { Name = "Eruption", At = 1 }, new Move { Name = "Extrasensory", At = 1 }, new Move { Name = "Lava Plume", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 8 }, new Move { Name = "Roar", At = 15 }, new Move { Name = "Fire Spin", At = 22 }, new Move { Name = "Stomp", At = 29 }, new Move { Name = "Flamethrower", At = 36 }, new Move { Name = "Swagger", At = 43 }, new Move { Name = "Fire Fang", At = 50 }, new Move { Name = "Lava Plume", At = 57 }, new Move { Name = "Extrasensory", At = 64 }, new Move { Name = "Fire Blast", At = 71 }, new Move { Name = "Calm Mind", At = 78 }, new Move { Name = "Eruption", At = 85 }, },
                },

                new Species() {
                    Name = "Suicune",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Extrasensory", At = 1 }, new Move { Name = "Tailwind", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bubble Beam", At = 8 }, new Move { Name = "Rain Dance", At = 15 }, new Move { Name = "Gust", At = 22 }, new Move { Name = "Aurora Beam", At = 29 }, new Move { Name = "Mist", At = 36 }, new Move { Name = "Mirror Coat", At = 43 }, new Move { Name = "Ice Fang", At = 50 }, new Move { Name = "Tailwind", At = 57 }, new Move { Name = "Extrasensory", At = 64 }, new Move { Name = "Hydro Pump", At = 71 }, new Move { Name = "Calm Mind", At = 78 }, new Move { Name = "Blizzard", At = 85 }, },
                },

                new Species() {
                    Name = "Larvitar",
                    moves = { new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Sandstorm", At = 5 }, new Move { Name = "Screech", At = 10 }, new Move { Name = "Chip Away", At = 14 }, new Move { Name = "Rock Slide", At = 19 }, new Move { Name = "Scary Face", At = 23 }, new Move { Name = "Thrash", At = 28 }, new Move { Name = "Dark Pulse", At = 32 }, new Move { Name = "Payback", At = 37 }, new Move { Name = "Crunch", At = 41 }, new Move { Name = "Earthquake", At = 46 }, new Move { Name = "Stone Edge", At = 50 }, new Move { Name = "Hyper Beam", At = 55 }, },
                    eggMoves = { "Pursuit", "Stomp", "Outrage", "Focus Energy", "Ancient Power", "Dragon Dance", "Curse", "Iron Defense", "Assurance", "Iron Head", "Stealth Rock", "Iron Tail", },
                },

                new Species() {
                    Name = "Pupitar",
                    moves = { new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Sandstorm", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Sandstorm", At = 5 }, new Move { Name = "Screech", At = 10 }, new Move { Name = "Chip Away", At = 14 }, new Move { Name = "Rock Slide", At = 19 }, new Move { Name = "Scary Face", At = 23 }, new Move { Name = "Thrash", At = 28 }, new Move { Name = "Dark Pulse", At = 34 }, new Move { Name = "Payback", At = 41 }, new Move { Name = "Crunch", At = 47 }, new Move { Name = "Earthquake", At = 54 }, new Move { Name = "Stone Edge", At = 60 }, new Move { Name = "Hyper Beam", At = 67 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Tyranitar",
                    moves = { new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Sandstorm", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Sandstorm", At = 5 }, new Move { Name = "Screech", At = 10 }, new Move { Name = "Chip Away", At = 14 }, new Move { Name = "Rock Slide", At = 19 }, new Move { Name = "Scary Face", At = 23 }, new Move { Name = "Thrash", At = 28 }, new Move { Name = "Dark Pulse", At = 34 }, new Move { Name = "Payback", At = 41 }, new Move { Name = "Crunch", At = 47 }, new Move { Name = "Earthquake", At = 54 }, new Move { Name = "Stone Edge", At = 63 }, new Move { Name = "Hyper Beam", At = 73 }, new Move { Name = "Giga Impact", At = 82 }, },
                },

                new Species() {
                    Name = "Lugia",
                    moves = { new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Weather Ball", At = 1 }, new Move { Name = "Gust", At = 9 }, new Move { Name = "Dragon Rush", At = 15 }, new Move { Name = "Extrasensory", At = 23 }, new Move { Name = "Rain Dance", At = 29 }, new Move { Name = "Hydro Pump", At = 37 }, new Move { Name = "Aeroblast", At = 43 }, new Move { Name = "Punishment", At = 50 }, new Move { Name = "Ancient Power", At = 57 }, new Move { Name = "Safeguard", At = 65 }, new Move { Name = "Recover", At = 71 }, new Move { Name = "Future Sight", At = 79 }, new Move { Name = "Natural Gift", At = 85 }, new Move { Name = "Calm Mind", At = 93 }, new Move { Name = "Sky Attack", At = 99 }, },
                },

                new Species() {
                    Name = "Ho-Oh",
                    moves = { new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Weather Ball", At = 1 }, new Move { Name = "Gust", At = 9 }, new Move { Name = "Brave Bird", At = 15 }, new Move { Name = "Extrasensory", At = 23 }, new Move { Name = "Sunny Day", At = 29 }, new Move { Name = "Fire Blast", At = 37 }, new Move { Name = "Sacred Fire", At = 43 }, new Move { Name = "Punishment", At = 50 }, new Move { Name = "Ancient Power", At = 57 }, new Move { Name = "Safeguard", At = 65 }, new Move { Name = "Recover", At = 71 }, new Move { Name = "Future Sight", At = 79 }, new Move { Name = "Natural Gift", At = 85 }, new Move { Name = "Calm Mind", At = 93 }, new Move { Name = "Sky Attack", At = 99 }, },
                    item100 = "Sacred Ash",
                },

                new Species() {
                    Name = "Celebi",
                    moves = { new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Recover", At = 1 }, new Move { Name = "Heal Bell", At = 1 }, new Move { Name = "Safeguard", At = 10 }, new Move { Name = "Magical Leaf", At = 19 }, new Move { Name = "Ancient Power", At = 28 }, new Move { Name = "Baton Pass", At = 37 }, new Move { Name = "Natural Gift", At = 46 }, new Move { Name = "Heal Block", At = 55 }, new Move { Name = "Future Sight", At = 64 }, new Move { Name = "Healing Wish", At = 73 }, new Move { Name = "Leaf Storm", At = 82 }, new Move { Name = "Perish Song", At = 91 }, },
                    item100 = "Lum Berry",
                },

                new Species() {
                    Name = "Treecko",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Quick Attack", At = 9 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Pursuit", At = 17 }, new Move { Name = "Giga Drain", At = 21 }, new Move { Name = "Agility", At = 25 }, new Move { Name = "Slam", At = 29 }, new Move { Name = "Detect", At = 33 }, new Move { Name = "Energy Ball", At = 37 }, new Move { Name = "Quick Guard", At = 41 }, new Move { Name = "Endeavor", At = 45 }, new Move { Name = "Screech", At = 49 }, },
                    eggMoves = { "Crunch", "Mud Sport", "Endeavor", "Leech Seed", "Dragon Breath", "Crush Claw", "Worry Seed", "Double Kick", "Grass Whistle", "Synthesis", "Magical Leaf", "Leaf Storm", "Razor Wind", "Bullet Seed", "Natural Gift", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Grovyle",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Quick Attack", At = 9 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Fury Cutter", At = 16 }, new Move { Name = "Pursuit", At = 18 }, new Move { Name = "Leaf Blade", At = 23 }, new Move { Name = "Agility", At = 28 }, new Move { Name = "Slam", At = 33 }, new Move { Name = "Detect", At = 38 }, new Move { Name = "X-Scissor", At = 43 }, new Move { Name = "False Swipe", At = 48 }, new Move { Name = "Quick Guard", At = 53 }, new Move { Name = "Leaf Storm", At = 58 }, new Move { Name = "Screech", At = 63 }, },
                },

                new Species() {
                    Name = "Sceptile",
                    moves = { new Move { Name = "Leaf Storm", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Quick Attack", At = 9 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Fury Cutter", At = 16 }, new Move { Name = "Pursuit", At = 18 }, new Move { Name = "Leaf Blade", At = 23 }, new Move { Name = "Agility", At = 28 }, new Move { Name = "Slam", At = 33 }, new Move { Name = "Dual Chop", At = 36 }, new Move { Name = "Detect", At = 39 }, new Move { Name = "X-Scissor", At = 45 }, new Move { Name = "False Swipe", At = 51 }, new Move { Name = "Quick Guard", At = 57 }, new Move { Name = "Leaf Storm", At = 63 }, new Move { Name = "Screech", At = 69 }, },
                },

                new Species() {
                    Name = "Torchic",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Sand Attack", At = 10 }, new Move { Name = "Peck", At = 14 }, new Move { Name = "Fire Spin", At = 19 }, new Move { Name = "Quick Attack", At = 23 }, new Move { Name = "Flame Burst", At = 28 }, new Move { Name = "Focus Energy", At = 32 }, new Move { Name = "Slash", At = 37 }, new Move { Name = "Mirror Move", At = 41 }, new Move { Name = "Flamethrower", At = 46 }, },
                    eggMoves = { "Counter", "Reversal", "Endure", "Smelling Salts", "Crush Claw", "Baton Pass", "Agility", "Night Slash", "Last Resort", "Feint", "Feather Dance", "Curse", "Flame Burst", "Low Kick", },
                },

                new Species() {
                    Name = "Combusken",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Sand Attack", At = 10 }, new Move { Name = "Peck", At = 14 }, new Move { Name = "Double Kick", At = 16 }, new Move { Name = "Flame Charge", At = 20 }, new Move { Name = "Quick Attack", At = 25 }, new Move { Name = "Bulk Up", At = 31 }, new Move { Name = "Focus Energy", At = 36 }, new Move { Name = "Slash", At = 42 }, new Move { Name = "Mirror Move", At = 47 }, new Move { Name = "Sky Uppercut", At = 53 }, new Move { Name = "Flare Blitz", At = 58 }, },
                },

                new Species() {
                    Name = "Blaziken",
                    moves = { new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "High Jump Kick", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Sand Attack", At = 10 }, new Move { Name = "Peck", At = 14 }, new Move { Name = "Double Kick", At = 16 }, new Move { Name = "Flame Charge", At = 20 }, new Move { Name = "Quick Attack", At = 25 }, new Move { Name = "Bulk Up", At = 31 }, new Move { Name = "Blaze Kick", At = 36 }, new Move { Name = "Focus Energy", At = 37 }, new Move { Name = "Slash", At = 44 }, new Move { Name = "Brave Bird", At = 50 }, new Move { Name = "Sky Uppercut", At = 57 }, new Move { Name = "Flare Blitz", At = 63 }, },
                },

                new Species() {
                    Name = "Mudkip",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Mud-Slap", At = 9 }, new Move { Name = "Foresight", At = 12 }, new Move { Name = "Bide", At = 17 }, new Move { Name = "Mud Sport", At = 20 }, new Move { Name = "Rock Throw", At = 25 }, new Move { Name = "Protect", At = 28 }, new Move { Name = "Whirlpool", At = 33 }, new Move { Name = "Take Down", At = 36 }, new Move { Name = "Hydro Pump", At = 41 }, new Move { Name = "Endeavor", At = 44 }, },
                    eggMoves = { "Refresh", "Uproar", "Curse", "Stomp", "Ice Ball", "Mirror Coat", "Counter", "Ancient Power", "Whirlpool", "Bite", "Double-Edge", "Mud Bomb", "Yawn", "Sludge", "Avalanche", "Wide Guard", "Barrier", },
                },

                new Species() {
                    Name = "Marshtomp",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Mud-Slap", At = 9 }, new Move { Name = "Foresight", At = 12 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Bide", At = 18 }, new Move { Name = "Mud Bomb", At = 22 }, new Move { Name = "Rock Slide", At = 28 }, new Move { Name = "Protect", At = 32 }, new Move { Name = "Muddy Water", At = 38 }, new Move { Name = "Take Down", At = 42 }, new Move { Name = "Earthquake", At = 48 }, new Move { Name = "Endeavor", At = 52 }, },
                },

                new Species() {
                    Name = "Swampert",
                    moves = { new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Mud-Slap", At = 9 }, new Move { Name = "Foresight", At = 12 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Bide", At = 18 }, new Move { Name = "Mud Bomb", At = 22 }, new Move { Name = "Rock Slide", At = 28 }, new Move { Name = "Protect", At = 32 }, new Move { Name = "Muddy Water", At = 39 }, new Move { Name = "Take Down", At = 44 }, new Move { Name = "Earthquake", At = 51 }, new Move { Name = "Endeavor", At = 56 }, new Move { Name = "Hammer Arm", At = 63 }, },
                },

                new Species() {
                    Name = "Poochyena",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Howl", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Odor Sleuth", At = 13 }, new Move { Name = "Roar", At = 16 }, new Move { Name = "Swagger", At = 19 }, new Move { Name = "Assurance", At = 22 }, new Move { Name = "Scary Face", At = 25 }, new Move { Name = "Embargo", At = 28 }, new Move { Name = "Taunt", At = 31 }, new Move { Name = "Take Down", At = 34 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Sucker Punch", At = 40 }, },
                    eggMoves = { "Astonish", "Poison Fang", "Covet", "Leer", "Yawn", "Sucker Punch", "Ice Fang", "Fire Fang", "Thunder Fang", "Me First", "Snatch", "Sleep Talk", "Play Rough", },
                },

                new Species() {
                    Name = "Mightyena",
                    moves = { new Move { Name = "Crunch", At = 1 }, new Move { Name = "Thief", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Howl", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Howl", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Odor Sleuth", At = 13 }, new Move { Name = "Roar", At = 16 }, new Move { Name = "Snarl", At = 18 }, new Move { Name = "Swagger", At = 20 }, new Move { Name = "Assurance", At = 24 }, new Move { Name = "Scary Face", At = 28 }, new Move { Name = "Embargo", At = 32 }, new Move { Name = "Taunt", At = 36 }, new Move { Name = "Take Down", At = 40 }, new Move { Name = "Crunch", At = 44 }, new Move { Name = "Sucker Punch", At = 48 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Zigzagoon",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Baby-Doll Eyes", At = 12 }, new Move { Name = "Odor Sleuth", At = 13 }, new Move { Name = "Mud Sport", At = 17 }, new Move { Name = "Pin Missile", At = 19 }, new Move { Name = "Covet", At = 23 }, new Move { Name = "Bestow", At = 25 }, new Move { Name = "Flail", At = 29 }, new Move { Name = "Take Down", At = 31 }, new Move { Name = "Rest", At = 35 }, new Move { Name = "Belly Drum", At = 37 }, new Move { Name = "Fling", At = 41 }, },
                    eggMoves = { "Charm", "Pursuit", "Tickle", "Trick", "Helping Hand", "Mud-Slap", "Sleep Talk", "Rock Climb", "Simple Beam", },
                    oras5 = "Revive",
                    oras50 = "Potion",
                },

                new Species() {
                    Name = "Linoone",
                    moves = { new Move { Name = "Play Rough", At = 1 }, new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Switcheroo", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Odor Sleuth", At = 13 }, new Move { Name = "Mud Sport", At = 17 }, new Move { Name = "Fury Swipes", At = 19 }, new Move { Name = "Covet", At = 24 }, new Move { Name = "Bestow", At = 27 }, new Move { Name = "Slash", At = 32 }, new Move { Name = "Double-Edge", At = 35 }, new Move { Name = "Rest", At = 40 }, new Move { Name = "Belly Drum", At = 43 }, new Move { Name = "Fling", At = 48 }, },
                    eggMoves = { "Charm", "Pursuit", "Tickle", "Trick", "Helping Hand", "Mud-Slap", "Sleep Talk", "Rock Climb", "Simple Beam", },
                    oras5 = "Max Revive",
                    oras50 = "Potion",
                },

                new Species() {
                    Name = "Wurmple",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Bug Bite", At = 15 }, },
                    oras5 = "Bright Powder",
                    oras50 = "Pecha Berry",
                },

                new Species() {
                    Name = "Silcoon",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Harden", At = 7 }, },
                },

                new Species() {
                    Name = "Beautifly",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Gust", At = 10 }, new Move { Name = "Absorb", At = 12 }, new Move { Name = "Stun Spore", At = 15 }, new Move { Name = "Morning Sun", At = 17 }, new Move { Name = "Air Cutter", At = 20 }, new Move { Name = "Mega Drain", At = 22 }, new Move { Name = "Silver Wind", At = 25 }, new Move { Name = "Attract", At = 27 }, new Move { Name = "Whirlwind", At = 30 }, new Move { Name = "Giga Drain", At = 32 }, new Move { Name = "Bug Buzz", At = 35 }, new Move { Name = "Rage", At = 37 }, new Move { Name = "Quiver Dance", At = 40 }, },
                    FS = true,
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Cascoon",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Harden", At = 7 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Dustox",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Gust", At = 10 }, new Move { Name = "Confusion", At = 12 }, new Move { Name = "Poison Powder", At = 15 }, new Move { Name = "Moonlight", At = 17 }, new Move { Name = "Venoshock", At = 20 }, new Move { Name = "Psybeam", At = 22 }, new Move { Name = "Silver Wind", At = 25 }, new Move { Name = "Light Screen", At = 27 }, new Move { Name = "Whirlwind", At = 30 }, new Move { Name = "Toxic", At = 32 }, new Move { Name = "Bug Buzz", At = 35 }, new Move { Name = "Protect", At = 37 }, new Move { Name = "Quiver Dance", At = 40 }, },
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Lotad",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Absorb", At = 6 }, new Move { Name = "Bubble", At = 9 }, new Move { Name = "Natural Gift", At = 12 }, new Move { Name = "Mist", At = 15 }, new Move { Name = "Mega Drain", At = 18 }, new Move { Name = "Bubble Beam", At = 21 }, new Move { Name = "Nature Power", At = 24 }, new Move { Name = "Rain Dance", At = 27 }, new Move { Name = "Giga Drain", At = 30 }, new Move { Name = "Zen Headbutt", At = 33 }, new Move { Name = "Energy Ball", At = 36 }, },
                    eggMoves = { "Synthesis", "Razor Leaf", "Sweet Scent", "Leech Seed", "Flail", "Water Gun", "Tickle", "Counter", "Giga Drain", "Teeter Dance", },
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Lombre",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Absorb", At = 6 }, new Move { Name = "Bubble", At = 9 }, new Move { Name = "Fury Swipes", At = 12 }, new Move { Name = "Fake Out", At = 16 }, new Move { Name = "Water Sport", At = 20 }, new Move { Name = "Bubble Beam", At = 24 }, new Move { Name = "Nature Power", At = 28 }, new Move { Name = "Uproar", At = 32 }, new Move { Name = "Knock Off", At = 36 }, new Move { Name = "Zen Headbutt", At = 40 }, new Move { Name = "Hydro Pump", At = 44 }, },
                    eggMoves = { "Synthesis", "Razor Leaf", "Sweet Scent", "Leech Seed", "Flail", "Water Gun", "Tickle", "Counter", "Giga Drain", "Teeter Dance", },
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Ludicolo",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Nature Power", At = 1 }, },
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Seedot",
                    moves = { new Move { Name = "Bide", At = 1 }, new Move { Name = "Harden", At = 3 }, new Move { Name = "Growth", At = 9 }, new Move { Name = "Nature Power", At = 15 }, new Move { Name = "Synthesis", At = 21 }, new Move { Name = "Sunny Day", At = 27 }, new Move { Name = "Explosion", At = 33 }, },
                    eggMoves = { "Leech Seed", "Amnesia", "Quick Attack", "Razor Wind", "Take Down", "Worry Seed", "Nasty Plot", "Power Swap", "Defog", "Foul Play", "Beat Up", "Bullet Seed", "Grassy Terrain", },
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Nuzleaf",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Harden", At = 3 }, new Move { Name = "Growth", At = 6 }, new Move { Name = "Nature Power", At = 9 }, new Move { Name = "Fake Out", At = 12 }, new Move { Name = "Razor Leaf", At = 14 }, new Move { Name = "Torment", At = 16 }, new Move { Name = "Razor Wind", At = 20 }, new Move { Name = "Feint Attack", At = 24 }, new Move { Name = "Leaf Blade", At = 28 }, new Move { Name = "Swagger", At = 32 }, new Move { Name = "Extrasensory", At = 36 }, },
                    eggMoves = { "Leech Seed", "Amnesia", "Quick Attack", "Razor Wind", "Take Down", "Worry Seed", "Nasty Plot", "Power Swap", "Defog", "Foul Play", "Beat Up", "Bullet Seed", "Grassy Terrain", },
                    FS = true,
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Shiftry",
                    moves = { new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Feint Attack", At = 1 }, new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Leaf Tornado", At = 20 }, new Move { Name = "Hurricane", At = 32 }, new Move { Name = "Leaf Storm", At = 44 }, },
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Taillow",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Focus Energy", At = 5 }, new Move { Name = "Quick Attack", At = 9 }, new Move { Name = "Wing Attack", At = 13 }, new Move { Name = "Double Team", At = 17 }, new Move { Name = "Aerial Ace", At = 21 }, new Move { Name = "Quick Guard", At = 25 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Air Slash", At = 33 }, new Move { Name = "Endeavor", At = 37 }, new Move { Name = "Brave Bird", At = 41 }, },
                    eggMoves = { "Pursuit", "Supersonic", "Refresh", "Mirror Move", "Rage", "Sky Attack", "Whirlwind", "Brave Bird", "Roost", "Steel Wing", "Defog", "Boomburst", },
                },

                new Species() {
                    Name = "Swellow",
                    moves = { new Move { Name = "Brave Bird", At = 1 }, new Move { Name = "Air Slash", At = 1 }, new Move { Name = "Pluck", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Focus Energy", At = 5 }, new Move { Name = "Quick Attack", At = 9 }, new Move { Name = "Wing Attack", At = 13 }, new Move { Name = "Double Team", At = 17 }, new Move { Name = "Aerial Ace", At = 21 }, new Move { Name = "Quick Guard", At = 27 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Endeavor", At = 39 }, new Move { Name = "Air Slash", At = 45 }, new Move { Name = "Brave Bird", At = 51 }, },
                },

                new Species() {
                    Name = "Wingull",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Wing Attack", At = 8 }, new Move { Name = "Mist", At = 12 }, new Move { Name = "Water Pulse", At = 15 }, new Move { Name = "Quick Attack", At = 19 }, new Move { Name = "Air Cutter", At = 22 }, new Move { Name = "Pursuit", At = 26 }, new Move { Name = "Aerial Ace", At = 29 }, new Move { Name = "Roost", At = 33 }, new Move { Name = "Agility", At = 36 }, new Move { Name = "Air Slash", At = 40 }, new Move { Name = "Hurricane", At = 43 }, },
                    eggMoves = { "Mist", "Twister", "Agility", "Gust", "Water Sport", "Aqua Ring", "Knock Off", "Brine", "Roost", "Soak", "Wide Guard", },
                    eggRand = 7,
                    oras50 = "Pretty Wing",
                },

                new Species() {
                    Name = "Pelipper",
                    moves = { new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Tailwind", At = 1 }, new Move { Name = "Soak", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Wing Attack", At = 8 }, new Move { Name = "Mist", At = 12 }, new Move { Name = "Water Pulse", At = 15 }, new Move { Name = "Payback", At = 19 }, new Move { Name = "Roost", At = 22 }, new Move { Name = "Protect", At = 25 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Stockpile", At = 33 }, new Move { Name = "Swallow", At = 33 }, new Move { Name = "Spit Up", At = 33 }, new Move { Name = "Fling", At = 39 }, new Move { Name = "Tailwind", At = 44 }, new Move { Name = "Hydro Pump", At = 50 }, new Move { Name = "Hurricane", At = 55 }, },
                    eggMoves = { "Mist", "Twister", "Agility", "Gust", "Water Sport", "Aqua Ring", "Knock Off", "Brine", "Roost", "Soak", "Wide Guard", },
                    eggRand = 7,
                    oras5 = "Lucky Egg",
                    oras50 = "Pretty Wing",
                },

                new Species() {
                    Name = "Ralts",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Confusion", At = 4 }, new Move { Name = "Double Team", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Lucky Chant", At = 14 }, new Move { Name = "Magical Leaf", At = 17 }, new Move { Name = "Heal Pulse", At = 19 }, new Move { Name = "Draining Kiss", At = 22 }, new Move { Name = "Calm Mind", At = 24 }, new Move { Name = "Psychic", At = 27 }, new Move { Name = "Imprison", At = 29 }, new Move { Name = "Future Sight", At = 32 }, new Move { Name = "Charm", At = 34 }, new Move { Name = "Hypnosis", At = 37 }, new Move { Name = "Dream Eater", At = 39 }, new Move { Name = "Stored Power", At = 42 }, },
                    eggMoves = { "Disable", "Mean Look", "Memento", "Destiny Bond", "Grudge", "Shadow Sneak", "Confuse Ray", "Encore", "Synchronoise", "Skill Swap", "Misty Terrain", "Ally Switch", },
                },

                new Species() {
                    Name = "Kirlia",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Teleport", At = 1 }, new Move { Name = "Confusion", At = 4 }, new Move { Name = "Double Team", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Lucky Chant", At = 14 }, new Move { Name = "Magical Leaf", At = 17 }, new Move { Name = "Heal Pulse", At = 19 }, new Move { Name = "Draining Kiss", At = 23 }, new Move { Name = "Calm Mind", At = 26 }, new Move { Name = "Psychic", At = 30 }, new Move { Name = "Imprison", At = 33 }, new Move { Name = "Future Sight", At = 37 }, new Move { Name = "Charm", At = 40 }, new Move { Name = "Hypnosis", At = 44 }, new Move { Name = "Dream Eater", At = 47 }, new Move { Name = "Stored Power", At = 51 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Gardevoir",
                    moves = { new Move { Name = "Moonblast", At = 1 }, new Move { Name = "Stored Power", At = 1 }, new Move { Name = "Misty Terrain", At = 1 }, new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Teleport", At = 1 }, new Move { Name = "Confusion", At = 4 }, new Move { Name = "Double Team", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Wish", At = 14 }, new Move { Name = "Magical Leaf", At = 17 }, new Move { Name = "Heal Pulse", At = 19 }, new Move { Name = "Draining Kiss", At = 23 }, new Move { Name = "Calm Mind", At = 26 }, new Move { Name = "Psychic", At = 31 }, new Move { Name = "Imprison", At = 35 }, new Move { Name = "Future Sight", At = 40 }, new Move { Name = "Captivate", At = 44 }, new Move { Name = "Hypnosis", At = 49 }, new Move { Name = "Dream Eater", At = 53 }, new Move { Name = "Stored Power", At = 58 }, new Move { Name = "Moonblast", At = 62 }, },
                },

                new Species() {
                    Name = "Surskit",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Sweet Scent", At = 9 }, new Move { Name = "Water Sport", At = 14 }, new Move { Name = "Bubble Beam", At = 17 }, new Move { Name = "Agility", At = 22 }, new Move { Name = "Mist", At = 25 }, new Move { Name = "Haze", At = 25 }, new Move { Name = "Aqua Jet", At = 30 }, new Move { Name = "Baton Pass", At = 35 }, new Move { Name = "Sticky Web", At = 38 }, },
                    eggMoves = { "Foresight", "Mud Shot", "Psybeam", "Hydro Pump", "Mind Reader", "Signal Beam", "Bug Bite", "Aqua Jet", "Endure", "Fell Stinger", "Power Split", },
                    eggRand = 9,
                    oras50 = "Honey",
                },

                new Species() {
                    Name = "Masquerain",
                    moves = { new Move { Name = "Quiver Dance", At = 1 }, new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Bug Buzz", At = 1 }, new Move { Name = "Ominous Wind", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Sweet Scent", At = 9 }, new Move { Name = "Water Sport", At = 14 }, new Move { Name = "Gust", At = 17 }, new Move { Name = "Scary Face", At = 22 }, new Move { Name = "Air Cutter", At = 22 }, new Move { Name = "Stun Spore", At = 26 }, new Move { Name = "Silver Wind", At = 32 }, new Move { Name = "Air Slash", At = 38 }, new Move { Name = "Bug Buzz", At = 42 }, new Move { Name = "Whirlwind", At = 48 }, new Move { Name = "Quiver Dance", At = 52 }, },
                    eggMoves = { "Foresight", "Mud Shot", "Psybeam", "Hydro Pump", "Mind Reader", "Signal Beam", "Bug Bite", "Aqua Jet", "Endure", "Fell Stinger", "Power Split", },
                    eggRand = 9,
                    FS = true,
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Shroomish",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Stun Spore", At = 5 }, new Move { Name = "Leech Seed", At = 8 }, new Move { Name = "Mega Drain", At = 12 }, new Move { Name = "Headbutt", At = 15 }, new Move { Name = "Poison Powder", At = 19 }, new Move { Name = "Worry Seed", At = 22 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Growth", At = 29 }, new Move { Name = "Toxic", At = 33 }, new Move { Name = "Seed Bomb", At = 36 }, new Move { Name = "Spore", At = 40 }, },
                    eggMoves = { "Fake Tears", "Charm", "Helping Hand", "Worry Seed", "Wake-Up Slap", "Seed Bomb", "Bullet Seed", "Focus Punch", "Natural Gift", "Drain Punch", },
                    oras5 = "Big Mushroom",
                    oras50 = "Tiny Mushroom",
                },

                new Species() {
                    Name = "Breloom",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Stun Spore", At = 1 }, new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Stun Spore", At = 5 }, new Move { Name = "Leech Seed", At = 8 }, new Move { Name = "Mega Drain", At = 12 }, new Move { Name = "Headbutt", At = 15 }, new Move { Name = "Feint", At = 19 }, new Move { Name = "Counter", At = 22 }, new Move { Name = "Mach Punch", At = 23 }, new Move { Name = "Force Palm", At = 28 }, new Move { Name = "Mind Reader", At = 33 }, new Move { Name = "Sky Uppercut", At = 39 }, new Move { Name = "Seed Bomb", At = 44 }, new Move { Name = "Dynamic Punch", At = 50 }, },
                    FS = true,
                    oras5 = "Big Mushroom",
                    oras50 = "Tiny Mushroom",
                },

                new Species() {
                    Name = "Slakoth",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Encore", At = 6 }, new Move { Name = "Slack Off", At = 9 }, new Move { Name = "Feint Attack", At = 14 }, new Move { Name = "Amnesia", At = 17 }, new Move { Name = "Covet", At = 22 }, new Move { Name = "Chip Away", At = 25 }, new Move { Name = "Counter", At = 30 }, new Move { Name = "Flail", At = 33 }, new Move { Name = "Play Rough", At = 38 }, },
                    eggMoves = { "Pursuit", "Slash", "Body Slam", "Snore", "Crush Claw", "Curse", "Sleep Talk", "Hammer Arm", "Night Slash", "After You", "Tickle", },
                },

                new Species() {
                    Name = "Vigoroth",
                    moves = { new Move { Name = "Reversal", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Encore", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Encore", At = 6 }, new Move { Name = "Uproar", At = 9 }, new Move { Name = "Fury Swipes", At = 14 }, new Move { Name = "Endure", At = 17 }, new Move { Name = "Slash", At = 23 }, new Move { Name = "Chip Away", At = 27 }, new Move { Name = "Counter", At = 33 }, new Move { Name = "Focus Punch", At = 37 }, new Move { Name = "Reversal", At = 43 }, },
                },

                new Species() {
                    Name = "Slaking",
                    moves = { new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Punishment", At = 1 }, new Move { Name = "Fling", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Encore", At = 1 }, new Move { Name = "Slack Off", At = 1 }, new Move { Name = "Encore", At = 6 }, new Move { Name = "Slack Off", At = 9 }, new Move { Name = "Feint Attack", At = 14 }, new Move { Name = "Amnesia", At = 17 }, new Move { Name = "Covet", At = 23 }, new Move { Name = "Chip Away", At = 27 }, new Move { Name = "Counter", At = 33 }, new Move { Name = "Swagger", At = 36 }, new Move { Name = "Flail", At = 39 }, new Move { Name = "Fling", At = 47 }, new Move { Name = "Punishment", At = 53 }, new Move { Name = "Hammer Arm", At = 61 }, },
                },

                new Species() {
                    Name = "Nincada",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Leech Life", At = 5 }, new Move { Name = "Sand Attack", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Mud-Slap", At = 17 }, new Move { Name = "Metal Claw", At = 21 }, new Move { Name = "Mind Reader", At = 25 }, new Move { Name = "Bide", At = 29 }, new Move { Name = "False Swipe", At = 33 }, new Move { Name = "Dig", At = 37 }, },
                    eggMoves = { "Endure", "Feint Attack", "Gust", "Silver Wind", "Bug Buzz", "Night Slash", "Bug Bite", "Final Gambit", },
                    FS = true,
                    oras5 = "Soft Sand",
                },

                new Species() {
                    Name = "Ninjask",
                    moves = { new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Leech Life", At = 5 }, new Move { Name = "Sand Attack", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Agility", At = 17 }, new Move { Name = "Double Team", At = 20 }, new Move { Name = "Fury Cutter", At = 20 }, new Move { Name = "Screech", At = 20 }, new Move { Name = "Slash", At = 23 }, new Move { Name = "Mind Reader", At = 29 }, new Move { Name = "Baton Pass", At = 35 }, new Move { Name = "Swords Dance", At = 41 }, new Move { Name = "X-Scissor", At = 47 }, },
                },

                new Species() {
                    Name = "Shedinja",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Leech Life", At = 5 }, new Move { Name = "Sand Attack", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Spite", At = 17 }, new Move { Name = "Shadow Sneak", At = 21 }, new Move { Name = "Mind Reader", At = 25 }, new Move { Name = "Confuse Ray", At = 29 }, new Move { Name = "Shadow Ball", At = 33 }, new Move { Name = "Grudge", At = 37 }, new Move { Name = "Heal Block", At = 41 }, new Move { Name = "Phantom Force", At = 45 }, },
                },

                new Species() {
                    Name = "Whismur",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Echoed Voice", At = 4 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Screech", At = 15 }, new Move { Name = "Supersonic", At = 18 }, new Move { Name = "Stomp", At = 22 }, new Move { Name = "Uproar", At = 25 }, new Move { Name = "Roar", At = 29 }, new Move { Name = "Rest", At = 32 }, new Move { Name = "Sleep Talk", At = 36 }, new Move { Name = "Hyper Voice", At = 39 }, new Move { Name = "Synchronoise", At = 43 }, },
                    eggMoves = { "Take Down", "Snore", "Extrasensory", "Smelling Salts", "Smokescreen", "Endeavor", "Hammer Arm", "Fake Tears", "Circle Throw", "Disarming Voice", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Loudred",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Echoed Voice", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Howl", At = 1 }, new Move { Name = "Echoed Voice", At = 4 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Screech", At = 15 }, new Move { Name = "Supersonic", At = 18 }, new Move { Name = "Bite", At = 20 }, new Move { Name = "Stomp", At = 23 }, new Move { Name = "Uproar", At = 27 }, new Move { Name = "Roar", At = 32 }, new Move { Name = "Rest", At = 36 }, new Move { Name = "Sleep Talk", At = 41 }, new Move { Name = "Hyper Voice", At = 45 }, new Move { Name = "Synchronoise", At = 50 }, },
                    eggMoves = { "Take Down", "Snore", "Extrasensory", "Smelling Salts", "Smokescreen", "Endeavor", "Hammer Arm", "Fake Tears", "Circle Throw", "Disarming Voice", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Exploud",
                    moves = { new Move { Name = "Boomburst", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Echoed Voice", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Howl", At = 1 }, new Move { Name = "Echoed Voice", At = 4 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Screech", At = 15 }, new Move { Name = "Supersonic", At = 18 }, new Move { Name = "Bite", At = 20 }, new Move { Name = "Stomp", At = 23 }, new Move { Name = "Uproar", At = 27 }, new Move { Name = "Roar", At = 32 }, new Move { Name = "Rest", At = 36 }, new Move { Name = "Crunch", At = 40 }, new Move { Name = "Sleep Talk", At = 42 }, new Move { Name = "Hyper Voice", At = 47 }, new Move { Name = "Synchronoise", At = 53 }, new Move { Name = "Boomburst", At = 58 }, new Move { Name = "Hyper Beam", At = 64 }, },
                },

                new Species() {
                    Name = "Makuhita",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Arm Thrust", At = 7 }, new Move { Name = "Fake Out", At = 10 }, new Move { Name = "Force Palm", At = 13 }, new Move { Name = "Whirlwind", At = 16 }, new Move { Name = "Knock Off", At = 19 }, new Move { Name = "Vital Throw", At = 22 }, new Move { Name = "Belly Drum", At = 25 }, new Move { Name = "Smelling Salts", At = 28 }, new Move { Name = "Seismic Toss", At = 31 }, new Move { Name = "Wake-Up Slap", At = 34 }, new Move { Name = "Endure", At = 37 }, new Move { Name = "Close Combat", At = 40 }, new Move { Name = "Reversal", At = 43 }, new Move { Name = "Heavy Slam", At = 46 }, },
                    eggMoves = { "Feint Attack", "Detect", "Foresight", "Helping Hand", "Cross Chop", "Revenge", "Dynamic Punch", "Counter", "Wake-Up Slap", "Bullet Punch", "Feint", "Wide Guard", "Focus Punch", "Chip Away", },
                    eggRand = 7,
                    oras5 = "Black Belt",
                },

                new Species() {
                    Name = "Hariyama",
                    moves = { new Move { Name = "Brine", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Arm Thrust", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Arm Thrust", At = 7 }, new Move { Name = "Fake Out", At = 10 }, new Move { Name = "Force Palm", At = 13 }, new Move { Name = "Whirlwind", At = 16 }, new Move { Name = "Knock Off", At = 19 }, new Move { Name = "Vital Throw", At = 22 }, new Move { Name = "Belly Drum", At = 26 }, new Move { Name = "Smelling Salts", At = 30 }, new Move { Name = "Seismic Toss", At = 34 }, new Move { Name = "Wake-Up Slap", At = 38 }, new Move { Name = "Endure", At = 42 }, new Move { Name = "Close Combat", At = 46 }, new Move { Name = "Reversal", At = 50 }, new Move { Name = "Heavy Slam", At = 54 }, },
                    eggMoves = { "Feint Attack", "Detect", "Foresight", "Helping Hand", "Cross Chop", "Revenge", "Dynamic Punch", "Counter", "Wake-Up Slap", "Bullet Punch", "Feint", "Wide Guard", "Focus Punch", "Chip Away", },
                    eggRand = 7,
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Azurill",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Tail Whip", At = 2 }, new Move { Name = "Water Sport", At = 5 }, new Move { Name = "Bubble", At = 7 }, new Move { Name = "Charm", At = 10 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Helping Hand", At = 16 }, new Move { Name = "Slam", At = 20 }, new Move { Name = "Bounce", At = 23 }, },
                    eggMoves = { "Encore", "Sing", "Refresh", "Slam", "Tickle", "Fake Tears", "Body Slam", "Water Sport", "Soak", "Muddy Water", "Copycat", "Camouflage", },
                },

                new Species() {
                    Name = "Nosepass",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Block", At = 7 }, new Move { Name = "Rock Throw", At = 10 }, new Move { Name = "Thunder Wave", At = 13 }, new Move { Name = "Rest", At = 16 }, new Move { Name = "Spark", At = 19 }, new Move { Name = "Rock Slide", At = 22 }, new Move { Name = "Power Gem", At = 25 }, new Move { Name = "Rock Blast", At = 28 }, new Move { Name = "Discharge", At = 31 }, new Move { Name = "Sandstorm", At = 34 }, new Move { Name = "Earth Power", At = 37 }, new Move { Name = "Stone Edge", At = 40 }, new Move { Name = "Lock-On", At = 43 }, new Move { Name = "Zap Cannon", At = 43 }, },
                    eggMoves = { "Magnitude", "Rollout", "Double-Edge", "Block", "Stealth Rock", "Endure", "Wide Guard", },
                    FS = true,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Skitty",
                    moves = { new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Foresight", At = 4 }, new Move { Name = "Sing", At = 7 }, new Move { Name = "Attract", At = 10 }, new Move { Name = "Disarming Voice", At = 13 }, new Move { Name = "Double Slap", At = 16 }, new Move { Name = "Copycat", At = 19 }, new Move { Name = "Feint Attack", At = 22 }, new Move { Name = "Charm", At = 25 }, new Move { Name = "Wake-Up Slap", At = 28 }, new Move { Name = "Assist", At = 31 }, new Move { Name = "Covet", At = 34 }, new Move { Name = "Heal Bell", At = 37 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Captivate", At = 43 }, new Move { Name = "Play Rough", At = 46 }, },
                    eggMoves = { "Helping Hand", "Uproar", "Fake Tears", "Wish", "Baton Pass", "Tickle", "Last Resort", "Fake Out", "Zen Headbutt", "Sucker Punch", "Mud Bomb", "Simple Beam", "Captivate", "Cosmic Power", },
                },

                new Species() {
                    Name = "Delcatty",
                    moves = { new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Sing", At = 1 }, new Move { Name = "Attract", At = 1 }, new Move { Name = "Double Slap", At = 1 }, },
                },

                new Species() {
                    Name = "Sableye",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Foresight", At = 4 }, new Move { Name = "Night Shade", At = 6 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Fury Swipes", At = 11 }, new Move { Name = "Detect", At = 14 }, new Move { Name = "Shadow Sneak", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Fake Out", At = 21 }, new Move { Name = "Punishment", At = 24 }, new Move { Name = "Knock Off", At = 26 }, new Move { Name = "Shadow Claw", At = 29 }, new Move { Name = "Confuse Ray", At = 31 }, new Move { Name = "Zen Headbutt", At = 34 }, new Move { Name = "Power Gem", At = 36 }, new Move { Name = "Shadow Ball", At = 39 }, new Move { Name = "Foul Play", At = 41 }, new Move { Name = "Quash", At = 44 }, new Move { Name = "Mean Look", At = 46 }, },
                    eggMoves = { "Recover", "Moonlight", "Nasty Plot", "Flatter", "Feint", "Sucker Punch", "Trick", "Captivate", "Mean Look", "Metal Burst", "Imprison", },
                    eggRand = 7,
                    FS = true,
                    oras5 = "Wide Lens",
                },

                new Species() {
                    Name = "Mawile",
                    moves = { new Move { Name = "Play Rough", At = 1 }, new Move { Name = "Iron Head", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Fairy Wind", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Fake Tears", At = 5 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Sweet Scent", At = 13 }, new Move { Name = "Vice Grip", At = 17 }, new Move { Name = "Feint Attack", At = 21 }, new Move { Name = "Baton Pass", At = 25 }, new Move { Name = "Crunch", At = 29 }, new Move { Name = "Iron Defense", At = 33 }, new Move { Name = "Sucker Punch", At = 37 }, new Move { Name = "Stockpile", At = 41 }, new Move { Name = "Swallow", At = 41 }, new Move { Name = "Spit Up", At = 41 }, new Move { Name = "Iron Head", At = 45 }, new Move { Name = "Play Rough", At = 49 }, },
                    eggMoves = { "Poison Fang", "Ancient Power", "Tickle", "Sucker Punch", "Ice Fang", "Fire Fang", "Thunder Fang", "Punishment", "Guard Swap", "Captivate", "Slam", "Metal Burst", "Misty Terrain", "Seismic Toss", },
                    eggRand = 9,
                    FS = true,
                    oras5 = "Iron Ball",
                },

                new Species() {
                    Name = "Aron",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud-Slap", At = 4 }, new Move { Name = "Headbutt", At = 7 }, new Move { Name = "Metal Claw", At = 10 }, new Move { Name = "Rock Tomb", At = 13 }, new Move { Name = "Protect", At = 16 }, new Move { Name = "Roar", At = 19 }, new Move { Name = "Iron Head", At = 22 }, new Move { Name = "Rock Slide", At = 25 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Metal Sound", At = 31 }, new Move { Name = "Iron Tail", At = 34 }, new Move { Name = "Iron Defense", At = 37 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Autotomize", At = 43 }, new Move { Name = "Heavy Slam", At = 46 }, new Move { Name = "Metal Burst", At = 49 }, },
                    eggMoves = { "Endeavor", "Body Slam", "Stomp", "Smelling Salts", "Curse", "Screech", "Iron Head", "Dragon Rush", "Head Smash", "Superpower", "Stealth Rock", "Reversal", },
                    eggRand = 5,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Lairon",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Mud-Slap", At = 4 }, new Move { Name = "Headbutt", At = 7 }, new Move { Name = "Metal Claw", At = 10 }, new Move { Name = "Rock Tomb", At = 13 }, new Move { Name = "Protect", At = 16 }, new Move { Name = "Roar", At = 19 }, new Move { Name = "Iron Head", At = 22 }, new Move { Name = "Rock Slide", At = 25 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Metal Sound", At = 31 }, new Move { Name = "Iron Tail", At = 35 }, new Move { Name = "Iron Defense", At = 39 }, new Move { Name = "Double-Edge", At = 43 }, new Move { Name = "Autotomize", At = 47 }, new Move { Name = "Heavy Slam", At = 51 }, new Move { Name = "Metal Burst", At = 55 }, },
                    eggMoves = { "Endeavor", "Body Slam", "Stomp", "Smelling Salts", "Curse", "Screech", "Iron Head", "Dragon Rush", "Head Smash", "Superpower", "Stealth Rock", "Reversal", },
                    eggRand = 9,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Aggron",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Mud-Slap", At = 4 }, new Move { Name = "Headbutt", At = 7 }, new Move { Name = "Metal Claw", At = 10 }, new Move { Name = "Rock Tomb", At = 13 }, new Move { Name = "Protect", At = 16 }, new Move { Name = "Roar", At = 19 }, new Move { Name = "Iron Head", At = 22 }, new Move { Name = "Rock Slide", At = 25 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Metal Sound", At = 31 }, new Move { Name = "Iron Tail", At = 35 }, new Move { Name = "Iron Defense", At = 39 }, new Move { Name = "Double-Edge", At = 45 }, new Move { Name = "Autotomize", At = 51 }, new Move { Name = "Heavy Slam", At = 57 }, new Move { Name = "Metal Burst", At = 63 }, },
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Meditite",
                    moves = { new Move { Name = "Bide", At = 1 }, new Move { Name = "Meditate", At = 4 }, new Move { Name = "Confusion", At = 7 }, new Move { Name = "Detect", At = 9 }, new Move { Name = "Endure", At = 12 }, new Move { Name = "Feint", At = 15 }, new Move { Name = "Force Palm", At = 17 }, new Move { Name = "Hidden Power", At = 20 }, new Move { Name = "Calm Mind", At = 23 }, new Move { Name = "Mind Reader", At = 25 }, new Move { Name = "High Jump Kick", At = 28 }, new Move { Name = "Psych Up", At = 31 }, new Move { Name = "Acupressure", At = 33 }, new Move { Name = "Power Trick", At = 36 }, new Move { Name = "Reversal", At = 39 }, new Move { Name = "Recover", At = 41 }, new Move { Name = "Counter", At = 44 }, },
                    eggMoves = { "Fire Punch", "Thunder Punch", "Ice Punch", "Foresight", "Fake Out", "Baton Pass", "Dynamic Punch", "Power Swap", "Guard Swap", "Psycho Cut", "Bullet Punch", "Drain Punch", "Secret Power", "Quick Guard", },
                    FS = true,
                },

                new Species() {
                    Name = "Medicham",
                    moves = { new Move { Name = "Zen Headbutt", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Ice Punch", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Meditate", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Detect", At = 1 }, new Move { Name = "Meditate", At = 4 }, new Move { Name = "Confusion", At = 7 }, new Move { Name = "Detect", At = 9 }, new Move { Name = "Endure", At = 12 }, new Move { Name = "Feint", At = 15 }, new Move { Name = "Force Palm", At = 17 }, new Move { Name = "Hidden Power", At = 20 }, new Move { Name = "Calm Mind", At = 23 }, new Move { Name = "Mind Reader", At = 25 }, new Move { Name = "High Jump Kick", At = 28 }, new Move { Name = "Psych Up", At = 31 }, new Move { Name = "Acupressure", At = 33 }, new Move { Name = "Power Trick", At = 36 }, new Move { Name = "Reversal", At = 42 }, new Move { Name = "Recover", At = 47 }, new Move { Name = "Counter", At = 53 }, },
                    eggMoves = { "Fire Punch", "Thunder Punch", "Ice Punch", "Foresight", "Fake Out", "Baton Pass", "Dynamic Punch", "Power Swap", "Guard Swap", "Psycho Cut", "Bullet Punch", "Drain Punch", "Secret Power", "Quick Guard", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Electrike",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Howl", At = 7 }, new Move { Name = "Quick Attack", At = 10 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Odor Sleuth", At = 16 }, new Move { Name = "Thunder Fang", At = 19 }, new Move { Name = "Bite", At = 24 }, new Move { Name = "Discharge", At = 29 }, new Move { Name = "Roar", At = 34 }, new Move { Name = "Wild Charge", At = 39 }, new Move { Name = "Charge", At = 44 }, new Move { Name = "Thunder", At = 49 }, },
                    eggMoves = { "Crunch", "Headbutt", "Uproar", "Curse", "Swift", "Discharge", "Ice Fang", "Fire Fang", "Thunder Fang", "Switcheroo", "Electro Ball", "Shock Wave", "Flame Burst", "Eerie Impulse", },
                },

                new Species() {
                    Name = "Manectric",
                    moves = { new Move { Name = "Electric Terrain", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Howl", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Howl", At = 7 }, new Move { Name = "Quick Attack", At = 10 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Odor Sleuth", At = 16 }, new Move { Name = "Thunder Fang", At = 19 }, new Move { Name = "Bite", At = 24 }, new Move { Name = "Discharge", At = 30 }, new Move { Name = "Roar", At = 36 }, new Move { Name = "Wild Charge", At = 42 }, new Move { Name = "Charge", At = 48 }, new Move { Name = "Thunder", At = 54 }, new Move { Name = "Electric Terrain", At = 60 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Plusle",
                    moves = { new Move { Name = "Nuzzle", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Helping Hand", At = 4 }, new Move { Name = "Spark", At = 7 }, new Move { Name = "Encore", At = 10 }, new Move { Name = "Bestow", At = 13 }, new Move { Name = "Swift", At = 16 }, new Move { Name = "Electro Ball", At = 19 }, new Move { Name = "Copycat", At = 22 }, new Move { Name = "Charm", At = 25 }, new Move { Name = "Charge", At = 28 }, new Move { Name = "Discharge", At = 31 }, new Move { Name = "Baton Pass", At = 34 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Last Resort", At = 40 }, new Move { Name = "Thunder", At = 43 }, new Move { Name = "Nasty Plot", At = 46 }, new Move { Name = "Entrainment", At = 49 }, },
                    eggMoves = { "Wish", "Sing", "Sweet Kiss", "Discharge", "Lucky Chant", "Charm", "Fake Tears", },
                    oras5 = "Cell Battery",
                },

                new Species() {
                    Name = "Minun",
                    moves = { new Move { Name = "Nuzzle", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Helping Hand", At = 4 }, new Move { Name = "Spark", At = 7 }, new Move { Name = "Encore", At = 10 }, new Move { Name = "Switcheroo", At = 13 }, new Move { Name = "Swift", At = 16 }, new Move { Name = "Electro Ball", At = 19 }, new Move { Name = "Copycat", At = 22 }, new Move { Name = "Fake Tears", At = 25 }, new Move { Name = "Charge", At = 28 }, new Move { Name = "Discharge", At = 31 }, new Move { Name = "Baton Pass", At = 34 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Trump Card", At = 40 }, new Move { Name = "Thunder", At = 43 }, new Move { Name = "Nasty Plot", At = 46 }, new Move { Name = "Entrainment", At = 49 }, },
                    eggMoves = { "Wish", "Sing", "Sweet Kiss", "Discharge", "Lucky Chant", "Charm", "Fake Tears", },
                    oras5 = "Cell Battery",
                },

                new Species() {
                    Name = "Volbeat",
                    moves = { new Move { Name = "Flash", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Double Team", At = 5 }, new Move { Name = "Confuse Ray", At = 8 }, new Move { Name = "Quick Attack", At = 12 }, new Move { Name = "Struggle Bug", At = 15 }, new Move { Name = "Moonlight", At = 19 }, new Move { Name = "Tail Glow", At = 22 }, new Move { Name = "Signal Beam", At = 26 }, new Move { Name = "Protect", At = 29 }, new Move { Name = "Zen Headbutt", At = 33 }, new Move { Name = "Helping Hand", At = 36 }, new Move { Name = "Bug Buzz", At = 40 }, new Move { Name = "Play Rough", At = 43 }, new Move { Name = "Double-Edge", At = 47 }, },
                    eggMoves = { "Baton Pass", "Silver Wind", "Trick", "Encore", "Bug Buzz", "Dizzy Punch", "Seismic Toss", },
                    FS = true,
                    oras5 = "Bright Powder",
                },

                new Species() {
                    Name = "Illumise",
                    moves = { new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sweet Scent", At = 5 }, new Move { Name = "Charm", At = 9 }, new Move { Name = "Quick Attack", At = 12 }, new Move { Name = "Struggle Bug", At = 15 }, new Move { Name = "Moonlight", At = 19 }, new Move { Name = "Wish", At = 22 }, new Move { Name = "Encore", At = 26 }, new Move { Name = "Flatter", At = 29 }, new Move { Name = "Zen Headbutt", At = 33 }, new Move { Name = "Helping Hand", At = 36 }, new Move { Name = "Bug Buzz", At = 40 }, new Move { Name = "Play Rough", At = 43 }, new Move { Name = "Covet", At = 47 }, },
                    eggMoves = { "Baton Pass", "Silver Wind", "Growth", "Encore", "Bug Buzz", "Captivate", "Fake Tears", "Confuse Ray", },
                    FS = true,
                    oras5 = "Bright Powder",
                },

                new Species() {
                    Name = "Roselia",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 4 }, new Move { Name = "Poison Sting", At = 7 }, new Move { Name = "Stun Spore", At = 10 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Leech Seed", At = 16 }, new Move { Name = "Magical Leaf", At = 19 }, new Move { Name = "Grass Whistle", At = 22 }, new Move { Name = "Giga Drain", At = 25 }, new Move { Name = "Toxic Spikes", At = 28 }, new Move { Name = "Sweet Scent", At = 31 }, new Move { Name = "Ingrain", At = 34 }, new Move { Name = "Petal Blizzard", At = 37 }, new Move { Name = "Toxic", At = 40 }, new Move { Name = "Aromatherapy", At = 43 }, new Move { Name = "Synthesis", At = 46 }, new Move { Name = "Petal Dance", At = 50 }, },
                  //eggMoves = { "Spikes", "Synthesis", "Pin Missile", "Cotton Spore", "Sleep Powder", "Razor Leaf", "Mind Reader", "Leaf Storm", "Seed Bomb", "Giga Drain", "Natural Gift", "Grass Whistle", "Bullet Seed", },
                    eggMoves = { "Spikes", "Synthesis", "Pin Missile", "Cotton Spore", "Sleep Powder", "Razor Leaf", "Mind Reader", "Leaf Storm", "Extrasensory", "Seed Bomb", "Giga Drain", "Natural Gift", "Grass Whistle", },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Gulpin",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Yawn", At = 5 }, new Move { Name = "Poison Gas", At = 8 }, new Move { Name = "Sludge", At = 10 }, new Move { Name = "Amnesia", At = 12 }, new Move { Name = "Acid Spray", At = 17 }, new Move { Name = "Encore", At = 20 }, new Move { Name = "Toxic", At = 25 }, new Move { Name = "Stockpile", At = 28 }, new Move { Name = "Spit Up", At = 28 }, new Move { Name = "Swallow", At = 28 }, new Move { Name = "Sludge Bomb", At = 33 }, new Move { Name = "Gastro Acid", At = 36 }, new Move { Name = "Belch", At = 41 }, new Move { Name = "Wring Out", At = 44 }, new Move { Name = "Gunk Shot", At = 49 }, },
                    eggMoves = { "Acid Armor", "Smog", "Pain Split", "Curse", "Destiny Bond", "Mud-Slap", "Gunk Shot", "Venom Drench", },
                    xy5 = "Oran Berry",
                    oras5 = "Sitrus Berry",
                    oras50 = "Oran Berry",
                },

                new Species() {
                    Name = "Swalot",
                    moves = { new Move { Name = "Gunk Shot", At = 1 }, new Move { Name = "Wring Out", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Sludge", At = 1 }, new Move { Name = "Yawn", At = 5 }, new Move { Name = "Poison Gas", At = 8 }, new Move { Name = "Sludge", At = 10 }, new Move { Name = "Amnesia", At = 12 }, new Move { Name = "Acid Spray", At = 17 }, new Move { Name = "Encore", At = 20 }, new Move { Name = "Toxic", At = 25 }, new Move { Name = "Body Slam", At = 26 }, new Move { Name = "Stockpile", At = 30 }, new Move { Name = "Spit Up", At = 30 }, new Move { Name = "Swallow", At = 30 }, new Move { Name = "Sludge Bomb", At = 37 }, new Move { Name = "Gastro Acid", At = 42 }, new Move { Name = "Belch", At = 49 }, new Move { Name = "Wring Out", At = 54 }, new Move { Name = "Gunk Shot", At = 61 }, },
                    FS = true,
                    xy5 = "Oran Berry",
                    oras5 = "Sitrus Berry",
                    oras50 = "Oran Berry",
                },

                new Species() {
                    Name = "Carvanha",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Rage", At = 4 }, new Move { Name = "Focus Energy", At = 8 }, new Move { Name = "Aqua Jet", At = 11 }, new Move { Name = "Assurance", At = 15 }, new Move { Name = "Screech", At = 18 }, new Move { Name = "Swagger", At = 22 }, new Move { Name = "Ice Fang", At = 25 }, new Move { Name = "Scary Face", At = 29 }, new Move { Name = "Poison Fang", At = 32 }, new Move { Name = "Crunch", At = 36 }, new Move { Name = "Agility", At = 39 }, new Move { Name = "Take Down", At = 43 }, },
                    eggMoves = { "Hydro Pump", "Double-Edge", "Thrash", "Ancient Power", "Swift", "Brine", "Destiny Bond", },
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Sharpedo",
                    moves = { new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Feint", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Rage", At = 4 }, new Move { Name = "Focus Energy", At = 8 }, new Move { Name = "Aqua Jet", At = 11 }, new Move { Name = "Assurance", At = 15 }, new Move { Name = "Screech", At = 18 }, new Move { Name = "Swagger", At = 22 }, new Move { Name = "Ice Fang", At = 25 }, new Move { Name = "Scary Face", At = 29 }, new Move { Name = "Slash", At = 30 }, new Move { Name = "Poison Fang", At = 34 }, new Move { Name = "Crunch", At = 40 }, new Move { Name = "Agility", At = 45 }, new Move { Name = "Skull Bash", At = 51 }, new Move { Name = "Taunt", At = 56 }, new Move { Name = "Night Slash", At = 62 }, },
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Wailmer",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Whirlpool", At = 13 }, new Move { Name = "Astonish", At = 16 }, new Move { Name = "Water Pulse", At = 19 }, new Move { Name = "Mist", At = 22 }, new Move { Name = "Brine", At = 25 }, new Move { Name = "Rest", At = 29 }, new Move { Name = "Dive", At = 33 }, new Move { Name = "Amnesia", At = 37 }, new Move { Name = "Water Spout", At = 41 }, new Move { Name = "Bounce", At = 45 }, new Move { Name = "Hydro Pump", At = 49 }, new Move { Name = "Heavy Slam", At = 53 }, },
                    eggMoves = { "Double-Edge", "Thrash", "Snore", "Sleep Talk", "Curse", "Fissure", "Tickle", "Defense Curl", "Body Slam", "Aqua Ring", "Soak", "Zen Headbutt", "Clear Smog", },
                },

                new Species() {
                    Name = "Wailord",
                    moves = { new Move { Name = "Heavy Slam", At = 1 }, new Move { Name = "Splash", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Rollout", At = 10 }, new Move { Name = "Whirlpool", At = 13 }, new Move { Name = "Astonish", At = 16 }, new Move { Name = "Water Pulse", At = 19 }, new Move { Name = "Mist", At = 22 }, new Move { Name = "Rest", At = 25 }, new Move { Name = "Brine", At = 29 }, new Move { Name = "Water Spout", At = 33 }, new Move { Name = "Amnesia", At = 37 }, new Move { Name = "Dive", At = 44 }, new Move { Name = "Bounce", At = 51 }, new Move { Name = "Hydro Pump", At = 58 }, new Move { Name = "Heavy Slam", At = 65 }, },
                },

                new Species() {
                    Name = "Numel",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Focus Energy", At = 8 }, new Move { Name = "Magnitude", At = 12 }, new Move { Name = "Flame Burst", At = 15 }, new Move { Name = "Amnesia", At = 19 }, new Move { Name = "Lava Plume", At = 22 }, new Move { Name = "Earth Power", At = 26 }, new Move { Name = "Curse", At = 29 }, new Move { Name = "Take Down", At = 31 }, new Move { Name = "Yawn", At = 36 }, new Move { Name = "Earthquake", At = 40 }, new Move { Name = "Flamethrower", At = 43 }, new Move { Name = "Double-Edge", At = 47 }, },
                    eggMoves = { "Howl", "Scary Face", "Body Slam", "Rollout", "Defense Curl", "Stomp", "Yawn", "Ancient Power", "Mud Bomb", "Heat Wave", "Stockpile", "Swallow", "Spit Up", "Endure", "Iron Head", "Growth", },
                },

                new Species() {
                    Name = "Camerupt",
                    moves = { new Move { Name = "Fissure", At = 1 }, new Move { Name = "Eruption", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Focus Energy", At = 8 }, new Move { Name = "Magnitude", At = 12 }, new Move { Name = "Flame Burst", At = 15 }, new Move { Name = "Amnesia", At = 19 }, new Move { Name = "Lava Plume", At = 22 }, new Move { Name = "Earth Power", At = 26 }, new Move { Name = "Curse", At = 29 }, new Move { Name = "Take Down", At = 31 }, new Move { Name = "Rock Slide", At = 33 }, new Move { Name = "Yawn", At = 39 }, new Move { Name = "Earthquake", At = 46 }, new Move { Name = "Eruption", At = 52 }, new Move { Name = "Fissure", At = 59 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Torkoal",
                    moves = { new Move { Name = "Ember", At = 1 }, new Move { Name = "Smog", At = 4 }, new Move { Name = "Withdraw", At = 7 }, new Move { Name = "Rapid Spin", At = 10 }, new Move { Name = "Fire Spin", At = 13 }, new Move { Name = "Smokescreen", At = 15 }, new Move { Name = "Flame Wheel", At = 18 }, new Move { Name = "Curse", At = 22 }, new Move { Name = "Lava Plume", At = 25 }, new Move { Name = "Body Slam", At = 27 }, new Move { Name = "Protect", At = 30 }, new Move { Name = "Flamethrower", At = 34 }, new Move { Name = "Iron Defense", At = 38 }, new Move { Name = "Amnesia", At = 40 }, new Move { Name = "Flail", At = 42 }, new Move { Name = "Heat Wave", At = 45 }, new Move { Name = "Shell Smash", At = 47 }, new Move { Name = "Inferno", At = 50 }, },
                    eggMoves = { "Eruption", "Endure", "Sleep Talk", "Yawn", "Fissure", "Skull Bash", "Flame Burst", "Clear Smog", "Superpower", },
                    eggRand = 7,
                    item5 = "Charcoal",
                },

                new Species() {
                    Name = "Spoink",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Psywave", At = 7 }, new Move { Name = "Odor Sleuth", At = 10 }, new Move { Name = "Psybeam", At = 14 }, new Move { Name = "Psych Up", At = 15 }, new Move { Name = "Confuse Ray", At = 18 }, new Move { Name = "Magic Coat", At = 21 }, new Move { Name = "Zen Headbutt", At = 26 }, new Move { Name = "Power Gem", At = 29 }, new Move { Name = "Rest", At = 29 }, new Move { Name = "Snore", At = 33 }, new Move { Name = "Psyshock", At = 38 }, new Move { Name = "Payback", At = 40 }, new Move { Name = "Psychic", At = 44 }, new Move { Name = "Bounce", At = 50 }, },
                    eggMoves = { "Future Sight", "Extrasensory", "Trick", "Zen Headbutt", "Amnesia", "Mirror Coat", "Skill Swap", "Whirlwind", "Lucky Chant", "Endure", "Simple Beam", },
                },

                new Species() {
                    Name = "Grumpig",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Psywave", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Psybeam", At = 1 }, new Move { Name = "Psywave", At = 7 }, new Move { Name = "Odor Sleuth", At = 10 }, new Move { Name = "Psybeam", At = 14 }, new Move { Name = "Psych Up", At = 15 }, new Move { Name = "Confuse Ray", At = 18 }, new Move { Name = "Magic Coat", At = 21 }, new Move { Name = "Zen Headbutt", At = 26 }, new Move { Name = "Power Gem", At = 29 }, new Move { Name = "Teeter Dance", At = 32 }, new Move { Name = "Rest", At = 35 }, new Move { Name = "Snore", At = 35 }, new Move { Name = "Psyshock", At = 42 }, new Move { Name = "Payback", At = 46 }, new Move { Name = "Psychic", At = 52 }, new Move { Name = "Bounce", At = 60 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Spinda",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Copycat", At = 5 }, new Move { Name = "Feint Attack", At = 10 }, new Move { Name = "Psybeam", At = 14 }, new Move { Name = "Hypnosis", At = 19 }, new Move { Name = "Dizzy Punch", At = 23 }, new Move { Name = "Sucker Punch", At = 28 }, new Move { Name = "Teeter Dance", At = 32 }, new Move { Name = "Uproar", At = 37 }, new Move { Name = "Psych Up", At = 41 }, new Move { Name = "Double-Edge", At = 46 }, new Move { Name = "Flail", At = 50 }, new Move { Name = "Thrash", At = 55 }, },
                    eggMoves = { "Encore", "Assist", "Disable", "Baton Pass", "Wish", "Trick", "Smelling Salts", "Fake Out", "Role Play", "Psycho Cut", "Fake Tears", "Rapid Spin", "Icy Wind", "Water Pulse", "Psycho Shift", "Guard Split", },
                },

                new Species() {
                    Name = "Trapinch",
                    moves = { new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Feint Attack", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Mud-Slap", At = 5 }, new Move { Name = "Bulldoze", At = 8 }, new Move { Name = "Sand Tomb", At = 12 }, new Move { Name = "Rock Slide", At = 15 }, new Move { Name = "Dig", At = 19 }, new Move { Name = "Crunch", At = 22 }, new Move { Name = "Earth Power", At = 26 }, new Move { Name = "Feint", At = 29 }, new Move { Name = "Earthquake", At = 33 }, new Move { Name = "Sandstorm", At = 36 }, new Move { Name = "Superpower", At = 40 }, new Move { Name = "Hyper Beam", At = 43 }, new Move { Name = "Fissure", At = 47 }, },
                    eggMoves = { "Focus Energy", "Quick Attack", "Gust", "Flail", "Fury Cutter", "Mud Shot", "Endure", "Earth Power", "Bug Bite", "Signal Beam", },
                    eggRand = 9,
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Vibrava",
                    moves = { new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Feint Attack", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Mud-Slap", At = 5 }, new Move { Name = "Bulldoze", At = 8 }, new Move { Name = "Sand Tomb", At = 12 }, new Move { Name = "Rock Slide", At = 15 }, new Move { Name = "Supersonic", At = 19 }, new Move { Name = "Screech", At = 22 }, new Move { Name = "Earth Power", At = 26 }, new Move { Name = "Bug Buzz", At = 29 }, new Move { Name = "Earthquake", At = 33 }, new Move { Name = "Dragon Breath", At = 35 }, new Move { Name = "Sandstorm", At = 36 }, new Move { Name = "Uproar", At = 40 }, new Move { Name = "Hyper Beam", At = 43 }, new Move { Name = "Boomburst", At = 47 }, },
                },

                new Species() {
                    Name = "Flygon",
                    moves = { new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Feint Attack", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Mud-Slap", At = 5 }, new Move { Name = "Bulldoze", At = 8 }, new Move { Name = "Sand Tomb", At = 12 }, new Move { Name = "Rock Slide", At = 15 }, new Move { Name = "Supersonic", At = 19 }, new Move { Name = "Screech", At = 22 }, new Move { Name = "Earth Power", At = 26 }, new Move { Name = "Dragon Tail", At = 29 }, new Move { Name = "Earthquake", At = 33 }, new Move { Name = "Dragon Breath", At = 35 }, new Move { Name = "Sandstorm", At = 36 }, new Move { Name = "Uproar", At = 40 }, new Move { Name = "Hyper Beam", At = 43 }, new Move { Name = "Dragon Claw", At = 45 }, new Move { Name = "Dragon Rush", At = 47 }, },
                },

                new Species() {
                    Name = "Cacnea",
                    moves = { new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 4 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Leech Seed", At = 10 }, new Move { Name = "Sand Attack", At = 13 }, new Move { Name = "Needle Arm", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Ingrain", At = 22 }, new Move { Name = "Payback", At = 26 }, new Move { Name = "Spikes", At = 30 }, new Move { Name = "Sucker Punch", At = 34 }, new Move { Name = "Pin Missile", At = 38 }, new Move { Name = "Energy Ball", At = 42 }, new Move { Name = "Cotton Spore", At = 46 }, new Move { Name = "Sandstorm", At = 50 }, new Move { Name = "Destiny Bond", At = 54 }, },
                    eggMoves = { "Grass Whistle", "Acid", "Teeter Dance", "Dynamic Punch", "Counter", "Low Kick", "Smelling Salts", "Magical Leaf", "Seed Bomb", "Nasty Plot", "Disable", "Block", "Worry Seed", "Switcheroo", "Fell Stinger", "Belch", "Rototiller", },
                    eggRand = 5,
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Cacturne",
                    moves = { new Move { Name = "Destiny Bond", At = 1 }, new Move { Name = "Revenge", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Absorb", At = 4 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Leech Seed", At = 10 }, new Move { Name = "Sand Attack", At = 13 }, new Move { Name = "Needle Arm", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Ingrain", At = 22 }, new Move { Name = "Payback", At = 26 }, new Move { Name = "Spikes", At = 30 }, new Move { Name = "Spiky Shield", At = 32 }, new Move { Name = "Sucker Punch", At = 35 }, new Move { Name = "Pin Missile", At = 38 }, new Move { Name = "Energy Ball", At = 44 }, new Move { Name = "Cotton Spore", At = 49 }, new Move { Name = "Sandstorm", At = 54 }, new Move { Name = "Destiny Bond", At = 59 }, },
                    FS = true,
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Swablu",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Astonish", At = 3 }, new Move { Name = "Sing", At = 5 }, new Move { Name = "Fury Attack", At = 7 }, new Move { Name = "Safeguard", At = 9 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Mist", At = 14 }, new Move { Name = "Round", At = 17 }, new Move { Name = "Natural Gift", At = 20 }, new Move { Name = "Take Down", At = 23 }, new Move { Name = "Refresh", At = 26 }, new Move { Name = "Mirror Move", At = 30 }, new Move { Name = "Cotton Guard", At = 34 }, new Move { Name = "Dragon Pulse", At = 38 }, new Move { Name = "Perish Song", At = 42 }, new Move { Name = "Moonblast", At = 46 }, },
                    eggMoves = { "Agility", "Haze", "Pursuit", "Rage", "Feather Dance", "Dragon Rush", "Power Swap", "Roost", "Hyper Voice", "Steel Wing", },
                },

                new Species() {
                    Name = "Altaria",
                    moves = { new Move { Name = "Sky Attack", At = 1 }, new Move { Name = "Pluck", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Sing", At = 1 }, new Move { Name = "Astonish", At = 3 }, new Move { Name = "Sing", At = 5 }, new Move { Name = "Fury Attack", At = 7 }, new Move { Name = "Safeguard", At = 9 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Mist", At = 14 }, new Move { Name = "Round", At = 17 }, new Move { Name = "Natural Gift", At = 20 }, new Move { Name = "Take Down", At = 23 }, new Move { Name = "Refresh", At = 26 }, new Move { Name = "Dragon Dance", At = 30 }, new Move { Name = "Cotton Guard", At = 34 }, new Move { Name = "Dragon Breath", At = 35 }, new Move { Name = "Dragon Pulse", At = 40 }, new Move { Name = "Perish Song", At = 46 }, new Move { Name = "Moonblast", At = 52 }, new Move { Name = "Sky Attack", At = 59 }, },
                },

                new Species() {
                    Name = "Zangoose",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Fury Cutter", At = 8 }, new Move { Name = "Pursuit", At = 12 }, new Move { Name = "Hone Claws", At = 15 }, new Move { Name = "Slash", At = 19 }, new Move { Name = "Revenge", At = 22 }, new Move { Name = "Crush Claw", At = 26 }, new Move { Name = "False Swipe", At = 29 }, new Move { Name = "Embargo", At = 33 }, new Move { Name = "Detect", At = 36 }, new Move { Name = "X-Scissor", At = 40 }, new Move { Name = "Taunt", At = 43 }, new Move { Name = "Swords Dance", At = 47 }, new Move { Name = "Close Combat", At = 50 }, },
                    eggMoves = { "Flail", "Double Kick", "Razor Wind", "Counter", "Curse", "Fury Swipes", "Night Slash", "Metal Claw", "Double Hit", "Disable", "Iron Tail", "Final Gambit", "Feint", "Quick Guard", },
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Seviper",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Swagger", At = 1 }, new Move { Name = "Bite", At = 4 }, new Move { Name = "Lick", At = 7 }, new Move { Name = "Poison Tail", At = 10 }, new Move { Name = "Screech", At = 13 }, new Move { Name = "Venoshock", At = 16 }, new Move { Name = "Glare", At = 19 }, new Move { Name = "Poison Fang", At = 22 }, new Move { Name = "Venom Drench", At = 25 }, new Move { Name = "Night Slash", At = 28 }, new Move { Name = "Gastro Acid", At = 31 }, new Move { Name = "Poison Jab", At = 34 }, new Move { Name = "Haze", At = 37 }, new Move { Name = "Crunch", At = 40 }, new Move { Name = "Belch", At = 43 }, new Move { Name = "Coil", At = 46 }, new Move { Name = "Wring Out", At = 49 }, },
                    eggMoves = { "Stockpile", "Swallow", "Spit Up", "Body Slam", "Scary Face", "Assurance", "Night Slash", "Switcheroo", "Iron Tail", "Wring Out", "Punishment", "Final Gambit", },
                    FS = true,
                    oras5 = "Shed Shell",
                    xy100 = "Persim Berry",
                },

                new Species() {
                    Name = "Lunatone",
                    moves = { new Move { Name = "Moonblast", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Hypnosis", At = 5 }, new Move { Name = "Rock Polish", At = 9 }, new Move { Name = "Psywave", At = 13 }, new Move { Name = "Embargo", At = 17 }, new Move { Name = "Rock Slide", At = 21 }, new Move { Name = "Cosmic Power", At = 25 }, new Move { Name = "Psychic", At = 29 }, new Move { Name = "Heal Block", At = 33 }, new Move { Name = "Stone Edge", At = 37 }, new Move { Name = "Future Sight", At = 41 }, new Move { Name = "Explosion", At = 45 }, new Move { Name = "Magic Room", At = 49 }, },
                    item5 = "Moon Stone",
                    oras50 = "Stardust",
                },

                new Species() {
                    Name = "Solrock",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Fire Spin", At = 5 }, new Move { Name = "Rock Polish", At = 9 }, new Move { Name = "Psywave", At = 13 }, new Move { Name = "Embargo", At = 17 }, new Move { Name = "Rock Slide", At = 21 }, new Move { Name = "Cosmic Power", At = 25 }, new Move { Name = "Psychic", At = 29 }, new Move { Name = "Heal Block", At = 33 }, new Move { Name = "Stone Edge", At = 37 }, new Move { Name = "Solar Beam", At = 41 }, new Move { Name = "Explosion", At = 45 }, new Move { Name = "Wonder Room", At = 49 }, },
                    item5 = "Sun Stone",
                    oras50 = "Stardust",
                },

                new Species() {
                    Name = "Barboach",
                    moves = { new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 6 }, new Move { Name = "Water Sport", At = 6 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Mud Bomb", At = 13 }, new Move { Name = "Amnesia", At = 15 }, new Move { Name = "Water Pulse", At = 17 }, new Move { Name = "Magnitude", At = 20 }, new Move { Name = "Rest", At = 25 }, new Move { Name = "Snore", At = 25 }, new Move { Name = "Aqua Tail", At = 28 }, new Move { Name = "Earthquake", At = 32 }, new Move { Name = "Muddy Water", At = 35 }, new Move { Name = "Future Sight", At = 39 }, new Move { Name = "Fissure", At = 44 }, },
                    eggMoves = { "Thrash", "Whirlpool", "Spark", "Hydro Pump", "Flail", "Take Down", "Dragon Dance", "Earth Power", "Mud Shot", "Muddy Water", },
                },

                new Species() {
                    Name = "Whiscash",
                    moves = { new Move { Name = "Tickle", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud Sport", At = 6 }, new Move { Name = "Water Sport", At = 6 }, new Move { Name = "Water Gun", At = 9 }, new Move { Name = "Mud Bomb", At = 13 }, new Move { Name = "Amnesia", At = 15 }, new Move { Name = "Water Pulse", At = 17 }, new Move { Name = "Magnitude", At = 20 }, new Move { Name = "Rest", At = 25 }, new Move { Name = "Snore", At = 25 }, new Move { Name = "Aqua Tail", At = 28 }, new Move { Name = "Zen Headbutt", At = 30 }, new Move { Name = "Earthquake", At = 34 }, new Move { Name = "Muddy Water", At = 39 }, new Move { Name = "Future Sight", At = 45 }, new Move { Name = "Fissure", At = 52 }, },
                },

                new Species() {
                    Name = "Corphish",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Harden", At = 5 }, new Move { Name = "Vice Grip", At = 7 }, new Move { Name = "Leer", At = 10 }, new Move { Name = "Bubble Beam", At = 14 }, new Move { Name = "Protect", At = 17 }, new Move { Name = "Double Hit", At = 20 }, new Move { Name = "Knock Off", At = 23 }, new Move { Name = "Night Slash", At = 26 }, new Move { Name = "Razor Shell", At = 31 }, new Move { Name = "Taunt", At = 34 }, new Move { Name = "Swords Dance", At = 37 }, new Move { Name = "Crunch", At = 39 }, new Move { Name = "Crabhammer", At = 43 }, new Move { Name = "Guillotine", At = 48 }, },
                    eggMoves = { "Mud Sport", "Endeavor", "Body Slam", "Ancient Power", "Knock Off", "Superpower", "Metal Claw", "Dragon Dance", "Trump Card", "Chip Away", "Double-Edge", "Aqua Jet", "Switcheroo", },
                },

                new Species() {
                    Name = "Crawdaunt",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Harden", At = 5 }, new Move { Name = "Vice Grip", At = 7 }, new Move { Name = "Leer", At = 10 }, new Move { Name = "Bubble Beam", At = 14 }, new Move { Name = "Protect", At = 17 }, new Move { Name = "Double Hit", At = 20 }, new Move { Name = "Knock Off", At = 23 }, new Move { Name = "Night Slash", At = 26 }, new Move { Name = "Swift", At = 30 }, new Move { Name = "Razor Shell", At = 32 }, new Move { Name = "Taunt", At = 36 }, new Move { Name = "Swords Dance", At = 40 }, new Move { Name = "Crunch", At = 43 }, new Move { Name = "Crabhammer", At = 48 }, new Move { Name = "Guillotine", At = 54 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Baltoy",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Rapid Spin", At = 4 }, new Move { Name = "Mud-Slap", At = 7 }, new Move { Name = "Heal Block", At = 10 }, new Move { Name = "Rock Tomb", At = 13 }, new Move { Name = "Psybeam", At = 16 }, new Move { Name = "Ancient Power", At = 19 }, new Move { Name = "Cosmic Power", At = 22 }, new Move { Name = "Power Trick", At = 25 }, new Move { Name = "Self-Destruct", At = 28 }, new Move { Name = "Extrasensory", At = 31 }, new Move { Name = "Guard Split", At = 34 }, new Move { Name = "Power Split", At = 34 }, new Move { Name = "Earth Power", At = 37 }, new Move { Name = "Sandstorm", At = 40 }, new Move { Name = "Imprison", At = 43 }, new Move { Name = "Explosion", At = 46 }, },
                    oras5 = "Light Clay",
                },

                new Species() {
                    Name = "Claydol",
                    moves = { new Move { Name = "Teleport", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Rapid Spin", At = 1 }, new Move { Name = "Rapid Spin", At = 4 }, new Move { Name = "Mud-Slap", At = 7 }, new Move { Name = "Heal Block", At = 10 }, new Move { Name = "Rock Tomb", At = 13 }, new Move { Name = "Psybeam", At = 16 }, new Move { Name = "Ancient Power", At = 19 }, new Move { Name = "Cosmic Power", At = 22 }, new Move { Name = "Power Trick", At = 25 }, new Move { Name = "Self-Destruct", At = 28 }, new Move { Name = "Extrasensory", At = 31 }, new Move { Name = "Guard Split", At = 34 }, new Move { Name = "Power Split", At = 34 }, new Move { Name = "Hyper Beam", At = 36 }, new Move { Name = "Earth Power", At = 40 }, new Move { Name = "Sandstorm", At = 46 }, new Move { Name = "Imprison", At = 52 }, new Move { Name = "Explosion", At = 58 }, },
                    oras5 = "Light Clay",
                },

                new Species() {
                    Name = "Lileep",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Acid", At = 5 }, new Move { Name = "Ingrain", At = 9 }, new Move { Name = "Confuse Ray", At = 13 }, new Move { Name = "Ancient Power", At = 17 }, new Move { Name = "Brine", At = 21 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Gastro Acid", At = 31 }, new Move { Name = "Amnesia", At = 36 }, new Move { Name = "Energy Ball", At = 41 }, new Move { Name = "Stockpile", At = 46 }, new Move { Name = "Spit Up", At = 46 }, new Move { Name = "Swallow", At = 46 }, new Move { Name = "Wring Out", At = 52 }, },
                    eggMoves = { "Barrier", "Recover", "Mirror Coat", "Wring Out", "Tickle", "Curse", "Mega Drain", "Endure", "Stealth Rock", },
                    item5 = "Big Root",
                },

                new Species() {
                    Name = "Cradily",
                    moves = { new Move { Name = "Wring Out", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Acid", At = 1 }, new Move { Name = "Ingrain", At = 1 }, new Move { Name = "Acid", At = 5 }, new Move { Name = "Ingrain", At = 9 }, new Move { Name = "Confuse Ray", At = 13 }, new Move { Name = "Ancient Power", At = 17 }, new Move { Name = "Brine", At = 21 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Gastro Acid", At = 31 }, new Move { Name = "Amnesia", At = 36 }, new Move { Name = "Energy Ball", At = 44 }, new Move { Name = "Stockpile", At = 52 }, new Move { Name = "Spit Up", At = 52 }, new Move { Name = "Swallow", At = 52 }, new Move { Name = "Wring Out", At = 61 }, },
                    item5 = "Big Root",
                },

                new Species() {
                    Name = "Anorith",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud Sport", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Fury Cutter", At = 10 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Metal Claw", At = 17 }, new Move { Name = "Ancient Power", At = 21 }, new Move { Name = "Bug Bite", At = 25 }, new Move { Name = "Brine", At = 29 }, new Move { Name = "Slash", At = 34 }, new Move { Name = "Crush Claw", At = 39 }, new Move { Name = "X-Scissor", At = 44 }, new Move { Name = "Protect", At = 49 }, new Move { Name = "Rock Blast", At = 55 }, },
                    eggMoves = { "Rapid Spin", "Knock Off", "Screech", "Sand Attack", "Cross Poison", "Curse", "Iron Defense", "Water Pulse", "Aqua Jet", },
                },

                new Species() {
                    Name = "Armaldo",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud Sport", At = 4 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Fury Cutter", At = 10 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Metal Claw", At = 17 }, new Move { Name = "Ancient Power", At = 21 }, new Move { Name = "Slash", At = 25 }, new Move { Name = "Brine", At = 29 }, new Move { Name = "Slash", At = 34 }, new Move { Name = "Crush Claw", At = 39 }, new Move { Name = "X-Scissor", At = 46 }, new Move { Name = "Protect", At = 53 }, new Move { Name = "Rock Blast", At = 61 }, },
                },

                new Species() {
                    Name = "Feebas",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Tackle", At = 15 }, new Move { Name = "Flail", At = 30 }, },
                    eggMoves = { "Mirror Coat", "Dragon Breath", "Mud Sport", "Hypnosis", "Confuse Ray", "Mist", "Haze", "Tickle", "Brine", "Iron Tail", "Dragon Pulse", "Captivate", },
                },

                new Species() {
                    Name = "Milotic",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 4 }, new Move { Name = "Refresh", At = 7 }, new Move { Name = "Disarming Voice", At = 11 }, new Move { Name = "Twister", At = 14 }, new Move { Name = "Water Pulse", At = 17 }, new Move { Name = "Aqua Ring", At = 21 }, new Move { Name = "Captivate", At = 24 }, new Move { Name = "Dragon Tail", At = 27 }, new Move { Name = "Recover", At = 31 }, new Move { Name = "Aqua Tail", At = 34 }, new Move { Name = "Attract", At = 37 }, new Move { Name = "Safeguard", At = 41 }, new Move { Name = "Coil", At = 44 }, new Move { Name = "Hydro Pump", At = 47 }, new Move { Name = "Rain Dance", At = 51 }, },
                },

                new Species() {
                    Name = "Castform",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Water Gun", At = 10 }, new Move { Name = "Ember", At = 10 }, new Move { Name = "Powder Snow", At = 10 }, new Move { Name = "Headbutt", At = 15 }, new Move { Name = "Rain Dance", At = 20 }, new Move { Name = "Sunny Day", At = 20 }, new Move { Name = "Hail", At = 20 }, new Move { Name = "Weather Ball", At = 25 }, new Move { Name = "Hydro Pump", At = 35 }, new Move { Name = "Fire Blast", At = 35 }, new Move { Name = "Blizzard", At = 35 }, new Move { Name = "Hurricane", At = 45 }, },
                    eggMoves = { "Future Sight", "Lucky Chant", "Disable", "Amnesia", "Ominous Wind", "Hex", "Clear Smog", "Reflect Type", "Guard Swap", "Cosmic Power", },
                    item100 = "Mystic Water",
                },

                new Species() {
                    Name = "Kecleon",
                    moves = { new Move { Name = "Thief", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Bind", At = 4 }, new Move { Name = "Shadow Sneak", At = 7 }, new Move { Name = "Feint", At = 10 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Feint Attack", At = 16 }, new Move { Name = "Psybeam", At = 18 }, new Move { Name = "Ancient Power", At = 21 }, new Move { Name = "Slash", At = 25 }, new Move { Name = "Camouflage", At = 30 }, new Move { Name = "Shadow Claw", At = 33 }, new Move { Name = "Screech", At = 38 }, new Move { Name = "Substitute", At = 42 }, new Move { Name = "Sucker Punch", At = 46 }, new Move { Name = "Synchronoise", At = 50 }, },
                    eggMoves = { "Disable", "Magic Coat", "Trick", "Fake Out", "Nasty Plot", "Dizzy Punch", "Recover", "Skill Swap", "Snatch", "Foul Play", "Camouflage", },
                    FS = true,
                },

                new Species() {
                    Name = "Shuppet",
                    moves = { new Move { Name = "Knock Off", At = 1 }, new Move { Name = "Screech", At = 4 }, new Move { Name = "Night Shade", At = 7 }, new Move { Name = "Spite", At = 10 }, new Move { Name = "Shadow Sneak", At = 13 }, new Move { Name = "Will-O-Wisp", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Hex", At = 22 }, new Move { Name = "Curse", At = 26 }, new Move { Name = "Shadow Ball", At = 30 }, new Move { Name = "Embargo", At = 34 }, new Move { Name = "Sucker Punch", At = 38 }, new Move { Name = "Snatch", At = 42 }, new Move { Name = "Grudge", At = 46 }, new Move { Name = "Trick", At = 50 }, new Move { Name = "Phantom Force", At = 54 }, },
                    eggMoves = { "Disable", "Destiny Bond", "Foresight", "Astonish", "Imprison", "Pursuit", "Shadow Sneak", "Confuse Ray", "Ominous Wind", "Gunk Shot", "Phantom Force", },
                    eggRand = 7,
                    FS = true,
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Banette",
                    moves = { new Move { Name = "Phantom Force", At = 1 }, new Move { Name = "Knock Off", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Spite", At = 1 }, new Move { Name = "Screech", At = 4 }, new Move { Name = "Night Shade", At = 7 }, new Move { Name = "Spite", At = 10 }, new Move { Name = "Shadow Sneak", At = 13 }, new Move { Name = "Will-O-Wisp", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Hex", At = 22 }, new Move { Name = "Curse", At = 26 }, new Move { Name = "Shadow Ball", At = 30 }, new Move { Name = "Embargo", At = 34 }, new Move { Name = "Sucker Punch", At = 40 }, new Move { Name = "Snatch", At = 46 }, new Move { Name = "Grudge", At = 52 }, new Move { Name = "Trick", At = 58 }, new Move { Name = "Phantom Force", At = 64 }, },
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Duskull",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Disable", At = 6 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Foresight", At = 14 }, new Move { Name = "Shadow Sneak", At = 17 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Will-O-Wisp", At = 25 }, new Move { Name = "Confuse Ray", At = 30 }, new Move { Name = "Curse", At = 33 }, new Move { Name = "Hex", At = 38 }, new Move { Name = "Shadow Ball", At = 41 }, new Move { Name = "Mean Look", At = 46 }, new Move { Name = "Payback", At = 49 }, new Move { Name = "Future Sight", At = 54 }, },
                    eggMoves = { "Imprison", "Destiny Bond", "Pain Split", "Grudge", "Memento", "Feint Attack", "Ominous Wind", "Dark Pulse", "Skill Swap", "Haze", },
                    eggRand = 9,
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Dusclops",
                    moves = { new Move { Name = "Future Sight", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Ice Punch", At = 1 }, new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Gravity", At = 1 }, new Move { Name = "Bind", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Disable", At = 6 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Foresight", At = 14 }, new Move { Name = "Shadow Sneak", At = 17 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Will-O-Wisp", At = 25 }, new Move { Name = "Confuse Ray", At = 30 }, new Move { Name = "Curse", At = 33 }, new Move { Name = "Shadow Punch", At = 37 }, new Move { Name = "Hex", At = 40 }, new Move { Name = "Shadow Ball", At = 45 }, new Move { Name = "Mean Look", At = 52 }, new Move { Name = "Payback", At = 57 }, new Move { Name = "Future Sight", At = 64 }, },
                    FS = true,
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Tropius",
                    moves = { new Move { Name = "Leaf Storm", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Sweet Scent", At = 6 }, new Move { Name = "Stomp", At = 10 }, new Move { Name = "Magical Leaf", At = 16 }, new Move { Name = "Whirlwind", At = 21 }, new Move { Name = "Leaf Tornado", At = 26 }, new Move { Name = "Natural Gift", At = 30 }, new Move { Name = "Air Slash", At = 36 }, new Move { Name = "Body Slam", At = 41 }, new Move { Name = "Bestow", At = 46 }, new Move { Name = "Synthesis", At = 50 }, new Move { Name = "Solar Beam", At = 56 }, new Move { Name = "Leaf Storm", At = 61 }, },
                    eggMoves = { "Headbutt", "Slam", "Razor Wind", "Leech Seed", "Nature Power", "Leaf Storm", "Synthesis", "Curse", "Leaf Blade", "Dragon Dance", "Bullet Seed", "Natural Gift", },
                    FS = true,
                },

                new Species() {
                    Name = "Chimecho",
                    moves = { new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Synchronoise", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Confusion", At = 10 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Psywave", At = 16 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Extrasensory", At = 22 }, new Move { Name = "Heal Bell", At = 27 }, new Move { Name = "Uproar", At = 32 }, new Move { Name = "Safeguard", At = 37 }, new Move { Name = "Double-Edge", At = 42 }, new Move { Name = "Heal Pulse", At = 47 }, new Move { Name = "Synchronoise", At = 52 }, new Move { Name = "Healing Wish", At = 57 }, },
                  //eggMoves = { "Disable", "Curse", "Hypnosis", "Wish", "Future Sight", "Recover", "Stored Power", "Skill Swap", "Cosmic Power", },
                    eggMoves = { "Disable", "Curse", "Hypnosis", "Wish", "Future Sight", "Recover", "Stored Power", "Skill Swap", "Cosmic Power", },
                    oras5 = "Cleanse Tag",
                },

                new Species() {
                    Name = "Absol",
                    moves = { new Move { Name = "Perish Song", At = 1 }, new Move { Name = "Future Sight", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Feint", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Quick Attack", At = 7 }, new Move { Name = "Pursuit", At = 10 }, new Move { Name = "Taunt", At = 13 }, new Move { Name = "Bite", At = 16 }, new Move { Name = "Double Team", At = 19 }, new Move { Name = "Slash", At = 22 }, new Move { Name = "Swords Dance", At = 25 }, new Move { Name = "Night Slash", At = 29 }, new Move { Name = "Detect", At = 33 }, new Move { Name = "Psycho Cut", At = 37 }, new Move { Name = "Me First", At = 41 }, new Move { Name = "Sucker Punch", At = 45 }, new Move { Name = "Razor Wind", At = 49 }, new Move { Name = "Future Sight", At = 53 }, new Move { Name = "Perish Song", At = 57 }, },
                    eggMoves = { "Baton Pass", "Feint Attack", "Double-Edge", "Magic Coat", "Curse", "Mean Look", "Zen Headbutt", "Punishment", "Sucker Punch", "Assurance", "Me First", "Megahorn", "Hex", "Perish Song", "Play Rough", },
                    FS = true,
                    oras5 = "Life Orb",
                },

                new Species() {
                    Name = "Wynaut",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Encore", At = 1 }, new Move { Name = "Counter", At = 15 }, new Move { Name = "Mirror Coat", At = 15 }, new Move { Name = "Safeguard", At = 15 }, new Move { Name = "Destiny Bond", At = 15 }, },
                },

                new Species() {
                    Name = "Snorunt",
                    moves = { new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Team", At = 5 }, new Move { Name = "Ice Shard", At = 10 }, new Move { Name = "Icy Wind", At = 14 }, new Move { Name = "Bite", At = 19 }, new Move { Name = "Ice Fang", At = 23 }, new Move { Name = "Headbutt", At = 28 }, new Move { Name = "Protect", At = 32 }, new Move { Name = "Frost Breath", At = 37 }, new Move { Name = "Crunch", At = 41 }, new Move { Name = "Blizzard", At = 46 }, new Move { Name = "Hail", At = 50 }, },
                    eggMoves = { "Block", "Spikes", "Rollout", "Disable", "Bide", "Weather Ball", "Avalanche", "Hex", "Fake Tears", "Switcheroo", },
                    eggRand = 7,
                    FS = true,
                    oras5 = "Snowball",
                },

                new Species() {
                    Name = "Glalie",
                    moves = { new Move { Name = "Sheer Cold", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Ice Shard", At = 1 }, new Move { Name = "Double Team", At = 5 }, new Move { Name = "Ice Shard", At = 10 }, new Move { Name = "Icy Wind", At = 14 }, new Move { Name = "Bite", At = 19 }, new Move { Name = "Ice Fang", At = 23 }, new Move { Name = "Headbutt", At = 28 }, new Move { Name = "Protect", At = 32 }, new Move { Name = "Frost Breath", At = 37 }, new Move { Name = "Crunch", At = 41 }, new Move { Name = "Freeze-Dry", At = 42 }, new Move { Name = "Blizzard", At = 48 }, new Move { Name = "Hail", At = 54 }, new Move { Name = "Sheer Cold", At = 61 }, },
                },

                new Species() {
                    Name = "Spheal",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 5 }, new Move { Name = "Encore", At = 9 }, new Move { Name = "Ice Ball", At = 13 }, new Move { Name = "Brine", At = 17 }, new Move { Name = "Aurora Beam", At = 21 }, new Move { Name = "Body Slam", At = 26 }, new Move { Name = "Rest", At = 31 }, new Move { Name = "Snore", At = 31 }, new Move { Name = "Hail", At = 36 }, new Move { Name = "Blizzard", At = 41 }, new Move { Name = "Sheer Cold", At = 46 }, },
                    eggMoves = { "Water Sport", "Stockpile", "Swallow", "Spit Up", "Yawn", "Curse", "Fissure", "Signal Beam", "Aqua Ring", "Rollout", "Sleep Talk", "Water Pulse", "Belly Drum", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Sealeo",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 5 }, new Move { Name = "Encore", At = 9 }, new Move { Name = "Ice Ball", At = 13 }, new Move { Name = "Brine", At = 17 }, new Move { Name = "Aurora Beam", At = 21 }, new Move { Name = "Body Slam", At = 26 }, new Move { Name = "Rest", At = 31 }, new Move { Name = "Snore", At = 31 }, new Move { Name = "Swagger", At = 32 }, new Move { Name = "Hail", At = 38 }, new Move { Name = "Blizzard", At = 45 }, new Move { Name = "Sheer Cold", At = 52 }, },
                    eggMoves = { "Water Sport", "Stockpile", "Swallow", "Spit Up", "Yawn", "Curse", "Fissure", "Signal Beam", "Aqua Ring", "Rollout", "Sleep Talk", "Water Pulse", "Belly Drum", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Walrein",
                    moves = { new Move { Name = "Crunch", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Encore", At = 7 }, new Move { Name = "Ice Ball", At = 13 }, new Move { Name = "Brine", At = 19 }, new Move { Name = "Aurora Beam", At = 19 }, new Move { Name = "Body Slam", At = 25 }, new Move { Name = "Rest", At = 31 }, new Move { Name = "Snore", At = 31 }, new Move { Name = "Swagger", At = 32 }, new Move { Name = "Hail", At = 38 }, new Move { Name = "Ice Fang", At = 44 }, new Move { Name = "Blizzard", At = 49 }, new Move { Name = "Sheer Cold", At = 60 }, },
                },

                new Species() {
                    Name = "Clamperl",
                    moves = { new Move { Name = "Clamp", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Whirlpool", At = 1 }, new Move { Name = "Iron Defense", At = 1 }, new Move { Name = "Shell Smash", At = 50 }, },
                    eggMoves = { "Refresh", "Mud Sport", "Body Slam", "Supersonic", "Barrier", "Confuse Ray", "Aqua Ring", "Muddy Water", "Water Pulse", "Brine", "Endure", },
                    item5 = "Big Pearl",
                    oras50 = "Pearl",
                },

                new Species() {
                    Name = "Huntail",
                    moves = { new Move { Name = "Whirlpool", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Screech", At = 5 }, new Move { Name = "Scary Face", At = 9 }, new Move { Name = "Feint Attack", At = 11 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Ice Fang", At = 16 }, new Move { Name = "Brine", At = 19 }, new Move { Name = "Sucker Punch", At = 23 }, new Move { Name = "Dive", At = 26 }, new Move { Name = "Baton Pass", At = 29 }, new Move { Name = "Crunch", At = 34 }, new Move { Name = "Aqua Tail", At = 39 }, new Move { Name = "Coil", At = 45 }, new Move { Name = "Hydro Pump", At = 50 }, },
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Gorebyss",
                    moves = { new Move { Name = "Whirlpool", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Water Sport", At = 5 }, new Move { Name = "Agility", At = 9 }, new Move { Name = "Draining Kiss", At = 11 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Amnesia", At = 16 }, new Move { Name = "Aqua Ring", At = 19 }, new Move { Name = "Captivate", At = 23 }, new Move { Name = "Dive", At = 26 }, new Move { Name = "Baton Pass", At = 29 }, new Move { Name = "Psychic", At = 34 }, new Move { Name = "Aqua Tail", At = 39 }, new Move { Name = "Coil", At = 45 }, new Move { Name = "Hydro Pump", At = 50 }, },
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Relicanth",
                    moves = { new Move { Name = "Head Smash", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud Sport", At = 6 }, new Move { Name = "Water Gun", At = 10 }, new Move { Name = "Rock Tomb", At = 15 }, new Move { Name = "Ancient Power", At = 21 }, new Move { Name = "Dive", At = 26 }, new Move { Name = "Take Down", At = 31 }, new Move { Name = "Yawn", At = 35 }, new Move { Name = "Rest", At = 41 }, new Move { Name = "Hydro Pump", At = 46 }, new Move { Name = "Double-Edge", At = 50 }, new Move { Name = "Head Smash", At = 56 }, },
                    eggMoves = { "Magnitude", "Skull Bash", "Water Sport", "Amnesia", "Sleep Talk", "Aqua Tail", "Snore", "Mud-Slap", "Muddy Water", "Mud Shot", "Brine", "Zen Headbutt", },
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Luvdisc",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Agility", At = 7 }, new Move { Name = "Draining Kiss", At = 9 }, new Move { Name = "Lucky Chant", At = 14 }, new Move { Name = "Water Pulse", At = 17 }, new Move { Name = "Attract", At = 22 }, new Move { Name = "Flail", At = 27 }, new Move { Name = "Sweet Kiss", At = 31 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Aqua Ring", At = 40 }, new Move { Name = "Captivate", At = 46 }, new Move { Name = "Hydro Pump", At = 50 }, new Move { Name = "Safeguard", At = 55 }, },
                    eggMoves = { "Splash", "Supersonic", "Water Sport", "Mud Sport", "Captivate", "Aqua Ring", "Aqua Jet", "Heal Pulse", "Brine", "Entrainment", },
                    item50 = "Heart Scale",
                },

                new Species() {
                    Name = "Bagon",
                    moves = { new Move { Name = "Rage", At = 1 }, new Move { Name = "Ember", At = 4 }, new Move { Name = "Leer", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Dragon Breath", At = 13 }, new Move { Name = "Headbutt", At = 17 }, new Move { Name = "Focus Energy", At = 21 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Dragon Claw", At = 29 }, new Move { Name = "Zen Headbutt", At = 34 }, new Move { Name = "Scary Face", At = 39 }, new Move { Name = "Flamethrower", At = 44 }, new Move { Name = "Double-Edge", At = 49 }, },
                    eggMoves = { "Hydro Pump", "Thrash", "Dragon Rage", "Twister", "Dragon Dance", "Fire Fang", "Dragon Rush", "Dragon Pulse", "Endure", "Defense Curl", },
                    eggRand = 5,
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Shelgon",
                    moves = { new Move { Name = "Rage", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Ember", At = 4 }, new Move { Name = "Leer", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Dragon Breath", At = 13 }, new Move { Name = "Headbutt", At = 17 }, new Move { Name = "Focus Energy", At = 21 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Dragon Claw", At = 29 }, new Move { Name = "Protect", At = 30 }, new Move { Name = "Zen Headbutt", At = 35 }, new Move { Name = "Scary Face", At = 42 }, new Move { Name = "Flamethrower", At = 49 }, new Move { Name = "Double-Edge", At = 56 }, },
                    FS = true,
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Salamence",
                    moves = { new Move { Name = "Dragon Tail", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Ember", At = 4 }, new Move { Name = "Leer", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Dragon Breath", At = 13 }, new Move { Name = "Headbutt", At = 17 }, new Move { Name = "Focus Energy", At = 21 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Dragon Claw", At = 29 }, new Move { Name = "Protect", At = 30 }, new Move { Name = "Zen Headbutt", At = 35 }, new Move { Name = "Scary Face", At = 42 }, new Move { Name = "Flamethrower", At = 49 }, new Move { Name = "Fly", At = 50 }, new Move { Name = "Double-Edge", At = 63 }, },
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Beldum",
                    moves = { new Move { Name = "Take Down", At = 1 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Metang",
                    moves = { new Move { Name = "Magnet Rise", At = 1 }, new Move { Name = "Take Down", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Metal Claw", At = 1 }, new Move { Name = "Confusion", At = 20 }, new Move { Name = "Metal Claw", At = 20 }, new Move { Name = "Pursuit", At = 23 }, new Move { Name = "Bullet Punch", At = 26 }, new Move { Name = "Miracle Eye", At = 29 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Scary Face", At = 35 }, new Move { Name = "Psychic", At = 38 }, new Move { Name = "Agility", At = 41 }, new Move { Name = "Meteor Mash", At = 44 }, new Move { Name = "Iron Defense", At = 47 }, new Move { Name = "Hyper Beam", At = 50 }, },
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Metagross",
                    moves = { new Move { Name = "Magnet Rise", At = 1 }, new Move { Name = "Take Down", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Metal Claw", At = 1 }, new Move { Name = "Confusion", At = 20 }, new Move { Name = "Metal Claw", At = 20 }, new Move { Name = "Pursuit", At = 23 }, new Move { Name = "Bullet Punch", At = 26 }, new Move { Name = "Miracle Eye", At = 29 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Scary Face", At = 35 }, new Move { Name = "Psychic", At = 38 }, new Move { Name = "Agility", At = 41 }, new Move { Name = "Meteor Mash", At = 44 }, new Move { Name = "Hammer Arm", At = 45 }, new Move { Name = "Iron Defense", At = 52 }, new Move { Name = "Hyper Beam", At = 60 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Regirock",
                    moves = { new Move { Name = "Explosion", At = 1 }, new Move { Name = "Stomp", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Charge Beam", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Rock Throw", At = 7 }, new Move { Name = "Charge Beam", At = 13 }, new Move { Name = "Bulldoze", At = 19 }, new Move { Name = "Curse", At = 25 }, new Move { Name = "Ancient Power", At = 31 }, new Move { Name = "Iron Defense", At = 37 }, new Move { Name = "Stone Edge", At = 43 }, new Move { Name = "Hammer Arm", At = 49 }, new Move { Name = "Lock-On", At = 55 }, new Move { Name = "Zap Cannon", At = 55 }, new Move { Name = "Superpower", At = 61 }, new Move { Name = "Hyper Beam", At = 67 }, },
                },

                new Species() {
                    Name = "Regice",
                    moves = { new Move { Name = "Explosion", At = 1 }, new Move { Name = "Stomp", At = 1 }, new Move { Name = "Icy Wind", At = 1 }, new Move { Name = "Charge Beam", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Icy Wind", At = 7 }, new Move { Name = "Charge Beam", At = 13 }, new Move { Name = "Bulldoze", At = 19 }, new Move { Name = "Curse", At = 25 }, new Move { Name = "Ancient Power", At = 31 }, new Move { Name = "Amnesia", At = 37 }, new Move { Name = "Ice Beam", At = 43 }, new Move { Name = "Hammer Arm", At = 49 }, new Move { Name = "Lock-On", At = 55 }, new Move { Name = "Zap Cannon", At = 55 }, new Move { Name = "Superpower", At = 61 }, new Move { Name = "Hyper Beam", At = 67 }, },
                },

                new Species() {
                    Name = "Registeel",
                    moves = { new Move { Name = "Explosion", At = 1 }, new Move { Name = "Stomp", At = 1 }, new Move { Name = "Metal Claw", At = 1 }, new Move { Name = "Charge Beam", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Metal Claw", At = 7 }, new Move { Name = "Charge Beam", At = 13 }, new Move { Name = "Bulldoze", At = 19 }, new Move { Name = "Curse", At = 25 }, new Move { Name = "Ancient Power", At = 31 }, new Move { Name = "Iron Defense", At = 37 }, new Move { Name = "Amnesia", At = 37 }, new Move { Name = "Iron Head", At = 43 }, new Move { Name = "Flash Cannon", At = 43 }, new Move { Name = "Hammer Arm", At = 49 }, new Move { Name = "Lock-On", At = 55 }, new Move { Name = "Zap Cannon", At = 55 }, new Move { Name = "Superpower", At = 61 }, new Move { Name = "Hyper Beam", At = 67 }, },
                },

                new Species() {
                    Name = "Latias",
                    moves = { new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Wish", At = 1 }, new Move { Name = "Psywave", At = 1 }, new Move { Name = "Safeguard", At = 1 }, new Move { Name = "Water Sport", At = 4 }, new Move { Name = "Charm", At = 7 }, new Move { Name = "Stored Power", At = 10 }, new Move { Name = "Refresh", At = 13 }, new Move { Name = "Heal Pulse", At = 16 }, new Move { Name = "Dragon Breath", At = 20 }, new Move { Name = "Mist Ball", At = 24 }, new Move { Name = "Psycho Shift", At = 28 }, new Move { Name = "Recover", At = 32 }, new Move { Name = "Reflect Type", At = 36 }, new Move { Name = "Zen Headbutt", At = 41 }, new Move { Name = "Guard Split", At = 46 }, new Move { Name = "Psychic", At = 51 }, new Move { Name = "Dragon Pulse", At = 56 }, new Move { Name = "Healing Wish", At = 61 }, },
                },

                new Species() {
                    Name = "Latios",
                    moves = { new Move { Name = "Memento", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Heal Block", At = 1 }, new Move { Name = "Psywave", At = 1 }, new Move { Name = "Safeguard", At = 1 }, new Move { Name = "Protect", At = 4 }, new Move { Name = "Dragon Dance", At = 7 }, new Move { Name = "Stored Power", At = 10 }, new Move { Name = "Refresh", At = 13 }, new Move { Name = "Heal Pulse", At = 16 }, new Move { Name = "Dragon Breath", At = 20 }, new Move { Name = "Luster Purge", At = 24 }, new Move { Name = "Psycho Shift", At = 28 }, new Move { Name = "Recover", At = 32 }, new Move { Name = "Telekinesis", At = 36 }, new Move { Name = "Zen Headbutt", At = 41 }, new Move { Name = "Power Split", At = 46 }, new Move { Name = "Psychic", At = 51 }, new Move { Name = "Dragon Pulse", At = 56 }, new Move { Name = "Memento", At = 61 }, },
                },

                new Species() {
                    Name = "Kyogre",
                    moves = { new Move { Name = "Ancient Power", At = 1 }, new Move { Name = "Water Pulse", At = 1 }, new Move { Name = "Scary Face", At = 5 }, new Move { Name = "Aqua Tail", At = 15 }, new Move { Name = "Body Slam", At = 20 }, new Move { Name = "Aqua Ring", At = 30 }, new Move { Name = "Ice Beam", At = 35 }, new Move { Name = "Origin Pulse", At = 45 }, new Move { Name = "Calm Mind", At = 50 }, new Move { Name = "Muddy Water", At = 60 }, new Move { Name = "Sheer Cold", At = 65 }, new Move { Name = "Hydro Pump", At = 75 }, new Move { Name = "Double-Edge", At = 80 }, new Move { Name = "Water Spout", At = 90 }, },
                },

                new Species() {
                    Name = "Groudon",
                    moves = { new Move { Name = "Ancient Power", At = 1 }, new Move { Name = "Mud Shot", At = 1 }, new Move { Name = "Scary Face", At = 5 }, new Move { Name = "Earth Power", At = 15 }, new Move { Name = "Lava Plume", At = 20 }, new Move { Name = "Rest", At = 30 }, new Move { Name = "Earthquake", At = 35 }, new Move { Name = "Precipice Blades", At = 45 }, new Move { Name = "Bulk Up", At = 50 }, new Move { Name = "Solar Beam", At = 60 }, new Move { Name = "Fissure", At = 65 }, new Move { Name = "Fire Blast", At = 75 }, new Move { Name = "Hammer Arm", At = 80 }, new Move { Name = "Eruption", At = 90 }, },
                },

                new Species() {
                    Name = "Rayquaza",
                    moves = { new Move { Name = "Twister", At = 1 }, new Move { Name = "Scary Face", At = 5 }, new Move { Name = "Ancient Power", At = 15 }, new Move { Name = "Crunch", At = 20 }, new Move { Name = "Air Slash", At = 30 }, new Move { Name = "Rest", At = 35 }, new Move { Name = "Extreme Speed", At = 45 }, new Move { Name = "Dragon Pulse", At = 50 }, new Move { Name = "Dragon Dance", At = 60 }, new Move { Name = "Fly", At = 65 }, new Move { Name = "Hyper Voice", At = 75 }, new Move { Name = "Outrage", At = 80 }, new Move { Name = "Hyper Beam", At = 90 }, },
                },

                new Species() {
                    Name = "Jirachi",
                    moves = { new Move { Name = "Wish", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Rest", At = 5 }, new Move { Name = "Swift", At = 10 }, new Move { Name = "Helping Hand", At = 15 }, new Move { Name = "Psychic", At = 20 }, new Move { Name = "Refresh", At = 25 }, new Move { Name = "Rest", At = 30 }, new Move { Name = "Zen Headbutt", At = 35 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Gravity", At = 45 }, new Move { Name = "Healing Wish", At = 50 }, new Move { Name = "Future Sight", At = 55 }, new Move { Name = "Cosmic Power", At = 60 }, new Move { Name = "Last Resort", At = 65 }, new Move { Name = "Doom Desire", At = 70 }, },
                    item100 = "Star Piece",
                },

                new Species() {
                    Name = "Deoxys",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Night Shade", At = 7 }, new Move { Name = "Teleport", At = 13 }, new Move { Name = "Knock Off", At = 19 }, new Move { Name = "Pursuit", At = 25 }, new Move { Name = "Psychic", At = 31 }, new Move { Name = "Snatch", At = 37 }, new Move { Name = "Psycho Shift", At = 43 }, new Move { Name = "Zen Headbutt", At = 49 }, new Move { Name = "Cosmic Power", At = 55 }, new Move { Name = "Recover", At = 61 }, new Move { Name = "Psycho Boost", At = 67 }, new Move { Name = "Hyper Beam", At = 73 }, },
                },

                new Species() {
                    Name = "Turtwig",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Withdraw", At = 5 }, new Move { Name = "Absorb", At = 9 }, new Move { Name = "Razor Leaf", At = 13 }, new Move { Name = "Curse", At = 17 }, new Move { Name = "Bite", At = 21 }, new Move { Name = "Mega Drain", At = 25 }, new Move { Name = "Leech Seed", At = 29 }, new Move { Name = "Synthesis", At = 33 }, new Move { Name = "Crunch", At = 37 }, new Move { Name = "Giga Drain", At = 41 }, new Move { Name = "Leaf Storm", At = 45 }, },
                    eggMoves = { "Worry Seed", "Growth", "Tickle", "Body Slam", "Double-Edge", "Sand Tomb", "Seed Bomb", "Thrash", "Amnesia", "Superpower", "Stockpile", "Swallow", "Spit Up", "Earth Power", "Wide Guard", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Grotle",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Withdraw", At = 5 }, new Move { Name = "Absorb", At = 9 }, new Move { Name = "Razor Leaf", At = 13 }, new Move { Name = "Curse", At = 17 }, new Move { Name = "Bite", At = 22 }, new Move { Name = "Mega Drain", At = 27 }, new Move { Name = "Leech Seed", At = 32 }, new Move { Name = "Synthesis", At = 37 }, new Move { Name = "Crunch", At = 42 }, new Move { Name = "Giga Drain", At = 47 }, new Move { Name = "Leaf Storm", At = 52 }, },
                },

                new Species() {
                    Name = "Torterra",
                    moves = { new Move { Name = "Wood Hammer", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Withdraw", At = 5 }, new Move { Name = "Absorb", At = 9 }, new Move { Name = "Razor Leaf", At = 13 }, new Move { Name = "Curse", At = 17 }, new Move { Name = "Bite", At = 22 }, new Move { Name = "Mega Drain", At = 27 }, new Move { Name = "Earthquake", At = 32 }, new Move { Name = "Leech Seed", At = 33 }, new Move { Name = "Synthesis", At = 39 }, new Move { Name = "Crunch", At = 45 }, new Move { Name = "Giga Drain", At = 51 }, new Move { Name = "Leaf Storm", At = 57 }, },
                },

                new Species() {
                    Name = "Chimchar",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Taunt", At = 9 }, new Move { Name = "Fury Swipes", At = 15 }, new Move { Name = "Flame Wheel", At = 17 }, new Move { Name = "Nasty Plot", At = 23 }, new Move { Name = "Torment", At = 25 }, new Move { Name = "Facade", At = 31 }, new Move { Name = "Fire Spin", At = 33 }, new Move { Name = "Acrobatics", At = 39 }, new Move { Name = "Slack Off", At = 41 }, new Move { Name = "Flamethrower", At = 47 }, },
                    eggMoves = { "Fire Punch", "Thunder Punch", "Double Kick", "Encore", "Heat Wave", "Focus Energy", "Helping Hand", "Fake Out", "Blaze Kick", "Counter", "Assist", "Quick Guard", "Focus Punch", "Submission", },
                },

                new Species() {
                    Name = "Monferno",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Taunt", At = 9 }, new Move { Name = "Mach Punch", At = 14 }, new Move { Name = "Fury Swipes", At = 16 }, new Move { Name = "Flame Wheel", At = 19 }, new Move { Name = "Feint", At = 26 }, new Move { Name = "Torment", At = 29 }, new Move { Name = "Close Combat", At = 36 }, new Move { Name = "Fire Spin", At = 39 }, new Move { Name = "Acrobatics", At = 46 }, new Move { Name = "Slack Off", At = 49 }, new Move { Name = "Flare Blitz", At = 56 }, },
                },

                new Species() {
                    Name = "Infernape",
                    moves = { new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Taunt", At = 9 }, new Move { Name = "Mach Punch", At = 14 }, new Move { Name = "Fury Swipes", At = 16 }, new Move { Name = "Flame Wheel", At = 19 }, new Move { Name = "Feint", At = 26 }, new Move { Name = "Punishment", At = 29 }, new Move { Name = "Close Combat", At = 36 }, new Move { Name = "Fire Spin", At = 42 }, new Move { Name = "Acrobatics", At = 52 }, new Move { Name = "Calm Mind", At = 58 }, new Move { Name = "Flare Blitz", At = 68 }, },
                },

                new Species() {
                    Name = "Piplup",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Bubble", At = 8 }, new Move { Name = "Water Sport", At = 11 }, new Move { Name = "Peck", At = 15 }, new Move { Name = "Bubble Beam", At = 18 }, new Move { Name = "Bide", At = 22 }, new Move { Name = "Fury Attack", At = 25 }, new Move { Name = "Brine", At = 29 }, new Move { Name = "Whirlpool", At = 32 }, new Move { Name = "Mist", At = 36 }, new Move { Name = "Drill Peck", At = 39 }, new Move { Name = "Hydro Pump", At = 43 }, },
                    eggMoves = { "Double Hit", "Supersonic", "Yawn", "Mud Sport", "Mud-Slap", "Snore", "Flail", "Agility", "Aqua Ring", "Hydro Pump", "Feather Dance", "Bide", "Icy Wind", },
                },

                new Species() {
                    Name = "Prinplup",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Bubble", At = 8 }, new Move { Name = "Water Sport", At = 11 }, new Move { Name = "Peck", At = 15 }, new Move { Name = "Metal Claw", At = 16 }, new Move { Name = "Bubble Beam", At = 19 }, new Move { Name = "Bide", At = 24 }, new Move { Name = "Fury Attack", At = 28 }, new Move { Name = "Brine", At = 33 }, new Move { Name = "Whirlpool", At = 37 }, new Move { Name = "Mist", At = 42 }, new Move { Name = "Drill Peck", At = 46 }, new Move { Name = "Hydro Pump", At = 50 }, },
                },

                new Species() {
                    Name = "Empoleon",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Bubble", At = 8 }, new Move { Name = "Swords Dance", At = 11 }, new Move { Name = "Peck", At = 15 }, new Move { Name = "Metal Claw", At = 16 }, new Move { Name = "Bubble Beam", At = 19 }, new Move { Name = "Swagger", At = 24 }, new Move { Name = "Fury Attack", At = 28 }, new Move { Name = "Brine", At = 33 }, new Move { Name = "Aqua Jet", At = 36 }, new Move { Name = "Whirlpool", At = 39 }, new Move { Name = "Mist", At = 46 }, new Move { Name = "Drill Peck", At = 52 }, new Move { Name = "Hydro Pump", At = 59 }, },
                },

                new Species() {
                    Name = "Starly",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Wing Attack", At = 9 }, new Move { Name = "Double Team", At = 13 }, new Move { Name = "Endeavor", At = 17 }, new Move { Name = "Whirlwind", At = 21 }, new Move { Name = "Aerial Ace", At = 25 }, new Move { Name = "Take Down", At = 29 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Brave Bird", At = 37 }, new Move { Name = "Final Gambit", At = 41 }, },
                    eggMoves = { "Feather Dance", "Fury Attack", "Pursuit", "Astonish", "Sand Attack", "Foresight", "Double-Edge", "Steel Wing", "Uproar", "Roost", "Detect", "Revenge", "Mirror Move", },
                },

                new Species() {
                    Name = "Staravia",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Wing Attack", At = 9 }, new Move { Name = "Double Team", At = 13 }, new Move { Name = "Endeavor", At = 18 }, new Move { Name = "Whirlwind", At = 23 }, new Move { Name = "Aerial Ace", At = 28 }, new Move { Name = "Take Down", At = 33 }, new Move { Name = "Agility", At = 38 }, new Move { Name = "Brave Bird", At = 43 }, new Move { Name = "Final Gambit", At = 48 }, },
                },

                new Species() {
                    Name = "Staraptor",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Wing Attack", At = 9 }, new Move { Name = "Double Team", At = 13 }, new Move { Name = "Endeavor", At = 18 }, new Move { Name = "Whirlwind", At = 23 }, new Move { Name = "Aerial Ace", At = 28 }, new Move { Name = "Take Down", At = 33 }, new Move { Name = "Close Combat", At = 34 }, new Move { Name = "Agility", At = 41 }, new Move { Name = "Brave Bird", At = 49 }, new Move { Name = "Final Gambit", At = 57 }, },
                },

                new Species() {
                    Name = "Bidoof",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Defense Curl", At = 9 }, new Move { Name = "Rollout", At = 13 }, new Move { Name = "Headbutt", At = 17 }, new Move { Name = "Hyper Fang", At = 21 }, new Move { Name = "Yawn", At = 25 }, new Move { Name = "Amnesia", At = 29 }, new Move { Name = "Take Down", At = 33 }, new Move { Name = "Super Fang", At = 37 }, new Move { Name = "Superpower", At = 41 }, new Move { Name = "Curse", At = 45 }, },
                    eggMoves = { "Quick Attack", "Water Sport", "Double-Edge", "Fury Swipes", "Defense Curl", "Rollout", "Odor Sleuth", "Aqua Tail", "Rock Climb", "Sleep Talk", "Endure", "Skull Bash", },
                },

                new Species() {
                    Name = "Bibarel",
                    moves = { new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Defense Curl", At = 9 }, new Move { Name = "Rollout", At = 13 }, new Move { Name = "Water Gun", At = 15 }, new Move { Name = "Headbutt", At = 18 }, new Move { Name = "Hyper Fang", At = 23 }, new Move { Name = "Yawn", At = 28 }, new Move { Name = "Amnesia", At = 33 }, new Move { Name = "Take Down", At = 38 }, new Move { Name = "Super Fang", At = 43 }, new Move { Name = "Superpower", At = 48 }, new Move { Name = "Curse", At = 53 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Kricketot",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Struggle Bug", At = 6 }, new Move { Name = "Bug Bite", At = 16 }, },
                    oras5 = "Metronome",
                },

                new Species() {
                    Name = "Kricketune",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Fury Cutter", At = 10 }, new Move { Name = "Leech Life", At = 14 }, new Move { Name = "Sing", At = 18 }, new Move { Name = "Focus Energy", At = 22 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "X-Scissor", At = 30 }, new Move { Name = "Screech", At = 34 }, new Move { Name = "Fell Stinger", At = 36 }, new Move { Name = "Taunt", At = 38 }, new Move { Name = "Night Slash", At = 42 }, new Move { Name = "Sticky Web", At = 44 }, new Move { Name = "Bug Buzz", At = 46 }, new Move { Name = "Perish Song", At = 50 }, },
                    oras5 = "Metronome",
                },

                new Species() {
                    Name = "Shinx",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 5 }, new Move { Name = "Charge", At = 9 }, new Move { Name = "Baby-Doll Eyes", At = 11 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Roar", At = 21 }, new Move { Name = "Swagger", At = 25 }, new Move { Name = "Thunder Fang", At = 29 }, new Move { Name = "Crunch", At = 33 }, new Move { Name = "Scary Face", At = 37 }, new Move { Name = "Discharge", At = 41 }, new Move { Name = "Wild Charge", At = 45 }, },
                    eggMoves = { "Ice Fang", "Fire Fang", "Thunder Fang", "Quick Attack", "Howl", "Take Down", "Night Slash", "Shock Wave", "Swift", "Double Kick", "Signal Beam", "Helping Hand", "Eerie Impulse", "Fake Tears", },
                },

                new Species() {
                    Name = "Luxio",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Leer", At = 5 }, new Move { Name = "Charge", At = 9 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Bite", At = 18 }, new Move { Name = "Roar", At = 23 }, new Move { Name = "Swagger", At = 28 }, new Move { Name = "Thunder Fang", At = 33 }, new Move { Name = "Crunch", At = 38 }, new Move { Name = "Scary Face", At = 43 }, new Move { Name = "Discharge", At = 48 }, new Move { Name = "Wild Charge", At = 53 }, },
                    eggMoves = { "Ice Fang", "Fire Fang", "Thunder Fang", "Quick Attack", "Howl", "Take Down", "Night Slash", "Shock Wave", "Swift", "Double Kick", "Signal Beam", "Helping Hand", "Eerie Impulse", "Fake Tears", },
                    FS = true,
                },

                new Species() {
                    Name = "Luxray",
                    moves = { new Move { Name = "Electric Terrain", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Leer", At = 5 }, new Move { Name = "Charge", At = 9 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Bite", At = 18 }, new Move { Name = "Roar", At = 23 }, new Move { Name = "Swagger", At = 28 }, new Move { Name = "Thunder Fang", At = 35 }, new Move { Name = "Crunch", At = 42 }, new Move { Name = "Scary Face", At = 49 }, new Move { Name = "Discharge", At = 56 }, new Move { Name = "Wild Charge", At = 63 }, new Move { Name = "Electric Terrain", At = 67 }, },
                },

                new Species() {
                    Name = "Budew",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 4 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Stun Spore", At = 10 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Worry Seed", At = 16 }, },
                    eggMoves = { "Spikes", "Synthesis", "Pin Missile", "Cotton Spore", "Sleep Powder", "Razor Leaf", "Mind Reader", "Leaf Storm", "Extrasensory", "Seed Bomb", "Giga Drain", "Natural Gift", "Grass Whistle", },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Roserade",
                    moves = { new Move { Name = "Venom Drench", At = 1 }, new Move { Name = "Grassy Terrain", At = 1 }, new Move { Name = "Weather Ball", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Magical Leaf", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Cranidos",
                    moves = { new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 6 }, new Move { Name = "Pursuit", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Scary Face", At = 19 }, new Move { Name = "Assurance", At = 24 }, new Move { Name = "Chip Away", At = 28 }, new Move { Name = "Ancient Power", At = 33 }, new Move { Name = "Zen Headbutt", At = 37 }, new Move { Name = "Screech", At = 42 }, new Move { Name = "Head Smash", At = 46 }, },
                    eggMoves = { "Crunch", "Thrash", "Double-Edge", "Leer", "Slam", "Stomp", "Whirlwind", "Hammer Arm", "Curse", "Iron Tail", "Iron Head", },
                },

                new Species() {
                    Name = "Rampardos",
                    moves = { new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 6 }, new Move { Name = "Pursuit", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Scary Face", At = 19 }, new Move { Name = "Assurance", At = 24 }, new Move { Name = "Chip Away", At = 28 }, new Move { Name = "Endeavor", At = 30 }, new Move { Name = "Ancient Power", At = 36 }, new Move { Name = "Zen Headbutt", At = 43 }, new Move { Name = "Screech", At = 51 }, new Move { Name = "Head Smash", At = 58 }, },
                },

                new Species() {
                    Name = "Shieldon",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Taunt", At = 6 }, new Move { Name = "Metal Sound", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Iron Defense", At = 19 }, new Move { Name = "Swagger", At = 24 }, new Move { Name = "Ancient Power", At = 28 }, new Move { Name = "Endure", At = 33 }, new Move { Name = "Metal Burst", At = 37 }, new Move { Name = "Iron Head", At = 42 }, new Move { Name = "Heavy Slam", At = 46 }, },
                    eggMoves = { "Headbutt", "Scary Face", "Focus Energy", "Double-Edge", "Rock Blast", "Body Slam", "Screech", "Curse", "Fissure", "Counter", "Stealth Rock", "Wide Guard", "Guard Split", },
                },

                new Species() {
                    Name = "Bastiodon",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Metal Sound", At = 1 }, new Move { Name = "Taunt", At = 6 }, new Move { Name = "Metal Sound", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Iron Defense", At = 19 }, new Move { Name = "Swagger", At = 24 }, new Move { Name = "Ancient Power", At = 28 }, new Move { Name = "Block", At = 30 }, new Move { Name = "Endure", At = 36 }, new Move { Name = "Metal Burst", At = 43 }, new Move { Name = "Iron Head", At = 51 }, new Move { Name = "Heavy Slam", At = 58 }, },
                },

                new Species() {
                    Name = "Burmy",
                    moves = { new Move { Name = "Protect", At = 1 }, new Move { Name = "Tackle", At = 10 }, new Move { Name = "Bug Bite", At = 15 }, new Move { Name = "Hidden Power", At = 20 }, },
                },

                new Species() {
                    Name = "Wormadam",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 10 }, new Move { Name = "Bug Bite", At = 15 }, new Move { Name = "Hidden Power", At = 20 }, new Move { Name = "Confusion", At = 23 }, new Move { Name = "Razor Leaf", At = 26 }, new Move { Name = "Growth", At = 29 }, new Move { Name = "Psybeam", At = 32 }, new Move { Name = "Captivate", At = 35 }, new Move { Name = "Flail", At = 38 }, new Move { Name = "Attract", At = 41 }, new Move { Name = "Psychic", At = 44 }, new Move { Name = "Leaf Storm", At = 47 }, },
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Mothim",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Protect", At = 10 }, new Move { Name = "Bug Bite", At = 15 }, new Move { Name = "Hidden Power", At = 20 }, new Move { Name = "Confusion", At = 23 }, new Move { Name = "Gust", At = 26 }, new Move { Name = "Poison Powder", At = 29 }, new Move { Name = "Psybeam", At = 32 }, new Move { Name = "Camouflage", At = 35 }, new Move { Name = "Silver Wind", At = 38 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Psychic", At = 44 }, new Move { Name = "Bug Buzz", At = 47 }, new Move { Name = "Quiver Dance", At = 50 }, },
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Combee",
                    moves = { new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Bug Bite", At = 13 }, new Move { Name = "Bug Buzz", At = 29 }, },
                    FS = true,
                    item5 = "Honey",
                },

                new Species() {
                    Name = "Vespiquen",
                    moves = { new Move { Name = "Fell Stinger", At = 1 }, new Move { Name = "Destiny Bond", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Fury Cutter", At = 5 }, new Move { Name = "Pursuit", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Defend Order", At = 17 }, new Move { Name = "Slash", At = 21 }, new Move { Name = "Power Gem", At = 25 }, new Move { Name = "Heal Order", At = 29 }, new Move { Name = "Toxic", At = 33 }, new Move { Name = "Air Slash", At = 37 }, new Move { Name = "Captivate", At = 41 }, new Move { Name = "Attack Order", At = 45 }, new Move { Name = "Swagger", At = 49 }, new Move { Name = "Destiny Bond", At = 53 }, new Move { Name = "Fell Stinger", At = 57 }, },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Pachirisu",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Quick Attack", At = 5 }, new Move { Name = "Charm", At = 9 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Endure", At = 17 }, new Move { Name = "Nuzzle", At = 19 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Electro Ball", At = 25 }, new Move { Name = "Sweet Kiss", At = 29 }, new Move { Name = "Thunder Wave", At = 33 }, new Move { Name = "Super Fang", At = 37 }, new Move { Name = "Discharge", At = 41 }, new Move { Name = "Last Resort", At = 45 }, new Move { Name = "Hyper Fang", At = 49 }, },
                    eggMoves = { "Covet", "Bite", "Fake Tears", "Defense Curl", "Rollout", "Flatter", "Flail", "Iron Tail", "Tail Whip", "Follow Me", "Charge", "Bestow", "Ion Deluge", },
                    FS = true,
                },

                new Species() {
                    Name = "Buizel",
                    moves = { new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Water Gun", At = 15 }, new Move { Name = "Pursuit", At = 18 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Aqua Jet", At = 24 }, new Move { Name = "Double Hit", At = 27 }, new Move { Name = "Whirlpool", At = 31 }, new Move { Name = "Razor Wind", At = 35 }, new Move { Name = "Aqua Tail", At = 38 }, new Move { Name = "Agility", At = 41 }, new Move { Name = "Hydro Pump", At = 45 }, },
                    eggMoves = { "Mud-Slap", "Headbutt", "Fury Swipes", "Slash", "Odor Sleuth", "Double Slap", "Fury Cutter", "Baton Pass", "Aqua Tail", "Aqua Ring", "Me First", "Switcheroo", "Tail Slap", "Soak", },
                },

                new Species() {
                    Name = "Floatzel",
                    moves = { new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Crunch", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Water Gun", At = 15 }, new Move { Name = "Pursuit", At = 18 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Aqua Jet", At = 24 }, new Move { Name = "Double Hit", At = 29 }, new Move { Name = "Whirlpool", At = 35 }, new Move { Name = "Razor Wind", At = 41 }, new Move { Name = "Aqua Tail", At = 46 }, new Move { Name = "Agility", At = 51 }, new Move { Name = "Hydro Pump", At = 57 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Cherubi",
                    moves = { new Move { Name = "Morning Sun", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Leech Seed", At = 10 }, new Move { Name = "Helping Hand", At = 13 }, new Move { Name = "Magical Leaf", At = 19 }, new Move { Name = "Sunny Day", At = 22 }, new Move { Name = "Worry Seed", At = 28 }, new Move { Name = "Take Down", At = 31 }, new Move { Name = "Solar Beam", At = 37 }, new Move { Name = "Lucky Chant", At = 40 }, new Move { Name = "Petal Blizzard", At = 47 }, },
                    eggMoves = { "Razor Leaf", "Sweet Scent", "Tickle", "Nature Power", "Grass Whistle", "Aromatherapy", "Weather Ball", "Heal Pulse", "Healing Wish", "Seed Bomb", "Natural Gift", "Defense Curl", "Rollout", "Flower Shield", },
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Cherrim",
                    moves = { new Move { Name = "Morning Sun", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Growth", At = 7 }, new Move { Name = "Leech Seed", At = 10 }, new Move { Name = "Helping Hand", At = 13 }, new Move { Name = "Magical Leaf", At = 19 }, new Move { Name = "Sunny Day", At = 22 }, new Move { Name = "Petal Dance", At = 25 }, new Move { Name = "Worry Seed", At = 30 }, new Move { Name = "Take Down", At = 35 }, new Move { Name = "Solar Beam", At = 43 }, new Move { Name = "Lucky Chant", At = 48 }, new Move { Name = "Petal Blizzard", At = 50 }, },
                    eggMoves = { "Razor Leaf", "Sweet Scent", "Tickle", "Nature Power", "Grass Whistle", "Aromatherapy", "Weather Ball", "Heal Pulse", "Healing Wish", "Seed Bomb", "Natural Gift", "Defense Curl", "Rollout", "Flower Shield", },
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Shellos (Pink)",
                    moves = { new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 2 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Water Pulse", At = 7 }, new Move { Name = "Mud Bomb", At = 11 }, new Move { Name = "Hidden Power", At = 16 }, new Move { Name = "Rain Dance", At = 22 }, new Move { Name = "Body Slam", At = 29 }, new Move { Name = "Muddy Water", At = 37 }, new Move { Name = "Recover", At = 46 }, },
                    eggMoves = { "Counter", "Mirror Coat", "Stockpile", "Swallow", "Spit Up", "Yawn", "Memento", "Curse", "Amnesia", "Fissure", "Trump Card", "Sludge", "Clear Smog", "Brine", "Mist", "Acid Armor", },
                },

                new Species() {
                    Name = "Gastrodon (Pink)",
                    moves = { new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Water Pulse", At = 1 }, new Move { Name = "Mud Sport", At = 2 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Water Pulse", At = 7 }, new Move { Name = "Mud Bomb", At = 11 }, new Move { Name = "Hidden Power", At = 16 }, new Move { Name = "Rain Dance", At = 22 }, new Move { Name = "Body Slam", At = 29 }, new Move { Name = "Muddy Water", At = 41 }, new Move { Name = "Recover", At = 54 }, },
                },

                new Species() {
                    Name = "Ambipom",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Baton Pass", At = 11 }, new Move { Name = "Tickle", At = 15 }, new Move { Name = "Fury Swipes", At = 18 }, new Move { Name = "Swift", At = 22 }, new Move { Name = "Screech", At = 25 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Double Hit", At = 32 }, new Move { Name = "Fling", At = 36 }, new Move { Name = "Nasty Plot", At = 39 }, new Move { Name = "Last Resort", At = 43 }, },
                },

                new Species() {
                    Name = "Drifloon",
                    moves = { new Move { Name = "Constrict", At = 1 }, new Move { Name = "Minimize", At = 1 }, new Move { Name = "Astonish", At = 4 }, new Move { Name = "Gust", At = 8 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Payback", At = 16 }, new Move { Name = "Ominous Wind", At = 20 }, new Move { Name = "Stockpile", At = 25 }, new Move { Name = "Hex", At = 27 }, new Move { Name = "Swallow", At = 32 }, new Move { Name = "Spit Up", At = 32 }, new Move { Name = "Shadow Ball", At = 36 }, new Move { Name = "Amnesia", At = 40 }, new Move { Name = "Baton Pass", At = 44 }, new Move { Name = "Explosion", At = 50 }, },
                    eggMoves = { "Memento", "Body Slam", "Destiny Bond", "Disable", "Haze", "Hypnosis", "Weather Ball", "Clear Smog", "Defog", "Tailwind", },
                },

                new Species() {
                    Name = "Drifblim",
                    moves = { new Move { Name = "Phantom Force", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Minimize", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Astonish", At = 4 }, new Move { Name = "Gust", At = 8 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Payback", At = 16 }, new Move { Name = "Ominous Wind", At = 20 }, new Move { Name = "Stockpile", At = 25 }, new Move { Name = "Hex", At = 27 }, new Move { Name = "Swallow", At = 34 }, new Move { Name = "Spit Up", At = 34 }, new Move { Name = "Shadow Ball", At = 40 }, new Move { Name = "Amnesia", At = 46 }, new Move { Name = "Baton Pass", At = 52 }, new Move { Name = "Explosion", At = 60 }, new Move { Name = "Phantom Force", At = 65 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Buneary",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Splash", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Endure", At = 6 }, new Move { Name = "Baby-Doll Eyes", At = 10 }, new Move { Name = "Frustration", At = 13 }, new Move { Name = "Quick Attack", At = 16 }, new Move { Name = "Jump Kick", At = 23 }, new Move { Name = "Baton Pass", At = 26 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Dizzy Punch", At = 36 }, new Move { Name = "After You", At = 43 }, new Move { Name = "Charm", At = 46 }, new Move { Name = "Entrainment", At = 50 }, new Move { Name = "Bounce", At = 56 }, new Move { Name = "Healing Wish", At = 63 }, },
                    eggMoves = { "Fake Tears", "Fake Out", "Encore", "Sweet Kiss", "Double Hit", "Low Kick", "Sky Uppercut", "Switcheroo", "Thunder Punch", "Ice Punch", "Fire Punch", "Flail", "Focus Punch", "Circle Throw", "Copycat", "Teeter Dance", "Cosmic Power", "Mud Sport", },
                },

                new Species() {
                    Name = "Lopunny",
                    moves = { new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Bounce", At = 1 }, new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Mirror Coat", At = 1 }, new Move { Name = "Magic Coat", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Splash", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Endure", At = 6 }, new Move { Name = "Return", At = 13 }, new Move { Name = "Quick Attack", At = 16 }, new Move { Name = "Jump Kick", At = 23 }, new Move { Name = "Baton Pass", At = 26 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Dizzy Punch", At = 36 }, new Move { Name = "After You", At = 43 }, new Move { Name = "Charm", At = 46 }, new Move { Name = "Entrainment", At = 53 }, new Move { Name = "Bounce", At = 56 }, new Move { Name = "Healing Wish", At = 63 }, new Move { Name = "High Jump Kick", At = 66 }, },
                },

                new Species() {
                    Name = "Mismagius",
                    moves = { new Move { Name = "Mystical Fire", At = 1 }, new Move { Name = "Power Gem", At = 1 }, new Move { Name = "Phantom Force", At = 1 }, new Move { Name = "Lucky Chant", At = 1 }, new Move { Name = "Magical Leaf", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Psywave", At = 1 }, new Move { Name = "Spite", At = 1 }, new Move { Name = "Astonish", At = 1 }, },
                },

                new Species() {
                    Name = "Honchkrow",
                    moves = { new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Sucker Punch", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Pursuit", At = 1 }, new Move { Name = "Haze", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Swagger", At = 25 }, new Move { Name = "Nasty Plot", At = 35 }, new Move { Name = "Foul Play", At = 45 }, new Move { Name = "Night Slash", At = 55 }, new Move { Name = "Quash", At = 65 }, new Move { Name = "Dark Pulse", At = 75 }, },
                },

                new Species() {
                    Name = "Glameow",
                    moves = { new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Scratch", At = 5 }, new Move { Name = "Growl", At = 8 }, new Move { Name = "Hypnosis", At = 13 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Fury Swipes", At = 20 }, new Move { Name = "Charm", At = 25 }, new Move { Name = "Assist", At = 29 }, new Move { Name = "Captivate", At = 32 }, new Move { Name = "Slash", At = 37 }, new Move { Name = "Sucker Punch", At = 41 }, new Move { Name = "Attract", At = 44 }, new Move { Name = "Hone Claws", At = 48 }, new Move { Name = "Play Rough", At = 50 }, },
                    eggMoves = { "Bite", "Tail Whip", "Quick Attack", "Sand Attack", "Fake Tears", "Assurance", "Flail", "Snatch", "Wake-Up Slap", "Last Resort", },
                },

                new Species() {
                    Name = "Purugly",
                    moves = { new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Scratch", At = 5 }, new Move { Name = "Growl", At = 8 }, new Move { Name = "Hypnosis", At = 13 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Fury Swipes", At = 20 }, new Move { Name = "Charm", At = 25 }, new Move { Name = "Assist", At = 29 }, new Move { Name = "Captivate", At = 32 }, new Move { Name = "Slash", At = 37 }, new Move { Name = "Swagger", At = 38 }, new Move { Name = "Body Slam", At = 45 }, new Move { Name = "Attract", At = 52 }, new Move { Name = "Hone Claws", At = 60 }, },
                    eggMoves = { "Bite", "Tail Whip", "Quick Attack", "Sand Attack", "Fake Tears", "Assurance", "Flail", "Snatch", "Wake-Up Slap", "Last Resort", },
                },

                new Species() {
                    Name = "Chingling",
                    moves = { new Move { Name = "Wrap", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Confusion", At = 10 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Last Resort", At = 16 }, new Move { Name = "Entrainment", At = 19 }, new Move { Name = "Uproar", At = 32 }, },
                    eggMoves = { "Disable", "Curse", "Hypnosis", "Wish", "Future Sight", "Recover", "Stored Power", "Skill Swap", "Cosmic Power", },
                    oras5 = "Cleanse Tag",
                },

                new Species() {
                    Name = "Stunky",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Poison Gas", At = 4 }, new Move { Name = "Screech", At = 7 }, new Move { Name = "Fury Swipes", At = 10 }, new Move { Name = "Smokescreen", At = 14 }, new Move { Name = "Feint", At = 18 }, new Move { Name = "Slash", At = 22 }, new Move { Name = "Toxic", At = 27 }, new Move { Name = "Acid Spray", At = 32 }, new Move { Name = "Night Slash", At = 37 }, new Move { Name = "Memento", At = 43 }, new Move { Name = "Belch", At = 46 }, new Move { Name = "Explosion", At = 49 }, },
                    eggMoves = { "Pursuit", "Leer", "Smog", "Double-Edge", "Crunch", "Scary Face", "Astonish", "Punishment", "Haze", "Iron Tail", "Foul Play", "Flame Burst", "Play Rough", },
                },

                new Species() {
                    Name = "Skuntank",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Poison Gas", At = 4 }, new Move { Name = "Screech", At = 7 }, new Move { Name = "Fury Swipes", At = 10 }, new Move { Name = "Smokescreen", At = 14 }, new Move { Name = "Feint", At = 18 }, new Move { Name = "Slash", At = 22 }, new Move { Name = "Toxic", At = 27 }, new Move { Name = "Acid Spray", At = 32 }, new Move { Name = "Flamethrower", At = 34 }, new Move { Name = "Night Slash", At = 41 }, new Move { Name = "Memento", At = 51 }, new Move { Name = "Belch", At = 56 }, new Move { Name = "Explosion", At = 61 }, },
                },

                new Species() {
                    Name = "Bronzor",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Hypnosis", At = 5 }, new Move { Name = "Imprison", At = 9 }, new Move { Name = "Confuse Ray", At = 11 }, new Move { Name = "Psywave", At = 15 }, new Move { Name = "Iron Defense", At = 19 }, new Move { Name = "Feint Attack", At = 21 }, new Move { Name = "Safeguard", At = 25 }, new Move { Name = "Future Sight", At = 29 }, new Move { Name = "Metal Sound", At = 31 }, new Move { Name = "Gyro Ball", At = 35 }, new Move { Name = "Extrasensory", At = 39 }, new Move { Name = "Payback", At = 41 }, new Move { Name = "Heal Block", At = 45 }, new Move { Name = "Heavy Slam", At = 49 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Bronzong",
                    moves = { new Move { Name = "Sunny Day", At = 1 }, new Move { Name = "Rain Dance", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, new Move { Name = "Imprison", At = 1 }, new Move { Name = "Hypnosis", At = 5 }, new Move { Name = "Imprison", At = 9 }, new Move { Name = "Confuse Ray", At = 11 }, new Move { Name = "Psywave", At = 15 }, new Move { Name = "Iron Defense", At = 19 }, new Move { Name = "Feint Attack", At = 21 }, new Move { Name = "Safeguard", At = 25 }, new Move { Name = "Future Sight", At = 29 }, new Move { Name = "Metal Sound", At = 31 }, new Move { Name = "Block", At = 33 }, new Move { Name = "Gyro Ball", At = 36 }, new Move { Name = "Extrasensory", At = 42 }, new Move { Name = "Payback", At = 46 }, new Move { Name = "Heal Block", At = 52 }, new Move { Name = "Heavy Slam", At = 58 }, },
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Bonsly",
                    moves = { new Move { Name = "Fake Tears", At = 1 }, new Move { Name = "Copycat", At = 1 }, new Move { Name = "Flail", At = 5 }, new Move { Name = "Low Kick", At = 8 }, new Move { Name = "Rock Throw", At = 12 }, new Move { Name = "Mimic", At = 15 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Rock Tomb", At = 22 }, new Move { Name = "Block", At = 26 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Counter", At = 33 }, new Move { Name = "Sucker Punch", At = 36 }, new Move { Name = "Double-Edge", At = 40 }, },
                    eggMoves = { "Self-Destruct", "Headbutt", "Harden", "Defense Curl", "Rollout", "Sand Tomb", "Stealth Rock", "Curse", "Endure", },
                },

                new Species() {
                    Name = "Mime Jr.",
                    moves = { new Move { Name = "Tickle", At = 1 }, new Move { Name = "Barrier", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Copycat", At = 4 }, new Move { Name = "Meditate", At = 8 }, new Move { Name = "Double Slap", At = 11 }, new Move { Name = "Mimic", At = 15 }, new Move { Name = "Encore", At = 18 }, new Move { Name = "Light Screen", At = 22 }, new Move { Name = "Reflect", At = 22 }, new Move { Name = "Psybeam", At = 25 }, new Move { Name = "Substitute", At = 29 }, new Move { Name = "Recycle", At = 32 }, new Move { Name = "Trick", At = 36 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Role Play", At = 43 }, new Move { Name = "Baton Pass", At = 46 }, new Move { Name = "Safeguard", At = 50 }, },
                    eggMoves = { "Future Sight", "Hypnosis", "Mimic", "Fake Out", "Trick", "Confuse Ray", "Wake-Up Slap", "Teeter Dance", "Healing Wish", "Charm", "Nasty Plot", "Power Split", "Magic Room", "Icy Wind", },
                },

                new Species() {
                    Name = "Happiny",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Charm", At = 1 }, new Move { Name = "Copycat", At = 5 }, new Move { Name = "Refresh", At = 9 }, new Move { Name = "Sweet Kiss", At = 12 }, },
                    eggMoves = { "Present", "Metronome", "Heal Bell", "Aromatherapy", "Counter", "Helping Hand", "Gravity", "Last Resort", "Mud Bomb", "Natural Gift", "Endure", },
                    item5 = "Lucky Egg",
                    item50 = "Oval Stone",
                },

                new Species() {
                    Name = "Chatot",
                    moves = { new Move { Name = "Hyper Voice", At = 1 }, new Move { Name = "Chatter", At = 1 }, new Move { Name = "Confide", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Growl", At = 5 }, new Move { Name = "Mirror Move", At = 9 }, new Move { Name = "Sing", At = 13 }, new Move { Name = "Fury Attack", At = 17 }, new Move { Name = "Chatter", At = 21 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Round", At = 29 }, new Move { Name = "Mimic", At = 33 }, new Move { Name = "Echoed Voice", At = 37 }, new Move { Name = "Roost", At = 41 }, new Move { Name = "Uproar", At = 45 }, new Move { Name = "Synchronoise", At = 49 }, new Move { Name = "Feather Dance", At = 50 }, new Move { Name = "Hyper Voice", At = 57 }, },
                    eggMoves = { "Encore", "Night Shade", "Agility", "Nasty Plot", "Supersonic", "Steel Wing", "Sleep Talk", "Defog", "Air Cutter", "Boomburst", },
                    item5 = "Metronome",
                },

                new Species() {
                    Name = "Spiritomb",
                    moves = { new Move { Name = "Curse", At = 1 }, new Move { Name = "Pursuit", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Spite", At = 1 }, new Move { Name = "Shadow Sneak", At = 1 }, new Move { Name = "Feint Attack", At = 7 }, new Move { Name = "Hypnosis", At = 13 }, new Move { Name = "Dream Eater", At = 19 }, new Move { Name = "Ominous Wind", At = 25 }, new Move { Name = "Sucker Punch", At = 31 }, new Move { Name = "Nasty Plot", At = 37 }, new Move { Name = "Memento", At = 43 }, new Move { Name = "Dark Pulse", At = 49 }, },
                    eggMoves = { "Destiny Bond", "Pain Split", "Smokescreen", "Imprison", "Grudge", "Shadow Sneak", "Captivate", "Nightmare", "Foul Play", },
                    FS = true,
                },

                new Species() {
                    Name = "Gible",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 3 }, new Move { Name = "Dragon Rage", At = 7 }, new Move { Name = "Sandstorm", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Sand Tomb", At = 19 }, new Move { Name = "Slash", At = 25 }, new Move { Name = "Dragon Claw", At = 27 }, new Move { Name = "Dig", At = 31 }, new Move { Name = "Dragon Rush", At = 37 }, },
                    eggMoves = { "Dragon Breath", "Outrage", "Twister", "Scary Face", "Double-Edge", "Thrash", "Metal Claw", "Sand Tomb", "Body Slam", "Iron Head", "Mud Shot", "Rock Climb", "Iron Tail", },
                    eggRand = 5,
                },

                new Species() {
                    Name = "Gabite",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Sand Attack", At = 3 }, new Move { Name = "Dragon Rage", At = 7 }, new Move { Name = "Sandstorm", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Sand Tomb", At = 19 }, new Move { Name = "Dual Chop", At = 24 }, new Move { Name = "Slash", At = 28 }, new Move { Name = "Dragon Claw", At = 33 }, new Move { Name = "Dig", At = 40 }, new Move { Name = "Dragon Rush", At = 49 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Garchomp",
                    moves = { new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Sandstorm", At = 1 }, new Move { Name = "Sand Attack", At = 3 }, new Move { Name = "Dragon Rage", At = 7 }, new Move { Name = "Sandstorm", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Sand Tomb", At = 19 }, new Move { Name = "Dual Chop", At = 24 }, new Move { Name = "Slash", At = 28 }, new Move { Name = "Dragon Claw", At = 33 }, new Move { Name = "Dig", At = 40 }, new Move { Name = "Crunch", At = 48 }, new Move { Name = "Dragon Rush", At = 55 }, },
                },

                new Species() {
                    Name = "Munchlax",
                    moves = { new Move { Name = "Last Resort", At = 1 }, new Move { Name = "Recycle", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Metronome", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Defense Curl", At = 4 }, new Move { Name = "Amnesia", At = 9 }, new Move { Name = "Lick", At = 12 }, new Move { Name = "Chip Away", At = 17 }, new Move { Name = "Screech", At = 20 }, new Move { Name = "Body Slam", At = 25 }, new Move { Name = "Stockpile", At = 28 }, new Move { Name = "Swallow", At = 33 }, new Move { Name = "Rollout", At = 36 }, new Move { Name = "Fling", At = 41 }, new Move { Name = "Belly Drum", At = 44 }, new Move { Name = "Natural Gift", At = 49 }, new Move { Name = "Snatch", At = 50 }, new Move { Name = "Last Resort", At = 57 }, },
                    eggMoves = { "Lick", "Charm", "Double-Edge", "Curse", "Whirlwind", "Pursuit", "Zen Headbutt", "Counter", "Natural Gift", "After You", "Self-Destruct", "Belch", },
                    item100 = "Leftovers",
                },

                new Species() {
                    Name = "Riolu",
                    moves = { new Move { Name = "Foresight", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Endure", At = 1 }, new Move { Name = "Counter", At = 6 }, new Move { Name = "Feint", At = 11 }, new Move { Name = "Force Palm", At = 15 }, new Move { Name = "Copycat", At = 19 }, new Move { Name = "Screech", At = 24 }, new Move { Name = "Reversal", At = 29 }, new Move { Name = "Nasty Plot", At = 47 }, new Move { Name = "Final Gambit", At = 50 }, },
                    eggMoves = { "Cross Chop", "Detect", "Bite", "Mind Reader", "Sky Uppercut", "High Jump Kick", "Agility", "Vacuum Wave", "Crunch", "Low Kick", "Iron Defense", "Blaze Kick", "Bullet Punch", "Follow Me", "Circle Throw", },
                    FS = true,
                },

                new Species() {
                    Name = "Lucario",
                    moves = { new Move { Name = "Extreme Speed", At = 1 }, new Move { Name = "Dragon Pulse", At = 1 }, new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Aura Sphere", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Detect", At = 1 }, new Move { Name = "Metal Claw", At = 1 }, new Move { Name = "Counter", At = 6 }, new Move { Name = "Feint", At = 11 }, new Move { Name = "Power-Up Punch", At = 15 }, new Move { Name = "Swords Dance", At = 19 }, new Move { Name = "Metal Sound", At = 24 }, new Move { Name = "Bone Rush", At = 29 }, new Move { Name = "Quick Guard", At = 33 }, new Move { Name = "Me First", At = 37 }, new Move { Name = "Aura Sphere", At = 42 }, new Move { Name = "Calm Mind", At = 47 }, new Move { Name = "Heal Pulse", At = 51 }, new Move { Name = "Close Combat", At = 55 }, new Move { Name = "Dragon Pulse", At = 60 }, new Move { Name = "Extreme Speed", At = 65 }, },
                },

                new Species() {
                    Name = "Hippopotas",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Dig", At = 19 }, new Move { Name = "Sand Tomb", At = 25 }, new Move { Name = "Crunch", At = 31 }, new Move { Name = "Earthquake", At = 37 }, new Move { Name = "Double-Edge", At = 44 }, new Move { Name = "Fissure", At = 50 }, },
                    eggMoves = { "Stockpile", "Swallow", "Spit Up", "Curse", "Slack Off", "Body Slam", "Sand Tomb", "Revenge", "Sleep Talk", "Whirlwind", },
                },

                new Species() {
                    Name = "Hippowdon",
                    moves = { new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Yawn", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Yawn", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Dig", At = 19 }, new Move { Name = "Sand Tomb", At = 25 }, new Move { Name = "Crunch", At = 31 }, new Move { Name = "Earthquake", At = 40 }, new Move { Name = "Double-Edge", At = 50 }, new Move { Name = "Fissure", At = 60 }, },
                },

                new Species() {
                    Name = "Skorupi",
                    moves = { new Move { Name = "Bite", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Knock Off", At = 5 }, new Move { Name = "Pin Missile", At = 9 }, new Move { Name = "Acupressure", At = 13 }, new Move { Name = "Pursuit", At = 16 }, new Move { Name = "Bug Bite", At = 20 }, new Move { Name = "Poison Fang", At = 23 }, new Move { Name = "Venoshock", At = 27 }, new Move { Name = "Hone Claws", At = 30 }, new Move { Name = "Toxic Spikes", At = 34 }, new Move { Name = "Night Slash", At = 38 }, new Move { Name = "Scary Face", At = 41 }, new Move { Name = "Crunch", At = 45 }, new Move { Name = "Fell Stinger", At = 47 }, new Move { Name = "Cross Poison", At = 49 }, },
                    eggMoves = { "Feint Attack", "Screech", "Sand Attack", "Slash", "Confuse Ray", "Whirlwind", "Agility", "Pursuit", "Night Slash", "Iron Tail", "Twineedle", "Poison Tail", },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Drapion",
                    moves = { new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Knock Off", At = 1 }, new Move { Name = "Knock Off", At = 5 }, new Move { Name = "Pin Missile", At = 9 }, new Move { Name = "Acupressure", At = 13 }, new Move { Name = "Pursuit", At = 16 }, new Move { Name = "Bug Bite", At = 20 }, new Move { Name = "Poison Fang", At = 23 }, new Move { Name = "Venoshock", At = 27 }, new Move { Name = "Hone Claws", At = 30 }, new Move { Name = "Toxic Spikes", At = 34 }, new Move { Name = "Night Slash", At = 38 }, new Move { Name = "Scary Face", At = 43 }, new Move { Name = "Crunch", At = 49 }, new Move { Name = "Fell Stinger", At = 53 }, new Move { Name = "Cross Poison", At = 57 }, },
                    FS = true,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Croagunk",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Mud-Slap", At = 3 }, new Move { Name = "Poison Sting", At = 8 }, new Move { Name = "Taunt", At = 10 }, new Move { Name = "Pursuit", At = 15 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Revenge", At = 22 }, new Move { Name = "Swagger", At = 24 }, new Move { Name = "Mud Bomb", At = 29 }, new Move { Name = "Sucker Punch", At = 31 }, new Move { Name = "Venoshock", At = 36 }, new Move { Name = "Nasty Plot", At = 38 }, new Move { Name = "Poison Jab", At = 43 }, new Move { Name = "Sludge Bomb", At = 45 }, new Move { Name = "Belch", At = 47 }, new Move { Name = "Flatter", At = 50 }, },
                    eggMoves = { "Me First", "Feint", "Dynamic Punch", "Headbutt", "Vacuum Wave", "Meditate", "Fake Out", "Wake-Up Slap", "Smelling Salts", "Cross Chop", "Bullet Punch", "Counter", "Drain Punch", "Acupressure", "Quick Guard", },
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Toxicroak",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Mud-Slap", At = 3 }, new Move { Name = "Poison Sting", At = 8 }, new Move { Name = "Taunt", At = 10 }, new Move { Name = "Pursuit", At = 15 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Revenge", At = 22 }, new Move { Name = "Swagger", At = 24 }, new Move { Name = "Mud Bomb", At = 29 }, new Move { Name = "Sucker Punch", At = 31 }, new Move { Name = "Venoshock", At = 36 }, new Move { Name = "Nasty Plot", At = 41 }, new Move { Name = "Poison Jab", At = 49 }, new Move { Name = "Sludge Bomb", At = 54 }, new Move { Name = "Belch", At = 58 }, new Move { Name = "Flatter", At = 62 }, },
                    FS = true,
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Carnivine",
                    moves = { new Move { Name = "Bind", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Bite", At = 7 }, new Move { Name = "Vine Whip", At = 11 }, new Move { Name = "Sweet Scent", At = 17 }, new Move { Name = "Ingrain", At = 21 }, new Move { Name = "Feint Attack", At = 27 }, new Move { Name = "Leaf Tornado", At = 31 }, new Move { Name = "Stockpile", At = 37 }, new Move { Name = "Spit Up", At = 37 }, new Move { Name = "Swallow", At = 37 }, new Move { Name = "Crunch", At = 41 }, new Move { Name = "Wring Out", At = 47 }, new Move { Name = "Power Whip", At = 50 }, },
                    eggMoves = { "Sleep Powder", "Stun Spore", "Razor Leaf", "Slam", "Synthesis", "Magical Leaf", "Leech Seed", "Worry Seed", "Giga Drain", "Rage Powder", "Grass Whistle", },
                },

                new Species() {
                    Name = "Finneon",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Water Gun", At = 6 }, new Move { Name = "Attract", At = 10 }, new Move { Name = "Rain Dance", At = 13 }, new Move { Name = "Gust", At = 17 }, new Move { Name = "Water Pulse", At = 22 }, new Move { Name = "Captivate", At = 26 }, new Move { Name = "Safeguard", At = 29 }, new Move { Name = "Aqua Ring", At = 33 }, new Move { Name = "Whirlpool", At = 38 }, new Move { Name = "U-turn", At = 42 }, new Move { Name = "Bounce", At = 45 }, new Move { Name = "Silver Wind", At = 49 }, new Move { Name = "Soak", At = 54 }, },
                    eggMoves = { "Sweet Kiss", "Charm", "Flail", "Aqua Tail", "Splash", "Psybeam", "Tickle", "Agility", "Brine", "Aurora Beam", "Signal Beam", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Lumineon",
                    moves = { new Move { Name = "Soak", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Attract", At = 1 }, new Move { Name = "Water Gun", At = 6 }, new Move { Name = "Attract", At = 10 }, new Move { Name = "Rain Dance", At = 13 }, new Move { Name = "Gust", At = 17 }, new Move { Name = "Water Pulse", At = 22 }, new Move { Name = "Captivate", At = 26 }, new Move { Name = "Safeguard", At = 29 }, new Move { Name = "Aqua Ring", At = 35 }, new Move { Name = "Whirlpool", At = 42 }, new Move { Name = "U-turn", At = 48 }, new Move { Name = "Bounce", At = 53 }, new Move { Name = "Silver Wind", At = 59 }, new Move { Name = "Soak", At = 66 }, },
                },

                new Species() {
                    Name = "Mantyke",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Supersonic", At = 3 }, new Move { Name = "Bubble Beam", At = 7 }, new Move { Name = "Confuse Ray", At = 11 }, new Move { Name = "Wing Attack", At = 14 }, new Move { Name = "Headbutt", At = 16 }, new Move { Name = "Water Pulse", At = 19 }, new Move { Name = "Wide Guard", At = 23 }, new Move { Name = "Take Down", At = 27 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Air Slash", At = 36 }, new Move { Name = "Aqua Ring", At = 39 }, new Move { Name = "Bounce", At = 46 }, new Move { Name = "Hydro Pump", At = 49 }, },
                    eggMoves = { "Twister", "Hydro Pump", "Haze", "Slam", "Mud Sport", "Mirror Coat", "Water Sport", "Splash", "Signal Beam", "Wide Guard", "Amnesia", "Tailwind", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Snover",
                    moves = { new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Razor Leaf", At = 5 }, new Move { Name = "Icy Wind", At = 9 }, new Move { Name = "Grass Whistle", At = 13 }, new Move { Name = "Swagger", At = 17 }, new Move { Name = "Mist", At = 21 }, new Move { Name = "Ice Shard", At = 26 }, new Move { Name = "Ingrain", At = 31 }, new Move { Name = "Wood Hammer", At = 36 }, new Move { Name = "Blizzard", At = 41 }, new Move { Name = "Sheer Cold", At = 46 }, },
                    eggMoves = { "Leech Seed", "Magical Leaf", "Seed Bomb", "Growth", "Double-Edge", "Mist", "Stomp", "Skull Bash", "Avalanche", "Natural Gift", "Bullet Seed", },
                    FS = true,
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Abomasnow",
                    moves = { new Move { Name = "Ice Punch", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Icy Wind", At = 1 }, new Move { Name = "Razor Leaf", At = 5 }, new Move { Name = "Icy Wind", At = 9 }, new Move { Name = "Grass Whistle", At = 13 }, new Move { Name = "Swagger", At = 17 }, new Move { Name = "Mist", At = 21 }, new Move { Name = "Ice Shard", At = 26 }, new Move { Name = "Ingrain", At = 31 }, new Move { Name = "Wood Hammer", At = 36 }, new Move { Name = "Blizzard", At = 47 }, new Move { Name = "Sheer Cold", At = 58 }, },
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Weavile",
                    moves = { new Move { Name = "Embargo", At = 1 }, new Move { Name = "Revenge", At = 1 }, new Move { Name = "Assurance", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Quick Attack", At = 8 }, new Move { Name = "Feint Attack", At = 10 }, new Move { Name = "Icy Wind", At = 14 }, new Move { Name = "Fury Swipes", At = 16 }, new Move { Name = "Nasty Plot", At = 20 }, new Move { Name = "Metal Claw", At = 22 }, new Move { Name = "Hone Claws", At = 25 }, new Move { Name = "Fling", At = 28 }, new Move { Name = "Screech", At = 32 }, new Move { Name = "Night Slash", At = 35 }, new Move { Name = "Snatch", At = 40 }, new Move { Name = "Punishment", At = 44 }, new Move { Name = "Dark Pulse", At = 47 }, },
                    item5 = "Quick Claw",
                    xy50 = "Grip Claw",
                },

                new Species() {
                    Name = "Magnezone",
                    moves = { new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Magnetic Flux", At = 1 }, new Move { Name = "Mirror Coat", At = 1 }, new Move { Name = "Barrier", At = 1 }, new Move { Name = "Electric Terrain", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Sonic Boom", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Thunder Shock", At = 7 }, new Move { Name = "Sonic Boom", At = 11 }, new Move { Name = "Thunder Wave", At = 13 }, new Move { Name = "Magnet Bomb", At = 17 }, new Move { Name = "Spark", At = 19 }, new Move { Name = "Mirror Shot", At = 23 }, new Move { Name = "Metal Sound", At = 25 }, new Move { Name = "Electro Ball", At = 29 }, new Move { Name = "Flash Cannon", At = 33 }, new Move { Name = "Screech", At = 39 }, new Move { Name = "Discharge", At = 43 }, new Move { Name = "Lock-On", At = 49 }, new Move { Name = "Magnet Rise", At = 53 }, new Move { Name = "Gyro Ball", At = 59 }, new Move { Name = "Zap Cannon", At = 63 }, },
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Lickilicky",
                    moves = { new Move { Name = "Wring Out", At = 1 }, new Move { Name = "Power Whip", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Defense Curl", At = 9 }, new Move { Name = "Knock Off", At = 13 }, new Move { Name = "Wrap", At = 17 }, new Move { Name = "Stomp", At = 21 }, new Move { Name = "Disable", At = 25 }, new Move { Name = "Slam", At = 29 }, new Move { Name = "Rollout", At = 33 }, new Move { Name = "Chip Away", At = 37 }, new Move { Name = "Me First", At = 41 }, new Move { Name = "Refresh", At = 45 }, new Move { Name = "Screech", At = 49 }, new Move { Name = "Power Whip", At = 53 }, new Move { Name = "Wring Out", At = 57 }, new Move { Name = "Gyro Ball", At = 61 }, },
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Rhyperior",
                    moves = { new Move { Name = "Rock Wrecker", At = 1 }, new Move { Name = "Horn Drill", At = 1 }, new Move { Name = "Poison Jab", At = 1 }, new Move { Name = "Horn Attack", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Scary Face", At = 9 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Stomp", At = 17 }, new Move { Name = "Bulldoze", At = 21 }, new Move { Name = "Chip Away", At = 25 }, new Move { Name = "Rock Blast", At = 29 }, new Move { Name = "Drill Run", At = 33 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Stone Edge", At = 41 }, new Move { Name = "Hammer Arm", At = 42 }, new Move { Name = "Earthquake", At = 48 }, new Move { Name = "Megahorn", At = 55 }, new Move { Name = "Horn Drill", At = 62 }, new Move { Name = "Rock Wrecker", At = 69 }, },
                },

                new Species() {
                    Name = "Tangrowth",
                    moves = { new Move { Name = "Block", At = 1 }, new Move { Name = "Ingrain", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Sleep Powder", At = 4 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Absorb", At = 10 }, new Move { Name = "Poison Powder", At = 14 }, new Move { Name = "Bind", At = 17 }, new Move { Name = "Growth", At = 20 }, new Move { Name = "Mega Drain", At = 23 }, new Move { Name = "Knock Off", At = 27 }, new Move { Name = "Stun Spore", At = 30 }, new Move { Name = "Natural Gift", At = 33 }, new Move { Name = "Giga Drain", At = 36 }, new Move { Name = "Ancient Power", At = 40 }, new Move { Name = "Slam", At = 43 }, new Move { Name = "Tickle", At = 46 }, new Move { Name = "Wring Out", At = 49 }, new Move { Name = "Grassy Terrain", At = 50 }, new Move { Name = "Power Whip", At = 53 }, new Move { Name = "Block", At = 56 }, },
                },

                new Species() {
                    Name = "Electivire",
                    moves = { new Move { Name = "Electric Terrain", At = 1 }, new Move { Name = "Ion Deluge", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Thunder Shock", At = 5 }, new Move { Name = "Low Kick", At = 8 }, new Move { Name = "Swift", At = 12 }, new Move { Name = "Shock Wave", At = 15 }, new Move { Name = "Thunder Wave", At = 19 }, new Move { Name = "Electro Ball", At = 22 }, new Move { Name = "Light Screen", At = 26 }, new Move { Name = "Thunder Punch", At = 29 }, new Move { Name = "Discharge", At = 36 }, new Move { Name = "Screech", At = 42 }, new Move { Name = "Thunderbolt", At = 49 }, new Move { Name = "Thunder", At = 55 }, new Move { Name = "Giga Impact", At = 62 }, new Move { Name = "Electric Terrain", At = 65 }, },
                    item5 = "Electirizer",
                },

                new Species() {
                    Name = "Magmortar",
                    moves = { new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Smokescreen", At = 8 }, new Move { Name = "Feint Attack", At = 12 }, new Move { Name = "Fire Spin", At = 15 }, new Move { Name = "Clear Smog", At = 19 }, new Move { Name = "Flame Burst", At = 22 }, new Move { Name = "Confuse Ray", At = 26 }, new Move { Name = "Fire Punch", At = 29 }, new Move { Name = "Lava Plume", At = 36 }, new Move { Name = "Sunny Day", At = 42 }, new Move { Name = "Flamethrower", At = 49 }, new Move { Name = "Fire Blast", At = 55 }, new Move { Name = "Hyper Beam", At = 62 }, },
                    item5 = "Magmarizer",
                },

                new Species() {
                    Name = "Togekiss",
                    moves = { new Move { Name = "After You", At = 1 }, new Move { Name = "Sky Attack", At = 1 }, new Move { Name = "Extreme Speed", At = 1 }, new Move { Name = "Aura Sphere", At = 1 }, new Move { Name = "Air Slash", At = 1 }, },
                },

                new Species() {
                    Name = "Yanmega",
                    moves = { new Move { Name = "Bug Buzz", At = 1 }, new Move { Name = "Air Slash", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Double Team", At = 11 }, new Move { Name = "Sonic Boom", At = 14 }, new Move { Name = "Detect", At = 17 }, new Move { Name = "Supersonic", At = 22 }, new Move { Name = "Uproar", At = 27 }, new Move { Name = "Pursuit", At = 30 }, new Move { Name = "Ancient Power", At = 33 }, new Move { Name = "Feint", At = 38 }, new Move { Name = "Slash", At = 43 }, new Move { Name = "Screech", At = 46 }, new Move { Name = "U-turn", At = 49 }, new Move { Name = "Air Slash", At = 54 }, new Move { Name = "Bug Buzz", At = 57 }, },
                    item5 = "Wide Lens",
                },

                new Species() {
                    Name = "Leafeon",
                    moves = { new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Razor Leaf", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Grass Whistle", At = 17 }, new Move { Name = "Magical Leaf", At = 20 }, new Move { Name = "Giga Drain", At = 25 }, new Move { Name = "Swords Dance", At = 29 }, new Move { Name = "Synthesis", At = 33 }, new Move { Name = "Sunny Day", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Leaf Blade", At = 45 }, },
                },

                new Species() {
                    Name = "Glaceon",
                    moves = { new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Icy Wind", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Ice Fang", At = 20 }, new Move { Name = "Ice Shard", At = 25 }, new Move { Name = "Barrier", At = 29 }, new Move { Name = "Mirror Coat", At = 33 }, new Move { Name = "Hail", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Blizzard", At = 45 }, },
                },

                new Species() {
                    Name = "Gliscor",
                    moves = { new Move { Name = "Guillotine", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Poison Jab", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Knock Off", At = 1 }, new Move { Name = "Sand Attack", At = 4 }, new Move { Name = "Harden", At = 7 }, new Move { Name = "Knock Off", At = 10 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Fury Cutter", At = 16 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Acrobatics", At = 22 }, new Move { Name = "Night Slash", At = 27 }, new Move { Name = "U-turn", At = 30 }, new Move { Name = "Screech", At = 35 }, new Move { Name = "X-Scissor", At = 40 }, new Move { Name = "Sky Uppercut", At = 45 }, new Move { Name = "Swords Dance", At = 50 }, new Move { Name = "Guillotine", At = 55 }, },
                },

                new Species() {
                    Name = "Mamoswine",
                    moves = { new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Ancient Power", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Mud Sport", At = 5 }, new Move { Name = "Powder Snow", At = 8 }, new Move { Name = "Mud-Slap", At = 11 }, new Move { Name = "Endure", At = 14 }, new Move { Name = "Mud Bomb", At = 18 }, new Move { Name = "Hail", At = 21 }, new Move { Name = "Ice Fang", At = 24 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Double Hit", At = 33 }, new Move { Name = "Mist", At = 37 }, new Move { Name = "Thrash", At = 41 }, new Move { Name = "Earthquake", At = 46 }, new Move { Name = "Blizzard", At = 52 }, new Move { Name = "Scary Face", At = 58 }, },
                },

                new Species() {
                    Name = "Porygon-Z",
                    moves = { new Move { Name = "Trick Room", At = 1 }, new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Magic Coat", At = 1 }, new Move { Name = "Conversion 2", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Conversion", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Psybeam", At = 7 }, new Move { Name = "Agility", At = 12 }, new Move { Name = "Recover", At = 18 }, new Move { Name = "Magnet Rise", At = 23 }, new Move { Name = "Signal Beam", At = 29 }, new Move { Name = "Embargo", At = 34 }, new Move { Name = "Discharge", At = 40 }, new Move { Name = "Lock-On", At = 45 }, new Move { Name = "Tri Attack", At = 50 }, new Move { Name = "Magic Coat", At = 56 }, new Move { Name = "Zap Cannon", At = 62 }, new Move { Name = "Hyper Beam", At = 67 }, },
                },

                new Species() {
                    Name = "Gallade",
                    moves = { new Move { Name = "Stored Power", At = 1 }, new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Leaf Blade", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Teleport", At = 1 }, new Move { Name = "Confusion", At = 4 }, new Move { Name = "Double Team", At = 6 }, new Move { Name = "Teleport", At = 9 }, new Move { Name = "Quick Guard", At = 11 }, new Move { Name = "Fury Cutter", At = 14 }, new Move { Name = "Slash", At = 17 }, new Move { Name = "Heal Pulse", At = 19 }, new Move { Name = "Wide Guard", At = 23 }, new Move { Name = "Swords Dance", At = 26 }, new Move { Name = "Psycho Cut", At = 31 }, new Move { Name = "Helping Hand", At = 35 }, new Move { Name = "Feint", At = 40 }, new Move { Name = "False Swipe", At = 44 }, new Move { Name = "Protect", At = 49 }, new Move { Name = "Close Combat", At = 53 }, new Move { Name = "Stored Power", At = 58 }, },
                },

                new Species() {
                    Name = "Probopass",
                    moves = { new Move { Name = "Magnet Rise", At = 1 }, new Move { Name = "Gravity", At = 1 }, new Move { Name = "Wide Guard", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Iron Defense", At = 1 }, new Move { Name = "Block", At = 1 }, new Move { Name = "Magnet Bomb", At = 1 }, new Move { Name = "Iron Defense", At = 4 }, new Move { Name = "Block", At = 7 }, new Move { Name = "Magnet Bomb", At = 10 }, new Move { Name = "Thunder Wave", At = 13 }, new Move { Name = "Rest", At = 16 }, new Move { Name = "Spark", At = 19 }, new Move { Name = "Rock Slide", At = 22 }, new Move { Name = "Power Gem", At = 25 }, new Move { Name = "Rock Blast", At = 28 }, new Move { Name = "Discharge", At = 31 }, new Move { Name = "Sandstorm", At = 34 }, new Move { Name = "Earth Power", At = 37 }, new Move { Name = "Stone Edge", At = 40 }, new Move { Name = "Lock-On", At = 43 }, new Move { Name = "Zap Cannon", At = 43 }, },
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Dusknoir",
                    moves = { new Move { Name = "Future Sight", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Ice Punch", At = 1 }, new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Gravity", At = 1 }, new Move { Name = "Bind", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Disable", At = 6 }, new Move { Name = "Astonish", At = 9 }, new Move { Name = "Foresight", At = 14 }, new Move { Name = "Shadow Sneak", At = 17 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Will-O-Wisp", At = 25 }, new Move { Name = "Confuse Ray", At = 30 }, new Move { Name = "Curse", At = 33 }, new Move { Name = "Shadow Punch", At = 37 }, new Move { Name = "Hex", At = 40 }, new Move { Name = "Shadow Ball", At = 45 }, new Move { Name = "Mean Look", At = 52 }, new Move { Name = "Payback", At = 57 }, new Move { Name = "Future Sight", At = 64 }, },
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Froslass",
                    moves = { new Move { Name = "Destiny Bond", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Ice Shard", At = 1 }, new Move { Name = "Double Team", At = 5 }, new Move { Name = "Ice Shard", At = 10 }, new Move { Name = "Icy Wind", At = 14 }, new Move { Name = "Astonish", At = 19 }, new Move { Name = "Draining Kiss", At = 23 }, new Move { Name = "Ominous Wind", At = 28 }, new Move { Name = "Confuse Ray", At = 32 }, new Move { Name = "Wake-Up Slap", At = 37 }, new Move { Name = "Captivate", At = 41 }, new Move { Name = "Shadow Ball", At = 42 }, new Move { Name = "Blizzard", At = 48 }, new Move { Name = "Hail", At = 54 }, new Move { Name = "Destiny Bond", At = 61 }, },
                },

                new Species() {
                    Name = "Rotom",
                    moves = { new Move { Name = "Discharge", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Trick", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Uproar", At = 8 }, new Move { Name = "Double Team", At = 15 }, new Move { Name = "Shock Wave", At = 22 }, new Move { Name = "Ominous Wind", At = 29 }, new Move { Name = "Substitute", At = 36 }, new Move { Name = "Electro Ball", At = 43 }, new Move { Name = "Hex", At = 50 }, new Move { Name = "Charge", At = 57 }, new Move { Name = "Discharge", At = 64 }, },
                },

                new Species() {
                    Name = "Uxie",
                    moves = { new Move { Name = "Memento", At = 1 }, new Move { Name = "Natural Gift", At = 1 }, new Move { Name = "Flail", At = 1 }, new Move { Name = "Rest", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Imprison", At = 6 }, new Move { Name = "Endure", At = 16 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Yawn", At = 31 }, new Move { Name = "Future Sight", At = 36 }, new Move { Name = "Amnesia", At = 46 }, new Move { Name = "Extrasensory", At = 50 }, new Move { Name = "Flail", At = 61 }, new Move { Name = "Natural Gift", At = 66 }, new Move { Name = "Memento", At = 76 }, },
                },

                new Species() {
                    Name = "Mesprit",
                    moves = { new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Natural Gift", At = 1 }, new Move { Name = "Copycat", At = 1 }, new Move { Name = "Rest", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Imprison", At = 6 }, new Move { Name = "Protect", At = 16 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Lucky Chant", At = 31 }, new Move { Name = "Future Sight", At = 36 }, new Move { Name = "Charm", At = 46 }, new Move { Name = "Extrasensory", At = 50 }, new Move { Name = "Copycat", At = 61 }, new Move { Name = "Natural Gift", At = 66 }, new Move { Name = "Healing Wish", At = 76 }, },
                },

                new Species() {
                    Name = "Azelf",
                    moves = { new Move { Name = "Natural Gift", At = 1 }, new Move { Name = "Last Resort", At = 1 }, new Move { Name = "Rest", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Imprison", At = 6 }, new Move { Name = "Detect", At = 16 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Uproar", At = 31 }, new Move { Name = "Future Sight", At = 36 }, new Move { Name = "Nasty Plot", At = 46 }, new Move { Name = "Extrasensory", At = 50 }, new Move { Name = "Last Resort", At = 61 }, new Move { Name = "Natural Gift", At = 66 }, new Move { Name = "Explosion", At = 76 }, },
                },

                new Species() {
                    Name = "Dialga",
                    moves = { new Move { Name = "Dragon Breath", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Metal Claw", At = 6 }, new Move { Name = "Ancient Power", At = 10 }, new Move { Name = "Slash", At = 15 }, new Move { Name = "Power Gem", At = 19 }, new Move { Name = "Metal Burst", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Earth Power", At = 33 }, new Move { Name = "Aura Sphere", At = 37 }, new Move { Name = "Iron Tail", At = 42 }, new Move { Name = "Roar of Time", At = 46 }, new Move { Name = "Flash Cannon", At = 50 }, },
                },

                new Species() {
                    Name = "Palkia",
                    moves = { new Move { Name = "Dragon Breath", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Water Pulse", At = 6 }, new Move { Name = "Ancient Power", At = 10 }, new Move { Name = "Slash", At = 15 }, new Move { Name = "Power Gem", At = 19 }, new Move { Name = "Aqua Tail", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Earth Power", At = 33 }, new Move { Name = "Aura Sphere", At = 37 }, new Move { Name = "Aqua Tail", At = 42 }, new Move { Name = "Spacial Rend", At = 46 }, new Move { Name = "Hydro Pump", At = 50 }, },
                },

                new Species() {
                    Name = "Heatran",
                    moves = { new Move { Name = "Magma Storm", At = 1 }, new Move { Name = "Heat Wave", At = 1 }, new Move { Name = "Earth Power", At = 1 }, new Move { Name = "Iron Head", At = 1 }, new Move { Name = "Fire Spin", At = 1 }, new Move { Name = "Ancient Power", At = 1 }, new Move { Name = "Leer", At = 9 }, new Move { Name = "Fire Fang", At = 17 }, new Move { Name = "Metal Sound", At = 25 }, new Move { Name = "Crunch", At = 33 }, new Move { Name = "Scary Face", At = 41 }, new Move { Name = "Lava Plume", At = 49 }, new Move { Name = "Fire Spin", At = 57 }, new Move { Name = "Iron Head", At = 65 }, new Move { Name = "Earth Power", At = 73 }, new Move { Name = "Heat Wave", At = 81 }, new Move { Name = "Stone Edge", At = 88 }, new Move { Name = "Magma Storm", At = 96 }, },
                },

                new Species() {
                    Name = "Regigigas",
                    moves = { new Move { Name = "Heavy Slam", At = 1 }, new Move { Name = "Crush Grip", At = 1 }, new Move { Name = "Fire Punch", At = 1 }, new Move { Name = "Ice Punch", At = 1 }, new Move { Name = "Thunder Punch", At = 1 }, new Move { Name = "Dizzy Punch", At = 1 }, new Move { Name = "Knock Off", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Foresight", At = 1 }, new Move { Name = "Revenge", At = 25 }, new Move { Name = "Wide Guard", At = 40 }, new Move { Name = "Zen Headbutt", At = 50 }, new Move { Name = "Payback", At = 65 }, new Move { Name = "Crush Grip", At = 75 }, new Move { Name = "Heavy Slam", At = 90 }, new Move { Name = "Giga Impact", At = 100 }, },
                },

                new Species() {
                    Name = "Giratina",
                    moves = { new Move { Name = "Dragon Breath", At = 1 }, new Move { Name = "Scary Face", At = 1 }, new Move { Name = "Ominous Wind", At = 6 }, new Move { Name = "Ancient Power", At = 10 }, new Move { Name = "Slash", At = 15 }, new Move { Name = "Shadow Sneak", At = 19 }, new Move { Name = "Destiny Bond", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Earth Power", At = 33 }, new Move { Name = "Aura Sphere", At = 37 }, new Move { Name = "Shadow Claw", At = 42 }, new Move { Name = "Shadow Force", At = 46 }, new Move { Name = "Hex", At = 50 }, },
                },

                new Species() {
                    Name = "Cresselia",
                    moves = { new Move { Name = "Lunar Dance", At = 1 }, new Move { Name = "Psycho Shift", At = 1 }, new Move { Name = "Psycho Cut", At = 1 }, new Move { Name = "Moonlight", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Safeguard", At = 11 }, new Move { Name = "Mist", At = 20 }, new Move { Name = "Aurora Beam", At = 29 }, new Move { Name = "Future Sight", At = 38 }, new Move { Name = "Slash", At = 47 }, new Move { Name = "Moonlight", At = 57 }, new Move { Name = "Psycho Cut", At = 66 }, new Move { Name = "Psycho Shift", At = 75 }, new Move { Name = "Lunar Dance", At = 84 }, new Move { Name = "Psychic", At = 93 }, new Move { Name = "Moonblast", At = 99 }, },
                },

                new Species() {
                    Name = "Phione",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Charm", At = 9 }, new Move { Name = "Supersonic", At = 16 }, new Move { Name = "Bubble Beam", At = 24 }, new Move { Name = "Acid Armor", At = 31 }, new Move { Name = "Whirlpool", At = 39 }, new Move { Name = "Water Pulse", At = 46 }, new Move { Name = "Aqua Ring", At = 54 }, new Move { Name = "Dive", At = 61 }, new Move { Name = "Rain Dance", At = 69 }, },
                },

                new Species() {
                    Name = "Manaphy",
                    moves = { new Move { Name = "Tail Glow", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Charm", At = 9 }, new Move { Name = "Supersonic", At = 16 }, new Move { Name = "Bubble Beam", At = 24 }, new Move { Name = "Acid Armor", At = 31 }, new Move { Name = "Whirlpool", At = 39 }, new Move { Name = "Water Pulse", At = 46 }, new Move { Name = "Aqua Ring", At = 54 }, new Move { Name = "Dive", At = 61 }, new Move { Name = "Rain Dance", At = 69 }, new Move { Name = "Heart Swap", At = 76 }, },
                },

                new Species() {
                    Name = "Darkrai",
                    moves = { new Move { Name = "Ominous Wind", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Hypnosis", At = 20 }, new Move { Name = "Feint Attack", At = 29 }, new Move { Name = "Nightmare", At = 38 }, new Move { Name = "Double Team", At = 47 }, new Move { Name = "Haze", At = 57 }, new Move { Name = "Dark Void", At = 66 }, new Move { Name = "Nasty Plot", At = 75 }, new Move { Name = "Dream Eater", At = 84 }, new Move { Name = "Dark Pulse", At = 93 }, },
                },

                new Species() {
                    Name = "Shaymin",
                    moves = { new Move { Name = "Growth", At = 1 }, new Move { Name = "Magical Leaf", At = 10 }, new Move { Name = "Leech Seed", At = 19 }, new Move { Name = "Synthesis", At = 28 }, new Move { Name = "Sweet Scent", At = 37 }, new Move { Name = "Natural Gift", At = 46 }, new Move { Name = "Worry Seed", At = 55 }, new Move { Name = "Aromatherapy", At = 64 }, new Move { Name = "Energy Ball", At = 73 }, new Move { Name = "Sweet Kiss", At = 82 }, new Move { Name = "Healing Wish", At = 91 }, new Move { Name = "Seed Flare", At = 100 }, },
                    item100 = "Lum Berry",
                },

                new Species() {
                    Name = "Arceus",
                    moves = { new Move { Name = "Seismic Toss", At = 1 }, new Move { Name = "Cosmic Power", At = 1 }, new Move { Name = "Natural Gift", At = 1 }, new Move { Name = "Punishment", At = 1 }, new Move { Name = "Gravity", At = 10 }, new Move { Name = "Earth Power", At = 20 }, new Move { Name = "Hyper Voice", At = 30 }, new Move { Name = "Extreme Speed", At = 40 }, new Move { Name = "Refresh", At = 50 }, new Move { Name = "Future Sight", At = 60 }, new Move { Name = "Recover", At = 70 }, new Move { Name = "Hyper Beam", At = 80 }, new Move { Name = "Perish Song", At = 90 }, new Move { Name = "Judgment", At = 100 }, },
                },

                new Species() {
                    Name = "Victini",
                    moves = { new Move { Name = "Searing Shot", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Incinerate", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Endure", At = 9 }, new Move { Name = "Headbutt", At = 17 }, new Move { Name = "Flame Charge", At = 25 }, new Move { Name = "Reversal", At = 33 }, new Move { Name = "Flame Burst", At = 41 }, new Move { Name = "Zen Headbutt", At = 49 }, new Move { Name = "Inferno", At = 57 }, new Move { Name = "Double-Edge", At = 65 }, new Move { Name = "Flare Blitz", At = 73 }, new Move { Name = "Final Gambit", At = 81 }, new Move { Name = "Stored Power", At = 89 }, new Move { Name = "Overheat", At = 97 }, },
                },

                new Species() {
                    Name = "Snivy",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Wrap", At = 10 }, new Move { Name = "Growth", At = 13 }, new Move { Name = "Leaf Tornado", At = 16 }, new Move { Name = "Leech Seed", At = 19 }, new Move { Name = "Mega Drain", At = 22 }, new Move { Name = "Slam", At = 25 }, new Move { Name = "Leaf Blade", At = 28 }, new Move { Name = "Coil", At = 31 }, new Move { Name = "Giga Drain", At = 34 }, new Move { Name = "Wring Out", At = 37 }, new Move { Name = "Gastro Acid", At = 40 }, new Move { Name = "Leaf Storm", At = 43 }, },
                    eggMoves = { "Captivate", "Natural Gift", "Glare", "Iron Tail", "Magical Leaf", "Sweet Scent", "Mirror Coat", "Pursuit", "Mean Look", "Twister", "Grassy Terrain", },
                },

                new Species() {
                    Name = "Servine",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Wrap", At = 10 }, new Move { Name = "Growth", At = 13 }, new Move { Name = "Leaf Tornado", At = 16 }, new Move { Name = "Leech Seed", At = 20 }, new Move { Name = "Mega Drain", At = 24 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Leaf Blade", At = 32 }, new Move { Name = "Coil", At = 36 }, new Move { Name = "Giga Drain", At = 40 }, new Move { Name = "Wring Out", At = 44 }, new Move { Name = "Gastro Acid", At = 48 }, new Move { Name = "Leaf Storm", At = 52 }, },
                },

                new Species() {
                    Name = "Serperior",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Wrap", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Wrap", At = 10 }, new Move { Name = "Growth", At = 13 }, new Move { Name = "Leaf Tornado", At = 16 }, new Move { Name = "Leech Seed", At = 20 }, new Move { Name = "Mega Drain", At = 24 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Leaf Blade", At = 32 }, new Move { Name = "Coil", At = 38 }, new Move { Name = "Giga Drain", At = 44 }, new Move { Name = "Wring Out", At = 50 }, new Move { Name = "Gastro Acid", At = 56 }, new Move { Name = "Leaf Storm", At = 62 }, },
                },

                new Species() {
                    Name = "Tepig",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Odor Sleuth", At = 9 }, new Move { Name = "Defense Curl", At = 13 }, new Move { Name = "Flame Charge", At = 15 }, new Move { Name = "Smog", At = 19 }, new Move { Name = "Rollout", At = 21 }, new Move { Name = "Take Down", At = 25 }, new Move { Name = "Heat Crash", At = 27 }, new Move { Name = "Assurance", At = 31 }, new Move { Name = "Flamethrower", At = 33 }, new Move { Name = "Head Smash", At = 37 }, new Move { Name = "Roar", At = 39 }, new Move { Name = "Flare Blitz", At = 43 }, },
                    eggMoves = { "Covet", "Body Slam", "Thrash", "Magnitude", "Superpower", "Curse", "Endeavor", "Yawn", "Sleep Talk", "Heavy Slam", "Sucker Punch", },
                },

                new Species() {
                    Name = "Pignite",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Odor Sleuth", At = 9 }, new Move { Name = "Defense Curl", At = 13 }, new Move { Name = "Flame Charge", At = 15 }, new Move { Name = "Arm Thrust", At = 17 }, new Move { Name = "Smog", At = 20 }, new Move { Name = "Rollout", At = 23 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Heat Crash", At = 31 }, new Move { Name = "Assurance", At = 36 }, new Move { Name = "Flamethrower", At = 39 }, new Move { Name = "Head Smash", At = 44 }, new Move { Name = "Roar", At = 47 }, new Move { Name = "Flare Blitz", At = 52 }, },
                },

                new Species() {
                    Name = "Emboar",
                    moves = { new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Tail Whip", At = 3 }, new Move { Name = "Ember", At = 7 }, new Move { Name = "Odor Sleuth", At = 9 }, new Move { Name = "Defense Curl", At = 13 }, new Move { Name = "Flame Charge", At = 15 }, new Move { Name = "Arm Thrust", At = 17 }, new Move { Name = "Smog", At = 20 }, new Move { Name = "Rollout", At = 23 }, new Move { Name = "Take Down", At = 28 }, new Move { Name = "Heat Crash", At = 31 }, new Move { Name = "Assurance", At = 38 }, new Move { Name = "Flamethrower", At = 43 }, new Move { Name = "Head Smash", At = 50 }, new Move { Name = "Roar", At = 55 }, new Move { Name = "Flare Blitz", At = 62 }, },
                },

                new Species() {
                    Name = "Oshawott",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Water Sport", At = 11 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Razor Shell", At = 17 }, new Move { Name = "Fury Cutter", At = 19 }, new Move { Name = "Water Pulse", At = 23 }, new Move { Name = "Revenge", At = 25 }, new Move { Name = "Aqua Jet", At = 29 }, new Move { Name = "Encore", At = 31 }, new Move { Name = "Aqua Tail", At = 35 }, new Move { Name = "Retaliate", At = 37 }, new Move { Name = "Swords Dance", At = 41 }, new Move { Name = "Hydro Pump", At = 43 }, },
                    eggMoves = { "Copycat", "Detect", "Air Slash", "Assurance", "Brine", "Night Slash", "Trump Card", "Screech", },
                },

                new Species() {
                    Name = "Dewott",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Water Sport", At = 11 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Razor Shell", At = 17 }, new Move { Name = "Fury Cutter", At = 20 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Revenge", At = 28 }, new Move { Name = "Aqua Jet", At = 33 }, new Move { Name = "Encore", At = 36 }, new Move { Name = "Aqua Tail", At = 41 }, new Move { Name = "Retaliate", At = 44 }, new Move { Name = "Swords Dance", At = 49 }, new Move { Name = "Hydro Pump", At = 52 }, },
                },

                new Species() {
                    Name = "Samurott",
                    moves = { new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Tail Whip", At = 5 }, new Move { Name = "Water Gun", At = 7 }, new Move { Name = "Water Sport", At = 11 }, new Move { Name = "Focus Energy", At = 13 }, new Move { Name = "Razor Shell", At = 17 }, new Move { Name = "Fury Cutter", At = 20 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Revenge", At = 28 }, new Move { Name = "Aqua Jet", At = 33 }, new Move { Name = "Slash", At = 36 }, new Move { Name = "Encore", At = 38 }, new Move { Name = "Aqua Tail", At = 45 }, new Move { Name = "Retaliate", At = 50 }, new Move { Name = "Swords Dance", At = 57 }, new Move { Name = "Hydro Pump", At = 62 }, },
                },

                new Species() {
                    Name = "Patrat",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 3 }, new Move { Name = "Bite", At = 6 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Detect", At = 11 }, new Move { Name = "Sand Attack", At = 13 }, new Move { Name = "Crunch", At = 16 }, new Move { Name = "Hypnosis", At = 18 }, new Move { Name = "Super Fang", At = 21 }, new Move { Name = "After You", At = 23 }, new Move { Name = "Work Up", At = 26 }, new Move { Name = "Hyper Fang", At = 28 }, new Move { Name = "Mean Look", At = 31 }, new Move { Name = "Baton Pass", At = 33 }, new Move { Name = "Slam", At = 36 }, },
                    eggMoves = { "Foresight", "Iron Tail", "Screech", "Assurance", "Pursuit", "Revenge", "Flail", },
                },

                new Species() {
                    Name = "Watchog",
                    moves = { new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Leer", At = 3 }, new Move { Name = "Bite", At = 6 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Detect", At = 11 }, new Move { Name = "Sand Attack", At = 13 }, new Move { Name = "Crunch", At = 16 }, new Move { Name = "Hypnosis", At = 18 }, new Move { Name = "Confuse Ray", At = 20 }, new Move { Name = "Super Fang", At = 22 }, new Move { Name = "After You", At = 25 }, new Move { Name = "Psych Up", At = 29 }, new Move { Name = "Hyper Fang", At = 32 }, new Move { Name = "Mean Look", At = 36 }, new Move { Name = "Baton Pass", At = 39 }, new Move { Name = "Slam", At = 43 }, },
                },

                new Species() {
                    Name = "Lillipup",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Odor Sleuth", At = 5 }, new Move { Name = "Bite", At = 8 }, new Move { Name = "Baby-Doll Eyes", At = 10 }, new Move { Name = "Helping Hand", At = 12 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Work Up", At = 19 }, new Move { Name = "Crunch", At = 22 }, new Move { Name = "Roar", At = 26 }, new Move { Name = "Retaliate", At = 29 }, new Move { Name = "Reversal", At = 33 }, new Move { Name = "Last Resort", At = 36 }, new Move { Name = "Giga Impact", At = 40 }, new Move { Name = "Play Rough", At = 45 }, },
                    eggMoves = { "Howl", "Sand Attack", "Mud-Slap", "Lick", "Charm", "Endure", "Yawn", "Pursuit", "Fire Fang", "Thunder Fang", "Ice Fang", "After You", },
                    FS = true,
                },

                new Species() {
                    Name = "Herdier",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Odor Sleuth", At = 5 }, new Move { Name = "Bite", At = 8 }, new Move { Name = "Helping Hand", At = 12 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Work Up", At = 20 }, new Move { Name = "Crunch", At = 24 }, new Move { Name = "Roar", At = 29 }, new Move { Name = "Retaliate", At = 33 }, new Move { Name = "Reversal", At = 38 }, new Move { Name = "Last Resort", At = 42 }, new Move { Name = "Giga Impact", At = 47 }, new Move { Name = "Play Rough", At = 52 }, },
                },

                new Species() {
                    Name = "Stoutland",
                    moves = { new Move { Name = "Ice Fang", At = 1 }, new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Odor Sleuth", At = 5 }, new Move { Name = "Bite", At = 8 }, new Move { Name = "Helping Hand", At = 12 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Work Up", At = 20 }, new Move { Name = "Crunch", At = 24 }, new Move { Name = "Roar", At = 29 }, new Move { Name = "Retaliate", At = 36 }, new Move { Name = "Reversal", At = 42 }, new Move { Name = "Last Resort", At = 51 }, new Move { Name = "Giga Impact", At = 59 }, new Move { Name = "Play Rough", At = 63 }, },
                },

                new Species() {
                    Name = "Purrloin",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Assist", At = 6 }, new Move { Name = "Sand Attack", At = 10 }, new Move { Name = "Fury Swipes", At = 12 }, new Move { Name = "Pursuit", At = 15 }, new Move { Name = "Torment", At = 19 }, new Move { Name = "Fake Out", At = 21 }, new Move { Name = "Hone Claws", At = 24 }, new Move { Name = "Assurance", At = 28 }, new Move { Name = "Slash", At = 30 }, new Move { Name = "Captivate", At = 33 }, new Move { Name = "Night Slash", At = 37 }, new Move { Name = "Snatch", At = 39 }, new Move { Name = "Nasty Plot", At = 42 }, new Move { Name = "Sucker Punch", At = 46 }, new Move { Name = "Play Rough", At = 49 }, },
                    eggMoves = { "Pay Day", "Foul Play", "Feint Attack", "Fake Tears", "Charm", "Encore", "Yawn", "Covet", "Copycat", },
                },

                new Species() {
                    Name = "Liepard",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Assist", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Growl", At = 3 }, new Move { Name = "Assist", At = 6 }, new Move { Name = "Sand Attack", At = 10 }, new Move { Name = "Fury Swipes", At = 12 }, new Move { Name = "Pursuit", At = 15 }, new Move { Name = "Torment", At = 19 }, new Move { Name = "Fake Out", At = 22 }, new Move { Name = "Hone Claws", At = 26 }, new Move { Name = "Assurance", At = 31 }, new Move { Name = "Slash", At = 34 }, new Move { Name = "Taunt", At = 38 }, new Move { Name = "Night Slash", At = 43 }, new Move { Name = "Snatch", At = 47 }, new Move { Name = "Nasty Plot", At = 50 }, new Move { Name = "Sucker Punch", At = 55 }, new Move { Name = "Play Rough", At = 58 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Pansage",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Lick", At = 7 }, new Move { Name = "Vine Whip", At = 10 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Leech Seed", At = 16 }, new Move { Name = "Bite", At = 19 }, new Move { Name = "Seed Bomb", At = 22 }, new Move { Name = "Torment", At = 25 }, new Move { Name = "Fling", At = 28 }, new Move { Name = "Acrobatics", At = 31 }, new Move { Name = "Grass Knot", At = 34 }, new Move { Name = "Recycle", At = 37 }, new Move { Name = "Natural Gift", At = 40 }, new Move { Name = "Crunch", At = 43 }, },
                    eggMoves = { "Covet", "Low Kick", "Tickle", "Nasty Plot", "Role Play", "Astonish", "Grass Whistle", "Magical Leaf", "Bullet Seed", "Leaf Storm", "Disarming Voice", },
                    FS = true,
                },

                new Species() {
                    Name = "Simisage",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Fury Swipes", At = 1 }, new Move { Name = "Seed Bomb", At = 1 }, },
                },

                new Species() {
                    Name = "Pansear",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Lick", At = 7 }, new Move { Name = "Incinerate", At = 10 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Yawn", At = 16 }, new Move { Name = "Bite", At = 19 }, new Move { Name = "Flame Burst", At = 22 }, new Move { Name = "Amnesia", At = 25 }, new Move { Name = "Fling", At = 28 }, new Move { Name = "Acrobatics", At = 31 }, new Move { Name = "Fire Blast", At = 34 }, new Move { Name = "Recycle", At = 37 }, new Move { Name = "Natural Gift", At = 40 }, new Move { Name = "Crunch", At = 43 }, },
                    eggMoves = { "Covet", "Low Kick", "Tickle", "Nasty Plot", "Role Play", "Astonish", "Sleep Talk", "Fire Spin", "Fire Punch", "Heat Wave", "Disarming Voice", },
                    FS = true,
                },

                new Species() {
                    Name = "Simisear",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Fury Swipes", At = 1 }, new Move { Name = "Flame Burst", At = 1 }, },
                },

                new Species() {
                    Name = "Panpour",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Lick", At = 7 }, new Move { Name = "Water Gun", At = 10 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Water Sport", At = 16 }, new Move { Name = "Bite", At = 19 }, new Move { Name = "Scald", At = 22 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Fling", At = 28 }, new Move { Name = "Acrobatics", At = 31 }, new Move { Name = "Brine", At = 34 }, new Move { Name = "Recycle", At = 37 }, new Move { Name = "Natural Gift", At = 40 }, new Move { Name = "Crunch", At = 43 }, },
                    eggMoves = { "Covet", "Low Kick", "Tickle", "Nasty Plot", "Role Play", "Astonish", "Aqua Ring", "Aqua Tail", "Mud Sport", "Hydro Pump", "Disarming Voice", },
                    FS = true,
                },

                new Species() {
                    Name = "Simipour",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Fury Swipes", At = 1 }, new Move { Name = "Scald", At = 1 }, },
                },

                new Species() {
                    Name = "Munna",
                    moves = { new Move { Name = "Psywave", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Lucky Chant", At = 5 }, new Move { Name = "Yawn", At = 7 }, new Move { Name = "Psybeam", At = 11 }, new Move { Name = "Imprison", At = 13 }, new Move { Name = "Moonlight", At = 17 }, new Move { Name = "Hypnosis", At = 19 }, new Move { Name = "Zen Headbutt", At = 23 }, new Move { Name = "Synchronoise", At = 25 }, new Move { Name = "Nightmare", At = 29 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Calm Mind", At = 35 }, new Move { Name = "Psychic", At = 37 }, new Move { Name = "Dream Eater", At = 41 }, new Move { Name = "Telekinesis", At = 43 }, new Move { Name = "Stored Power", At = 47 }, },
                    eggMoves = { "Sleep Talk", "Secret Power", "Barrier", "Magic Coat", "Helping Hand", "Baton Pass", "Swift", "Curse", "Sonic Boom", "Healing Wish", },
                    FS = true,
                },

                new Species() {
                    Name = "Musharna",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Lucky Chant", At = 1 }, new Move { Name = "Psybeam", At = 1 }, new Move { Name = "Hypnosis", At = 1 }, },
                },

                new Species() {
                    Name = "Pidove",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Leer", At = 8 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Air Cutter", At = 15 }, new Move { Name = "Roost", At = 18 }, new Move { Name = "Detect", At = 22 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Air Slash", At = 29 }, new Move { Name = "Razor Wind", At = 32 }, new Move { Name = "Feather Dance", At = 36 }, new Move { Name = "Swagger", At = 39 }, new Move { Name = "Facade", At = 43 }, new Move { Name = "Tailwind", At = 46 }, new Move { Name = "Sky Attack", At = 50 }, },
                    eggMoves = { "Steel Wing", "Hypnosis", "Uproar", "Bestow", "Wish", "Morning Sun", "Lucky Chant", "Night Slash", },
                },

                new Species() {
                    Name = "Tranquill",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Leer", At = 8 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Air Cutter", At = 15 }, new Move { Name = "Roost", At = 18 }, new Move { Name = "Detect", At = 23 }, new Move { Name = "Taunt", At = 27 }, new Move { Name = "Air Slash", At = 32 }, new Move { Name = "Razor Wind", At = 36 }, new Move { Name = "Feather Dance", At = 41 }, new Move { Name = "Swagger", At = 45 }, new Move { Name = "Facade", At = 50 }, new Move { Name = "Tailwind", At = 54 }, new Move { Name = "Sky Attack", At = 59 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Unfezant",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Leer", At = 8 }, new Move { Name = "Quick Attack", At = 11 }, new Move { Name = "Air Cutter", At = 15 }, new Move { Name = "Roost", At = 18 }, new Move { Name = "Detect", At = 23 }, new Move { Name = "Taunt", At = 27 }, new Move { Name = "Air Slash", At = 33 }, new Move { Name = "Razor Wind", At = 38 }, new Move { Name = "Feather Dance", At = 44 }, new Move { Name = "Swagger", At = 49 }, new Move { Name = "Facade", At = 55 }, new Move { Name = "Tailwind", At = 60 }, new Move { Name = "Sky Attack", At = 66 }, },
                },

                new Species() {
                    Name = "Blitzle",
                    moves = { new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Charge", At = 8 }, new Move { Name = "Shock Wave", At = 11 }, new Move { Name = "Thunder Wave", At = 15 }, new Move { Name = "Flame Charge", At = 18 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Spark", At = 25 }, new Move { Name = "Stomp", At = 29 }, new Move { Name = "Discharge", At = 32 }, new Move { Name = "Agility", At = 36 }, new Move { Name = "Wild Charge", At = 39 }, new Move { Name = "Thrash", At = 43 }, },
                    eggMoves = { "Me First", "Take Down", "Sand Attack", "Double Kick", "Screech", "Rage", "Endure", "Double-Edge", "Shock Wave", "Snatch", },
                },

                new Species() {
                    Name = "Zebstrika",
                    moves = { new Move { Name = "Ion Deluge", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Tail Whip", At = 4 }, new Move { Name = "Charge", At = 8 }, new Move { Name = "Shock Wave", At = 11 }, new Move { Name = "Thunder Wave", At = 15 }, new Move { Name = "Flame Charge", At = 18 }, new Move { Name = "Pursuit", At = 22 }, new Move { Name = "Spark", At = 25 }, new Move { Name = "Stomp", At = 31 }, new Move { Name = "Discharge", At = 36 }, new Move { Name = "Agility", At = 42 }, new Move { Name = "Wild Charge", At = 47 }, new Move { Name = "Thrash", At = 53 }, new Move { Name = "Ion Deluge", At = 58 }, },
                    eggMoves = { "Me First", "Take Down", "Sand Attack", "Double Kick", "Screech", "Rage", "Endure", "Double-Edge", "Shock Wave", "Snatch", },
                    FS = true,
                },

                new Species() {
                    Name = "Roggenrola",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Headbutt", At = 10 }, new Move { Name = "Rock Blast", At = 14 }, new Move { Name = "Mud-Slap", At = 17 }, new Move { Name = "Iron Defense", At = 20 }, new Move { Name = "Smack Down", At = 23 }, new Move { Name = "Rock Slide", At = 27 }, new Move { Name = "Stealth Rock", At = 30 }, new Move { Name = "Sandstorm", At = 33 }, new Move { Name = "Stone Edge", At = 36 }, new Move { Name = "Explosion", At = 40 }, },
                    eggMoves = { "Magnitude", "Curse", "Autotomize", "Rock Tomb", "Lock-On", "Heavy Slam", "Take Down", "Gravity", "Wide Guard", },
                    eggRand = 5,
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Boldore",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Headbutt", At = 10 }, new Move { Name = "Rock Blast", At = 14 }, new Move { Name = "Mud-Slap", At = 17 }, new Move { Name = "Iron Defense", At = 20 }, new Move { Name = "Smack Down", At = 23 }, new Move { Name = "Power Gem", At = 25 }, new Move { Name = "Rock Slide", At = 30 }, new Move { Name = "Stealth Rock", At = 36 }, new Move { Name = "Sandstorm", At = 42 }, new Move { Name = "Stone Edge", At = 48 }, new Move { Name = "Explosion", At = 55 }, },
                    eggMoves = { "Magnitude", "Curse", "Autotomize", "Rock Tomb", "Lock-On", "Heavy Slam", "Take Down", "Gravity", "Wide Guard", },
                    FS = true,
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Gigalith",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Headbutt", At = 10 }, new Move { Name = "Rock Blast", At = 14 }, new Move { Name = "Mud-Slap", At = 17 }, new Move { Name = "Iron Defense", At = 20 }, new Move { Name = "Smack Down", At = 23 }, new Move { Name = "Power Gem", At = 25 }, new Move { Name = "Rock Slide", At = 30 }, new Move { Name = "Stealth Rock", At = 36 }, new Move { Name = "Sandstorm", At = 42 }, new Move { Name = "Stone Edge", At = 48 }, new Move { Name = "Explosion", At = 55 }, },
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Woobat",
                    moves = { new Move { Name = "Confusion", At = 1 }, new Move { Name = "Odor Sleuth", At = 4 }, new Move { Name = "Gust", At = 8 }, new Move { Name = "Assurance", At = 12 }, new Move { Name = "Heart Stamp", At = 15 }, new Move { Name = "Imprison", At = 19 }, new Move { Name = "Air Cutter", At = 21 }, new Move { Name = "Attract", At = 25 }, new Move { Name = "Amnesia", At = 29 }, new Move { Name = "Calm Mind", At = 29 }, new Move { Name = "Air Slash", At = 32 }, new Move { Name = "Future Sight", At = 36 }, new Move { Name = "Psychic", At = 41 }, new Move { Name = "Endeavor", At = 47 }, },
                    eggMoves = { "Charm", "Knock Off", "Fake Tears", "Supersonic", "Synchronoise", "Stored Power", "Roost", "Flatter", "Helping Hand", "Captivate", "Venom Drench", "Psycho Shift", },
                    FS = true,
                },

                new Species() {
                    Name = "Swoobat",
                    moves = { new Move { Name = "Confusion", At = 1 }, new Move { Name = "Odor Sleuth", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Assurance", At = 1 }, new Move { Name = "Odor Sleuth", At = 4 }, new Move { Name = "Gust", At = 8 }, new Move { Name = "Assurance", At = 12 }, new Move { Name = "Heart Stamp", At = 15 }, new Move { Name = "Imprison", At = 19 }, new Move { Name = "Air Cutter", At = 21 }, new Move { Name = "Attract", At = 25 }, new Move { Name = "Amnesia", At = 29 }, new Move { Name = "Calm Mind", At = 29 }, new Move { Name = "Air Slash", At = 32 }, new Move { Name = "Future Sight", At = 36 }, new Move { Name = "Psychic", At = 41 }, new Move { Name = "Endeavor", At = 47 }, },
                },

                new Species() {
                    Name = "Drilbur",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Rapid Spin", At = 5 }, new Move { Name = "Mud-Slap", At = 8 }, new Move { Name = "Fury Swipes", At = 12 }, new Move { Name = "Metal Claw", At = 15 }, new Move { Name = "Dig", At = 19 }, new Move { Name = "Hone Claws", At = 22 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Earthquake", At = 33 }, new Move { Name = "Swords Dance", At = 36 }, new Move { Name = "Sandstorm", At = 40 }, new Move { Name = "Drill Run", At = 43 }, new Move { Name = "Fissure", At = 47 }, },
                    eggMoves = { "Iron Defense", "Rapid Spin", "Earth Power", "Crush Claw", "Metal Sound", "Submission", "Skull Bash", "Rock Climb", },
                },

                new Species() {
                    Name = "Excadrill",
                    moves = { new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Rapid Spin", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Rapid Spin", At = 5 }, new Move { Name = "Mud-Slap", At = 8 }, new Move { Name = "Fury Swipes", At = 12 }, new Move { Name = "Metal Claw", At = 15 }, new Move { Name = "Dig", At = 19 }, new Move { Name = "Hone Claws", At = 22 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Horn Drill", At = 31 }, new Move { Name = "Earthquake", At = 36 }, new Move { Name = "Swords Dance", At = 42 }, new Move { Name = "Sandstorm", At = 49 }, new Move { Name = "Drill Run", At = 55 }, new Move { Name = "Fissure", At = 62 }, },
                    eggMoves = { "Iron Defense", "Rapid Spin", "Earth Power", "Crush Claw", "Metal Sound", "Submission", "Skull Bash", "Rock Climb", },
                    eggRand = 9,
                    FS = true,
                },

                new Species() {
                    Name = "Audino",
                    moves = { new Move { Name = "Last Resort", At = 1 }, new Move { Name = "Misty Terrain", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Baby-Doll Eyes", At = 5 }, new Move { Name = "Refresh", At = 9 }, new Move { Name = "Disarming Voice", At = 13 }, new Move { Name = "Double Slap", At = 17 }, new Move { Name = "Attract", At = 21 }, new Move { Name = "Secret Power", At = 25 }, new Move { Name = "Entrainment", At = 29 }, new Move { Name = "Take Down", At = 33 }, new Move { Name = "Heal Pulse", At = 37 }, new Move { Name = "After You", At = 41 }, new Move { Name = "Simple Beam", At = 45 }, new Move { Name = "Double-Edge", At = 49 }, new Move { Name = "Last Resort", At = 53 }, },
                    eggMoves = { "Wish", "Heal Bell", "Lucky Chant", "Encore", "Bestow", "Sweet Kiss", "Yawn", "Sleep Talk", "Healing Wish", "Amnesia", "Draining Kiss", },
                    FS = true,
                    item5 = "Sitrus Berry",
                    item50 = "Oran Berry",
                },

                new Species() {
                    Name = "Timburr",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Low Kick", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Wake-Up Slap", At = 20 }, new Move { Name = "Chip Away", At = 24 }, new Move { Name = "Bulk Up", At = 28 }, new Move { Name = "Rock Slide", At = 31 }, new Move { Name = "Dynamic Punch", At = 34 }, new Move { Name = "Scary Face", At = 37 }, new Move { Name = "Hammer Arm", At = 40 }, new Move { Name = "Stone Edge", At = 43 }, new Move { Name = "Focus Punch", At = 46 }, new Move { Name = "Superpower", At = 49 }, },
                    eggMoves = { "Drain Punch", "Endure", "Counter", "Comet Punch", "Foresight", "Smelling Salts", "Detect", "Wide Guard", "Force Palm", "Reversal", "Mach Punch", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Gurdurr",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Low Kick", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Wake-Up Slap", At = 20 }, new Move { Name = "Chip Away", At = 24 }, new Move { Name = "Bulk Up", At = 29 }, new Move { Name = "Rock Slide", At = 33 }, new Move { Name = "Dynamic Punch", At = 37 }, new Move { Name = "Scary Face", At = 41 }, new Move { Name = "Hammer Arm", At = 45 }, new Move { Name = "Stone Edge", At = 49 }, new Move { Name = "Focus Punch", At = 53 }, new Move { Name = "Superpower", At = 57 }, },
                },

                new Species() {
                    Name = "Conkeldurr",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Low Kick", At = 12 }, new Move { Name = "Rock Throw", At = 16 }, new Move { Name = "Wake-Up Slap", At = 20 }, new Move { Name = "Chip Away", At = 24 }, new Move { Name = "Bulk Up", At = 29 }, new Move { Name = "Rock Slide", At = 33 }, new Move { Name = "Dynamic Punch", At = 37 }, new Move { Name = "Scary Face", At = 41 }, new Move { Name = "Hammer Arm", At = 45 }, new Move { Name = "Stone Edge", At = 49 }, new Move { Name = "Focus Punch", At = 53 }, new Move { Name = "Superpower", At = 57 }, },
                },

                new Species() {
                    Name = "Tympole",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Round", At = 9 }, new Move { Name = "Bubble Beam", At = 12 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Aqua Ring", At = 20 }, new Move { Name = "Uproar", At = 23 }, new Move { Name = "Muddy Water", At = 27 }, new Move { Name = "Rain Dance", At = 31 }, new Move { Name = "Flail", At = 34 }, new Move { Name = "Echoed Voice", At = 38 }, new Move { Name = "Hydro Pump", At = 42 }, new Move { Name = "Hyper Voice", At = 45 }, },
                    eggMoves = { "Water Pulse", "Refresh", "Mud Sport", "Mud Bomb", "Sleep Talk", "Snore", "Mist", "Earth Power", "After You", },
                },

                new Species() {
                    Name = "Palpitoad",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Round", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Round", At = 9 }, new Move { Name = "Bubble Beam", At = 12 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Aqua Ring", At = 20 }, new Move { Name = "Uproar", At = 23 }, new Move { Name = "Muddy Water", At = 28 }, new Move { Name = "Rain Dance", At = 33 }, new Move { Name = "Flail", At = 37 }, new Move { Name = "Echoed Voice", At = 42 }, new Move { Name = "Hydro Pump", At = 47 }, new Move { Name = "Hyper Voice", At = 51 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Seismitoad",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Round", At = 1 }, new Move { Name = "Supersonic", At = 5 }, new Move { Name = "Round", At = 9 }, new Move { Name = "Bubble Beam", At = 12 }, new Move { Name = "Mud Shot", At = 16 }, new Move { Name = "Aqua Ring", At = 20 }, new Move { Name = "Uproar", At = 23 }, new Move { Name = "Muddy Water", At = 28 }, new Move { Name = "Rain Dance", At = 33 }, new Move { Name = "Acid", At = 36 }, new Move { Name = "Flail", At = 39 }, new Move { Name = "Drain Punch", At = 44 }, new Move { Name = "Echoed Voice", At = 49 }, new Move { Name = "Hydro Pump", At = 53 }, new Move { Name = "Hyper Voice", At = 59 }, },
                },

                new Species() {
                    Name = "Throh",
                    moves = { new Move { Name = "Bind", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bide", At = 5 }, new Move { Name = "Focus Energy", At = 9 }, new Move { Name = "Seismic Toss", At = 13 }, new Move { Name = "Vital Throw", At = 17 }, new Move { Name = "Revenge", At = 21 }, new Move { Name = "Storm Throw", At = 25 }, new Move { Name = "Body Slam", At = 29 }, new Move { Name = "Bulk Up", At = 33 }, new Move { Name = "Circle Throw", At = 37 }, new Move { Name = "Endure", At = 41 }, new Move { Name = "Wide Guard", At = 45 }, new Move { Name = "Superpower", At = 48 }, new Move { Name = "Reversal", At = 50 }, },
                    FS = true,
                    item5 = "Black Belt",
                },

                new Species() {
                    Name = "Sawk",
                    moves = { new Move { Name = "Rock Smash", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Bide", At = 5 }, new Move { Name = "Focus Energy", At = 9 }, new Move { Name = "Double Kick", At = 13 }, new Move { Name = "Low Sweep", At = 17 }, new Move { Name = "Counter", At = 21 }, new Move { Name = "Karate Chop", At = 25 }, new Move { Name = "Brick Break", At = 29 }, new Move { Name = "Bulk Up", At = 33 }, new Move { Name = "Retaliate", At = 37 }, new Move { Name = "Endure", At = 41 }, new Move { Name = "Quick Guard", At = 45 }, new Move { Name = "Close Combat", At = 48 }, new Move { Name = "Reversal", At = 50 }, },
                    FS = true,
                    item5 = "Black Belt",
                },

                new Species() {
                    Name = "Sewaddle",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Bug Bite", At = 8 }, new Move { Name = "Razor Leaf", At = 15 }, new Move { Name = "Struggle Bug", At = 22 }, new Move { Name = "Endure", At = 29 }, new Move { Name = "Sticky Web", At = 31 }, new Move { Name = "Bug Buzz", At = 36 }, new Move { Name = "Flail", At = 43 }, },
                    eggMoves = { "Silver Wind", "Screech", "Razor Wind", "Mind Reader", "Agility", "Me First", "Baton Pass", "Camouflage", "Air Slash", },
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Swadloon",
                    moves = { new Move { Name = "Grass Whistle", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Protect", At = 20 }, },
                    FS = true,
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Leavanny",
                    moves = { new Move { Name = "False Swipe", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Bug Bite", At = 1 }, new Move { Name = "Razor Leaf", At = 1 }, new Move { Name = "Bug Bite", At = 8 }, new Move { Name = "Razor Leaf", At = 15 }, new Move { Name = "Struggle Bug", At = 22 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Helping Hand", At = 32 }, new Move { Name = "Fell Stinger", At = 34 }, new Move { Name = "Leaf Blade", At = 36 }, new Move { Name = "X-Scissor", At = 39 }, new Move { Name = "Entrainment", At = 43 }, new Move { Name = "Swords Dance", At = 46 }, new Move { Name = "Leaf Storm", At = 50 }, },
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Venipede",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Screech", At = 8 }, new Move { Name = "Pursuit", At = 12 }, new Move { Name = "Protect", At = 15 }, new Move { Name = "Poison Tail", At = 19 }, new Move { Name = "Bug Bite", At = 22 }, new Move { Name = "Venoshock", At = 26 }, new Move { Name = "Agility", At = 29 }, new Move { Name = "Steamroller", At = 33 }, new Move { Name = "Toxic", At = 36 }, new Move { Name = "Venoshock", At = 38 }, new Move { Name = "Rock Climb", At = 40 }, new Move { Name = "Double-Edge", At = 43 }, },
                    eggMoves = { "Twineedle", "Pin Missile", "Toxic Spikes", "Spikes", "Take Down", "Rock Climb", },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Whirlipede",
                    moves = { new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Screech", At = 8 }, new Move { Name = "Pursuit", At = 12 }, new Move { Name = "Protect", At = 15 }, new Move { Name = "Poison Tail", At = 19 }, new Move { Name = "Iron Defense", At = 22 }, new Move { Name = "Bug Bite", At = 23 }, new Move { Name = "Venoshock", At = 28 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Steamroller", At = 37 }, new Move { Name = "Toxic", At = 41 }, new Move { Name = "Venom Drench", At = 43 }, new Move { Name = "Rock Climb", At = 46 }, new Move { Name = "Double-Edge", At = 50 }, },
                    FS = true,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Scolipede",
                    moves = { new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Poison Sting", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Poison Sting", At = 5 }, new Move { Name = "Screech", At = 8 }, new Move { Name = "Pursuit", At = 12 }, new Move { Name = "Protect", At = 15 }, new Move { Name = "Poison Tail", At = 19 }, new Move { Name = "Bug Bite", At = 23 }, new Move { Name = "Venoshock", At = 28 }, new Move { Name = "Baton Pass", At = 30 }, new Move { Name = "Agility", At = 33 }, new Move { Name = "Steamroller", At = 39 }, new Move { Name = "Toxic", At = 44 }, new Move { Name = "Venom Drench", At = 47 }, new Move { Name = "Rock Climb", At = 50 }, new Move { Name = "Double-Edge", At = 55 }, new Move { Name = "Megahorn", At = 65 }, },
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Cottonee",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Fairy Wind", At = 1 }, new Move { Name = "Growth", At = 4 }, new Move { Name = "Leech Seed", At = 8 }, new Move { Name = "Stun Spore", At = 10 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Cotton Spore", At = 17 }, new Move { Name = "Razor Leaf", At = 19 }, new Move { Name = "Poison Powder", At = 22 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Charm", At = 28 }, new Move { Name = "Helping Hand", At = 31 }, new Move { Name = "Energy Ball", At = 35 }, new Move { Name = "Cotton Guard", At = 37 }, new Move { Name = "Sunny Day", At = 40 }, new Move { Name = "Endeavor", At = 44 }, new Move { Name = "Solar Beam", At = 46 }, },
                    eggMoves = { "Natural Gift", "Encore", "Tickle", "Fake Tears", "Grass Whistle", "Memento", "Beat Up", "Switcheroo", "Worry Seed", "Captivate", },
                },

                new Species() {
                    Name = "Whimsicott",
                    moves = { new Move { Name = "Growth", At = 1 }, new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Cotton Spore", At = 1 }, new Move { Name = "Gust", At = 10 }, new Move { Name = "Tailwind", At = 28 }, new Move { Name = "Hurricane", At = 46 }, new Move { Name = "Moonblast", At = 50 }, },
                },

                new Species() {
                    Name = "Petilil",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 4 }, new Move { Name = "Leech Seed", At = 8 }, new Move { Name = "Sleep Powder", At = 10 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Synthesis", At = 17 }, new Move { Name = "Magical Leaf", At = 19 }, new Move { Name = "Stun Spore", At = 22 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Aromatherapy", At = 28 }, new Move { Name = "Helping Hand", At = 31 }, new Move { Name = "Energy Ball", At = 35 }, new Move { Name = "Entrainment", At = 37 }, new Move { Name = "Sunny Day", At = 40 }, new Move { Name = "After You", At = 44 }, new Move { Name = "Leaf Storm", At = 46 }, },
                    eggMoves = { "Natural Gift", "Charm", "Endure", "Ingrain", "Worry Seed", "Grass Whistle", "Sweet Scent", "Bide", "Healing Wish", },
                    FS = true,
                },

                new Species() {
                    Name = "Lilligant",
                    moves = { new Move { Name = "Growth", At = 1 }, new Move { Name = "Leech Seed", At = 1 }, new Move { Name = "Mega Drain", At = 1 }, new Move { Name = "Synthesis", At = 1 }, new Move { Name = "Teeter Dance", At = 10 }, new Move { Name = "Quiver Dance", At = 28 }, new Move { Name = "Petal Dance", At = 46 }, new Move { Name = "Petal Blizzard", At = 50 }, },
                },

                new Species() {
                    Name = "Basculin (Red)",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Flail", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Uproar", At = 4 }, new Move { Name = "Headbutt", At = 7 }, new Move { Name = "Bite", At = 10 }, new Move { Name = "Aqua Jet", At = 13 }, new Move { Name = "Chip Away", At = 16 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Crunch", At = 24 }, new Move { Name = "Aqua Tail", At = 28 }, new Move { Name = "Soak", At = 32 }, new Move { Name = "Double-Edge", At = 36 }, new Move { Name = "Scary Face", At = 41 }, new Move { Name = "Flail", At = 46 }, new Move { Name = "Final Gambit", At = 50 }, new Move { Name = "Thrash", At = 56 }, },
                    eggMoves = { "Swift", "Bubble Beam", "Mud Shot", "Muddy Water", "Agility", "Whirlpool", "Rage", "Brine", "Revenge", },
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Sandile",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Bite", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Torment", At = 10 }, new Move { Name = "Sand Tomb", At = 13 }, new Move { Name = "Assurance", At = 16 }, new Move { Name = "Mud-Slap", At = 19 }, new Move { Name = "Embargo", At = 22 }, new Move { Name = "Swagger", At = 25 }, new Move { Name = "Crunch", At = 28 }, new Move { Name = "Dig", At = 31 }, new Move { Name = "Scary Face", At = 34 }, new Move { Name = "Foul Play", At = 37 }, new Move { Name = "Sandstorm", At = 40 }, new Move { Name = "Earthquake", At = 43 }, new Move { Name = "Thrash", At = 46 }, },
                    eggMoves = { "Double-Edge", "Rock Climb", "Pursuit", "Uproar", "Fire Fang", "Thunder Fang", "Beat Up", "Focus Energy", "Counter", "Mean Look", "Me First", },
                    eggRand = 7,
                    FS = true,
                },

                new Species() {
                    Name = "Krokorok",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Torment", At = 10 }, new Move { Name = "Sand Tomb", At = 13 }, new Move { Name = "Assurance", At = 16 }, new Move { Name = "Mud-Slap", At = 19 }, new Move { Name = "Embargo", At = 22 }, new Move { Name = "Swagger", At = 25 }, new Move { Name = "Crunch", At = 28 }, new Move { Name = "Dig", At = 32 }, new Move { Name = "Scary Face", At = 36 }, new Move { Name = "Foul Play", At = 40 }, new Move { Name = "Sandstorm", At = 44 }, new Move { Name = "Earthquake", At = 48 }, new Move { Name = "Thrash", At = 52 }, },
                },

                new Species() {
                    Name = "Krookodile",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Bite", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Torment", At = 10 }, new Move { Name = "Sand Tomb", At = 13 }, new Move { Name = "Assurance", At = 16 }, new Move { Name = "Mud-Slap", At = 19 }, new Move { Name = "Embargo", At = 22 }, new Move { Name = "Swagger", At = 25 }, new Move { Name = "Crunch", At = 28 }, new Move { Name = "Dig", At = 32 }, new Move { Name = "Scary Face", At = 36 }, new Move { Name = "Foul Play", At = 42 }, new Move { Name = "Sandstorm", At = 48 }, new Move { Name = "Earthquake", At = 54 }, new Move { Name = "Outrage", At = 60 }, },
                },

                new Species() {
                    Name = "Darumaka",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Rollout", At = 3 }, new Move { Name = "Incinerate", At = 6 }, new Move { Name = "Rage", At = 9 }, new Move { Name = "Fire Fang", At = 11 }, new Move { Name = "Headbutt", At = 14 }, new Move { Name = "Uproar", At = 17 }, new Move { Name = "Facade", At = 19 }, new Move { Name = "Fire Punch", At = 22 }, new Move { Name = "Work Up", At = 25 }, new Move { Name = "Thrash", At = 27 }, new Move { Name = "Belly Drum", At = 30 }, new Move { Name = "Flare Blitz", At = 33 }, new Move { Name = "Taunt", At = 35 }, new Move { Name = "Superpower", At = 39 }, new Move { Name = "Overheat", At = 42 }, },
                    eggMoves = { "Sleep Talk", "Focus Punch", "Focus Energy", "Endure", "Hammer Arm", "Take Down", "Flame Wheel", "Encore", "Yawn", "Snatch", },
                },

                new Species() {
                    Name = "Darmanitan",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Incinerate", At = 1 }, new Move { Name = "Rage", At = 1 }, new Move { Name = "Rollout", At = 3 }, new Move { Name = "Incinerate", At = 6 }, new Move { Name = "Rage", At = 9 }, new Move { Name = "Fire Fang", At = 11 }, new Move { Name = "Headbutt", At = 14 }, new Move { Name = "Swagger", At = 17 }, new Move { Name = "Facade", At = 19 }, new Move { Name = "Fire Punch", At = 22 }, new Move { Name = "Work Up", At = 25 }, new Move { Name = "Thrash", At = 27 }, new Move { Name = "Belly Drum", At = 30 }, new Move { Name = "Flare Blitz", At = 33 }, new Move { Name = "Hammer Arm", At = 35 }, new Move { Name = "Taunt", At = 39 }, new Move { Name = "Superpower", At = 47 }, new Move { Name = "Overheat", At = 54 }, },
                    eggMoves = { "Sleep Talk", "Focus Punch", "Focus Energy", "Endure", "Hammer Arm", "Take Down", "Flame Wheel", "Encore", "Yawn", "Snatch", },
                },

                new Species() {
                    Name = "Maractus",
                    moves = { new Move { Name = "Spiky Shield", At = 1 }, new Move { Name = "Cotton Guard", At = 1 }, new Move { Name = "After You", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Sweet Scent", At = 3 }, new Move { Name = "Growth", At = 6 }, new Move { Name = "Pin Missile", At = 10 }, new Move { Name = "Mega Drain", At = 13 }, new Move { Name = "Synthesis", At = 15 }, new Move { Name = "Cotton Spore", At = 18 }, new Move { Name = "Needle Arm", At = 22 }, new Move { Name = "Giga Drain", At = 26 }, new Move { Name = "Acupressure", At = 29 }, new Move { Name = "Ingrain", At = 33 }, new Move { Name = "Petal Dance", At = 38 }, new Move { Name = "Sucker Punch", At = 42 }, new Move { Name = "Sunny Day", At = 45 }, new Move { Name = "Petal Blizzard", At = 48 }, new Move { Name = "Solar Beam", At = 50 }, new Move { Name = "Cotton Guard", At = 55 }, new Move { Name = "After You", At = 57 }, },
                    eggMoves = { "Bullet Seed", "Bounce", "Worry Seed", "Leech Seed", "Seed Bomb", "Wood Hammer", "Spikes", "Grass Whistle", "Grassy Terrain", },
                    FS = true,
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Dwebble",
                    moves = { new Move { Name = "Fury Cutter", At = 1 }, new Move { Name = "Rock Blast", At = 5 }, new Move { Name = "Withdraw", At = 7 }, new Move { Name = "Sand Attack", At = 11 }, new Move { Name = "Feint Attack", At = 13 }, new Move { Name = "Smack Down", At = 17 }, new Move { Name = "Rock Polish", At = 19 }, new Move { Name = "Bug Bite", At = 23 }, new Move { Name = "Stealth Rock", At = 24 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Slash", At = 31 }, new Move { Name = "X-Scissor", At = 35 }, new Move { Name = "Shell Smash", At = 37 }, new Move { Name = "Flail", At = 41 }, new Move { Name = "Rock Wrecker", At = 43 }, },
                    eggMoves = { "Endure", "Iron Defense", "Night Slash", "Sand Tomb", "Counter", "Curse", "Spikes", "Block", "Wide Guard", "Rototiller", },
                    eggRand = 7,
                    FS = true,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Crustle",
                    moves = { new Move { Name = "Shell Smash", At = 1 }, new Move { Name = "Rock Blast", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Rock Blast", At = 5 }, new Move { Name = "Withdraw", At = 7 }, new Move { Name = "Sand Attack", At = 11 }, new Move { Name = "Feint Attack", At = 13 }, new Move { Name = "Smack Down", At = 17 }, new Move { Name = "Rock Polish", At = 19 }, new Move { Name = "Bug Bite", At = 23 }, new Move { Name = "Stealth Rock", At = 24 }, new Move { Name = "Rock Slide", At = 29 }, new Move { Name = "Slash", At = 31 }, new Move { Name = "X-Scissor", At = 38 }, new Move { Name = "Shell Smash", At = 43 }, new Move { Name = "Flail", At = 50 }, new Move { Name = "Rock Wrecker", At = 55 }, },
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Scraggy",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Feint Attack", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Swagger", At = 16 }, new Move { Name = "Brick Break", At = 20 }, new Move { Name = "Payback", At = 23 }, new Move { Name = "Chip Away", At = 27 }, new Move { Name = "High Jump Kick", At = 31 }, new Move { Name = "Scary Face", At = 34 }, new Move { Name = "Crunch", At = 38 }, new Move { Name = "Facade", At = 42 }, new Move { Name = "Rock Climb", At = 45 }, new Move { Name = "Focus Punch", At = 48 }, new Move { Name = "Head Smash", At = 50 }, },
                    eggMoves = { "Drain Punch", "Counter", "Dragon Dance", "Detect", "Fake Out", "Fire Punch", "Ice Punch", "Thunder Punch", "Amnesia", "Feint Attack", "Zen Headbutt", "Quick Guard", },
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Scrafty",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Low Kick", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Feint Attack", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Feint Attack", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Swagger", At = 16 }, new Move { Name = "Brick Break", At = 20 }, new Move { Name = "Payback", At = 23 }, new Move { Name = "Chip Away", At = 27 }, new Move { Name = "High Jump Kick", At = 31 }, new Move { Name = "Scary Face", At = 34 }, new Move { Name = "Crunch", At = 38 }, new Move { Name = "Facade", At = 45 }, new Move { Name = "Rock Climb", At = 51 }, new Move { Name = "Focus Punch", At = 58 }, new Move { Name = "Head Smash", At = 65 }, },
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Sigilyph",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Miracle Eye", At = 1 }, new Move { Name = "Hypnosis", At = 4 }, new Move { Name = "Psywave", At = 8 }, new Move { Name = "Tailwind", At = 11 }, new Move { Name = "Whirlwind", At = 14 }, new Move { Name = "Psybeam", At = 18 }, new Move { Name = "Air Cutter", At = 21 }, new Move { Name = "Light Screen", At = 24 }, new Move { Name = "Reflect", At = 28 }, new Move { Name = "Synchronoise", At = 31 }, new Move { Name = "Mirror Move", At = 34 }, new Move { Name = "Gravity", At = 38 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Psychic", At = 44 }, new Move { Name = "Cosmic Power", At = 48 }, new Move { Name = "Sky Attack", At = 50 }, },
                    eggMoves = { "Stored Power", "Psycho Shift", "Ancient Power", "Steel Wing", "Roost", "Skill Swap", "Future Sight", },
                    FS = true,
                },

                new Species() {
                    Name = "Yamask",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Disable", At = 5 }, new Move { Name = "Haze", At = 9 }, new Move { Name = "Night Shade", At = 13 }, new Move { Name = "Hex", At = 17 }, new Move { Name = "Will-O-Wisp", At = 21 }, new Move { Name = "Ominous Wind", At = 25 }, new Move { Name = "Curse", At = 29 }, new Move { Name = "Power Split", At = 33 }, new Move { Name = "Guard Split", At = 33 }, new Move { Name = "Shadow Ball", At = 37 }, new Move { Name = "Grudge", At = 41 }, new Move { Name = "Mean Look", At = 45 }, new Move { Name = "Destiny Bond", At = 49 }, },
                    eggMoves = { "Memento", "Fake Tears", "Nasty Plot", "Endure", "Heal Block", "Imprison", "Nightmare", "Disable", "Ally Switch", "Toxic Spikes", },
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Cofagrigus",
                    moves = { new Move { Name = "Astonish", At = 1 }, new Move { Name = "Protect", At = 1 }, new Move { Name = "Disable", At = 1 }, new Move { Name = "Haze", At = 1 }, new Move { Name = "Disable", At = 5 }, new Move { Name = "Haze", At = 9 }, new Move { Name = "Night Shade", At = 13 }, new Move { Name = "Hex", At = 17 }, new Move { Name = "Will-O-Wisp", At = 21 }, new Move { Name = "Ominous Wind", At = 25 }, new Move { Name = "Curse", At = 29 }, new Move { Name = "Power Split", At = 33 }, new Move { Name = "Guard Split", At = 33 }, new Move { Name = "Scary Face", At = 34 }, new Move { Name = "Shadow Ball", At = 39 }, new Move { Name = "Grudge", At = 45 }, new Move { Name = "Mean Look", At = 51 }, new Move { Name = "Destiny Bond", At = 57 }, },
                    eggMoves = { "Memento", "Fake Tears", "Nasty Plot", "Endure", "Heal Block", "Imprison", "Nightmare", "Disable", "Ally Switch", "Toxic Spikes", },
                    eggRand = 7,
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Tirtouga",
                    moves = { new Move { Name = "Bide", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 5 }, new Move { Name = "Bite", At = 8 }, new Move { Name = "Protect", At = 11 }, new Move { Name = "Aqua Jet", At = 15 }, new Move { Name = "Ancient Power", At = 18 }, new Move { Name = "Crunch", At = 21 }, new Move { Name = "Wide Guard", At = 25 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Smack Down", At = 31 }, new Move { Name = "Curse", At = 35 }, new Move { Name = "Shell Smash", At = 38 }, new Move { Name = "Aqua Tail", At = 41 }, new Move { Name = "Rock Slide", At = 45 }, new Move { Name = "Rain Dance", At = 48 }, new Move { Name = "Hydro Pump", At = 50 }, },
                    eggMoves = { "Water Pulse", "Knock Off", "Rock Throw", "Slam", "Iron Defense", "Flail", "Whirlpool", "Body Slam", "Bide", "Guard Swap", },
                },

                new Species() {
                    Name = "Carracosta",
                    moves = { new Move { Name = "Bide", At = 1 }, new Move { Name = "Withdraw", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Rollout", At = 5 }, new Move { Name = "Bite", At = 8 }, new Move { Name = "Protect", At = 11 }, new Move { Name = "Aqua Jet", At = 15 }, new Move { Name = "Ancient Power", At = 18 }, new Move { Name = "Crunch", At = 21 }, new Move { Name = "Wide Guard", At = 25 }, new Move { Name = "Brine", At = 28 }, new Move { Name = "Smack Down", At = 31 }, new Move { Name = "Curse", At = 35 }, new Move { Name = "Shell Smash", At = 40 }, new Move { Name = "Aqua Tail", At = 45 }, new Move { Name = "Rock Slide", At = 51 }, new Move { Name = "Rain Dance", At = 56 }, new Move { Name = "Hydro Pump", At = 61 }, },
                },

                new Species() {
                    Name = "Archen",
                    moves = { new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Rock Throw", At = 5 }, new Move { Name = "Double Team", At = 8 }, new Move { Name = "Scary Face", At = 11 }, new Move { Name = "Pluck", At = 15 }, new Move { Name = "Ancient Power", At = 18 }, new Move { Name = "Agility", At = 21 }, new Move { Name = "Quick Guard", At = 25 }, new Move { Name = "Acrobatics", At = 28 }, new Move { Name = "Dragon Breath", At = 31 }, new Move { Name = "Crunch", At = 35 }, new Move { Name = "Endeavor", At = 38 }, new Move { Name = "U-turn", At = 41 }, new Move { Name = "Rock Slide", At = 45 }, new Move { Name = "Dragon Claw", At = 48 }, new Move { Name = "Thrash", At = 50 }, },
                    eggMoves = { "Steel Wing", "Defog", "Dragon Pulse", "Head Smash", "Knock Off", "Earth Power", "Bite", "Ally Switch", "Switcheroo", },
                },

                new Species() {
                    Name = "Archeops",
                    moves = { new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Rock Throw", At = 1 }, new Move { Name = "Rock Throw", At = 5 }, new Move { Name = "Double Team", At = 8 }, new Move { Name = "Scary Face", At = 11 }, new Move { Name = "Pluck", At = 15 }, new Move { Name = "Ancient Power", At = 18 }, new Move { Name = "Agility", At = 21 }, new Move { Name = "Quick Guard", At = 25 }, new Move { Name = "Acrobatics", At = 28 }, new Move { Name = "Dragon Breath", At = 31 }, new Move { Name = "Crunch", At = 35 }, new Move { Name = "Endeavor", At = 40 }, new Move { Name = "U-turn", At = 45 }, new Move { Name = "Rock Slide", At = 51 }, new Move { Name = "Dragon Claw", At = 56 }, new Move { Name = "Thrash", At = 61 }, },
                },

                new Species() {
                    Name = "Trubbish",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Recycle", At = 3 }, new Move { Name = "Toxic Spikes", At = 7 }, new Move { Name = "Acid Spray", At = 12 }, new Move { Name = "Double Slap", At = 14 }, new Move { Name = "Sludge", At = 18 }, new Move { Name = "Stockpile", At = 23 }, new Move { Name = "Swallow", At = 23 }, new Move { Name = "Take Down", At = 25 }, new Move { Name = "Sludge Bomb", At = 29 }, new Move { Name = "Clear Smog", At = 34 }, new Move { Name = "Toxic", At = 36 }, new Move { Name = "Amnesia", At = 40 }, new Move { Name = "Belch", At = 42 }, new Move { Name = "Gunk Shot", At = 45 }, new Move { Name = "Explosion", At = 47 }, },
                    eggMoves = { "Spikes", "Rollout", "Haze", "Curse", "Rock Blast", "Sand Attack", "Mud Sport", "Self-Destruct", },
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Garbodor",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Poison Gas", At = 1 }, new Move { Name = "Recycle", At = 1 }, new Move { Name = "Toxic Spikes", At = 1 }, new Move { Name = "Recycle", At = 3 }, new Move { Name = "Toxic Spikes", At = 7 }, new Move { Name = "Acid Spray", At = 12 }, new Move { Name = "Double Slap", At = 14 }, new Move { Name = "Sludge", At = 18 }, new Move { Name = "Stockpile", At = 23 }, new Move { Name = "Swallow", At = 23 }, new Move { Name = "Body Slam", At = 25 }, new Move { Name = "Sludge Bomb", At = 29 }, new Move { Name = "Clear Smog", At = 34 }, new Move { Name = "Toxic", At = 39 }, new Move { Name = "Amnesia", At = 46 }, new Move { Name = "Belch", At = 49 }, new Move { Name = "Gunk Shot", At = 54 }, new Move { Name = "Explosion", At = 59 }, },
                    FS = true,
                    item5 = "Nugget",
                    item50 = "Black Sludge",
                },

                new Species() {
                    Name = "Zorua",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Pursuit", At = 5 }, new Move { Name = "Fake Tears", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Scary Face", At = 21 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Foul Play", At = 29 }, new Move { Name = "Torment", At = 33 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Embargo", At = 41 }, new Move { Name = "Punishment", At = 45 }, new Move { Name = "Nasty Plot", At = 49 }, new Move { Name = "Imprison", At = 53 }, new Move { Name = "Night Daze", At = 57 }, },
                    eggMoves = { "Detect", "Captivate", "Dark Pulse", "Snatch", "Memento", "Sucker Punch", "Extrasensory", "Counter", "Copycat", },
                },

                new Species() {
                    Name = "Zoroark",
                    moves = { new Move { Name = "Night Daze", At = 1 }, new Move { Name = "Imprison", At = 1 }, new Move { Name = "U-turn", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Pursuit", At = 1 }, new Move { Name = "Hone Claws", At = 1 }, new Move { Name = "Pursuit", At = 5 }, new Move { Name = "Hone Claws", At = 9 }, new Move { Name = "Fury Swipes", At = 13 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Scary Face", At = 21 }, new Move { Name = "Taunt", At = 25 }, new Move { Name = "Foul Play", At = 29 }, new Move { Name = "Night Slash", At = 30 }, new Move { Name = "Torment", At = 34 }, new Move { Name = "Agility", At = 39 }, new Move { Name = "Embargo", At = 44 }, new Move { Name = "Punishment", At = 49 }, new Move { Name = "Nasty Plot", At = 54 }, new Move { Name = "Imprison", At = 59 }, new Move { Name = "Night Daze", At = 64 }, },
                },

                new Species() {
                    Name = "Minccino",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Baby-Doll Eyes", At = 3 }, new Move { Name = "Helping Hand", At = 7 }, new Move { Name = "Tickle", At = 9 }, new Move { Name = "Double Slap", At = 13 }, new Move { Name = "Encore", At = 15 }, new Move { Name = "Swift", At = 19 }, new Move { Name = "Sing", At = 21 }, new Move { Name = "Tail Slap", At = 25 }, new Move { Name = "Charm", At = 27 }, new Move { Name = "Wake-Up Slap", At = 31 }, new Move { Name = "Echoed Voice", At = 33 }, new Move { Name = "Slam", At = 37 }, new Move { Name = "Captivate", At = 39 }, new Move { Name = "Hyper Voice", At = 43 }, new Move { Name = "Last Resort", At = 45 }, new Move { Name = "After You", At = 49 }, },
                    eggMoves = { "Iron Tail", "Tail Whip", "Aqua Tail", "Mud-Slap", "Knock Off", "Fake Tears", "Sleep Talk", "Endure", "Flail", },
                    FS = true,
                },

                new Species() {
                    Name = "Cinccino",
                    moves = { new Move { Name = "Bullet Seed", At = 1 }, new Move { Name = "Rock Blast", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Tickle", At = 1 }, new Move { Name = "Sing", At = 1 }, new Move { Name = "Tail Slap", At = 1 }, },
                },

                new Species() {
                    Name = "Gothita",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Confusion", At = 3 }, new Move { Name = "Tickle", At = 7 }, new Move { Name = "Play Nice", At = 8 }, new Move { Name = "Fake Tears", At = 10 }, new Move { Name = "Double Slap", At = 14 }, new Move { Name = "Psybeam", At = 16 }, new Move { Name = "Embargo", At = 19 }, new Move { Name = "Feint Attack", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Flatter", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Heal Block", At = 33 }, new Move { Name = "Psychic", At = 37 }, new Move { Name = "Telekinesis", At = 40 }, new Move { Name = "Charm", At = 46 }, new Move { Name = "Magic Room", At = 48 }, },
                    eggMoves = { "Mirror Coat", "Uproar", "Miracle Eye", "Captivate", "Mean Look", "Dark Pulse", "Heal Pulse", },
                },

                new Species() {
                    Name = "Gothorita",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Tickle", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Confusion", At = 3 }, new Move { Name = "Tickle", At = 7 }, new Move { Name = "Fake Tears", At = 10 }, new Move { Name = "Double Slap", At = 14 }, new Move { Name = "Psybeam", At = 16 }, new Move { Name = "Embargo", At = 19 }, new Move { Name = "Feint Attack", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Flatter", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Heal Block", At = 34 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Telekinesis", At = 43 }, new Move { Name = "Charm", At = 50 }, new Move { Name = "Magic Room", At = 53 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Gothitelle",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Tickle", At = 1 }, new Move { Name = "Play Nice", At = 1 }, new Move { Name = "Confusion", At = 3 }, new Move { Name = "Tickle", At = 7 }, new Move { Name = "Fake Tears", At = 10 }, new Move { Name = "Double Slap", At = 14 }, new Move { Name = "Psybeam", At = 16 }, new Move { Name = "Embargo", At = 19 }, new Move { Name = "Feint Attack", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Flatter", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Heal Block", At = 34 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Telekinesis", At = 45 }, new Move { Name = "Charm", At = 54 }, new Move { Name = "Magic Room", At = 59 }, },
                },

                new Species() {
                    Name = "Solosis",
                    moves = { new Move { Name = "Psywave", At = 1 }, new Move { Name = "Reflect", At = 3 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Snatch", At = 10 }, new Move { Name = "Hidden Power", At = 14 }, new Move { Name = "Light Screen", At = 16 }, new Move { Name = "Charm", At = 19 }, new Move { Name = "Recover", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Endeavor", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Pain Split", At = 33 }, new Move { Name = "Psychic", At = 37 }, new Move { Name = "Skill Swap", At = 40 }, new Move { Name = "Heal Block", At = 46 }, new Move { Name = "Wonder Room", At = 48 }, },
                    eggMoves = { "Night Shade", "Astonish", "Confuse Ray", "Acid Armor", "Trick", "Imprison", "Secret Power", "Astonish", "Helping Hand", },
                },

                new Species() {
                    Name = "Duosion",
                    moves = { new Move { Name = "Psywave", At = 1 }, new Move { Name = "Reflect", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Snatch", At = 1 }, new Move { Name = "Reflect", At = 3 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Snatch", At = 10 }, new Move { Name = "Hidden Power", At = 14 }, new Move { Name = "Light Screen", At = 16 }, new Move { Name = "Charm", At = 19 }, new Move { Name = "Recover", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Endeavor", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Pain Split", At = 34 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Skill Swap", At = 43 }, new Move { Name = "Heal Block", At = 50 }, new Move { Name = "Wonder Room", At = 53 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Reuniclus",
                    moves = { new Move { Name = "Psywave", At = 1 }, new Move { Name = "Reflect", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Snatch", At = 1 }, new Move { Name = "Reflect", At = 3 }, new Move { Name = "Rollout", At = 7 }, new Move { Name = "Snatch", At = 10 }, new Move { Name = "Hidden Power", At = 14 }, new Move { Name = "Light Screen", At = 16 }, new Move { Name = "Charm", At = 19 }, new Move { Name = "Recover", At = 24 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Endeavor", At = 28 }, new Move { Name = "Future Sight", At = 31 }, new Move { Name = "Pain Split", At = 34 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Dizzy Punch", At = 41 }, new Move { Name = "Skill Swap", At = 45 }, new Move { Name = "Heal Block", At = 54 }, new Move { Name = "Wonder Room", At = 59 }, },
                },

                new Species() {
                    Name = "Ducklett",
                    moves = { new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 3 }, new Move { Name = "Defog", At = 6 }, new Move { Name = "Wing Attack", At = 9 }, new Move { Name = "Water Pulse", At = 13 }, new Move { Name = "Aerial Ace", At = 15 }, new Move { Name = "Bubble Beam", At = 19 }, new Move { Name = "Feather Dance", At = 21 }, new Move { Name = "Aqua Ring", At = 24 }, new Move { Name = "Air Slash", At = 27 }, new Move { Name = "Roost", At = 30 }, new Move { Name = "Rain Dance", At = 34 }, new Move { Name = "Tailwind", At = 37 }, new Move { Name = "Brave Bird", At = 41 }, new Move { Name = "Hurricane", At = 46 }, },
                    eggMoves = { "Steel Wing", "Brine", "Gust", "Air Cutter", "Mirror Move", "Me First", "Lucky Chant", "Mud Sport", },
                },

                new Species() {
                    Name = "Swanna",
                    moves = { new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Defog", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Water Sport", At = 3 }, new Move { Name = "Defog", At = 6 }, new Move { Name = "Wing Attack", At = 9 }, new Move { Name = "Water Pulse", At = 13 }, new Move { Name = "Aerial Ace", At = 15 }, new Move { Name = "Bubble Beam", At = 19 }, new Move { Name = "Feather Dance", At = 21 }, new Move { Name = "Aqua Ring", At = 24 }, new Move { Name = "Air Slash", At = 27 }, new Move { Name = "Roost", At = 30 }, new Move { Name = "Rain Dance", At = 34 }, new Move { Name = "Tailwind", At = 40 }, new Move { Name = "Brave Bird", At = 47 }, new Move { Name = "Hurricane", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Vanillite",
                    moves = { new Move { Name = "Icicle Spear", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Uproar", At = 10 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Mist", At = 16 }, new Move { Name = "Avalanche", At = 19 }, new Move { Name = "Taunt", At = 22 }, new Move { Name = "Mirror Shot", At = 26 }, new Move { Name = "Acid Armor", At = 31 }, new Move { Name = "Ice Beam", At = 35 }, new Move { Name = "Hail", At = 40 }, new Move { Name = "Mirror Coat", At = 44 }, new Move { Name = "Blizzard", At = 49 }, new Move { Name = "Sheer Cold", At = 53 }, },
                    eggMoves = { "Water Pulse", "Natural Gift", "Imprison", "Autotomize", "Iron Defense", "Magnet Rise", "Ice Shard", "Powder Snow", },
                },

                new Species() {
                    Name = "Vanillish",
                    moves = { new Move { Name = "Icicle Spear", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Uproar", At = 10 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Mist", At = 16 }, new Move { Name = "Avalanche", At = 19 }, new Move { Name = "Taunt", At = 22 }, new Move { Name = "Mirror Shot", At = 26 }, new Move { Name = "Acid Armor", At = 31 }, new Move { Name = "Ice Beam", At = 36 }, new Move { Name = "Hail", At = 42 }, new Move { Name = "Mirror Coat", At = 47 }, new Move { Name = "Blizzard", At = 53 }, new Move { Name = "Sheer Cold", At = 58 }, },
                },

                new Species() {
                    Name = "Vanilluxe",
                    moves = { new Move { Name = "Sheer Cold", At = 1 }, new Move { Name = "Freeze-Dry", At = 1 }, new Move { Name = "Weather Ball", At = 1 }, new Move { Name = "Icicle Spear", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Astonish", At = 7 }, new Move { Name = "Uproar", At = 10 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Mist", At = 16 }, new Move { Name = "Avalanche", At = 19 }, new Move { Name = "Taunt", At = 22 }, new Move { Name = "Mirror Shot", At = 26 }, new Move { Name = "Acid Armor", At = 31 }, new Move { Name = "Ice Beam", At = 36 }, new Move { Name = "Hail", At = 42 }, new Move { Name = "Mirror Coat", At = 50 }, new Move { Name = "Blizzard", At = 59 }, new Move { Name = "Sheer Cold", At = 67 }, },
                },

                new Species() {
                    Name = "Deerling",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Camouflage", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Double Kick", At = 10 }, new Move { Name = "Leech Seed", At = 13 }, new Move { Name = "Feint Attack", At = 16 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Jump Kick", At = 24 }, new Move { Name = "Aromatherapy", At = 28 }, new Move { Name = "Energy Ball", At = 32 }, new Move { Name = "Charm", At = 36 }, new Move { Name = "Nature Power", At = 41 }, new Move { Name = "Double-Edge", At = 46 }, new Move { Name = "Solar Beam", At = 51 }, },
                    eggMoves = { "Fake Tears", "Natural Gift", "Synthesis", "Worry Seed", "Odor Sleuth", "Agility", "Sleep Talk", "Baton Pass", "Grass Whistle", },
                },

                new Species() {
                    Name = "Sawsbuck",
                    moves = { new Move { Name = "Megahorn", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Camouflage", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Sand Attack", At = 7 }, new Move { Name = "Double Kick", At = 10 }, new Move { Name = "Leech Seed", At = 13 }, new Move { Name = "Feint Attack", At = 16 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Jump Kick", At = 24 }, new Move { Name = "Aromatherapy", At = 28 }, new Move { Name = "Energy Ball", At = 32 }, new Move { Name = "Charm", At = 36 }, new Move { Name = "Horn Leech", At = 37 }, new Move { Name = "Nature Power", At = 44 }, new Move { Name = "Double-Edge", At = 52 }, new Move { Name = "Solar Beam", At = 60 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Emolga",
                    moves = { new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Quick Attack", At = 4 }, new Move { Name = "Tail Whip", At = 7 }, new Move { Name = "Charge", At = 10 }, new Move { Name = "Spark", At = 13 }, new Move { Name = "Nuzzle", At = 15 }, new Move { Name = "Pursuit", At = 16 }, new Move { Name = "Double Team", At = 19 }, new Move { Name = "Shock Wave", At = 22 }, new Move { Name = "Electro Ball", At = 26 }, new Move { Name = "Acrobatics", At = 30 }, new Move { Name = "Light Screen", At = 34 }, new Move { Name = "Encore", At = 38 }, new Move { Name = "Volt Switch", At = 42 }, new Move { Name = "Agility", At = 46 }, new Move { Name = "Discharge", At = 50 }, },
                    eggMoves = { "Roost", "Iron Tail", "Astonish", "Air Slash", "Shock Wave", "Charm", "Covet", "Tickle", "Baton Pass", "Ion Deluge", },
                    FS = true,
                },

                new Species() {
                    Name = "Karrablast",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Endure", At = 8 }, new Move { Name = "Fury Cutter", At = 13 }, new Move { Name = "Fury Attack", At = 16 }, new Move { Name = "Headbutt", At = 20 }, new Move { Name = "False Swipe", At = 25 }, new Move { Name = "Bug Buzz", At = 28 }, new Move { Name = "Slash", At = 32 }, new Move { Name = "Take Down", At = 37 }, new Move { Name = "Scary Face", At = 40 }, new Move { Name = "X-Scissor", At = 44 }, new Move { Name = "Flail", At = 49 }, new Move { Name = "Swords Dance", At = 52 }, new Move { Name = "Double-Edge", At = 56 }, },
                    eggMoves = { "Megahorn", "Pursuit", "Counter", "Horn Attack", "Feint Attack", "Bug Bite", "Screech", "Knock Off", "Drill Run", },
                },

                new Species() {
                    Name = "Escavalier",
                    moves = { new Move { Name = "Double-Edge", At = 1 }, new Move { Name = "Fell Stinger", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Twineedle", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Quick Guard", At = 8 }, new Move { Name = "Twineedle", At = 13 }, new Move { Name = "Fury Attack", At = 16 }, new Move { Name = "Headbutt", At = 20 }, new Move { Name = "False Swipe", At = 25 }, new Move { Name = "Bug Buzz", At = 28 }, new Move { Name = "Slash", At = 32 }, new Move { Name = "Iron Head", At = 37 }, new Move { Name = "Iron Defense", At = 40 }, new Move { Name = "X-Scissor", At = 44 }, new Move { Name = "Reversal", At = 49 }, new Move { Name = "Swords Dance", At = 52 }, new Move { Name = "Giga Impact", At = 56 }, new Move { Name = "Fell Stinger", At = 60 }, },
                },

                new Species() {
                    Name = "Foongus",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 6 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Bide", At = 12 }, new Move { Name = "Mega Drain", At = 15 }, new Move { Name = "Ingrain", At = 18 }, new Move { Name = "Feint Attack", At = 20 }, new Move { Name = "Sweet Scent", At = 24 }, new Move { Name = "Giga Drain", At = 28 }, new Move { Name = "Toxic", At = 32 }, new Move { Name = "Synthesis", At = 35 }, new Move { Name = "Clear Smog", At = 39 }, new Move { Name = "Solar Beam", At = 43 }, new Move { Name = "Rage Powder", At = 45 }, new Move { Name = "Spore", At = 50 }, },
                    eggMoves = { "Gastro Acid", "Growth", "Poison Powder", "Stun Spore", "Rollout", "Defense Curl", "Endure", "Body Slam", },
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Amoonguss",
                    moves = { new Move { Name = "Absorb", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Growth", At = 6 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Bide", At = 12 }, new Move { Name = "Mega Drain", At = 15 }, new Move { Name = "Ingrain", At = 18 }, new Move { Name = "Feint Attack", At = 20 }, new Move { Name = "Sweet Scent", At = 24 }, new Move { Name = "Giga Drain", At = 28 }, new Move { Name = "Toxic", At = 32 }, new Move { Name = "Synthesis", At = 35 }, new Move { Name = "Clear Smog", At = 43 }, new Move { Name = "Solar Beam", At = 49 }, new Move { Name = "Rage Powder", At = 54 }, new Move { Name = "Spore", At = 62 }, },
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Frillish",
                    moves = { new Move { Name = "Bubble", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Night Shade", At = 9 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Recover", At = 17 }, new Move { Name = "Water Pulse", At = 22 }, new Move { Name = "Ominous Wind", At = 27 }, new Move { Name = "Brine", At = 32 }, new Move { Name = "Rain Dance", At = 37 }, new Move { Name = "Hex", At = 43 }, new Move { Name = "Hydro Pump", At = 49 }, new Move { Name = "Wring Out", At = 55 }, new Move { Name = "Water Spout", At = 61 }, },
                    eggMoves = { "Acid Armor", "Confuse Ray", "Pain Split", "Mist", "Recover", "Constrict", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Jellicent",
                    moves = { new Move { Name = "Water Spout", At = 1 }, new Move { Name = "Wring Out", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Absorb", At = 1 }, new Move { Name = "Night Shade", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Night Shade", At = 9 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Recover", At = 17 }, new Move { Name = "Water Pulse", At = 22 }, new Move { Name = "Ominous Wind", At = 27 }, new Move { Name = "Brine", At = 32 }, new Move { Name = "Rain Dance", At = 37 }, new Move { Name = "Hex", At = 45 }, new Move { Name = "Hydro Pump", At = 53 }, new Move { Name = "Wring Out", At = 61 }, new Move { Name = "Water Spout", At = 69 }, },
                },

                new Species() {
                    Name = "Alomomola",
                    moves = { new Move { Name = "Hydro Pump", At = 1 }, new Move { Name = "Wide Guard", At = 1 }, new Move { Name = "Healing Wish", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Water Sport", At = 1 }, new Move { Name = "Aqua Ring", At = 5 }, new Move { Name = "Aqua Jet", At = 9 }, new Move { Name = "Double Slap", At = 13 }, new Move { Name = "Heal Pulse", At = 17 }, new Move { Name = "Protect", At = 21 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Wake-Up Slap", At = 29 }, new Move { Name = "Soak", At = 33 }, new Move { Name = "Wish", At = 37 }, new Move { Name = "Brine", At = 41 }, new Move { Name = "Safeguard", At = 45 }, new Move { Name = "Helping Hand", At = 49 }, new Move { Name = "Wide Guard", At = 53 }, new Move { Name = "Healing Wish", At = 57 }, new Move { Name = "Hydro Pump", At = 61 }, },
                    eggMoves = { "Pain Split", "Refresh", "Tickle", "Mirror Coat", "Mist", "Endure", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Joltik",
                    moves = { new Move { Name = "String Shot", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Spider Web", At = 1 }, new Move { Name = "Thunder Wave", At = 4 }, new Move { Name = "Screech", At = 7 }, new Move { Name = "Fury Cutter", At = 12 }, new Move { Name = "Electroweb", At = 15 }, new Move { Name = "Bug Bite", At = 18 }, new Move { Name = "Gastro Acid", At = 23 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "Electro Ball", At = 29 }, new Move { Name = "Signal Beam", At = 34 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Sucker Punch", At = 40 }, new Move { Name = "Discharge", At = 45 }, new Move { Name = "Bug Buzz", At = 48 }, },
                    eggMoves = { "Pin Missile", "Poison Sting", "Cross Poison", "Rock Climb", "Pursuit", "Disable", "Feint Attack", "Camouflage", },
                },

                new Species() {
                    Name = "Galvantula",
                    moves = { new Move { Name = "Sticky Web", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Spider Web", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Thunder Wave", At = 4 }, new Move { Name = "Screech", At = 7 }, new Move { Name = "Fury Cutter", At = 12 }, new Move { Name = "Electroweb", At = 15 }, new Move { Name = "Bug Bite", At = 18 }, new Move { Name = "Gastro Acid", At = 23 }, new Move { Name = "Slash", At = 26 }, new Move { Name = "Electro Ball", At = 29 }, new Move { Name = "Signal Beam", At = 34 }, new Move { Name = "Agility", At = 40 }, new Move { Name = "Sucker Punch", At = 46 }, new Move { Name = "Discharge", At = 54 }, new Move { Name = "Bug Buzz", At = 60 }, new Move { Name = "Sticky Web", At = 65 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Ferroseed",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Rollout", At = 6 }, new Move { Name = "Curse", At = 9 }, new Move { Name = "Metal Claw", At = 14 }, new Move { Name = "Pin Missile", At = 18 }, new Move { Name = "Gyro Ball", At = 21 }, new Move { Name = "Iron Defense", At = 26 }, new Move { Name = "Mirror Shot", At = 30 }, new Move { Name = "Ingrain", At = 35 }, new Move { Name = "Self-Destruct", At = 38 }, new Move { Name = "Iron Head", At = 43 }, new Move { Name = "Payback", At = 47 }, new Move { Name = "Flash Cannon", At = 52 }, new Move { Name = "Explosion", At = 55 }, },
                    eggMoves = { "Bullet Seed", "Leech Seed", "Spikes", "Worry Seed", "Seed Bomb", "Gravity", "Rock Climb", "Stealth Rock", "Acid Spray", },
                    FS = true,
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Ferrothorn",
                    moves = { new Move { Name = "Rock Climb", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Rollout", At = 1 }, new Move { Name = "Curse", At = 1 }, new Move { Name = "Rollout", At = 6 }, new Move { Name = "Curse", At = 9 }, new Move { Name = "Metal Claw", At = 14 }, new Move { Name = "Pin Missile", At = 18 }, new Move { Name = "Gyro Ball", At = 21 }, new Move { Name = "Iron Defense", At = 26 }, new Move { Name = "Mirror Shot", At = 30 }, new Move { Name = "Ingrain", At = 35 }, new Move { Name = "Self-Destruct", At = 38 }, new Move { Name = "Power Whip", At = 40 }, new Move { Name = "Iron Head", At = 46 }, new Move { Name = "Payback", At = 53 }, new Move { Name = "Flash Cannon", At = 61 }, new Move { Name = "Explosion", At = 67 }, },
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Klink",
                    moves = { new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Charge", At = 6 }, new Move { Name = "Thunder Shock", At = 11 }, new Move { Name = "Gear Grind", At = 16 }, new Move { Name = "Bind", At = 21 }, new Move { Name = "Charge Beam", At = 26 }, new Move { Name = "Autotomize", At = 31 }, new Move { Name = "Mirror Shot", At = 36 }, new Move { Name = "Screech", At = 39 }, new Move { Name = "Discharge", At = 42 }, new Move { Name = "Metal Sound", At = 45 }, new Move { Name = "Shift Gear", At = 48 }, new Move { Name = "Lock-On", At = 50 }, new Move { Name = "Zap Cannon", At = 54 }, new Move { Name = "Hyper Beam", At = 57 }, },
                },

                new Species() {
                    Name = "Klang",
                    moves = { new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Gear Grind", At = 1 }, new Move { Name = "Charge", At = 6 }, new Move { Name = "Thunder Shock", At = 11 }, new Move { Name = "Gear Grind", At = 16 }, new Move { Name = "Bind", At = 21 }, new Move { Name = "Charge Beam", At = 26 }, new Move { Name = "Autotomize", At = 31 }, new Move { Name = "Mirror Shot", At = 36 }, new Move { Name = "Screech", At = 40 }, new Move { Name = "Discharge", At = 44 }, new Move { Name = "Metal Sound", At = 48 }, new Move { Name = "Shift Gear", At = 52 }, new Move { Name = "Lock-On", At = 56 }, new Move { Name = "Zap Cannon", At = 60 }, new Move { Name = "Hyper Beam", At = 64 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Klinklang",
                    moves = { new Move { Name = "Magnetic Flux", At = 1 }, new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Gear Grind", At = 1 }, new Move { Name = "Charge", At = 6 }, new Move { Name = "Thunder Shock", At = 11 }, new Move { Name = "Gear Grind", At = 16 }, new Move { Name = "Bind", At = 21 }, new Move { Name = "Charge Beam", At = 25 }, new Move { Name = "Autotomize", At = 31 }, new Move { Name = "Mirror Shot", At = 36 }, new Move { Name = "Screech", At = 40 }, new Move { Name = "Discharge", At = 44 }, new Move { Name = "Metal Sound", At = 48 }, new Move { Name = "Shift Gear", At = 54 }, new Move { Name = "Lock-On", At = 60 }, new Move { Name = "Zap Cannon", At = 66 }, new Move { Name = "Hyper Beam", At = 72 }, new Move { Name = "Magnetic Flux", At = 76 }, },
                },

                new Species() {
                    Name = "Tynamo",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Spark", At = 1 }, new Move { Name = "Charge Beam", At = 1 }, },
                },

                new Species() {
                    Name = "Eelektrik",
                    moves = { new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Thunder Wave", At = 1 }, new Move { Name = "Spark", At = 1 }, new Move { Name = "Charge Beam", At = 1 }, new Move { Name = "Bind", At = 9 }, new Move { Name = "Acid", At = 19 }, new Move { Name = "Discharge", At = 29 }, new Move { Name = "Crunch", At = 39 }, new Move { Name = "Thunderbolt", At = 44 }, new Move { Name = "Acid Spray", At = 49 }, new Move { Name = "Coil", At = 54 }, new Move { Name = "Wild Charge", At = 59 }, new Move { Name = "Gastro Acid", At = 64 }, new Move { Name = "Zap Cannon", At = 69 }, new Move { Name = "Thrash", At = 74 }, },
                },

                new Species() {
                    Name = "Eelektross",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Zap Cannon", At = 1 }, new Move { Name = "Gastro Acid", At = 1 }, new Move { Name = "Coil", At = 1 }, new Move { Name = "Ion Deluge", At = 1 }, new Move { Name = "Crush Claw", At = 1 }, new Move { Name = "Headbutt", At = 1 }, new Move { Name = "Acid", At = 1 }, new Move { Name = "Discharge", At = 1 }, new Move { Name = "Crunch", At = 1 }, },
                },

                new Species() {
                    Name = "Elgyem",
                    moves = { new Move { Name = "Confusion", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Heal Block", At = 8 }, new Move { Name = "Miracle Eye", At = 11 }, new Move { Name = "Psybeam", At = 15 }, new Move { Name = "Headbutt", At = 18 }, new Move { Name = "Hidden Power", At = 22 }, new Move { Name = "Imprison", At = 25 }, new Move { Name = "Simple Beam", At = 29 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Psych Up", At = 36 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Calm Mind", At = 43 }, new Move { Name = "Recover", At = 46 }, new Move { Name = "Guard Split", At = 50 }, new Move { Name = "Power Split", At = 50 }, new Move { Name = "Synchronoise", At = 53 }, new Move { Name = "Wonder Room", At = 56 }, },
                    eggMoves = { "Teleport", "Disable", "Astonish", "Power Swap", "Guard Swap", "Barrier", "Nasty Plot", "Skill Swap", "Cosmic Power", "Ally Switch", },
                },

                new Species() {
                    Name = "Beheeyem",
                    moves = { new Move { Name = "Wonder Room", At = 1 }, new Move { Name = "Synchronoise", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Heal Block", At = 1 }, new Move { Name = "Miracle Eye", At = 1 }, new Move { Name = "Growl", At = 4 }, new Move { Name = "Heal Block", At = 8 }, new Move { Name = "Miracle Eye", At = 11 }, new Move { Name = "Psybeam", At = 15 }, new Move { Name = "Headbutt", At = 18 }, new Move { Name = "Hidden Power", At = 22 }, new Move { Name = "Imprison", At = 25 }, new Move { Name = "Simple Beam", At = 29 }, new Move { Name = "Zen Headbutt", At = 32 }, new Move { Name = "Psych Up", At = 36 }, new Move { Name = "Psychic", At = 39 }, new Move { Name = "Calm Mind", At = 45 }, new Move { Name = "Recover", At = 50 }, new Move { Name = "Guard Split", At = 56 }, new Move { Name = "Power Split", At = 58 }, new Move { Name = "Synchronoise", At = 63 }, new Move { Name = "Wonder Room", At = 68 }, },
                },

                new Species() {
                    Name = "Litwick",
                    moves = { new Move { Name = "Ember", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Minimize", At = 3 }, new Move { Name = "Smog", At = 5 }, new Move { Name = "Fire Spin", At = 7 }, new Move { Name = "Confuse Ray", At = 10 }, new Move { Name = "Night Shade", At = 13 }, new Move { Name = "Will-O-Wisp", At = 16 }, new Move { Name = "Flame Burst", At = 20 }, new Move { Name = "Imprison", At = 24 }, new Move { Name = "Hex", At = 28 }, new Move { Name = "Memento", At = 33 }, new Move { Name = "Inferno", At = 38 }, new Move { Name = "Curse", At = 43 }, new Move { Name = "Shadow Ball", At = 49 }, new Move { Name = "Pain Split", At = 55 }, new Move { Name = "Overheat", At = 61 }, },
                    eggMoves = { "Acid Armor", "Heat Wave", "Haze", "Endure", "Captivate", "Acid", "Clear Smog", "Power Split", },
                },

                new Species() {
                    Name = "Lampent",
                    moves = { new Move { Name = "Ember", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Minimize", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Minimize", At = 3 }, new Move { Name = "Smog", At = 5 }, new Move { Name = "Fire Spin", At = 7 }, new Move { Name = "Confuse Ray", At = 10 }, new Move { Name = "Night Shade", At = 13 }, new Move { Name = "Will-O-Wisp", At = 16 }, new Move { Name = "Flame Burst", At = 20 }, new Move { Name = "Imprison", At = 24 }, new Move { Name = "Hex", At = 28 }, new Move { Name = "Memento", At = 33 }, new Move { Name = "Inferno", At = 38 }, new Move { Name = "Curse", At = 45 }, new Move { Name = "Shadow Ball", At = 53 }, new Move { Name = "Pain Split", At = 61 }, new Move { Name = "Overheat", At = 69 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Chandelure",
                    moves = { new Move { Name = "Pain Split", At = 1 }, new Move { Name = "Smog", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Flame Burst", At = 1 }, new Move { Name = "Hex", At = 1 }, },
                },

                new Species() {
                    Name = "Axew",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Assurance", At = 7 }, new Move { Name = "Dragon Rage", At = 10 }, new Move { Name = "Dual Chop", At = 13 }, new Move { Name = "Scary Face", At = 16 }, new Move { Name = "Slash", At = 20 }, new Move { Name = "False Swipe", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Dragon Dance", At = 32 }, new Move { Name = "Taunt", At = 36 }, new Move { Name = "Dragon Pulse", At = 41 }, new Move { Name = "Swords Dance", At = 46 }, new Move { Name = "Guillotine", At = 50 }, new Move { Name = "Outrage", At = 56 }, new Move { Name = "Giga Impact", At = 61 }, },
                    eggMoves = { "Counter", "Focus Energy", "Reversal", "Endure", "Razor Wind", "Night Slash", "Endeavor", "Iron Tail", "Dragon Pulse", "Harden", },
                    eggRand = 7,
                },

                new Species() {
                    Name = "Fraxure",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Assurance", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Assurance", At = 7 }, new Move { Name = "Dragon Rage", At = 10 }, new Move { Name = "Dual Chop", At = 13 }, new Move { Name = "Scary Face", At = 16 }, new Move { Name = "Slash", At = 20 }, new Move { Name = "False Swipe", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Dragon Dance", At = 32 }, new Move { Name = "Taunt", At = 36 }, new Move { Name = "Dragon Pulse", At = 42 }, new Move { Name = "Swords Dance", At = 48 }, new Move { Name = "Guillotine", At = 54 }, new Move { Name = "Outrage", At = 60 }, new Move { Name = "Giga Impact", At = 66 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Haxorus",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Assurance", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Leer", At = 4 }, new Move { Name = "Assurance", At = 7 }, new Move { Name = "Dragon Rage", At = 10 }, new Move { Name = "Dual Chop", At = 13 }, new Move { Name = "Scary Face", At = 16 }, new Move { Name = "Slash", At = 20 }, new Move { Name = "False Swipe", At = 24 }, new Move { Name = "Dragon Claw", At = 28 }, new Move { Name = "Dragon Dance", At = 32 }, new Move { Name = "Taunt", At = 36 }, new Move { Name = "Dragon Pulse", At = 42 }, new Move { Name = "Swords Dance", At = 50 }, new Move { Name = "Guillotine", At = 58 }, new Move { Name = "Outrage", At = 66 }, new Move { Name = "Giga Impact", At = 74 }, },
                },

                new Species() {
                    Name = "Cubchoo",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Powder Snow", At = 5 }, new Move { Name = "Bide", At = 9 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Play Nice", At = 15 }, new Move { Name = "Fury Swipes", At = 17 }, new Move { Name = "Brine", At = 21 }, new Move { Name = "Endure", At = 25 }, new Move { Name = "Charm", At = 29 }, new Move { Name = "Slash", At = 33 }, new Move { Name = "Flail", At = 36 }, new Move { Name = "Rest", At = 41 }, new Move { Name = "Blizzard", At = 45 }, new Move { Name = "Hail", At = 49 }, new Move { Name = "Thrash", At = 53 }, new Move { Name = "Sheer Cold", At = 57 }, },
                    eggMoves = { "Yawn", "Avalanche", "Encore", "Ice Punch", "Night Slash", "Assurance", "Sleep Talk", "Focus Punch", "Play Rough", },
                    eggRand = 5,
                },

                new Species() {
                    Name = "Beartic",
                    moves = { new Move { Name = "Sheer Cold", At = 1 }, new Move { Name = "Thrash", At = 1 }, new Move { Name = "Superpower", At = 1 }, new Move { Name = "Aqua Jet", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Bide", At = 1 }, new Move { Name = "Icy Wind", At = 1 }, new Move { Name = "Play Nice", At = 9 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Fury Swipes", At = 17 }, new Move { Name = "Brine", At = 21 }, new Move { Name = "Endure", At = 25 }, new Move { Name = "Swagger", At = 29 }, new Move { Name = "Slash", At = 33 }, new Move { Name = "Flail", At = 36 }, new Move { Name = "Icicle Crash", At = 37 }, new Move { Name = "Rest", At = 41 }, new Move { Name = "Blizzard", At = 45 }, new Move { Name = "Hail", At = 53 }, new Move { Name = "Thrash", At = 59 }, new Move { Name = "Sheer Cold", At = 66 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Cryogonal",
                    moves = { new Move { Name = "Sheer Cold", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Ice Shard", At = 1 }, new Move { Name = "Mist", At = 1 }, new Move { Name = "Haze", At = 1 }, new Move { Name = "Bind", At = 1 }, new Move { Name = "Ice Shard", At = 5 }, new Move { Name = "Sharpen", At = 9 }, new Move { Name = "Rapid Spin", At = 13 }, new Move { Name = "Icy Wind", At = 17 }, new Move { Name = "Mist", At = 21 }, new Move { Name = "Haze", At = 21 }, new Move { Name = "Aurora Beam", At = 25 }, new Move { Name = "Acid Armor", At = 29 }, new Move { Name = "Ice Beam", At = 33 }, new Move { Name = "Light Screen", At = 37 }, new Move { Name = "Reflect", At = 37 }, new Move { Name = "Slash", At = 41 }, new Move { Name = "Confuse Ray", At = 45 }, new Move { Name = "Recover", At = 49 }, new Move { Name = "Freeze-Dry", At = 50 }, new Move { Name = "Solar Beam", At = 53 }, new Move { Name = "Night Slash", At = 57 }, new Move { Name = "Sheer Cold", At = 61 }, },
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Shelmet",
                    moves = { new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Acid", At = 4 }, new Move { Name = "Bide", At = 8 }, new Move { Name = "Curse", At = 13 }, new Move { Name = "Struggle Bug", At = 16 }, new Move { Name = "Mega Drain", At = 20 }, new Move { Name = "Yawn", At = 25 }, new Move { Name = "Protect", At = 28 }, new Move { Name = "Acid Armor", At = 32 }, new Move { Name = "Giga Drain", At = 37 }, new Move { Name = "Body Slam", At = 40 }, new Move { Name = "Bug Buzz", At = 44 }, new Move { Name = "Recover", At = 49 }, new Move { Name = "Guard Swap", At = 50 }, new Move { Name = "Final Gambit", At = 56 }, },
                    eggMoves = { "Endure", "Baton Pass", "Double-Edge", "Encore", "Guard Split", "Mind Reader", "Mud-Slap", "Spikes", "Feint", "Pursuit", },
                },

                new Species() {
                    Name = "Accelgor",
                    moves = { new Move { Name = "Water Shuriken", At = 1 }, new Move { Name = "Final Gambit", At = 1 }, new Move { Name = "Power Swap", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Acid Spray", At = 1 }, new Move { Name = "Double Team", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Acid Spray", At = 4 }, new Move { Name = "Double Team", At = 8 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Struggle Bug", At = 16 }, new Move { Name = "Mega Drain", At = 20 }, new Move { Name = "Swift", At = 25 }, new Move { Name = "Me First", At = 28 }, new Move { Name = "Agility", At = 32 }, new Move { Name = "Giga Drain", At = 37 }, new Move { Name = "U-turn", At = 40 }, new Move { Name = "Bug Buzz", At = 44 }, new Move { Name = "Recover", At = 49 }, new Move { Name = "Power Swap", At = 52 }, new Move { Name = "Final Gambit", At = 56 }, },
                },

                new Species() {
                    Name = "Stunfisk",
                    moves = { new Move { Name = "Fissure", At = 1 }, new Move { Name = "Flail", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 1 }, new Move { Name = "Bide", At = 5 }, new Move { Name = "Thunder Shock", At = 9 }, new Move { Name = "Mud Shot", At = 13 }, new Move { Name = "Camouflage", At = 17 }, new Move { Name = "Mud Bomb", At = 21 }, new Move { Name = "Discharge", At = 25 }, new Move { Name = "Endure", At = 30 }, new Move { Name = "Bounce", At = 35 }, new Move { Name = "Muddy Water", At = 40 }, new Move { Name = "Thunderbolt", At = 45 }, new Move { Name = "Revenge", At = 50 }, new Move { Name = "Flail", At = 55 }, new Move { Name = "Fissure", At = 61 }, },
                    eggMoves = { "Shock Wave", "Earth Power", "Yawn", "Sleep Talk", "Astonish", "Curse", "Spite", "Spark", "Pain Split", "Eerie Impulse", "Reflect Type", "Me First", },
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Mienfoo",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Meditate", At = 5 }, new Move { Name = "Detect", At = 9 }, new Move { Name = "Fake Out", At = 13 }, new Move { Name = "Double Slap", At = 17 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Calm Mind", At = 25 }, new Move { Name = "Force Palm", At = 29 }, new Move { Name = "Drain Punch", At = 33 }, new Move { Name = "Jump Kick", At = 37 }, new Move { Name = "U-turn", At = 41 }, new Move { Name = "Quick Guard", At = 45 }, new Move { Name = "Bounce", At = 49 }, new Move { Name = "High Jump Kick", At = 50 }, new Move { Name = "Reversal", At = 57 }, new Move { Name = "Aura Sphere", At = 61 }, },
                    eggMoves = { "Endure", "Vital Throw", "Baton Pass", "Smelling Salts", "Low Kick", "Feint", "Me First", "Knock Off", "Ally Switch", },
                    FS = true,
                },

                new Species() {
                    Name = "Mienshao",
                    moves = { new Move { Name = "Aura Sphere", At = 1 }, new Move { Name = "Reversal", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Meditate", At = 1 }, new Move { Name = "Detect", At = 1 }, new Move { Name = "Fake Out", At = 1 }, new Move { Name = "Meditate", At = 5 }, new Move { Name = "Detect", At = 9 }, new Move { Name = "Fake Out", At = 13 }, new Move { Name = "Double Slap", At = 17 }, new Move { Name = "Swift", At = 21 }, new Move { Name = "Calm Mind", At = 25 }, new Move { Name = "Force Palm", At = 29 }, new Move { Name = "Drain Punch", At = 33 }, new Move { Name = "Jump Kick", At = 37 }, new Move { Name = "U-turn", At = 41 }, new Move { Name = "Wide Guard", At = 45 }, new Move { Name = "Bounce", At = 49 }, new Move { Name = "High Jump Kick", At = 56 }, new Move { Name = "Reversal", At = 63 }, new Move { Name = "Aura Sphere", At = 70 }, },
                },

                new Species() {
                    Name = "Druddigon",
                    moves = { new Move { Name = "Leer", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Hone Claws", At = 5 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Scary Face", At = 13 }, new Move { Name = "Dragon Rage", At = 18 }, new Move { Name = "Slash", At = 21 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Dragon Claw", At = 27 }, new Move { Name = "Chip Away", At = 31 }, new Move { Name = "Revenge", At = 35 }, new Move { Name = "Night Slash", At = 40 }, new Move { Name = "Dragon Tail", At = 45 }, new Move { Name = "Rock Climb", At = 49 }, new Move { Name = "Superpower", At = 55 }, new Move { Name = "Outrage", At = 62 }, },
                    eggMoves = { "Fire Fang", "Thunder Fang", "Crush Claw", "Feint Attack", "Pursuit", "Iron Tail", "Poison Tail", "Snatch", "Metal Claw", "Glare", "Sucker Punch", },
                    eggRand = 5,
                    FS = true,
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Golett",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Mud-Slap", At = 5 }, new Move { Name = "Rollout", At = 9 }, new Move { Name = "Shadow Punch", At = 13 }, new Move { Name = "Iron Defense", At = 17 }, new Move { Name = "Mega Punch", At = 21 }, new Move { Name = "Magnitude", At = 25 }, new Move { Name = "Dynamic Punch", At = 30 }, new Move { Name = "Night Shade", At = 35 }, new Move { Name = "Curse", At = 40 }, new Move { Name = "Earthquake", At = 45 }, new Move { Name = "Hammer Arm", At = 50 }, new Move { Name = "Focus Punch", At = 55 }, },
                    item5 = "Light Clay",
                },

                new Species() {
                    Name = "Golurk",
                    moves = { new Move { Name = "Phantom Force", At = 1 }, new Move { Name = "Focus Punch", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Defense Curl", At = 1 }, new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud-Slap", At = 5 }, new Move { Name = "Rollout", At = 9 }, new Move { Name = "Shadow Punch", At = 13 }, new Move { Name = "Iron Defense", At = 17 }, new Move { Name = "Mega Punch", At = 21 }, new Move { Name = "Magnitude", At = 25 }, new Move { Name = "Dynamic Punch", At = 30 }, new Move { Name = "Night Shade", At = 35 }, new Move { Name = "Curse", At = 40 }, new Move { Name = "Heavy Slam", At = 43 }, new Move { Name = "Earthquake", At = 50 }, new Move { Name = "Hammer Arm", At = 60 }, new Move { Name = "Focus Punch", At = 70 }, new Move { Name = "Phantom Force", At = 75 }, },
                    FS = true,
                    item5 = "Light Clay",
                },

                new Species() {
                    Name = "Pawniard",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 6 }, new Move { Name = "Fury Cutter", At = 9 }, new Move { Name = "Torment", At = 14 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Scary Face", At = 22 }, new Move { Name = "Metal Claw", At = 25 }, new Move { Name = "Slash", At = 30 }, new Move { Name = "Assurance", At = 33 }, new Move { Name = "Metal Sound", At = 38 }, new Move { Name = "Embargo", At = 41 }, new Move { Name = "Iron Defense", At = 46 }, new Move { Name = "Night Slash", At = 49 }, new Move { Name = "Iron Head", At = 54 }, new Move { Name = "Swords Dance", At = 57 }, new Move { Name = "Guillotine", At = 62 }, },
                    eggMoves = { "Revenge", "Sucker Punch", "Pursuit", "Headbutt", "Stealth Rock", "Psycho Cut", "Mean Look", "Quick Guard", },
                    FS = true,
                },

                new Species() {
                    Name = "Bisharp",
                    moves = { new Move { Name = "Guillotine", At = 1 }, new Move { Name = "Iron Head", At = 1 }, new Move { Name = "Metal Burst", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Cutter", At = 1 }, new Move { Name = "Torment", At = 1 }, new Move { Name = "Leer", At = 6 }, new Move { Name = "Fury Cutter", At = 9 }, new Move { Name = "Torment", At = 14 }, new Move { Name = "Feint Attack", At = 17 }, new Move { Name = "Scary Face", At = 22 }, new Move { Name = "Metal Claw", At = 25 }, new Move { Name = "Slash", At = 30 }, new Move { Name = "Assurance", At = 33 }, new Move { Name = "Metal Sound", At = 38 }, new Move { Name = "Embargo", At = 41 }, new Move { Name = "Iron Defense", At = 46 }, new Move { Name = "Night Slash", At = 49 }, new Move { Name = "Iron Head", At = 57 }, new Move { Name = "Swords Dance", At = 63 }, new Move { Name = "Guillotine", At = 71 }, },
                },

                new Species() {
                    Name = "Bouffalant",
                    moves = { new Move { Name = "Pursuit", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Rage", At = 6 }, new Move { Name = "Fury Attack", At = 11 }, new Move { Name = "Horn Attack", At = 16 }, new Move { Name = "Scary Face", At = 21 }, new Move { Name = "Revenge", At = 26 }, new Move { Name = "Head Charge", At = 31 }, new Move { Name = "Focus Energy", At = 36 }, new Move { Name = "Megahorn", At = 41 }, new Move { Name = "Reversal", At = 46 }, new Move { Name = "Thrash", At = 50 }, new Move { Name = "Swords Dance", At = 56 }, new Move { Name = "Giga Impact", At = 61 }, },
                    eggMoves = { "Stomp", "Rock Climb", "Headbutt", "Skull Bash", "Mud Shot", "Mud-Slap", "Iron Head", "Amnesia", "Belch", },
                },

                new Species() {
                    Name = "Rufflet",
                    moves = { new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Wing Attack", At = 10 }, new Move { Name = "Hone Claws", At = 14 }, new Move { Name = "Scary Face", At = 19 }, new Move { Name = "Aerial Ace", At = 23 }, new Move { Name = "Slash", At = 28 }, new Move { Name = "Defog", At = 32 }, new Move { Name = "Tailwind", At = 37 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Crush Claw", At = 46 }, new Move { Name = "Sky Drop", At = 50 }, new Move { Name = "Whirlwind", At = 55 }, new Move { Name = "Brave Bird", At = 59 }, new Move { Name = "Thrash", At = 64 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Braviary",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Brave Bird", At = 1 }, new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Superpower", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Wing Attack", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Wing Attack", At = 10 }, new Move { Name = "Hone Claws", At = 14 }, new Move { Name = "Scary Face", At = 19 }, new Move { Name = "Aerial Ace", At = 23 }, new Move { Name = "Slash", At = 28 }, new Move { Name = "Defog", At = 32 }, new Move { Name = "Tailwind", At = 37 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Crush Claw", At = 46 }, new Move { Name = "Sky Drop", At = 50 }, new Move { Name = "Superpower", At = 51 }, new Move { Name = "Whirlwind", At = 57 }, new Move { Name = "Brave Bird", At = 63 }, new Move { Name = "Thrash", At = 70 }, },
                },

                new Species() {
                    Name = "Vullaby",
                    moves = { new Move { Name = "Gust", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Pluck", At = 10 }, new Move { Name = "Nasty Plot", At = 14 }, new Move { Name = "Flatter", At = 19 }, new Move { Name = "Feint Attack", At = 23 }, new Move { Name = "Punishment", At = 28 }, new Move { Name = "Defog", At = 32 }, new Move { Name = "Tailwind", At = 37 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Dark Pulse", At = 46 }, new Move { Name = "Embargo", At = 50 }, new Move { Name = "Whirlwind", At = 55 }, new Move { Name = "Brave Bird", At = 59 }, new Move { Name = "Mirror Move", At = 64 }, },
                    eggMoves = { "Steel Wing", "Mean Look", "Roost", "Scary Face", "Knock Off", "Fake Tears", "Foul Play", },
                    FS = true,
                },

                new Species() {
                    Name = "Mandibuzz",
                    moves = { new Move { Name = "Mirror Move", At = 1 }, new Move { Name = "Brave Bird", At = 1 }, new Move { Name = "Whirlwind", At = 1 }, new Move { Name = "Bone Rush", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Fury Attack", At = 1 }, new Move { Name = "Pluck", At = 1 }, new Move { Name = "Fury Attack", At = 5 }, new Move { Name = "Pluck", At = 10 }, new Move { Name = "Nasty Plot", At = 14 }, new Move { Name = "Flatter", At = 19 }, new Move { Name = "Feint Attack", At = 23 }, new Move { Name = "Punishment", At = 28 }, new Move { Name = "Defog", At = 32 }, new Move { Name = "Tailwind", At = 37 }, new Move { Name = "Air Slash", At = 41 }, new Move { Name = "Dark Pulse", At = 46 }, new Move { Name = "Embargo", At = 50 }, new Move { Name = "Bone Rush", At = 51 }, new Move { Name = "Whirlwind", At = 57 }, new Move { Name = "Brave Bird", At = 63 }, new Move { Name = "Mirror Move", At = 70 }, },
                },

                new Species() {
                    Name = "Heatmor",
                    moves = { new Move { Name = "Inferno", At = 1 }, new Move { Name = "Hone Claws", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Incinerate", At = 1 }, new Move { Name = "Lick", At = 1 }, new Move { Name = "Odor Sleuth", At = 6 }, new Move { Name = "Bind", At = 11 }, new Move { Name = "Fire Spin", At = 16 }, new Move { Name = "Fury Swipes", At = 21 }, new Move { Name = "Snatch", At = 26 }, new Move { Name = "Flame Burst", At = 31 }, new Move { Name = "Bug Bite", At = 36 }, new Move { Name = "Slash", At = 41 }, new Move { Name = "Amnesia", At = 44 }, new Move { Name = "Flamethrower", At = 47 }, new Move { Name = "Stockpile", At = 50 }, new Move { Name = "Spit Up", At = 50 }, new Move { Name = "Swallow", At = 50 }, new Move { Name = "Inferno", At = 61 }, },
                    eggMoves = { "Pursuit", "Wrap", "Night Slash", "Curse", "Body Slam", "Heat Wave", "Feint Attack", "Sucker Punch", "Tickle", "Sleep Talk", "Belch", },
                },

                new Species() {
                    Name = "Durant",
                    moves = { new Move { Name = "Guillotine", At = 1 }, new Move { Name = "Iron Defense", At = 1 }, new Move { Name = "Metal Sound", At = 1 }, new Move { Name = "Vice Grip", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Fury Cutter", At = 6 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Agility", At = 16 }, new Move { Name = "Metal Claw", At = 21 }, new Move { Name = "Bug Bite", At = 26 }, new Move { Name = "Crunch", At = 31 }, new Move { Name = "Iron Head", At = 36 }, new Move { Name = "Dig", At = 41 }, new Move { Name = "Entrainment", At = 46 }, new Move { Name = "X-Scissor", At = 51 }, new Move { Name = "Iron Defense", At = 56 }, new Move { Name = "Guillotine", At = 61 }, new Move { Name = "Metal Sound", At = 66 }, },
                    eggMoves = { "Screech", "Endure", "Rock Climb", "Baton Pass", "Thunder Fang", "Feint Attack", },
                },

                new Species() {
                    Name = "Deino",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Dragon Breath", At = 17 }, new Move { Name = "Roar", At = 20 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Dragon Pulse", At = 32 }, new Move { Name = "Work Up", At = 38 }, new Move { Name = "Dragon Rush", At = 42 }, new Move { Name = "Body Slam", At = 48 }, new Move { Name = "Scary Face", At = 50 }, new Move { Name = "Hyper Voice", At = 58 }, new Move { Name = "Outrage", At = 62 }, },
                    eggMoves = { "Fire Fang", "Thunder Fang", "Ice Fang", "Double Hit", "Astonish", "Earth Power", "Screech", "Head Smash", "Assurance", "Dark Pulse", },
                    eggRand = 5,
                },

                new Species() {
                    Name = "Zweilous",
                    moves = { new Move { Name = "Double Hit", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Dragon Breath", At = 17 }, new Move { Name = "Roar", At = 20 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Dragon Pulse", At = 32 }, new Move { Name = "Work Up", At = 38 }, new Move { Name = "Dragon Rush", At = 42 }, new Move { Name = "Body Slam", At = 48 }, new Move { Name = "Scary Face", At = 55 }, new Move { Name = "Hyper Voice", At = 64 }, new Move { Name = "Outrage", At = 71 }, },
                },

                new Species() {
                    Name = "Hydreigon",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Hyper Voice", At = 1 }, new Move { Name = "Tri Attack", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Focus Energy", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Focus Energy", At = 4 }, new Move { Name = "Bite", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Dragon Breath", At = 17 }, new Move { Name = "Roar", At = 20 }, new Move { Name = "Crunch", At = 25 }, new Move { Name = "Slam", At = 28 }, new Move { Name = "Dragon Pulse", At = 32 }, new Move { Name = "Work Up", At = 38 }, new Move { Name = "Dragon Rush", At = 42 }, new Move { Name = "Body Slam", At = 48 }, new Move { Name = "Scary Face", At = 55 }, new Move { Name = "Hyper Voice", At = 68 }, new Move { Name = "Outrage", At = 79 }, },
                },

                new Species() {
                    Name = "Larvesta",
                    moves = { new Move { Name = "Ember", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Leech Life", At = 10 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Flame Charge", At = 30 }, new Move { Name = "Bug Bite", At = 40 }, new Move { Name = "Double-Edge", At = 50 }, new Move { Name = "Flame Wheel", At = 60 }, new Move { Name = "Bug Buzz", At = 70 }, new Move { Name = "Amnesia", At = 80 }, new Move { Name = "Thrash", At = 90 }, new Move { Name = "Flare Blitz", At = 100 }, },
                    eggMoves = { "String Shot", "Harden", "Foresight", "Endure", "Zen Headbutt", "Morning Sun", "Magnet Rise", },
                    FS = true,
                },

                new Species() {
                    Name = "Volcarona",
                    moves = { new Move { Name = "Fiery Dance", At = 1 }, new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Rage Powder", At = 1 }, new Move { Name = "Heat Wave", At = 1 }, new Move { Name = "Quiver Dance", At = 1 }, new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Thrash", At = 1 }, new Move { Name = "Amnesia", At = 1 }, new Move { Name = "Bug Buzz", At = 1 }, new Move { Name = "Flame Wheel", At = 1 }, new Move { Name = "Ember", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Leech Life", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Leech Life", At = 10 }, new Move { Name = "Gust", At = 20 }, new Move { Name = "Fire Spin", At = 30 }, new Move { Name = "Whirlwind", At = 40 }, new Move { Name = "Silver Wind", At = 50 }, new Move { Name = "Quiver Dance", At = 59 }, new Move { Name = "Heat Wave", At = 60 }, new Move { Name = "Bug Buzz", At = 70 }, new Move { Name = "Rage Powder", At = 80 }, new Move { Name = "Hurricane", At = 90 }, new Move { Name = "Fiery Dance", At = 100 }, },
                    item100 = "Silver Powder",
                },

                new Species() {
                    Name = "Cobalion",
                    moves = { new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Metal Burst", At = 1 }, new Move { Name = "Work Up", At = 1 }, new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Kick", At = 7 }, new Move { Name = "Metal Claw", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Retaliate", At = 31 }, new Move { Name = "Iron Head", At = 37 }, new Move { Name = "Sacred Sword", At = 42 }, new Move { Name = "Swords Dance", At = 49 }, new Move { Name = "Quick Guard", At = 55 }, new Move { Name = "Work Up", At = 61 }, new Move { Name = "Metal Burst", At = 67 }, new Move { Name = "Close Combat", At = 73 }, },
                },

                new Species() {
                    Name = "Terrakion",
                    moves = { new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Work Up", At = 1 }, new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Kick", At = 7 }, new Move { Name = "Smack Down", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Retaliate", At = 31 }, new Move { Name = "Rock Slide", At = 37 }, new Move { Name = "Sacred Sword", At = 42 }, new Move { Name = "Swords Dance", At = 49 }, new Move { Name = "Quick Guard", At = 55 }, new Move { Name = "Work Up", At = 61 }, new Move { Name = "Stone Edge", At = 67 }, new Move { Name = "Close Combat", At = 73 }, },
                },

                new Species() {
                    Name = "Virizion",
                    moves = { new Move { Name = "Close Combat", At = 1 }, new Move { Name = "Leaf Blade", At = 1 }, new Move { Name = "Work Up", At = 1 }, new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Kick", At = 7 }, new Move { Name = "Magical Leaf", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Retaliate", At = 31 }, new Move { Name = "Giga Drain", At = 37 }, new Move { Name = "Sacred Sword", At = 42 }, new Move { Name = "Swords Dance", At = 49 }, new Move { Name = "Quick Guard", At = 55 }, new Move { Name = "Work Up", At = 61 }, new Move { Name = "Leaf Blade", At = 67 }, new Move { Name = "Close Combat", At = 73 }, },
                },

                new Species() {
                    Name = "Tornadus",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Tailwind", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Swagger", At = 7 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Revenge", At = 19 }, new Move { Name = "Air Cutter", At = 25 }, new Move { Name = "Extrasensory", At = 31 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Air Slash", At = 43 }, new Move { Name = "Crunch", At = 49 }, new Move { Name = "Tailwind", At = 55 }, new Move { Name = "Rain Dance", At = 61 }, new Move { Name = "Hurricane", At = 67 }, new Move { Name = "Dark Pulse", At = 73 }, new Move { Name = "Hammer Arm", At = 79 }, new Move { Name = "Thrash", At = 85 }, },
                },

                new Species() {
                    Name = "Thundurus",
                    moves = { new Move { Name = "Thrash", At = 1 }, new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Nasty Plot", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Uproar", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Thunder Shock", At = 1 }, new Move { Name = "Swagger", At = 7 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Revenge", At = 19 }, new Move { Name = "Shock Wave", At = 25 }, new Move { Name = "Heal Block", At = 31 }, new Move { Name = "Agility", At = 37 }, new Move { Name = "Discharge", At = 43 }, new Move { Name = "Crunch", At = 49 }, new Move { Name = "Charge", At = 55 }, new Move { Name = "Nasty Plot", At = 61 }, new Move { Name = "Thunder", At = 67 }, new Move { Name = "Dark Pulse", At = 73 }, new Move { Name = "Hammer Arm", At = 79 }, new Move { Name = "Thrash", At = 85 }, },
                },

                new Species() {
                    Name = "Reshiram",
                    moves = { new Move { Name = "Fire Fang", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Imprison", At = 8 }, new Move { Name = "Ancient Power", At = 15 }, new Move { Name = "Flamethrower", At = 22 }, new Move { Name = "Dragon Breath", At = 29 }, new Move { Name = "Slash", At = 36 }, new Move { Name = "Extrasensory", At = 43 }, new Move { Name = "Fusion Flare", At = 50 }, new Move { Name = "Dragon Pulse", At = 54 }, new Move { Name = "Imprison", At = 64 }, new Move { Name = "Crunch", At = 71 }, new Move { Name = "Fire Blast", At = 78 }, new Move { Name = "Outrage", At = 85 }, new Move { Name = "Hyper Voice", At = 92 }, new Move { Name = "Blue Flare", At = 100 }, },
                },

                new Species() {
                    Name = "Zekrom",
                    moves = { new Move { Name = "Thunder Fang", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Imprison", At = 8 }, new Move { Name = "Ancient Power", At = 15 }, new Move { Name = "Thunderbolt", At = 22 }, new Move { Name = "Dragon Breath", At = 29 }, new Move { Name = "Slash", At = 36 }, new Move { Name = "Zen Headbutt", At = 43 }, new Move { Name = "Fusion Bolt", At = 50 }, new Move { Name = "Dragon Claw", At = 54 }, new Move { Name = "Imprison", At = 64 }, new Move { Name = "Crunch", At = 71 }, new Move { Name = "Thunder", At = 78 }, new Move { Name = "Outrage", At = 85 }, new Move { Name = "Hyper Voice", At = 92 }, new Move { Name = "Bolt Strike", At = 100 }, },
                },

                new Species() {
                    Name = "Landorus",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Fissure", At = 1 }, new Move { Name = "Block", At = 1 }, new Move { Name = "Mud Shot", At = 1 }, new Move { Name = "Rock Tomb", At = 1 }, new Move { Name = "Imprison", At = 7 }, new Move { Name = "Punishment", At = 13 }, new Move { Name = "Bulldoze", At = 19 }, new Move { Name = "Rock Throw", At = 25 }, new Move { Name = "Extrasensory", At = 31 }, new Move { Name = "Swords Dance", At = 37 }, new Move { Name = "Earth Power", At = 43 }, new Move { Name = "Rock Slide", At = 49 }, new Move { Name = "Earthquake", At = 55 }, new Move { Name = "Sandstorm", At = 61 }, new Move { Name = "Fissure", At = 67 }, new Move { Name = "Stone Edge", At = 73 }, new Move { Name = "Hammer Arm", At = 79 }, new Move { Name = "Outrage", At = 85 }, },
                },

                new Species() {
                    Name = "Kyurem",
                    moves = { new Move { Name = "Icy Wind", At = 1 }, new Move { Name = "Dragon Rage", At = 1 }, new Move { Name = "Imprison", At = 8 }, new Move { Name = "Ancient Power", At = 15 }, new Move { Name = "Ice Beam", At = 22 }, new Move { Name = "Dragon Breath", At = 29 }, new Move { Name = "Slash", At = 36 }, new Move { Name = "Scary Face", At = 43 }, new Move { Name = "Glaciate", At = 50 }, new Move { Name = "Dragon Pulse", At = 57 }, new Move { Name = "Imprison", At = 64 }, new Move { Name = "Endeavor", At = 71 }, new Move { Name = "Blizzard", At = 78 }, new Move { Name = "Outrage", At = 85 }, new Move { Name = "Hyper Voice", At = 92 }, },
                },

                new Species() {
                    Name = "Keldeo",
                    moves = { new Move { Name = "Aqua Jet", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Double Kick", At = 7 }, new Move { Name = "Bubble Beam", At = 13 }, new Move { Name = "Take Down", At = 19 }, new Move { Name = "Helping Hand", At = 25 }, new Move { Name = "Retaliate", At = 31 }, new Move { Name = "Aqua Tail", At = 37 }, new Move { Name = "Sacred Sword", At = 43 }, new Move { Name = "Swords Dance", At = 49 }, new Move { Name = "Quick Guard", At = 55 }, new Move { Name = "Work Up", At = 61 }, new Move { Name = "Hydro Pump", At = 67 }, new Move { Name = "Close Combat", At = 73 }, },
                },

                new Species() {
                    Name = "Meloetta",
                    moves = { new Move { Name = "Round", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Confusion", At = 11 }, new Move { Name = "Sing", At = 16 }, new Move { Name = "Teeter Dance", At = 21 }, new Move { Name = "Acrobatics", At = 26 }, new Move { Name = "Psybeam", At = 31 }, new Move { Name = "Echoed Voice", At = 36 }, new Move { Name = "U-turn", At = 43 }, new Move { Name = "Wake-Up Slap", At = 50 }, new Move { Name = "Psychic", At = 57 }, new Move { Name = "Hyper Voice", At = 64 }, new Move { Name = "Role Play", At = 71 }, new Move { Name = "Close Combat", At = 78 }, new Move { Name = "Perish Song", At = 85 }, },
                    item100 = "Star Piece",
                },

                new Species() {
                    Name = "Genesect",
                    moves = { new Move { Name = "Fell Stinger", At = 1 }, new Move { Name = "Techno Blast", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Magnet Rise", At = 1 }, new Move { Name = "Metal Claw", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Fury Cutter", At = 7 }, new Move { Name = "Lock-On", At = 11 }, new Move { Name = "Flame Charge", At = 18 }, new Move { Name = "Magnet Bomb", At = 22 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Metal Sound", At = 33 }, new Move { Name = "Signal Beam", At = 40 }, new Move { Name = "Tri Attack", At = 44 }, new Move { Name = "X-Scissor", At = 51 }, new Move { Name = "Bug Buzz", At = 55 }, new Move { Name = "Simple Beam", At = 62 }, new Move { Name = "Zap Cannon", At = 66 }, new Move { Name = "Hyper Beam", At = 73 }, new Move { Name = "Self-Destruct", At = 77 }, },
                },

                new Species() {
                    Name = "Chespin",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Vine Whip", At = 5 }, new Move { Name = "Rollout", At = 8 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Leech Seed", At = 15 }, new Move { Name = "Pin Missile", At = 18 }, new Move { Name = "Take Down", At = 27 }, new Move { Name = "Seed Bomb", At = 32 }, new Move { Name = "Mud Shot", At = 35 }, new Move { Name = "Bulk Up", At = 39 }, new Move { Name = "Body Slam", At = 42 }, new Move { Name = "Pain Split", At = 45 }, new Move { Name = "Wood Hammer", At = 48 }, },
                    eggMoves = { "Synthesis", "Belly Drum", "Curse", "Quick Guard", "Spikes", "Defense Curl", "Rollout", },
                },

                new Species() {
                    Name = "Quilladin",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Vine Whip", At = 5 }, new Move { Name = "Rollout", At = 8 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Leech Seed", At = 15 }, new Move { Name = "Pin Missile", At = 20 }, new Move { Name = "Needle Arm", At = 26 }, new Move { Name = "Take Down", At = 30 }, new Move { Name = "Seed Bomb", At = 35 }, new Move { Name = "Mud Shot", At = 39 }, new Move { Name = "Bulk Up", At = 44 }, new Move { Name = "Body Slam", At = 48 }, new Move { Name = "Pain Split", At = 52 }, new Move { Name = "Wood Hammer", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Chesnaught",
                    moves = { new Move { Name = "Feint", At = 1 }, new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Belly Drum", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Vine Whip", At = 5 }, new Move { Name = "Rollout", At = 8 }, new Move { Name = "Bite", At = 11 }, new Move { Name = "Leech Seed", At = 15 }, new Move { Name = "Pin Missile", At = 20 }, new Move { Name = "Needle Arm", At = 26 }, new Move { Name = "Take Down", At = 30 }, new Move { Name = "Seed Bomb", At = 35 }, new Move { Name = "Spiky Shield", At = 36 }, new Move { Name = "Mud Shot", At = 41 }, new Move { Name = "Bulk Up", At = 44 }, new Move { Name = "Body Slam", At = 48 }, new Move { Name = "Pain Split", At = 52 }, new Move { Name = "Wood Hammer", At = 55 }, new Move { Name = "Hammer Arm", At = 60 }, new Move { Name = "Giga Impact", At = 70 }, new Move { Name = "Spiky Shield", At = 75 }, },
                },

                new Species() {
                    Name = "Fennekin",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Flame Charge", At = 14 }, new Move { Name = "Psybeam", At = 17 }, new Move { Name = "Fire Spin", At = 20 }, new Move { Name = "Lucky Chant", At = 25 }, new Move { Name = "Light Screen", At = 27 }, new Move { Name = "Psyshock", At = 31 }, new Move { Name = "Flamethrower", At = 35 }, new Move { Name = "Will-O-Wisp", At = 38 }, new Move { Name = "Psychic", At = 41 }, new Move { Name = "Sunny Day", At = 43 }, new Move { Name = "Magic Room", At = 46 }, new Move { Name = "Fire Blast", At = 48 }, },
                    eggMoves = { "Wish", "Hypnosis", "Heat Wave", "Magic Coat", },
                },

                new Species() {
                    Name = "Braixen",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Flame Charge", At = 14 }, new Move { Name = "Psybeam", At = 18 }, new Move { Name = "Fire Spin", At = 22 }, new Move { Name = "Lucky Chant", At = 27 }, new Move { Name = "Light Screen", At = 30 }, new Move { Name = "Psyshock", At = 34 }, new Move { Name = "Flamethrower", At = 41 }, new Move { Name = "Will-O-Wisp", At = 45 }, new Move { Name = "Psychic", At = 48 }, new Move { Name = "Sunny Day", At = 51 }, new Move { Name = "Magic Room", At = 53 }, new Move { Name = "Fire Blast", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Delphox",
                    moves = { new Move { Name = "Future Sight", At = 1 }, new Move { Name = "Role Play", At = 1 }, new Move { Name = "Switcheroo", At = 1 }, new Move { Name = "Shadow Ball", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Howl", At = 11 }, new Move { Name = "Flame Charge", At = 14 }, new Move { Name = "Psybeam", At = 18 }, new Move { Name = "Fire Spin", At = 22 }, new Move { Name = "Lucky Chant", At = 27 }, new Move { Name = "Light Screen", At = 30 }, new Move { Name = "Psyshock", At = 34 }, new Move { Name = "Mystical Fire", At = 36 }, new Move { Name = "Flamethrower", At = 42 }, new Move { Name = "Will-O-Wisp", At = 47 }, new Move { Name = "Psychic", At = 51 }, new Move { Name = "Sunny Day", At = 55 }, new Move { Name = "Magic Room", At = 58 }, new Move { Name = "Fire Blast", At = 61 }, new Move { Name = "Future Sight", At = 69 }, new Move { Name = "Mystical Fire", At = 75 }, },
                },

                new Species() {
                    Name = "Froakie",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bubble", At = 5 }, new Move { Name = "Quick Attack", At = 8 }, new Move { Name = "Lick", At = 10 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Smokescreen", At = 18 }, new Move { Name = "Round", At = 21 }, new Move { Name = "Fling", At = 25 }, new Move { Name = "Smack Down", At = 29 }, new Move { Name = "Substitute", At = 35 }, new Move { Name = "Bounce", At = 39 }, new Move { Name = "Double Team", At = 43 }, new Move { Name = "Hydro Pump", At = 48 }, },
                    eggMoves = { "Bestow", "Mind Reader", "Toxic Spikes", "Mud Sport", "Camouflage", "Water Sport", },
                },

                new Species() {
                    Name = "Frogadier",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bubble", At = 5 }, new Move { Name = "Quick Attack", At = 8 }, new Move { Name = "Lick", At = 10 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Smokescreen", At = 20 }, new Move { Name = "Round", At = 23 }, new Move { Name = "Fling", At = 28 }, new Move { Name = "Smack Down", At = 33 }, new Move { Name = "Substitute", At = 38 }, new Move { Name = "Bounce", At = 44 }, new Move { Name = "Double Team", At = 48 }, new Move { Name = "Hydro Pump", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Greninja",
                    moves = { new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Role Play", At = 1 }, new Move { Name = "Mat Block", At = 1 }, new Move { Name = "Pound", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Bubble", At = 5 }, new Move { Name = "Quick Attack", At = 8 }, new Move { Name = "Lick", At = 10 }, new Move { Name = "Water Pulse", At = 14 }, new Move { Name = "Smokescreen", At = 20 }, new Move { Name = "Shadow Sneak", At = 23 }, new Move { Name = "Spikes", At = 28 }, new Move { Name = "Feint Attack", At = 33 }, new Move { Name = "Water Shuriken", At = 36 }, new Move { Name = "Substitute", At = 43 }, new Move { Name = "Extrasensory", At = 49 }, new Move { Name = "Double Team", At = 52 }, new Move { Name = "Haze", At = 56 }, new Move { Name = "Hydro Pump", At = 60 }, new Move { Name = "Night Slash", At = 70 }, new Move { Name = "Water Shuriken", At = 75 }, },
                },

                new Species() {
                    Name = "Bunnelby",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Agility", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 7 }, new Move { Name = "Double Slap", At = 10 }, new Move { Name = "Mud-Slap", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Mud Shot", At = 18 }, new Move { Name = "Double Kick", At = 20 }, new Move { Name = "Odor Sleuth", At = 25 }, new Move { Name = "Flail", At = 29 }, new Move { Name = "Dig", At = 33 }, new Move { Name = "Bounce", At = 38 }, new Move { Name = "Super Fang", At = 42 }, new Move { Name = "Facade", At = 47 }, new Move { Name = "Earthquake", At = 49 }, },
                    eggMoves = { "Spikes", "Defense Curl", "Rollout", },
                },

                new Species() {
                    Name = "Diggersby",
                    moves = { new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Rototiller", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Swords Dance", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Agility", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Quick Attack", At = 7 }, new Move { Name = "Mud-Slap", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Mud Shot", At = 18 }, new Move { Name = "Double Kick", At = 20 }, new Move { Name = "Odor Sleuth", At = 26 }, new Move { Name = "Flail", At = 31 }, new Move { Name = "Dig", At = 37 }, new Move { Name = "Bounce", At = 42 }, new Move { Name = "Super Fang", At = 48 }, new Move { Name = "Facade", At = 53 }, new Move { Name = "Earthquake", At = 57 }, new Move { Name = "Hammer Arm", At = 60 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Fletchling",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Peck", At = 10 }, new Move { Name = "Agility", At = 13 }, new Move { Name = "Flail", At = 16 }, new Move { Name = "Roost", At = 21 }, new Move { Name = "Razor Wind", At = 25 }, new Move { Name = "Natural Gift", At = 29 }, new Move { Name = "Flame Charge", At = 34 }, new Move { Name = "Acrobatics", At = 39 }, new Move { Name = "Me First", At = 41 }, new Move { Name = "Tailwind", At = 45 }, new Move { Name = "Steel Wing", At = 48 }, },
                    eggMoves = { "Tailwind", "Snatch", "Quick Guard", },
                },

                new Species() {
                    Name = "Fletchinder",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Peck", At = 10 }, new Move { Name = "Agility", At = 13 }, new Move { Name = "Flail", At = 16 }, new Move { Name = "Ember", At = 17 }, new Move { Name = "Roost", At = 25 }, new Move { Name = "Razor Wind", At = 27 }, new Move { Name = "Natural Gift", At = 31 }, new Move { Name = "Flame Charge", At = 38 }, new Move { Name = "Acrobatics", At = 42 }, new Move { Name = "Me First", At = 46 }, new Move { Name = "Tailwind", At = 51 }, new Move { Name = "Steel Wing", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Talonflame",
                    moves = { new Move { Name = "Brave Bird", At = 1 }, new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Quick Attack", At = 6 }, new Move { Name = "Peck", At = 10 }, new Move { Name = "Agility", At = 13 }, new Move { Name = "Flail", At = 16 }, new Move { Name = "Ember", At = 17 }, new Move { Name = "Roost", At = 25 }, new Move { Name = "Razor Wind", At = 27 }, new Move { Name = "Natural Gift", At = 31 }, new Move { Name = "Flame Charge", At = 39 }, new Move { Name = "Acrobatics", At = 44 }, new Move { Name = "Me First", At = 49 }, new Move { Name = "Tailwind", At = 55 }, new Move { Name = "Steel Wing", At = 60 }, new Move { Name = "Brave Bird", At = 64 }, },
                },

                new Species() {
                    Name = "Scatterbug",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "String Shot", At = 1 }, new Move { Name = "Stun Spore", At = 6 }, new Move { Name = "Bug Bite", At = 15 }, },
                    eggMoves = { "Stun Spore", "Poison Powder", "Rage Powder", },
                },

                new Species() {
                    Name = "Spewpa",
                    moves = { new Move { Name = "Harden", At = 1 }, new Move { Name = "Protect", At = 9 }, },
                },

                new Species() {
                    Name = "Vivillon",
                    moves = { new Move { Name = "Powder", At = 1 }, new Move { Name = "Sleep Powder", At = 1 }, new Move { Name = "Poison Powder", At = 1 }, new Move { Name = "Stun Spore", At = 1 }, new Move { Name = "Gust", At = 1 }, new Move { Name = "Light Screen", At = 1 }, new Move { Name = "Struggle Bug", At = 12 }, new Move { Name = "Psybeam", At = 17 }, new Move { Name = "Supersonic", At = 21 }, new Move { Name = "Draining Kiss", At = 25 }, new Move { Name = "Aromatherapy", At = 31 }, new Move { Name = "Bug Buzz", At = 35 }, new Move { Name = "Safeguard", At = 41 }, new Move { Name = "Quiver Dance", At = 45 }, new Move { Name = "Hurricane", At = 50 }, new Move { Name = "Powder", At = 55 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Litleo",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Work Up", At = 8 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Noble Roar", At = 15 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Fire Fang", At = 23 }, new Move { Name = "Endeavor", At = 28 }, new Move { Name = "Echoed Voice", At = 33 }, new Move { Name = "Flamethrower", At = 36 }, new Move { Name = "Crunch", At = 39 }, new Move { Name = "Hyper Voice", At = 43 }, new Move { Name = "Incinerate", At = 46 }, new Move { Name = "Overheat", At = 50 }, },
                    eggMoves = { "Entrainment", "Yawn", "Snatch", "Fire Spin", },
                },

                new Species() {
                    Name = "Pyroar",
                    moves = { new Move { Name = "Hyper Beam", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Ember", At = 5 }, new Move { Name = "Work Up", At = 8 }, new Move { Name = "Headbutt", At = 11 }, new Move { Name = "Noble Roar", At = 15 }, new Move { Name = "Take Down", At = 20 }, new Move { Name = "Fire Fang", At = 23 }, new Move { Name = "Endeavor", At = 28 }, new Move { Name = "Echoed Voice", At = 33 }, new Move { Name = "Flamethrower", At = 38 }, new Move { Name = "Crunch", At = 42 }, new Move { Name = "Hyper Voice", At = 48 }, new Move { Name = "Incinerate", At = 51 }, new Move { Name = "Overheat", At = 57 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Flabébé (Red)",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Fairy Wind", At = 6 }, new Move { Name = "Lucky Chant", At = 10 }, new Move { Name = "Razor Leaf", At = 15 }, new Move { Name = "Wish", At = 20 }, new Move { Name = "Magical Leaf", At = 22 }, new Move { Name = "Grassy Terrain", At = 24 }, new Move { Name = "Petal Blizzard", At = 28 }, new Move { Name = "Aromatherapy", At = 33 }, new Move { Name = "Misty Terrain", At = 37 }, new Move { Name = "Moonblast", At = 41 }, new Move { Name = "Petal Dance", At = 45 }, new Move { Name = "Solar Beam", At = 48 }, },
                    eggMoves = { "Copycat", "Captivate", "Camouflage", },
                },

                new Species() {
                    Name = "Floette (red)",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Vine Whip", At = 1 }, new Move { Name = "Fairy Wind", At = 6 }, new Move { Name = "Lucky Chant", At = 10 }, new Move { Name = "Razor Leaf", At = 15 }, new Move { Name = "Wish", At = 20 }, new Move { Name = "Magical Leaf", At = 25 }, new Move { Name = "Grassy Terrain", At = 27 }, new Move { Name = "Petal Blizzard", At = 33 }, new Move { Name = "Aromatherapy", At = 38 }, new Move { Name = "Misty Terrain", At = 43 }, new Move { Name = "Moonblast", At = 46 }, new Move { Name = "Petal Dance", At = 51 }, new Move { Name = "Solar Beam", At = 58 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Florges",
                    moves = { new Move { Name = "Disarming Voice", At = 1 }, new Move { Name = "Lucky Chant", At = 1 }, new Move { Name = "Wish", At = 1 }, new Move { Name = "Magical Leaf", At = 1 }, new Move { Name = "Flower Shield", At = 1 }, new Move { Name = "Grass Knot", At = 1 }, new Move { Name = "Grassy Terrain", At = 1 }, new Move { Name = "Petal Blizzard", At = 1 }, new Move { Name = "Misty Terrain", At = 1 }, new Move { Name = "Moonblast", At = 1 }, new Move { Name = "Petal Dance", At = 1 }, new Move { Name = "Aromatherapy", At = 1 }, },
                },

                new Species() {
                    Name = "Skiddo",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Tail Whip", At = 9 }, new Move { Name = "Leech Seed", At = 12 }, new Move { Name = "Razor Leaf", At = 13 }, new Move { Name = "Worry Seed", At = 16 }, new Move { Name = "Synthesis", At = 20 }, new Move { Name = "Take Down", At = 22 }, new Move { Name = "Bulldoze", At = 26 }, new Move { Name = "Seed Bomb", At = 30 }, new Move { Name = "Bulk Up", At = 34 }, new Move { Name = "Double-Edge", At = 38 }, new Move { Name = "Horn Leech", At = 42 }, new Move { Name = "Leaf Blade", At = 45 }, new Move { Name = "Milk Drink", At = 50 }, },
                    eggMoves = { "Defense Curl", "Rollout", "Milk Drink", },
                },

                new Species() {
                    Name = "Gogoat",
                    moves = { new Move { Name = "Aerial Ace", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growth", At = 1 }, new Move { Name = "Vine Whip", At = 7 }, new Move { Name = "Tail Whip", At = 9 }, new Move { Name = "Leech Seed", At = 12 }, new Move { Name = "Razor Leaf", At = 13 }, new Move { Name = "Worry Seed", At = 16 }, new Move { Name = "Synthesis", At = 20 }, new Move { Name = "Take Down", At = 22 }, new Move { Name = "Bulldoze", At = 26 }, new Move { Name = "Seed Bomb", At = 30 }, new Move { Name = "Bulk Up", At = 34 }, new Move { Name = "Double-Edge", At = 40 }, new Move { Name = "Horn Leech", At = 47 }, new Move { Name = "Leaf Blade", At = 55 }, new Move { Name = "Milk Drink", At = 58 }, new Move { Name = "Earthquake", At = 60 }, new Move { Name = "Aerial Ace", At = 65 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Pancham",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Arm Thrust", At = 7 }, new Move { Name = "Work Up", At = 10 }, new Move { Name = "Karate Chop", At = 12 }, new Move { Name = "Comet Punch", At = 15 }, new Move { Name = "Slash", At = 20 }, new Move { Name = "Circle Throw", At = 25 }, new Move { Name = "Vital Throw", At = 27 }, new Move { Name = "Body Slam", At = 33 }, new Move { Name = "Crunch", At = 39 }, new Move { Name = "Entrainment", At = 42 }, new Move { Name = "Parting Shot", At = 45 }, new Move { Name = "Sky Uppercut", At = 48 }, },
                    eggMoves = { "Quash", "Me First", "Quick Guard", "Foul Play", "Storm Throw", },
                    FS = true,
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Pangoro",
                    moves = { new Move { Name = "Entrainment", At = 1 }, new Move { Name = "Hammer Arm", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Arm Thrust", At = 7 }, new Move { Name = "Work Up", At = 10 }, new Move { Name = "Karate Chop", At = 12 }, new Move { Name = "Comet Punch", At = 15 }, new Move { Name = "Slash", At = 20 }, new Move { Name = "Circle Throw", At = 25 }, new Move { Name = "Vital Throw", At = 27 }, new Move { Name = "Body Slam", At = 35 }, new Move { Name = "Crunch", At = 42 }, new Move { Name = "Entrainment", At = 45 }, new Move { Name = "Parting Shot", At = 48 }, new Move { Name = "Sky Uppercut", At = 52 }, new Move { Name = "Hammer Arm", At = 57 }, new Move { Name = "Taunt", At = 65 }, new Move { Name = "Low Sweep", At = 70 }, },
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Furfrou",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Baby-Doll Eyes", At = 9 }, new Move { Name = "Headbutt", At = 12 }, new Move { Name = "Tail Whip", At = 15 }, new Move { Name = "Bite", At = 22 }, new Move { Name = "Odor Sleuth", At = 27 }, new Move { Name = "Retaliate", At = 33 }, new Move { Name = "Take Down", At = 35 }, new Move { Name = "Charm", At = 38 }, new Move { Name = "Sucker Punch", At = 42 }, new Move { Name = "Cotton Guard", At = 48 }, },
                    eggMoves = { "Role Play", "Work Up", "Mimic", "Captivate", "Refresh", },
                },

                new Species() {
                    Name = "Espurr",
                    moves = { new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Covet", At = 5 }, new Move { Name = "Confusion", At = 9 }, new Move { Name = "Light Screen", At = 13 }, new Move { Name = "Psybeam", At = 17 }, new Move { Name = "Fake Out", At = 19 }, new Move { Name = "Disarming Voice", At = 22 }, new Move { Name = "Psyshock", At = 25 }, },
                    eggMoves = { "Trick", "Yawn", "Assist", "Barrier", },
                    FS = true,
                },

                new Species() {
                    Name = "Meowstic",
                    moves = { new Move { Name = "Quick Guard", At = 1 }, new Move { Name = "Mean Look", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Leer", At = 1 }, new Move { Name = "Covet", At = 5 }, new Move { Name = "Confusion", At = 9 }, new Move { Name = "Light Screen", At = 13 }, new Move { Name = "Psybeam", At = 17 }, new Move { Name = "Fake Out", At = 19 }, new Move { Name = "Disarming Voice", At = 22 }, new Move { Name = "Psyshock", At = 25 }, new Move { Name = "Charm", At = 28 }, new Move { Name = "Miracle Eye", At = 31 }, new Move { Name = "Reflect", At = 35 }, new Move { Name = "Psychic", At = 40 }, new Move { Name = "Role Play", At = 43 }, new Move { Name = "Imprison", At = 45 }, new Move { Name = "Sucker Punch", At = 48 }, new Move { Name = "Misty Terrain", At = 50 }, new Move { Name = "Quick Guard", At = 53 }, },
                },

                new Species() {
                    Name = "Honedge",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Swords Dance", At = 1 }, new Move { Name = "Fury Cutter", At = 5 }, new Move { Name = "Metal Sound", At = 8 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Autotomize", At = 18 }, new Move { Name = "Shadow Sneak", At = 20 }, new Move { Name = "Aerial Ace", At = 22 }, new Move { Name = "Retaliate", At = 26 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Iron Defense", At = 32 }, new Move { Name = "Night Slash", At = 35 }, new Move { Name = "Power Trick", At = 39 }, new Move { Name = "Iron Head", At = 42 }, new Move { Name = "Sacred Sword", At = 47 }, },
                    eggMoves = { "Metal Sound", "Shadow Sneak", "Destiny Bond", "Wide Guard", },
                },

                new Species() {
                    Name = "Doublade",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Swords Dance", At = 1 }, new Move { Name = "Fury Cutter", At = 5 }, new Move { Name = "Metal Sound", At = 8 }, new Move { Name = "Pursuit", At = 13 }, new Move { Name = "Autotomize", At = 18 }, new Move { Name = "Shadow Sneak", At = 20 }, new Move { Name = "Aerial Ace", At = 22 }, new Move { Name = "Retaliate", At = 26 }, new Move { Name = "Slash", At = 29 }, new Move { Name = "Iron Defense", At = 32 }, new Move { Name = "Night Slash", At = 36 }, new Move { Name = "Power Trick", At = 41 }, new Move { Name = "Iron Head", At = 45 }, new Move { Name = "Sacred Sword", At = 51 }, },
                },

                new Species() {
                    Name = "Aegislash",
                    moves = { new Move { Name = "Fury Cutter", At = 1 }, new Move { Name = "Pursuit", At = 1 }, new Move { Name = "Autotomize", At = 1 }, new Move { Name = "Shadow Sneak", At = 1 }, new Move { Name = "Slash", At = 1 }, new Move { Name = "Iron Defense", At = 1 }, new Move { Name = "Night Slash", At = 1 }, new Move { Name = "Power Trick", At = 1 }, new Move { Name = "Iron Head", At = 1 }, new Move { Name = "Head Smash", At = 1 }, new Move { Name = "Swords Dance", At = 1 }, new Move { Name = "Aerial Ace", At = 1 }, new Move { Name = "King’s Shield", At = 1 }, new Move { Name = "Sacred Sword", At = 1 }, },
                },

                new Species() {
                    Name = "Spritzee",
                    moves = { new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Fairy Wind", At = 1 }, new Move { Name = "Sweet Kiss", At = 6 }, new Move { Name = "Odor Sleuth", At = 8 }, new Move { Name = "Echoed Voice", At = 13 }, new Move { Name = "Calm Mind", At = 17 }, new Move { Name = "Draining Kiss", At = 21 }, new Move { Name = "Aromatherapy", At = 25 }, new Move { Name = "Attract", At = 29 }, new Move { Name = "Moonblast", At = 31 }, new Move { Name = "Charm", At = 35 }, new Move { Name = "Flail", At = 38 }, new Move { Name = "Misty Terrain", At = 42 }, new Move { Name = "Skill Swap", At = 44 }, new Move { Name = "Psychic", At = 48 }, new Move { Name = "Disarming Voice", At = 50 }, },
                    eggMoves = { "Disable", "Wish", "Captivate", "Refresh", },
                    FS = true,
                },

                new Species() {
                    Name = "Aromatisse",
                    moves = { new Move { Name = "Aromatic Mist", At = 1 }, new Move { Name = "Heal Pulse", At = 1 }, new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Fairy Wind", At = 1 }, new Move { Name = "Sweet Kiss", At = 6 }, new Move { Name = "Odor Sleuth", At = 8 }, new Move { Name = "Echoed Voice", At = 13 }, new Move { Name = "Calm Mind", At = 17 }, new Move { Name = "Draining Kiss", At = 21 }, new Move { Name = "Aromatherapy", At = 25 }, new Move { Name = "Attract", At = 29 }, new Move { Name = "Moonblast", At = 31 }, new Move { Name = "Charm", At = 35 }, new Move { Name = "Flail", At = 38 }, new Move { Name = "Misty Terrain", At = 42 }, new Move { Name = "Skill Swap", At = 44 }, new Move { Name = "Psychic", At = 48 }, new Move { Name = "Disarming Voice", At = 53 }, new Move { Name = "Reflect", At = 57 }, new Move { Name = "Psych Up", At = 64 }, },
                },

                new Species() {
                    Name = "Swirlix",
                    moves = { new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Fairy Wind", At = 5 }, new Move { Name = "Play Nice", At = 8 }, new Move { Name = "Fake Tears", At = 10 }, new Move { Name = "Round", At = 13 }, new Move { Name = "Cotton Spore", At = 17 }, new Move { Name = "Endeavor", At = 21 }, new Move { Name = "Aromatherapy", At = 26 }, new Move { Name = "Draining Kiss", At = 31 }, new Move { Name = "Energy Ball", At = 36 }, new Move { Name = "Cotton Guard", At = 41 }, new Move { Name = "Wish", At = 45 }, new Move { Name = "Play Rough", At = 49 }, new Move { Name = "Light Screen", At = 58 }, new Move { Name = "Safeguard", At = 67 }, },
                    eggMoves = { "After You", "Yawn", "Belly Drum", "Copycat", },
                    FS = true,
                },

                new Species() {
                    Name = "Slurpuff",
                    moves = { new Move { Name = "Sweet Scent", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Fairy Wind", At = 5 }, new Move { Name = "Play Nice", At = 8 }, new Move { Name = "Fake Tears", At = 10 }, new Move { Name = "Round", At = 13 }, new Move { Name = "Cotton Spore", At = 17 }, new Move { Name = "Endeavor", At = 21 }, new Move { Name = "Aromatherapy", At = 26 }, new Move { Name = "Draining Kiss", At = 31 }, new Move { Name = "Energy Ball", At = 36 }, new Move { Name = "Cotton Guard", At = 41 }, new Move { Name = "Wish", At = 45 }, new Move { Name = "Play Rough", At = 49 }, new Move { Name = "Light Screen", At = 58 }, new Move { Name = "Safeguard", At = 67 }, },
                },

                new Species() {
                    Name = "Inkay",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Reflect", At = 4 }, new Move { Name = "Foul Play", At = 8 }, new Move { Name = "Swagger", At = 12 }, new Move { Name = "Psywave", At = 13 }, new Move { Name = "Topsy-Turvy", At = 15 }, new Move { Name = "Hypnosis", At = 18 }, new Move { Name = "Psybeam", At = 21 }, new Move { Name = "Switcheroo", At = 23 }, new Move { Name = "Payback", At = 27 }, new Move { Name = "Light Screen", At = 31 }, new Move { Name = "Pluck", At = 35 }, new Move { Name = "Psycho Cut", At = 39 }, new Move { Name = "Slash", At = 43 }, new Move { Name = "Night Slash", At = 46 }, new Move { Name = "Superpower", At = 48 }, },
                    eggMoves = { "Simple Beam", "Power Split", "Camouflage", "Flatter", "Destiny Bond", },
                    FS = true,
                },

                new Species() {
                    Name = "Malamar",
                    moves = { new Move { Name = "Superpower", At = 1 }, new Move { Name = "Reversal", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Peck", At = 1 }, new Move { Name = "Constrict", At = 1 }, new Move { Name = "Reflect", At = 4 }, new Move { Name = "Foul Play", At = 8 }, new Move { Name = "Swagger", At = 12 }, new Move { Name = "Psywave", At = 13 }, new Move { Name = "Topsy-Turvy", At = 15 }, new Move { Name = "Hypnosis", At = 18 }, new Move { Name = "Psybeam", At = 21 }, new Move { Name = "Switcheroo", At = 23 }, new Move { Name = "Payback", At = 27 }, new Move { Name = "Light Screen", At = 31 }, new Move { Name = "Pluck", At = 35 }, new Move { Name = "Psycho Cut", At = 39 }, new Move { Name = "Slash", At = 43 }, new Move { Name = "Night Slash", At = 46 }, new Move { Name = "Superpower", At = 48 }, },
                },

                new Species() {
                    Name = "Binacle",
                    moves = { new Move { Name = "Shell Smash", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Withdraw", At = 7 }, new Move { Name = "Fury Swipes", At = 10 }, new Move { Name = "Slash", At = 13 }, new Move { Name = "Mud-Slap", At = 18 }, new Move { Name = "Clamp", At = 20 }, new Move { Name = "Rock Polish", At = 24 }, new Move { Name = "Ancient Power", At = 28 }, new Move { Name = "Hone Claws", At = 32 }, new Move { Name = "Fury Cutter", At = 37 }, new Move { Name = "Night Slash", At = 41 }, new Move { Name = "Razor Shell", At = 45 }, new Move { Name = "Cross Chop", At = 49 }, },
                    eggMoves = { "Tickle", "Switcheroo", "Helping Hand", "Water Sport", },
                },

                new Species() {
                    Name = "Barbaracle",
                    moves = { new Move { Name = "Stone Edge", At = 1 }, new Move { Name = "Skull Bash", At = 1 }, new Move { Name = "Shell Smash", At = 1 }, new Move { Name = "Scratch", At = 1 }, new Move { Name = "Sand Attack", At = 1 }, new Move { Name = "Water Gun", At = 4 }, new Move { Name = "Withdraw", At = 7 }, new Move { Name = "Fury Swipes", At = 10 }, new Move { Name = "Slash", At = 13 }, new Move { Name = "Mud-Slap", At = 18 }, new Move { Name = "Clamp", At = 20 }, new Move { Name = "Rock Polish", At = 24 }, new Move { Name = "Ancient Power", At = 28 }, new Move { Name = "Hone Claws", At = 32 }, new Move { Name = "Fury Cutter", At = 37 }, new Move { Name = "Night Slash", At = 44 }, new Move { Name = "Razor Shell", At = 48 }, new Move { Name = "Cross Chop", At = 55 }, new Move { Name = "Stone Edge", At = 60 }, new Move { Name = "Skull Bash", At = 65 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Skrelp",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Feint Attack", At = 5 }, new Move { Name = "Tail Whip", At = 9 }, new Move { Name = "Bubble", At = 12 }, new Move { Name = "Acid", At = 15 }, new Move { Name = "Camouflage", At = 19 }, new Move { Name = "Poison Tail", At = 23 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Double Team", At = 28 }, new Move { Name = "Toxic", At = 32 }, new Move { Name = "Aqua Tail", At = 35 }, new Move { Name = "Sludge Bomb", At = 38 }, new Move { Name = "Hydro Pump", At = 42 }, new Move { Name = "Dragon Pulse", At = 49 }, },
                    eggMoves = { "Toxic Spikes", "Play Rough", "Haze", "Acid Armor", "Venom Drench", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Dragalge",
                    moves = { new Move { Name = "Dragon Tail", At = 1 }, new Move { Name = "Twister", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Smokescreen", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Feint Attack", At = 5 }, new Move { Name = "Tail Whip", At = 9 }, new Move { Name = "Bubble", At = 12 }, new Move { Name = "Acid", At = 15 }, new Move { Name = "Camouflage", At = 19 }, new Move { Name = "Poison Tail", At = 23 }, new Move { Name = "Water Pulse", At = 25 }, new Move { Name = "Double Team", At = 28 }, new Move { Name = "Toxic", At = 32 }, new Move { Name = "Aqua Tail", At = 35 }, new Move { Name = "Sludge Bomb", At = 38 }, new Move { Name = "Hydro Pump", At = 42 }, new Move { Name = "Dragon Pulse", At = 53 }, new Move { Name = "Dragon Tail", At = 59 }, new Move { Name = "Twister", At = 67 }, },
                },

                new Species() {
                    Name = "Clauncher",
                    moves = { new Move { Name = "Splash", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Vice Grip", At = 9 }, new Move { Name = "Bubble", At = 12 }, new Move { Name = "Flail", At = 16 }, new Move { Name = "Bubble Beam", At = 20 }, new Move { Name = "Swords Dance", At = 25 }, new Move { Name = "Crabhammer", At = 30 }, new Move { Name = "Water Pulse", At = 34 }, new Move { Name = "Smack Down", At = 39 }, new Move { Name = "Aqua Jet", At = 43 }, new Move { Name = "Muddy Water", At = 48 }, },
                    eggMoves = { "Aqua Jet", "Entrainment", "Endure", "Crabhammer", "Helping Hand", },
                    eggRand = 9,
                },

                new Species() {
                    Name = "Clawitzer",
                    moves = { new Move { Name = "Heal Pulse", At = 1 }, new Move { Name = "Dark Pulse", At = 1 }, new Move { Name = "Dragon Pulse", At = 1 }, new Move { Name = "Aura Sphere", At = 1 }, new Move { Name = "Splash", At = 1 }, new Move { Name = "Water Gun", At = 1 }, new Move { Name = "Water Sport", At = 7 }, new Move { Name = "Vice Grip", At = 9 }, new Move { Name = "Bubble", At = 12 }, new Move { Name = "Flail", At = 16 }, new Move { Name = "Bubble Beam", At = 20 }, new Move { Name = "Swords Dance", At = 25 }, new Move { Name = "Crabhammer", At = 30 }, new Move { Name = "Water Pulse", At = 34 }, new Move { Name = "Smack Down", At = 42 }, new Move { Name = "Aqua Jet", At = 47 }, new Move { Name = "Muddy Water", At = 53 }, new Move { Name = "Dark Pulse", At = 57 }, new Move { Name = "Dragon Pulse", At = 63 }, new Move { Name = "Aura Sphere", At = 67 }, },
                },

                new Species() {
                    Name = "Helioptile",
                    moves = { new Move { Name = "Pound", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Thunder Shock", At = 6 }, new Move { Name = "Charge", At = 11 }, new Move { Name = "Mud-Slap", At = 13 }, new Move { Name = "Quick Attack", At = 17 }, new Move { Name = "Razor Wind", At = 22 }, new Move { Name = "Parabolic Charge", At = 25 }, new Move { Name = "Thunder Wave", At = 31 }, new Move { Name = "Bulldoze", At = 35 }, new Move { Name = "Volt Switch", At = 40 }, new Move { Name = "Electrify", At = 45 }, new Move { Name = "Thunderbolt", At = 49 }, },
                    eggMoves = { "Agility", "Glare", "Camouflage", "Electric Terrain", },
                    FS = true,
                },

                new Species() {
                    Name = "Heliolisk",
                    moves = { new Move { Name = "Eerie Impulse", At = 1 }, new Move { Name = "Electrify", At = 1 }, new Move { Name = "Razor Wind", At = 1 }, new Move { Name = "Quick Attack", At = 1 }, new Move { Name = "Thunder", At = 1 }, new Move { Name = "Charge", At = 1 }, new Move { Name = "Parabolic Charge", At = 1 }, },
                },

                new Species() {
                    Name = "Tyrunt",
                    moves = { new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Roar", At = 6 }, new Move { Name = "Stomp", At = 10 }, new Move { Name = "Bide", At = 12 }, new Move { Name = "Stealth Rock", At = 15 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Charm", At = 20 }, new Move { Name = "Ancient Power", At = 26 }, new Move { Name = "Dragon Tail", At = 30 }, new Move { Name = "Crunch", At = 34 }, new Move { Name = "Dragon Claw", At = 37 }, new Move { Name = "Thrash", At = 40 }, new Move { Name = "Earthquake", At = 44 }, new Move { Name = "Horn Drill", At = 49 }, },
                    eggMoves = { "Dragon Dance", "Thunder Fang", "Ice Fang", "Poison Fang", "Rock Polish", "Fire Fang", "Curse", },
                },

                new Species() {
                    Name = "Tyrantrum",
                    moves = { new Move { Name = "Head Smash", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Roar", At = 6 }, new Move { Name = "Stomp", At = 10 }, new Move { Name = "Bide", At = 12 }, new Move { Name = "Stealth Rock", At = 15 }, new Move { Name = "Bite", At = 17 }, new Move { Name = "Charm", At = 20 }, new Move { Name = "Ancient Power", At = 26 }, new Move { Name = "Dragon Tail", At = 30 }, new Move { Name = "Crunch", At = 34 }, new Move { Name = "Dragon Claw", At = 37 }, new Move { Name = "Thrash", At = 42 }, new Move { Name = "Earthquake", At = 47 }, new Move { Name = "Horn Drill", At = 53 }, new Move { Name = "Head Smash", At = 58 }, new Move { Name = "Rock Slide", At = 68 }, new Move { Name = "Giga Impact", At = 75 }, },
                },

                new Species() {
                    Name = "Amaura",
                    moves = { new Move { Name = "Growl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Thunder Wave", At = 5 }, new Move { Name = "Rock Throw", At = 10 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Mist", At = 18 }, new Move { Name = "Aurora Beam", At = 20 }, new Move { Name = "Ancient Power", At = 26 }, new Move { Name = "Round", At = 30 }, new Move { Name = "Avalanche", At = 34 }, new Move { Name = "Hail", At = 38 }, new Move { Name = "Nature Power", At = 41 }, new Move { Name = "Encore", At = 44 }, new Move { Name = "Light Screen", At = 47 }, new Move { Name = "Ice Beam", At = 50 }, new Move { Name = "Hyper Beam", At = 57 }, new Move { Name = "Blizzard", At = 65 }, },
                    eggMoves = { "Haze", "Barrier", "Mirror Coat", "Magnet Rise", "Discharge", },
                },

                new Species() {
                    Name = "Aurorus",
                    moves = { new Move { Name = "Freeze-Dry", At = 1 }, new Move { Name = "Growl", At = 1 }, new Move { Name = "Powder Snow", At = 1 }, new Move { Name = "Thunder Wave", At = 5 }, new Move { Name = "Rock Throw", At = 10 }, new Move { Name = "Icy Wind", At = 13 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Mist", At = 18 }, new Move { Name = "Aurora Beam", At = 20 }, new Move { Name = "Ancient Power", At = 26 }, new Move { Name = "Round", At = 30 }, new Move { Name = "Avalanche", At = 34 }, new Move { Name = "Hail", At = 38 }, new Move { Name = "Nature Power", At = 43 }, new Move { Name = "Encore", At = 46 }, new Move { Name = "Light Screen", At = 50 }, new Move { Name = "Ice Beam", At = 56 }, new Move { Name = "Hyper Beam", At = 63 }, new Move { Name = "Blizzard", At = 74 }, new Move { Name = "Freeze-Dry", At = 77 }, },
                },

                new Species() {
                    Name = "Sylveon",
                    moves = { new Move { Name = "Disarming Voice", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Helping Hand", At = 1 }, new Move { Name = "Sand Attack", At = 5 }, new Move { Name = "Fairy Wind", At = 9 }, new Move { Name = "Quick Attack", At = 13 }, new Move { Name = "Swift", At = 17 }, new Move { Name = "Draining Kiss", At = 20 }, new Move { Name = "Skill Swap", At = 25 }, new Move { Name = "Misty Terrain", At = 29 }, new Move { Name = "Light Screen", At = 33 }, new Move { Name = "Moonblast", At = 37 }, new Move { Name = "Last Resort", At = 41 }, new Move { Name = "Psych Up", At = 45 }, },
                },

                new Species() {
                    Name = "Hawlucha",
                    moves = { new Move { Name = "Detect", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Hone Claws", At = 1 }, new Move { Name = "Karate Chop", At = 4 }, new Move { Name = "Wing Attack", At = 8 }, new Move { Name = "Roost", At = 12 }, new Move { Name = "Aerial Ace", At = 16 }, new Move { Name = "Encore", At = 20 }, new Move { Name = "Fling", At = 24 }, new Move { Name = "Flying Press", At = 28 }, new Move { Name = "Bounce", At = 32 }, new Move { Name = "Endeavor", At = 36 }, new Move { Name = "Feather Dance", At = 40 }, new Move { Name = "High Jump Kick", At = 44 }, new Move { Name = "Sky Attack", At = 48 }, new Move { Name = "Sky Drop", At = 55 }, new Move { Name = "Swords Dance", At = 60 }, },
                    eggMoves = { "Agility", "Me First", "Ally Switch", "Entrainment", "Mud Sport", "Baton Pass", "Quick Guard", },
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Dedenne",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Tail Whip", At = 1 }, new Move { Name = "Thunder Shock", At = 7 }, new Move { Name = "Charge", At = 11 }, new Move { Name = "Charm", At = 14 }, new Move { Name = "Parabolic Charge", At = 17 }, new Move { Name = "Nuzzle", At = 20 }, new Move { Name = "Thunder Wave", At = 23 }, new Move { Name = "Volt Switch", At = 26 }, new Move { Name = "Rest", At = 30 }, new Move { Name = "Snore", At = 31 }, new Move { Name = "Charge Beam", At = 34 }, new Move { Name = "Entrainment", At = 39 }, new Move { Name = "Play Rough", At = 42 }, new Move { Name = "Thunder", At = 45 }, new Move { Name = "Discharge", At = 50 }, },
                    eggMoves = { "Eerie Impulse", "Covet", "Helping Hand", "Natural Gift", },
                    FS = true,
                },

                new Species() {
                    Name = "Carbink",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Rock Throw", At = 5 }, new Move { Name = "Sharpen", At = 8 }, new Move { Name = "Smack Down", At = 12 }, new Move { Name = "Reflect", At = 18 }, new Move { Name = "Stealth Rock", At = 21 }, new Move { Name = "Guard Split", At = 27 }, new Move { Name = "Ancient Power", At = 31 }, new Move { Name = "Flail", At = 35 }, new Move { Name = "Skill Swap", At = 40 }, new Move { Name = "Power Gem", At = 46 }, new Move { Name = "Stone Edge", At = 49 }, new Move { Name = "Moonblast", At = 50 }, new Move { Name = "Light Screen", At = 60 }, new Move { Name = "Safeguard", At = 70 }, },
                },

                new Species() {
                    Name = "Goomy",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Protect", At = 9 }, new Move { Name = "Bide", At = 13 }, new Move { Name = "Dragon Breath", At = 18 }, new Move { Name = "Rain Dance", At = 25 }, new Move { Name = "Flail", At = 28 }, new Move { Name = "Body Slam", At = 32 }, new Move { Name = "Muddy Water", At = 38 }, new Move { Name = "Dragon Pulse", At = 42 }, },
                    eggMoves = { "Acid Armor", "Curse", "Iron Tail", "Poison Tail", "Counter", "Endure", },
                },

                new Species() {
                    Name = "Sliggoo",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Protect", At = 9 }, new Move { Name = "Bide", At = 13 }, new Move { Name = "Dragon Breath", At = 18 }, new Move { Name = "Rain Dance", At = 25 }, new Move { Name = "Flail", At = 28 }, new Move { Name = "Body Slam", At = 32 }, new Move { Name = "Muddy Water", At = 38 }, new Move { Name = "Dragon Pulse", At = 47 }, },
                    FS = true,
                },

                new Species() {
                    Name = "Goodra",
                    moves = { new Move { Name = "Outrage", At = 1 }, new Move { Name = "Feint", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bubble", At = 1 }, new Move { Name = "Absorb", At = 5 }, new Move { Name = "Protect", At = 9 }, new Move { Name = "Bide", At = 13 }, new Move { Name = "Dragon Breath", At = 18 }, new Move { Name = "Rain Dance", At = 25 }, new Move { Name = "Flail", At = 28 }, new Move { Name = "Body Slam", At = 32 }, new Move { Name = "Muddy Water", At = 38 }, new Move { Name = "Dragon Pulse", At = 47 }, new Move { Name = "Aqua Tail", At = 50 }, new Move { Name = "Power Whip", At = 55 }, new Move { Name = "Outrage", At = 63 }, },
                },

                new Species() {
                    Name = "Klefki",
                    moves = { new Move { Name = "Fairy Lock", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Fairy Wind", At = 5 }, new Move { Name = "Astonish", At = 8 }, new Move { Name = "Metal Sound", At = 12 }, new Move { Name = "Spikes", At = 15 }, new Move { Name = "Draining Kiss", At = 18 }, new Move { Name = "Crafty Shield", At = 23 }, new Move { Name = "Foul Play", At = 27 }, new Move { Name = "Torment", At = 32 }, new Move { Name = "Mirror Shot", At = 34 }, new Move { Name = "Imprison", At = 36 }, new Move { Name = "Recycle", At = 40 }, new Move { Name = "Play Rough", At = 43 }, new Move { Name = "Magic Room", At = 44 }, new Move { Name = "Heal Block", At = 50 }, },
                    eggMoves = { "Switcheroo", "Thief", "Lock-On", "Iron Defense", },
                    FS = true,
                },

                new Species() {
                    Name = "Phantump",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Astonish", At = 5 }, new Move { Name = "Growth", At = 8 }, new Move { Name = "Ingrain", At = 13 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Leech Seed", At = 23 }, new Move { Name = "Curse", At = 28 }, new Move { Name = "Will-O-Wisp", At = 31 }, new Move { Name = "Forest’s Curse", At = 35 }, new Move { Name = "Destiny Bond", At = 39 }, new Move { Name = "Phantom Force", At = 45 }, new Move { Name = "Wood Hammer", At = 49 }, new Move { Name = "Horn Leech", At = 54 }, },
                    eggMoves = { "Grudge", "Bestow", "Imprison", "Venom Drench", },
                    FS = true,
                },

                new Species() {
                    Name = "Trevenant",
                    moves = { new Move { Name = "Horn Leech", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Astonish", At = 5 }, new Move { Name = "Growth", At = 8 }, new Move { Name = "Ingrain", At = 13 }, new Move { Name = "Feint Attack", At = 19 }, new Move { Name = "Leech Seed", At = 23 }, new Move { Name = "Curse", At = 28 }, new Move { Name = "Will-O-Wisp", At = 31 }, new Move { Name = "Forest’s Curse", At = 35 }, new Move { Name = "Destiny Bond", At = 39 }, new Move { Name = "Phantom Force", At = 45 }, new Move { Name = "Wood Hammer", At = 49 }, new Move { Name = "Shadow Claw", At = 55 }, new Move { Name = "Horn Leech", At = 62 }, },
                },

                new Species() {
                    Name = "Pumpkaboo (Average)",
                    moves = { new Move { Name = "Trick", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Scary Face", At = 4 }, new Move { Name = "Trick-or-Treat", At = 6 }, new Move { Name = "Worry Seed", At = 11 }, new Move { Name = "Razor Leaf", At = 16 }, new Move { Name = "Leech Seed", At = 20 }, new Move { Name = "Trick-or-Treat", At = 23 }, new Move { Name = "Bullet Seed", At = 26 }, new Move { Name = "Shadow Sneak", At = 30 }, new Move { Name = "Shadow Ball", At = 36 }, new Move { Name = "Trick-or-Treat", At = 40 }, new Move { Name = "Pain Split", At = 42 }, new Move { Name = "Seed Bomb", At = 48 }, },
                    eggMoves = { "Disable", "Bestow", "Destiny Bond", },
                    FS = true,
                },

                new Species() {
                    Name = "Gourgeist",
                    moves = { new Move { Name = "Explosion", At = 1 }, new Move { Name = "Phantom Force", At = 1 }, new Move { Name = "Trick", At = 1 }, new Move { Name = "Astonish", At = 1 }, new Move { Name = "Confuse Ray", At = 1 }, new Move { Name = "Scary Face", At = 4 }, new Move { Name = "Trick-or-Treat", At = 6 }, new Move { Name = "Worry Seed", At = 11 }, new Move { Name = "Razor Leaf", At = 16 }, new Move { Name = "Leech Seed", At = 20 }, new Move { Name = "Trick-or-Treat", At = 23 }, new Move { Name = "Bullet Seed", At = 26 }, new Move { Name = "Shadow Sneak", At = 30 }, new Move { Name = "Shadow Ball", At = 36 }, new Move { Name = "Trick-or-Treat", At = 40 }, new Move { Name = "Pain Split", At = 42 }, new Move { Name = "Seed Bomb", At = 48 }, new Move { Name = "Phantom Force", At = 57 }, new Move { Name = "Trick-or-Treat", At = 63 }, new Move { Name = "Shadow Ball", At = 70 }, new Move { Name = "Explosion", At = 75 }, },
                },

                new Species() {
                    Name = "Bergmite",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Powder Snow", At = 5 }, new Move { Name = "Icy Wind", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Sharpen", At = 20 }, new Move { Name = "Curse", At = 22 }, new Move { Name = "Ice Fang", At = 26 }, new Move { Name = "Ice Ball", At = 30 }, new Move { Name = "Rapid Spin", At = 35 }, new Move { Name = "Avalanche", At = 39 }, new Move { Name = "Blizzard", At = 43 }, new Move { Name = "Recover", At = 47 }, new Move { Name = "Double-Edge", At = 49 }, },
                    eggMoves = { "Recover", "Mist", "Barrier", "Mirror Coat", },
                    FS = true,
                },

                new Species() {
                    Name = "Avalugg",
                    moves = { new Move { Name = "Iron Defense", At = 1 }, new Move { Name = "Crunch", At = 1 }, new Move { Name = "Skull Bash", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Powder Snow", At = 5 }, new Move { Name = "Icy Wind", At = 10 }, new Move { Name = "Take Down", At = 15 }, new Move { Name = "Sharpen", At = 20 }, new Move { Name = "Curse", At = 22 }, new Move { Name = "Ice Fang", At = 26 }, new Move { Name = "Ice Ball", At = 30 }, new Move { Name = "Rapid Spin", At = 35 }, new Move { Name = "Avalanche", At = 42 }, new Move { Name = "Blizzard", At = 46 }, new Move { Name = "Recover", At = 51 }, new Move { Name = "Double-Edge", At = 56 }, new Move { Name = "Skull Bash", At = 60 }, new Move { Name = "Crunch", At = 65 }, },
                },

                new Species() {
                    Name = "Noibat",
                    moves = { new Move { Name = "Screech", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leech Life", At = 5 }, new Move { Name = "Gust", At = 11 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Wing Attack", At = 16 }, new Move { Name = "Agility", At = 18 }, new Move { Name = "Air Cutter", At = 23 }, new Move { Name = "Roost", At = 27 }, new Move { Name = "Razor Wind", At = 31 }, new Move { Name = "Tailwind", At = 35 }, new Move { Name = "Whirlwind", At = 40 }, new Move { Name = "Super Fang", At = 43 }, new Move { Name = "Air Slash", At = 48 }, new Move { Name = "Hurricane", At = 58 }, },
                    eggMoves = { "Switcheroo", "Snatch", "Outrage", "Tailwind", },
                    FS = true,
                },

                new Species() {
                    Name = "Noivern",
                    moves = { new Move { Name = "Moonlight", At = 1 }, new Move { Name = "Boomburst", At = 1 }, new Move { Name = "Dragon Pulse", At = 1 }, new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Screech", At = 1 }, new Move { Name = "Supersonic", At = 1 }, new Move { Name = "Tackle", At = 1 }, new Move { Name = "Leech Life", At = 5 }, new Move { Name = "Gust", At = 11 }, new Move { Name = "Bite", At = 13 }, new Move { Name = "Wing Attack", At = 16 }, new Move { Name = "Agility", At = 18 }, new Move { Name = "Air Cutter", At = 23 }, new Move { Name = "Roost", At = 27 }, new Move { Name = "Razor Wind", At = 31 }, new Move { Name = "Tailwind", At = 35 }, new Move { Name = "Whirlwind", At = 40 }, new Move { Name = "Super Fang", At = 43 }, new Move { Name = "Air Slash", At = 53 }, new Move { Name = "Hurricane", At = 62 }, new Move { Name = "Dragon Pulse", At = 70 }, new Move { Name = "Boomburst", At = 75 }, },
                },

                new Species() {
                    Name = "Xerneas",
                    moves = { new Move { Name = "Heal Pulse", At = 1 }, new Move { Name = "Aromatherapy", At = 1 }, new Move { Name = "Ingrain", At = 1 }, new Move { Name = "Take Down", At = 1 }, new Move { Name = "Light Screen", At = 5 }, new Move { Name = "Aurora Beam", At = 10 }, new Move { Name = "Gravity", At = 18 }, new Move { Name = "Geomancy", At = 26 }, new Move { Name = "Moonblast", At = 35 }, new Move { Name = "Megahorn", At = 44 }, new Move { Name = "Night Slash", At = 51 }, new Move { Name = "Horn Leech", At = 55 }, new Move { Name = "Psych Up", At = 59 }, new Move { Name = "Misty Terrain", At = 63 }, new Move { Name = "Nature Power", At = 72 }, new Move { Name = "Close Combat", At = 80 }, new Move { Name = "Giga Impact", At = 88 }, new Move { Name = "Outrage", At = 93 }, },
                },

                new Species() {
                    Name = "Yveltal",
                    moves = { new Move { Name = "Hurricane", At = 1 }, new Move { Name = "Razor Wind", At = 1 }, new Move { Name = "Taunt", At = 1 }, new Move { Name = "Roost", At = 1 }, new Move { Name = "Double Team", At = 5 }, new Move { Name = "Air Slash", At = 10 }, new Move { Name = "Snarl", At = 18 }, new Move { Name = "Oblivion Wing", At = 26 }, new Move { Name = "Disable", At = 35 }, new Move { Name = "Dark Pulse", At = 44 }, new Move { Name = "Foul Play", At = 51 }, new Move { Name = "Phantom Force", At = 55 }, new Move { Name = "Psychic", At = 59 }, new Move { Name = "Dragon Rush", At = 63 }, new Move { Name = "Focus Blast", At = 72 }, new Move { Name = "Sucker Punch", At = 80 }, new Move { Name = "Hyper Beam", At = 88 }, new Move { Name = "Sky Attack", At = 93 }, },
                },

                new Species() {
                    Name = "Zygarde",
                    moves = { new Move { Name = "Glare", At = 1 }, new Move { Name = "Bulldoze", At = 1 }, new Move { Name = "Dragon Breath", At = 1 }, new Move { Name = "Bite", At = 1 }, new Move { Name = "Safeguard", At = 5 }, new Move { Name = "Dig", At = 10 }, new Move { Name = "Bind", At = 18 }, new Move { Name = "Land’s Wrath", At = 26 }, new Move { Name = "Sandstorm", At = 35 }, new Move { Name = "Haze", At = 44 }, new Move { Name = "Crunch", At = 51 }, new Move { Name = "Earthquake", At = 55 }, new Move { Name = "Camouflage", At = 59 }, new Move { Name = "Dragon Pulse", At = 63 }, new Move { Name = "Dragon Dance", At = 72 }, new Move { Name = "Coil", At = 80 }, new Move { Name = "Extreme Speed", At = 88 }, new Move { Name = "Outrage", At = 93 }, },
                },

                new Species() {
                    Name = "Diancie",
                    moves = { new Move { Name = "Tackle", At = 1 }, new Move { Name = "Harden", At = 1 }, new Move { Name = "Rock Throw", At = 5 }, new Move { Name = "Sharpen", At = 8 }, new Move { Name = "Smack Down", At = 12 }, new Move { Name = "Reflect", At = 18 }, new Move { Name = "Stealth Rock", At = 21 }, new Move { Name = "Guard Split", At = 27 }, new Move { Name = "Ancient Power", At = 31 }, new Move { Name = "Flail", At = 35 }, new Move { Name = "Skill Swap", At = 40 }, new Move { Name = "Trick Room", At = 46 }, new Move { Name = "Stone Edge", At = 49 }, new Move { Name = "Moonblast", At = 50 }, new Move { Name = "Diamond Storm", At = 50 }, new Move { Name = "Light Screen", At = 60 }, new Move { Name = "Safeguard", At = 70 }, },
                },

                new Species() {
                    Name = "Hoopa",
                    moves = { new Move { Name = "Hyperspace Hole", At = 1 }, new Move { Name = "Trick", At = 1 }, new Move { Name = "Destiny Bond", At = 1 }, new Move { Name = "Ally Switch", At = 1 }, new Move { Name = "Confusion", At = 1 }, new Move { Name = "Astonish", At = 6 }, new Move { Name = "Magic Coat", At = 10 }, new Move { Name = "Light Screen", At = 15 }, new Move { Name = "Psybeam", At = 19 }, new Move { Name = "Skill Swap", At = 25 }, new Move { Name = "Power Split", At = 29 }, new Move { Name = "Guard Split", At = 29 }, new Move { Name = "Phantom Force", At = 35 }, new Move { Name = "Zen Headbutt", At = 46 }, new Move { Name = "Wonder Room", At = 50 }, new Move { Name = "Trick Room", At = 50 }, new Move { Name = "Shadow Ball", At = 55 }, new Move { Name = "Nasty Plot", At = 68 }, new Move { Name = "Psychic", At = 75 }, new Move { Name = "Hyperspace Hole", At = 85 }, },
                },

                new Species() {
                    Name = "Volcanion",
                    moves = { new Move { Name = "Steam Eruption", At = 1 }, new Move { Name = "Flare Blitz", At = 1 }, new Move { Name = "Take Down", At = 1 }, new Move { Name = "Mist", At = 8 }, new Move { Name = "Haze", At = 11 }, new Move { Name = "Flame Charge", At = 15 }, new Move { Name = "Water Pulse", At = 21 }, new Move { Name = "Stomp", At = 28 }, new Move { Name = "Scald", At = 32 }, new Move { Name = "Weather Ball", At = 40 }, new Move { Name = "Body Slam", At = 46 }, new Move { Name = "Hydro Pump", At = 50 }, new Move { Name = "Flare Blitz", At = 58 }, new Move { Name = "Overheat", At = 65 }, new Move { Name = "Explosion", At = 76 }, new Move { Name = "Steam Eruption", At = 85 }, },
                },

                new Species() {
                    Name = "  ",
                },

                new Species() {
                    Name = "Shellos (Blue)",
                    moves = { new Move { Name = "Mud-Slap", At = 1 }, new Move { Name = "Mud Sport", At = 2 }, new Move { Name = "Harden", At = 4 }, new Move { Name = "Water Pulse", At = 7 }, new Move { Name = "Mud Bomb", At = 11 }, new Move { Name = "Hidden Power", At = 16 }, new Move { Name = "Rain Dance", At = 22 }, new Move { Name = "Body Slam", At = 29 }, new Move { Name = "Muddy Water", At = 37 }, new Move { Name = "Recover", At = 46 }, },
                    eggMoves = { "Counter", "Mirror Coat", "Stockpile", "Swallow", "Spit Up", "Yawn", "Memento", "Curse", "Amnesia", "Fissure", "Trump Card", "Sludge", "Clear Smog", "Brine", "Mist", "Acid Armor", },
                },

                new Species() {
                    Name = "Gastrodon (Blue)",
                },

                new Species() {
                    Name = "Basculin (Blue)",
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Flabébé (Yellow)",
                },

                new Species() {
                    Name = "Flabébé (Orange)",
                },

                new Species() {
                    Name = "Flabébé (Blue)",
                },

                new Species() {
                    Name = "Flabébé (White)",
                },

                new Species() {
                    Name = "Floette (Yellow)",
                    FS = true,
                },

                new Species() {
                    Name = "Floette (Orange)",
                },

                new Species() {
                    Name = "Floette (Blue)",
                    FS = true,
                },

                new Species() {
                    Name = "Floette (White)",
                },

                new Species() {
                    Name = "Pumpkaboo (Small)",
                },

                new Species() {
                    Name = "Pumpkaboo (Large)",
                },

                new Species() {
                    Name = "Pumpkaboo (Super)",
                    item100 = "Miracle Seed",
                },

            };

    }
}
