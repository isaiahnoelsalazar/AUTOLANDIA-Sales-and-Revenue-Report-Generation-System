using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class CustomersForm : Form
    {
        int LastClickedColumn = 0;
        bool Reverse = false;

        public CustomersForm()
        {
            InitializeComponent();

            CustomerTable.Columns.Add("CustomerName", -2);
            CustomerTable.Columns.Add("PlateNumbers", -2);

            CustomerTable.ColumnClick += (s, e) =>
            {
                List<CustomerItem> Temp = new List<CustomerItem>(CustomerList);
                Temp.Sort(new CustomerItemComparer(e.Column));

                if (LastClickedColumn == e.Column)
                {
                    if (!Reverse)
                    {
                        Temp.Reverse();
                        Reverse = true;
                    }
                    else
                    {
                        Reverse = false;
                    }
                }
                else
                {
                    LastClickedColumn = e.Column;
                    Reverse = false;
                }

                CustomerTable.Items.Clear();
                foreach (CustomerItem Customer in Temp)
                {
                    CustomerTable.Items.Add(new ListViewItem(new string[] { Customer.Name, Customer.PlateNumbers }));
                }
                foreach (ColumnHeader ColumnHeader in CustomerTable.Columns)
                {
                    ColumnHeader.Width = -2;
                }
            };

            RefreshCustomers();
        }

        public void RefreshCustomers()
        {
            RecreateCustomerList();

            List<CustomerItem> Temp = new List<CustomerItem>(CustomerList);
            Temp.Sort(new CustomerItemComparer(LastClickedColumn));

            CustomerTable.Items.Clear();
            foreach (CustomerItem Customer in Temp)
            {
                CustomerTable.Items.Add(new ListViewItem(new string[] { Customer.Name, Customer.PlateNumbers }));
            }
            foreach (ColumnHeader ColumnHeader in CustomerTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
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

        private void EditTableValuesButton_Click(object sender, EventArgs e)
        {
            new EditCustomersDataForm(this).ShowDialog();
        }
    }
}
