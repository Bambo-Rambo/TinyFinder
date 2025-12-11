using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFinder.Controls
{
    public enum EnctrKey
    {
        ID,
        Wild,
        Fishing,
        RockSmash,
        Horde,
        Honey,
        Radar,
        FS,
        Ambush,
        DexNavMov,
        DexNavSrch
    }

    public class EncounterType
    {
        public EnctrKey Key { get; set; }
        public string Name { get; set; }

        public bool ShowsSettings = true;

        public uint MinAdvancesSrch;
        public uint MaxAdvancesSrch;
        public uint MinAdvancesGen;
        public uint MaxAdvancesGen;
        public int InteractMT;

        public bool ShowsTriggerMTFrame;

        public bool ShowsLocations = true;
        public bool ShowsCharm;
        public bool ShowsEmulator;
        public bool ShowsUseBag;
        public bool ShowsFlute;
        public bool ShowsMultiFlutes;

        public bool ShowsChain;
        public bool ShowsParty = true;
        public bool ShowsRatio;

        public bool ShowsTIDSID;

        public bool ShowsSync = true;
        public bool ShowsSpecies = true;
        public bool ShowsSlots = true;

        public bool ShowsHordeInfo;
        public bool ShowsRadarInfo;
        public bool ShowsDexNavInfo;

        public static List<EncounterType> GetEncounterTypes(bool ORAS)
        {
            List<EncounterType> list = new List<EncounterType>()
            {
                new EncounterType
                {
                    Key = EnctrKey.ID,
                    Name = "ID",

                    ShowsLocations = false,
                    ShowsSettings = false,
                    ShowsParty = false,

                    ShowsTIDSID = true,
                    ShowsSlots = false,
                    ShowsSpecies = false,
                    ShowsSync = false,
                },

                new EncounterType
                {
                    Key = EnctrKey.Wild,
                    Name = "Normal Wild",

                    ShowsRatio = true,

                    ShowsSlots = true,
                    ShowsFlute = ORAS,
                },

                new EncounterType
                {
                    Key = EnctrKey.Fishing,
                    Name = "Fishing",

                    ShowsTriggerMTFrame = true,
                    ShowsEmulator = true,
                    ShowsUseBag = true,
                    ShowsRatio = true,

                    ShowsFlute = ORAS,

                    // After exiting the bag, we prefer that no blinks will happen before the rod usage
                    // Pressing B to exit the bag -> countdown begins 16 MT frames earlier in ORAS
                    // Rod usage delay -> 4
                    // The earliest possible blink can happen at MT frame 152 (Meteor Falls on Emu)
                    InteractMT = 140,   // Actual activation at 144
                },

                new EncounterType 
                { 
                    Key = EnctrKey.RockSmash, 
                    Name = "Rock Smash",

                    ShowsParty = false,
                    ShowsTriggerMTFrame = true,
                    ShowsEmulator = true,
                    ShowsFlute = ORAS,
                    ShowsSettings = false,

                    // We cannot prevents blinks from happening until rock smash is activated
                    // so let's just take a round number like 300
                    InteractMT = 300,   // Actual activation at 316
                },

                new EncounterType 
                { 
                    Key = EnctrKey.Horde, 
                    Name = "Horde",

                    ShowsHordeInfo = true,
                    ShowsFlute = ORAS,
                    ShowsMultiFlutes = ORAS,
                },

                new EncounterType 
                { 
                    Key = EnctrKey.Honey, Name = "Honey Wild", ShowsFlute = ORAS, 
                },
            };

            if (ORAS)
            {
                list.Add(new EncounterType 
                { 
                    Key = EnctrKey.DexNavMov, 
                    Name = "DexNav - Moving",

                    ShowsChain = true,

                    ShowsFlute = true,
                    ShowsSync = false,
                    ShowsDexNavInfo = true,
                });

                list.Add(new EncounterType 
                { 
                    Key = EnctrKey.DexNavSrch, 
                    Name = "DexNav - Searching",

                    ShowsTriggerMTFrame = true,
                    ShowsEmulator = true,
                    ShowsChain = true,

                    ShowsSlots = false,
                    ShowsFlute = true,
                    ShowsSync = false,
                    ShowsDexNavInfo = true,

                    // After exiting the bag, we prefer that no blinks will happen before the search activation
                    // Pressing X to exit the bag -> countdown begins 4 MT frames earlier in ORAS
                    // Search activation delay -> 12
                    // The earliest possible blink can happen at MT frame 164 (Meteor Falls on Emu)
                    InteractMT = 140,   // Actual activation at 152
                });
            }
            else
            {
                list.Add(new EncounterType 
                { 
                    Key = EnctrKey.Radar, 
                    Name = "Poké Radar",
                    ShowsRadarInfo = true,
                    ShowsUseBag = true,

                    ShowsChain = true,
                });

                list.Add(new EncounterType 
                { 
                    Key = EnctrKey.FS, 
                    Name = "Friend Safari",

                    ShowsLocations = false,
                    ShowsRatio = true,
                });

                list.Add(new EncounterType 
                { 
                    Key = EnctrKey.Ambush, 
                    Name = "Ambush Encounter",
                    ShowsSettings = false,
                });
            }

            return list;
        }

    }

}