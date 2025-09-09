using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class OrdersForm : Form
    {
        int LastClickedColumn = 0;
        bool Reverse = false;

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

            //OrderTable.ColumnClick += (s, e) =>
            //{
            //    List<OrderItem> Temp = new List<OrderItem>(OrderList);
            //    Temp.Sort(new OrderItemComparer(e.Column));

            //    if (LastClickedColumn == e.Column)
            //    {
            //        if (!Reverse)
            //        {
            //            Temp.Reverse();
            //            Reverse = true;
            //        }
            //        else
            //        {
            //            Reverse = false;
            //        }
            //    }
            //    else
            //    {
            //        LastClickedColumn = e.Column;
            //        Reverse = false;
            //    }

            //    OrderTable.Items.Clear();
            //    foreach (OrderItem Order in Temp)
            //    {
            //        //OrderTable.Items.Add(new ListViewItem(new string[] { Order.OrderId, Order.EmployeeName, Order.PlateNumber, Order.ServiceIdList, Order.PackageIdList, Order.OrderBalance.ToString(), Order.PaymentMethodName, Order.DateCreated }));
            //    }
            //    foreach (ColumnHeader ColumnHeader in OrderTable.Columns)
            //    {
            //        ColumnHeader.Width = -2;
            //    }
            //};

            //RefreshOrders();
        }

        public void RefreshOrders()
        {
            //RecreateOrderList();

            //List<OrderItem> Temp = new List<OrderItem>(OrderList);
            //Temp.Sort(new OrderItemComparer(LastClickedColumn));

            //OrderTable.Items.Clear();
            //foreach (OrderItem Order in Temp)
            //{
            //    //OrderTable.Items.Add(new ListViewItem(new string[] { Order.OrderId, Order.EmployeeName, Order.PlateNumber, Order.ServiceIdList, Order.PackageIdList, Order.OrderBalance.ToString(), Order.PaymentMethodName, Order.DateCreated }));
            //}
            //foreach (ColumnHeader ColumnHeader in OrderTable.Columns)
            //{
            //    ColumnHeader.Width = -2;
            //}
        }

        private void CreateNewOrderButton_Click(object sender, EventArgs e)
        {
            new NewOrderDialog(this).ShowDialog();
        }

        private void EditTableValuesButton_Click(object sender, EventArgs e)
        {
            new EditOrdersDataForm(this).ShowDialog();
        }
    }
}
