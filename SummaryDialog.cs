using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SummaryDialog : MaterialForm
    {
        bool FirstDateSelected = false;
        DateTime FirstDate;

        public SummaryDialog()
        {
            InitializeComponent();

            SummaryText.Text = string.Empty;

            SummaryCalendar.MaxDate = DateTime.Now.Date;
            SummaryCalendar.MinDate = DateTime.Now.Date.AddMonths(-2);
        }

        private void SummaryDialog_Load(object sender, EventArgs e)
        {
            RefreshBilling(SummaryCalendar.MaxDate, SummaryCalendar.MaxDate);
        }

        void RefreshBilling(DateTime DateTimeStart, DateTime DateTimeEnd)
        {
            DateRange.Text = $"{DateTimeStart.Date} - {DateTimeEnd.Date}";

            TimeSpan DateRangeTimeSpan = DateTimeEnd - DateTimeStart;
            DateTime[] DateTimeRange = new DateTime[DateRangeTimeSpan.Days + 1];

            for (int a = 0; a < DateTimeRange.Length; a++)
            {
                if (DateTimeRange[DateTimeRange.Length - 1].CompareTo(DateTimeEnd) != 0)
                {
                    DateTimeRange[a] = DateTimeStart.AddDays(a);
                }
            }

            double TotalSales = 0;
            double TotalTransactions = 0;

            foreach (BillingItem Billing in GlobalBillingList)
            {
                if (DateTimeRange.Contains(DateTime.Parse(Billing.DateCreated).Date) && Billing.Progress.Equals("Paid"))
                {
                    TotalSales += Convert.ToDouble(Billing.Balance);
                    TotalTransactions++;
                }
            }

            SummaryText.Text = $"Total sales: {TotalSales}\nTotal transactions: {TotalTransactions}";
        }

        private void SummaryCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!FirstDateSelected)
            {
                SummaryText.Text = string.Empty;
                FirstDate = e.Start.Date;
                FirstDateSelected = true;
                DateRange.Text = $"{FirstDate.Date} - (Select end date)";
            }
            else
            {
                FirstDateSelected = false;
                DateRange.Text = $"{FirstDate.Date} - {e.Start.Date}";
                RefreshBilling(FirstDate, e.Start.Date);
            }
        }
    }
}
