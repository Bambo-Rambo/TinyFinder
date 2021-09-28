using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace TinyFinder.Subforms.Profiles
{
    public partial class Editor : Form
    {
        Profile profile = new Profile();
        public Editor(string Ver, int Year, uint Seed)
        {
            InitializeComponent();
            if (Ver == "XY")
                XY_Button.Checked = true;
            else
                ORAS_Button.Checked = true;
            YearEditor.Value = Year;
            SeedEditor.Value = Seed;
            GetValues(Ver, Year, Seed);
        }

        public void GetValues(string Ver, int Year, uint Seed)
        {
            profile.name = name.Text;
            profile.version = Ver;
            profile.year = Year;
            profile.seed = Seed;
        }

        private void save_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Profile>));
            TextWriter writer = new StreamWriter("Profiles.xml");
            serializer.Serialize(writer, profile);
            writer.Close();
        }
    }
}
