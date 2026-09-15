using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using TinyFinder.Subforms.Profiles;

namespace TinyFinder.Subforms.Profile_Calibration
{
    public partial class Calibrator : Form
    {
        TinyMT tiny = new TinyMT();
        Calculate calc = new Calculate();
        Profile profile = new Profile();
        Editor editor;
        uint[] array = new uint[4];
        public Calibrator()
        {
            InitializeComponent();
            year.Value = DateTime.Now.Year;
        }

        private string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');

        private void IDCalibrate_Click(object sender, EventArgs e)
        {
            Calibrate(2);
        }

        private void NormalCalibrate_Click(object sender, EventArgs e)
        {
            Calibrate(1);
        }

        public void Calibrate(byte advances)
        {
            uint start_seed = calc.startingPoint((int)year.Value);
            array[3] = tiny3.Value;
            array[2] = tiny2.Value;
            array[1] = tiny1.Value;
            array[0] = tiny0.Value;
            for (uint c = start_seed; c < 0xFFFFFFFF; c++)
                if (tiny.init(c, advances)[3] == array[3])     //Comparing [3] and [2] should be enough
                    if (tiny.init(c, advances)[2] == array[2])
                    {
                        if (MessageBox.Show(
                            "Version = " + profile.name +
                            "   Year = " + year.Value +
                            "   Seed = " + hex(c) +
                            "\n\n           Create Profile from values?", 
                            "Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //editor = new Editor(xyRadio.Checked ? "XY" : "ORAS", (int)year.Value, c);
                            if (editor == null)
                                editor = new Editor(xyRadio.Checked ? "XY" : "ORAS", (int)year.Value, c);
                            editor.Show();
                            editor.Focus();
                        }

                        break;
                    }
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Set the Citra RTC to " + year.Value + "-01-01T13:00:00";
        }

        private void Calibrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
