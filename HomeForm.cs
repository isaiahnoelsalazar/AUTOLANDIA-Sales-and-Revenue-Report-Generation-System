using System;
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

            WeeklySalesChart.Titles.Add("Weekly Sales");
            Series DailySales = WeeklySalesChart.Series.Add("Daily Sales");
            DailySales.ChartType = SeriesChartType.Line;

            DateTime Today = DateTime.Now;
            DateTime[] Days = new DateTime[7];

            DateTime StartOfWeek = Today.AddDays(-(int)Today.DayOfWeek);
            for (int a = 0; a < 7; a++)
            {
                Days[a] = StartOfWeek.AddDays(a);
                DailySales.Points.AddXY(Days[a].ToString("D"), 0);
            }

            for (int a = 0; a < Days.Length; a++)
            {
                double TotalSales = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Days[a].ToString("d").Equals(DateTime.Parse(Order.DateCreated).ToString("d")))
                    {
                        TotalSales += Convert.ToDouble(Order.OrderBalance);
                    }
                }

                DailySales.Points[a].SetValueY(TotalSales);
            }
        }
    }
}
