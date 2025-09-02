using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ViewWeeklySalesDialog : MaterialForm
    {
        public ViewWeeklySalesDialog()
        {
            InitializeComponent();

            WeeklySalesTable.Columns.Add("Title", -2);
            WeeklySalesTable.Columns.Add("Value", -2);

            DateTime Today = DateTime.Now;
            DateTime[] Days = new DateTime[7];

            DateTime StartOfWeek = Today.AddDays(-(int)Today.DayOfWeek);

            for (int a = 0; a < 7; a++)
            {
                Days[a] = StartOfWeek.AddDays(a).Date;
            }

            double TotalWeeklySales = 0;
            int TotalOrders = 0;

            foreach (OrderItem Order in OrderList)
            {
                if (Days.Contains(DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("d"))))
                {
                    TotalWeeklySales += Order.OrderBalance;
                    TotalOrders++;
                }
            }

            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "This Week's Total Sales", TotalWeeklySales.ToString() }));
            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "This Week's Total Orders", TotalOrders.ToString() }));
            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "", "" }));
            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "Sales", "" }));

            foreach (DateTime Day in Days)
            {
                double DaySale = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Day == DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("d")))
                    {
                        DaySale += Order.OrderBalance;
                    }
                }

                WeeklySalesTable.Items.Add(new ListViewItem(new string[] { Day.ToString("d"), DaySale.ToString() }));
            }

            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "", "" }));
            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "Orders", "" }));

            foreach (DateTime Day in Days)
            {
                int DayOrders = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Day == DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("d")))
                    {
                        DayOrders++;
                    }
                }

                WeeklySalesTable.Items.Add(new ListViewItem(new string[] { Day.ToString("d"), DayOrders.ToString() }));
            }

            foreach (ColumnHeader ColumnHeader in WeeklySalesTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }
    }
}
