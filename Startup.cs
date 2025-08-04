using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class Startup : MaterialForm
    {
        Timer Timer = new Timer();

        public Startup()
        {
            InitializeComponent();

            SET_SKIN(this);

            Timer.Interval = 1000;
            Timer.Tick += (s, e) =>
            {
                try
                {
                    Timer.Stop();
                    new MainForm(this).Show();
                }
                catch (Exception exception)
                {
                    Timer.Stop();
                    MaterialMessageBox.Show(exception.Message, "Alert");
                    Application.Exit();
                }
            };
            Timer.Start();
        }
    }
}
