using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            CustomerTable.Columns.Add("CustomerName", -2);
            CustomerTable.Columns.Add("PlateNumbers", -2);

            RefreshCustomers();
        }

        public void RefreshCustomers()
        {
            new Do(() =>
            {
                RecreateCustomerList();
            })
            .AfterDo(() =>
            {
                CustomerTable.Items.Clear();
                foreach (CustomerItem Customer in CustomerList)
                {
                    CustomerTable.Items.Add(new ListViewItem(new string[] { Customer.Name, Customer.PlateNumbers }));
                }
                foreach (ColumnHeader ColumnHeader in CustomerTable.Columns)
                {
                    ColumnHeader.Width = -2;
                }
            });
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            new NewCustomerDialog(this).ShowDialog();
        }

        private void AssignCustomerButton_Click(object sender, EventArgs e)
        {
            new AssignCustomerVehicleDialog(this).ShowDialog();
        }

        private void UnassignCustomerButton_Click(object sender, EventArgs e)
        {
            new UnassignCustomerVehicleDialog(this).ShowDialog();
        }
    }
}
