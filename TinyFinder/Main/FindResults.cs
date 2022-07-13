using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TinyFinder
{
    public partial class Form1
    {
        int Year;
        uint tinyInitSeed, seconds, initial = 0, Min, Max;
        byte searchMonth, SlotLimit, SlotCount;
        byte NPC_Noise = 0, CurrentLocation = 0, advances = 0;
        bool DateSearcher, HasHordes, Is_XY_TallGrass = false;
        string HordeFlutes;

        byte[] fluteArray = { 0, 0, 0, 0, 0 };
        public void StartSearch()
        {
            uint[] state = new uint[4], store_seed = new uint[4], state_hit = new uint[4];
            table = new DataTable();

            state[3] = t3.Value;
            state[2] = t2.Value;
            state[1] = t1.Value;
            state[0] = t0.Value;

            Year = (int)year.Value;
            Min = (uint)min.Value;
            Max = (uint)max.Value;

            MethodUsed = (byte)Methods.SelectedIndex;
            DateSearcher = SearchGen.SelectedIndex == 0;

            var jobs = new Thread[(int)ThreadCount.Value];

            if (DateSearcher)       //Calibrating the TinyMT seed depending on the user's currnet state at 13:00:00
            {
                Working = true;
                Searcher.Rows.Clear();
                ManageSearcher(ref Searcher, MethodUsed);
                Searcher.Update();

                byte bootAdvances = (byte)(MethodUsed == 0 ? 2 : 1);    //If there is no save data (lang select screen), TinyMT state advances by 2
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
            }
            else
            {
                Working = false;    //For Generator, we need to make sure that the calculations will be done only once and only for the current state
                ManageGenColumns(ref table, MethodUsed);
            }

            searchMonth = (byte)(Months.SelectedIndex + 1);         //We calculate how many seconds have passed from January to the selected month,
            seconds = calc.FindSeconds(searchMonth, Year);          //then add them to find the TinyMT seed for the selected month's 1st day 
            tinyInitSeed = calc.FindMonthSeed(initial, seconds);    //and continue from there (1 second = +1000 seeds)

            if (MethodUsed != 0 && !isRadar1())     //Checking which slots are checked for searching (Pointless for ID and Radar chain 1)
            {
                SlotLimit = 0;
                switch (MethodUsed)
                {
                    case 1: case 8: SlotLimit = 13; break;
                    case 2: case 4: SlotLimit = 4; break;
                    case 3: SlotLimit = 6; break;
                    case 5:
                        SlotLimit = (byte)(SurfBox.Checked ? 6 : 13);
                        break;
                    case 6:
                        SlotLimit = 13;
                        if (ORAS_Button.Checked)
                        {
                            if (NavType.SelectedIndex == 1)
                                SlotLimit = 4;
                            else
                                if (SurfBox.Checked)
                                SlotLimit = 6;
                        }
                        break;
                    case 7:
                        SlotLimit = (byte)(party.Value == 2 ? 3 : 4);
                        break;
                }
                Slots = new HashSet<byte>();
                try
                {
                    for (byte s = 1; s < SlotLimit; s++)
                        if (SlotsComboBox.CheckBoxItems[s].Checked)
                            Slots.Add(s);
                }
                catch { }   //Only occurs if change FS slots from 2 to 3 and click Generate
                
                SlotCount = (byte)Slots.Count;
            }

            //Getting the Noise for each place, also if is XY tall grass and if has moving horde, because the results are affected
            if (MethodUsed == 1 || (MethodUsed == 4 && Horde_Turn.Checked))     //Normal Wild / Moving Horde
            {
                CurrentLocation = (byte)locations.SelectedIndex;
                NPC_Noise = (byte)(CaveBox.Checked ? 0 : Convert.ToByte(Locations[CurrentLocation].NPC));
                HasHordes = (XY_Button.Checked && (CaveBox.Checked || Locations[CurrentLocation].Has_Hordes))
                    || (ORAS_Button.Checked && LongGrassBox.Checked && !CaveBox.Checked);
                Is_XY_TallGrass = XY_Button.Checked && !CaveBox.Checked && Locations[CurrentLocation].Tall_Grass;
            }
            else if (MethodUsed == 2 || MethodUsed == 7)                        //Fishing / Friend Safari have nothing
            {
                NPC_Noise = 0;
                HasHordes = Is_XY_TallGrass = false;
            }

            switch (MethodUsed)
            {
                case 0:     //ID
                    if (DateSearcher)
                    {
                        for (int i = 0; i < jobs.Length; i++)
                        {
                            jobs[i] = new Thread(() => IDSearch((ushort)tid.Value, (ushort)sid.Value, (uint)jobs.Length, state));
                            jobs[i].Start();
                            Thread.Sleep(100);
                            tinyInitSeed += 1000;
                            seconds++;
                        }
                    }
                    else
                        IDSearch((ushort)tid.Value, (ushort)sid.Value, 1, state);

                    break;

                case 1:     //Normal Wild
                case 2:     //Fishing
                case 7:     //Friend Safari
                    
                    Rand100Column = XY_Button.Checked && !DateSearcher ? 4 : 5;    //Searcher has the flute column for both XY and ORAS
                                                                                   //Generator has it only for ORAS
                    if (DateSearcher) new Thread(() =>
                    {
                        if (MethodUsed == 2)
                            FishingSearch(state);
                        else
                            WildSearch(state);
                    }).Start();
                    else 
                    {
                        if (MethodUsed == 2)
                            FishingSearch(state);
                        else
                            WildSearch(state);
                    };
                    break;

                case 3:     //Rock Smash
                    
                    if (DateSearcher) new Thread(() => RockSmashSearch(state)).Start();
                    else RockSmashSearch(state);
                    break;

                case 4:     //Horde
                    int DesiredHA = HASlot.SelectedIndex;
                    Rand100Column = XY_Button.Checked ? 5 : 6;
                    
                    if (ORAS_Button.Checked)
                    {
                        fluteArray[0] = (byte)Flute1.Value;
                        fluteArray[1] = (byte)Flute2.Value;
                        fluteArray[2] = (byte)Flute3.Value;
                        fluteArray[3] = (byte)Flute4.Value;
                        fluteArray[4] = (byte)Flute5.Value;
                    }

                    if (!Horde_Turn.Checked)
                        advances = (byte)((3 * party.Value) + (CaveBox.Checked ? 3 : Convert.ToByte(Locations[(byte)locations.SelectedIndex].Bag_Advances)));

                    if (DateSearcher)
                    {
                        for (int i = 0; i < jobs.Length; i++)
                        {
                            jobs[i] = new Thread(() => HordeSearch(DesiredHA, (uint)jobs.Length, state));
                            jobs[i].Start();
                            Thread.Sleep(100);
                            tinyInitSeed += 1000;
                            seconds++;
                        }
                    }
                    else
                        HordeSearch(DesiredHA, 1, state);

                    break;

                case 5:     //Honey Wild
                    
                    if (CaveBox.Checked)
                        advances = 3;
                    else
                    {
                        if (XY_Button.Checked)
                            advances = 27;
                        else
                            advances = (byte)(locations.Visible ? Convert.ToByte(Locations[(byte)locations.SelectedIndex].ratio) : 15);
                    }
                    advances += (byte)(party.Value * 3);

                    if (DateSearcher) new Thread(() => HoneySearch(state)).Start();
                    else HoneySearch(state);
                    break;

                case 6:     //Radar / DexNav

                    if (Equals(Methods.Items[6], "Radar"))
                    {
                        if (DateSearcher)
                            SPatchSpots.Clear();
                        else
                            GPatchSpots.Clear();

                        advances = (byte)(ratio.Value == 0 ? 0 : (party.Value * 3 + (BagBox.Checked ? 27 : 0)));

                        if (DateSearcher) new Thread(() => RadarSearch(state)).Start();
                        else RadarSearch(state);

                    }
                    else
                    {
                        bool W_Exclusives = NavType.SelectedIndex == 1;
                        bool W_Shiny = NavFilters.CheckBoxItems[1].Checked;
                        bool W_HA = NavFilters.CheckBoxItems[2].Checked;
                        bool W_EggMove = NavFilters.CheckBoxItems[3].Checked;
                        bool W_Boost = NavFilters.CheckBoxItems[4].Checked;
                        bool W_Sync = NavFilters.CheckBoxItems[5].Checked;

                        if (DateSearcher)
                        {
                            for (int i = 0; i < jobs.Length; i++)
                            {
                                jobs[i] = new Thread(() => DexNavSearch(W_Exclusives, W_Shiny, W_HA, W_EggMove, W_Boost, W_Sync, (uint)jobs.Length, state));

                                jobs[i].Start();
                                Thread.Sleep(100);
                                tinyInitSeed += 1000;
                                seconds++;
                            }
                        }
                        else
                            DexNavSearch(W_Exclusives, W_Shiny, W_HA, W_EggMove, W_Boost, W_Sync, 1, state);

                    }
                    break;

                case 8:     //Swooping

                    if (DateSearcher) new Thread(() => SwoopingSearch(state)).Start();
                    else SwoopingSearch(state);
                    break;
            }

            if (!DateSearcher)
            {
                MainButton.Enabled = true;
                string M = isRadar1() ? "Radar1" : Methods.Text;
                ManageGenerator(Generator, table, M);
            }
            
        }

        public async void FindTinySeed(uint Seed, uint Jump, uint[] CurrentState)
        {
            TinyMT tiny = new TinyMT();
            byte bootAdvances = (byte)(MethodUsed == 0 ? 2 : 1);
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


        #region ID
        public void IDSearch(ushort tid, ushort sid, uint Jump, uint[] state)
        {
            ID id = new ID(tid, sid); TinyMT tiny = new TinyMT();
            uint[] StoreSeed = new uint[4];
            uint randID = id.randhex, TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                state = tiny.init(TinySeed, 2);
            do
            {
                state.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(state);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    if (randID == tiny.temper(state) && DateSearcher)
                    {
                        Invoke(new Action(() =>
                        {
                            Searcher.Rows.Add(calc.secondsToDate(TotalSeconds, Year),
                            hex(StoreSeed[3]), hex(StoreSeed[2]), hex(StoreSeed[1]), hex(StoreSeed[0]),
                            Index - 1, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                            id.TSV.ToString().PadLeft(4, '0'), id.TRV.ToString("X"), hex(id.randhex));
                        }));
                    }
                    else if (!DateSearcher)
                    {
                        id.GenerateIndex(state);
                        if ((id.trainerID == tid && id.secretID == sid) || filters)
                        {
                            table.Rows.Add(Index, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                id.TSV.ToString().PadLeft(4, '0'), id.TRV.ToString("X"), hex(id.randhex), hex(state[3]), hex(state[2]),
                                hex(state[1]), hex(state[0]));
                        }
                    }
                    tiny.nextState(state);
                }
                TotalSeconds += Jump; TinySeed += 1000 * Jump;
                state = tiny.init(TinySeed, 2);
            }
            while (Working);
        }
        #endregion


        #region Wild
        public void WildSearch(uint[] CurrentState)
        {
            Wild wild = new Wild()
            {
                ratio = (byte)ratio.Value,
                oras = ORAS_Button.Checked,
                slotType = (byte)(MethodUsed == 1 ? 0 : MethodUsed == 2 ? 3 : MethodUsed == 7 && party.Value == 2 ? 1 : 2),
                Noise = NPC_Noise,
                CanStepHorde = HasHordes,
                XY_TallGrass = Is_XY_TallGrass,
            };
            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    wild.GenerateIndex(CurrentState);
                    if (!filters)
                    {
                        if (wild.trigger && (Slots.Contains(wild.slot) || SlotCount == 0) && (wild.Sync || !SyncBox.Checked))
                        {
                            if (XY_Button.Checked || Flute1.Value == wild.flute || Flute1.Value == 0)
                            {
                                if (DateSearcher)
                                    ShowWildSrch(wild, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                                else
                                    ShowWildGen(table, wild, CurrentState, Index);
                            }
                        }
                    }
                    else
                        ShowWildGen(table, wild, CurrentState, Index);

                    tiny.nextState(CurrentState);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } while (Working);
        }
        private void ShowWildSrch(Wild wild, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, wild.encounter, wild.Sync, wild.slot, wild.flute, wild.rand100);
            }));
        }
        private void ShowWildGen(DataTable table, Wild wild, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, wild.encounter, wild.Sync.ToString(), wild.slot, wild.flute, wild.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, wild.encounter, wild.Sync.ToString(), wild.slot, wild.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion


        #region Fishing
        public void FishingSearch(uint[] CurrentState)
        {
            Fishing fish = new Fishing();
            Invoke(new Action(() =>
            {
                fish = new Fishing()
                {
                    Ratio_Fishing = (byte)ratio.Value,
                    ORAS_Fishing = ORAS_Button.Checked,
                    party = (byte)party.Value,
                    TargetFrame = (int)FishingFrame.Value,
                    Advances = (byte)(party.Value * 3 + (BagBox.Checked ? Locations[locations.SelectedIndex].Bag_Advances : 0)),
                    SystemDelay = (ushort)(CitraBox.Checked ? 1 : 0),  //14/18 for 3ds?

                    DelayRand = CitraBox.Checked ? Locations[locations.SelectedIndex].CitraDelayRand : Locations[locations.SelectedIndex].ConsoleDelayRand,

                    GameCorrection = XY_Button.Checked ? (CitraBox.Checked ? 144 : 146) :
                (CitraBox.Checked ? Locations[locations.SelectedIndex].CitraORASCorr : Locations[locations.SelectedIndex].ConsoleORASCorr),
                };
            }));

            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    fish.SetTimeLine(CurrentState);
                    if (!filters)
                    {
                        if (fish.trigger && (Slots.Contains(fish.slot) || SlotCount == 0) && (fish.Sync || !SyncBox.Checked))
                        {
                            if (XY_Button.Checked || Flute1.Value == fish.flute || Flute1.Value == 0)
                            {
                                if (DateSearcher)
                                    ShowFishingSrch(fish, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                                else
                                    ShowFishingGen(table, fish, CurrentState, Index);
                            }
                        }
                    }
                    else
                        ShowFishingGen(table, fish, CurrentState, Index);

                    tiny.nextState(CurrentState);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } while (Working);
        }
        private void ShowFishingSrch(Fishing fish, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, fish.encounter, fish.Sync, fish.slot, fish.ActualDelay, fish.timeline, fish.flute, fish.rand100);
            }));
        }
        private void ShowFishingGen(DataTable table, Fishing fish, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, fish.encounter, fish.Sync.ToString(), fish.slot, fish.ActualDelay, fish.timeline, fish.flute, fish.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, fish.encounter, fish.Sync.ToString(), fish.slot, fish.ActualDelay, fish.timeline, fish.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        #endregion


        #region Rock Smash
        public void RockSmashSearch(uint[] CurrentState)
        {
            Wild smash = new Wild()
            {
                oras = ORAS_Button.Checked
            };
            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    smash.RockSmash(CurrentState);
                    if ((smash.encounter == 0 && (Slots.Contains(smash.slot) || SlotCount == 0) && (smash.Sync || !SyncBox.Checked)
                            &&
                            (XY_Button.Checked || Flute1.Value == smash.flute || Flute1.Value == 0)) || filters)
                    {
                        if (DateSearcher)
                            ShowSmashSrch(smash, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                        else
                            ShowSmashGen(table, smash, CurrentState, Index);
                    }
                    tiny.nextState(CurrentState);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } 
            while (Working);
        }
        private void ShowSmashSrch(Wild smash, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index,
                   smash.encounter, smash.Sync, smash.slot, smash.flute, smash.rand100);
            }));
        }
        private void ShowSmashGen(DataTable table, Wild smash, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, smash.encounter, smash.Sync.ToString(), smash.slot, smash.flute, smash.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, smash.encounter, smash.Sync.ToString(), smash.slot, smash.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion


        #region Horde
        public void HordeSearch(int DesiredHA, uint Jump, uint[] CurrentState)
        {
            TinyMT tiny = new TinyMT();
            Horde horde = new Horde()
            {
                oras = ORAS_Button.Checked,
                ratio = (byte)ratio.Value,
                NPC = NPC_Noise,
                XY_TallGrass = Is_XY_TallGrass,
                trigger = !Horde_Turn.Checked,
                Trigger_only = DateSearcher || !filters,
            };
            uint[] StoreSeed = new uint[4], StateHit = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(tinyInitSeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);

                CurrentState.CopyTo(StateHit, 0);

                for (byte TempIndex = 0; TempIndex < advances; TempIndex++)
                    tiny.nextState(StateHit);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    if (Horde_Turn.Checked)
                        horde.HordeTurn(CurrentState);
                    else
                        horde.HordeHoney(StateHit);

                    if (!filters)
                    {
                        if ((Slots.Contains(horde.slot) || SlotCount == 0) && horde.trigger)
                            if (((Enumerable.Range(2, 6).Contains(DesiredHA)
                                && horde.HA == DesiredHA - 1)                //Seach for HA in specific slot

                                || (DesiredHA == 1 && horde.HA != 0)         //Search for HA in any slot
                                || DesiredHA == 0)                           //Don't search for HA

                                &&

                                (horde.sync || !SyncBox.Checked))
                                ShowHorde(table, horde, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index, CurrentState, 0);
                    }
                    else
                        ShowHorde(table, horde, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index, CurrentState, 0);

                    tiny.nextState(CurrentState); tiny.nextState(StateHit);
                }
                TotalSeconds += Jump; TinySeed += 1000 * Jump;
                CurrentState = tiny.init(TinySeed, 1);
            }
            while (Working);
        }
        private void ShowHorde(DataTable table, Horde horde, string date, uint[] store_seed, uint index, uint[] state, byte FluteHordeCount)
        {
            if (DateSearcher)
            {
                if (ORAS_Button.Checked)
                {
                    for (byte f = 0; f < 5; f++)
                    {
                        if (fluteArray[f] == horde.flutes[f] || fluteArray[f] == 0)
                            FluteHordeCount++;
                    }
                    if (FluteHordeCount == 5)
                    {
                        HordeFlutes = string.Join(", ", horde.flutes.Select(f => f.ToString()));
                        Invoke(new Action(() =>
                        {
                            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                               index, horde.encounter, horde.sync, horde.slot, horde.HA, HordeFlutes, horde.rand100);
                        }));
                    }
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index,
                        horde.encounter, horde.sync, horde.slot, horde.HA, horde.sync, horde.rand100);
                    }));
                }
            }
            else
            {
                if (ORAS_Button.Checked)
                {
                    for (byte f = 0; f < 5; f++)
                    {
                        if (fluteArray[f] == horde.flutes[f] || fluteArray[f] == 0 || filters)
                            FluteHordeCount++;
                    }
                    if (FluteHordeCount == 5)
                    {
                        HordeFlutes = string.Join(", ", horde.flutes.Select(f => f.ToString()));
                        table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA,
                            HordeFlutes, horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                    }

                }
                else
                {
                    table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA,
                        horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
            }
        }
        #endregion


        #region Honey
        public void HoneySearch(uint[] CurrentState)
        {
            HoneyWild honey = new HoneyWild()
            {
                oras = ORAS_Button.Checked,
                slotType = (byte)(SurfBox.Checked ? 4 : 0),
            };
            uint[] StoreSeed = new uint[4], StateHit = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);

                for (uint Inex = 0; Inex < Min; Inex++)
                    tiny.nextState(CurrentState);

                CurrentState.CopyTo(StateHit, 0);

                for (byte TempIndex = 0; TempIndex < advances; TempIndex++)
                    tiny.nextState(StateHit);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    honey.GenerateIndex(StateHit);
                    if (((Slots.Contains(honey.slot) || SlotCount == 0) 
                        && 
                        (honey.Sync || !SyncBox.Checked)
                        &&
                        (XY_Button.Checked || Flute1.Value == honey.flute || Flute1.Value == 0)) || filters)
                    {
                        if (DateSearcher)
                            ShowHoneySrch(honey, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                        else
                            ShowHoneyGen(table, honey, CurrentState, Index);
                    }
                    tiny.nextState(CurrentState); tiny.nextState(StateHit);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } while (Working);
        }
        private void ShowHoneySrch(HoneyWild honey, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, honey.Sync, honey.slot, honey.flute, honey.rand100);
            }));
        }
        private void ShowHoneyGen(DataTable table, HoneyWild honey, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, honey.Sync.ToString(), honey.slot, honey.flute, honey.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, honey.Sync.ToString(), honey.slot, honey.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion


        #region Radar
        public void RadarSearch(uint[] CurrentState)
        {
            Radar radar = new Radar()
            {
                chain = (byte)ratio.Value,
                party = (byte)party.Value,
                BonusMusic = BonusMusicBox.Checked,
            };
            uint[] StoreSeed = new uint[4], StateHit = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);

                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);

                CurrentState.CopyTo(StateHit, 0);

                for (byte TempIndex = 0; TempIndex < advances; TempIndex++)
                    tiny.nextState(StateHit);

                for (uint Index = Min; Index <= Max; Index++)
                {
                    radar.GenerateIndex(StateHit);
                    if (!filters)
                    {
                        if (radar.Shiny || (radar.chain == 0 && (Slots.Contains(radar.slot) || SlotCount == 0) && (radar.sync || (!SyncBox.Checked))))
                        {
                            if (DateSearcher)
                                ShowRadarSrch(radar, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index, (byte)ratio.Value);
                            else
                                ShowRadarGen(table, radar, CurrentState, Index, (byte)ratio.Value);
                        }
                    }
                    else
                        ShowRadarGen(table, radar, CurrentState, Index, (byte)ratio.Value);

                    tiny.nextState(CurrentState);
                    tiny.nextState(StateHit);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } 
            while (Working);
        }
        private void ShowRadarSrch(Radar radar, string date, uint[] store_seed, uint index, byte chain)
        {
            if (chain == 0)
            {
                Invoke(new Action(() =>
                {
                    Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, radar.sync, radar.slot, radar.Music, null, radar.rand100);
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, radar.Shiny, radar.Music, null, radar.rand100);
                }));
            }
            element.RadarIndex = index;
            element.RadarState3 = store_seed[3];
            element.RadarSpots = radar.Overview;
            SPatchSpots.Add(element);
        }
        private void ShowRadarGen(DataTable table, Radar radar, uint[] state, uint index, byte chain)
        {
            if (chain == 0)
                table.Rows.Add(index, radar.sync.ToString(), radar.slot, radar.Music, radar.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, radar.Shiny.ToString(), radar.Music, radar.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            element.RadarIndex = index;
            element.RadarState3 = state[3];
            element.RadarSpots = radar.Overview;
            GPatchSpots.Add(element);
        }
        #endregion


        #region DexNav
        public void DexNavSearch(bool W_Exclusives, bool W_Shiny, bool W_HA, bool W_EggMove, bool W_Boost, bool W_Sync, uint Jump, uint[] CurrentState)
        {
            TinyMT tiny = new TinyMT();
            DexNav nav = new DexNav()
            {
                noise = (byte)noise.Value,
                searchlevel = (ushort)party.Value,
                chain = (byte)ratio.Value,
                charm = CharmBox.Checked,
                exclusives = ExclusiveBox.Checked,
                slotType = SurfBox.Checked ? 1 : 0,
                Trigger_only = DateSearcher || !filters,
            };

            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    nav.GenerateIndex(CurrentState);
                    if (!filters)
                    {
                        if (nav.trigger && (nav.shiny || !W_Shiny))
                            if (((!W_Exclusives && nav.EnctrType != 2) || (W_Exclusives && nav.EnctrType == 2))
                                && 
                                (Slots.Contains((byte)nav.slot) || SlotCount == 0)
                                &&
                                (nav.HA || !W_HA)
                                &&
                                (nav.eggMove || !W_EggMove)
                                &&
                                (nav.sync || !W_Sync)
                                &&
                                ((nav.potential == Potential.Value) || (Potential.Value == 0)))
                                if ((nav.boost || !W_Boost)
                                    && ((Flute1.Value == 0) || nav.flute == Flute1.Value))
                                {
                                    if (DateSearcher)
                                        ShowNavSrch(nav, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                                    else
                                        ShowNavGen(table, nav, CurrentState, Index);
                                }
                    }
                    else
                        ShowNavGen(table, nav, CurrentState, Index);

                    tiny.nextState(CurrentState);
                }
                TotalSeconds += Jump; TinySeed += 1000 * Jump;
                CurrentState = tiny.init(TinySeed, 1);
            }
            while (Working);
        }
        private void ShowNavSrch(DexNav nav, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, nav.right, nav.down, nav.trigger, nav.encounter, nav.sync, nav.slot, nav.shiny, "+" +
                nav.levelBoost, nav.HA, nav.eggMove, nav.potential, nav.flute, nav.rand100);
            }));
        }
        private void ShowNavGen(DataTable table, DexNav nav, uint[] state, uint index)
        {
            table.Rows.Add(index, nav.right, nav.down, nav.trigger.ToString(), nav.encounter.ToString(), nav.sync.ToString(),
                nav.slot, nav.shiny.ToString(), "+" + nav.levelBoost.ToString(), nav.HA.ToString(), nav.eggMove.ToString(),
                nav.potential, nav.flute, nav.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion


        #region Swooping
        public void SwoopingSearch(uint[] CurrentState)
        {
            Wild swoop = new Wild();
            uint[] StoreSeed = new uint[4];
            uint TotalSeconds = seconds, TinySeed = tinyInitSeed;

            if (DateSearcher)
                CurrentState = tiny.init(TinySeed, 1);
            do
            {
                CurrentState.CopyTo(StoreSeed, 0);
                for (uint Index = 0; Index < Min; Index++)
                    tiny.nextState(CurrentState);
                for (uint Index = Min; Index <= Max; Index++)
                {
                    swoop.Swooping(CurrentState);
                    if (((Slots.Contains(swoop.slot) || SlotCount == 0) && (swoop.Sync || !SyncBox.Checked))    || filters)
                    {
                        if (DateSearcher)
                            ShowSwoopSrch(swoop, calc.secondsToDate(TotalSeconds, Year), StoreSeed, Index);
                        else
                            ShowSwoopGen(table, swoop, CurrentState, Index);
                    }
                    tiny.nextState(CurrentState);
                }
                TotalSeconds++; TinySeed += 1000;
                CurrentState = tiny.init(TinySeed, 1);
            } 
            while (Working);
        }
        private void ShowSwoopSrch(Wild swoop, string date, uint[] store_seed, uint index)
        {
            Invoke(new Action(() =>
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                       index, swoop.Sync, swoop.slot, null, swoop.rand100);
            }));
        }
        private void ShowSwoopGen(DataTable table, Wild swoop, uint[] state, uint index)
        {
            table.Rows.Add(index, swoop.Sync, swoop.slot, swoop.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion


    }
}
