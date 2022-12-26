using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using TinyFinder.Main;

namespace TinyFinder
{
    public partial class Form1
    {
        int Year, TotalRandCalls;
        uint tinyInitSeed, seconds, initial = 0, Min, Max;
        byte searchMonth, SlotCount;
        bool DateSearcher, fastID;
        byte bootAdvances;

        byte MethodUsed;
        bool Calibrated = false, Working, NoFilters, Nav, Radar1;

        BindingSource source = new BindingSource();
        UISettings settings;
        List<Index> GenList = new List<Index>();
        List<Index> SearchList = new List<Index>();

        // Values for UI controls
        uint TargetRand;

        Thread[] jobs;
        uint ThreadsUsed;

        public void ApplyUISettings()
        {
            settings = new UISettings()
            {
                // UI Settings
                oras = ORAS,
                bonusMusic = BonusMusicBox.Checked,
                moving = MovingHordeOption,
                fishingRod = (byte)EncounterType.SelectedIndex,
                fluteOption = (byte)(ORAS ? FluteOption.SelectedIndex : 0),
                citra = CitraBox.Checked,
                ratio = (byte)ratio.Value,
                chain = (byte)ratio.Value,  // Different variable to avoid confusion

                // Side Settings
                triggerOnly = DateSearcher || !NoFilters,
                method = MethodUsed,


                // Preferences
                SpecificTID = TIDBOX.Checked,
                SpecificSID = SIDBOX.Checked,
                TargetTID = (ushort)tid.Value,
                TargetSID = (ushort)sid.Value,
                Wants_Sync = SyncBox.Checked,
                Target_Horde_HA = (sbyte)(HASlot.SelectedIndex - 1),
                Target_Slots = SelectedSlots,
                Target_Flute = ORAS ? (int)Flute1.Value : 0,
                Target_Potential = (int)Potential.Value,

                Wants_Shiny = NavFilters.CheckBoxItems[1].Checked,
                Wants_HA = NavFilters.CheckBoxItems[2].Checked,
                Wants_EggMove = NavFilters.CheckBoxItems[3].Checked,
                Wants_Boost = NavFilters.CheckBoxItems[4].Checked,
            };

            if (Method != 0)
            {
                settings.surfing = Surfing;
                settings.longGrass = LongGrass; 
                settings.currentSlots = SlotTable();
                settings.currentLevels = LevelTable();

                if (ORAS)
                {
                    settings.Horde_Flutes[0] = (byte)Flute1.Value;
                    settings.Horde_Flutes[1] = (byte)Flute2.Value;
                    settings.Horde_Flutes[2] = (byte)Flute3.Value;
                    settings.Horde_Flutes[3] = (byte)Flute4.Value;
                    settings.Horde_Flutes[4] = (byte)Flute5.Value;
                }

                if (IsDexNav)
                {
                    settings.charm = CharmBox.Checked;
                    settings.noise = (byte)noise.Value;
                    settings.searchLevel = (ushort)party.Value;
                    settings.Wants_Sync = NavFilters.CheckBoxItems[5].Checked;
                    settings.exclusives = HasExclusives;
                    settings.sType = (byte)(Surfing ? 1 : 0);
                    settings.Wants_Exclusives = checkExclusives();
                    settings.specialSlots = GetNavTable;
                    settings.dexNavLevel = CurrentLocation.DexNavLevel;
                }
                else if (Method == 7)
                {
                    settings.DexNumberFS = GetFSList.ElementAt(SpeciesCombo.SelectedIndex);
                }
                else
                {
                    settings.specialSlots = CurrentLocation.HordeTable2;
                    settings.party = (byte)party.Value;
                }

                if (!isRadar1)
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
            TinyMT tiny = new TinyMT();
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

            state[3] = t3.Value;
            state[2] = t2.Value;
            state[1] = t1.Value;
            state[0] = t0.Value;

            Year = (int)year.Value;
            Min = (uint)min.Value;
            Max = (uint)max.Value;

            MethodUsed = (byte)Methods.SelectedIndex;
            Nav = IsDexNav;
            Radar1 = isRadar1;
            DateSearcher = SearchGen.SelectedIndex == 0;
            bootAdvances = (byte)(MethodUsed == 0 ? 2 : 1);

            if (!DateSearcher)
                ManageColumns(Generator, MethodUsed);
            else
                ManageColumns(Searcher, MethodUsed);

            jobs = new Thread[(int)ThreadCount.Value];
            // Use the selected number of threads only for ID, Hordes, Radar and DexNav
            ThreadsUsed = (MethodUsed == 0 || MethodUsed == 4 || MethodUsed == 6) ? (uint)jobs.Length : 1;

            if (DateSearcher)       //Calibrating the TinyMT seed depending on the user's currnet state at 13:00:00
            {
                Working = true;
                if (!Calibrated)
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

            searchMonth = (byte)(Months.SelectedIndex + 1);         //We calculate how many seconds have passed from January to the selected month,
            seconds = calc.FindSeconds(searchMonth, Year);          //then add them to find the TinyMT seed for the selected month's 1st day 
            tinyInitSeed = calc.FindMonthSeed(initial, seconds);    //and continue from there (1 second = +1000 seeds)

            if (MethodUsed != 0 && !isRadar1)     //Checking which slots are checked for searching (Pointless for ID and Radar chain 1)
            {
                try
                {
                    SelectedSlots = new bool[13];
                    SlotCount = 0;
                    for (byte s = 1; s < SlotsComboBox.Items.Count; s++)
                        if (SlotsComboBox.CheckBoxItems[s].Checked)
                        {
                            SelectedSlots[s] = true;
                            SlotCount++;
                        }
                }
                catch { }   //Only occurs if change FS slots from 2 to 3 and click Generate

            }

            ApplyUISettings();

            switch (MethodUsed)
            {
                case 0:     // ID

                    TargetRand = Convert.ToUInt32(settings.TargetSID.ToString("X") + settings.TargetTID.ToString("X").PadLeft(4, '0'), 16);
                    fastID = DateSearcher && settings.SpecificTID && settings.SpecificSID;
                    //TotalRandCalls = 1;
                    break;

                case 1:     // Wild

                    settings.sType = (byte)(Surfing ? 4 : 0);   // For wild only
                    settings.noise = Convert.ToByte(CurrentLocation.NPC);
                    if (ORAS)
                    {
                        settings.movingHordes = LongGrass;
                    }
                    else if (!Surfing && !LongGrass && !Swampy)
                    {
                        settings.movingHordes = CurrentLocation.HasMovingHordes();
                        settings.radarGrass = CurrentLocation.HasRadar();
                    }
                    //TotalRandCalls = settings.noise + 7;
                    break;

                case 2:     // Fishing

                    settings.advances = (byte)(party.Value * 3 + (BagBox.Checked ? CurrentLocation.Bag_Advances : 0));
                    settings.delayRand = CitraBox.Checked ? CurrentLocation.CitraDelayRand : CurrentLocation.ConsoleDelayRand;
                    settings.targetFrame = (int)FishingFrame.Value;
                    settings.gameCorrection = !ORAS ? (settings.citra ? 144 : 146) : (settings.citra ? CurrentLocation.CitraORASCorr : CurrentLocation.ConsoleORASCorr);
                    //TotalRandCalls = settings.advances + 20;
                    break;

                case 3:     // Rock Smash
                case 8:     // Swooping
                    TotalRandCalls = 6;
                    break;

                case 4:     // Horde

                    if (settings.moving)
                    {
                        settings.noise = Convert.ToByte(CurrentLocation.NPC);
                        settings.radarGrass = !ORAS && CurrentLocation.HasRadar();
                        TotalRandCalls = settings.noise + 18;
                    }
                    else
                    {
                        settings.advances = (byte)(party.Value * 3 + CurrentLocation.Bag_Advances);
                        TotalRandCalls = settings.advances + 15;
                    }
                    if (ORAS)
                        TotalRandCalls += 5;    // Flutes

                    break;

                case 5:     // Honey Wild

                    settings.sType = (byte)(Surfing ? 4 : 0);
                    settings.advances += (byte)(party.Value * 3 + CurrentLocation.Bag_Advances);
                    //TotalRandCalls = settings.advances + 5;
                    break;

                case 6:     // Radar / DexNav

                    if (IsDexNav)
                    {
                        TotalRandCalls = settings.noise + 35;
                        if (ratio.Value == 49 || ratio.Value == 99)
                            TotalRandCalls += 10;

                        if (settings.searchLevel > 200)
                            settings.TargetValue = settings.searchLevel + 600;
                        else if (settings.searchLevel > 100)
                            settings.TargetValue = 2 * settings.searchLevel + 400;
                        else
                            settings.TargetValue = 6 * settings.searchLevel;

                        if (settings.searchLevel < 5)
                            settings.Grade = 0;
                        else if (settings.searchLevel < 10)
                            settings.Grade = 1;
                        else if (settings.searchLevel < 25)
                            settings.Grade = 2;
                        else if (settings.searchLevel < 50)
                            settings.Grade = 3;
                        else if (settings.searchLevel < 100)
                            settings.Grade = 4;
                        else
                            settings.Grade = 5;
                    }
                    else
                    {
                        settings.advances = (byte)(settings.party * 3 + (BagBox.Checked ? 27 : 0));
                        TotalRandCalls = settings.advances + 24;
                    }
                    break;

                case 7:     // Friend Safari

                    settings.sType = (byte)(EncounterType.SelectedIndex + 1);   // If 3rd slot is unlocked -> type = 2. If not, -> type = 1
                    //TotalRandCalls = settings.noise + settings.advances + 5;
                    break;
            }

            if (DateSearcher)
            {
                for (int i = 0; i < ThreadsUsed; i++)
                {
                    jobs[i] = new Thread(() => 
                    {
                        if (MethodUsed == 4 || MethodUsed == 6) // Hordes / Radar / DexNav
                            FastSearch(state, ThreadsUsed);
                        else
                            StartResearch(state, ThreadsUsed);
                    });
                    jobs[i].Start();
                    Thread.Sleep(100);
                    tinyInitSeed += 1000;
                    seconds++;
                }
            }
            else
            {
                if (MethodUsed == 4 || MethodUsed == 6) // Hordes / Radar / DexNav
                    FastSearch(state, 0);
                else
                    StartResearch(state, 0);

                Generator.DataSource = GenList;
            }

        }

        // This is only used for Hordes and Radar / DexNav.
        // Instead of calculating the new TinyMT state every time, we store some of them in an array and take them from there.
        // Each Hordes/DexNav index has a lot of rand calls so this approach makes the process way faster.
        // ID has only 1 though so it would become slower instead.
        // Code is far from being optimized. Fix later
        private void FastSearch(uint[] CurrentState, uint Jump)
        {
            Index index;
            List<uint> rngList = new List<uint>();
            TinyMT tiny = new TinyMT();
            
            uint[] StoreSeed = new uint[4];
            uint[] StoreState = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            do
            {
                /*List<uint[]> States = new List<uint[]>();
                for (uint i = 0; i <= Max; i++)
                    States.Add(tiny.NextState(CurrentState));
                for (uint i = Min; i < Min + 20; i++)
                    rngList.Add(tiny.Nextuint(States[(int)i]));*/

                rngList.Clear();

                CurrentState.CopyTo(StoreSeed, 0);          // This is the TinyMT seed, necessary for Date Searcher
                for (uint i = 0; i < Min; i++)
                    tiny.nextState(CurrentState);

                // Not the best approach but saves a lot of time
                if (!DateSearcher)
                    CurrentState.CopyTo(StoreState, 0);     // This is the actual TinyMT state, necessary for Generator
                for (int i = 0; i < TotalRandCalls; i++)
                    rngList.Add(tiny.Nextuint(CurrentState));

                for (uint i = Min; i <= Max; i++, rngList.RemoveAt(0))
                {
                    switch (MethodUsed)
                    {
                        case 6:     // DexNav / Radar

                            if (Nav)
                            {
                                index = new DexNav(rngList, settings);
                                if (settings.CheckDexNav(index) || NoFilters)
                                    AddtoList(index, i, StoreSeed, StoreState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            else
                            {
                                index = new Radar(rngList, settings);
                                if (settings.CheckRadar(index, settings.chain) || NoFilters)
                                {
                                    AddtoList(index, i, StoreSeed, StoreState, calc.secondsToDate(TotalSeconds, Year));
                                }
                            }
                            break;

                        case 4:     // Horde

                            index = new Horde(rngList, settings);
                            if (settings.CheckHorde(index, settings.moving, settings.oras) || NoFilters)
                            {
                                index.HordeFlutes = string.Join(", ", index.flutes.Select(f => f.ToString()));
                                index.item = string.Join(", ", index.itemSlots.Select(f => f.ToString()));
                                AddtoList(index, i, StoreSeed, StoreState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            break;
                    }

                    tiny.nextState(StoreState);
                    rngList.Add(tiny.Nextuint(CurrentState));
                }

                TotalSeconds += Jump;
                TinySeed += 1000 * Jump;
                CurrentState = tiny.init(TinySeed, bootAdvances);

            }
            while (Working);
            Invoke(new Action(() => { Finished(); }));
        }


        // This is the old approach. Run faster with ID, but is way slower for anything else.
        // Extra speed is pointless though, since even the most rare possible index, is being found instantly.
        private void StartResearch(uint[] CurrentState, uint Jump)
        {
            Index index;
            TinyMT tiny = new TinyMT();
            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;
            
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint i = 0; i < Min; i++)
                    tiny.nextState(CurrentState);

                for (uint i = Min; i <= Max; i++)
                {
                    switch (MethodUsed)
                    {
                        case 0:     // ID
                            if (tiny.temper(CurrentState) == TargetRand && fastID)
                            {
                                index = new ID(CurrentState, false);
                                AddtoList(index, i - 1, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            else if (!fastID)
                            {
                                index = new ID(CurrentState, true);
                                if (settings.CheckID(index) || NoFilters)
                                    AddtoList(index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            }
                            break;

                        case 1:     // Normal Wild
                        case 3:     // Rock Smash
                        case 7:     // Friend Safari

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, true) || NoFilters)
                                AddtoList(index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case 2:     // Fishing

                            index = new Fishing(CurrentState, settings);
                            if (settings.CheckCommon(index, true) || NoFilters)
                                AddtoList(index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case 5:     // Honey Wild

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, false) || NoFilters)
                                AddtoList(index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                        case 8:     // Swooping

                            index = new Wild(CurrentState, settings);
                            if (settings.CheckCommon(index, false) || NoFilters)
                                AddtoList(index, i, StoreSeed, CurrentState, calc.secondsToDate(TotalSeconds, Year));
                            break;

                    }

                    tiny.nextState(CurrentState);
                }

                TotalSeconds += Jump;
                TinySeed += 1000 * Jump;
                CurrentState = tiny.init(TinySeed, bootAdvances);

            }
            while (Working);
            Invoke(new Action(() => { Finished(); }));
        }


        private void AddtoList(Index index, uint CurrentIndex, uint[] InitialState, uint[] TinyState, string rtc)
        {
            if (MethodUsed != 0 && !Radar1)
                index = PrepareIndex.Prepare(index, settings);
            index.IndexValue = CurrentIndex;

            if (DateSearcher)
            {
                index.RTC = rtc;
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