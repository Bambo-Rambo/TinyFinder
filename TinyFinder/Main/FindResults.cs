using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using TinyFinder.Main;
using TinyFinder.Controls;
using System.Diagnostics.PerformanceData;
using System.Data.SqlTypes;
using TinyFinder.Properties;

namespace TinyFinder
{
    public partial class Form1
    {
        int Year;
        uint tinyInitSeed, seconds, initial = 0, Min, Max;
        uint TargetRandID;
        int searchMonth, SlotCount;
        bool DateSearcher, fastID;
        int bootAdvances;

        bool Calibrated = false, Working, NoFilters, Radar1;

        TinyMT tiny = new TinyMT();
        EncounterType Choice = new EncounterType();
        EnctrKey EnctrTypeChosen => Choice.Key;

        BindingSource source = new BindingSource();
        UISettings settings;
        List<Index> GenList = new List<Index>();
        List<Index> SearchList = new List<Index>();

        Thread[] jobs;
        uint ThreadsUsed;

        public void ApplyUISettings()
        {
            settings = new UISettings()
            {
                // General Settings
                triggerOnly = DateSearcher || !NoFilters,
                encounterKey = EnctrTypeChosen,

                // UI Settings
                oras = ORAS,
                bonusMusic = BonusMusicBox.Checked,
                moving = MovingHordeOption,
                fishingRod = EncounterSettings.SelectedIndex,
                fluteOption = ORAS ? FluteOption.SelectedIndex : 0,
                emulator = EmuBox.Checked,
                ratio = (int)ratio.Value,
                chain = (int)CurrentChain.Value,

                // Preferences
                SpecificTID = TIDBOX.Checked,
                SpecificSID = SIDBOX.Checked,
                TargetTID = (ushort)TIDValue.Value,
                TargetSID = (ushort)SIDValue.Value,
                Wants_Sync = SyncBox.Checked,
                Target_Horde_HA = HASlot.SelectedIndex - 1,
                Target_Slots = SelectedSlots,
                Target_Flute = ORAS ? (int)Flute1.Value : 0,
                Target_Potential = (int)Potential.Value,

                Wants_Shiny = NavFilters.CheckBoxItems[1].Checked,
                Wants_HA = NavFilters.CheckBoxItems[2].Checked,
                Wants_EggMove = NavFilters.CheckBoxItems[3].Checked,
                Wants_Boost = NavFilters.CheckBoxItems[4].Checked,
            };

            if (!IsID)
            {
                settings.surfing = Surfing;
                settings.longGrass = LongGrass; 
                settings.currentSlots = IsHorde ? GetHordeTable1.Concat(GetHordeTable2).Concat(GetHordeTable3).ToArray() : SlotTable();
                settings.currentLevels = LevelTable();
                settings.interactMTFrame = (int)InteractFrame.Value;
                settings.longBlinkRand = EmuBox.Checked ? CurrentLocation.FirstLongBlinkRand_Emu : CurrentLocation.FirstLongBlinkRand;

                if (ORAS)
                {
                    settings.Horde_Flutes[0] = (int)Flute1.Value;
                    settings.Horde_Flutes[1] = (int)Flute2.Value;
                    settings.Horde_Flutes[2] = (int)Flute3.Value;
                    settings.Horde_Flutes[3] = (int)Flute4.Value;
                    settings.Horde_Flutes[4] = (int)Flute5.Value;
                }

                if (IsDexNav)
                {
                    settings.DNsearching = IsDexNavSrch;
                    settings.charm = CharmBox.Checked;
                    settings.searchLevel = (ushort)SearchLvl.Value;
                    settings.Wants_Sync = NavFilters.CheckBoxItems[5].Checked;
                    settings.Wants_Exclusives = AddExclusiveSlots();
                    settings.Show_Alt_EggMove = AltEggMove.Checked;
                    settings.specialSlots = GetNavTable;
                    settings.dexNavLevel = CurrentLocation.DexNavLevel;

                    if (IsDexNavSrch && AddExclusiveSlots())
                        settings.exclusives = true;
                    else
                        settings.exclusives = HasExclusives && (!Surfing || (GetWildTable == null && GetCaveTable == null && GetLongTable == null));

                    for (ushort i = 0; i < Species.SpeciesList.Count; i++)
                        if (Species.SpeciesList.ElementAt(i).Name.Equals(SpeciesCombo.SelectedItem.ToString()))
                        {
                            settings.FixedSpecies = i;
                            break;
                        }

                    switch (EncounterSettings.SelectedItem.ToString())
                    {
                        case "Grass" when CurrentLocation.Enc_Ratio != 1:   // Route 111 - Desert
                        case "Long Grass":
                            settings.maxEggRand = 2;
                            break;
                        default:
                            settings.maxEggRand = 10;
                            break;
                    }
                    if (settings.Show_Alt_EggMove)
                        settings.maxEggRand += 2;

                }
                else if (IsFriendSafari)
                {
                    settings.DexNumberFS = GetFSList.ElementAt(SpeciesCombo.SelectedIndex);
                }
                else
                {
                    settings.specialSlots = CurrentLocation.HordeTable2;
                    settings.party = (int)party.Value;
                }

                if (!IsRadar1)
                {
                    // If the user didn't selected any slots, consider them all selected.
                    // Not the best approach but may be faster when filtering.
                    if (SlotCount == 0)
                        for (int i = 1; i < 13; i++)
                            settings.Target_Slots[i] = true;
                }

            }
        }
        public async void FindTinySeed(uint Seed, uint Jump, uint[] CurrentState)
        {
            await Task.Run(() =>
            {
                while (!Calibrated)
                {
                    if (tiny.init(Seed, bootAdvances)[3] == CurrentState[3])
                        if (tiny.init(Seed, bootAdvances)[2] == CurrentState[2])
                        {
                            initial = Seed;
                            Calibrated = true;
                        }
                    Seed += Jump;
                }
            });
        }

        public void Prepare()
        {
            uint[] state = new uint[4], store_seed = new uint[4], state_hit = new uint[4];
            GenList = new List<Index>();
            SearchList = new List<Index>();

            if ((IsDexNavSrch || IsFishing) && min.Value < 1)
                min.Value = 1;

            Year = (int)year.Value;
            Min = (uint)min.Value;
            Max = (uint)max.Value;

            Choice = SelectedEncounter;
            Radar1 = IsRadar1;
            DateSearcher = SearchGen.SelectedIndex == 0;
            
            if (ReaderBTN.Checked)
            {
                initial = t3.Value;
                bootAdvances = 0;
                state = tiny.init(initial, bootAdvances);
            }
            else
            {
                state[3] = t3.Value;
                state[2] = t2.Value;
                state[1] = t1.Value;
                state[0] = t0.Value;
                bootAdvances = EnctrTypeChosen == EnctrKey.ID ? 2 : 1;
            }

            if (!DateSearcher)
                ManageColumns(Generator, Choice);
            else
            {
                ManageColumns(Searcher, Choice);
                Searcher.Columns["S_Tiny3"].Visible = Searcher.Columns["S_Tiny2"].Visible =
                    Searcher.Columns["S_Tiny1"].Visible = Searcher.Columns["S_Tiny0"].Visible = !ReaderBTN.Checked;
                Searcher.Columns["S_Tiny32"].Visible = ReaderBTN.Checked;
            }
                
            jobs = new Thread[(int)ThreadCount.Value];
            // Use the selected number of threads only for ID, Hordes, Radar and DexNav
            ThreadsUsed = (EnctrTypeChosen == EnctrKey.ID || EnctrTypeChosen == EnctrKey.Horde || 
                EnctrTypeChosen == EnctrKey.DexNavMov || EnctrTypeChosen == EnctrKey.DexNavSrch) ? (uint)jobs.Length : 1;

            if (DateSearcher)       //Calibrating the TinyMT seed depending on the user's current state at 13:00:00
            {
                Working = true;
                if (!Calibrated && !ReaderBTN.Checked)
                {
                    MainButton.Text = "Calibrating...";

                    //Each year's approximate TinyMT seed at date 20xx:01:01 can be calculated to save time in the research, see Calculate.cs
                    uint start_seed = calc.startingPoint(Year);
                    for (int i = 0; i < jobs.Length; i++)
                    {
                        jobs[i] = new Thread(() => FindTinySeed(start_seed, (uint)jobs.Length, state)); jobs[i].Start();
                        Thread.Sleep(100);
                        start_seed++;
                    }

                    //Bad Solution
                    while (!Calibrated)
                    {
                        Application.DoEvents();
                    }
                }

                MainButton.Text = "Searching...";
                StopButton.Enabled = true;

                source.DataSource = SearchList;
                Searcher.DataSource = source;
            }
            else
            {
                Working = false;    //For Generator, we need to make sure that the calculations will be done only once and only for the current state
            }

            searchMonth = Months.SelectedIndex + 1;                 //We calculate how many seconds have passed from January to the selected month,
            seconds = calc.FindSeconds(searchMonth, Year);          //then add them to find the TinyMT seed for the selected month's 1st day 
            tinyInitSeed = calc.FindMonthSeed(initial, seconds);    //and continue from there (1 second = +1000 seeds)

            if (EnctrTypeChosen != EnctrKey.ID && !IsRadar1)     //Checking which slots are checked for searching (Pointless for ID and Radar chain > 0)
            {
                try
                {
                    SelectedSlots = new bool[13];
                    SlotCount = 0;
                    for (int s = 1; s < SlotsComboBox.Items.Count; s++)
                        if (SlotsComboBox.CheckBoxItems[s].Checked)
                        {
                            SelectedSlots[s] = true;
                            SlotCount++;
                        }
                }
                catch { }   //Only occurs if change FS slots from 2 to 3 and click Generate

            }

            ApplyUISettings();

            switch (EnctrTypeChosen)
            {
                case EnctrKey.ID:

                    TargetRandID = Convert.ToUInt32(settings.TargetSID.ToString("X") + settings.TargetTID.ToString("X").PadLeft(4, '0'), 16);
                    fastID = DateSearcher && settings.SpecificTID && settings.SpecificSID;
                    break;

                case EnctrKey.Wild:

                    settings.sType = Surfing ? 4 : 0;   // For wild only
                    settings.calibration = Convert.ToInt32(CurrentLocation.NPC);
                    if (ORAS)
                    {
                        settings.possibleHorde = LongGrass;
                    }
                    else if (!Surfing && !LongGrass && !Swampy)
                    {
                        settings.possibleHorde = CurrentLocation.HasMovingHordes();
                        settings.radarGrass = CurrentLocation.HasRadar();
                    }
                    break;

                case EnctrKey.Fishing:

                    settings.sType = 3;
                  //settings.advances = (int)(party.Value * 3 + getBagAdvances() - 1);     // When use rod from bag

                    // Route 12 is excluded for now since NPC affects in different spot than wild
                    settings.advances = (int)(party.Value * 3 + CurrentLocation.NPC);

                    break;

                /*case EnctrKey.RockSmash:
                    //settings.advances = getBagAdvances();
                    //settings.advances = CurrentLocation.NPC;  // Route 12 and Route 18 only but in different spots than wild
                    break;*/

                case EnctrKey.Horde:
                case EnctrKey.Honey:

                    if (settings.moving)
                    {
                        settings.calibration = Convert.ToInt32(CurrentLocation.NPC);
                        settings.radarGrass = !ORAS && CurrentLocation.HasRadar();
                    }
                    else
                    {
                        settings.advances = (int)(party.Value * 3 + getBagAdvances() - 1);     // -1 is necessary for calculating the first blink
                        if (EmuBox.Checked)
                        {
                            settings.honeyDelay = ORAS ? 118 : 114;
                        }
                        else
                        {
                            // 114 in XY retail connection cave
                            // 120 in XY retail route 5?
                            // 122 in XY retail route 7
                            // 112-114 in Azure Bay?

                            if (getBagAdvances() == 3)
                            {
                                settings.honeyDelay = ORAS ? 120 : 110;     // ORAS 120, 120, 120, 
                            }
                            else
                            {
                                settings.honeyDelay = ORAS ? 126 : 112;     // 114, 110, 112, 112,  ORAS 126, 122, 126, 126, 128?
                            }

                        }
                        if (IsHoney)
                            settings.sType = Surfing ? 4 : 0;
                    }

                    break;

                case EnctrKey.Radar:

                    settings.advances = settings.party * 3 + 27;
                    break;

                case EnctrKey.DexNavMov:
                case EnctrKey.DexNavSrch:

                    settings.calibration = EncounterSettings.SelectedItem.ToString().Equals("Cave") ? 2 : 0;
                    settings.sType = Surfing ? 1 : 0;
                    settings.TargetValue = DexNav.GetTargetValue(settings.searchLevel);
                    settings.Grade = DexNav.GetGrade(settings.searchLevel);
                    break;

                case EnctrKey.FS:

                    settings.sType = EncounterSettings.SelectedIndex + 1;   // If 3rd slot is unlocked -> type = 2. If not, -> type = 1
                    break;
            }

            if (DateSearcher)
            {
                for (int i = 0; i < ThreadsUsed; i++)
                {
                    uint[] localState = (uint[])state.Clone();
                    jobs[i] = new Thread(() => 
                    {
                        StartResearch(localState, ThreadsUsed);
                    });
                    jobs[i].Start();
                    Thread.Sleep(100);
                    tinyInitSeed += 1000;
                    seconds++;
                }
            }
            else
            {
                StartResearch(state, 0);
                Generator.DataSource = GenList;
            }

        }


        private void StartResearch(uint[] CurrentState, uint Jump)
        {
            Index index;
            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;
            
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);

                if (IsDexNavSrch)
                {
                    for (uint i = 0; i < Min - 1; i++)      // We need -1 in order to calculate the 1st long blink cycle
                        tiny.nextState(CurrentState);
                }
                else
                {
                    for (uint i = 0; i < Min; i++)
                        tiny.nextState(CurrentState);
                }

                for (uint i = Min; i <= Max; i++)
                {
                    switch (EnctrTypeChosen)
                    {
                        case EnctrKey.ID:
                            if (tiny.temper(CurrentState) == TargetRandID && fastID)
                            {
                                index = new ID(CurrentState, false);
                                AddtoList(TinySeed, index, i - 1, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            else if (!fastID)
                            {
                                index = new ID(CurrentState, true);
                                if (settings.CheckID(index) || NoFilters)
                                    AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            break;

                        case EnctrKey.Wild:
                        //case EnctrKey.Fishing:
                        case EnctrKey.RockSmash:
                        case EnctrKey.FS:

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, true) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.Fishing:

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, true) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.Horde:

                            index = new Horde(CurrentState, settings);
                            if (settings.CheckHorde(index, settings.moving, settings.oras) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.Honey:

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, false) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.Radar:

                            index = new Radar(CurrentState, settings);
                            if (settings.CheckRadar(index, settings.chain) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.DexNavMov:

                            index = new DexNav(CurrentState, settings);
                            if (settings.CheckDexNav(index) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.DexNavSrch:
                            index = new DexNav(CurrentState, settings);
                            if (settings.CheckDexNav(index) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, tiny.NextState(CurrentState.ToArray()), calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case EnctrKey.Ambush:

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, false) || NoFilters)
                                AddtoList(TinySeed, index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                    }

                    tiny.nextState(CurrentState);

                }

                TotalSeconds += Jump;
                TinySeed += Jump * 1000;
                CurrentState = tiny.init(TinySeed, bootAdvances);

            }
            while (Working);
            Invoke(new Action(() => { Finished(); }));
        }


        private void AddtoList(uint TinySeed, Index index, uint CurrentIndex, uint[] InitialState, uint[] TinyState, string rtc)
        {
            if (EnctrTypeChosen != EnctrKey.ID && !Radar1)
                index = PrepareRow.Prepare(index, settings);

            if (index.risky && !NoFilters)
                return;

            index.IndexValue = CurrentIndex;

            if (DateSearcher)
            {
                index.RTC = rtc;
                index.InitTiny32 = TinySeed;
                index.Tiny3 = InitialState[3];
                index.Tiny2 = InitialState[2];
                index.Tiny1 = InitialState[1];
                index.Tiny0 = InitialState[0];
                SearchList.Add(index);
                Thread.Sleep(50);
                Invoke(new Action(() =>
                {
                    int scrollPosition = Searcher.FirstDisplayedScrollingRowIndex;
                    source.ResetBindings(false);
                    try
                    {
                        Searcher.FirstDisplayedScrollingRowIndex = scrollPosition;
                    }
                    catch
                    {
                        //Searcher.FirstDisplayedScrollingRowIndex = 0;
                    }
                }));
            }
            else
            {
                index.Tiny3 = TinyState[3];
                index.Tiny2 = TinyState[2];
                index.Tiny1 = TinyState[1];
                index.Tiny0 = TinyState[0];
                GenList.Add(index);
            }   
        }
    }
}