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
        public async void StartSearch()
        {
            uint[] state = new uint[4], store_seed = new uint[4], state_hit = new uint[4];
            DataTable table = new DataTable();

            state[3] = t3.Value;
            state[2] = t2.Value;
            state[1] = t1.Value;
            state[0] = t0.Value;

            int Year = (int)year.Value;
            uint Min = (uint)min.Value;
            uint Max = (uint)max.Value;

            MethodUsed = (byte)Methods.SelectedIndex;
            DateSearcher = SearchGen.SelectedIndex == 0;
            if (DateSearcher)
            {
                MainButton.Enabled = false;
                Working = true;
                Searcher.Rows.Clear();
                ManageSearcher(ref Searcher, MethodUsed);
                Searcher.Update();

                byte bootAdvances = (byte)(MethodUsed == 0 ? 2 : 1);
                if (!Calibrated)
                {
                    MainButton.Text = "Calibrating...";
                    uint start_seed = calc.startingPoint(Year);
                    await Task.Run(() =>
                    {
                        for (uint c = start_seed; c < 0xFFFFFFFF; c++)
                            if (tiny.init(c, bootAdvances)[3] == state[3])     //Comparing [3] and [2] should be enough
                                if (tiny.init(c, bootAdvances)[2] == state[2])
                                {
                                    initial = c;
                                    break;
                                }
                    });
                    Calibrated = true;
                }
                MainButton.Text = "Searching...";
                StopButton.Enabled = true;
            }
            else
            {
                Working = false;
                ManageGenColumns(ref table, MethodUsed);
            }

            searchMonth = (byte)(Months.SelectedIndex + 1);
            seconds = calc.FindSeconds(searchMonth, Year);
            uint tinyInitSeed = calc.FindMonthSeed(initial, seconds);

            if (MethodUsed != 0 && !isRadar1())
            {
                SlotLimit = 0;
                switch (MethodUsed)
                {
                    case 1: case 8: SlotLimit = 13; break;
                    case 2: case 4: case 7: SlotLimit = 4; break;
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
                }
                Slots = new HashSet<byte>();
                for (byte s = 1; s < SlotLimit; s++)
                    if (slots.CheckBoxItems[s].Checked)
                        Slots.Add(s);
                SlotCount = (byte)Slots.Count;
            }

            byte NPC_Influence = 0, CurrentLocation = 0, advances = 0;
            bool Is_XY_TallGrass = false;
            HasHordes = false;
            if (MethodUsed == 1 || (MethodUsed == 4 && Horde_Turn.Checked))
            {
                CurrentLocation = (byte)locations.SelectedIndex;
                NPC_Influence = (byte)(CaveBox.Checked ? 0 : Convert.ToByte(Locations[CurrentLocation].NPC));
                HasHordes = (XY_Button.Checked && (CaveBox.Checked || Locations[CurrentLocation].Has_Hordes))
                    || (ORAS_Button.Checked && LongGrassBox.Checked && !CaveBox.Checked);
                Is_XY_TallGrass = XY_Button.Checked && !CaveBox.Checked && Locations[CurrentLocation].Tall_Grass;
            }

            switch (MethodUsed)
            {
                case 0:     //ID
                    ushort TIDValue = (ushort)tid.Value;
                    ushort SIDValue = (ushort)sid.Value;
                    ID id = new ID(TIDValue, SIDValue);
                    uint randID = id.randhex;

                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 2);
                    await Task.Run(() => 
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);
                            for (uint j = Min; j <= Max; j++)
                            {
                                if (randID == tiny.temper(state) && DateSearcher)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        Searcher.Rows.Add(calc.secondsToDate(seconds, Year),
                                        hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                                        j - 1, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                        id.TSV.ToString().PadLeft(4, '0'), id.TRV.ToString("X"), hex(id.randhex));
                                    }));
                                }
                                else
                                {
                                    id.results(state);
                                    if (!ΙgnoreFilters.Checked)
                                    {
                                        if (id.trainerID == TIDValue && id.secretID == SIDValue)
                                            table.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                            id.TSV.ToString().PadLeft(4, '0'), id.TRV.ToString("X"), hex(id.randhex), hex(state[3]), hex(state[2]),
                                            hex(state[1]), hex(state[0]));
                                    }
                                    else
                                    {
                                        table.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                            id.TSV.ToString().PadLeft(4, '0'), id.TRV.ToString("X"), hex(id.randhex), hex(state[3]), hex(state[2]),
                                            hex(state[1]), hex(state[0]));
                                    }
                                }
                                tiny.nextState(state);
                            }
                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 2);
                        } while (Working);
                    });
                    break;

                case 1:     //Normal Wild
                case 2:     //Fishing
                case 7:     //Friend Safari
                    Wild wild = new Wild()
                    {
                        ratio = (byte)ratio.Value,
                        oras = ORAS_Button.Checked,
                        slotType = (byte)(MethodUsed == 2 ? 2 : MethodUsed == 7 ? 1 : 0),
                        NPC = NPC_Influence,
                        CanStepHorde = HasHordes,
                        XY_TallGrass = Is_XY_TallGrass,
                    };
                    Rand100Column = XY_Button.Checked && !DateSearcher ? 4 : 5;    //Searcher has the flute column for both XY and ORAS
                                                                                   //Generator has it only for ORAS
                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 1);
                    await Task.Run(() =>
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);
                            for (uint j = Min; j <= Max; j++)
                            {
                                wild.results(state);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if (wild.trigger && (Slots.Contains(wild.slot) || SlotCount == 0) && (wild.Sync || !SyncBox.Checked))
                                    {
                                        if (XY_Button.Checked || Flute1.Value == wild.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowWildSrch(wild, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowWildGen(table, wild, state, j);
                                        }
                                    }
                                }
                                else
                                    ShowWildGen(table, wild, state, j);

                                tiny.nextState(state);
                            }
                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 1);
                        } while (Working);
                    });
                    break;

                case 3:     //Rock Smash
                    Wild smash = new Wild()
                    {
                        oras = ORAS_Button.Checked
                    };

                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 1);
                    await Task.Run(() =>
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);
                            for (uint j = Min; j <= Max; j++)
                            {
                                smash.RockSmash(state);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if (smash.encounter == 0 && (Slots.Contains(smash.slot) || SlotCount == 0) && (smash.Sync || !SyncBox.Checked))
                                    {
                                        if (XY_Button.Checked || Flute1.Value == smash.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowSmashSrch(smash, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowSmashGen(table, smash, state, j);
                                        }
                                    }
                                }
                                else
                                    ShowSmashGen(table, smash, state, j);

                                tiny.nextState(state);
                            }
                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 1);
                        } while (Working);
                    });
                    break;

                case 4:     //Horde
                    Horde horde = new Horde()
                    {
                        oras = ORAS_Button.Checked,
                        ratio = (byte)ratio.Value,
                        NPC = NPC_Influence,
                        XY_TallGrass = Is_XY_TallGrass,
                        Trigger_only = DateSearcher || !ΙgnoreFilters.Checked,
                    };
                    Rand100Column = XY_Button.Checked ? 5 : 6;

                    int DesiredHA = HASlot.SelectedIndex;
                    if (ORAS_Button.Checked)
                    {
                        fluteArray[0] = (byte)Flute1.Value;
                        fluteArray[1] = (byte)Flute2.Value;
                        fluteArray[2] = (byte)Flute3.Value;
                        fluteArray[3] = (byte)Flute4.Value;
                        fluteArray[4] = (byte)Flute5.Value;
                    }

                    if (!Horde_Turn.Checked)
                    {
                        advances = (byte)((3 * party.Value) + (CaveBox.Checked ? 3 : Convert.ToByte(Locations[CurrentLocation].Bag_Advances)));
                        horde.trigger = true;
                    }

                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 1);
                    await Task.Run(() =>
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);

                            state.CopyTo(state_hit, 0);

                            for (byte j = 0; j < advances; j++)
                                tiny.nextState(state_hit);
                            for (uint j = Min; j <= Max; j++)
                            {
                                if (Horde_Turn.Checked)
                                    horde.HordeTurn(state);
                                else
                                    horde.HordeHoney(state_hit);

                                if (!ΙgnoreFilters.Checked)
                                {
                                    if ((Slots.Contains(horde.slot) || SlotCount == 0) && horde.trigger)
                                        if (((Enumerable.Range(2, 6).Contains(DesiredHA)
                                            && horde.HA == DesiredHA - 1)                //Seach for HA in specific slot

                                            || (DesiredHA == 1 && horde.HA != 0)         //Search for HA in any slot
                                            || DesiredHA == 0)                           //Don't search for HA

                                            &&

                                            (horde.sync || !SyncBox.Checked))
                                            ShowHorde(table, horde, calc.secondsToDate(seconds, Year), store_seed, j, state);
                                }
                                else
                                    ShowHorde(table, horde, calc.secondsToDate(seconds, Year), store_seed, j, state);

                                tiny.nextState(state);
                                tiny.nextState(state_hit);
                            }

                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 1);
                        } while (Working);
                    });
                    break;

                case 5:     //Honey Wild
                    HoneyWild honey = new HoneyWild()
                    {
                        oras = ORAS_Button.Checked,
                        slotCase = (byte)(SurfBox.Checked ? 3 : 0),
                    };
                    if (CaveBox.Checked)
                        advances = 3;
                    else
                    {
                        if (XY_Button.Checked)
                            advances = 27;
                        else
                            advances = (byte)(locations.Visible ? Convert.ToByte(Locations[CurrentLocation].ratio) : 15);
                    }
                    advances += (byte)(party.Value * 3);

                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 1);
                    await Task.Run(() =>
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);

                            state.CopyTo(state_hit, 0);

                            for (byte j = 0; j < advances; j++)
                                tiny.nextState(state_hit);
                            for (uint j = Min; j <= Max; j++)
                            {
                                honey.results(state_hit);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if ((Slots.Contains(honey.slot) || SlotCount == 0) && (honey.Sync || !SyncBox.Checked))
                                    {
                                        if (XY_Button.Checked || Flute1.Value == honey.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowHoneySrch(honey, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowHoneyGen(table, honey, state, j);
                                        }
                                    }
                                }
                                else
                                    ShowHoneyGen(table, honey, state, j);

                                tiny.nextState(state);
                                tiny.nextState(state_hit);
                            }
                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 1);
                        } while (Working);
                    });
                    break;

                case 6:     //Radar / DexNav
                    if (Equals(Methods.Items[6], "Radar"))
                    {
                        Radar radar = new Radar()
                        {
                            chain = (byte)ratio.Value,
                            party = (byte)party.Value,
                            boost = BoostBox.Checked,
                        };
                        if (DateSearcher)
                            SPatchSpots.Clear();
                        else
                            GPatchSpots.Clear();

                        if (ratio.Value == 0)
                        {
                            if (DateSearcher)
                                state = tiny.init(tinyInitSeed, 1);
                            await Task.Run(() =>
                            {
                                do
                                {
                                    state.CopyTo(store_seed, 0);
                                    for (uint j = 0; j < Min; j++)
                                        tiny.nextState(state);
                                    for (uint j = Min; j <= Max; j++)
                                    {
                                        radar.results(state);
                                        if (!ΙgnoreFilters.Checked)
                                        {
                                            if ((Slots.Contains(radar.slot) || SlotCount == 0) && (radar.sync || (!SyncBox.Checked)))
                                            {
                                                if (DateSearcher)
                                                    ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, 0);
                                                else
                                                    ShowRadarGen(table, radar, state, j, 0);
                                            }
                                        }
                                        else
                                            ShowRadarGen(table, radar, state, j, 0);

                                        tiny.nextState(state);
                                    }
                                    seconds++;
                                    tinyInitSeed += 1000;
                                    state = tiny.init(tinyInitSeed, 1);
                                } while (Working);
                            });
                        }
                        else
                        {
                            advances = (byte)(party.Value * 3 + (BagBox.Checked ? 27 : 0));

                            if (DateSearcher)
                                state = tiny.init(tinyInitSeed, 1);
                            await Task.Run(() =>
                            {
                                do
                                {
                                    state.CopyTo(store_seed, 0);

                                    for (uint j = 0; j < Min; j++)
                                        tiny.nextState(state);

                                    state.CopyTo(state_hit, 0);

                                    for (byte j = 0; j < advances; j++)
                                        tiny.nextState(state_hit);

                                    for (uint j = Min; j <= Max; j++)
                                    {
                                        radar.results(state_hit);
                                        if (!ΙgnoreFilters.Checked)
                                        {
                                            if (radar.Shiny)
                                            {
                                                if (DateSearcher)
                                                    ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, (byte)ratio.Value);
                                                else
                                                    ShowRadarGen(table, radar, state, j, (byte)ratio.Value);
                                            }
                                        }
                                        else
                                            ShowRadarGen(table, radar, state, j, (byte)ratio.Value);

                                        tiny.nextState(state);
                                        tiny.nextState(state_hit);
                                    }
                                    seconds++;
                                    tinyInitSeed += 1000;
                                    state = tiny.init(tinyInitSeed, 1);
                                } while (Working);
                            });
                        }
                    }
                    else
                    {
                        DexNav nav = new DexNav()
                        {
                            noise = (byte)noise.Value,
                            searchlevel = (ushort)party.Value,
                            chain = (byte)ratio.Value,
                            charm = CharmBox.Checked,
                            exclusives = ExclusiveBox.Checked,
                            type = SurfBox.Checked ? 1 : 0,
                            Trigger_only = DateSearcher || !ΙgnoreFilters.Checked,
                        };
                        bool WantsExclusives = NavType.SelectedIndex == 1;
                        bool WantsShiny = NavFilters.CheckBoxItems[1].Checked;
                        bool WantsHA = NavFilters.CheckBoxItems[2].Checked;
                        bool WantsEggMove = NavFilters.CheckBoxItems[3].Checked;
                        bool WantsBoost = NavFilters.CheckBoxItems[4].Checked;
                        bool WantsSync = NavFilters.CheckBoxItems[5].Checked;

                        if (DateSearcher)
                            state = tiny.init(tinyInitSeed, 1);
                        await Task.Run(() =>
                        {
                            do
                            {
                                state.CopyTo(store_seed, 0);
                                for (uint j = 0; j < Min; j++)
                                    tiny.nextState(state);
                                for (uint j = Min; j <= Max; j++)
                                {
                                    nav.results(state);
                                    if (!ΙgnoreFilters.Checked)
                                    {
                                        if (nav.trigger && (nav.shiny || !WantsShiny))
                                            if (((!WantsExclusives && nav.slotType != 2) || (WantsExclusives && nav.slotType == 2))
                                                && (Slots.Contains((byte)nav.slot) || SlotCount == 0)
                                                &&
                                                (nav.HA || !WantsHA)
                                                &&
                                                (nav.eggMove || !WantsEggMove)
                                                &&
                                                (nav.sync || !WantsSync)
                                                &&
                                                ((nav.potential == Potential.Value) || (Potential.Value == 0)))
                                                if ((nav.boost || !WantsBoost)
                                                    && ((Flute1.Value == 0) || nav.flute == Flute1.Value))
                                                {
                                                    if (DateSearcher)
                                                        ShowNavSrch(nav, calc.secondsToDate(seconds, Year), store_seed, j);
                                                    else
                                                        ShowNavGen(table, nav, state, j);
                                                }
                                    }
                                    else
                                        ShowNavGen(table, nav, state, j);

                                    tiny.nextState(state);
                                }
                                seconds++;
                                tinyInitSeed += 1000;
                                state = tiny.init(tinyInitSeed, 1);
                            } while (Working);
                        });   
                    }
                    break;

                case 8:     //Swooping
                    Wild swoop = new Wild();
                    if (DateSearcher)
                        state = tiny.init(tinyInitSeed, 1);
                    await Task.Run(() =>
                    {
                        do
                        {
                            state.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(state);
                            for (uint j = Min; j <= Max; j++)
                            {
                                swoop.Swooping(state);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if ((Slots.Contains(swoop.slot) || SlotCount == 0) && (swoop.Sync || !SyncBox.Checked))
                                    {
                                        if (DateSearcher)
                                            ShowSwoopSrch(swoop, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowSwoopGen(table, swoop, state, j);
                                    }
                                }
                                else
                                    ShowSwoopGen(table, swoop, state, j);

                                tiny.nextState(state);
                            }
                            seconds++;
                            tinyInitSeed += 1000;
                            state = tiny.init(tinyInitSeed, 1);
                        } while (Working);
                    });
                    break;
            }

            string M = isRadar1() ? "Radar1" : Methods.Text;
            if (!DateSearcher)
                ManageGenerator(Generator, table, M);

            StopButton.Enabled = Working = false;
            MainButton.Enabled = true;
            MainButton.Text = DateSearcher ? "Search" : "Generate";
        }

        #region Show Results
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

        private void ShowHorde(DataTable table, Horde horde, string date, uint[] store_seed, uint index, uint[] state)
        {
            if (DateSearcher)
            {
                if (ORAS_Button.Checked)
                {
                    count = 0;
                    for (byte f = 0; f < 5; f++)
                    {
                        if (fluteArray[f] == horde.flutes[f] || fluteArray[f] == 0)
                            count++;
                    }
                    if (count == 5)
                    {
                        Flutes = string.Join(", ", horde.flutes.Select(f => f.ToString()));
                        Invoke(new Action(() =>
                        {
                            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                               index, horde.encounter, horde.sync, horde.slot, horde.HA, Flutes, horde.rand100);
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
                    count = 0;
                    for (byte f = 0; f < 5; f++)
                    {
                        if (fluteArray[f] == horde.flutes[f] || fluteArray[f] == 0 || ΙgnoreFilters.Checked)
                            count++;
                    }
                    if (count == 5)
                    {
                        Flutes = string.Join(", ", horde.flutes.Select(f => f.ToString()));
                        table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA,
                            Flutes, horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                    }

                }
                else
                {
                    table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA, 
                        horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
            }
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
            element.index = index;
            element.spots = radar.Overview;
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
            element.index = index;
            element.spots = radar.Overview;
            GPatchSpots.Add(element);
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
