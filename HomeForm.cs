using System;
using System.Threading;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class HomeForm : Form
    {
        string Time = string.Empty;

        public HomeForm()
        {
            InitializeComponent();

            new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    int Hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
                    Time = Hour >= 12 ? (Hour - 12) < 6 ? "afternoon" : "evening" : Hour < 4 ? "evening" : "morning";
                    try
                    {
                        GreetingLabel.BeginInvoke((MethodInvoker)delegate ()
                        {
                            GreetingLabel.Text = $"Good {Time}! Here is your summary:";
                        });
                    }
                    catch
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                }
            })).Start();
        }
    }
}
