using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using TinyFinder.Subforms.MT;
using TinyFinder.Main;
using System.Linq;

namespace TinyFinder
{
    public partial class Form1 : Form
    {
        private string DexToName(int dex) => Species.SpeciesList.ElementAt(dex).Name;
        private string SelectedSpecies => SpeciesCombo.SelectedItem.ToString();
        byte SelectedLocation => (byte)locationsComboBox.SelectedIndex;
        Location CurrentLocation => listOfLocations.ElementAt(SelectedLocation);
        private ushort[] GetWildTable => CurrentLocation.GrassTable;
        private ushort[] GetCaveTable => CurrentLocation.CaveTable;
        private ushort[] GetLongTable => CurrentLocation.LongTable;
        private ushort[] GetRedTable => CurrentLocation.RedTable;
        private ushort[] GetYellowTable => CurrentLocation.YellowTable;
        private ushort[] GetPurpleTable => CurrentLocation.PurpleTable;
        private ushort[] GetSwampTable => CurrentLocation.SwampTable;
        private ushort[] GetHordeTable => CurrentLocation.HordeTable;
        private ushort[] GetSurfTable => CurrentLocation.SurfTable;
        private ushort[] GetOldTable => CurrentLocation.OldTable;
        private ushort[] GetGoodTable => CurrentLocation.GoodTable;
        private ushort[] GetSuperTable => CurrentLocation.SuperTable;
        private ushort[] GetSmashTable => CurrentLocation.SmashTable;
        private ushort[] GetNavTable => CurrentLocation.DexNavTable;
        private ushort[] GetSwoopingTable => CurrentLocation.SwoopingTable;
        private List<ushort> GetFSList => Species.getFSList();

        bool MovingHordeOption => Method == 4 && EncounterType.SelectedIndex == 1;      // User selected moving horde method
        private bool HasExclusives => GetNavTable != null;
        bool ORAS => GameVersion.SelectedIndex > 1;
        bool IsDexNav => Method == 6 && ORAS;
        

        private bool isRadar1 => Method == 6 && !ORAS && ratio.Value > 0;

        bool Surfing => EncounterType.SelectedIndex != -1 && EncounterType.SelectedItem.ToString().Equals("Water");
        bool LongGrass => EncounterType.SelectedIndex != -1 && EncounterType.SelectedItem.ToString().Equals("Long Grass");
        bool Swampy => EncounterType.SelectedIndex != -1 && EncounterType.SelectedItem.ToString().Equals("Swamp");
        byte Method => (byte)Methods.SelectedIndex;


        Data data = new Data();
        NTRHelper ntrhelper;
        MTForm mersenne;
        Calculate calc = new Calculate();

        bool[] SelectedSlots;
        bool AllowCellFormatting, ascending;
        uint[] GeneratorState = new uint[4];

        List<Location> listOfLocations;

        public Form1()
        {
            InitializeComponent();
        }

        #region GUI Events
        private void Form1_Load(object sender, EventArgs e)
        {
            t3.Text = t2.Text = t1.Text = t0.Text = "";     // Faster copy paste for Citra
            Generator.Size = new Size(1170, 315);           // Size breaks for some reason

            GameVersion.SelectedIndex = 0;
            year.Value = DateTime.Now.Year; Months.SelectedIndex = DateTime.Now.Month - 1;
            //Date_Label.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";

            ThreadCount.Value = Properties.Settings.Default.CPUs == 0 ? Environment.ProcessorCount : Properties.Settings.Default.CPUs;
            ThreadCount.Maximum = Environment.ProcessorCount;

            DefaultChanges();
            Methods.SelectedIndex = 0;
            SearchGen.SelectedIndex = 1;
        }

        // Main Event (Search Button)
        private void MainButton_Click(object sender, EventArgs e)
        {
            AllowCellFormatting = ascending = false;
            MainButton.Enabled = IgnoreFiltersButton.Enabled = SearchGen.SelectedIndex == 1;
            NoFilters = sender == IgnoreFiltersButton;
            Prepare();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            Finished();
        }
        private void Finished()
        {
            if (DateSearcher)
                for (uint i = 0; i < ThreadsUsed; i++)
                    jobs[i].Abort();

            StopButton.Enabled = Working = false;
            MainButton.Enabled = IgnoreFiltersButton.Enabled = true;
            MainButton.Text = SearchGen.SelectedIndex == 0 ? (Calibrated ? "Search" : "Calibrate and Search") : "Generate";
        }
        private void ThreadCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CPUs = (int)ThreadCount.Value;
            Properties.Settings.Default.Save();
        }

        private void GameVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameVersion.SelectedIndex <= 1)
            {
                Methods.Items[6] = "Radar";
                if (Methods.Items.Count != 9)
                {
                    Methods.Items.Add("Friend Safari");
                    Methods.Items.Add("Swooping");
                }
            }
            else
            {
                Methods.Items[6] = "DexNav";
                Methods.Items.Remove("Friend Safari");
                Methods.Items.Remove("Swooping");
            }

            Methods.SelectedIndex = 0;
            ManageControls();
            if (mersenne != null)
                mersenne.SetGame(!ORAS);
        }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool DateSearcher = SearchGen.SelectedIndex == 0;
            Year_Label.Visible = year.Visible = Month_Label.Visible = Months.Visible =
                Threads_Label.Enabled = ThreadCount.Enabled = DateRNGSeed.Visible = DateSearcher;
            ntr.Enabled = updateBTN.Visible = IgnoreFiltersButton.Visible = SetAsCurrent.Visible = !DateSearcher;
            Date_Label.Location = DateSearcher ? new Point(1, 71) : new Point(98, 71);
            Date_Label.Text = DateSearcher ? "Set the Citra RTC to " + year.Value + "-01-01 13:00:00" : "Current State";

            if (!Working)
                MainButton.Text = DateSearcher ? (Calibrated ? "Search" : "Calibrate and Search") : "Generate";

            if (DateSearcher)
            {
                Step_Label.Visible = Chain_Label.Visible = false;
                min.Value = min.Minimum = !ORAS ? 35 :
                                          (ORAS && Method == 0) ? 11 :
                                          (ORAS && Method != 0) ? 20 : 0;
                max.Value = (!ORAS && Method == 6) ? 800 : 150;

            }
            else
            {
                min.Minimum = 0; min.Value = 0;     //Careful for exception here
                if (Method != 0)
                    SetMin();
                max.Value = 50000;
            }
        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageControls();
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
                Date_Label.Text = "Set the Citra RTC to " + year.Value + "-01-01 13:00:00";
            TinyChanged();
        }

        private void ratio_ValueChanged(object sender, EventArgs e)
        {
            Species_Label.Enabled = SpeciesCombo.Enabled = SyncBox.Enabled = SlotsComboBox.Enabled = Slots_Label.Enabled = !isRadar1;
            BonusMusicBox.Enabled = isRadar1;
        }

        private void EncounterChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSpecies();
            ManageRatio();

            if (Method == 4)
            {
                Rate_Label.Visible = ratio.Visible = MovingHordeOption;
                Party_Label.Visible = party.Visible = !MovingHordeOption;
            }
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            EncounterType.Items.Clear();
            if (Method == 1)
            {
                if (GetWildTable != null)
                    EncounterType.Items.Add("Grass");
                if (GetCaveTable != null)
                    EncounterType.Items.Add("Cave");
                if (GetLongTable != null)
                    EncounterType.Items.Add("Long Grass");
                if (GetRedTable != null)
                    EncounterType.Items.Add("Red Flowers");
                if (GetYellowTable != null)
                    EncounterType.Items.Add("Yellow Flowers");
                if (GetPurpleTable != null)
                    EncounterType.Items.Add("Purple Flowers");
                if (GetSwampTable != null)
                    EncounterType.Items.Add("Swamp");
                if (CurrentLocation.RideTable != null)
                    EncounterType.Items.Add("Riding");
                if (GetSurfTable != null)
                    EncounterType.Items.Add("Water");
            }
            else if (Method == 2)
            {
                EncounterType.Items.Add("Old Rod");
                EncounterType.Items.Add("Good Rod");
                EncounterType.Items.Add("Super Rod");
            }
            else if (Method == 4)
            {
                EncounterType.Items.Add("Honey");
                if (!ORAS || (GetLongTable != null))
                    EncounterType.Items.Add("Moving");
            }
            else if (Method == 5)
            {
                if (GetHordeTable == null)
                {
                    if (GetWildTable != null)
                        EncounterType.Items.Add("Grass");
                    if (GetRedTable != null)
                        EncounterType.Items.Add("Red Flowers");
                    if (GetYellowTable != null)
                        EncounterType.Items.Add("Yellow Flowers");
                    if (GetPurpleTable != null)
                        EncounterType.Items.Add("Purple Flowers");
                    if (GetLongTable != null)
                        EncounterType.Items.Add("Long Grass");
                    if (GetCaveTable != null)
                        EncounterType.Items.Add("Cave");
                }
                if (GetSwampTable != null)
                    EncounterType.Items.Add("Swamp");
                if (GetSurfTable != null)
                    EncounterType.Items.Add("Water");
            }
            else if (Method == 6)
            {
                if (GetWildTable != null)
                    EncounterType.Items.Add("Grass");
                if (IsDexNav)
                {
                    if (GetCaveTable != null)
                        EncounterType.Items.Add("Cave");
                    if (GetLongTable != null)
                        EncounterType.Items.Add("Long Grass");
                    if (GetSurfTable != null)
                        EncounterType.Items.Add("Water");
                }
                else
                {
                    if (GetLongTable != null)
                        EncounterType.Items.Add("Long Grass");
                    if (GetRedTable != null)
                        EncounterType.Items.Add("Red Flowers");
                    if (GetYellowTable != null)
                        EncounterType.Items.Add("Yellow Flowers");
                    if (GetPurpleTable != null)
                        EncounterType.Items.Add("Purple Flowers");
                }
            }
            else if (Method == 7)
            {
                EncounterType.Items.Add("2 Slots");
                EncounterType.Items.Add("3 Slots");
            }

            if (EncounterType.Items.Count != 0)
            {
                if (Method == 2)
                    EncounterType.SelectedIndex = 2;    // For fishing, Super rod is the default choice
                else if (Method == 7)
                    EncounterType.SelectedIndex = 1;    // For FS, 3 slots is the default choice
                else
                    EncounterType.SelectedIndex = 0;
            } 
            else
                ManageSpecies();

            SetMin();
        }

        private void ManageRatio()
        {
            if (Method == 1 || MovingHordeOption)
            {
                if (Surfing)
                    ratio.Value = 7;
                else
                {
                    if (CurrentLocation.Enc_Ratio != 0)
                        ratio.Value = CurrentLocation.Enc_Ratio;
                    else
                        ratio.Value = 13;
                }
            }
            else if (Method == 2)
                ratio.Value = 49;
            else if (Method == 7)
                ratio.Value = 13;
        }

        private void SetMin()
        {
            if (SearchGen.SelectedIndex == 1)
            {
                if (Method == 7)
                    min.Value = 27;
                else if (Method == 1 || MovingHordeOption || (Method >= 6 && !isRadar1))
                    min.Value = CurrentLocation.Bag_Advances;
            }
        }

        private void ManageSpecies()
        {
            SpeciesCombo.Items.Clear();

            if (Method == 7)
            {
                foreach (int num in GetFSList)
                    SpeciesCombo.Items.Add(DexToName(num));
                SpeciesCombo.SelectedIndex = 0;
                return;
            }

            SpeciesCombo.Items.Add("Any");
            HashSet<ushort> SlotSpecies = new HashSet<ushort>(SlotTable());

            if (IsDexNav && GetNavTable != null)
            {
                HashSet<ushort> navSpecies = new HashSet<ushort>(GetNavTable);
                // Merge DexNav slots with water slots ONLY if every other table doesn't exit for a given location
                if (!Surfing || (GetWildTable == null && GetCaveTable == null && GetLongTable == null))
                {
                    SlotSpecies.UnionWith(navSpecies);
                }
            }

            foreach (int s in SlotSpecies)
                SpeciesCombo.Items.Add(DexToName(s));

            SpeciesCombo.SelectedIndex = 0;

        }


        private void Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSlots();
            if (Method != 7)
            {
                ushort[] tempTable;
                if (IsDexNav && checkExclusives())
                    tempTable = GetNavTable;
                else
                    tempTable = SlotTable();
                for (int i = 1; i < SlotsComboBox.Items.Count; i++)
                    SlotsComboBox.CheckBoxItems[i].Checked = DexToName(tempTable[i - 1]).Equals(SelectedSpecies);
            }
        }

        private void ExclusivesBox_CheckedChanged(object sender, EventArgs e)
        {
            ManageSlots();
            for (int i = 1; i < SlotsComboBox.Items.Count; i++)
                SlotsComboBox.CheckBoxItems[i].Checked = DexToName(GetNavTable[i - 1]).Equals(SelectedSpecies);
        }

        private bool checkExclusives()
        {
            if (GetNavTable != null)
                for (int i = 0; i < 3; i++)
                    if (DexToName(GetNavTable[i]).Equals(SelectedSpecies))
                        return true;
            return false;
        }

        private ushort[] SlotTable()
        {
            if (Method == 3)
                return GetSmashTable;
            if (Method == 7)
                return null;
            if (Method == 8)
                return GetSwoopingTable;

            switch (EncounterType.SelectedItem.ToString())
            {
                case "Grass":
                    return GetWildTable;
                case "Cave":
                    return GetCaveTable;
                case "Red Flowers":
                    return GetRedTable;
                case "Yellow Flowers":
                    return GetYellowTable;
                case "Purple Flowers":
                    return GetPurpleTable;

                case "Water":
                    return GetSurfTable;
                case "Swamp":
                    return GetSwampTable;
                case "Riding":
                    return CurrentLocation.RideTable;
                case "Long Grass":
                    return GetLongTable;

                case "Old Rod":
                    return GetOldTable;
                case "Good Rod":
                    return GetGoodTable;
                case "Super Rod":
                    return GetSuperTable;
                case "Honey":
                case "Moving":
                    return GetHordeTable;
                default:
                    MessageBox.Show("Faulty Slot. Please Report this.");
                    break;
            }
            
            return null;
        }

        private int[] LevelTable()
        {
            if (Method == 3)
                return CurrentLocation.SmashLevel;
            else if (Method == 8)
                return CurrentLocation.SwoopingLevel;
            else if (Method == 7)
                return null;

            switch (EncounterType.SelectedItem.ToString())
            {
                case "Grass":
                case "Cave":
                case "Long Grass":
                case "Riding":
                    return CurrentLocation.WildLevel;
                case "Red Flowers":
                    return CurrentLocation.RedLevel;
                case "Yellow Flowers":
                    return CurrentLocation.YellowLevel;
                case "Purple Flowers":
                    return CurrentLocation.PurpleLevel;
                case "Water":
                    return CurrentLocation.SurfLevel;
                case "Swamp":
                    return CurrentLocation.SwampLevel;
                case "Old Rod":
                    return CurrentLocation.OldLevel;
                case "Good Rod":
                    return CurrentLocation.GoodLevel;
                case "Super Rod":
                    return CurrentLocation.SuperLevel;
                case "Honey":
                case "Moving":
                    return CurrentLocation.HordeLevel;
                default:
                    MessageBox.Show("Faulty Level. Please Report this.");
                    return null;
            }
        }

        private void ManageLocations()
        {
            switch (GameVersion.SelectedIndex)
            {
                case 0:
                    listOfLocations = SpeciesX.WildLocationsX();
                    break;
                case 1:
                    listOfLocations = SpeciesY.WildLocationsY();
                    break;
                case 2:
                    listOfLocations = SpeciesOR.WildLocationsOR();
                    break;
                case 3:
                    listOfLocations = SpeciesAS.WildLocationsAS();
                    break;
            }

            locationsComboBox.Items.Clear();
            foreach (Location temp in listOfLocations.ToList())
            {
                if (
                (Method == 1                && !temp.HasNormalWild()) ||

              //(Method == 2                && !temp.HasFishing()) ||
                (Method == 2                && temp.ConsoleDelayRand == 0) ||   // <- Better

                (Method == 3                && temp.SmashTable == null) ||

                (Method == 4                && temp.HordeTable == null) ||

                (Method == 5                && !temp.HasHoneyWild()) ||

                (CheckMethod("Radar")       && !temp.HasRadar()) ||

                (CheckMethod("DexNav")      && !temp.HasDexNav()) ||

                (Method == 8                && temp.SwoopingTable == null))
                {
                    listOfLocations.Remove(temp);
                    continue;
                }
                locationsComboBox.Items.Add(temp.Name);
            }
            locationsComboBox.SelectedIndex = 0;
        }

        private void ManageSlots()
        {
            //Default values for most methods
            byte SlotsCount = 12;
            ushort ComboBoxHeight = 310;
            //

            switch (Method)
            {
                case 3:     // Rock Smash
                    SlotsCount = 5;
                    ComboBoxHeight = 140;
                    break;

                case 1:     // Normal Wild
                case 5:     // Honey Wild
                //case 6:     // Radar / DexNav
                    SlotsCount = (byte)(Surfing ? 5 : 12);
                    ComboBoxHeight = (ushort)(Surfing ? 140 : 310);
                    break;

                case 6:     // DexNav

                    if (IsDexNav && checkExclusives())
                    {
                        SlotsCount = 3;
                        ComboBoxHeight = 90;
                    }
                    else
                    {
                        SlotsCount = (byte)(Surfing ? 5 : 12);
                        ComboBoxHeight = (ushort)(Surfing ? 140 : 310);
                    }
                    break;
                case 7:     // Friend Safari
                    SlotsCount = (byte)(EncounterType.SelectedIndex + 2);
                    ComboBoxHeight = (ushort)(SlotsCount == 2 ? 65 : 90);
                    break;

                case 2:     // Fishing
                case 4:     // Horde
                    SlotsCount = 3;
                    ComboBoxHeight = 90;
                    break;
            }
            // All slots need to be unchecked before being removed to clear the slot text in combobox
            for (int i = 0; i < SlotsComboBox.Items.Count; i++)
                SlotsComboBox.CheckBoxItems[i].Checked = false;
            SlotsComboBox.Items.Clear();
            SlotsComboBox.DropDownHeight = ComboBoxHeight;
            for (byte add = 1; add < SlotsCount + 1; add++)
                SlotsComboBox.Items.AddRange(new object[] { add });
        }

        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void TinyChanged()
        {
            if (SearchGen.SelectedIndex == 0)
            {
                Calibrated = false;
                if (!Working)
                    MainButton.Text = "Calibrate and Search";
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

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                NTRHelper.ntrclient.ReadTiny("TTT");
                if (Method == 6)
                {
                    if (ORAS)
                    {
                        NTRHelper.ntrclient.ReadTiny("Step");
                        NTRHelper.ntrclient.ReadTiny("DexNavChain");
                    }
                    else
                    {
                        NTRHelper.ntrclient.ReadTiny("RadarChain");
                    }
                }
                MainButton.PerformClick();
            }
            catch   //If the user clicks Update before the console is connected again
            {
                ntrhelper.HandleException();
                updateBTN.PerformClick();
            }
        }

        public void OnConnected_Changed(bool IsConnected)
        {
            updateBTN.Enabled = IsConnected;
        }

        public void parseNTRInfo(string name, object info)
        {
            switch (name)
            {
                case "TTT":
                    var tiny = (uint[])info;
                    t3.Value = tiny[3];
                    t2.Value = tiny[2];
                    t1.Value = tiny[1];
                    t0.Value = tiny[0];
                    return;
                case "Step":
                    var steps = (uint[])info;
                    Step_Label.Visible = true;
                    Step_Label.ForeColor = steps[0] == 19 ? Color.Red : Color.Black;
                    Step_Label.Text = "Step Counter   =   " + steps[0].ToString();
                    break;
                case "DexNavChain":
                    var chain = (uint[])info;
                    ratio.Value = chain[0];
                    Chain_Label.Visible = true;
                    Chain_Label.Text = "Chain Length   =   " + chain[0].ToString();
                    break;
                case "RadarChain":
                    var chainRadar = (uint[])info;
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

        private void MTrng_Click(object sender, EventArgs e)
        {
            OpenMTForm();
        }
        private void OpenMTForm()
        {
            if (mersenne == null)
                mersenne = new MTForm();
            mersenne.Show();
            mersenne.Focus();
            mersenne.SetGame(!ORAS);
        }

        private void TIDBOX_CheckedChanged_1(object sender, EventArgs e)
        {
            tid.Enabled = TIDBOX.Checked;
        }
        private void SIDBOX_CheckedChanged(object sender, EventArgs e)
        {
            sid.Enabled = SIDBOX.Checked;
        }

        private void MTSeedGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void TIDSIDGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void NormalGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void HordeGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void DexNavGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }

        #endregion

        #region Manage Buttons and Slots
        private void ManageControls()
        {
            TIDBOX.Visible = SIDBOX.Visible = tid.Visible = sid.Visible = Method == 0;
            SlotsComboBox.Visible = Slots_Label.Visible = Method != 0;
            SyncBox.Visible = Method != 0 && !IsDexNav;
            FluteOptionLabel.Visible = FluteOption.Visible = Flute1_Label.Visible = Flute1.Visible = Method != 0 && ORAS;
            HASlot.Visible = HA_Label.Visible = Method == 4;
            Flute2_Label.Visible = Flute2.Visible = Flute3_Label.Visible = Flute3.Visible = Flute4_Label.Visible =
                Flute4.Visible = Flute5_Label.Visible = Flute5.Visible = ORAS && Method == 4;
            Rate_Label.Visible = ratio.Visible = Method == 1 || Method == 2 || Method == 6 || Method == 7;

            Location_Label.Visible = locationsComboBox.Visible = Method != 0 && Method != 7;
            EncounterType.Visible = Method != 0 && Method != 3 && Method != 8;

            BonusMusicBox.Visible = Patches_Board.Visible = !ORAS && Method == 6;
            BagBox.Visible = BagBox.Checked = (Method == 6 && !ORAS) || Method == 2;

            CitraBox.Visible = FinalFR_Label.Visible = FishingFrame.Visible = Method == 2;
            CharmBox.Visible = Method == 6 && ORAS;
            Noise_Label.Visible = noise.Visible = NavFilters_Label.Visible = 
                NavFilters.Visible = Potential_Label.Visible = Potential.Visible = ORAS && Method == 6;

            Species_Label.Visible = SpeciesCombo.Visible = Method != 0;

            Party_Label.Visible = party.Visible = (Method > 3 && Method < 8 && Method != 7) || Method == 2 ;

            Step_Label.Visible = Chain_Label.Visible = false;

            Flute1_Label.Text = Method == 4 ? "Flute 1" : "Flute";
            Rate_Label.Text = Method == 6 ? "Chain" : "Ratio";
            Party_Label.Text = (IsDexNav) ? "Search Level" : "Party";

            ratio.Minimum = 1; ratio.Maximum = 99;

            if (SearchGen.SelectedIndex == 0)
            {
                min.Value = min.Minimum = !ORAS ? 35 :
                                          (ORAS && Method == 0) ? 11 :
                                          (ORAS && Method != 0) ? 20 : 0;
                max.Value = (!ORAS && Method == 6) ? 800 : 150;
            }
            else
            {
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }

            if (Method != 0)
            {
                ratio_ValueChanged(null, null);
                SpeciesCombo.Items.Clear();
                if (Method != 7)
                    ManageLocations();

                Species_Label.Location = new Point(13, 46); SpeciesCombo.Location = new Point(75, 42);
                Slots_Label.Location = new Point(13, 93); SlotsComboBox.Location = new Point(75, 89);

                Flute1_Label.Location = new Point(245, 45);
                Flute1.Location = new Point(313, 42);
                SyncBox.Location = new Point(53, 148);
                Party_Label.Location = new Point(332, 197);
                party.Minimum = 1; party.Maximum = 6; party.Value = party.Maximum;
                Slots_Label.Enabled = SlotsComboBox.Enabled = SyncBox.Enabled = true;
                
                if (Method == 4)
                {
                    Flute1_Label.Location = new Point(245, 55);
                    Flute1.Location = new Point(313, 52);
                    HASlot.SelectedIndex = 0;
                    SyncBox.Location = new Point(35, 175);
                }
                else if (Method == 6)
                {
                    ratio.Minimum = 0;
                    if (!ORAS)
                    {
                        ratio.Value = 1;    //Chain
                        ratio.Maximum = 60;
                        ratio_ValueChanged(null, null);
                    }
                    else
                    {
                        ratio.Value = 0;    //Chain
                        party.Maximum = 999;
                        party.Value = 999;
                        Party_Label.Location = new Point(284, 196);
                        Slots_Label.Location = new Point(13, 93);
                        SlotsComboBox.Location = new Point(75, 89);
                        Flute1_Label.Location = new Point(220, 139);
                        Flute1.Location = new Point(311, 137);
                    }
                }
                else if (Method == 7)
                {
                    location_SelectedIndexChanged(null, null);
                    ManageRatio();
                }
            }
        }

        private void DefaultChanges()
        {
            FluteOption.SelectedIndex = 0;

            BonusMusicBox.Location = new Point(335, 34);
            CharmBox.Location = new Point(335, 34);

            TIDBOX.Location = new Point(75, 78);
            tid.Location = new Point(139, 77);
            SIDBOX.Location = new Point(75, 117);
            sid.Location = new Point(139, 116);

            HA_Label.Location = new Point(13, 140);
            HASlot.Location = new Point(75, 137);

            Patches_Board.Location = new Point(242, 38);
            Patches_Board.Text = "#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########";

            Step_Label.Location = new Point(75, 119);
            Chain_Label.Location = new Point(75, 149);

            NavFilters_Label.Location = new Point(13, 140);
            NavFilters.Location = new Point(75, 137);
            Potential_Label.Location = new Point(220, 91);
            Potential.Location = new Point(311, 89);

            Searcher.AutoGenerateColumns = false;
            Generator.AutoGenerateColumns = false;

            DoubleBuffered(Searcher);
            DoubleBuffered(Generator);
        }

        public bool CheckMethod(string m)
        {
            return Methods.SelectedItem.ToString().Equals(m);
        }

        
        #endregion

        #region ManageDataGridviews
        
        private void ManageColumns(DataGridView dgv, byte method)
        {
            string L = dgv == Generator ? "G" : "S";
            dgv.Columns[L + "_TID"].Visible = dgv.Columns[L + "_SID"].Visible = 
                dgv.Columns[L + "_TSV"].Visible = dgv.Columns[L + "_TRV"].Visible = 
                dgv.Columns[L + "_RandHex"].Visible = method == 0;

            dgv.Columns[L + "_Right"].Visible = dgv.Columns[L + "_Up"].Visible =
                dgv.Columns[L + "_Type"].Visible =
                dgv.Columns[L + "_HA_DexNav"].Visible =
                dgv.Columns[L + "_Potential"].Visible =
                dgv.Columns[L + "_EggMove"].Visible = IsDexNav;

            dgv.Columns[L + "_Ratio"].Visible = (method >= 1 && method <= 3) || method == 7 || MovingHordeOption;
            dgv.Columns[L + "_Slot"].Visible = dgv.Columns[L + "_Sync"].Visible = dgv.Columns[L + "_Item"].Visible =
                dgv.Columns[L + "_Level"].Visible = dgv.Columns[L + "_SpeciesInfo"].Visible = method != 0 && !isRadar1;

            dgv.Columns[L + "_Delay"].Visible = dgv.Columns[L + "_Timeline"].Visible = method == 2;
            dgv.Columns[L + "_HA_Horde"].Visible = method == 4;
            dgv.Columns[L + "_Music"].Visible = !ORAS && method == 6;
            dgv.Columns[L + "_Shiny"].Visible = IsDexNav || isRadar1;
            //dgv.Columns[L + "_Flute"].Visible = IsORAS && method != 0 && method != 4;
            //dgv.Columns[L + "_Flutes"].Visible = IsORAS && method == 4;
            //dgv.Columns[L + "_Rand100"].Visible = method != 0;

            dgv.Columns[L + "_Level"].Width = method == 4 ? 100 : 60;
            dgv.Columns[L + "_Item"].Width = method == 4 ? 200 : 110;

            AllowCellFormatting = true;
        }

        private new void DoubleBuffered(DataGridView dgv)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }
        private void CellFormatting(DataGridView dgv, int row, string L)
        {
            if (AllowCellFormatting)
            {
                if (MethodUsed == 1 || MethodUsed == 2 || MethodUsed == 7)
                {
                    if (Convert.ToInt32(dgv.Rows[row].Cells[L + "_Ratio"].Value) < ratio.Value &&
                        (!settings.movingHordes || (settings.movingHordes && Convert.ToByte(dgv.Rows[row].Cells[L + "_Rand100"].Value) > 4)))
                    {
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                    }  
                }
                else if (MethodUsed == 3)
                {
                    if (Convert.ToInt32(dgv.Rows[row].Cells[L + "_Ratio"].Value) == 0)
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (MethodUsed == 4)
                {
                    if (Convert.ToInt32(dgv.Rows[row].Cells[L + "_Ratio"].Value) < ratio.Value
                        && Convert.ToInt32(dgv.Rows[row].Cells[L + "_Rand100"].Value) < 5
                        && MovingHordeOption)
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (isRadar1)
                {
                    if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Shiny"].Value))
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                }
                else if (IsDexNav)
                {
                    if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Success"].Value))
                    {
                        if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Shiny"].Value))
                            dgv.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                        else
                            dgv.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void Searcher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(Searcher, e.RowIndex, "S");
        }

        private void Generator_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(Generator, e.RowIndex, "G");
        }

        private void Searcher_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SearchList != null)
            {
                ascending = !ascending;
                string SelectedColumn = Searcher.Columns[e.ColumnIndex].DataPropertyName;
                SortRowsTinyMT sort = new SortRowsTinyMT();
                sort.SortRows(SearchList, SelectedColumn, ascending ? 1 : -1);
                Searcher.Refresh();
            }
        }

        private void Generator_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GenList != null)
            {
                ascending = !ascending;
                string SelectedColumn = Generator.Columns[e.ColumnIndex].DataPropertyName;
                SortRowsTinyMT sort = new SortRowsTinyMT();
                sort.SortRows(GenList, SelectedColumn, ascending ? 1 : -1);
                Generator.Refresh();
            }
        }

        private void Generator_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Method == 6 && !ORAS)
            {
                try
                {
                    Patches_Board.Text = Generator.Rows[e.RowIndex].Cells["G_Patches"].Value.ToString();
                }
                catch
                { }
            }
        }
        private void Searcher_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Method == 6 && !ORAS)
            {
                try
                {
                    Patches_Board.Text = Searcher.Rows[e.RowIndex].Cells["S_Patches"].Value.ToString();
                }
                catch
                { }
            }
        }

        private void Searcher_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Searcher.Rows.Count > 0)
            {
                try
                {
                    Searcher.CurrentCell = Searcher.Rows[e.RowIndex].Cells[0];
                }
                catch { }   //Do nothing if the user clicks in a cell header
            }
        }
        private void DateRNGSeed_Click(object sender, EventArgs e)
        {
            if (Searcher.Rows.Count > 0)
            {
                try
                {
                    OpenMTForm();
                    mersenne.SetDate(Searcher.SelectedCells[0].Value.ToString());
                }
                catch { }   //Do nothing if the user clicks in a cell header
            }
        }

        private void Generator_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Generator.Rows.Count > 0 && e.Button == MouseButtons.Right)
            {
                try
                {
                    /*Generator.Rows[e.RowIndex].Cells["G_Tiny3"].Selected = true;
                    Generator.Rows[e.RowIndex].Cells["G_Tiny2"].Selected = true;
                    Generator.Rows[e.RowIndex].Cells["G_Tiny1"].Selected = true;
                    Generator.Rows[e.RowIndex].Cells["G_Tiny0"].Selected = true;*/
                    GeneratorState[3] = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["G_Tiny3"].Value.ToString());
                    GeneratorState[2] = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["G_Tiny2"].Value.ToString());
                    GeneratorState[1] = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["G_Tiny1"].Value.ToString());
                    GeneratorState[0] = Convert.ToUInt32(Generator.Rows[e.RowIndex].Cells["G_Tiny0"].Value.ToString());
                }
                catch { }   //Do nothing if the user clicks in a cell header
            }
        }
        private void SetAsCurrent_Click(object sender, EventArgs e)
        {
            if (Generator.Rows.Count > 0)
            {
                t3.Value = GeneratorState[3];
                t2.Value = GeneratorState[2];
                t1.Value = GeneratorState[1];
                t0.Value = GeneratorState[0];
            }
        }


        #endregion
    }
}