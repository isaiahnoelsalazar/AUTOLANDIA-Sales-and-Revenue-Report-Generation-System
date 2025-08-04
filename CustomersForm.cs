using System;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            CustomerTable.Columns.Add("CustomerName", -2);
            CustomerTable.Columns.Add("PlateNumber", -2);
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
