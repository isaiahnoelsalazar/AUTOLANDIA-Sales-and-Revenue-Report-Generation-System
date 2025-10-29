using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

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
            new MainForm(this).ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
