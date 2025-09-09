using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ViewMonthlySalesDialog : MaterialForm
    {
        public ViewMonthlySalesDialog()
        {
            InitializeComponent();

            MonthlySalesTable.Columns.Add("Title", -2);
            MonthlySalesTable.Columns.Add("Value", -2);

            DateTime Today = DateTime.Now;
            DateTime[] Months = new DateTime[12];

            DateTime StartOfYear = DateTime.Parse(Today.AddMonths(-Today.Month + 1).ToString("Y"));

            for (int a = 0; a < 12; a++)
            {
                Months[a] = StartOfYear.AddMonths(a);
            }

            double ThisMonthSales = 0;
            int ThisMonthOrders = 0;

            foreach (OrderItem Order in OrderList)
            {
                if (Today.ToString("Y").Equals(DateTime.Parse(Order.DateCreated).Date.ToString("Y")))
                {
                    ThisMonthSales += Order.OrderBalance;
                    ThisMonthOrders++;
                }
            }

            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "This Month's Total Sales", ThisMonthSales.ToString() }));
            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "This Month's Total Orders", ThisMonthOrders.ToString() }));
            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "", "" }));
            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "Sales", "" }));

            foreach (DateTime Month in Months)
            {
                double TotalMonthlySales = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Month == DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("Y")))
                    {
                        TotalMonthlySales += Order.OrderBalance;
                    }
                }

                MonthlySalesTable.Items.Add(new ListViewItem(new string[] { Month.ToString("Y"), TotalMonthlySales.ToString() }));
            }

            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "", "" }));
            MonthlySalesTable.Items.Add(new ListViewItem(new string[] { "Orders", "" }));

            foreach (DateTime Month in Months)
            {
                int TotalOrders = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Month == DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("Y")))
                    {
                        TotalOrders++;
                    }
                }

                MonthlySalesTable.Items.Add(new ListViewItem(new string[] { Month.ToString("Y"), TotalOrders.ToString() }));
            }

            foreach (ColumnHeader ColumnHeader in MonthlySalesTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }
    }
}
