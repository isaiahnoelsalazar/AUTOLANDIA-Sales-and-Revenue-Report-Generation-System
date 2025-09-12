using System;
using System.Threading;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class HomeForm : Form
    {
        Thread TimeThread;
        string Time = string.Empty;

        public HomeForm()
        {
            InitializeComponent();

            TimeThread = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    int Hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
                    Time = Hour >= 12 ? (Hour - 12) < 6 ? "afternoon" : "evening" : Hour < 4 ? "evening" : "morning";
                    try
                    {
                        GreetingLabel.BeginInvoke((MethodInvoker)delegate ()
                        {
                            GreetingLabel.Text = $"Good {Time}!";
                        });
                    }
                    catch
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                }
            }));
            TimeThread.Start();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeThread.Abort();
        }
    }
}
