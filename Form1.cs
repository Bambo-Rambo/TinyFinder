using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TinyFinder
{
    public partial class Form1 : Form
    {
        HashSet<byte> Slots;
        byte[] fluteArray = { 0, 0, 0, 0, 0 };
        Calculate calc = new Calculate();
        TinyMT tiny = new TinyMT();
        SlotData LocationData = new SlotData();
        uint seconds, initial = 0;
        byte count, searchMonth;
        bool Calibrated = false;

        struct PatchSpot
        {
            public uint index;
            public string[] spots;
        }
        PatchSpot element = new PatchSpot();

        List<PatchSpot> GPatchSpots = new List<PatchSpot>();
        List<PatchSpot> SPatchSpots = new List<PatchSpot>();

        public Form1()
        {
            InitializeComponent();

            Generator.Visible = false;
            xyRadio.Checked = true;
            year.Value = DateTime.Now.Year; month.SelectedIndex = (DateTime.Now.Month - 1);
            DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            ManageControls(0);
            ManageColumns(ref Searcher, 0, "s");
        }

        private string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');

        #region Events
        private void xyRadio_CheckedChanged(object sender, EventArgs e) 
        {
            if (Methods.Items.Count == 6)
            {
                Methods.Items.Add("Radar");
                Methods.Items.Add("Friend Safari");
            }
            ManageControls(0); 
        }
        private void orasRadio_CheckedChanged(object sender, EventArgs e) 
        {
            Methods.Items.Remove("Radar");
            Methods.Items.Remove("Friend Safari");
            ManageControls(0);
        }
        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {

            sync.Enabled = true; slots.Enabled = true; s.Enabled = true;
            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.Items.Clear();
                    break;
                case 1:     //Normal Wild
                    if (xyRadio.Checked)
                        location.SelectedIndex = 0;
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 2:     //Fishing
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 90;
                    slots.Items.Clear();
                    for (byte add = 1; add < 4; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 3:     //Rock Smash
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 140;
                    slots.Items.Clear();
                    for (byte add = 1; add < 6; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 4:     //Horde
                    hidden.SelectedIndex = 1;
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 90;
                    slots.Items.Clear();
                    for (byte add = 1; add < 4; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 5:     //Honey Wild
                    if (orasRadio.Checked)
                        surfLocation.SelectedIndex = 0;
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 6:     //Poke Radar
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 7:     //Friend Safari
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 90;
                    slots.Items.Clear();
                    for (byte add = 1; add < 4; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
            }
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            Calibrated = false; button1.Text = "Calibrate and Search";
        }

        private void ratio_ValueChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 6)
            {
                if (ratio.Value == 0)
                {
                    boost.Enabled = false; sync.Enabled = true; 
                    slots.Enabled = true; s.Enabled = true;
                }
                else
                {
                    boost.Enabled = true; sync.Enabled = false; 
                    slots.Enabled = false; s.Enabled = false;
                }
            }
        }

        private void cave_CheckedChanged(object sender, EventArgs e)
        {
            if (cave.Checked)
            {
                ratio.Value = 7;
                label10.Enabled = location.Enabled = surfLocation.Enabled = false;
            }
            else
            {
                ratio.Value = 13;
                label10.Enabled = location.Enabled = surfLocation.Enabled = true;
            }
        }

        private void water_CheckedChanged(object sender, EventArgs e)
        {
            if (water.Checked)
            {
                if (orasRadio.Checked)
                {
                    label10.Visible = surfLocation.Visible = true;
                }
                slots.DropDownHeight = 140;
                slots.Items.Clear();
                for (byte add = 1; add < 6; add++)
                    slots.Items.AddRange(new object[] { add.ToString() });
            }
            else
            {
                label10.Visible = surfLocation.Visible = false;
                slots.DropDownHeight = 310;
                slots.Items.Clear();
                for (byte add = 1; add < 13; add++)
                    slots.Items.AddRange(new object[] { add.ToString() });
            }
        }

        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            {
                Searcher.Visible = true; Generator.Visible = false;
                year.Visible = true; DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
                DateLabel.Location = new Point(1, 71); month.Visible = true; button1.Text = "Calibrate and Search"; 
                atleast.Enabled = true; y.Visible = true; mo.Visible = true;
            }
            else
            {
                Generator.Visible = true; Searcher.Visible = false;
                year.Visible = false; DateLabel.Text = "Current State"; DateLabel.Location = new Point(98, 71); month.Visible = false;
                button1.Text = "Generate"; atleast.Enabled = false; y.Visible = false; mo.Visible = false; 
            }
            ManageControls((byte)Methods.SelectedIndex);
        }
        private void t3_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t1_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t0_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void Generator_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Generator.DefaultCellStyle.BackColor == Color.LightCyan)
                patch_board.Text = string.Join("\n", GPatchSpots[e.RowIndex].spots);
        }
        private void Searcher_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Searcher.DefaultCellStyle.BackColor == Color.LightCyan)
                patch_board.Text = string.Join("\n", SPatchSpots[e.RowIndex].spots);
        }

        #endregion

        //Main Event (Search Button)
        private void button1_Click(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
                ManageColumns(ref Searcher, (byte)Methods.SelectedIndex, "s");
            else
                ManageColumns(ref Generator, (byte)Methods.SelectedIndex, "g");
            
            if (SearchGen.SelectedTab == Srch)
            {
                Searcher.Rows.Clear();
                Searcher.DefaultCellStyle.BackColor = Color.White;
                Searcher.Update();
            }
            else
            {
                Generator.Rows.Clear();
                Generator.DefaultCellStyle.BackColor = Color.White;
                Generator.Update();
            }
            

            int Year = (int)year.Value;
            uint Min = (uint)min.Value;
            uint Max = (uint)max.Value;
            uint[] array = new uint[4], store_seed = new uint[4];
            uint find = (uint)atleast.Value;
            if (SearchGen.SelectedTab == Gen)
                find = 0;

            array[3] = t3.Value;
            array[2] = t2.Value;
            array[1] = t1.Value;
            array[0] = t0.Value;

            if (SearchGen.SelectedTab == Srch)
            {
                byte extra = 1;
                if (Methods.SelectedIndex == 0)
                    extra = 2;
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
            }
            button1.Text = "Search";
            searchMonth = (byte)(month.SelectedIndex + 1); 
            seconds = calc.findSeconds(searchMonth, Year); 
            uint i = calc.findSeed(initial, seconds);

            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    ID id = new ID((ushort)tid.Value, (ushort)sid.Value);
                    uint randID = id.randhex;
                    do
                    {
                        if (SearchGen.SelectedTab == Srch)
                            array = tiny.init(i, 2);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            tiny.nextState(array);
                            if (randID == tiny.temper(array))
                            {
                                if (SearchGen.SelectedTab == Srch)
                                {
                                    Searcher.Rows.Add(calc.secondsToDate(seconds, Year),
                                    hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                                    j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                    id.TSV.ToString().PadLeft(4, '0'), null, id.TRV, null, null, hex(id.randhex));
                                    Searcher.Update();
                                }
                                else
                                {
                                    Generator.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                    id.TSV.ToString().PadLeft(4, '0'), null, id.TRV, null, null, hex(id.randhex),
                                    hex(array[3]), hex(array[2]), hex(array[1]), hex(array[0]));
                                    Generator.Update();
                                }
                            }
                        }

                        if (seconds % 10000 == 0)
                            Searcher.Update();

                        seconds++;
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    Searcher.Update();
                    break;


                case 1:     //Normal Wild
                case 2:     //Fishing
                case 7:     //Friend Safari

                    byte SlotLimit = 4, SlotCase = 0, EnctSyncExtra = 0;
                    if (Methods.SelectedIndex == 1) { SlotLimit = 13; }
                    if (Methods.SelectedIndex == 2) { SlotCase = 2; }
                    if (Methods.SelectedIndex == 7) { SlotCase = 1; }

                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < SlotLimit; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);
                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    if (Methods.SelectedIndex == 1 && !orasRadio.Checked && !cave.Checked && location.SelectedIndex != 0)
                        EnctSyncExtra = (byte)(LocationData.getAdvances(location.SelectedItem.ToString()) + 1);

                    Wild wild = new Wild();
                    do
                    {
                        if (SearchGen.SelectedTab == Srch)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            wild.results(array, orasRadio.Checked, cave.Checked || location.SelectedIndex == 7, SlotCase, EnctSyncExtra);
                            if (wild.encounter < (byte)ratio.Value && Slots.Contains(wild.slot) && ((sync.Checked && wild.Sync) || !sync.Checked))
                            {
                                if (orasRadio.Checked)
                                {
                                    if ((flute1.Value != 0 && flute1.Value == wild.flute) || flute1.Value == 0)
                                    {
                                        if (SearchGen.SelectedTab == Srch)
                                            ShowWildSrch(wild, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowWildGen(wild, array, j);
                                    }
                                    
                                }
                                else
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowWildSrch(wild, calc.secondsToDate(seconds, Year), store_seed, j);
                                    else
                                        ShowWildGen(wild, array, j);
                                }
                            }
                            tiny.nextState(array);
                        }

                        seconds++;
                        if (seconds % 5000 == 0)
                            Searcher.Update();
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    Searcher.Update();
                    break;


                case 3:     //Rock Smash
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < 6; s++)
                    {
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);
                    }
                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                    RockSmash smash = new RockSmash();

                    do
                    {
                        if (SearchGen.SelectedTab == Srch)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            smash.results(array, orasRadio.Checked);
                            if (smash.encounter == 0 && Slots.Contains(smash.slot) && ((sync.Checked && smash.Sync) || !sync.Checked))
                            {
                                if (orasRadio.Checked)
                                {
                                    if ((flute1.Value != 0 && flute1.Value == smash.flute) || flute1.Value == 0)
                                    {
                                        if (SearchGen.SelectedTab == Srch)
                                            ShowSmashSrch(smash, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowSmashGen(smash, array, j);
                                    }
                                }
                                else
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowSmashSrch(smash, calc.secondsToDate(seconds, Year), store_seed, j);
                                    else
                                        ShowSmashGen(smash, array, j);
                                }
                            }
                            tiny.nextState(array);
                        }

                        seconds++;
                        if (seconds % 5000 == 0)
                            Searcher.Update();
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    Searcher.Update();
                    break;


                case 4:     //Horde
                    if (orasRadio.Checked)
                    {
                        fluteArray[0] = (byte)flute1.Value;
                        fluteArray[1] = (byte)flute2.Value;
                        fluteArray[2] = (byte)flute3.Value;
                        fluteArray[3] = (byte)flute4.Value;
                        fluteArray[4] = (byte)flute5.Value;
                    }
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < 4; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);

                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    Horde horde = new Horde();
                    do
                    {
                        if (SearchGen.SelectedTab == Srch)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            horde.results(array, (byte)party.Value, orasRadio.Checked, cave.Checked);
                            if (Slots.Contains(horde.slot))
                                if (((Enumerable.Range(2, 6).Contains(hidden.SelectedIndex) && horde.HA == hidden.SelectedIndex - 1) //Seach for HA in specific slot
                                    || (hidden.SelectedIndex == 1 && horde.HA != 0)         //Search for HA in any slot
                                    || hidden.SelectedIndex == 0)                           //Don't search for HA

                                    &&

                                    ((sync.Checked && horde.sync)
                                    || !sync.Checked))
                                    ShowHorde(horde, calc.secondsToDate(seconds, Year), store_seed, j, array);
                            tiny.nextState(array);
                        }

                        seconds++;
                        /*if (seconds % 100 == 0)
                            Searcher.Update();*/
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    Searcher.Update();
                    break;

                case 5:     //Honey Wild
                    Slots = new HashSet<byte>();
                    byte sl = 13;
                    if (water.Checked)
                        sl = 6;
                    for (byte s = 1; s < sl; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);

                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    HoneyWild honey = new HoneyWild();
                    if (water.Checked)
                        honey.slotLine = 3;
                    else
                        honey.slotLine = 0;

                    do
                    {
                        if (SearchGen.SelectedTab == Srch)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            honey.results(array, orasRadio.Checked, cave.Checked, water.Checked, (byte)party.Value, (byte)surfLocation.SelectedIndex);
                            if (Slots.Contains(honey.slot) && ((sync.Checked && honey.Sync) || !sync.Checked))
                            {
                                if (orasRadio.Checked)
                                {
                                    if ((flute1.Value != 0 && flute1.Value == honey.flute) || flute1.Value == 0)
                                    {
                                        if (SearchGen.SelectedTab == Srch)
                                            ShowHoneySrch(honey, calc.secondsToDate(seconds, Year), store_seed, j);
                                        else
                                            ShowHoneyGen(honey, array, j);
                                    }
                                }
                                else
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowHoneySrch(honey, calc.secondsToDate(seconds, Year), store_seed, j);
                                    else
                                        ShowHoneyGen(honey, array, j);
                                }
                            }
                            tiny.nextState(array);
                        }

                        seconds++;
                        if (seconds % 5000 == 0)
                            Searcher.Update();
                        i += 1000;
                    } while (Searcher.Rows.Count < find);
                    Searcher.Update();
                    break;

                case 6:     //Radar
                    Radar radar = new Radar();

                    if (SearchGen.SelectedTab == Srch)
                        SPatchSpots.Clear();
                    else
                        GPatchSpots.Clear();

                    if (ratio.Value == 0)
                    {
                        Slots = new HashSet<byte>();
                        for (byte s = 1; s < 13; s++)
                            if (slots.CheckBoxItems[s - 1].Checked)
                                Slots.Add(s);
                        if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                        do
                        {
                            if (SearchGen.SelectedTab == Srch)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar.results(array, 0, (byte)party.Value, boost.Checked);
                                if (Slots.Contains(radar.slot) && ((sync.Checked && radar.sync) || (!sync.Checked)))
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, 0);
                                    else
                                        ShowRadarGen(radar, array, j, 0);
                                }
                                tiny.nextState(array);
                            }

                            seconds++;
                            i += 1000;
                        } while (Searcher.Rows.Count < find);
                        Searcher.Update();
                    }
                    else
                    {
                        if (SearchGen.SelectedTab == Srch)
                            Searcher.DefaultCellStyle.BackColor = Color.LightCyan;
                        else
                            Generator.DefaultCellStyle.BackColor = Color.LightCyan;
                        Searcher.Update();
                        do
                        {
                            if (SearchGen.SelectedTab == Srch)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);
                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar.results(array, (byte)ratio.Value, (byte)party.Value, boost.Checked);
                                if (radar.Shiny)
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, (byte)ratio.Value);
                                    else
                                        ShowRadarGen(radar, array, j, (byte)ratio.Value);
                                }
                                tiny.nextState(array);
                            }

                            seconds++;
                            if (seconds % 1000 == 0)
                                Searcher.Update();
                            i += 1000;
                        } while (Searcher.Rows.Count < find);
                    }
                    Searcher.Update();
                    break;
            }
        }

        #region Show Results
        private void ShowWildSrch(Wild wild, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                index, wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", null, null, wild.randInt);
        }
        private void ShowWildGen(Wild wild, uint[] state, uint index)
        {
            Generator.Rows.Add(index, wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", null, null, wild.randInt,
                hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowSmashSrch(RockSmash smash, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index,
                smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", null, null, smash.randInt);
        }
        private void ShowSmashGen(RockSmash smash, uint[] state, uint index)
        {
            Generator.Rows.Add(index, smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", null, null, smash.randInt,
                hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowHorde(Horde horde, string date, uint[] store_seed, uint index, uint[] state)
        {
            if (SearchGen.SelectedTab == Srch)
            {
                if (orasRadio.Checked)
                {
                    count = 0;
                    for (byte f = 0; f < 5; f++)
                    {
                        if ((fluteArray[f] != 0 && fluteArray[f] == horde.flutes[f]) || fluteArray[f] == 0)
                            count++;
                    }
                    if (count == 5)
                        Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), index, null, horde.sync, horde.slot,
                        horde.flutes[0] + ", " + horde.flutes[1] + ", " + horde.flutes[2] + ", " + horde.flutes[3] + ", " + horde.flutes[4],
                        horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%",
                        horde.HA, null, horde.randInt);

                }
                else
                {
                    Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                    index, null, horde.sync, horde.slot, null, horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + 
                    horde.items[3] + "%, " + horde.items[4] + "%", horde.HA, null, horde.randInt);
                }
            } 
            else
            {
                if (orasRadio.Checked)
                {
                    count = 0;
                    for (byte f = 0; f < 5; f++)
                    {
                        if ((fluteArray[f] != 0 && fluteArray[f] == horde.flutes[f]) || fluteArray[f] == 0)
                            count++;
                    }
                    if (count == 5)
                        Generator.Rows.Add(index, null, horde.sync, horde.slot, horde.flutes[0] + ", " + horde.flutes[1] + ", " 
                            + horde.flutes[2] + ", " + horde.flutes[3] + ", " + horde.flutes[4], horde.items[0] + "%, " + horde.items[1] 
                            + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%", horde.HA, null, horde.randInt,
                            hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
                else
                {
                    Generator.Rows.Add(index, null, horde.sync, horde.slot, null, horde.items[0] + "%, " + horde.items[1] + "%, " 
                        + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%", horde.HA, null, horde.randInt, 
                        hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
                }
            }
        }

        private void ShowHoneySrch(HoneyWild honey, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                index, null, honey.Sync, honey.slot, honey.flute, honey.item + "%", null, null, honey.randInt);
        }
        private void ShowHoneyGen(HoneyWild honey, uint[] state, uint index)
        {
            Generator.Rows.Add(index, null, honey.Sync, honey.slot, honey.flute, honey.item + "%", null, null, honey.randInt,
                hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
        }

        private void ShowRadarSrch(Radar radar, string date, uint[] store_seed, uint index, byte chain)
        {
            if (chain == 0)
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                    index, null, radar.sync, radar.slot, null, radar.item + "%", null, radar.Music, radar.randInt);
            }
            else
            {
                Searcher.Rows.Add(date, hex(store_seed[3]), hex(store_seed[2]), hex(store_seed[1]), hex(store_seed[0]), 
                    index, null, null, null, null, null, null, radar.Music, radar.randInt);
            }
            element.index = index;
            element.spots = radar.Overview;
            SPatchSpots.Add(element);
        }

        private void ShowRadarGen(Radar radar, uint[] state, uint index, byte chain)
        {
            if (chain == 0)
            {
                Generator.Rows.Add(index, null, radar.sync, radar.slot, null, radar.item + "%", null, radar.Music, radar.randInt,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            }
            else
            {
                Generator.Rows.Add(index, null, null, null, null, null, null, radar.Music, radar.randInt,
                    hex(state[3]), hex(state[2]), hex(state[1]), hex(state[0]));
            }
            element.index = index;
            element.spots = radar.Overview;
            GPatchSpots.Add(element);
        }

        #endregion

        #region Manage Controls and Columns
        private void ManageControls(byte method)
        {
            Methods.SelectedIndex = method;
            label3.Visible = false; label4.Visible = false; tid.Visible = false; sid.Visible = false; slots.Visible = false; s.Visible = false;
            hidden.Visible = false; h.Visible = false; flutelabel.Visible = false; flute1.Visible = false; label11.Visible = false; flute2.Visible = false;
            label12.Visible = false; flute3.Visible = false; label13.Visible = false; flute4.Visible = false; label14.Visible = false; flute5.Visible = false;
            sync.Visible = false; cave.Visible = false; boost.Visible = false; p.Visible = false; party.Visible = false; r.Visible = false; ratio.Visible = false;
            ratio.Minimum = 1; ratio.Maximum = 100; label10.Visible = false; location.Visible = false; patch_board.Visible = false; water.Visible = false;
            surfLocation.Visible = false;

            max.Value = 150;

            if (method == 0)
            {
                if (orasRadio.Checked)
                    min.Value = min.Minimum = 11;
                else
                    min.Value = min.Minimum = 35;
                label3.Visible = true; label4.Visible = true; tid.Visible = true; sid.Visible = true;
            }
            else
            {
                if (orasRadio.Checked)
                {
                    min.Value = min.Minimum = 20;
                    flutelabel.Visible = true;
                    flute1.Visible = true;
                }
                else
                {
                    min.Value = min.Minimum = 35;
                    if (method == 6)
                        max.Value = 1000;
                }
                slots.Visible = true; s.Visible = true; sync.Visible = true;
                
                if (method == 1 || method == 2 || method == 3 || method == 7)
                {
                    if (!orasRadio.Checked && method == 1)
                    { label10.Visible = true; location.Visible = true; }
                    if (cave.Checked)
                    {
                        location.Enabled = false;
                        if (method != 7)
                            ratio.Value = 7;
                    }
                    r.Text = "Ratio";
                    if (method == 1)
                        cave.Visible = true;

                    if (method != 3) { r.Visible = true; ratio.Visible = true; }
                    
                    if (method == 2)
                        ratio.Value = 49;
                    else if (!cave.Checked || method == 7)
                        ratio.Value = 13;
                }
                else if (method == 4)
                {
                    hidden.Visible = true; h.Visible = true; cave.Visible = true; p.Visible = true;
                    party.Visible = true;
                    if (orasRadio.Checked)
                    {
                        flutelabel.Visible = true; flute1.Visible = true; label11.Visible = true; flute2.Visible = true; label12.Visible = true;
                        flute3.Visible = true; label13.Visible = true; flute4.Visible = true; label14.Visible = true; flute5.Visible = true;
                    }
                }
                else if (method == 5)
                {
                    p.Visible = true;
                    party.Visible = true;
                    cave.Visible = true;
                    water.Visible = true;
                    if (orasRadio.Checked && water.Checked)
                    {
                        label10.Visible = surfLocation.Visible = true;
                        if (cave.Checked)
                            surfLocation.Enabled = false;
                        else
                            surfLocation.Enabled = true;
                    }
                }
                else
                {
                    r.Text = "Chain"; r.Visible = true; ratio.Visible = true; ratio.Minimum = 0; ratio.Maximum = 60; ratio.Value = 0;
                    p.Visible = true; party.Visible = true; boost.Visible = true; patch_board.Visible = true;
                }
            }
            if (SearchGen.SelectedTab == Gen)
            {
                min.Value = min.Minimum = 0; 
                max.Value = 50000;
            }
        }

        private void ManageColumns(ref DataGridView view, byte method, string letter)
        {
            view.Columns[letter + "_Enctr"].Visible = true; view.Columns[letter + "_Slot"].Visible = true;
            view.Columns[letter + "_Sync"].Visible = true; view.Columns[letter + "_Item"].Visible = true;
            view.Columns[letter + "_HA"].Visible = false; view.Columns[letter + "_Music"].Visible = false;
            view.Columns[letter + "_Item"].Width = 50;
            if (method == 0)
            {
                view.Columns[letter + "_Enctr"].HeaderText = "TID"; view.Columns[letter + "_Sync"].HeaderText = "SID";
                view.Columns[letter + "_Slot"].HeaderText = "TSV"; view.Columns[letter + "_Item"].HeaderText = "TRV";
                view.Columns[letter + "_Rand"].HeaderText = "Rand#";
                view.Columns[letter + "_Flute"].Visible = false;
            }
            else
            {
                view.Columns[letter + "_Enctr"].HeaderText = "Enctr?"; view.Columns[letter + "_Sync"].HeaderText = "Sync?";
                view.Columns[letter + "_Slot"].HeaderText = "Slot"; view.Columns[letter + "_Item"].HeaderText = "Item";
                view.Columns[letter + "_Rand"].HeaderText = "Rand(100)";

                if (orasRadio.Checked)
                    view.Columns[letter + "_Flute"].Visible = true;
                else
                    view.Columns[letter + "_Flute"].Visible = false;

                if (method == 1 || method == 2 || method == 3 || method == 7)
                    view.Columns[letter + "_Enctr"].Visible = true;

                else if (method == 4)
                {
                    view.Columns[letter + "_Enctr"].Visible = false;
                    view.Columns[letter + "_HA"].Visible = true;
                    view.Columns[letter + "_Item"].Width = 150;
                }
                else if (method == 5)
                    view.Columns[letter + "_Enctr"].Visible = false;
                else
                {
                    view.Columns[letter + "_Enctr"].Visible = false;
                    view.Columns[letter + "_Music"].Visible = true;
                    if (ratio.Value == 0)
                    {
                        view.Columns[letter + "_Slot"].Visible = true;
                        view.Columns[letter + "_Sync"].Visible = true;
                        view.Columns[letter + "_Item"].Visible = true;
                    }
                    else
                    {
                        view.Columns[letter + "_Slot"].Visible = false;
                        view.Columns[letter + "_Sync"].Visible = false;
                        view.Columns[letter + "_Item"].Visible = false;
                    }
                }
            }
        }
        #endregion
    }
}