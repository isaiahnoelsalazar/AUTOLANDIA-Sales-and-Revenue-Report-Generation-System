using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
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
                CB_Customers.Items.Add(Customer.Name);
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CB_Customers.Text) && !string.IsNullOrEmpty(CB_Vehicles.Text))
            {
                try
                {
                    string PlateNumber = CB_Vehicles.Text.Split(',')[0];
                    string CustomerName = CB_Customers.Text;
                    string CustomerPlateNumbers = CustomerList[CB_Customers.Items.IndexOf(CB_Customers.Text)].PlateNumbers;
                    if (CustomerPlateNumbers.Equals("(None)"))
                    {
                        CustomerPlateNumbers = "[]";
                    }
                    string[] Split = CustomerPlateNumbers.Substring(1, CustomerPlateNumbers.Length - 2).Split(',');
                    string FinalCustomerPlateNumbers = "";
                    FinalCustomerPlateNumbers = "[";
                    foreach (string Plate in Split)
                    {
                        if (!string.IsNullOrEmpty(Plate))
                        {
                            FinalCustomerPlateNumbers += Plate + ",";
                        }
                    }
                    FinalCustomerPlateNumbers += PlateNumber + "]";

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    //RecordActivity($"Assigned customer \"{CustomerName}\" to vehicle \"{PlateNumber}\"", () =>
                    //{
                    //    new Do(() =>
                    //    {
                    //        string Query = $"UPDATE AUTOLANDIA_CustomerList SET PlateNumbers='{FinalCustomerPlateNumbers}' WHERE CustomerName='{CustomerName}'";
                    //        string Query1 = $"UPDATE AUTOLANDIA_VehicleList SET CustomerName='{CustomerName}' WHERE PlateNumber='{PlateNumber}'";
                    //        NewQuery(Query);
                    //        NewQuery(Query1);
                    //    })
                    //    .AfterDo(() =>
                    //    {
                    //        MaterialMessageBox.Show("Successfully assigned customer to a vehicle!", "Notice");
                    //        CustomersForm.RefreshCustomers();
                    //        GlobalVehiclesForm.RefreshVehicles();
                    //        GlobalActivityRecordForm.RefreshActivities();
                    //        Close();
                    //    });
                    //});

                    RecordActivity($"Assigned customer \"{CustomerName}\" to vehicle \"{PlateNumber}\"");

                    SqlCommand Command1 = new SqlCommand($"UPDATE AUTOLANDIA_CustomerList SET PlateNumbers='{FinalCustomerPlateNumbers}' WHERE CONVERT(VARCHAR, CustomerName)='{CustomerName}'", SQL);
                    SqlCommand Command2 = new SqlCommand($"UPDATE AUTOLANDIA_VehicleList SET CustomerName='{CustomerName}' WHERE CONVERT(VARCHAR, PlateNumber)='{PlateNumber}'", SQL);

                    Command1.ExecuteNonQuery();
                    Command2.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully assigned customer to a vehicle!", "Notice");
                    CustomersForm.RefreshCustomers();
                    GlobalVehiclesForm.RefreshVehicles();
                    GlobalActivityRecordForm.RefreshActivities();
                    Close();
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
                    DoneButton.Enabled = true;
                    CancelButton.Enabled = true;
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
