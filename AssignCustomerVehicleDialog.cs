using MaterialSkin.Controls;
using System;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class AssignCustomerVehicleDialog : MaterialForm
    {
        CustomersForm CustomersForm;

        public AssignCustomerVehicleDialog(CustomersForm CustomersForm)
        {
            InitializeComponent();

            this.CustomersForm = CustomersForm;

            foreach (VehicleItem Vehicle in VehicleList)
            {
                if (Vehicle.CustomerName.Equals("(None)"))
                {
                    CB_Vehicles.Items.Add(Vehicle.PlateNumber + ", " + Vehicle.Brand + ", " + Vehicle.Model);
                }
            }
            foreach (CustomerItem Customer in CustomerList)
            {
                if (Customer.PlateNumbers.Equals("(None)"))
                {
                    CB_Customers.Items.Add(Customer.Name);
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CB_Customers.Text) && !string.IsNullOrEmpty(CB_Vehicles.Text))
            {
                try
                {
                    new Do(() =>
                    {
                        string Query = $"UPDATE AUTOLANDIA_CustomerList SET PlateNumbers='{CB_Vehicles.Text.Split(',')[0]}' WHERE CustomerName='{CB_Customers.Text}'";
                        string Query1 = $"UPDATE AUTOLANDIA_VehicleList SET CustomerName='{CB_Customers.Text}' WHERE PlateNumber='{CB_Vehicles.Text.Split(',')[0]}'";
                        NewQuery(Query);
                        NewQuery(Query1);
                    })
                    .AfterDo(() =>
                    {
                        MaterialMessageBox.Show("Successfully assigned customer to a vehicle!", "Notice");
                        CustomersForm.RefreshCustomers();
                        RecreateVehicleList();
                        Close();
                    });
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
                }
            }
            else
            {
                MaterialMessageBox.Show("Please select both a customer and a vehicle.", "Alert");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
