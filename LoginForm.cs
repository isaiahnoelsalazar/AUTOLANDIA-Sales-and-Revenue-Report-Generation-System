using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm(Startup Startup)
        {
            InitializeComponent();

            Startup.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < GlobalAccountList.Count; a++)
            {
                if (GlobalAccountList[a].Username.Equals(TB_Username.Text))
                {
                    if (GlobalAccountList[a].Password.Equals(TB_Password.Text))
                    {
                        TB_Username.Text = string.Empty;
                        TB_Password.Text = string.Empty;
                        LoggedAccount = GlobalAccountList[a];
                        new MainForm(this).ShowDialog();
                    }
                    else
                    {
                        AlertMessageBox("Incorrect password.");
                    }
                }
                else
                {
                    AlertMessageBox("Account not found.");
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
