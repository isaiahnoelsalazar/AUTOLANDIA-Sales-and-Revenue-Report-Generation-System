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

            WeeklySalesTable.Columns.Add("", -2);
            WeeklySalesTable.Columns.Add("", -2);

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

            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "Total Weekly Sales", TotalWeeklySales.ToString() }));
            WeeklySalesTable.Items.Add(new ListViewItem(new string[] { "Total Orders", TotalOrders.ToString() }));

            foreach (ColumnHeader ColumnHeader in WeeklySalesTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }
    }
}
