using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace TinyFinder
{
    public partial class Form1
    {
        //Main Event (Search Button)
        private void button1_Click(object sender, EventArgs e)
        {
            DateSearcher = SearchGen.SelectedIndex == 0;
            MethodUsed = (byte)Methods.SelectedIndex;
            DataTable table = new DataTable();

            if (DateSearcher)
            {
                Searcher.Rows.Clear();
                ManageSearcher(ref Searcher, (byte)Methods.SelectedIndex);
                Searcher.Update();
            }
            else
                ManageGenColumns(ref table, (byte)Methods.SelectedIndex);

            int Year = (int)year.Value;
            uint Min = (uint)min.Value;
            uint Max = (uint)max.Value;
            uint[] array = new uint[4], store_seed = new uint[4];
            uint find = (uint)Atleast.Value;
            if (!DateSearcher)
                find = 0;

            array[3] = t3.Value;
            array[2] = t2.Value;
            array[1] = t1.Value;
            array[0] = t0.Value;

            if (DateSearcher)
            {
                byte extra = (byte)(Methods.SelectedIndex == 0 ? 2 : 1);
                if (!Calibrated)
                {
                    uint start_seed = calc.findTiny(Year);
                    for (uint c = start_seed; c < 0xFFFFFFFF; c++)
                        if (tiny.init(c, extra)[3] == array[3])     //Comparing [3] and [2] should be enough
                            if (tiny.init(c, extra)[2] == array[2])
                            {
                                initial = c;
                                break;
                            }
                    Calibrated = true;
                }
                button1.Text = "Search";
            }
            searchMonth = (byte)(Months.SelectedIndex + 1);
            seconds = calc.findSeconds(searchMonth, Year);
            uint i = calc.findSeed(initial, seconds);

            if (Methods.SelectedIndex != 0 && !isRadar1())
            {
                SlotLimit = 0;
                switch (Methods.SelectedIndex)
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
                if (Slots.Count == 0 && !ΙgnoreFilters.Checked && (!isRadar1() || (Methods.SelectedIndex == 6 && ORAS_Button.Checked)))
                {
                    MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    find = 0;
                }
            }

            byte NPC_Influence = 0, CurrentLocation;
            bool XY_TallGrass = false; 
            HasHordes = false;
            if (Methods.SelectedIndex == 1 || (Methods.SelectedIndex == 4 && Horde_Turn.Checked))
            {
                CurrentLocation = (byte)locations.SelectedIndex;
                NPC_Influence = (byte)(CaveBox.Checked ? 0 : Convert.ToByte(Locations[CurrentLocation].NPC));
                HasHordes = (XY_Button.Checked && (CaveBox.Checked || Locations[CurrentLocation].Has_Hordes)) 
                    || (ORAS_Button.Checked && LongGrassBox.Checked && !CaveBox.Checked);
                XY_TallGrass = XY_Button.Checked && !CaveBox.Checked && Locations[CurrentLocation].Tall_Grass;
            }


            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    ID id = new ID((ushort)tid.Value, (ushort)sid.Value);
                    uint randID = id.randhex;
                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 2);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            if (!ΙgnoreFilters.Enabled)
                            {
                                if (randID == tiny.temper(array))
                                {
                                    Searcher.Rows.Add(calc.secondsToDate(seconds, Year),
                                    hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                                    j - 1, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                    id.TSV.ToString().PadLeft(4, '0'), id.TRV, hex(id.randhex));
                                    Searcher.Update();
                                    Thread.Sleep(100);
                                }
                            }
                            else
                            {
                                //Bad implementation, fix later
                                id.results(array);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if (id.trainerID == tid.Value && id.secretID == sid.Value)
                                        table.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                        id.TSV.ToString().PadLeft(4, '0'), id.TRV, hex(id.randhex), hex(array[3]), hex(array[2]),
                                        hex(array[1]), hex(array[0]));
                                }
                                else
                                {
                                    table.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                        id.TSV.ToString().PadLeft(4, '0'), id.TRV, hex(id.randhex), hex(array[3]), hex(array[2]),
                                        hex(array[1]), hex(array[0]));
                                }
                            }
                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "ID");
                    break;

                case 1:     //Normal Wild
                case 2:     //Fishing
                case 7:     //Friend Safari
                    byte SlotCase = (byte)(Methods.SelectedIndex == 2 ? 2 : Methods.SelectedIndex == 7 ? 1 : 0);
                    Wild wild = new Wild();
                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            wild.results(array, (byte)ratio.Value, ORAS_Button.Checked, SlotCase, NPC_Influence, HasHordes, XY_TallGrass);
                            if (!ΙgnoreFilters.Checked)
                            {
                                if (wild.trigger && Slots.Contains(wild.slot) && (wild.Sync || !SyncBox.Checked))
                                {
                                    if (ORAS_Button.Checked)
                                    {
                                        if (Flute1.Value == wild.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowWildSrch(wild, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowWildGen(table, wild, array, j);
                                        }
                                    }
                                    else
                                    {
                                        if (DateSearcher)
                                            ShowWildSrch(wild, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowWildGen(table, wild, array, j);
                                    }
                                }
                            }
                            else
                                ShowWildGen(table, wild, array, j);

                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "Wild");
                    break;

                case 3:     //Rock Smash
                    Wild smash = new Wild();
                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            smash.RockSmash(array, ORAS_Button.Checked);
                            if (!ΙgnoreFilters.Checked)
                            {
                                if (smash.encounter == 0 && Slots.Contains(smash.slot) && (smash.Sync || !SyncBox.Checked))
                                {
                                    if (ORAS_Button.Checked)
                                    {
                                        if (Flute1.Value == smash.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowSmashSrch(smash, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowSmashGen(table, smash, array, j);
                                        }
                                    }
                                    else
                                    {
                                        if (DateSearcher)
                                            ShowSmashSrch(smash, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowSmashGen(table, smash, array, j);
                                    }
                                }
                            }
                            else
                                ShowSmashGen(table, smash, array, j);
                            
                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "Rock Smash");
                    break;

                case 4:     //Horde
                    Horde horde = new Horde();

                    if (ORAS_Button.Checked)
                    {
                        fluteArray[0] = (byte)Flute1.Value;
                        fluteArray[1] = (byte)Flute2.Value;
                        fluteArray[2] = (byte)Flute3.Value;
                        fluteArray[3] = (byte)Flute4.Value;
                        fluteArray[4] = (byte)Flute5.Value;
                    }

                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        if (!Horde_Turn.Checked)
                            horde.Bag_Advances = (byte)((3 * party.Value) + (CaveBox.Checked ? 3 : XY_Button.Checked ? 27 : 15));

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            if (Horde_Turn.Checked)
                                horde.HordeTurn(array, ORAS_Button.Checked, (byte)ratio.Value, NPC_Influence, XY_TallGrass);
                            else
                                horde.HordeHoney(array, ORAS_Button.Checked);

                            if (!ΙgnoreFilters.Checked)
                            {
                                if (Slots.Contains(horde.slot) && horde.trigger)
                                    if (((Enumerable.Range(2, 6).Contains(HASlot.SelectedIndex) 
                                        && horde.HA == HASlot.SelectedIndex - 1)                //Seach for HA in specific slot

                                        || (HASlot.SelectedIndex == 1 && horde.HA != 0)         //Search for HA in any slot
                                        || HASlot.SelectedIndex == 0)                           //Don't search for HA

                                        &&

                                        (horde.sync || !SyncBox.Checked))
                                        ShowHorde(table, horde, calc.secondsToDate(seconds, Year), store_seed, j, array);
                            }
                            else
                                ShowHorde(table, horde, calc.secondsToDate(seconds, Year), store_seed, j, array);

                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "Horde");
                    break;

                case 5:     //Honey Wild
                    HoneyWild honey = new HoneyWild();
                    if (CaveBox.Checked)
                        honey.Bag_Advances = 3;
                    else
                    {
                        if (XY_Button.Checked)
                            honey.Bag_Advances = 27;
                        else
                            honey.Bag_Advances = (byte)(locations.Visible ? Convert.ToByte(Locations[(byte)locations.SelectedIndex].ratio) : 15);
                    }
                    honey.slotCase = (byte)(SurfBox.Checked ? 3 : 0);

                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            honey.results(array, ORAS_Button.Checked, (byte)party.Value);
                            if (!ΙgnoreFilters.Checked)
                            {
                                if (Slots.Contains(honey.slot) && (honey.Sync || !SyncBox.Checked))
                                {
                                    if (ORAS_Button.Checked)
                                    {
                                        if (Flute1.Value == honey.flute || Flute1.Value == 0)
                                        {
                                            if (DateSearcher)
                                                ShowHoneySrch(honey, calc.secondsToDate(seconds, Year), store_seed, j);
                                            else
                                                ShowHoneyGen(table, honey, array, j);
                                        }
                                    }
                                    else
                                    {
                                        if (DateSearcher)
                                            ShowHoneySrch(honey, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowHoneyGen(table, honey, array, j);
                                    }
                                }
                            }
                            else
                                ShowHoneyGen(table, honey, array, j);
                            
                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "Honey");
                    break;

                case 6:     //Radar / DexNav
                    if (Equals(Methods.Items[6], "Radar"))
                    {
                        Radar radar = new Radar();
                        if (DateSearcher)
                            SPatchSpots.Clear();
                        else
                            GPatchSpots.Clear();

                        if (ratio.Value == 0)
                        {
                            do
                            {
                                if (DateSearcher)
                                    array = tiny.init(i, 1);
                                array.CopyTo(store_seed, 0);

                                for (uint j = 0; j < Min; j++)
                                    tiny.nextState(array);
                                for (uint j = Min; j <= Max; j++)
                                {
                                    radar.results(array, 0, (byte)party.Value, BoostBox.Checked, 0);
                                    if (!ΙgnoreFilters.Checked)
                                    {
                                        if (Slots.Contains(radar.slot) && (radar.sync || (!SyncBox.Checked)))
                                        {
                                            if (DateSearcher)
                                                ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, 0);
                                            else
                                                ShowRadarGen(table, radar, array, j, 0);
                                        }
                                    }
                                    else
                                        ShowRadarGen(table, radar, array, j, 0);
                                    
                                    tiny.nextState(array);
                                }
                                seconds++;
                                i += 1000;
                            } while (Searcher.Rows.Count < find);
                            if (!DateSearcher)
                                ManageGenerator(ref Generator, table, "Radar0");
                        }
                        else
                        {
                            byte advances = (byte)(BagBox.Checked ? 27 : 0);
                            Searcher.Update();
                            do
                            {
                                if (DateSearcher)
                                    array = tiny.init(i, 1);
                                array.CopyTo(store_seed, 0);
                                for (uint j = 0; j < Min; j++)
                                    tiny.nextState(array);
                                for (uint j = Min; j <= Max; j++)
                                {
                                    radar.results(array, (byte)ratio.Value, (byte)party.Value, BoostBox.Checked, advances);
                                    if (!ΙgnoreFilters.Checked)
                                    {
                                        if (radar.Shiny)
                                        {
                                            if (DateSearcher)
                                                ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, (byte)ratio.Value);
                                            else
                                                ShowRadarGen(table, radar, array, j, (byte)ratio.Value);
                                        }
                                    }
                                    else
                                        ShowRadarGen(table, radar, array, j, (byte)ratio.Value);
                                    tiny.nextState(array);
                                }
                                seconds++;
                                i += 1000;
                            } while (Searcher.Rows.Count < find);
                            if (!DateSearcher)
                                ManageGenerator(ref Generator, table, "Radar1");
                        }
                    }
                    else
                    {
                        DexNav nav = new DexNav();
                        int type = SurfBox.Checked ? 1 : 0;
                        do
                        {
                            if (DateSearcher)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                nav.results(array, (ushort)party.Value, (uint)ratio.Value, CharmBox.Checked, ExclusiveBox.Checked, type);
                                if (!ΙgnoreFilters.Checked)
                                {
                                    if (nav.shiny || !NavFilters.CheckBoxItems[2].Checked)
                                        if (nav.trigger || !NavFilters.CheckBoxItems[1].Checked)
                                            if (((NavType.SelectedIndex == 0 && nav.slotype != 2) || (NavType.SelectedIndex == 1 && nav.slotype == 2))
                                                && Slots.Contains((byte)nav.slot)
                                                &&
                                                (nav.HA || !NavFilters.CheckBoxItems[3].Checked)
                                                &&
                                                (nav.eggMove || !NavFilters.CheckBoxItems[4].Checked)
                                                &&
                                                (nav.sync || !NavFilters.CheckBoxItems[6].Checked)
                                                &&
                                                ((nav.potential == Potential.Value) || (Potential.Value == 0)))
                                                if ((nav.boost || !NavFilters.CheckBoxItems[5].Checked)
                                                    && ((Flute1.Value == 0) || nav.flute == Flute1.Value))
                                                {
                                                    if (DateSearcher)
                                                        ShowNavSrch(nav, calc.secondsToDate(seconds, Year), store_seed, j);
                                                    else
                                                        ShowNavGen(table, nav, array, j);
                                                }
                                }
                                else
                                    ShowNavGen(table, nav, array, j);
                                
                                tiny.nextState(array);
                            }
                            seconds++;
                            i += 1000;
                        } while (Searcher.Rows.Count < find);
                        if (!DateSearcher)
                            ManageGenerator(ref Generator, table, "DexNav");
                    }
                    break;

                case 8:     //Swooping
                    Wild swoop = new Wild();
                    do
                    {
                        if (DateSearcher)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            swoop.Swooping(array);
                            if (!ΙgnoreFilters.Checked)
                            {
                                if (Slots.Contains(swoop.slot) && (swoop.Sync || !SyncBox.Checked))
                                {
                                    if (DateSearcher)
                                        ShowSwoopSrch(swoop, calc.secondsToDate(seconds, Year), store_seed, j);
                                    else
                                        ShowSwoopGen(table, swoop, array, j);
                                }
                            }
                            else
                                ShowSwoopGen(table, swoop, array, j);

                            tiny.nextState(array);
                        }
                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    if (!DateSearcher)
                        ManageGenerator(ref Generator, table, "Swooping");
                    Searcher.Update();
                    break;
            }
        }

        #region Show Results
        private void ShowWildSrch(Wild wild, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", wild.rand100);
            Searcher.Update();
        }
        private void ShowWildGen(DataTable table, Wild wild, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, wild.encounter, wild.Sync.ToString(), wild.slot, wild.flute, wild.item.ToString() + "%", wild.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, wild.encounter, wild.Sync.ToString(), wild.slot, wild.item.ToString() + "%", wild.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowSmashSrch(Wild smash, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index,
                smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", smash.rand100);
            Searcher.Update();
        }
        private void ShowSmashGen(DataTable table, Wild smash, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, smash.encounter, smash.Sync.ToString(), smash.slot, smash.flute, smash.item.ToString() + "%", smash.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, smash.encounter, smash.Sync.ToString(), smash.slot, smash.item.ToString() + "%", smash.rand100,
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
                        Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index, horde.encounter, 
                            horde.sync, horde.slot, horde.HA, horde.flutes[0] + ", " + horde.flutes[1] + ", " + horde.flutes[2] + ", " + horde.flutes[3] 
                            + ", " + horde.flutes[4], horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " 
                            + horde.items[4] + "%", horde.rand100);
                        Searcher.Update();
                    }
                }
                else
                {
                    Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index, horde.encounter, 
                        horde.sync, horde.slot, horde.HA, horde.sync, horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " +
                        horde.items[3] + "%, " + horde.items[4] + "%", horde.rand100);
                    Searcher.Update();
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
                        table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA, horde.flutes[0].ToString() + ", " + 
                            horde.flutes[1].ToString() + ", " + horde.flutes[2].ToString() + ", " + horde.flutes[3].ToString() + ", " + 
                            horde.flutes[4].ToString(), horde.items[0].ToString() + "%, " + horde.items[1].ToString()
                            + "%, " + horde.items[2].ToString() + "%, " + horde.items[3].ToString() + "%, " + horde.items[4].ToString() + "%", 
                            horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
                else
                {
                    table.Rows.Add(index, horde.encounter.ToString(), horde.sync.ToString(), horde.slot, horde.HA, horde.items[0].ToString() + "%, " + 
                        horde.items[1].ToString() + "%, " + horde.items[2].ToString() + "%, " + horde.items[3].ToString() + "%, " + 
                        horde.items[4].ToString() + "%", horde.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
            }
        }

        private void ShowHoneySrch(HoneyWild honey, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                index, honey.Sync, honey.slot, honey.flute, honey.item + "%", honey.rand100);
            Searcher.Update();
        }
        private void ShowHoneyGen(DataTable table, HoneyWild honey, uint[] state, uint index)
        {
            if (ORAS_Button.Checked)
                table.Rows.Add(index, honey.Sync.ToString(), honey.slot, honey.flute, honey.item.ToString() + "%", honey.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            else
                table.Rows.Add(index, honey.Sync.ToString(), honey.slot, honey.item.ToString() + "%", honey.rand100,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowRadarSrch(Radar radar, string date, uint[] store_seed, uint index, byte chain)
        {
            if (chain == 0)
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, radar.sync, radar.slot, radar.Music, radar.item + "%", radar.rand100);
            else
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, radar.Shiny, radar.Music, null, null, radar.rand100);
            element.index = index;
            element.spots = radar.Overview;
            SPatchSpots.Add(element);
            Searcher.Update();
        }

        private void ShowRadarGen(DataTable table, Radar radar, uint[] state, uint index, byte chain)
        {
            if (chain == 0)
                table.Rows.Add(index, radar.sync.ToString(), radar.slot, radar.Music, radar.item.ToString() + "%", radar.rand100,
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
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, nav.right, nav.down, nav.trigger, nav.encounter, nav.sync, nav.slot, nav.shiny, "+" + nav.levelBoost,
                    nav.HA, nav.eggMove, nav.potential, nav.flute, nav.rand100);
            Searcher.Update();
        }
        private void ShowNavGen(DataTable table, DexNav nav, uint[] state, uint index)
        {
            table.Rows.Add(index, nav.right, nav.down, nav.trigger.ToString(), nav.encounter.ToString(), nav.sync.ToString(),
                nav.slot, nav.shiny.ToString(), "+" + nav.levelBoost.ToString(), nav.HA.ToString(), nav.eggMove.ToString(), 
                nav.potential, nav.flute, nav.rand100, hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowSwoopSrch(Wild swoop, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]),
                    index, swoop.Sync, swoop.slot, null, swoop.item + "%", swoop.rand100);
        }

        private void ShowSwoopGen(DataTable table, Wild swoop, uint[] state, uint index)
        {
            table.Rows.Add(index, swoop.Sync, swoop.slot, swoop.item.ToString() + "%", swoop.rand100, 
                hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }
        #endregion
    }
}
