using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            RefreshHome();
        }

        public void RefreshHome()
        {
            WeeklySalesChart.Titles.Clear();
            WeeklySalesChart.Series.Clear();
            MonthlySalesChart.Titles.Clear();
            MonthlySalesChart.Series.Clear();

            WeeklySalesChart.Titles.Add("Weekly Sales");
            Series DailySales = WeeklySalesChart.Series.Add("Daily Sales");
            DailySales.ChartType = SeriesChartType.Line;
            DailySales.Color = Color.Red;

            MonthlySalesChart.Titles.Add("Monthly Sales");
            Series MonthlySales = MonthlySalesChart.Series.Add("Monthly Sales");
            MonthlySales.ChartType = SeriesChartType.Line;
            MonthlySales.Color = Color.Red;
            MonthlySalesChart.ChartAreas[0].AxisX.Interval = 1;

            DateTime Today = DateTime.Now;
            DateTime[] Days = new DateTime[7];
            DateTime[] Months = new DateTime[12];

            DateTime StartOfWeek = Today.AddDays(-(int)Today.DayOfWeek);
            DateTime StartOfYear = DateTime.Parse(Today.AddMonths(-Today.Month + 1).ToString("Y"));

            for (int a = 0; a < 7; a++)
            {
                Days[a] = StartOfWeek.AddDays(a);
                DailySales.Points.AddXY(Days[a].ToString("D"), 0);
            }
            for (int a = 0; a < 12; a++)
            {
                Months[a] = StartOfYear.AddMonths(a);
                MonthlySales.Points.AddXY(Months[a].ToString("MMMM"), 0);
            }

            for (int a = 0; a < Days.Length; a++)
            {
                double TotalSales = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (DateTime.Parse(Order.DateCreated).ToString("d").Equals(Days[a].ToString("d")))
                    {
                        TotalSales += Convert.ToDouble(Order.OrderBalance);
                    }
                }

                DailySales.Points[a].SetValueY(TotalSales);
            }
            for (int a = 0; a < Months.Length; a++)
            {
                double TotalSales = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (DateTime.Parse(Order.DateCreated).ToString("Y").Equals(Months[a].ToString("Y")))
                    {
                        TotalSales += Convert.ToDouble(Order.OrderBalance);
                    }
                }

                MonthlySales.Points[a].SetValueY(TotalSales);
            }
        }

        private void ViewWeeklySalesButton_Click(object sender, EventArgs e)
        {
            new ViewWeeklySalesDialog().ShowDialog();
        }

        private void ViewMonthlySalesButton_Click(object sender, EventArgs e)
        {
            new ViewMonthlySalesDialog().ShowDialog();
        }
    }
}
