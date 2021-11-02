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
        List<Location> Locations;
        byte[] fluteArray = { 0, 0, 0, 0, 0 };
        Calculate calc = new Calculate();
        TinyMT tiny = new TinyMT();
        Data data = new Data();
        NTRHelper ntrhelper;
        Calibrator calibrator;
        Manager manager;
        uint seconds, initial = 0;
        byte count, searchMonth, SlotLimit;
        bool Calibrated = false, DateSearcher, HasHordes;
        byte MethodUsed;

        struct PatchSpot
        {
            public uint index;
            public string[] spots;
        }
        PatchSpot element = new PatchSpot();

        List<PatchSpot> GPatchSpots = new List<PatchSpot>();
        List<PatchSpot> SPatchSpots = new List<PatchSpot>();

        private string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');
        private bool isRadar1() => XY_Button.Checked && Methods.SelectedIndex == 6 && ratio.Value > 0;

        public Form1()
        {
            InitializeComponent();
            Generator.Visible = false;
            XY_Button.Checked = true;
            year.Value = DateTime.Now.Year; Months.SelectedIndex = DateTime.Now.Month - 1;
            Date_Label.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            DefaultPositions();
            ManageControls(0);
        }

        #region GUI Events
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
            ManageControls((byte)Methods.SelectedIndex);
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            Date_Label.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            Calibrated = false; 
            button1.Text = "Calibrate and Search";
        }

        private void ratio_ValueChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 6 && XY_Button.Checked)
            {
                SyncBox.Enabled = slots.Enabled = Slots_Label.Enabled = ratio.Value == 0;
                BoostBox.Enabled = BagBox.Enabled = isRadar1();
            }
        }

        private void Horde_Turn_CheckedChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 1 || Methods.SelectedIndex == 4)
            {
                CaveBox.Checked = false;
                CaveBox.Enabled = !(Horde_Turn.Checked && ORAS_Button.Checked);
                Rate_Label.Visible = ratio.Visible = Horde_Turn.Checked;
                Party_Label.Visible = party.Visible = !Horde_Turn.Checked;
                Location_Label.Visible = locations.Visible = Horde_Turn.Checked;
                Location_Label.Enabled = locations.Enabled = !CaveBox.Checked;
                ManageLocations();
                ManageRatio();
                if (ORAS_Button.Checked)
                {
                    LongGrassBox.Visible = LongGrassBox.Checked = Horde_Turn.Checked;
                    LongGrassBox.Enabled = false;
                    ratio.Value = 13;
                }
            }
        }

        private void CaveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 1 && locations.Items.Count != 0)
                LongGrassBox.Enabled = !CaveBox.Checked && Locations[(byte)locations.SelectedIndex].Has_Hordes
                        && !(locations.SelectedIndex > 5 && locations.SelectedIndex < 9);

            if (Location_Label.Visible)
            {
                Location_Label.Enabled = locations.Enabled = !CaveBox.Checked;
                ManageRatio();
            }
        }

        private void SurfBox_CheckedChanged(object sender, EventArgs e)
        {
            Location_Label.Visible = locations.Visible = Methods.SelectedIndex == 5 && SurfBox.Checked && ORAS_Button.Checked;
            Location_Label.Enabled = locations.Enabled = Location_Label.Visible && !CaveBox.Checked;
            ManageLocations();
            ManageSlots((byte)Methods.SelectedIndex);
        }

        private void ExclusiveBox_CheckedChanged(object sender, EventArgs e)
        {
            NavType.Enabled = ExclusiveBox.Checked;
            if (!ExclusiveBox.Checked)
                NavType.SelectedIndex = 0;
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 1)
            {
                LongGrassBox.Enabled = LongGrassBox.Checked = false;
                if (ORAS_Button.Checked && Locations[(byte)locations.SelectedIndex].Has_Hordes)
                {
                    LongGrassBox.Enabled = true;
                    if (locations.SelectedIndex == 6 || locations.SelectedIndex == 7 || locations.SelectedIndex == 9)
                    {
                        LongGrassBox.Enabled = false;
                        LongGrassBox.Checked = true;
                    }
                }
                ManageRatio();
            }
        }

        private void NavType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSlots(6);
        }

        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
            {
                Date_Label.Location = new Point(1, 71);
                Date_Label.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
                button1.Text = Calibrated ? "Search" : "Calibrate and Search";
                FindNum_Label.Enabled = Atleast.Enabled = Month_Label.Visible = Months.Visible = true;
                Year_Label.Visible = year.Visible = true;
                Step_Label.Visible = Chain_Label.Visible = false;
                ΙgnoreFilters.Checked = ΙgnoreFilters.Enabled = false;
                Generator.Visible = ntr.Enabled = updateBTN.Visible = false;
                Searcher.Visible = true;
                min.Value = min.Minimum = XY_Button.Checked ? 35 :
                                          (ORAS_Button.Checked && Methods.SelectedIndex == 0) ? 11 :
                                          (ORAS_Button.Checked && Methods.SelectedIndex != 0) ? 20 : 0;
                max.Value = (XY_Button.Checked && Methods.SelectedIndex == 6) ? 800 : 150;

            }
            else
            {
                Date_Label.Location = new Point(98, 71);
                Date_Label.Text = "Current State";
                button1.Text = "Generate";
                FindNum_Label.Enabled = Atleast.Enabled = Month_Label.Visible = Months.Visible = false;
                ntr.Enabled = updateBTN.Visible = true;
                ΙgnoreFilters.Enabled = true;
                Searcher.Visible = year.Visible = Year_Label.Visible = false;
                Generator.Visible = true;
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }
        }

        private void TinyChanged()
        {
            if (SearchGen.SelectedIndex == 0)
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
                if (XY_Button.Checked)
                {
                    try
                    {
                        Patches_Board.Text = string.Join("\n", GPatchSpots[getIndex(ref Generator, e.RowIndex)].spots);
                    }
                    catch
                    { }
                }
                /*else
                {
                    try
                    {
                        //To do
                        int one = Convert.ToInt32(Generator.Rows[e.RowIndex].Cells[1].Value.ToString());
                        int two = Convert.ToInt32(Generator.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    catch
                    { }
                }*/
            }
        }
        private void Searcher_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Searcher doesn't work with getIndex() because multiple indexes have the same number. Possibly use the Rand(100) as well
            //Currently doesn't work when sort the rows. To do
            try
            {
                Patches_Board.Text = string.Join("\n", SPatchSpots[e.RowIndex].spots);
            }
            catch
            { }
        }

        /*private void Generator_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To do
            if (e.Button == MouseButtons.Right)
            {
                t3.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [3]"].Value);
                t2.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [2]"].Value);
                t1.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [1]"].Value);
                t0.Value = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["Tiny [0]"].Value);
            }
        }*/

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                NTRHelper.ntrclient.ReadTiny("TTT");
                if (Methods.SelectedIndex == 6)
                {
                    if (ORAS_Button.Checked)
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
                    Step_Label.Visible = true;
                    Step_Label.ForeColor = steps[0] == 19 ? Color.Red : Color.Black;
                    Step_Label.Location = new Point(25, 100);
                    Step_Label.Text = "Step Counter   =   " + steps[0].ToString();
                    break;
                case "DexNavChain":
                    var chain = (uint[])state;
                    ratio.Value = chain[0];
                    Chain_Label.Visible = true;
                    Chain_Label.Location = new Point(25, 140);
                    Chain_Label.Text = "Chain Length   =   " + chain[0].ToString();
                    break;
                case "RadarChain":
                    var chainRadar = (uint[])state;
                    //ratio.Value = chainRadar[0];
                    Chain_Label.Visible = true;
                    Chain_Label.Location = new Point(25, 118);
                    Chain_Label.Text = "Chain Length   =   " + chainRadar[0].ToString();
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

        #region Manage Buttons and Slots
        private void ManageControls(byte Method)
        {
            Methods.SelectedIndex = Method;
            LongGrassBox.Checked = CaveBox.Checked = SurfBox.Checked = Horde_Turn.Checked = false;

            TID_Label.Visible = SID_Label.Visible = tid.Visible = sid.Visible = Method == 0;
            slots.Visible = Slots_Label.Visible = Method != 0;
            SyncBox.Visible = Method != 0 && !Equals(Methods.Text,"DexNav");
            Flute1_Label.Visible = Flute1.Visible = Method != 0 && ORAS_Button.Checked;
            HASlot.Visible = HA_Label.Visible = Horde_Turn.Visible = Method == 4;
            Flute2_Label.Visible = Flute2.Visible = Flute3_Label.Visible = Flute3.Visible = Flute4_Label.Visible =
                Flute4.Visible = Flute5_Label.Visible = Flute5.Visible = ORAS_Button.Checked && Method == 4;
            Rate_Label.Visible = ratio.Visible = Method == 1 || Method == 2 || Method == 6 || Method == 7;
            Location_Label.Visible = locations.Visible = Method == 1;

            BoostBox.Visible = Patches_Board.Visible = XY_Button.Checked && Method == 6;
            BagBox.Visible = Method == 6 && XY_Button.Checked;
            LongGrassBox.Visible = Method == 1 && ORAS_Button.Checked;
            CaveBox.Visible = Method == 1 || Method == 4 || Method == 5;
            SurfBox.Visible = Method == 5 || (Method == 6 && ORAS_Button.Checked);
            CharmBox.Visible = Method == 6 && ORAS_Button.Checked;
            ExclusiveBox.Visible = NavType_Label.Visible = NavType.Visible = NavFilters_Label.Visible =
                NavFilters.Visible = Potential_Label.Visible = Potential.Visible = ORAS_Button.Checked && Method == 6;

            Party_Label.Visible = party.Visible = Method > 3 && Method < 7;

            Step_Label.Visible = Chain_Label.Visible = false;

            CaveBox.Enabled = Method == 1 || Method == 4 || Method == 5;

            Flute1_Label.Text = Method == 4 ? "Flute 1" : "Flute";
            Rate_Label.Text = Method == 6 ? "Chain" : "Ratio";
            Party_Label.Text = (Method == 6 && ORAS_Button.Checked) ? "Search Level" : "Party";

            ratio.Minimum = 1; ratio.Maximum = 99;
            if (SearchGen.SelectedIndex == 0)
            {
                min.Value = min.Minimum = XY_Button.Checked ? 35 :
                                          (ORAS_Button.Checked && Methods.SelectedIndex == 0) ? 11 :
                                          (ORAS_Button.Checked && Methods.SelectedIndex != 0) ? 20 : 0;
                max.Value = (XY_Button.Checked && Methods.SelectedIndex == 6) ? 800 : 150;
            }
            else
            {
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }

            if (Method != 0)
            {
                ManageSlots((byte)Methods.SelectedIndex);
                Slots_Label.Location = new Point(13, 46);
                slots.Location = new Point(75, 42);
                Flute1_Label.Location = new Point(16, 98);
                Flute1.Location = new Point(75, 94);
                SyncBox.Location = new Point(53, 148);
                Party_Label.Location = new Point(230, 193);
                party.Maximum = 6;
                Slots_Label.Enabled = slots.Enabled = SyncBox.Enabled = SurfBox.Enabled = true;

                if (Method == 1)
                {
                    Location_Label.Enabled = locations.Enabled = true;
                    ManageLocations();
                    ManageRatio();
                }

                else if (Method == 2 || Method == 7)
                    ManageRatio();

                else if (Method == 4)
                {
                    Flute1_Label.Location = new Point(266, 55);
                    Flute1.Location = new Point(334, 52);
                    HASlot.SelectedIndex = 1;
                }

                else if (Method == 6)
                {
                    ratio.Minimum = 0;
                    if (XY_Button.Checked)
                    {
                        ratio.Value = 1;    //Chain
                        ratio.Maximum = 60;
                        SyncBox.Enabled = slots.Enabled = !isRadar1();
                    }
                    else
                    {
                        NavType.SelectedIndex = 0;
                        ratio.Value = 0;    //Chain
                        party.Maximum = 999;
                        party.Value = 999;
                        Party_Label.Location = new Point(185, 194);
                        Slots_Label.Location = new Point(9, 93);
                        slots.Location = new Point(71, 89);
                        Flute1_Label.Location = new Point(254, 140);
                        Flute1.Location = new Point(341, 137);
                    }
                }
            }
        }

        private void DefaultPositions()
        {
            BoostBox.Location = new Point(237, 80);
            BagBox.Location = new Point(237, 120);

            SurfBox.Location = new Point(237, 60);
            CharmBox.Location = new Point(237, 100);
            ExclusiveBox.Location = new Point(237, 140);

            TID_Label.Location = new Point(109, 79);
            tid.Location = new Point(139, 77);
            SID_Label.Location = new Point(109, 118);
            sid.Location = new Point(139, 116);

            HA_Label.Location = new Point(16, 98);
            HASlot.Location = new Point(75, 94);

            Patches_Board.Location = new Point(205, 26);
            Patches_Board.Text = "#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########";

            NavType_Label.Location = new Point(9, 45);
            NavType.Location = new Point(71, 41);
            NavFilters_Label.Location = new Point(9, 140);
            NavFilters.Location = new Point(71, 137);
            Potential_Label.Location = new Point(254, 93);
            Potential.Location = new Point(341, 89);
        }

        private void ManageSlots(byte method)
        {
            //Default values for most methods
            byte SlotsCount = 13;
            ushort ComboBoxHeight = 310;

            switch (method)
            {
                case 3:     //Rock Smash
                    SlotsCount = 6;
                    ComboBoxHeight = 140;
                    break;

                case 5:     //Honey Wild
                    SlotsCount = (byte)(SurfBox.Checked ? 6 : 13);
                    ComboBoxHeight = (ushort)(SurfBox.Checked ? 140 : 310);
                    break;

                case 6:     //DexNav
                    if (ORAS_Button.Checked)
                    {
                        if (NavType.SelectedIndex == 1)
                        {
                            SlotsCount = 4;
                            ComboBoxHeight = 90;
                        }
                        else
                        {
                            if (SurfBox.Checked)
                            {
                                SlotsCount = 6;
                                ComboBoxHeight = 140;
                            }
                        }
                    }
                    break;

                case 2:     //Fishing
                case 4:     //Horde
                case 7:     //Friend Safari
                    SlotsCount = 4;
                    ComboBoxHeight = 90;
                    break;
            }
            slots.Text = "";
            slots.Items.Clear();
            slots.DropDownHeight = ComboBoxHeight;
            for (byte add = 1; add < SlotsCount; add++)
                slots.Items.AddRange(new object[] { add });
        }

        private void ManageRatio()
        {
            if (Methods.SelectedIndex == 1 || (Methods.SelectedIndex == 4 && Horde_Turn.Checked))
            {
                if (CaveBox.Checked)
                    ratio.Value = 7;
                else
                {
                    ratio.Value = Locations[(byte)locations.SelectedIndex].ratio;
                }
            }
            else if (Methods.SelectedIndex == 2)
                ratio.Value = 49;
            else if (Methods.SelectedIndex == 7)
                ratio.Value = 13;
        }

        private void ManageLocations()
        {
            if (Location_Label.Visible)
            {
                Locations = data.SetLocations((byte)Methods.SelectedIndex, ORAS_Button.Checked);
                locations.Items.Clear();
                for (byte i = 0; i < Locations.Count; i++)
                    locations.Items.Add(Locations[i].Name);
                locations.SelectedIndex = 0;
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
                    table.Columns.Add("Ratio", typeof(byte));
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                }
                else if (method == 4)
                {
                    table.Columns.Add("Ratio", typeof(byte));
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                    table.Columns.Add("HA", typeof(byte));
                    if (ORAS_Button.Checked)
                        table.Columns.Add("Flute", typeof(string));
                }
                else if (method == 5 || method == 8)
                {
                    table.Columns.Add("Sync", typeof(string));
                    table.Columns.Add("Slot", typeof(byte));
                }
                else if (method == 6)
                {
                    if (XY_Button.Checked)
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
                    if (ORAS_Button.Checked)
                        table.Columns.Add("Flute", typeof(byte));

                if (method != 6 || (method == 6 && !ORAS_Button.Checked))
                    table.Columns.Add("Item", typeof(string));

                if (method == 6 && XY_Button.Checked && ratio.Value > 0)
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
                Generator.Columns["Ratio"].Width = Generator.Columns["Sync"].Width = 
                    Generator.Columns["Slot"].Width = Generator.Columns["Item"].Width = 50;
                if (ORAS_Button.Checked)
                    Generator.Columns["Flute"].Width = 50;
            }
            else if (Equals(method, "Horde")) 
            {
                Generator.Columns["Ratio"].Width = Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["HA"].Width = 50;
                Generator.Columns["Item"].Width = 150;
                if (ORAS_Button.Checked)
                    Generator.Columns["Flute"].Width = 75;
            }
            else if (Equals(method, "Honey"))
            {
                Generator.Columns["Sync"].Width = Generator.Columns["Slot"].Width = Generator.Columns["Item"].Width = 50;
                if (ORAS_Button.Checked)
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
                    Searcher.Columns.Add("ratio", "Ratio"); Searcher.Columns["ratio"].Width = 50;
                    Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                    Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                }
                else if (method == 4)
                {
                    Searcher.Columns.Add("ratio", "Ratio"); Searcher.Columns["ratio"].Width = 50;
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
                    if (XY_Button.Checked)
                    {
                        if (ratio.Value == 0)
                        {
                            Searcher.Columns.Add("sync", "Sync"); Searcher.Columns["sync"].Width = 50;
                            Searcher.Columns.Add("slot", "Slot"); Searcher.Columns["slot"].Width = 50;
                        }
                        else
                        {
                            Searcher.Columns.Add("Shiny", "Shiny"); Searcher.Columns["Shiny"].Width = 50;
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
                        Searcher.Columns.Add("Shiny", "Shiny"); Searcher.Columns["Shiny"].Width = 50;
                        Searcher.Columns.Add("lvlBoost", "Level"); Searcher.Columns["lvlBoost"].Width = 45;
                        Searcher.Columns.Add("ha", "HA"); Searcher.Columns["ha"].Width = 40;
                        Searcher.Columns.Add("eggmove", "Egg Move"); Searcher.Columns["eggmove"].Width = 85;
                        Searcher.Columns.Add("potential", "Potential"); Searcher.Columns["potential"].Width = 60;
                    }
                }
                Searcher.Columns.Add("flute", "Flute"); Searcher.Columns["flute"].Width = 70;
                if (XY_Button.Checked)
                    Searcher.Columns["flute"].Visible = false;

                if (method != 6 || (method == 6 && !ORAS_Button.Checked))
                    Searcher.Columns.Add("item", "Item");
                if (method != 4)
                {
                    if (method != 6 || (method == 6 && !ORAS_Button.Checked))
                        Searcher.Columns["item"].Width = 50;
                    Searcher.Columns["flute"].Width = 50;
                }
                else
                {
                    Searcher.Columns["flute"].Width = 70;
                    Searcher.Columns["item"].Width = 150;
                }

                if (method == 6 && XY_Button.Checked && ratio.Value > 0)
                    Searcher.Columns["item"].Visible = false;

                Searcher.Columns.Add("Rand(100)", "Rand(100)"); Searcher.Columns["Rand(100)"].Width = 90;
            }
        }

        private void CellFormatting(ref DataGridView view, int row, int column, byte num)
        {
            try
            {
                if (MethodUsed == 1 || MethodUsed == 2 || MethodUsed == 7)
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (Convert.ToInt32(view.Rows[row].Cells[num].Value) < ratio.Value && 
                            (!HasHordes || (HasHordes && Convert.ToByte(view.Rows[row].Cells["Rand(100)"].Value) > 4)))
                            view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (MethodUsed == 3)
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (Convert.ToInt32(view.Rows[row].Cells[num].Value) == 0)
                            view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (MethodUsed == 4)
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (Convert.ToInt32(view.Rows[row].Cells[num].Value) < ratio.Value 
                            && Convert.ToInt32(view.Rows[row].Cells["Rand(100)"].Value) < 5 
                            && Horde_Turn.Checked)
                            view.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (isRadar1())
                {
                    if (view.Rows[row].Cells[column].Value != null)
                        if (view.Rows[row].Cells["Shiny"].Value.ToString() == "True")
                            view.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                }
                else if (MethodUsed == 6)
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