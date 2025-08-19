using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            OrderTable.Columns.Add("OrderId", -2);
            OrderTable.Columns.Add("EmployeeName", -2);
            OrderTable.Columns.Add("PlateNumber", -2);
            OrderTable.Columns.Add("ServiceIdList", -2);
            OrderTable.Columns.Add("PackageIdList", -2);
            OrderTable.Columns.Add("OrderBalance", -2);
            OrderTable.Columns.Add("PaymentMethodName", -2);
            OrderTable.Columns.Add("DateCreated", -2);
        }

        public void RefreshOrders()
        {
            RecreateOrderList();

            OrderTable.Items.Clear();

            foreach (OrderItem Order in OrderList)
            {
                OrderTable.Items.Add(new ListViewItem(new string[] { Order.OrderId, Order.EmployeeName, Order.PlateNumber, Order.ServiceIdList, Order.PackageIdList, Order.OrderBalance.ToString(), Order.PaymentMethodName, Order.DateCreated }));
            }
            foreach (ColumnHeader ColumnHeader in OrderTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }

        private void CreateNewOrderButton_Click(object sender, EventArgs e)
        {
            new NewOrderDialog(this).ShowDialog();
        }
    }
}
