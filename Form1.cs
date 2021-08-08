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
            ManageColumns(0);
        }

        #region Events
        private void xyRadio_CheckedChanged(object sender, EventArgs e) 
        {
            if (Methods.Items.Count == 5)
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
                case 5:     //Poke Radar
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 6:     //Friend Safari
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
            if (Methods.SelectedIndex == 5)
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
            if (cave.Checked) { location.Enabled = false; ratio.Value = 7; }
            else { location.Enabled = true; ratio.Value = 13; }
        }

        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            {
                Searcher.Visible = true; Generator.Visible = false;
                year.Visible = true; DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
                DateLabel.Location = new Point(1, 71); month.Visible = true; button1.Text = "Calibrate and Search"; 
                find.Enabled = true; y.Visible = true; mo.Visible = true;
            }
            else
            {
                Generator.Visible = true; Searcher.Visible = false;
                year.Visible = false; DateLabel.Text = "Current State"; DateLabel.Location = new Point(98, 71); month.Visible = false;
                button1.Text = "Generate"; find.Enabled = false; y.Visible = false; mo.Visible = false; 
            }
            ManageControls((byte)Methods.SelectedIndex);
        }
        private void t3_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t1_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void t0_TextChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
            { Calibrated = false; button1.Text = "Calibrate and Search"; }
        }
        private void Generator_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Methods.SelectedIndex == 5)
                patch_board.Text = string.Join("\n", GPatchSpots[e.RowIndex].spots);
        }
        private void Searcher_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Methods.SelectedIndex == 5)
                patch_board.Text = string.Join("\n", SPatchSpots[e.RowIndex].spots);
        }

        #endregion

        //Main Event (Search Button)
        private void button1_Click(object sender, EventArgs e)
        {
            ManageColumns((byte)Methods.SelectedIndex);
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
            uint found = (uint)find.Value;
            byte EnctSync = 0;

            array[3] = t3.Value;
            array[2] = t2.Value;
            array[1] = t1.Value;
            array[0] = t0.Value;

            byte extra = 1;
            if (SearchGen.SelectedTab == Srch)
            {
                if (Methods.SelectedIndex == 0)
                    extra = 2;
                if (!Calibrated)
                {
                    uint start_seed = calc.findTiny(Year);
                    for (uint c = start_seed; c < 0xFFFFFFFF; c++)
                        if (tiny.init(c, extra)[3] == array[3] && tiny.init(c, extra)[2] == array[2]) //Comparing [3] and [2] should be enough
                        { initial = c; break; }
                    Calibrated = true;

                }
            }
            button1.Text = "Search";
            searchMonth = (byte)(month.SelectedIndex + 1); seconds = calc.findSeconds(searchMonth, Year); uint i = calc.findSeed(initial, seconds);

            ushort TID = (ushort)tid.Value; ushort SID = (ushort)sid.Value;
            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    ID id = new ID(TID, SID);
                    uint randID = id.randhex;
                    while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                    {
                        //dataGridView1.Update();
                        if (SearchGen.SelectedIndex == 0)
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
                                    store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                                    store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), j,
                                    id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                    id.TSV.ToString().PadLeft(4, '0'), null, id.TRV, null, null, id.randhex.ToString("X").PadLeft(8, '0'));
                                    Searcher.Update();
                                }
                                else
                                {
                                    Generator.Rows.Add(j, id.trainerID.ToString().PadLeft(5, '0'), id.secretID.ToString().PadLeft(5, '0'),
                                    id.TSV.ToString().PadLeft(4, '0'), null, id.TRV, null, null, id.randhex.ToString("X").PadLeft(8, '0'),
                                    array[3].ToString("X").PadLeft(8, '0'), array[2].ToString("X").PadLeft(8, '0'),
                                    array[1].ToString("X").PadLeft(8, '0'), array[0].ToString("X").PadLeft(8, '0'));
                                    Generator.Update();
                                }
                            }
                        }
                        if (SearchGen.SelectedTab == Gen)
                            break;

                        if (seconds % 10000 == 0)
                            Searcher.Update();

                        seconds++;
                        i += 1000;
                    }
                    Searcher.Update();
                    break;


                case 1:     //Normal Wild
                case 2:     //Fishing
                case 6:     //Friend Safari


                    byte SlotLimit = 4, SlotCase = 0;
                    if (Methods.SelectedIndex == 1) { SlotLimit = 13; }
                    if (Methods.SelectedIndex == 2) { SlotCase = 2; }
                    if (Methods.SelectedIndex == 6) { SlotCase = 1; }

                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < SlotLimit; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);
                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    if (Methods.SelectedIndex == 1 && !orasRadio.Checked && !cave.Checked && location.SelectedIndex != 0)
                        EnctSync = (byte)(LocationData.getAdvances(location.SelectedItem.ToString()) + 1);

                    Wild wild = new Wild();
                    wild.oras = orasRadio.Checked;
                    wild.cave = cave.Checked || location.SelectedIndex == 7; // -> Route 7 is identical to caves
                    wild.slotLine = SlotCase;
                    wild.ES = EnctSync;
                    while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            wild.results(array);
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
                        if (SearchGen.SelectedTab == Gen)
                            break;

                        seconds++;
                        if (seconds % 5000 == 0)
                            Searcher.Update();
                        i += 1000;
                    }
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
                    smash.oras = orasRadio.Checked;

                    while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            smash.results(array);
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
                        if (SearchGen.SelectedTab == Gen)
                            break;

                        seconds++;
                        if (seconds % 5000 == 0)
                            Searcher.Update();
                        i += 1000;
                    }
                    Searcher.Update();
                    break;


                case 4:     //Horde
                    Slots = new HashSet<byte>();
                    if (orasRadio.Checked)
                    {
                        fluteArray[0] = (byte)flute1.Value;
                        fluteArray[1] = (byte)flute2.Value;
                        fluteArray[2] = (byte)flute3.Value;
                        fluteArray[3] = (byte)flute4.Value;
                        fluteArray[4] = (byte)flute5.Value;
                    }
                    //dataGridView1.Update();
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < 4; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);

                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    Horde horde = new Horde();
                    horde.oras = orasRadio.Checked;

                    byte advances = 3;
                    if (!cave.Checked)
                    {
                        if (orasRadio.Checked)
                            advances = 15;
                        else advances = 27;
                    }
                    advances = (byte)(3 * party.Value + advances);

                    while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            horde.results(array, advances);
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
                        if (SearchGen.SelectedTab == Gen)
                            break;

                        seconds++;
                        //if (seconds % 100 == 0)
                            //dataGridView1.Update();
                        i += 1000;
                    }
                    Searcher.Update();
                    break;


                case 5:     //Radar
                    Radar radar = new Radar();
                    radar.num = (byte)party.Value;
                    radar.length = (byte)ratio.Value;
                    if (SearchGen.SelectedTab == Srch)
                        SPatchSpots.Clear();
                    else
                        GPatchSpots.Clear();

                    if (ratio.Value == 0)
                    {
                        radar.boost = false;
                        Slots = new HashSet<byte>();
                        for (byte s = 1; s < 13; s++)
                            if (slots.CheckBoxItems[s - 1].Checked)
                                Slots.Add(s);
                        if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                        while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                        {
                            if (SearchGen.SelectedIndex == 0)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar.results(array);
                                if (Slots.Contains(radar.slot) && ((sync.Checked && radar.sync) || (!sync.Checked)))
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, 0);
                                    else
                                        ShowRadarGen(radar, array, j, 0);
                                }
                                tiny.nextState(array);
                            }

                            if (SearchGen.SelectedTab == Gen)
                                break;

                            seconds++;
                            i += 1000;
                        }
                        Searcher.Update();
                    }
                    else
                    {
                        if (SearchGen.SelectedTab == Srch)
                            Searcher.DefaultCellStyle.BackColor = Color.LightCyan;
                        else
                            Generator.DefaultCellStyle.BackColor = Color.LightCyan;
                        radar.boost = boost.Checked;
                        Searcher.Update();
                        while (Searcher.Rows.Count < found || SearchGen.SelectedTab == Gen)
                        {
                            if (SearchGen.SelectedIndex == 0)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar.results(array);
                                if (radar.Shiny)
                                {
                                    if (SearchGen.SelectedTab == Srch)
                                        ShowRadarSrch(radar, calc.secondsToDate(seconds, Year), store_seed, j, (byte)ratio.Value);
                                    else
                                        ShowRadarGen(radar, array, j, (byte)ratio.Value);
                                }
                                tiny.nextState(array);
                                radar.boost = boost.Checked;
                            }

                            if (SearchGen.SelectedTab == Gen)
                                break;

                            seconds++;
                            if (seconds % 1000 == 0)
                                Searcher.Update();
                            i += 1000;
                        }
                    }
                    Searcher.Update();
                    break;
            }
        }

        #region Show Results
        private void ShowWildSrch(Wild wild, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", null, null, wild.randInt);
        }
        private void ShowWildGen(Wild wild, uint[] state, uint index)
        {
            Generator.Rows.Add(index, wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", null, null, wild.randInt,
                state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'),
                state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
        }


        private void ShowSmashSrch(RockSmash smash, string date, uint[] store_seed, uint index)
        {
            Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", null, null, smash.randInt);
        }
        private void ShowSmashGen(RockSmash smash, uint[] state, uint index)
        {
            Generator.Rows.Add(index, smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", null, null, smash.randInt,
                state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'),
                state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
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
                        Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                        store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index, null, horde.sync, horde.slot,
                        horde.flutes[0] + ", " + horde.flutes[1] + ", " + horde.flutes[2] + ", " + horde.flutes[3] + ", " + horde.flutes[4],
                        horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%",
                            horde.HA, null, horde.randInt);

                }
                else
                {
                    Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                    store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index, null, horde.sync,
                    horde.slot, null, horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%",
                        horde.HA, null, horde.randInt);
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
                            state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'), 
                            state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
                }
                else
                {
                    Generator.Rows.Add(index, null, horde.sync, horde.slot, null, horde.items[0] + "%, " + horde.items[1] + "%, " 
                        + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%", horde.HA, null, horde.randInt, 
                        state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'), 
                        state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
                }
            }
            
        }

        private void ShowRadarSrch(Radar radar, string date, uint[] store_seed, uint index, byte chain)
        {
            if (chain == 0)
            {
                Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                null, radar.sync, radar.slot, null, radar.item + "%", null, radar.Music, radar.randInt);
            }
            else
            {
                Searcher.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                null, null, null, null, null, null, radar.Music, radar.randInt);
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
                    state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'),
                    state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
            }
            else
            {
                Generator.Rows.Add(index, null, null, null, null, null, null, radar.Music, radar.randInt,
                    state[3].ToString("X").PadLeft(8, '0'), state[2].ToString("X").PadLeft(8, '0'),
                    state[1].ToString("X").PadLeft(8, '0'), state[0].ToString("X").PadLeft(8, '0'));
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
            ratio.Minimum = 1; ratio.Maximum = 100; label10.Visible = false; location.Visible = false; patch_board.Visible = false;

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
                    if (method == 5)
                        max.Value = 1000;
                }
                slots.Visible = true; s.Visible = true; sync.Visible = true;
                
                if (method == 1 || method == 2 || method == 3 || method == 6)
                {
                    if (!orasRadio.Checked && method == 1)
                    { label10.Visible = true; location.Visible = true; }
                    r.Text = "Ratio";
                    if (method == 1)
                        cave.Visible = true;

                    if (method != 3) { r.Visible = true; ratio.Visible = true; }
                    
                    if (method == 2)
                        ratio.Value = 49;
                    else
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

        private void ManageColumns(byte method)
        {
            if (SearchGen.SelectedTab == Srch)
            {
                Searcher.Columns["s_Enctr"].Visible = true; Searcher.Columns["s_Slot"].Visible = true; 
                Searcher.Columns["s_Sync"].Visible = true; Searcher.Columns["s_Item"].Visible = true;
                Searcher.Columns["s_HA"].Visible = false; Searcher.Columns["s_Music"].Visible = false;
                Searcher.Columns["s_Item"].Width = 50;
                if (method == 0)
                {
                    Searcher.Columns["s_Enctr"].HeaderText = "TID"; Searcher.Columns["s_Sync"].HeaderText = "SID";
                    Searcher.Columns["s_Slot"].HeaderText = "TSV"; Searcher.Columns["s_Item"].HeaderText = "TRV";
                    Searcher.Columns["s_Rand"].HeaderText = "Rand#";
                    Searcher.Columns["s_Flute"].Visible = false;
                }
                else
                {
                    Searcher.Columns["s_Enctr"].HeaderText = "Enctr?"; Searcher.Columns["s_Sync"].HeaderText = "Sync?";
                    Searcher.Columns["s_Slot"].HeaderText = "Slot"; Searcher.Columns["s_Item"].HeaderText = "Item";
                    Searcher.Columns["s_Rand"].HeaderText = "Rand(100)";

                    if (orasRadio.Checked)
                        Searcher.Columns["s_Flute"].Visible = true;
                    else
                        Searcher.Columns["s_Flute"].Visible = false;

                    if (method == 1 || method == 2 || method == 3 || method == 6)
                        Searcher.Columns["s_Enctr"].Visible = true;
                        
                    else if (method == 4)
                    {
                        Searcher.Columns["s_Enctr"].Visible = false;
                        Searcher.Columns["s_HA"].Visible = true;
                        Searcher.Columns["s_Item"].Width = 150;
                    }
                        
                    else
                    {
                        Searcher.Columns["s_Enctr"].Visible = false;
                        Searcher.Columns["s_Music"].Visible = true;
                        if (ratio.Value == 0)
                        {
                            Searcher.Columns["s_Slot"].Visible = true;
                            Searcher.Columns["s_Sync"].Visible = true; 
                            Searcher.Columns["s_Item"].Visible = true;
                        } else
                        {
                            Searcher.Columns["s_Slot"].Visible = false; 
                            Searcher.Columns["s_Sync"].Visible = false;
                            Searcher.Columns["s_Item"].Visible = false;
                        }
                    }
                        
                }
            }
            else
            {
                Generator.Columns["g_Enctr"].Visible = true; Generator.Columns["g_Slot"].Visible = true;
                Generator.Columns["g_Sync"].Visible = true; Generator.Columns["g_Item"].Visible = true;
                Generator.Columns["g_HA"].Visible = false; Generator.Columns["g_Music"].Visible = false;
                Generator.Columns["g_Item"].Width = 50;
                if (method == 0)
                {
                    Generator.Columns["g_Enctr"].HeaderText = "TID"; Generator.Columns["g_Sync"].HeaderText = "SID";
                    Generator.Columns["g_Slot"].HeaderText = "TSV"; Generator.Columns["g_Item"].HeaderText = "TRV";
                    Generator.Columns["g_Rand"].HeaderText = "Rand#";
                    Generator.Columns["g_Flute"].Visible = false;
                } 
                else
                {
                    Generator.Columns["g_Enctr"].HeaderText = "Enctr?"; Generator.Columns["g_Sync"].HeaderText = "Sync?";
                    Generator.Columns["g_Slot"].HeaderText = "Slot"; Generator.Columns["g_Item"].HeaderText = "Item";
                    Generator.Columns["g_Rand"].HeaderText = "Rand(100)";

                    if (orasRadio.Checked)
                        Generator.Columns["g_Flute"].Visible = true;
                    else
                        Generator.Columns["g_Flute"].Visible = false;

                    if (method == 1 || method == 2 || method == 3 || method == 6)
                        Generator.Columns["g_Enctr"].Visible = true;

                    else if (method == 4)
                    {
                        Generator.Columns["g_Enctr"].Visible = false;
                        Generator.Columns["g_HA"].Visible = true;
                        Generator.Columns["g_Item"].Width = 150;
                    }

                    else
                    {
                        Generator.Columns["g_Enctr"].Visible = false;
                        Generator.Columns["g_Music"].Visible = true;
                        if (ratio.Value == 0)
                        {
                            Generator.Columns["g_Slot"].Visible = true;
                            Generator.Columns["g_Sync"].Visible = true;
                            Generator.Columns["g_Item"].Visible = true;
                        }
                        else
                        {
                            Generator.Columns["g_Slot"].Visible = false;
                            Generator.Columns["g_Sync"].Visible = false;
                            Generator.Columns["g_Item"].Visible = false;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
