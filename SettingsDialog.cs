using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SettingsDialog : MaterialForm
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    File.Copy("AUTOLANDIA.db", Path.Combine(FBD.SelectedPath, "AUTOLANDIA.autlndia"));
                }
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "AUTOLANDIA Database Backup File (*.autlndia)|*.autlndia";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(OFD.FileName, "AUTOLANDIA.db", true);
                    Application.Restart();
                }
            }
        }
    }
}
