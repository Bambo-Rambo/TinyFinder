using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyFinder.RNG;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm : Form
    {
        Calculate calc = new Calculate();
        DateTime CitraRTC;
        bool Working;
        string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');
        public void SetDate(string date) 
        {
            TargetDate.Text = date.Substring(0, 10);
            SpecificTime.Checked = true;
            TargetTime.Text = date.Substring(11);
        } 
        public void SetGame(bool XY)
        {
            if (XY)
                XY_MTButton.Checked = true;
            else
                ORAS_MTButton.Checked = true;
        }
        public MTForm()
        {
            InitializeComponent();
        }
        private void MTForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
        private void SpecificTime_CheckedChanged(object sender, EventArgs e)
        {
            TargetTime.Enabled = SpecificTime.Checked;
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            Working = StopButton.Enabled = false;
            FindButton.Enabled = true;
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SpecificTime.Checked)
                    CitraRTC = DateTime.ParseExact(TargetDate.Text + TargetTime.Text, "yyyy-MM-ddHH:mm:ss", null);
                else
                    CitraRTC = DateTime.ParseExact(TargetDate.Text, "yyyy-MM-dd", null);

                DateCol.Visible = Frame300Col.Visible = SpecificTime.Checked;
                NewDateCol.Visible = !SpecificTime.Checked;
                Working = StopButton.Enabled = SpecificTime.Checked;
                FindButton.Enabled = !Working;

                Research();
            }
            catch
            {
                MessageBox.Show("Wrong RTC Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Research()
        {
            uint Frame300Seed = Frame300.Value;
            uint NewSavePar = calc.FindSavePar(CitraRTC, CurrentSavePar.Value, Frame300Seed, Target.Value);

            DateTime Finaldate = CitraRTC;
            uint ExtraSeconds = 0;

            int SaveDelay = XY_MTButton.Checked ? 24 : 26;
            MersenneTwister rng = new MersenneTwister(0);

            MT_DGV.Rows.Clear();

            if (!SpecificTime.Checked)
            {
                uint next;
                rng.Reseed(Frame300Seed);
                for (uint i = 0; i < 2000; i++)
                    rng.Generateuint();
                for (uint i = 2000; i < 100000; i++)
                {
                    next = rng.Generateuint();

                    //86400000 is the total MS in a day. For every 1000 added to the Save Par, the seconds are increased by 1
                    //for (uint j = NewSavePar - 86400000; j <= NewSavePar; j += 1000) <- Slow

                    if (next >= NewSavePar - 86400000 && next <= NewSavePar && ((next - (NewSavePar - 86400000)) % 1000 == 0))
                    {
                        Invoke(new Action(() =>
                        {
                            MT_DGV.Rows.Add(
                                null, hex(Frame300Seed), i - SaveDelay, hex(next),
                                Finaldate.AddSeconds((NewSavePar - next) / 1000).ToString("yyyy-MM-ddTHH:mm:ss"));
                        }));
                    }
                }
            }
            else
            {
                FindButton.Text = "Searching...";
                await Task.Run(() =>
                {
                    while (Working)
                    {
                        rng.Reseed(Frame300Seed);

                        for (uint i = 0; i < 2000; i++)
                            rng.Generateuint();
                        for (uint i = 2000; i < 10000; i++)
                        {
                            if (rng.Generateuint() == NewSavePar)
                            {
                                Invoke(new Action(() =>
                                {
                                    MT_DGV.Rows.Add(
                                        Finaldate.AddSeconds(ExtraSeconds).ToString("yyyy-MM-ddTHH:mm:ss"),
                                        hex(Frame300Seed), i - SaveDelay, hex(NewSavePar), null);
                                }));
                            }
                        }

                        ExtraSeconds++;         //+1 second in the RTC increases the Seed by 1000
                        Frame300Seed += 1000;
                    }
                });
                FindButton.Text = "Search";
            }
        }
    }
}
