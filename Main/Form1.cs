using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using TinyFinder.Subforms.Profile_Calibration;
using TinyFinder.Subforms.Profile_Manager;

namespace TinyFinder
{
    public partial class Form1 : Form
    {
        HashSet<byte> Slots;
        byte[] fluteArray = { 0, 0, 0, 0, 0 };
        Calculate calc = new Calculate();
        TinyMT tiny = new TinyMT();
        SlotData LocationData = new SlotData();
        NTRHelper ntrhelper;
        Calibrator calibrator;
        Manager manager;
        uint seconds, initial = 0;
        byte count, searchMonth, SlotLimit;
        bool Calibrated = false;
        string MethodUsed;

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
            year.Value = DateTime.Now.Year; month.SelectedIndex = DateTime.Now.Month - 1;
            DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            ManageControls(0);
        }

        private string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');
        private bool isRadar1() => xyRadio.Checked && Methods.SelectedIndex == 6 && ratio.Value > 0;

        #region Events
        private void xyRadio_CheckedChanged(object sender, EventArgs e)
        {
            Methods.Items[6] = "Radar";
            if (Methods.Items.Count == 7)
            {
                Methods.Items.Add("Friend Safari");
                Methods.Items.Add("Swooping");
            }
            ManageControls(0);
        }
        private void orasRadio_CheckedChanged(object sender, EventArgs e)
        {
            Methods.Items.Remove("Friend Safari");
            Methods.Items.Remove("Swooping");
            Methods.Items[6] = "DexNav";
            ManageControls(0);
        }
        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            slots.Text = "";
            surfLocation.Items.Clear();
            surfLocation.Items.Add("Elsewhere");
            surfLocation.SelectedIndex = 0;
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
                    water.Checked = false;
                    for (byte i = 0; i < 3; i++)
                        surfLocation.Items.Add(LocationData.getLocation(i));
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
                case 8:     //Swooping
                    ManageControls((byte)Methods.SelectedIndex);
                    slots.DropDownHeight = 310;
                    slots.Items.Clear();
                    for (byte add = 1; add < 13; add++)
                        slots.Items.AddRange(new object[] { add.ToString() });
                    break;
            }
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            Calibrated = false; 
            button1.Text = "Calibrate and Search";
        }

        private void ratio_ValueChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 6 && xyRadio.Checked)
            {
                sync.Enabled = slots.Enabled = s.Enabled = ratio.Value == 0 ? true : false;
                boost.Enabled = water.Enabled = !sync.Enabled;
            }
        }

        private void cave_CheckedChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedItem.ToString() != "DexNav")
            {
                label10.Enabled = location.Enabled = surfLocation.Enabled = cave.Checked ? false : true;
                ratio.Value = cave.Checked ? 7 : 13;
            }
        }

        private void water_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRadar1())
            {
                slots.Items.Clear();
                slots.Text = "";
            }
            if (Methods.SelectedIndex == 5)
            {
                if (water.Checked)
                {
                    if (orasRadio.Checked)
                        label10.Visible = surfLocation.Visible = true;
                    slots.DropDownHeight = 140;
                    SlotLimit = 6;
                }
                else
                {
                    label10.Visible = surfLocation.Visible = false;
                    slots.DropDownHeight = 310;
                    SlotLimit = 13;
                }
            }
            if (Methods.SelectedIndex == 6 && orasRadio.Checked)
            {
                slots.DropDownHeight = 310;
                SlotLimit = 13;
                if (NavType.SelectedIndex == 1)
                {
                    slots.DropDownHeight = 90;
                    SlotLimit = 4;
                }
                else if (water.Checked)
                {
                    slots.DropDownHeight = 140;
                    SlotLimit = 6;
                }
            }

            if (!isRadar1())
                for (byte add = 1; add < SlotLimit; add++)
                    slots.Items.AddRange(new object[] { add.ToString() });
        }

        private void dexnavpokes_CheckedChanged(object sender, EventArgs e)
        {
            if (dexnavpokes.Checked)
                NavType.Enabled = true;
            else
            {
                NavType.SelectedIndex = 0;
                NavType.Enabled = false;
            }
        }

        private void NavType_SelectedIndexChanged(object sender, EventArgs e)
        {
            slots.Items.Clear();
            slots.Text = "";
            if (NavType.SelectedIndex == 0)
            {
                if (!water.Checked)
                {
                    slots.DropDownHeight = 310;
                    SlotLimit = 13;
                }
                else
                {
                    slots.DropDownHeight = 140;
                    SlotLimit = 6;
                }
            }
            else
            {
                slots.DropDownHeight = 90;
                SlotLimit = 4;
            }
            for (byte add = 1; add < SlotLimit; add++)
                slots.Items.AddRange(new object[] { add.ToString() });
        }

        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedTab == Srch)
            {
                DateLabel.Location = new Point(1, 71);
                DateLabel.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
                button1.Text = Calibrated ? "Search" : "Calibrate and Search";
                label9.Enabled = atleast.Enabled = mo.Visible = month.Visible = true;
                y.Visible = year.Visible = true;
                StepLabel.Visible = ChainLabel.Visible = false;
                ignoreFilters.Checked = ignoreFilters.Enabled = false;
                Generator.Visible = ntr.Enabled = updateBTN.Visible = false;
                Searcher.Visible = true;
                min.Value = min.Minimum = xyRadio.Checked ? 35 :
                                          (orasRadio.Checked && Methods.SelectedIndex == 0) ? 11 :
                                          (orasRadio.Checked && Methods.SelectedIndex != 0) ? 20 : 0;
                max.Value = (xyRadio.Checked && Methods.SelectedIndex == 6) ? 800 : 150;

            }
            else
            {
                DateLabel.Location = new Point(98, 71);
                DateLabel.Text = "Current State";
                button1.Text = "Generate";
                label9.Enabled = atleast.Enabled = mo.Visible = month.Visible = false;
                ntr.Enabled = updateBTN.Visible = true;
                ignoreFilters.Enabled = true;
                Searcher.Visible = year.Visible = y.Visible = false;
                Generator.Visible = true;
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }
        }

        private void TinyChanged()
        {
            if (SearchGen.SelectedTab == Srch)
            {
                Calibrated = false;
                button1.Text = "Calibrate and Search";
            }
        }
        private void t3_TextChanged(object sender, EventArgs e)
        {
            TinyChanged();
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {
            TinyChanged();
        }
        private void t1_TextChanged(object sender, EventArgs e)
        {
            TinyChanged();
        }
        private void t0_TextChanged(object sender, EventArgs e)
        {
            TinyChanged();
        }

        private int getIndex(ref DataGridView view, int row)
        {
            //When sort the rows, it would show the spots for the clicked row numer not for the clicked TinyMT index
            int IndexNumber = Convert.ToInt32(view.Rows[row].Cells["Index"].Value);  //The clicked TinyMT index
            int num = 0;
            foreach (PatchSpot i in GPatchSpots)
            {
                if (i.index == IndexNumber)
                    break;
                num++;
            }
            return num;
        }
        private void Generator_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Methods.SelectedIndex == 6)
            {
                if (xyRadio.Checked)
                {
                    try
                    {
                        patch_board.Text = string.Join("\n", GPatchSpots[getIndex(ref Generator, e.RowIndex)].spots);
                    }
                    catch
                    { }
                }
                else
                {
                    try
                    {
                        //To do
                        int one = Convert.ToInt32(Generator.Rows[e.RowIndex].Cells[1].Value.ToString());
                        int two = Convert.ToInt32(Generator.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    catch
                    { }
                }
            }
        }
        private void Searcher_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Searcher doesn't work with getIndex() because multiple indexes have the same number. Possibly use the Rand(100) as well
            //Currently doesn't work when sort the rows. To do
            try
            {
                patch_board.Text = string.Join("\n", SPatchSpots[e.RowIndex].spots);
            }
            catch
            { }
        }

        private void Generator_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To do
            /*if (e.Button == MouseButtons.Right)
            {
                t3.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [3]"].Value);
                t2.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [2]"].Value);
                t1.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [1]"].Value);
                t0.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [0]"].Value);
            }*/
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                NTRHelper.ntrclient.ReadTiny("TTT");
                if (Methods.SelectedIndex == 6)
                {
                    if (orasRadio.Checked)
                    {
                        NTRHelper.ntrclient.ReadTiny("Step");
                        NTRHelper.ntrclient.ReadTiny("DexNavChain");
                    }
                    else
                    {
                        NTRHelper.ntrclient.ReadTiny("RadarChain");
                    }
                }
                button1.PerformClick();
            }
            catch
            {
                MessageBox.Show("Press One Click", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnConnected_Changed(bool IsConnected)
        {
            updateBTN.Enabled = IsConnected;
        }

        public void parseNTRInfo(string name, object state)
        {
            switch (name)
            {
                case "TTT":
                    var tiny = (uint[])state;
                    t3.Value = tiny[3];
                    t2.Value = tiny[2];
                    t1.Value = tiny[1];
                    t0.Value = tiny[0];
                    return;
                case "Step":
                    var steps = (uint[])state;
                    StepLabel.Visible = true;
                    if (steps[0] == 19)
                        StepLabel.ForeColor = Color.Red;
                    else
                        StepLabel.ForeColor = Color.Black;
                    StepLabel.Location = new Point(25, 100);
                    StepLabel.Text = "Step Counter   =   " + steps[0].ToString();
                    break;
                case "DexNavChain":
                    var chain = (uint[])state;
                    ratio.Value = chain[0];
                    ChainLabel.Visible = true;
                    ChainLabel.Location = new Point(25, 140);
                    ChainLabel.Text = "Chain Length   =   " + chain[0].ToString();
                    break;
                case "RadarChain":
                    var chainRadar = (uint[])state;
                    //ratio.Value = chainRadar[0];
                    ChainLabel.Visible = true;
                    ChainLabel.Location = new Point(25, 118);
                    ChainLabel.Text = "Chain Length   =   " + chainRadar[0].ToString();
                    break;
            }
        }

        private void ntr_Click(object sender, EventArgs e)
        {
            if (ntrhelper == null)
                ntrhelper = new NTRHelper();
            ntrhelper.Show();
            ntrhelper.Focus();
        }

        private void profiles_Click(object sender, EventArgs e)
        {
            if (calibrator == null)
                calibrator = new Calibrator();
            calibrator.Show();
            calibrator.Focus();
        }

        private void profilemanager_Click(object sender, EventArgs e)
        {
            if (manager == null)
                manager = new Manager();
            manager.Show();
            manager.Focus();
        }

        #endregion

        #region Manage Controls
        private void ManageControls(byte method)
        {
            Methods.SelectedIndex = method;
            label3.Visible = label4.Visible = tid.Visible = sid.Visible = slots.Visible = s.Visible = hidden.Visible = h.Visible =
            flutelabel.Visible = flute1.Visible = label11.Visible = flute2.Visible = label12.Visible = flute3.Visible =
            label13.Visible = flute4.Visible = label14.Visible = flute5.Visible = sync.Visible = cave.Visible = boost.Visible =
            p.Visible = party.Visible = r.Visible = ratio.Visible = label10.Visible = location.Visible = patch_board.Visible =
            water.Visible = surfLocation.Visible = navFilters.Visible = NavType.Visible = label15.Visible = label16.Visible =
            label17.Visible = potential.Visible = dexnavpokes.Visible = StepLabel.Visible = ChainLabel.Visible = false;
            cave.Checked = false;
            water.Text = "Surf";
            ratio.Minimum = 1; ratio.Maximum = 100;
            if (SearchGen.SelectedIndex == 0)
            {
                min.Value = min.Minimum = xyRadio.Checked ? 35 :
                                          (orasRadio.Checked && Methods.SelectedIndex == 0) ? 11 :
                                          (orasRadio.Checked && Methods.SelectedIndex != 0) ? 20 : 0;
                max.Value = (xyRadio.Checked && Methods.SelectedIndex == 6) ? 800 : 150;
            }
            else
            {
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }

            if (method == 0)
            {
                label3.Location = new Point(109, 79);
                tid.Location = new Point(139, 77);
                label4.Location = new Point(109, 118);
                sid.Location = new Point(139, 116);
                label3.Visible = label4.Visible = tid.Visible = sid.Visible = true;
            }
            else
            {
                s.Location = new Point(13, 46);
                slots.Location = new Point(75, 42);
                flutelabel.Location = new Point(16, 98);
                flute1.Location = new Point(75, 94);
                sync.Location = new Point(53, 148);
                flutelabel.Text = "Flute";
                p.Location = new Point(230, 193);
                p.Text = "Party";
                cave.Text = "Cave";
                party.Maximum = 6;
                if (orasRadio.Checked)
                    flutelabel.Visible = flute1.Visible = true;
                s.Text = "Slots";
                slots.Visible = s.Visible = sync.Visible = true;

                if (method == 1 || method == 2 || method == 3 || method == 7 || method == 8)
                {
                    if (!orasRadio.Checked && method == 1)
                        label10.Visible = location.Visible = true;

                    r.Text = "Ratio";
                    if (method == 1)
                        cave.Visible = true;

                    if (method != 3)
                        r.Visible = ratio.Visible = true;

                    if (method == 2)
                        ratio.Value = 49;
                    else if (!cave.Checked || method == 7)
                        ratio.Value = 13;
                    if (method == 8)
                        r.Visible = ratio.Visible = false;
                }

                else if (method == 4)
                {
                    flutelabel.Text = "Flute 1";
                    h.Location = new Point(16, 98);
                    hidden.Location = new Point(75, 94);
                    flutelabel.Location = new Point(266, 55);
                    flute1.Location = new Point(334, 52);
                    hidden.Visible = h.Visible = cave.Visible = p.Visible = party.Visible = true;
                    if (orasRadio.Checked)
                        flutelabel.Visible = flute1.Visible = label11.Visible = flute2.Visible = label12.Visible = flute3.Visible =
                            label13.Visible = flute4.Visible = label14.Visible = flute5.Visible = true;
                }

                else if (method == 5)
                {
                    p.Visible = party.Visible = cave.Visible = water.Visible = true;
                    if (orasRadio.Checked && water.Checked)
                    {
                        label10.Visible = surfLocation.Visible = true;
                        if (cave.Checked)
                            surfLocation.Enabled = false;
                        else
                            surfLocation.Enabled = true;
                    }
                }

                else if (method == 6)
                {
                    r.Text = "Chain";
                    ratio.Minimum = 0;
                    if (xyRadio.Checked)
                    {
                        r.Visible = ratio.Visible = p.Visible = party.Visible = boost.Visible = patch_board.Visible = water.Visible = true;
                        water.Text = "Use from bag";
                        s.Enabled = slots.Enabled = sync.Enabled = false;
                        ratio.Value = 1;
                        ratio.Maximum = 60;
                        patch_board.Location = new Point(205, 26);
                        patch_board.Text = "#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########";
                    }
                    else
                    {
                        NavType.SelectedIndex = 0;
                        ratio.Value = 0;
                        cave.Text = "Shiny Charm";
                        party.Maximum = 999;
                        party.Value = 999;
                        p.Location = new Point(185, 194);
                        p.Text = "Search Level";
                        sync.Visible = false;
                        NavType.Visible = navFilters.Visible = party.Visible = ratio.Visible = p.Visible = r.Visible = cave.Visible =
                        label15.Visible = label16.Visible = label17.Visible = potential.Visible = dexnavpokes.Visible = water.Visible = true;
                        label15.Location = new Point(9, 45);
                        s.Location = new Point(9, 93);
                        label16.Location = new Point(9, 140);
                        NavType.Location = new Point(71, 41);
                        slots.Location = new Point(71, 89);
                        navFilters.Location = new Point(71, 137);
                        label17.Location = new Point(254, 93);
                        potential.Location = new Point(341, 89);
                        flutelabel.Location = new Point(254, 140);
                        flute1.Location = new Point(341, 137);
                    }
                }
            }
        }

        #endregion

        #region ManageDataGridviews
        private void ManageGenColumns(ref DataTable table, byte method)
        {
            Generator.Columns.Clear();
            table.Columns.Clear();
            table.Columns.Add("Index", typeof(uint));
            if (method == 0)
            {
                table.Columns.Add("TID", typeof(string));
                table.Columns.Add("SID", typeof(string));
                table.Columns.Add("TSV", typeof(string));
                table.Columns.Add("TRV", typeof(byte));
                table.Columns.Add("Rand#", typeof(string));
            }
            else
            {
                if (method == 1 || method == 2 || method == 3 || method == 7)
                {
                    table.Columns.Add("Enctr", typeof(byte));
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                }
                else if (method == 4)
                {
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                    table.Columns.Add("HA", typeof(byte));
                    table.Columns.Add("Flute", typeof(string));
                }
                else if (method == 5 || method == 8)
                {
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                }
                else if (method == 6)
                {
                    if (xyRadio.Checked)
                    {
                        if (ratio.Value == 0)
                        {
                            table.Columns.Add("Sync", typeof(string));
                            table.Columns.Add("Slot", typeof(byte));
                        }
                        else
                        {
                            table.Columns.Add("Shiny", typeof(string));
                        }
                        table.Columns.Add("Music", typeof(char));
                    }
                    else
                    {
                        table.Columns.Add("Right", typeof(sbyte));
                        table.Columns.Add("Up", typeof(sbyte));
                        //table.Columns.Add("Rate", typeof(byte));
                        table.Columns.Add("Success", typeof(string));
                        table.Columns.Add("Type", typeof(string));
                        table.Columns.Add("Sync", typeof(string));
                        table.Columns.Add("Slot", typeof(byte));
                        table.Columns.Add("Shiny", typeof(string));
                        table.Columns.Add("Level", typeof(string));
                        table.Columns.Add("HA", typeof(string));
                        table.Columns.Add("Egg Move", typeof(string));
                        table.Columns.Add("Potential", typeof(byte));
                    }
                }
                if (method != 4)
                    if (orasRadio.Checked)
                        table.Columns.Add("Flute", typeof(byte));

                if (method != 6 || (method == 6 && !orasRadio.Checked))
                    table.Columns.Add("Item", typeof(string));

                if (method == 6 && xyRadio.Checked && ratio.Value > 0)
                    table.Columns.Remove("Item");

                table.Columns.Add("Rand(100)", typeof(byte));
            }
            table.Columns.Add("Tiny [3]", typeof(string));
            table.Columns.Add("Tiny [2]", typeof(string));
            table.Columns.Add("Tiny [1]", typeof(string));
            table.Columns.Add("Tiny [0]", typeof(string));
        }

        private void ManageGenerator(ref DataGridView Generator, DataTable table, string method)
        {
            Generator.DataSource = table;
            Generator.Columns[0].Width = 60;
            if (Equals(method, "ID"))
            {
                Generator.Columns["TID"].Width = Generator.Columns["SID"].Width = Generator.Columns["TSV"].Width = 50;
                Generator.Columns["TRV"].Width = 35;
                Generator.Columns["Rand#"].Width = 85;
            }
            else if (Equals(method, "Wild") || Equals(method, "Rock Smash"))
            {
                Generator.Columns["Enctr"].Width = Generator.Columns["Sync"].Width = 
                    Generator.Columns["Slot"].Width = Generator.Columns["Item"].Width = 50;
                if (orasRadio.Checked)
                    Generator.Columns["Flute"].Width = 50;
            }
            else if (Equals(method, "Horde")) 
            {
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["HA"].Width = 50;
                Generator.Columns["Item"].Width = 150;
                if (orasRadio.Checked)
                    Generator.Columns["Flute"].Width = 75;
            }
            else if (Equals(method, "Honey"))
            {
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["Item"].Width = 50;
                if (orasRadio.Checked)
                    Generator.Columns["Flute"].Width = 50;
            }
            else if (Equals(method, "Radar0"))
            {
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["Music"].Width =
                    Generator.Columns["Item"].Width = 50;
            }
            else if (Equals(method, "Radar1"))
            {
                Generator.Columns["Shiny"].Width = Generator.Columns["Music"].Width = 50;
            }
            else if (Equals(method, "DexNav"))
            {
                Generator.Columns["Right"].Width = Generator.Columns["Up"].Width = 40;
                Generator.Columns["Success"].Width = 55;
                Generator.Columns["Type"].Width = Generator.Columns["Potential"].Width = 60;
                Generator.Columns["Level"].Width = 60;
                Generator.Columns["Egg Move"].Width = 85;
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["Shiny"].Width =
                    Generator.Columns["Flute"].Width = Generator.Columns["HA"].Width = 50;
            }
            else if (Equals(method, "Swooping"))
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["Item"].Width = 50;

            Generator.Columns["Tiny [3]"].Width = Generator.Columns["Tiny [2]"].Width = 
                Generator.Columns["Tiny [1]"].Width = Generator.Columns["Tiny [0]"].Width = 75;
            if (!Equals(method, "ID"))
                Generator.Columns["Rand(100)"].Width = 85;
        }

        private void ManageSearcher(ref DataGridView Searcher, byte method)
        {
            Searcher.Columns.Clear();
            Searcher.Columns.Add("date", "Date"); Searcher.Columns["date"].Width = 120;
            Searcher.Columns.Add("tiny3", "Tiny [3]"); Searcher.Columns["tiny3"].Width = 75;
            Searcher.Columns.Add("tiny2", "Tiny [2]"); Searcher.Columns["tiny2"].Width = 75;
            Searcher.Columns.Add("tiny1", "Tiny [1]"); Searcher.Columns["tiny1"].Width = 75;
            Searcher.Columns.Add("tiny0", "Tiny [0]"); Searcher.Columns["tiny0"].Width = 75;
            Searcher.Columns.Add("index", "Index"); Searcher.Columns["index"].Width = 60;
            if (method == 0)
            {
                Searcher.Columns.Add("tid", "TID"); Searcher.Columns["tid"].Width = 50;
                Searcher.Columns.Add("sid", "SID"); Searcher.Columns["sid"].Width = 50;
                Searcher.Columns.Add("tsv", "TSV"); Searcher.Columns["tsv"].Width = 50;
                Searcher.Columns.Add("trv", "TRV"); Searcher.Columns["trv"].Width = 35;
                Searcher.Columns.Add("rand", "Rand#"); Searcher.Columns["rand"].Width = 80;
            }
            else
            {
                if (method == 1 || method == 2 || method == 3 || method == 7)
                {
                    Searcher.Columns.Add("enctr", "Enctr?"); Searcher.Columns["enctr"].Width = 50;
                    Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                    Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                }
                else if (method == 4)
                {
                    Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                    Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                    Searcher.Columns.Add("ha", "HA"); Searcher.Columns["ha"].Width = 30;
                }
                else if (method == 5 || method == 8)
                {
                    Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                    Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                }
                else if (method == 6)
                {
                    if (xyRadio.Checked)
                    {
                        if (ratio.Value == 0)
                        {
                            Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                            Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                        }
                        else
                        {
                            Searcher.Columns.Add("shiny", "Shiny"); Searcher.Columns["shiny"].Width = 50;
                        }
                        Searcher.Columns.Add("music", "Music"); Searcher.Columns["music"].Width = 50;
                    }
                    else
                    {
                        Searcher.Columns.Add("x", "Right"); Searcher.Columns["x"].Width = 40;
                        Searcher.Columns.Add("y", "Up"); Searcher.Columns["y"].Width = 40;
                        //Searcher.Columns.Add("rate", "Rate"); view.Columns["rate"].Width = 50;
                        Searcher.Columns.Add("success", "Success"); Searcher.Columns["success"].Width = 55;
                        Searcher.Columns.Add("type", "Type"); Searcher.Columns["type"].Width = 60;
                        Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                        Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                        Searcher.Columns.Add("shiny", "Shiny"); Searcher.Columns["shiny"].Width = 50;
                        Searcher.Columns.Add("lvlBoost", "Level"); Searcher.Columns["lvlBoost"].Width = 45;
                        Searcher.Columns.Add("ha", "HA"); Searcher.Columns["ha"].Width = 40;
                        Searcher.Columns.Add("eggmove", "Egg Move"); Searcher.Columns["eggmove"].Width = 85;
                        Searcher.Columns.Add("potential", "Potential"); Searcher.Columns["potential"].Width = 60;
                    }
                }
                Searcher.Columns.Add("flute", "Flute"); Searcher.Columns["flute"].Width = 70;
                if (xyRadio.Checked)
                    Searcher.Columns["flute"].Visible = false;

                if (method != 6 || (method == 6 && !orasRadio.Checked))
                    Searcher.Columns.Add("item", "Item");
                if (method != 4)
                {
                    if (method != 6 || (method == 6 && !orasRadio.Checked))
                        Searcher.Columns["item"].Width = 50;
                    Searcher.Columns["flute"].Width = 50;
                }
                else
                {
                    Searcher.Columns["flute"].Width = 70;
                    Searcher.Columns["item"].Width = 150;
                }

                if (method == 6 && xyRadio.Checked && ratio.Value > 0)
                    Searcher.Columns["item"].Visible = false;

                Searcher.Columns.Add("rand", "Rand (100)"); Searcher.Columns["rand"].Width = 90;
            }
        }

        private void CellFormatting(ref DataGridView view, int row, int column, byte num)
        {
            try
            {
                if (MethodUsed == "Normal Wild" || MethodUsed == "Fishing" || MethodUsed == "Friend Safari")
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (Convert.ToInt32(view.Rows[row].Cells[num].Value) < ratio.Value)
                            view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (MethodUsed == "Rock Smash")
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (Convert.ToInt32(view.Rows[row].Cells[num].Value) == 0)
                            view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (MethodUsed == "Radar1")
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (view.Rows[row].Cells[num].Value.ToString() == "True")
                            view.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                }
                else if (MethodUsed == "DexNav")
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (view.Rows[row].Cells[num + 2].Value.ToString() == "True")
                        {
                            if (view.Rows[row].Cells[num + 6].Value.ToString() == "True")
                                view.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                            else
                                view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                }
            }
            catch
            {

            }
        }

        private void Searcher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(ref Searcher, e.RowIndex, e.ColumnIndex, 6);
        }

        private void Generator_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(ref Generator, e.RowIndex, e.ColumnIndex, 1);
        }
        #endregion
    }
}