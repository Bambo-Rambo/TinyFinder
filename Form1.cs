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
        uint seconds;
        byte count;
        bool Calibrated = false;
        uint initial = 0;
        byte searchMonth;

        public Form1()
        {
            InitializeComponent();

            xyRadio.Checked = true;
            year.Value = DateTime.Now.Year; month.SelectedIndex = (DateTime.Now.Month - 1);
            DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            Fields(0);
        }

        //Events
        private void xyRadio_CheckedChanged(object sender, EventArgs e) { Fields(0); }
        private void orasRadio_CheckedChanged(object sender, EventArgs e) { Fields(0); }
        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            sync.Enabled = true; slots.Enabled = true; s.Enabled = true;
            cave.Checked = false; sync.Checked = false;
            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    Fields((byte)Methods.SelectedIndex);
                    slots.Items.Clear();
                    break;
                case 1:     //Normal Wild
                    if (xyRadio.Checked)
                        location.SelectedIndex = 0;
                    Fields((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 2:     //Fishing
                    Fields((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 90;
                    slots.Items.Clear();
                    for (byte add = 1; add < 4; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 3:     //Rock Smash
                    Fields((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 140;
                    slots.Items.Clear();
                    for (byte add = 1; add < 6; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 4:     //Horde
                    hidden.SelectedIndex = 1;
                    Fields((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 90;
                    slots.Items.Clear();
                    for (byte add = 1; add < 4; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 5:     //Poke Radar
                    Fields((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
                case 6:     //Friend Safari
                    Fields((byte)Methods.SelectedIndex);
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
                if (ratio.Value == 0) { boost.Enabled = false; sync.Enabled = true; slots.Enabled = true; s.Enabled = true; }
                else { boost.Enabled = true; sync.Enabled = false; slots.Enabled = false; s.Enabled = false; }
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
            if (SearchGen.SelectedTab == tabPage1)
            {
                year.Enabled = true; DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
                DateLabel.Location = new Point(1, 71); month.Enabled = true; button1.Text = "Calibrate and Search"; find.Enabled = true;
            }
            else
            {
                year.Enabled = false; DateLabel.Text = "Current State"; DateLabel.Location = new Point(98, 71); month.Enabled = false;
                button1.Text = "Generate"; find.Enabled = false;
            }
        }
        private void t3_TextChanged(object sender, EventArgs e)
        { Calibrated = false; button1.Text = "Calibrate and Search"; }
        private void t2_TextChanged(object sender, EventArgs e)
        { Calibrated = false; button1.Text = "Calibrate and Search"; }
        private void t1_TextChanged(object sender, EventArgs e)
        { Calibrated = false; button1.Text = "Calibrate and Search"; }
        private void t0_TextChanged(object sender, EventArgs e)
        { Calibrated = false; button1.Text = "Calibrate and Search"; }

        //Main Event (Click Button)
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["EnctrCol"].Visible = false; dataGridView1.Columns["SyncCol"].Visible = false; dataGridView1.Columns["SlotCol"].Visible = false;
            dataGridView1.Columns["FluteCol"].Visible = false; dataGridView1.Columns["ItemCol"].Visible = false; dataGridView1.Columns["HACol"].Visible = false;
            dataGridView1.Columns["MusicCol"].Visible = false; dataGridView1.Columns["Rand100Col"].Visible = false; dataGridView1.Columns["TIDCol"].Visible = false;
            dataGridView1.Columns["SIDCol"].Visible = false; dataGridView1.Columns["TSVCol"].Visible = false; dataGridView1.Columns["TRVCol"].Visible = false;
            dataGridView1.Columns["RandHexCol"].Visible = false; dataGridView1.Columns["DateCol"].Visible = true;
            dataGridView1.Rows.Clear(); dataGridView1.Update();
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
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
            if (SearchGen.SelectedIndex == 0)
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
                    button1.Text = "Search";
                }
            }
            searchMonth = (byte)(month.SelectedIndex + 1); seconds = calc.findSeconds(searchMonth, Year); uint i = calc.findSeed(initial, seconds);

            ushort TID = (ushort)tid.Value; ushort SID = (ushort)sid.Value;
            switch (Methods.SelectedIndex)
            {
                case 0:     //ID
                    string date;
                    dataGridView1.Columns["TIDCol"].Visible = true; dataGridView1.Columns["SIDCol"].Visible = true; dataGridView1.Columns["TSVCol"].Visible = true;
                    dataGridView1.Columns["TRVCol"].Visible = true; dataGridView1.Columns["RandHexCol"].Visible = true;
                    dataGridView1.Update();
                    ID id = new ID(TID, SID);
                    uint randID = id.randhex;
                    while (dataGridView1.Rows.Count < 1)    //Search only for 1 for now
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
                                if (SearchGen.SelectedIndex == 1) { dataGridView1.Columns["DateCol"].Visible = false; date = null; }
                                else date = calc.secondsToDate(seconds, Year);

                                dataGridView1.Rows.Add(date,
                                 store_seed[3].ToString("X").PadLeft(8, '0'),
                                 store_seed[2].ToString("X").PadLeft(8, '0'),
                                 store_seed[1].ToString("X").PadLeft(8, '0'),
                                 store_seed[0].ToString("X").PadLeft(8, '0'), j,
                                 null, null, null, null, null, null, null, null,
                                 id.trainerID.ToString().PadLeft(5, '0'),
                                 id.secretID.ToString().PadLeft(5, '0'),
                                 id.TSV.ToString().PadLeft(4, '0'),
                                 id.TRV, id.randhex.ToString("X").PadLeft(8, '0'));
                                dataGridView1.Update();
                            }
                        }
                        if (SearchGen.SelectedIndex == 1)
                            break;

                        seconds++;
                        i += 1000;
                    }
                    break;


                case 1:     //Normal Wild
                case 2:     //Fishing
                case 6:     //Friend Safari

                    if (orasRadio.Checked && Methods.SelectedIndex == 6)
                    { MessageBox.Show("Friend Safari does not exist in ORAS games", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    byte SlotLimit = 4, SlotCase = 0;
                    if (Methods.SelectedIndex == 1) { SlotLimit = 13; }
                    if (Methods.SelectedIndex == 2) { SlotCase = 2; }
                    if (Methods.SelectedIndex == 6) { SlotCase = 1; }

                    dataGridView1.Columns["EnctrCol"].Visible = true;
                    dataGridView1.Columns["SyncCol"].Visible = true; dataGridView1.Columns["SlotCol"].Visible = true;
                    dataGridView1.Columns["ItemCol"].Visible = true; dataGridView1.Columns["Rand100Col"].Visible = true;
                    if (orasRadio.Checked)
                        dataGridView1.Columns["FluteCol"].Visible = true;
                    dataGridView1.Update();
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < SlotLimit; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);
                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    if (Methods.SelectedIndex == 1 && !orasRadio.Checked && !cave.Checked && location.SelectedIndex != 0)
                        EnctSync = (byte)(LocationData.getAdvances(location.SelectedItem.ToString()) + 1);

                    Wild wild;
                    while (dataGridView1.Rows.Count < found)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            wild = new Wild(array, orasRadio.Checked, cave.Checked || location.SelectedIndex == 7, SlotCase, EnctSync); // location.SelectedIndex == 7 -> Route 7
                            tiny.nextState(array);
                            if (wild.encounter < (byte)ratio.Value && Slots.Contains(wild.slot))
                            {
                                if (orasRadio.Checked)
                                {
                                    if (((flute1.Value != 0 && flute1.Value == wild.flute) || flute1.Value == 0)

                                     &&

                                     ((sync.Checked && wild.Sync) || !sync.Checked))
                                        ShowWild(wild, calc.secondsToDate(seconds, Year), store_seed, j, true);
                                }
                                else
                                    if ((sync.Checked && wild.Sync) || !sync.Checked)
                                    ShowWild(wild, calc.secondsToDate(seconds, Year), store_seed, j, false);
                            }
                        }
                        if (SearchGen.SelectedIndex == 1)
                            break;

                        seconds++;
                        if (seconds % 3000 == 0)
                            dataGridView1.Update();
                        i += 1000;
                    }
                    break;


                case 3:     //Rock Smash
                    dataGridView1.Columns["EnctrCol"].Visible = true; dataGridView1.Columns["SyncCol"].Visible = true; dataGridView1.Columns["SlotCol"].Visible = true;
                    dataGridView1.Columns["ItemCol"].Visible = true; dataGridView1.Columns["Rand100Col"].Visible = true;
                    if (orasRadio.Checked)
                        dataGridView1.Columns["FluteCol"].Visible = true;
                    dataGridView1.Update();
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < 6; s++)
                    {
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);
                    }
                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                    RockSmash smash;
                    while (dataGridView1.Rows.Count < found)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            smash = new RockSmash(array, orasRadio.Checked, 3);
                            tiny.nextState(array);
                            if (smash.encounter == 0 && Slots.Contains(smash.slot)) //Encounter must be 0 to generate Pokemon in Rock Smash
                            {
                                if (orasRadio.Checked)
                                {
                                    if (((flute1.Value != 0 && flute1.Value == smash.flute) || flute1.Value == 0)

                                     &&

                                     ((sync.Checked && smash.Sync) || !sync.Checked))
                                        ShowSmash(smash, calc.secondsToDate(seconds, Year), store_seed, j, true);
                                }
                                else
                                    if ((sync.Checked && smash.Sync) || !sync.Checked)
                                    ShowSmash(smash, calc.secondsToDate(seconds, Year), store_seed, j, false);
                            }
                        }
                        if (SearchGen.SelectedIndex == 1)
                            break;

                        seconds++;
                        if (seconds % 3000 == 0)
                            dataGridView1.Update();
                        i += 1000;
                    }
                    break;


                case 4:     //Horde
                    Slots = new HashSet<byte>();
                    dataGridView1.Columns["SyncCol"].Visible = true; dataGridView1.Columns["SlotCol"].Visible = true;
                    dataGridView1.Columns["ItemCol"].Visible = true; dataGridView1.Columns["HACol"].Visible = true; dataGridView1.Columns["Rand100Col"].Visible = true;
                    if (orasRadio.Checked)
                    {
                        dataGridView1.Columns["FluteCol"].Visible = true;
                        fluteArray[0] = (byte)flute1.Value;
                        fluteArray[1] = (byte)flute2.Value;
                        fluteArray[2] = (byte)flute3.Value;
                        fluteArray[3] = (byte)flute4.Value;
                        fluteArray[4] = (byte)flute5.Value;
                    }
                    dataGridView1.Update();
                    Slots = new HashSet<byte>();
                    for (byte s = 1; s < 4; s++)
                        if (slots.CheckBoxItems[s - 1].Checked)
                            Slots.Add(s);

                    if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                    Horde horde;
                    while (dataGridView1.Rows.Count < found)
                    {
                        if (SearchGen.SelectedIndex == 0)
                            array = tiny.init(i, 1);
                        array.CopyTo(store_seed, 0);

                        for (uint j = 0; j < Min; j++)
                            tiny.nextState(array);
                        for (uint j = Min; j <= Max; j++)
                        {
                            horde = new Horde(array, (byte)party.Value, orasRadio.Checked, cave.Checked);
                            tiny.nextState(array);
                            if (Slots.Contains(horde.slot))
                                if (((Enumerable.Range(2, 6).Contains(hidden.SelectedIndex) && horde.HA == hidden.SelectedIndex - 1) //Seach for HA in specific slot
                                    || (hidden.SelectedIndex == 1 && horde.HA != 0)         //Search for HA in any slot
                                    || hidden.SelectedIndex == 0)                           //Don't search for HA

                                    &&

                                    ((sync.Checked && horde.sync)
                                    || !sync.Checked))
                                    ShowHorde(horde, calc.secondsToDate(seconds, Year), store_seed, j, orasRadio.Checked);
                        }
                        if (SearchGen.SelectedIndex == 1)
                            break;

                        seconds++;
                        if (seconds % 100 == 0)
                            dataGridView1.Update();
                        i += 1000;
                    }
                    break;


                case 5:     //Radar
                    if (orasRadio.Checked)
                    { MessageBox.Show("Poke Radar does not exist in ORAS games", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }

                    dataGridView1.Columns["Rand100Col"].Visible = true; dataGridView1.Columns["MusicCol"].Visible = true;
                    Radar radar;
                    if (ratio.Value == 0)
                    {
                        dataGridView1.Columns["SyncCol"].Visible = true; dataGridView1.Columns["SlotCol"].Visible = true;
                        dataGridView1.Columns["ItemCol"].Visible = true; dataGridView1.Update();
                        Slots = new HashSet<byte>();
                        for (byte s = 1; s < 13; s++)
                            if (slots.CheckBoxItems[s - 1].Checked)
                                Slots.Add(s);
                        if (Slots.Count == 0) { MessageBox.Show("No slots have been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                        while (dataGridView1.Rows.Count < found)
                        {
                            if (SearchGen.SelectedIndex == 0)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar = new Radar(array, 0, (byte)party.Value, false); //Set the Boost Music to be false for now
                                tiny.nextState(array);
                                if (Slots.Contains(radar.slot) && radar.Music == 'A' && ((sync.Checked && radar.sync) || (!sync.Checked)))
                                    ShowRadar(radar, calc.secondsToDate(seconds, Year), store_seed, j, 0);
                            }
                            if (SearchGen.SelectedIndex == 1)
                                break;

                            seconds++;
                            if (seconds % 1000 == 0)
                                dataGridView1.Update();
                            i += 1000;
                        }
                    }
                    else
                    {
                        dataGridView1.Update();
                        while (dataGridView1.Rows.Count < found)
                        {
                            if (SearchGen.SelectedIndex == 0)
                                array = tiny.init(i, 1);
                            array.CopyTo(store_seed, 0);

                            for (uint j = 0; j < Min; j++)
                                tiny.nextState(array);
                            for (uint j = Min; j <= Max; j++)
                            {
                                radar = new Radar(array, (byte)ratio.Value, (byte)party.Value, boost.Checked);
                                tiny.nextState(array);
                                if (radar.Shiny)
                                    ShowRadar(radar, calc.secondsToDate(seconds, Year), store_seed, j, (byte)ratio.Value);
                            }
                            if (SearchGen.SelectedIndex == 1)
                                break;

                            seconds++;
                            if (seconds % 100 == 0)
                                dataGridView1.Update();
                            i += 1000;
                        }
                    }
                    break;
            }
        }

        //Show Results
        private void ShowWild(Wild wild, string date, uint[] store_seed, uint index, bool isORAS)
        {
            if (SearchGen.SelectedIndex == 1) { date = null; dataGridView1.Columns["DateCol"].Visible = false; }

            if (isORAS)
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                wild.encounter, wild.Sync, wild.slot, wild.flute, wild.item + "%", null, null, wild.randInt);
            else
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                wild.encounter, wild.Sync, wild.slot, null, wild.item + "%", null, null, wild.randInt);
        }

        private void ShowSmash(RockSmash smash, string date, uint[] store_seed, uint index, bool isORAS)
        {
            if (SearchGen.SelectedIndex == 1) { date = null; dataGridView1.Columns["DateCol"].Visible = false; }

            if (isORAS)
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                smash.encounter, smash.Sync, smash.slot, smash.flute, smash.item + "%", null, null, smash.randInt);
            else
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                smash.encounter, smash.Sync, smash.slot, null, smash.item + "%", null, null, smash.randInt);
        }

        private void ShowHorde(Horde horde, string date, uint[] store_seed, uint index, bool isORAS)
        {
            if (SearchGen.SelectedIndex == 1) { date = null; dataGridView1.Columns["DateCol"].Visible = false; }

            if (isORAS)
            {
                count = 0;
                for (byte f = 0; f < 5; f++)
                {
                    if ((fluteArray[f] != 0 && fluteArray[f] == horde.flutes[f]) || fluteArray[f] == 0)
                        count++;
                }
                if (count == 5)
                    dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                    store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index, null, horde.sync, horde.slot,
                    horde.flutes[0] + ", " + horde.flutes[1] + ", " + horde.flutes[2] + ", " + horde.flutes[3] + ", " + horde.flutes[4],
                    horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%",
                        horde.HA, null, horde.randInt);

            }
            else
            {
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index, null, horde.sync,
                horde.slot, null, horde.items[0] + "%, " + horde.items[1] + "%, " + horde.items[2] + "%, " + horde.items[3] + "%, " + horde.items[4] + "%",
                    horde.HA, null, horde.randInt);
            }
        }

        private void ShowRadar(Radar radar, string date, uint[] store_seed, uint index, byte chain)
        {
            if (SearchGen.SelectedIndex == 1) { date = null; dataGridView1.Columns["DateCol"].Visible = false; }

            if (chain == 0)
            {
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                null, radar.sync, radar.slot, null, radar.item + "%", null, radar.Music, radar.randInt);
            }
            else
            {
                dataGridView1.DefaultCellStyle.BackColor = Color.LightCyan;
                dataGridView1.Rows.Add(date, store_seed[3].ToString("X").PadLeft(8, '0'), store_seed[2].ToString("X").PadLeft(8, '0'),
                store_seed[1].ToString("X").PadLeft(8, '0'), store_seed[0].ToString("X").PadLeft(8, '0'), index,
                null, null, null, null, null, null, radar.Music, radar.randInt);
            }
        }

        //Manage Controls
        private void Fields(byte method)
        {
            min.Value = min.Minimum = 35;
            Methods.SelectedIndex = method;
            label3.Visible = false; label4.Visible = false; tid.Visible = false; sid.Visible = false; slots.Visible = false; s.Visible = false;
            hidden.Visible = false; h.Visible = false; flute.Visible = false; flute1.Visible = false; label11.Visible = false; flute2.Visible = false;
            label12.Visible = false; flute3.Visible = false; label13.Visible = false; flute4.Visible = false; label14.Visible = false; flute5.Visible = false;
            sync.Visible = false; cave.Visible = false; boost.Visible = false; p.Visible = false; party.Visible = false; r.Visible = false; ratio.Visible = false;
            ratio.Minimum = 1; ratio.Maximum = 100; label10.Visible = false; location.Visible = false;
            if (method == 0)
            {
                if (orasRadio.Checked) { min.Value = min.Minimum = 11; }
                max.Value = 150;
                label3.Visible = true; label4.Visible = true; tid.Visible = true; sid.Visible = true;
            }
            else
            {
                if (orasRadio.Checked) { min.Value = min.Minimum = 25; }
                max.Value = 200;
                slots.Visible = true; s.Visible = true; sync.Visible = true;

                if (method == 1 || method == 2 || method == 3 || method == 6)
                {
                    if (!orasRadio.Checked && method == 1) { label10.Visible = true; location.Visible = true; cave.Visible = true; }
                    r.Text = "Ratio";
                    if (method != 3) { r.Visible = true; ratio.Visible = true; }
                    if (orasRadio.Checked) { flute.Visible = true; flute1.Visible = true; }
                    if (method == 2)
                        ratio.Value = 49;
                    else
                        ratio.Value = 13;
                }
                else if (method == 4)
                {
                    hidden.Visible = true; h.Visible = true; cave.Visible = true; p.Visible = true; party.Visible = true;
                    if (orasRadio.Checked)
                    {
                        flute.Visible = true; flute1.Visible = true; label11.Visible = true; flute2.Visible = true; label12.Visible = true;
                        flute3.Visible = true; label13.Visible = true; flute4.Visible = true; label14.Visible = true; flute5.Visible = true;
                    }
                }
                else
                {
                    r.Text = "Chain"; r.Visible = true; ratio.Visible = true; ratio.Minimum = 0; ratio.Maximum = 60; ratio.Value = 0;
                    p.Visible = true; party.Visible = true; boost.Visible = true;
                }
            }
        }
    }
}

