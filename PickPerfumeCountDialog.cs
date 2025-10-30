using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class PickPerfumeCountDialog : MaterialForm
    {
        NewTransactionDialog NewTransactionDialog;

        public PickPerfumeCountDialog(NewTransactionDialog NewTransactionDialog)
        {
            InitializeComponent();

            this.NewTransactionDialog = NewTransactionDialog;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (Check.IsAllNumbers(TB_PC.Text))
            {
                try
                {
                    if (int.Parse(TB_PC.Text) > 0)
                    {
                        NewTransactionDialog.PickPerfumeCount(int.Parse(TB_PC.Text));
                        Close();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
                    }
                }
                catch
                {
                    MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
                }
            }
            else
            {
                MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
            }
        }

        private void PickPerfumeCountDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Check.IsAllNumbers(TB_PC.Text))
            {
                try
                {
                    if (int.Parse(TB_PC.Text) > 0)
                    {
                        NewTransactionDialog.PickPerfumeCount(int.Parse(TB_PC.Text));
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
                        e.Cancel = true;
                    }
                }
                catch
                {
                    MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
                    e.Cancel = true;
                }
            }
            else
            {
                MaterialMessageBox.Show("Please enter a valid amount.", "Alert");
                e.Cancel = true;
            }
        }
    }
}
