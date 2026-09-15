using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TinyFinder.Subforms.Profile_Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            XmlTextReader reader = new XmlTextReader("./TinyFinderProfiles.xml");
            if (File.Exists("TinyFinderProfiles.xml"))
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader.Name);
                }
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
