using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class Species
    {
        public string Name;
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
                },

                new Species() {
                    Name = "Ivysaur",
                    FS = true,
                },

                new Species() {
                    Name = "Venusaur",
                },

                new Species() {
                    Name = "Charmander",
                },

                new Species() {
                    Name = "Charmeleon",
                    FS = true,
                },

                new Species() {
                    Name = "Charizard",
                },

                new Species() {
                    Name = "Squirtle",
                },

                new Species() {
                    Name = "Wartortle",
                    FS = true,
                },

                new Species() {
                    Name = "Blastoise",
                },

                new Species() {
                    Name = "Caterpie",
                },

                new Species() {
                    Name = "Metapod",
                },

                new Species() {
                    Name = "Butterfree",
                    FS = true,
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Weedle",
                },

                new Species() {
                    Name = "Kakuna",
                    FS = true,
                },

                new Species() {
                    Name = "Beedrill",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Pidgey",
                    FS = true,
                },

                new Species() {
                    Name = "Pidgeotto",
                },

                new Species() {
                    Name = "Pidgeot",
                },

                new Species() {
                    Name = "Rattata",
                },

                new Species() {
                    Name = "Raticate",
                },

                new Species() {
                    Name = "Spearow",
                    FS = true,
                },

                new Species() {
                    Name = "Fearow",
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Ekans",
                },

                new Species() {
                    Name = "Arbok",
                },

                new Species() {
                    Name = "Pikachu",
                    FS = true,
                    item5 = "Light Ball",
                },

                new Species() {
                    Name = "Raichu",
                },

                new Species() {
                    Name = "Sandshrew",
                    FS = true,
                    xy5 = "Quick Claw",
                    oras5 = "Grip Claw",
                },

                new Species() {
                    Name = "Sandslash",
                    xy5 = "Quick Claw",
                    oras5 = "Grip Claw",
                },

                new Species() {
                    Name = "Nidoran♀",
                },

                new Species() {
                    Name = "Nidorina",
                },

                new Species() {
                    Name = "Nidoqueen",
                },

                new Species() {
                    Name = "Nidoran♂",
                },

                new Species() {
                    Name = "Nidorino",
                },

                new Species() {
                    Name = "Nidoking",
                },

                new Species() {
                    Name = "Clefairy",
                    FS = true,
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Clefable",
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Vulpix",
                    oras5 = "Charcoal",
                },

                new Species() {
                    Name = "Ninetales",
                    FS = true,
                    oras5 = "Charcoal",
                },

                new Species() {
                    Name = "Jigglypuff",
                    FS = true,
                },

                new Species() {
                    Name = "Wigglytuff",
                },

                new Species() {
                    Name = "Zubat",
                },

                new Species() {
                    Name = "Golbat",
                },

                new Species() {
                    Name = "Oddish",
                    FS = true,
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Gloom",
                    FS = true,
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Vileplume",
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Paras",
                    FS = true,
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Parasect",
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Venonat",
                },

                new Species() {
                    Name = "Venomoth",
                    FS = true,
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Diglett",
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Dugtrio",
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Meowth",
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Persian",
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Psyduck",
                },

                new Species() {
                    Name = "Golduck",
                },

                new Species() {
                    Name = "Mankey",
                    FS = true,
                },

                new Species() {
                    Name = "Primeape",
                },

                new Species() {
                    Name = "Growlithe",
                    FS = true,
                },

                new Species() {
                    Name = "Arcanine",
                },

                new Species() {
                    Name = "Poliwag",
                },

                new Species() {
                    Name = "Poliwhirl",
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Poliwrath",
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Abra",
                    FS = true,
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Kadabra",
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Alakazam",
                    item5 = "Twisted Spoon",
                },

                new Species() {
                    Name = "Machop",
                     oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Machoke",
                    FS = true,
                     oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Machamp",
                     oras5 = "Focus Band",
                },

                new Species() {
                    Name = "Bellsprout",
                },

                new Species() {
                    Name = "Weepinbell",
                },

                new Species() {
                    Name = "Victreebel",
                },

                new Species() {
                    Name = "Tentacool",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Tentacruel",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Geodude",
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Graveler",
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Golem",
                    item5 = "Everstone",
                },

                new Species() {
                    Name = "Ponyta",
                    FS = true,
                },

                new Species() {
                    Name = "Rapidash",
                },

                new Species() {
                    Name = "Slowpoke",
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Slowbro",
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Magnemite",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Magneton",
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Farfetch’d",
                    item5 = "Leek",
                },

                new Species() {
                    Name = "Doduo",
                    FS = true,
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Dodrio",
                    item5 = "Sharp Beak",
                },

                new Species() {
                    Name = "Seel",
                },

                new Species() {
                    Name = "Dewgong",
                    FS = true,
                },

                new Species() {
                    Name = "Grimer",
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Muk",
                    FS = true,
                    item50 = "Black Sludge",
                },

                new Species() {
                    Name = "Shellder",
                    item5 = "Big Pearl",
                    item50 = "Pearl",
                },

                new Species() {
                    Name = "Cloyster",
                    FS = true,
                    item5 = "Big Pearl",
                    item50 = "Pearl",
                },

                new Species() {
                    Name = "Gastly",
                },

                new Species() {
                    Name = "Haunter",
                },

                new Species() {
                    Name = "Gengar",
                },

                new Species() {
                    Name = "Onix",
                    FS = true,
                },

                new Species() {
                    Name = "Drowzee",
                    FS = true,
                },

                new Species() {
                    Name = "Hypno",
                },

                new Species() {
                    Name = "Krabby",
                    FS = true,
                },

                new Species() {
                    Name = "Kingler",
                },

                new Species() {
                    Name = "Voltorb",
                },

                new Species() {
                    Name = "Electrode",
                    FS = true,
                },

                new Species() {
                    Name = "Exeggcute",
                },

                new Species() {
                    Name = "Exeggutor",
                },

                new Species() {
                    Name = "Cubone",
                    item5 = "Thick Club",
                },

                new Species() {
                    Name = "Marowak",
                    FS = true,
                    item5 = "Thick Club",
                },

                new Species() {
                    Name = "Hitmonlee",
                },

                new Species() {
                    Name = "Hitmonchan",
                },

                new Species() {
                    Name = "Lickitung",
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Koffing",
                    item5 = "Smoke Ball",
                },

                new Species() {
                    Name = "Weezing",
                    item5 = "Smoke Ball",
                },

                new Species() {
                    Name = "Rhyhorn",
                },

                new Species() {
                    Name = "Rhydon",
                    FS = true,
                },

                new Species() {
                    Name = "Chansey",
                    FS = true,
                    item5 = "Lucky Egg",
                    item50 = "Lucky Punch",
                },

                new Species() {
                    Name = "Tangela",
                    FS = true,
                },

                new Species() {
                    Name = "Kangaskhan",
                },

                new Species() {
                    Name = "Horsea",
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Seadra",
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Goldeen",
                    oras5 = "Mystic Water",
                },

                new Species() {
                    Name = "Seaking",
                    oras5 = "Mystic Water",
                },

                new Species() {
                    Name = "Staryu",
                    item5 = "Star Piece",
                    item50 = "Stardust",
                },

                new Species() {
                    Name = "Starmie",
                    item5 = "Star Piece",
                    item50 = "Stardust",
                },

                new Species() {
                    Name = "Mr. Mime",
                },

                new Species() {
                    Name = "Scyther",
                },

                new Species() {
                    Name = "Jynx",
                },

                new Species() {
                    Name = "Electabuzz",
                    FS = true,
                    item5 = "Electirizer",
                },

                new Species() {
                    Name = "Magmar",
                    FS = true,
                    item5 = "Magmarizer",
                },

                new Species() {
                    Name = "Pinsir",
                    FS = true,
                },

                new Species() {
                    Name = "Tauros",
                },

                new Species() {
                    Name = "Magikarp",
                },

                new Species() {
                    Name = "Gyarados",
                    FS = true,
                },

                new Species() {
                    Name = "Lapras",
                    FS = true,
                    item100 = "Mystic Water",
                },

                new Species() {
                    Name = "Ditto",
                    FS = true,
                    item5 = "Metal Powder",
                    item50 = "Quick Powder",
                },

                new Species() {
                    Name = "Eevee",
                    FS = true,
                },

                new Species() {
                    Name = "Vaporeon",
                },

                new Species() {
                    Name = "Jolteon",
                },

                new Species() {
                    Name = "Flareon",
                },

                new Species() {
                    Name = "Porygon",
                },

                new Species() {
                    Name = "Omanyte",
                },

                new Species() {
                    Name = "Omastar",
                },

                new Species() {
                    Name = "Kabuto",
                },

                new Species() {
                    Name = "Kabutops",
                },

                new Species() {
                    Name = "Aerodactyl",
                },

                new Species() {
                    Name = "Snorlax",
                    item100 = "Leftovers",
                },

                new Species() {
                    Name = "Articuno",
                },

                new Species() {
                    Name = "Zapdos",
                },

                new Species() {
                    Name = "Moltres",
                },

                new Species() {
                    Name = "Dratini",
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Dragonair",
                    FS = true,
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Dragonite",
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Mewtwo",
                },

                new Species() {
                    Name = "Mew",
                    item5 = "Lum Berry",
                },

                new Species() {
                    Name = "Chikorita",
                },

                new Species() {
                    Name = "Bayleef",
                },

                new Species() {
                    Name = "Meganium",
                },

                new Species() {
                    Name = "Cyndaquil",
                },

                new Species() {
                    Name = "Quilava",
                },

                new Species() {
                    Name = "Typhlosion",
                },

                new Species() {
                    Name = "Totodile",
                },

                new Species() {
                    Name = "Croconaw",
                },

                new Species() {
                    Name = "Feraligatr",
                },

                new Species() {
                    Name = "Sentret",
                },

                new Species() {
                    Name = "Furret",
                },

                new Species() {
                    Name = "Hoothoot",
                    FS = true,
                },

                new Species() {
                    Name = "Noctowl",
                },

                new Species() {
                    Name = "Ledyba",
                    FS = true,
                },

                new Species() {
                    Name = "Ledian",
                },

                new Species() {
                    Name = "Spinarak",
                },

                new Species() {
                    Name = "Ariados",
                    FS = true,
                },

                new Species() {
                    Name = "Crobat",
                },

                new Species() {
                    Name = "Chinchou",
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Lanturn",
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Pichu",
                },

                new Species() {
                    Name = "Cleffa",
                    item5 = "Moon Stone",
                },

                new Species() {
                    Name = "Igglybuff",
                },

                new Species() {
                    Name = "Togepi",
                    FS = true,
                },

                new Species() {
                    Name = "Togetic",
                },

                new Species() {
                    Name = "Natu",
                },

                new Species() {
                    Name = "Xatu",
                    FS = true,
                },

                new Species() {
                    Name = "Mareep",
                },

                new Species() {
                    Name = "Flaaffy",
                },

                new Species() {
                    Name = "Ampharos",
                },

                new Species() {
                    Name = "Bellossom",
                    oras5 = "Absorb Bulb",
                },

                new Species() {
                    Name = "Marill",
                },

                new Species() {
                    Name = "Azumarill",
                    FS = true,
                },

                new Species() {
                    Name = "Sudowoodo",
                },

                new Species() {
                    Name = "Politoed",
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Hoppip",
                },

                new Species() {
                    Name = "Skiploom",
                },

                new Species() {
                    Name = "Jumpluff",
                },

                new Species() {
                    Name = "Aipom",
                    FS = true,
                },

                new Species() {
                    Name = "Sunkern",
                    FS = true,
                },

                new Species() {
                    Name = "Sunflora",
                },

                new Species() {
                    Name = "Yanma",
                    item5 = "Wide Lens",
                },

                new Species() {
                    Name = "Wooper",
                    FS = true,
                },

                new Species() {
                    Name = "Quagsire",
                    FS = true,
                },

                new Species() {
                    Name = "Espeon",
                },

                new Species() {
                    Name = "Umbreon",
                },

                new Species() {
                    Name = "Murkrow",
                },

                new Species() {
                    Name = "Slowking",
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Misdreavus",
                },

                new Species() {
                    Name = "Unown",
                },

                new Species() {
                    Name = "Wobbuffet",
                    FS = true,
                },

                new Species() {
                    Name = "Girafarig",
                    FS = true,
                },

                new Species() {
                    Name = "Pineco",
                },

                new Species() {
                    Name = "Forretress",
                    FS = true,
                },

                new Species() {
                    Name = "Dunsparce",
                    FS = true,
                },

                new Species() {
                    Name = "Gligar",
                },

                new Species() {
                    Name = "Steelix",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Snubbull",
                    FS = true,
                },

                new Species() {
                    Name = "Granbull",
                },

                new Species() {
                    Name = "Qwilfish",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Scizor",
                },

                new Species() {
                    Name = "Shuckle",
                    FS = true,
                },

                new Species() {
                    Name = "Heracross",
                    FS = true,
                },

                new Species() {
                    Name = "Sneasel",
                    FS = true,
                    item5 = "Quick Claw",
                    xy50 = "Grip Claw",
                },

                new Species() {
                    Name = "Teddiursa",
                    FS = true,
                },

                new Species() {
                    Name = "Ursaring",
                },

                new Species() {
                    Name = "Slugma",
                    FS = true,
                },

                new Species() {
                    Name = "Magcargo",
                    FS = true,
                },

                new Species() {
                    Name = "Swinub",
                },

                new Species() {
                    Name = "Piloswine",
                    FS = true,
                },

                new Species() {
                    Name = "Corsola",
                    FS = true,
                    xy5 = "Hard Stone",
                    oras5 = "Luminous Moss",
                },

                new Species() {
                    Name = "Remoraid",
                },

                new Species() {
                    Name = "Octillery",
                    FS = true,
                },

                new Species() {
                    Name = "Delibird",
                    FS = true,
                },

                new Species() {
                    Name = "Mantine",
                },

                new Species() {
                    Name = "Skarmory",
                    FS = true,
                    oras5 = "Metal Coat",
                },

                new Species() {
                    Name = "Houndour",
                },

                new Species() {
                    Name = "Houndoom",
                },

                new Species() {
                    Name = "Kingdra",
                    item5 = "Dragon Scale",
                },

                new Species() {
                    Name = "Phanpy",
                    FS = true,
                },

                new Species() {
                    Name = "Donphan",
                },

                new Species() {
                    Name = "Porygon2",
                },

                new Species() {
                    Name = "Stantler",
                },

                new Species() {
                    Name = "Smeargle",
                    FS = true,
                },

                new Species() {
                    Name = "Tyrogue",
                    FS = true,
                },

                new Species() {
                    Name = "Hitmontop",
                },

                new Species() {
                    Name = "Smoochum",
                },

                new Species() {
                    Name = "Elekid",
                    oras5 = "Electirizer",
                },

                new Species() {
                    Name = "Magby",
                    oras5 = "Magmarizer",
                },

                new Species() {
                    Name = "Miltank",
                },

                new Species() {
                    Name = "Blissey",
                },

                new Species() {
                    Name = "Raikou",
                },

                new Species() {
                    Name = "Entei",
                },

                new Species() {
                    Name = "Suicune",
                },

                new Species() {
                    Name = "Larvitar",
                },

                new Species() {
                    Name = "Pupitar",
                    FS = true,
                },

                new Species() {
                    Name = "Tyranitar",
                },

                new Species() {
                    Name = "Lugia",
                },

                new Species() {
                    Name = "Ho-Oh",
                    item100 = "Sacred Ash",
                },

                new Species() {
                    Name = "Celebi",
                    item100 = "Lum Berry",
                },

                new Species() {
                    Name = "Treecko",
                },

                new Species() {
                    Name = "Grovyle",
                },

                new Species() {
                    Name = "Sceptile",
                },

                new Species() {
                    Name = "Torchic",
                },

                new Species() {
                    Name = "Combusken",
                },

                new Species() {
                    Name = "Blaziken",
                },

                new Species() {
                    Name = "Mudkip",
                },

                new Species() {
                    Name = "Marshtomp",
                },

                new Species() {
                    Name = "Swampert",
                },

                new Species() {
                    Name = "Poochyena",
                },

                new Species() {
                    Name = "Mightyena",
                    FS = true,
                },

                new Species() {
                    Name = "Zigzagoon",
                    oras5 = "Revive",
                    oras50 = "Potion",
                },

                new Species() {
                    Name = "Linoone",
                    oras5 = "Max Revive",
                    oras50 = "Potion",
                },

                new Species() {
                    Name = "Wurmple",
                    oras5 = "Bright Powder",
                    oras50 = "Pecha Berry",
                },

                new Species() {
                    Name = "Silcoon",
                },

                new Species() {
                    Name = "Beautifly",
                    FS = true,
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Cascoon",
                    FS = true,
                },

                new Species() {
                    Name = "Dustox",
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Lotad",
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Lombre",
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Ludicolo",
                    oras5 = "Mental Herb",
                },

                new Species() {
                    Name = "Seedot",
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Nuzleaf",
                    FS = true,
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Shiftry",
                    oras5 = "Power Herb",
                },

                new Species() {
                    Name = "Taillow",
                },

                new Species() {
                    Name = "Swellow",
                },

                new Species() {
                    Name = "Wingull",
                    oras50 = "Pretty Wing",
                },

                new Species() {
                    Name = "Pelipper",
                    oras5 = "Lucky Egg",
                    oras50 = "Pretty Wing",
                },

                new Species() {
                    Name = "Ralts",
                },

                new Species() {
                    Name = "Kirlia",
                    FS = true,
                },

                new Species() {
                    Name = "Gardevoir",
                },

                new Species() {
                    Name = "Surskit",
                    oras5 = "Honey",
                },

                new Species() {
                    Name = "Masquerain",
                    FS = true,
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Shroomish",
                    oras5 = "Big Mushroom",
                    oras50 = "Tiny Mushroom",
                },

                new Species() {
                    Name = "Breloom",
                    FS = true,
                    oras5 = "Big Mushroom",
                    oras50 = "Tiny Mushroom",
                },

                new Species() {
                    Name = "Slakoth",
                },

                new Species() {
                    Name = "Vigoroth",
                },

                new Species() {
                    Name = "Slaking",
                },

                new Species() {
                    Name = "Nincada",
                    FS = true,
                    oras5 = "Soft Sand",
                },

                new Species() {
                    Name = "Ninjask",
                },

                new Species() {
                    Name = "Shedinja",
                },

                new Species() {
                    Name = "Whismur",
                },

                new Species() {
                    Name = "Loudred",
                    FS = true,
                },

                new Species() {
                    Name = "Exploud",
                },

                new Species() {
                    Name = "Makuhita",
                    oras5 = "Black Belt",
                },

                new Species() {
                    Name = "Hariyama",
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Azurill",
                },

                new Species() {
                    Name = "Nosepass",
                    FS = true,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Skitty",
                },

                new Species() {
                    Name = "Delcatty",
                },

                new Species() {
                    Name = "Sableye",
                    FS = true,
                    oras5 = "Wide Lens",
                },

                new Species() {
                    Name = "Mawile",
                    FS = true,
                    oras5 = "Iron Ball",
                },

                new Species() {
                    Name = "Aron",
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Lairon",
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Aggron",
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Meditite",
                    FS = true,
                },

                new Species() {
                    Name = "Medicham",
                },

                new Species() {
                    Name = "Electrike",
                },

                new Species() {
                    Name = "Manectric",
                    FS = true,
                },

                new Species() {
                    Name = "Plusle",
                    oras5 = "Cell Battery",
                },

                new Species() {
                    Name = "Minun",
                    oras5 = "Cell Battery",
                },

                new Species() {
                    Name = "Volbeat",
                    FS = true,
                    oras5 = "Bright Powder",
                },

                new Species() {
                    Name = "Illumise",
                    FS = true,
                    oras5 = "Bright Powder",
                },

                new Species() {
                    Name = "Roselia",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Gulpin",
                    xy5 = "Oran Berry",
                    oras5 = "Sitrus Berry",
                    oras50 = "Oran Berry",
                },

                new Species() {
                    Name = "Swalot",
                    FS = true,
                    xy5 = "Oran Berry",
                    oras5 = "Sitrus Berry",
                    oras50 = "Oran Berry",
                },

                new Species() {
                    Name = "Carvanha",
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Sharpedo",
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Wailmer",
                },

                new Species() {
                    Name = "Wailord",
                },

                new Species() {
                    Name = "Numel",
                },

                new Species() {
                    Name = "Camerupt",
                    FS = true,
                },

                new Species() {
                    Name = "Torkoal",
                    item5 = "Charcoal",
                },

                new Species() {
                    Name = "Spoink",
                },

                new Species() {
                    Name = "Grumpig",
                    FS = true,
                },

                new Species() {
                    Name = "Spinda",
                },

                new Species() {
                    Name = "Trapinch",
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Vibrava",
                },

                new Species() {
                    Name = "Flygon",
                },

                new Species() {
                    Name = "Cacnea",
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Cacturne",
                    FS = true,
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Swablu",
                },

                new Species() {
                    Name = "Altaria",
                },

                new Species() {
                    Name = "Zangoose",
                    item5 = "Quick Claw",
                },

                new Species() {
                    Name = "Seviper",
                    FS = true,
                    oras5 = "Shed Shell",
                    xy100 = "Persim Berry",
                },

                new Species() {
                    Name = "Lunatone",
                    item5 = "Moon Stone",
                    oras50 = "Stardust",
                },

                new Species() {
                    Name = "Solrock",
                    item5 = "Sun Stone",
                    oras50 = "Stardust",
                },

                new Species() {
                    Name = "Barboach",
                },

                new Species() {
                    Name = "Whiscash",
                },

                new Species() {
                    Name = "Corphish",
                },

                new Species() {
                    Name = "Crawdaunt",
                    FS = true,
                },

                new Species() {
                    Name = "Baltoy",
                    oras5 = "Light Clay",
                },

                new Species() {
                    Name = "Claydol",
                    oras5 = "Light Clay",
                },

                new Species() {
                    Name = "Lileep",
                    item5 = "Big Root",
                },

                new Species() {
                    Name = "Cradily",
                    item5 = "Big Root",
                },

                new Species() {
                    Name = "Anorith",
                },

                new Species() {
                    Name = "Armaldo",
                },

                new Species() {
                    Name = "Feebas",
                },

                new Species() {
                    Name = "Milotic",
                },

                new Species() {
                    Name = "Castform",
                },

                new Species() {
                    Name = "Kecleon",
                    FS = true,
                },

                new Species() {
                    Name = "Shuppet",
                    FS = true,
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Banette",
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Duskull",
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Dusclops",
                    FS = true,
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Tropius",
                    FS = true,
                },

                new Species() {
                    Name = "Chimecho",
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Absol",
                    FS = true,
                    oras5 = "Life Orb",
                },

                new Species() {
                    Name = "Wynaut",
                },

                new Species() {
                    Name = "Snorunt",
                    FS = true,
                    oras5 = "Snowball",
                },

                new Species() {
                    Name = "Glalie",
                },

                new Species() {
                    Name = "Spheal",
                    FS = true,
                },

                new Species() {
                    Name = "Sealeo",
                },

                new Species() {
                    Name = "Walrein",
                },

                new Species() {
                    Name = "Clamperl",
                    item5 = "Big Pearl",
                    oras50 = "Pearl",
                },

                new Species() {
                    Name = "Huntail",
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Gorebyss",
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Relicanth",
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Luvdisc",
                    item50 = "Heart Scale",
                },

                new Species() {
                    Name = "Bagon",
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Shelgon",
                    FS = true,
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Salamence",
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Beldum",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Metang",
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Metagross",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Regirock",
                },

                new Species() {
                    Name = "Regice",
                },

                new Species() {
                    Name = "Registeel",
                },

                new Species() {
                    Name = "Latias",
                },

                new Species() {
                    Name = "Latios",
                },

                new Species() {
                    Name = "Kyogre",
                },

                new Species() {
                    Name = "Groudon",
                },

                new Species() {
                    Name = "Rayquaza",
                },

                new Species() {
                    Name = "Jirachi",
                    item100 = "Star Piece",
                },

                new Species() {
                    Name = "Deoxys",
                },

                new Species() {
                    Name = "Turtwig",
                },

                new Species() {
                    Name = "Grotle",
                },

                new Species() {
                    Name = "Torterra",
                },

                new Species() {
                    Name = "Chimchar",
                },

                new Species() {
                    Name = "Monferno",
                },

                new Species() {
                    Name = "Infernape",
                },

                new Species() {
                    Name = "Piplup",
                },

                new Species() {
                    Name = "Prinplup",
                },

                new Species() {
                    Name = "Empoleon",
                },

                new Species() {
                    Name = "Starly",
                },

                new Species() {
                    Name = "Staravia",
                },

                new Species() {
                    Name = "Staraptor",
                },

                new Species() {
                    Name = "Bidoof",
                },

                new Species() {
                    Name = "Bibarel",
                    FS = true,
                },

                new Species() {
                    Name = "Kricketot",
                    oras5 = "Metronome",
                },

                new Species() {
                    Name = "Kricketune",
                    oras5 = "Metronome",
                },

                new Species() {
                    Name = "Shinx",
                },

                new Species() {
                    Name = "Luxio",
                    FS = true,
                },

                new Species() {
                    Name = "Luxray",
                },

                new Species() {
                    Name = "Budew",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Roserade",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Cranidos",
                },

                new Species() {
                    Name = "Rampardos",
                },

                new Species() {
                    Name = "Shieldon",
                },

                new Species() {
                    Name = "Bastiodon",
                },

                new Species() {
                    Name = "Burmy",
                },

                new Species() {
                    Name = "Wormadam",
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Mothim",
                    item5 = "Silver Powder",
                },

                new Species() {
                    Name = "Combee",
                    FS = true,
                    item5 = "Honey",
                },

                new Species() {
                    Name = "Vespiquen",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Pachirisu",
                    FS = true,
                },

                new Species() {
                    Name = "Buizel",
                },

                new Species() {
                    Name = "Floatzel",
                    FS = true,
                },

                new Species() {
                    Name = "Cherubi",
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Cherrim",
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Shellos (Pink)",
                },

                new Species() {
                    Name = "Gastrodon (Pink)",
                },

                new Species() {
                    Name = "Ambipom",
                },

                new Species() {
                    Name = "Drifloon",
                },

                new Species() {
                    Name = "Drifblim",
                    FS = true,
                },

                new Species() {
                    Name = "Buneary",
                },

                new Species() {
                    Name = "Lopunny",
                },

                new Species() {
                    Name = "Mismagius",
                },

                new Species() {
                    Name = "Honchkrow",
                },

                new Species() {
                    Name = "Glameow",
                },

                new Species() {
                    Name = "Purugly",
                },

                new Species() {
                    Name = "Chingling",
                    oras5 = "Cleanse Tag",
                },

                new Species() {
                    Name = "Stunky",
                },

                new Species() {
                    Name = "Skuntank",
                },

                new Species() {
                    Name = "Bronzor",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Bronzong",
                    FS = true,
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Bonsly",
                },

                new Species() {
                    Name = "Mime Jr.",
                },

                new Species() {
                    Name = "Happiny",
                    item5 = "Lucky Egg",
                    item50 = "Oval Stone",
                },

                new Species() {
                    Name = "Chatot",
                    item5 = "Metronome",
                },

                new Species() {
                    Name = "Spiritomb",
                    FS = true,
                },

                new Species() {
                    Name = "Gible",
                },

                new Species() {
                    Name = "Gabite",
                    FS = true,
                },

                new Species() {
                    Name = "Garchomp",
                },

                new Species() {
                    Name = "Munchlax",
                },

                new Species() {
                    Name = "Riolu",
                    FS = true,
                },

                new Species() {
                    Name = "Lucario",
                },

                new Species() {
                    Name = "Hippopotas",
                },

                new Species() {
                    Name = "Hippowdon",
                },

                new Species() {
                    Name = "Skorupi",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Drapion",
                    FS = true,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Croagunk",
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Toxicroak",
                    FS = true,
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Carnivine",
                },

                new Species() {
                    Name = "Finneon",
                },

                new Species() {
                    Name = "Lumineon",
                },

                new Species() {
                    Name = "Mantyke",
                },

                new Species() {
                    Name = "Snover",
                    FS = true,
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Abomasnow",
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Weavile",
                    item5 = "Quick Claw",
                    xy50 = "Grip Claw",
                },

                new Species() {
                    Name = "Magnezone",
                    item5 = "Metal Coat",
                },

                new Species() {
                    Name = "Lickilicky",
                    item5 = "Lagging Tail",
                },

                new Species() {
                    Name = "Rhyperior",
                },

                new Species() {
                    Name = "Tangrowth",
                },

                new Species() {
                    Name = "Electivire",
                    item5 = "Electirizer",
                },

                new Species() {
                    Name = "Magmortar",
                    item5 = "Magmarizer",
                },

                new Species() {
                    Name = "Togekiss",
                },

                new Species() {
                    Name = "Yanmega",
                    item5 = "Wide Lens",
                },

                new Species() {
                    Name = "Leafeon",
                },

                new Species() {
                    Name = "Glaceon",
                },

                new Species() {
                    Name = "Gliscor",
                },

                new Species() {
                    Name = "Mamoswine",
                },

                new Species() {
                    Name = "Porygon-Z",
                },

                new Species() {
                    Name = "Gallade",
                },

                new Species() {
                    Name = "Probopass",
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Dusknoir",
                    oras5 = "Spell Tag",
                },

                new Species() {
                    Name = "Froslass",
                },

                new Species() {
                    Name = "Rotom",
                },

                new Species() {
                    Name = "Uxie",
                },

                new Species() {
                    Name = "Mesprit",
                },

                new Species() {
                    Name = "Azelf",
                },

                new Species() {
                    Name = "Dialga",
                },

                new Species() {
                    Name = "Palkia",
                },

                new Species() {
                    Name = "Heatran",
                },

                new Species() {
                    Name = "Regigigas",
                },

                new Species() {
                    Name = "Giratina",
                },

                new Species() {
                    Name = "Cresselia",
                },

                new Species() {
                    Name = "Phione",
                },

                new Species() {
                    Name = "Manaphy",
                },

                new Species() {
                    Name = "Darkrai",
                },

                new Species() {
                    Name = "Shaymin",
                    item100 = "Lum Berry",
                },

                new Species() {
                    Name = "Arceus",
                },

                new Species() {
                    Name = "Victini",
                },

                new Species() {
                    Name = "Snivy",
                },

                new Species() {
                    Name = "Servine",
                },

                new Species() {
                    Name = "Serperior",
                },

                new Species() {
                    Name = "Tepig",
                },

                new Species() {
                    Name = "Pignite",
                },

                new Species() {
                    Name = "Emboar",
                },

                new Species() {
                    Name = "Oshawott",
                },

                new Species() {
                    Name = "Dewott",
                },

                new Species() {
                    Name = "Samurott",
                },

                new Species() {
                    Name = "Patrat",
                },

                new Species() {
                    Name = "Watchog",
                },

                new Species() {
                    Name = "Lillipup",
                    FS = true,
                },

                new Species() {
                    Name = "Herdier",
                },

                new Species() {
                    Name = "Stoutland",
                },

                new Species() {
                    Name = "Purrloin",
                },

                new Species() {
                    Name = "Liepard",
                    FS = true,
                },

                new Species() {
                    Name = "Pansage",
                    FS = true,
                },

                new Species() {
                    Name = "Simisage",
                },

                new Species() {
                    Name = "Pansear",
                    FS = true,
                },

                new Species() {
                    Name = "Simisear",
                },

                new Species() {
                    Name = "Panpour",
                    FS = true,
                },

                new Species() {
                    Name = "Simipour",
                },

                new Species() {
                    Name = "Munna",
                    FS = true,
                },

                new Species() {
                    Name = "Musharna",
                },

                new Species() {
                    Name = "Pidove",
                },

                new Species() {
                    Name = "Tranquill",
                    FS = true,
                },

                new Species() {
                    Name = "Unfezant",
                },

                new Species() {
                    Name = "Blitzle",
                },

                new Species() {
                    Name = "Zebstrika",
                    FS = true,
                },

                new Species() {
                    Name = "Roggenrola",
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Boldore",
                    FS = true,
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Gigalith",
                    item5 = "Hard Stone",
                    item50 = "Everstone",
                },

                new Species() {
                    Name = "Woobat",
                    FS = true,
                },

                new Species() {
                    Name = "Swoobat",
                },

                new Species() {
                    Name = "Drilbur",
                },

                new Species() {
                    Name = "Excadrill",
                    FS = true,
                },

                new Species() {
                    Name = "Audino",
                    FS = true,
                    item5 = "Sitrus Berry",
                    item50 = "Oran Berry",
                },

                new Species() {
                    Name = "Timburr",
                },

                new Species() {
                    Name = "Gurdurr",
                },

                new Species() {
                    Name = "Conkeldurr",
                },

                new Species() {
                    Name = "Tympole",
                },

                new Species() {
                    Name = "Palpitoad",
                    FS = true,
                },

                new Species() {
                    Name = "Seismitoad",
                },

                new Species() {
                    Name = "Throh",
                    FS = true,
                    item5 = "Black Belt",
                },

                new Species() {
                    Name = "Sawk",
                    FS = true,
                    item5 = "Black Belt",
                },

                new Species() {
                    Name = "Sewaddle",
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Swadloon",
                    FS = true,
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Leavanny",
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Venipede",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Whirlipede",
                    FS = true,
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Scolipede",
                    item5 = "Poison Barb",
                },

                new Species() {
                    Name = "Cottonee",
                },

                new Species() {
                    Name = "Whimsicott",
                },

                new Species() {
                    Name = "Petilil",
                    FS = true,
                },

                new Species() {
                    Name = "Lilligant",
                },

                new Species() {
                    Name = "Basculin (Red)",
                    item5 = "Deep Sea Tooth",
                },

                new Species() {
                    Name = "Sandile",
                    FS = true,
                },

                new Species() {
                    Name = "Krokorok",
                },

                new Species() {
                    Name = "Krookodile",
                },

                new Species() {
                    Name = "Darumaka",
                },

                new Species() {
                    Name = "Darmanitan",
                },

                new Species() {
                    Name = "Maractus",
                    FS = true,
                    item5 = "Miracle Seed",
                },

                new Species() {
                    Name = "Dwebble",
                    FS = true,
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Crustle",
                    item5 = "Hard Stone",
                },

                new Species() {
                    Name = "Scraggy",
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Scrafty",
                    item5 = "Shed Shell",
                },

                new Species() {
                    Name = "Sigilyph",
                    FS = true,
                },

                new Species() {
                    Name = "Yamask",
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Cofagrigus",
                    item5 = "Spell Tag",
                },

                new Species() {
                    Name = "Tirtouga",
                },

                new Species() {
                    Name = "Carracosta",
                },

                new Species() {
                    Name = "Archen",
                },

                new Species() {
                    Name = "Archeops",
                },

                new Species() {
                    Name = "Trubbish",
                    item5 = "Black Sludge",
                },

                new Species() {
                    Name = "Garbodor",
                    FS = true,
                    item5 = "Nugget",
                    item50 = "Black Sludge",
                },

                new Species() {
                    Name = "Zorua",
                },

                new Species() {
                    Name = "Zoroark",
                },

                new Species() {
                    Name = "Minccino",
                    FS = true,
                },

                new Species() {
                    Name = "Cinccino",
                },

                new Species() {
                    Name = "Gothita",
                },

                new Species() {
                    Name = "Gothorita",
                    FS = true,
                },

                new Species() {
                    Name = "Gothitelle",
                },

                new Species() {
                    Name = "Solosis",
                },

                new Species() {
                    Name = "Duosion",
                    FS = true,
                },

                new Species() {
                    Name = "Reuniclus",
                },

                new Species() {
                    Name = "Ducklett",
                },

                new Species() {
                    Name = "Swanna",
                    FS = true,
                },

                new Species() {
                    Name = "Vanillite",
                },

                new Species() {
                    Name = "Vanillish",
                },

                new Species() {
                    Name = "Vanilluxe",
                },

                new Species() {
                    Name = "Deerling",
                },

                new Species() {
                    Name = "Sawsbuck",
                    FS = true,
                },

                new Species() {
                    Name = "Emolga",
                    FS = true,
                },

                new Species() {
                    Name = "Karrablast",
                },

                new Species() {
                    Name = "Escavalier",
                },

                new Species() {
                    Name = "Foongus",
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Amoonguss",
                    item5 = "Big Mushroom",
                    item50 = "Tiny Mushroom"
                },

                new Species() {
                    Name = "Frillish",
                },

                new Species() {
                    Name = "Jellicent",
                },

                new Species() {
                    Name = "Alomomola",
                },

                new Species() {
                    Name = "Joltik",
                },

                new Species() {
                    Name = "Galvantula",
                    FS = true,
                },

                new Species() {
                    Name = "Ferroseed",
                    FS = true,
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Ferrothorn",
                    item5 = "Sticky Barb",
                },

                new Species() {
                    Name = "Klink",
                },

                new Species() {
                    Name = "Klang",
                    FS = true,
                },

                new Species() {
                    Name = "Klinklang",
                },

                new Species() {
                    Name = "Tynamo",
                },

                new Species() {
                    Name = "Eelektrik",
                },

                new Species() {
                    Name = "Eelektross",
                },

                new Species() {
                    Name = "Elgyem",
                },

                new Species() {
                    Name = "Beheeyem",
                },

                new Species() {
                    Name = "Litwick",
                },

                new Species() {
                    Name = "Lampent",
                    FS = true,
                },

                new Species() {
                    Name = "Chandelure",
                },

                new Species() {
                    Name = "Axew",
                },

                new Species() {
                    Name = "Fraxure",
                    FS = true,
                },

                new Species() {
                    Name = "Haxorus",
                },

                new Species() {
                    Name = "Cubchoo",
                },

                new Species() {
                    Name = "Beartic",
                    FS = true,
                },

                new Species() {
                    Name = "Cryogonal",
                    item5 = "Never-Melt Ice",
                },

                new Species() {
                    Name = "Shelmet",
                },

                new Species() {
                    Name = "Accelgor",
                },

                new Species() {
                    Name = "Stunfisk",
                    FS = true,
                    item5 = "Soft Sand",
                },

                new Species() {
                    Name = "Mienfoo",
                    FS = true,
                },

                new Species() {
                    Name = "Mienshao",
                },

                new Species() {
                    Name = "Druddigon",
                    FS = true,
                    item5 = "Dragon Fang",
                },

                new Species() {
                    Name = "Golett",
                    item5 = "Light Clay",
                },

                new Species() {
                    Name = "Golurk",
                    FS = true,
                    item5 = "Light Clay",
                },

                new Species() {
                    Name = "Pawniard",
                    FS = true,
                },

                new Species() {
                    Name = "Bisharp",
                },

                new Species() {
                    Name = "Bouffalant",
                },

                new Species() {
                    Name = "Rufflet",
                    FS = true,
                },

                new Species() {
                    Name = "Braviary",
                },

                new Species() {
                    Name = "Vullaby",
                    FS = true,
                },

                new Species() {
                    Name = "Mandibuzz",
                },

                new Species() {
                    Name = "Heatmor",
                },

                new Species() {
                    Name = "Durant",
                },

                new Species() {
                    Name = "Deino",
                },

                new Species() {
                    Name = "Zweilous",
                },

                new Species() {
                    Name = "Hydreigon",
                },

                new Species() {
                    Name = "Larvesta",
                    FS = true,
                },

                new Species() {
                    Name = "Volcarona",
                    item100 = "Silver Powder",
                },

                new Species() {
                    Name = "Cobalion",
                },

                new Species() {
                    Name = "Terrakion",
                },

                new Species() {
                    Name = "Virizion",
                },

                new Species() {
                    Name = "Tornadus",
                },

                new Species() {
                    Name = "Thundurus",
                },

                new Species() {
                    Name = "Reshiram",
                },

                new Species() {
                    Name = "Zekrom",
                },

                new Species() {
                    Name = "Landorus",
                },

                new Species() {
                    Name = "Kyurem",
                },

                new Species() {
                    Name = "Keldeo",
                },

                new Species() {
                    Name = "Meloetta",
                    item100 = "Star Piece",
                },

                new Species() {
                    Name = "Genesect",
                },

                new Species() {
                    Name = "Chespin",
                },

                new Species() {
                    Name = "Quilladin",
                    FS = true,
                },

                new Species() {
                    Name = "Chesnaught",
                },

                new Species() {
                    Name = "Fennekin",
                },

                new Species() {
                    Name = "Braixen",
                    FS = true,
                },

                new Species() {
                    Name = "Delphox",
                },

                new Species() {
                    Name = "Froakie",
                },

                new Species() {
                    Name = "Frogadier",
                    FS = true,
                },

                new Species() {
                    Name = "Greninja",
                },

                new Species() {
                    Name = "Bunnelby",
                },

                new Species() {
                    Name = "Diggersby",
                    FS = true,
                },

                new Species() {
                    Name = "Fletchling",
                },

                new Species() {
                    Name = "Fletchinder",
                    FS = true,
                },

                new Species() {
                    Name = "Talonflame",
                },

                new Species() {
                    Name = "Scatterbug",
                },

                new Species() {
                    Name = "Spewpa",
                },

                new Species() {
                    Name = "Vivillon",
                    FS = true,
                },

                new Species() {
                    Name = "Litleo",
                },

                new Species() {
                    Name = "Pyroar",
                    FS = true,
                },

                new Species() {
                    Name = "Flabébé (red)",
                },

                new Species() {
                    Name = "Floette (red)",
                    FS = true,
                },

                new Species() {
                    Name = "Florges",
                },

                new Species() {
                    Name = "Skiddo",
                },

                new Species() {
                    Name = "Gogoat",
                    FS = true,
                },

                new Species() {
                    Name = "Pancham",
                    FS = true,
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Pangoro",
                    item5 = "Mental Herb",
                },

                new Species() {
                    Name = "Furfrou",
                },

                new Species() {
                    Name = "Espurr",
                    FS = true,
                },

                new Species() {
                    Name = "Meowstic",
                },

                new Species() {
                    Name = "Honedge",
                },

                new Species() {
                    Name = "Doublade",
                },

                new Species() {
                    Name = "Aegislash",
                },

                new Species() {
                    Name = "Spritzee",
                    FS = true,
                },

                new Species() {
                    Name = "Aromatisse",
                },

                new Species() {
                    Name = "Swirlix",
                    FS = true,
                },

                new Species() {
                    Name = "Slurpuff",
                },

                new Species() {
                    Name = "Inkay",
                    FS = true,
                },

                new Species() {
                    Name = "Malamar",
                },

                new Species() {
                    Name = "Binacle",
                },

                new Species() {
                    Name = "Barbaracle",
                    FS = true,
                },

                new Species() {
                    Name = "Skrelp",
                },

                new Species() {
                    Name = "Dragalge",
                },

                new Species() {
                    Name = "Clauncher",
                },

                new Species() {
                    Name = "Clawitzer",
                },

                new Species() {
                    Name = "Helioptile",
                    FS = true,
                },

                new Species() {
                    Name = "Heliolisk",
                },

                new Species() {
                    Name = "Tyrunt",
                },

                new Species() {
                    Name = "Tyrantrum",
                },

                new Species() {
                    Name = "Amaura",
                },

                new Species() {
                    Name = "Aurorus",
                },

                new Species() {
                    Name = "Sylveon",
                },

                new Species() {
                    Name = "Hawlucha",
                    FS = true,
                    item5 = "King's Rock",
                },

                new Species() {
                    Name = "Dedenne",
                    FS = true,
                },

                new Species() {
                    Name = "Carbink",
                },

                new Species() {
                    Name = "Goomy",
                },

                new Species() {
                    Name = "Sliggoo",
                    FS = true,
                },

                new Species() {
                    Name = "Goodra",
                },

                new Species() {
                    Name = "Klefki",
                    FS = true,
                },

                new Species() {
                    Name = "Phantump",
                    FS = true,
                },

                new Species() {
                    Name = "Trevenant",
                },

                new Species() {
                    Name = "Pumpkaboo (small)",
                },

                new Species() {
                    Name = "Gourgeist",
                },

                new Species() {
                    Name = "Bergmite",
                    FS = true,
                },

                new Species() {
                    Name = "Avalugg",
                },

                new Species() {
                    Name = "Noibat",
                    FS = true,
                },

                new Species() {
                    Name = "Noivern",
                },

                new Species() {
                    Name = "Xerneas",
                },

                new Species() {
                    Name = "Yveltal",
                },

                new Species() {
                    Name = "Zygarde",
                },

                new Species() {
                    Name = "Diancie",
                },

                new Species() {
                    Name = "Hoopa",
                },

                new Species() {
                    Name = "Volcanion",
                },

                new Species() {
                    Name = "  ",
                },

                new Species() {
                    Name = "Shellos (Blue)",
                },

                new Species() {
                    Name = "Gastrodon (Blue)",
                },

                new Species() {
                    Name = "Basculin (blue)",
                    FS = true,
                    item5 = "Deep Sea Scale",
                },

                new Species() {
                    Name = "Flabébé (yellow)",
                },

                new Species() {
                    Name = "Flabébé (orange)",
                },

                new Species() {
                    Name = "Flabébé (blue)",
                },

                new Species() {
                    Name = "Flabébé (white)",
                },

                new Species() {
                    Name = "Pumpkaboo (average)",
                },

                new Species() {
                    Name = "Pumpkaboo (large)",
                },

                new Species() {
                    Name = "Pumpkaboo (super)",
                    item100 = "Miracle Seed",
                },

            };

    }
}
