using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using TinyFinder.Subforms.MT;
using TinyFinder.Main;
using System.Linq;
using TinyFinder.Controls;
using System.ComponentModel;
using System.Security.Claims;

namespace TinyFinder
{
    public partial class Form1 : Form
    {
        private string DexToName(int dex) => Species.SpeciesList.ElementAt(dex).Name;
        private string SelectedSpecies => SpeciesCombo.SelectedItem.ToString();
        int SelectedLocation => (int)locationsComboBox.SelectedIndex;
        Location CurrentLocation => listOfLocations.ElementAt(SelectedLocation);
        private ushort[] GetWildTable => CurrentLocation.GrassTable;
        private ushort[] GetCaveTable => CurrentLocation.CaveTable;
        private ushort[] GetLongTable => CurrentLocation.LongTable;
        private ushort[] GetRedTable => CurrentLocation.RedTable;
        private ushort[] GetYellowTable => CurrentLocation.YellowTable;
        private ushort[] GetPurpleTable => CurrentLocation.PurpleTable;
        private ushort[] GetSwampTable => CurrentLocation.SwampTable;
        private ushort[] GetHordeTable1 => CurrentLocation.HordeTable1;
        private ushort[] GetHordeTable2 => CurrentLocation.HordeTable2;
        private ushort[] GetHordeTable3 => CurrentLocation.HordeTable3;
        private ushort[] GetSurfTable => CurrentLocation.SurfTable;
        private ushort[] GetOldTable => CurrentLocation.OldTable;
        private ushort[] GetGoodTable => CurrentLocation.GoodTable;
        private ushort[] GetSuperTable => CurrentLocation.SuperTable;
        private ushort[] GetSmashTable => CurrentLocation.SmashTable;
        private ushort[] GetNavTable => CurrentLocation.DexNavTable;
        private ushort[] GetAmbushTable => CurrentLocation.AmbushTable;
        private List<ushort> GetFSList => Species.getFSList();

        bool ORAS => GameVersion.SelectedIndex > 1;
        
        bool Surfing => EncounterSettings.SelectedIndex != -1 && EncounterSettings.SelectedItem.ToString().Equals("Water");
        bool Fishing => EncounterSettings.SelectedIndex != -1 && EncounterSettings.SelectedItem.ToString().Contains("Rod");
        bool LongGrass => EncounterSettings.SelectedIndex != -1 && EncounterSettings.SelectedItem.ToString().Equals("Long Grass");
        bool Swampy => EncounterSettings.SelectedIndex != -1 && EncounterSettings.SelectedItem.ToString().Equals("Swamp");

        private EncounterType SelectedEncounter => Methods.SelectedItem as EncounterType;

        bool IsID => SelectedEncounter.Key == EnctrKey.ID;
        bool IsWild => SelectedEncounter.Key == EnctrKey.Wild;
        bool IsFishing => SelectedEncounter.Key == EnctrKey.Fishing;
        bool IsRockSmash => SelectedEncounter.Key == EnctrKey.RockSmash;

        bool IsHorde => SelectedEncounter.Key == EnctrKey.Horde;
        bool MovingHordeOption => IsHorde && EncounterSettings.SelectedIndex == 1;      // User selected moving horde method

        bool IsHoney => SelectedEncounter.Key == EnctrKey.Honey;

        bool IsRadar => SelectedEncounter.Key == EnctrKey.Radar;
        private bool IsRadar1 => IsRadar && CurrentChain.Value > 0;

        bool IsFriendSafari => SelectedEncounter.Key == EnctrKey.FS;
        bool IsAmbush => SelectedEncounter.Key == EnctrKey.Ambush;

        bool IsDexNavMov => SelectedEncounter.Key == EnctrKey.DexNavMov;
        bool IsDexNavSrch => SelectedEncounter.Key == EnctrKey.DexNavSrch;
        bool IsDexNav => IsDexNavMov || IsDexNavSrch;
        private bool HasExclusives => GetNavTable != null && LegendDefeated.Checked;

        Data data = new Data();
        NTRHelper ntrhelper;
        MTForm mersenne;
        Calculate calc = new Calculate();

        bool[] SelectedSlots;
        bool AllowCellFormatting, ascending;
        uint[] GeneratorState = new uint[4];

        List<Location> listOfLocations;
        List<EncounterType> EncounterTypeList;

        public Form1()
        {
            InitializeComponent();
            Text += $"{Application.ProductVersion}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Generator.Size = new Size(1223, 315);           // Size breaks for some reason

            GameVersion.SelectedIndex = 0;
            year.Value = DateTime.Now.Year; Months.SelectedIndex = DateTime.Now.Month - 1;

            ThreadCount.Value = Properties.Settings.Default.CPUs == 0 ? Environment.ProcessorCount : Properties.Settings.Default.CPUs;
            ThreadCount.Maximum = Environment.ProcessorCount;

            DefaultChanges();
            Methods.SelectedIndex = 0;
            SearchGen.SelectedIndex = 1;
            ReaderBTN.Checked = true;
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
            MainButton.Text = SearchGen.SelectedIndex == 0 ? "Search" : "Generate";
        }
        private void year_ValueChanged(object sender, EventArgs e)
        {
            if (SearchGen.SelectedIndex == 0)
                Date_Label.Text = "Set the RTC to " + year.Value + "-01-01 13:00:00";
            TinyChanged();
        }
        private void ThreadCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CPUs = (int)ThreadCount.Value;
            Properties.Settings.Default.Save();
        }

        private void GameVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LegendDefeated.Text = (GameVersion.SelectedIndex == 2 ? "Groudon" : "Kyogre") + " Defeated";

            EncounterTypeList = EncounterType.GetEncounterTypes(ORAS);
            
            Methods.DataSource = EncounterTypeList;
            Methods.DisplayMember = "Name";

            Methods.SelectedIndex = 0;
            ManageControls();
            if (mersenne != null)
                mersenne.SetGame(!ORAS);
        }

        private void SearchGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool DateSearcher = SearchGen.SelectedIndex == 0;
            Year_Label.Visible = year.Visible = Month_Label.Visible = Months.Visible = Date_Label.Visible = DateRNGSeed.Visible = DateSearcher;
            ntr.Enabled = updateBTN.Visible = IgnoreFiltersButton.Visible = OffsetCalc.Visible = !DateSearcher;

            if (!Working)
                MainButton.Text = DateSearcher ? "Search" : "Generate";

            if (DateSearcher)
            {
                Step_Info.Visible = Chain_Info.Visible = false;
                min.Value = min.Minimum = !ORAS ? 35 :
                                          (ORAS && IsID) ? 11 :
                                          (ORAS && !IsID) ? 20 : 0;
                max.Value = IsRadar ? 800 : 150;

            }
            else
            {
                min.Minimum = 0; min.Value = 0;     //Careful for exception here
                if (!IsID)
                    SetMin();
                max.Value = 50000;
            }
        }

        private void ManageLocations()
        {
            switch (GameVersion.SelectedIndex)
            {
                case 0:
                    listOfLocations = TableXY.EncounterTable(true);
                    break;
                case 1:
                    listOfLocations = TableXY.EncounterTable(false);
                    break;
                case 2:
                    listOfLocations = TableORAS.EncounterTable(true);
                    break;
                case 3:
                    listOfLocations = TableORAS.EncounterTable(false);
                    break;
            }

            locationsComboBox.Items.Clear();
            foreach (Location temp in listOfLocations.ToList())     // Create a copy of list since we remove items
            {
                if (
                (IsWild && !temp.HasNormalWild()) ||

                (IsFishing && !temp.HasFishing()) ||
              //(IsFishing && temp.ConsoleDelayRand == 0) ||

                (IsRockSmash && temp.SmashTable == null) ||

                (IsHorde && temp.HordeTable1 == null) ||            // Only checking the 1st horde table works

                (IsHoney && !temp.HasHoneyWild()) ||

                (IsRadar && !temp.HasRadar()) ||

                (IsDexNav && !temp.HasDexNav()) ||

                (IsAmbush && temp.AmbushTable == null))
                {
                    listOfLocations.Remove(temp);
                    continue;
                }
                locationsComboBox.Items.Add(temp.Name);
            }
            locationsComboBox.SelectedIndex = 0;
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            EncounterSettings.Items.Clear();
            if (IsWild)
            {
                if (GetWildTable != null)
                    EncounterSettings.Items.Add("Grass");
                if (GetCaveTable != null)
                    EncounterSettings.Items.Add("Cave");
                if (GetLongTable != null)
                    EncounterSettings.Items.Add("Long Grass");
                if (GetRedTable != null)
                    EncounterSettings.Items.Add("Red Flowers");
                if (GetYellowTable != null)
                    EncounterSettings.Items.Add("Yellow Flowers");
                if (GetPurpleTable != null)
                    EncounterSettings.Items.Add("Purple Flowers");
                if (GetSwampTable != null)
                    EncounterSettings.Items.Add("Swamp");
                if (CurrentLocation.RideTable != null)
                    EncounterSettings.Items.Add("Riding");
                if (GetSurfTable != null)
                    EncounterSettings.Items.Add("Water");
            }
            else if (IsFishing)
            {
                EncounterSettings.Items.Add("Old Rod");
                EncounterSettings.Items.Add("Good Rod");
                EncounterSettings.Items.Add("Super Rod");
            }
            else if (IsHorde)
            {
                EncounterSettings.Items.Add("Honey");
                if (!ORAS || (GetLongTable != null))
                    EncounterSettings.Items.Add("Moving");
            }
            else if (IsHoney)
            {
                if (GetHordeTable1 == null)
                {
                    if (GetWildTable != null)
                        EncounterSettings.Items.Add("Grass");
                    if (GetRedTable != null)
                        EncounterSettings.Items.Add("Red Flowers");
                    if (GetYellowTable != null)
                        EncounterSettings.Items.Add("Yellow Flowers");
                    if (GetPurpleTable != null)
                        EncounterSettings.Items.Add("Purple Flowers");
                    if (GetLongTable != null)
                        EncounterSettings.Items.Add("Long Grass");
                    if (GetCaveTable != null)
                        EncounterSettings.Items.Add("Cave");
                }
                if (GetSwampTable != null)
                    EncounterSettings.Items.Add("Swamp");
                if (GetSurfTable != null)
                    EncounterSettings.Items.Add("Water");
            }
            else if (IsRadar || IsDexNav)
            {
                if (GetWildTable != null)
                    EncounterSettings.Items.Add("Grass");
                if (IsDexNav)
                {
                    if (GetCaveTable != null)
                        EncounterSettings.Items.Add("Cave");
                    if (GetLongTable != null)
                        EncounterSettings.Items.Add("Long Grass");
                    if (GetSurfTable != null)
                        EncounterSettings.Items.Add("Water");

                    if (IsDexNavSrch && GetOldTable != null)
                    {
                        EncounterSettings.Items.Add("Old Rod");
                        EncounterSettings.Items.Add("Good Rod");
                        EncounterSettings.Items.Add("Super Rod");
                    }
                }
                else
                {
                    if (GetLongTable != null)
                        EncounterSettings.Items.Add("Long Grass");
                    if (GetRedTable != null)
                        EncounterSettings.Items.Add("Red Flowers");
                    if (GetYellowTable != null)
                        EncounterSettings.Items.Add("Yellow Flowers");
                    if (GetPurpleTable != null)
                        EncounterSettings.Items.Add("Purple Flowers");
                }
            }
            else if (IsFriendSafari)
            {
                EncounterSettings.Items.Add("2 Slots");
                EncounterSettings.Items.Add("3 Slots");
            }

            if (EncounterSettings.Items.Count != 0)
            {
                if (IsFishing)
                    EncounterSettings.SelectedIndex = 2;    // For fishing, Super rod is the default choice
                else if (IsFriendSafari)
                    EncounterSettings.SelectedIndex = 1;    // For FS, 3 slots is the default choice
                else
                    EncounterSettings.SelectedIndex = 0;
            }
            else
            {
                SetMin();
                ManageSpecies();
            }

        }

        private void EncounterChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageRatio();
            SetMin();
            if (IsHorde)
            {
                Rate_Label.Visible = ratio.Visible = MovingHordeOption;
                EmuBox.Visible = !MovingHordeOption;
            }
            ManageSpecies();
        }

        private void ManageRatio()
        {
            if (IsWild || MovingHordeOption)
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
            else if (IsFishing)
                ratio.Value = 49;
            else if (IsFriendSafari)
                ratio.Value = 13;
        }

        private void ManageSpecies()
        {
            SpeciesCombo.Items.Clear();

            if (IsFriendSafari)
            {
                foreach (int num in GetFSList)
                    SpeciesCombo.Items.Add(DexToName(num));
            }
            else
            {
                if (!IsDexNavSrch)
                    SpeciesCombo.Items.Add("Any");
                if (IsHorde)
                {
                    HashSet<string> SlotSpecies = new HashSet<string>(NameHordeSlots());
                    foreach (string s in SlotSpecies)
                        SpeciesCombo.Items.Add(s);
                }
                else
                {
                    HashSet<ushort> SlotSpecies = new HashSet<ushort>(SlotTable());

                    if (IsDexNav && HasExclusives)
                    {
                        HashSet<ushort> navSpecies = new HashSet<ushort>(GetNavTable);
                        // Merge DexNav slots with water slots ONLY if every other table doesn't exit for a given location
                        if (!Fishing && (!Surfing || (GetWildTable == null && GetCaveTable == null && GetLongTable == null)))
                        {
                            SlotSpecies.UnionWith(navSpecies);
                        }
                    }

                    foreach (int s in SlotSpecies)
                        SpeciesCombo.Items.Add(DexToName(s));
                }
            }

            SpeciesCombo.SelectedIndex = 0;

        }
        private void Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSlots();
            if (IsHorde)
                for (int i = 1; i <= 3; i++)
                    SlotsComboBox.CheckBoxItems[i].Checked = SpeciesCombo.SelectedItem.ToString().Equals(NameHordeSlots()[i - 1]);
            else if (!IsFriendSafari && !IsDexNavSrch)
            {
                ushort[] tempTable;
                if (IsDexNav && AddExclusiveSlots())
                    tempTable = GetNavTable;
                else
                    tempTable = SlotTable();
                for (int i = 1; i < SlotsComboBox.Items.Count; i++)
                    SlotsComboBox.CheckBoxItems[i].Checked = DexToName(tempTable[i - 1]).Equals(SelectedSpecies);
            }
        }

        private ushort[] SlotTable()
        {
            if (IsRockSmash)
                return GetSmashTable;
            if (IsFriendSafari)
                return null;
            if (IsAmbush)
                return GetAmbushTable;

            switch (EncounterSettings.SelectedItem.ToString())
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
                default:
                    MessageBox.Show("Faulty Encounter Type.");
                    break;
            }

            return null;
        }

        public string[] NameHordeSlots()
        {
            string[] HordeSlots = new string[3];
            HordeSlots[0] = NameHordeSlot(GetHordeTable1);
            HordeSlots[1] = NameHordeSlot(GetHordeTable2);
            HordeSlots[2] = NameHordeSlot(GetHordeTable3);
            return HordeSlots;
        }

        public string NameHordeSlot(ushort[] hordeTable)
        {
            if (hordeTable.All(x => x == hordeTable[0]))
                return "5 " + DexToName(hordeTable[0]);

            object outsider = hordeTable.GroupBy(x => x).Single(group => group.Count() == 1).Key;
            int outsiderSlot = Array.IndexOf(hordeTable, outsider);
            return "4 " + DexToName(hordeTable[0]) + ", 1 " + DexToName(hordeTable[outsiderSlot]);
        }

        private int getBagAdvances()
        {
            int Advances;
            if (CurrentLocation.Bag_Advances == 0)
                Advances = ORAS ? 15 : 27;
            else
                Advances = CurrentLocation.Bag_Advances;
            if (IsDexNavSrch)
                Advances++;
            return Advances;
        }
        private void SetMin()
        {
            if (SearchGen.SelectedIndex == 1)
            {
                if (IsFriendSafari)
                    min.Value = 27;
                else if (IsWild || MovingHordeOption || IsDexNav || IsFriendSafari || IsAmbush || (IsRadar && !IsRadar1))
                    min.Value = getBagAdvances();
                else
                    min.Value = 0;
            }
        }

        private bool AddExclusiveSlots()
        {
            if (HasExclusives)
                for (int i = 0; i < 3; i++)
                    if (DexToName(GetNavTable[i]).Equals(SelectedSpecies))
                        return true;
            return false;
        }

        private int[] LevelTable()
        {
            if (IsRockSmash)
                return CurrentLocation.SmashLevel;
            else if (IsAmbush)
                return CurrentLocation.AmbushLevel;
            else if (IsFriendSafari)
                return null;

            switch (EncounterSettings.SelectedItem.ToString())
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
                    MessageBox.Show("Faulty Level table.");
                    return null;
            }
        }

        private void ManageSlots()
        {
            //Default values for most methods
            int SlotsCount = 12;
            ushort ComboBoxHeight = 310;
            //

            switch (SelectedEncounter.Key)
            {
                case EnctrKey.RockSmash:
                    SlotsCount = 5;
                    ComboBoxHeight = 140;
                    break;

                case EnctrKey.Wild:
                case EnctrKey.Honey:
                    SlotsCount = Surfing ? 5 : 12;
                    ComboBoxHeight = (ushort)(Surfing ? 140 : 310);
                    break;

                case EnctrKey.DexNavMov:
                case EnctrKey.DexNavSrch:
                case EnctrKey.Radar:

                    if (IsDexNav && AddExclusiveSlots())
                    {
                        SlotsCount = 3;
                        ComboBoxHeight = 90;
                    }
                    else
                    {
                        SlotsCount = Surfing ? 5 : 12;
                        ComboBoxHeight = (ushort)(Surfing ? 140 : 310);
                    }
                    break;
                case EnctrKey.FS:
                    SlotsCount = EncounterSettings.SelectedIndex + 2;
                    ComboBoxHeight = (ushort)(SlotsCount == 2 ? 65 : 90);
                    break;

                case EnctrKey.Fishing:
                case EnctrKey.Horde:
                    SlotsCount = 3;
                    ComboBoxHeight = 90;
                    break;
            }
            // All slots need to be unchecked before being removed to clear the slot text in combobox
            for (int i = 0; i < SlotsComboBox.Items.Count; i++)
                SlotsComboBox.CheckBoxItems[i].Checked = false;
            SlotsComboBox.Items.Clear();
            SlotsComboBox.DropDownHeight = ComboBoxHeight;
            for (int add = 1; add < SlotsCount + 1; add++)
                SlotsComboBox.Items.AddRange(new object[] { add });
        }

        #region Manage Buttons and Slots

        private void CurrentChain_ValueChanged(object sender, EventArgs e)
        {
            Species_Label.Enabled = SpeciesCombo.Enabled = SyncBox.Enabled = SlotsComboBox.Enabled = Slots_Label.Enabled = !IsRadar1;
            BonusMusicBox.Enabled = IsRadar1;
        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageControls();
        }
        private void ManageControls()
        {
            OffsetCalc.Enabled = !IsID;

            //It's safer to use the fields of the class directly rather than methods like "IsWild", "IsHorde" etc

            TIDBOX.Visible = SIDBOX.Visible = TIDValue.Visible = SIDValue.Visible = SelectedEncounter.ShowsTIDSID;
            SlotsComboBox.Visible = Slots_Label.Visible = SelectedEncounter.ShowsSlots;
            Species_Label.Visible = SpeciesCombo.Visible = SelectedEncounter.ShowsSpecies;
            SyncBox.Visible = SelectedEncounter.ShowsSync;

            FluteOptionLabel.Visible = FluteOption.Visible = Flute1_Label.Visible = Flute1.Visible = SelectedEncounter.ShowsFlute;
            Flute2_Label.Visible = Flute2.Visible = Flute3_Label.Visible = Flute3.Visible = Flute4_Label.Visible =
                Flute4.Visible = Flute5_Label.Visible = Flute5.Visible = SelectedEncounter.ShowsMultiFlutes;

            HASlot.Visible = HA_Label.Visible = SelectedEncounter.ShowsHordeInfo;
            Rate_Label.Visible = ratio.Visible = SelectedEncounter.ShowsRatio;
            Chain_Label.Visible = CurrentChain.Visible = SelectedEncounter.ShowsChain;
            Location_Label.Visible = locationsComboBox.Visible = SelectedEncounter.ShowsLocations;
            BonusMusicBox.Visible = Patches_Board.Visible = SelectedEncounter.ShowsRadarInfo;

            EmuBox.Visible = SelectedEncounter.ShowsEmulator;
            Interact_Label.Visible = InteractFrame.Visible = SelectedEncounter.ShowsTriggerMTFrame;

            CharmBox.Visible = SearchLvl_Label.Visible = SearchLvl.Visible = NavFilters_Label.Visible = NavFilters.Visible =
                Potential_Label.Visible = Potential.Visible = LegendDefeated.Visible = SelectedEncounter.ShowsDexNavInfo;
            AltEggMove.Visible = IsDexNavMov;

            Party_Label.Visible = party.Visible = SelectedEncounter.ShowsParty;
            EncounterSettings.Visible = SelectedEncounter.ShowsSettings;

            Step_Info.Visible = Chain_Info.Visible = false;

            Flute1_Label.Text = "Flute" + (IsHorde ? " 1" : "");

            InteractFrame.Value = SelectedEncounter.InteractMT;

            if (SearchGen.SelectedIndex == 0)
            {
                min.Value = min.Minimum = !ORAS ? 35 :
                                          (ORAS && IsID) ? 13 :  // ? 11 :
                                          (ORAS && !IsID) ? 20 : 0;
                max.Value = IsRadar ? 800 : 150;
            }
            else
            {
                min.Minimum = 0; min.Value = 0;
                max.Value = 50000;
            }

            if (!IsID)
            {
                CurrentChain_ValueChanged(null, null);
                SpeciesCombo.Items.Clear();
                if (!IsFriendSafari)
                    ManageLocations();

                Species_Label.Location = new Point(13, 46); SpeciesCombo.Location = new Point(75, 42);
                Slots_Label.Location = new Point(13, 93); SlotsComboBox.Location = new Point(75, 89);

                Flute1_Label.Location = new Point(245, 45);
                Flute1.Location = new Point(313, 42);
                SyncBox.Location = new Point(53, 148);
                Slots_Label.Enabled = SlotsComboBox.Enabled = SyncBox.Enabled = true;
                
                if (IsHorde)
                {
                    Flute1_Label.Location = new Point(257, 55);
                    Flute1.Location = new Point(325, 52);
                    HASlot.SelectedIndex = 0;
                    SyncBox.Location = new Point(35, 175);
                }
                else if (IsRadar)
                {
                    CurrentChain.Value = 1;
                    CurrentChain.Maximum = 255;
                    CurrentChain_ValueChanged(null, null);
                }
                else if (IsDexNav)
                {
                    CurrentChain.Value = 0;
                    CurrentChain.Maximum = 99;
                    Slots_Label.Location = new Point(13, 93);
                    SlotsComboBox.Location = new Point(75, 89);
                    Flute1_Label.Location = new Point(240, 94);
                    Flute1.Location = new Point(331, 92);
                }
                else if (IsFriendSafari)
                {
                    location_SelectedIndexChanged(null, null);
                }
            }
        }

        private void DefaultChanges()
        {
            FluteOption.SelectedIndex = 0;

            TIDBOX.Location = new Point(105, 78);
            TIDValue.Location = new Point(170, 77);
            SIDBOX.Location = new Point(105, 117);
            SIDValue.Location = new Point(170, 116);

            HA_Label.Location = new Point(13, 140);
            HASlot.Location = new Point(75, 137);

            Patches_Board.Location = new Point(242, 38);
            Patches_Board.Text = "#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########\n#########";

            Step_Info.Location = new Point(75, 119);
            Chain_Info.Location = new Point(75, 149);

            NavFilters_Label.Location = new Point(13, 140);
            NavFilters.Location = new Point(75, 137);
            Potential_Label.Location = new Point(240, 46);
            Potential.Location = new Point(331, 44);
            AltEggMove.Location = new Point(243, 140);

            Searcher.AutoGenerateColumns = false;
            Generator.AutoGenerateColumns = false;

            DoubleBuffered(Searcher);
            DoubleBuffered(Generator);
        }

        
        #endregion

        #region ManageDataGridviews
        
        private void ManageColumns(DataGridView dgv, EncounterType choice)
        {
            string L = dgv == Generator ? "G" : "S";
            dgv.Columns[L + "_TID"].Visible = dgv.Columns[L + "_SID"].Visible =
                dgv.Columns[L + "_TSV"].Visible = dgv.Columns[L + "_TRV"].Visible = IsID;
            //dgv.Columns[L + "_RandHex"].Visible = IsID;

            dgv.Columns[L + "_Right"].Visible = dgv.Columns[L + "_Up"].Visible =
                dgv.Columns[L + "_HA_DexNav"].Visible =
                dgv.Columns[L + "_Potential"].Visible =
                dgv.Columns[L + "_EggMove"].Visible = IsDexNav;
            dgv.Columns[L + "_Type"].Visible = IsDexNavMov;

            dgv.Columns[L + "_Ratio"].Visible = choice.ShowsRatio || MovingHordeOption;
            dgv.Columns[L + "_SpeciesInfo"].Visible = dgv.Columns[L + "_Sync"].Visible = 
                dgv.Columns[L + "_Item"].Visible = dgv.Columns[L + "_Level"].Visible = choice.ShowsSpecies && !IsRadar1;
            dgv.Columns[L + "_Slot"].Visible = choice.ShowsSlots && !IsRadar1;

            dgv.Columns[L + "_Delay"].Visible = //dgv.Columns[L + "_Timeline"].Visible = 
                IsFishing || IsDexNavSrch || IsRockSmash || (IsHorde && !MovingHordeOption) || IsHoney;
            dgv.Columns[L + "_HA_Horde"].Visible = IsHorde;
            dgv.Columns[L + "_Music"].Visible = IsRadar;
            dgv.Columns[L + "_Shiny"].Visible = IsRadar1;
            dgv.Columns[L + "_Rand100"].Visible = choice.Key == EnctrKey.Ambush;

            dgv.Columns[L + "_Level"].Width = IsHorde ? 100 : 60;
            dgv.Columns[L + "_Item"].Width = IsHorde ? 260 : 110;
            dgv.Columns[L + "_Timeline"].Width = IsFishing ? 250 : 130;

            AllowCellFormatting = true;
        }

        private new void DoubleBuffered(DataGridView dgv)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }
        private void CellFormatting(DataGridView dgv, int row, string L, DataGridViewCellFormattingEventArgs e)
        {
            if (AllowCellFormatting)
            {
                bool risky = false;
                if (IsFishing || IsRockSmash || IsHorde || IsHoney || IsDexNavSrch)
                    if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Risky"].Value))
                        risky = true;

                if (ratio.Visible && Convert.ToInt32(dgv.Rows[row].Cells[L + "_Ratio"].Value) < ratio.Value)
                {
                    if (Convert.ToInt32(dgv.Rows[row].Cells[L + "_Rand100"].Value) < 5)
                    {
                        if (!settings.possibleHorde)
                            dgv.Rows[row].DefaultCellStyle.BackColor = risky ? Color.LightCoral : Color.LightYellow;
                    }
                    else if (!MovingHordeOption)
                    {
                        dgv.Rows[row].DefaultCellStyle.BackColor = risky ? Color.LightCoral : Color.LightYellow;
                    }
                }

                if (IsRockSmash)
                {
                    if (Convert.ToInt32(dgv.Rows[row].Cells[L + "_Ratio"].Value) == 0)
                        dgv.Rows[row].DefaultCellStyle.BackColor = risky ? Color.LightCoral : Color.LightYellow;
                }
                else if (EnctrTypeChosen == EnctrKey.Horde)
                {
                    if (risky)
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.LightCoral;

                }
                else if (IsRadar1)
                {
                    if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Shiny"].Value))
                        dgv.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
                }
                else if (IsDexNav)
                {
                    if (IsDexNavSrch || Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Success"].Value))
                    {
                        if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Shiny"].Value))
                            dgv.Rows[row].DefaultCellStyle.BackColor = risky ? Color.LightCoral : Color.Aqua;
                        else if (!IsDexNavSrch)
                            dgv.Rows[row].DefaultCellStyle.BackColor = risky ? Color.LightCoral : Color.LightYellow;
                    }
                    if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_Boost"].Value))
                    {
                        if (dgv.Columns[e.ColumnIndex].Name.Equals(L + "_Level"))
                            e.CellStyle.Font = new Font(dgv.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold);
                    }
                    if (dgv.Columns[e.ColumnIndex].Name.Equals(L + "_EggMove"))
                    {
                        if (Convert.ToBoolean(dgv.Rows[row].Cells[L + "_GoodEggMove"].Value))
                            e.CellStyle.Font = new Font(dgv.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold);
                        else
                            e.CellStyle.ForeColor = Color.Gray;
                    }
                }

            }
        }

        private void Searcher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(Searcher, e.RowIndex, "S", e);
        }

        private void Generator_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(Generator, e.RowIndex, "G", e);
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
            if (IsRadar)
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
            if (IsRadar)
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
                    Generator.ClearSelection();
                    Generator.Rows[e.RowIndex].Selected = true;
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

        private void OffsetCalc_Click(object sender, EventArgs e)
        {
            if (Generator.Rows.Count > 0)
            {
                int EXP = 0, Hld = 0, Move = 0;
                int Target = (int)(uint)Generator.SelectedRows[0].Cells[0].Value;  // The highlighted index from the user
                int Offset = Target - (int)min.Value;

                int BagAdvances = 0;
                if (IsWild || IsFishing || IsRockSmash || MovingHordeOption || IsDexNav)   // Methods that require exiting the bag
                    BagAdvances = getBagAdvances();
                else if (IsFriendSafari)
                    BagAdvances = 27;

                int AdvancesRequired = Offset - BagAdvances;
                if (AdvancesRequired < 0)
                {
                    int EarliestIndex = (int)min.Value + BagAdvances;
                    MessageBox.Show("Index " + Target + " is too close." + "\n" + 
                        "The earliest you can aim for is " + EarliestIndex + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else if (AdvancesRequired == 0)
                {
                    MessageBox.Show("No advances required!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int TargetAdvances = (int)min.Value + AdvancesRequired;
                    string[] Steps = new string[3];
                    int ExpShareAdvances = (int)party.Value * 3;
                    EXP = AdvancesRequired / ExpShareAdvances;
                    int RemainingAdv = AdvancesRequired % ExpShareAdvances;
                    if (RemainingAdv != 0)
                    {
                        Hld = RemainingAdv / 3;
                        Move = (AdvancesRequired % ExpShareAdvances) % 3;
                    }

                    if (EXP != 0)
                        Steps[0] = "Use the Exp. Share " + EXP + " time(s).";
                    if (Hld != 0)
                        Steps[1] = "Give a held item " + Hld + " time(s).";
                    if (Move != 0)
                        Steps[2] = "Reject a new TM/HM move " + Move + " time(s).";

                    string FinalSteps = "";
                    for (int i = 0; i < 3; i++)
                        if (!string.IsNullOrWhiteSpace(Steps[i]))
                            FinalSteps += "\n" + Steps[i];

                    MessageBox.Show(FinalSteps, "Target Advances = " + TargetAdvances, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        #endregion

        #region Rarely useful
        private void min_ValueChanged(object sender, EventArgs e) { max.Minimum = min.Value; }

        private void TinyChanged()
        {
            if (SearchGen.SelectedIndex == 0)
            {
                Calibrated = false;
                //if (!Working)
                    //MainButton.Text = "Calibrate and Search";
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
                if (IsRadar || IsDexNav)
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
                    Step_Info.Visible = true;
                    Step_Info.ForeColor = steps[0] == 19 ? Color.Red : Color.Black;
                    Step_Info.Text = "Step Counter   =   " + steps[0].ToString();
                    break;
                case "DexNavChain":
                    var chain = (uint[])info;
                    CurrentChain.Value = chain[0];
                    Chain_Info.Visible = true;
                    Chain_Info.Text = "Chain Length   =   " + chain[0].ToString();
                    break;
                case "RadarChain":
                    var chainRadar = (uint[])info;
                    try
                        {
                            CurrentChain.Value = chainRadar[0];
                        }
                        catch
                        {
                            CurrentChain.Value = 255;
                        }
                    Chain_Info.Visible = true;
                    Chain_Info.Location = new Point(25, 118);
                    Chain_Info.Text = "Chain Length   =   " + chainRadar[0].ToString();
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

        private void ReaderBTN_CheckedChanged(object sender, EventArgs e)
        {
            int x = ReaderBTN.Checked ? 45 : 73;
            Tiny3_Label.Location = new Point(x, 103);
            Tiny3_Label.Text = ReaderBTN.Checked ? "TinyMT Seed" : "Tiny [3]";
            Tiny2_Label.Visible = t2.Visible = Tiny1_Label.Visible = t1.Visible = Tiny0_Label.Visible = t0.Visible = !ReaderBTN.Checked;
        }

        private void TIDBOX_CheckedChanged_1(object sender, EventArgs e)
        {
            TIDValue.Enabled = TIDBOX.Checked;
        }
        private void SIDBOX_CheckedChanged(object sender, EventArgs e)
        {
            SIDValue.Enabled = SIDBOX.Checked;
        }

        private void MTSeedGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void TIDSIDGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void NormalGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void HordeGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }
        private void DexNavGuide_Click(object sender, EventArgs e) { data.Guides(sender.ToString()); }


        private void LegendDefeated_CheckedChanged(object sender, EventArgs e)
        {
            ManageSpecies();
        }
        #endregion

    }
}