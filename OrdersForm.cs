using System;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            OrderTable.Columns.Add("EmployeeId", -2);
            OrderTable.Columns.Add("PlateNumber", -2);
            OrderTable.Columns.Add("ServiceIdList", -2);
            OrderTable.Columns.Add("PackageIdList", -2);
            OrderTable.Columns.Add("OrderBalance", -2);
            OrderTable.Columns.Add("PaymentMethodName", -2);
            OrderTable.Columns.Add("DateCreated", -2);
        }

        private void CreateNewOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
