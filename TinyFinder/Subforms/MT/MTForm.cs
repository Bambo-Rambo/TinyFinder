using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm : Form
    {
        Thread[] jobs;
        Calculate calc = new Calculate();
        DateTime CitraRTC;
        Data data = new Data();
        List<int> SelectedNatures = new List<int>();

        int IVcount, ShinyCount = 0;
        uint StartSeed, EndSeed, Min, Max, TSV, Desired_PID;
        byte TRV, Count8 = 0;
        byte Min_hp, Min_atk, Min_def, Min_spA, Min_spD, Min_spe, Max_hp, Max_atk, Max_def, Max_spA, Max_spD, Max_spe;

        byte Category, ShininessType;
        bool Fast, AnyTSV, EC, PossibleHA;
        string[] Natures;
        char UnownLetter1, UnownLetter2, UnownLetter3;

        public MTForm()
        {
            InitializeComponent();
        }
        private void MTForm_Load(object sender, EventArgs e)
        {
            DoubleBuffer(G6_DGV);
            DoubleBuffer(HORDE_DGV);
            DoubleBuffer(EC_DGV);
            DoubleBuffer(Seed_DGV);
            Gen6Categories.SelectedIndex = 0; ShinyType.SelectedIndex = 3;
            CurrentTSV.Value = (uint)Properties.Settings.Default.PSVs;
            CurrentTRV.Value = (uint)Properties.Settings.Default.PRVs;
            Natures = data.GetNatures();
            DefaulPositions();
            TargetDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void MTForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void Gen6Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = (byte)Gen6Categories.SelectedIndex;

            TSV_Label.Visible = CurrentTSV.Visible = LabelOR.Visible = CurrentTRV.Visible = Category == 0 || Category == 5;
            ShinyLabel.Visible = ShinyType.Visible = Category == 0;

            NiceEC.Visible = Category == 4;

            HAPossible.Visible = Category < 2;

            PID_Label.Visible = PIDBox.Visible = Category > 0 && Category < 4;
            PID_Label.Text = Category == 4 ? "PID/EC" : Category == 2 ? "EC" : "PID";

            CalcUnown.Visible = Nature_Label.Visible = NaturesCBox.Visible = Category != 2 && Category != 5;

            HP_Label.Enabled = ATK_Label.Enabled = DEF_Label.Enabled = SPA_Label.Enabled = SPD_Label.Enabled = SPE_Label.Enabled =
                MinHP.Enabled = MinAtk.Enabled = MinDef.Enabled = MinSpA.Enabled = MinSpD.Enabled = MinSpe.Enabled =
                MaxHP.Enabled = MaxAtk.Enabled = MaxDef.Enabled = MaxSpA.Enabled = MaxSpD.Enabled = MaxSpe.Enabled =
                Set_Label.Enabled = SettingsIVs.Enabled = PerfectIV_Label.Visible = PerfectIVs.Visible = Category != 5;

            EC_DGV.Visible = Category == 2;
            HORDE_DGV.Visible = ShiniesLabel.Visible = HordeShinies.Visible = AnyTSVBox.Visible = FastBox.Visible = Category == 5;
        }
        private void CurrentTSV_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PSVs = (int)CurrentTSV.Value;
            Properties.Settings.Default.Save();
        }
        private void CurrentTRV_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PRVs = (int)CurrentTRV.Value;
            Properties.Settings.Default.Save();
        }
        private void HordeShinies_ValueChanged(object sender, EventArgs e)
        {
            if (HordeShinies.Value == 5)
                AnyTSVBox.Checked = true;
            AnyTSVBox.Enabled = HordeShinies.Value < 5;
        }
        private void SettingsIVs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = SettingsIVs.SelectedIndex;
            SettingsIVs.SelectedItem = null;
            MinHP.Value = MinDef.Value = MinSpA.Value = MinSpD.Value = choice == 0 ? 0 : 31;
            MaxHP.Value = MaxDef.Value = MaxSpA.Value = MaxSpD.Value = 31;
            MinAtk.Value = (choice == 1 || choice == 3) ? 31 : 0; MaxAtk.Value = (choice == 2 || choice == 4) ? 0 : 31;
            MinSpe.Value = (choice == 1 || choice == 2) ? 31 : 0; MaxSpe.Value = (choice == 3 || choice == 4) ? 0 : 31;
        }
        public void SetDate(string date)    //Called from MainForm
        {
            TabList.SelectedIndex = 1;
            TargetDate.Text = date.Substring(0, 10);
            SpecificTime.Checked = true;
            TargetTime.Text = date.Substring(11);
        }
        public void SetGame(bool XY)        //Called from MainForm
        {
            if (XY)
                XY_MTButton.Checked = true;
            else
                ORAS_MTButton.Checked = true;
        }
        private void SpecificTime_CheckedChanged(object sender, EventArgs e)
        {
            TargetTime.Enabled = SpecificTime.Checked;
            SpecificDate.Enabled = !SpecificTime.Checked;
            if (SpecificTime.Checked)
                SpecificDate.Checked = true;
        }

        private void MTStopButton_Click(object sender, EventArgs e)
        {
            foreach (Thread job in jobs)
                if (job != null)
                    job.Abort();

            Finished();
        }
        private void Finished()
        {
            MT_StopButton.Enabled = false;
            MT_SearchButton.Enabled = true;
            MT_SearchButton.Text = "Search";
        }
        private void MTSearchButton_Click(object sender, EventArgs e)
        {
            if (Start_Seed.Value > End_Seed.Value || MinFrame.Value > MaxFrame.Value)
            {
                MessageBox.Show("Seed/Frame Range Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MT_SearchButton.Text = "Searching...";
                MT_SearchButton.Enabled = false;
                MT_StopButton.Enabled = true;
                jobs = new Thread[Properties.Settings.Default.CPUs];

                if (TabList.SelectedIndex == 0)
                {
                    StartSeed = Start_Seed.Value; EndSeed = End_Seed.Value;
                    Min = (uint)MinFrame.Value; Max = (uint)MaxFrame.Value;
                    IVcount = (int)PerfectIVs.Value;
                    ShininessType = (byte)ShinyType.SelectedIndex;

                    if (Category != 5)
                    {
                        G6_DGV.Rows.Clear();
                        EC_DGV.Rows.Clear();

                        PID_EC_Col.HeaderText = PID_Label.Text;
                        UnownCol1.Visible = UnownCol2.Visible = UnownCol3.Visible = CalcUnown.Checked;
                        Count8Col.Visible = Category == 4;

                        EC = Category == 2;
                        PossibleHA = HAPossible.Checked;
                        Desired_PID = PIDBox.Value;

                        Min_hp = (byte)MinHP.Value; Max_hp = (byte)MaxHP.Value;
                        Min_atk = (byte)MinAtk.Value; Max_atk = (byte)MaxAtk.Value;
                        Min_def = (byte)MinDef.Value; Max_def = (byte)MaxDef.Value;
                        Min_spA = (byte)MinSpA.Value; Max_spA = (byte)MaxSpA.Value;
                        Min_spD = (byte)MinSpD.Value; Max_spD = (byte)MaxSpD.Value;
                        Min_spe = (byte)MinSpe.Value; Max_spe = (byte)MaxSpe.Value;

                        SelectSlots();
                    }
                    else
                    {
                        HORDE_DGV.Rows.Clear();
                        TSV = (uint)CurrentTSV.Value;
                        ShinyCount = (int)HordeShinies.Value;
                        AnyTSV = AnyTSVBox.Checked;
                        Fast = FastBox.Checked;
                    }

                    for (int i = 0; i < jobs.Length; i++)
                    {
                        switch (Category)
                        {
                            case 0:
                                jobs[i] = new Thread(() => IVResearch(StartSeed, (uint)jobs.Length));
                                break;
                            case 1:
                            case 2:
                                jobs[i] = new Thread(() => PIDResearch(StartSeed, (uint)jobs.Length));
                                break;
                            case 3:
                                jobs[i] = new Thread(() => PIDRerollResearch(StartSeed, (uint)jobs.Length));
                                break;
                            case 4:
                                jobs[i] = new Thread(() => EC_PID_Research(StartSeed, (uint)jobs.Length));
                                break;
                            case 5:
                                jobs[i] = new Thread(() => HordesResearch(StartSeed, (uint)jobs.Length));
                                break;
                        }
                        jobs[i].Start();
                        Thread.Sleep(100);
                        StartSeed++;
                    }
                }
                else
                {
                    try
                    {
                        int ThreadsForUse;
                        if (SpecificTime.Checked)
                        {
                            CitraRTC = DateTime.ParseExact(TargetDate.Text + TargetTime.Text, "yyyy-MM-ddHH:mm:ss", null);
                            ThreadsForUse = Properties.Settings.Default.CPUs;
                            MT_SearchButton.Text = "Searching...";
                        }
                        else
                        {
                            CitraRTC = DateTime.ParseExact(TargetDate.Text, "yyyy-MM-dd", null);
                            ThreadsForUse = 1;
                        }

                        Seed_DGV.Rows.Clear();
                        DateCol.Visible = Frame300Col.Visible = SpecificTime.Checked;
                        NewDateCol.Visible = !SpecificTime.Checked;

                        for (uint i = 0; i < ThreadsForUse; i++)
                        {
                            jobs[i] = new Thread(() => SeedResearch((uint)ThreadsForUse, i));
                            jobs[i].Start();
                            Thread.Sleep(100);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Wrong RTC Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Finished();
                    }
                }   
            }
        }

        private void DefaulPositions()
        {
            PID_Label.Location = new Point(24, 100); PIDBox.Location = new Point(78, 97);
            Nature_Label.Location = new Point(24, 134); NaturesCBox.Location = new Point(78, 130);
        }

        private void SelectSlots()
        {
            List<string> NatureString = new List<string>();
            for (byte n = 1; n < 26; n++)
                if (NaturesCBox.CheckBoxItems[n].Checked)
                    NatureString.Add(NaturesCBox.CheckBoxItems[n].Text);

            SelectedNatures.Clear();
            for (byte n = 0; n < 25; n++)
                if (NatureString.Contains(Natures[n]))
                    SelectedNatures.Add(n);
        }

        private void DoubleBuffer(DataGridView view)
        {
            Type dgvType = view.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(view, true, null);
        }
    }
}