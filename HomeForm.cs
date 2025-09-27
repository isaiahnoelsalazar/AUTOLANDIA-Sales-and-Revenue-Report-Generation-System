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

        private void QuickReports_Click(object sender, EventArgs e)
        {

        }

        private void QuickCustomer_Click(object sender, EventArgs e)
        {
            new NewCustomerDialog().ShowDialog();
        }

        private void QuickVehicle_Click(object sender, EventArgs e)
        {
            new AddCustomerVehicleDialog().ShowDialog();
        }

        private void QuickOrder_Click(object sender, EventArgs e)
        {
            new NewTransactionDialog().ShowDialog();
        }

        private void QuickSalary_Click(object sender, EventArgs e)
        {
            new EmployeeSalariesDialog().ShowDialog();
        }

        private void QuickTimeSchedule_Click(object sender, EventArgs e)
        {
            new EmployeeScheduleDialog().ShowDialog();
        }
    }
}
