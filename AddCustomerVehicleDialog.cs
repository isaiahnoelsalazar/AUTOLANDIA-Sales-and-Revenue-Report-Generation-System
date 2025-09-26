using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class AddCustomerVehicleDialog : MaterialForm
    {
        PreviewCustomerDialog PreviewCustomerDialog;
        NewCustomerDialog NewCustomerDialog;
        PeopleForm PeopleForm;
        string CustomerID;

        public AddCustomerVehicleDialog(PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PeopleForm = PeopleForm;
        }

        public AddCustomerVehicleDialog(NewCustomerDialog NewCustomerDialog, PeopleForm PeopleForm, string CustomerID)
        {
            InitializeComponent();

            this.NewCustomerDialog = NewCustomerDialog;
            this.CustomerID = CustomerID;
            this.PeopleForm = PeopleForm;
        }

        public AddCustomerVehicleDialog(PreviewCustomerDialog PreviewCustomerDialog, string CustomerID, PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PreviewCustomerDialog = PreviewCustomerDialog;
            this.CustomerID = CustomerID;
            this.PeopleForm = PeopleForm;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Brand.Text) || Check.HasSymbols(TB_Brand.Text))
            {
                ErrorMessage += "Brand cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (Check.HasNumbers(TB_Model.Text) || Check.HasSymbols(TB_Model.Text))
            {
                ErrorMessage += "Model cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (GetSize().Equals(""))
            {
                ErrorMessage += "Please select a vehicle size." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_PlateNumber.Text))
            {
                ErrorMessage += "Please enter the vehicle's plate number." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string Brand = TB_Brand.Text.ToUpper();
                    string Model = TB_Model.Text.ToUpper();
                    string Size = GetSize().ToUpper();
                    string PlateNumber = TB_PlateNumber.Text.ToUpper();
                    string VehicleID = (GlobalVehicleList.Count + 1).ToString();

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    string CustomerName = string.Empty;
                    string CustomerPlateNumbers = string.Empty;
                    string FinalCustomerPlateNumbers = "";

                    if (!string.IsNullOrEmpty(CustomerID))
                    {
                        foreach (CustomerItem Customer in GlobalCustomerList)
                        {
                            if (Customer.ID.Equals(CustomerID))
                            {
                                CustomerName = $"{Customer.LastName}, {Customer.FirstName} {Customer.MiddleName}";
                                CustomerPlateNumbers = Customer.PlateNumbers;
                            }
                        }

                        if (CustomerPlateNumbers.Equals("(None)"))
                        {
                            CustomerPlateNumbers = "[]";
                        }
                        string[] Split = CustomerPlateNumbers.Substring(1, CustomerPlateNumbers.Length - 2).Split(',');
                        FinalCustomerPlateNumbers = "[";
                        foreach (string Plate in Split)
                        {
                            if (!string.IsNullOrEmpty(Plate))
                            {
                                FinalCustomerPlateNumbers += Plate + ",";
                            }
                        }
                        FinalCustomerPlateNumbers += PlateNumber + "]";
                    }

                    RecordActivity($"Added new vehicle{(string.IsNullOrEmpty(CustomerID) ? "" : " for [Customer ID " + CustomerID)}{(string.IsNullOrEmpty(CustomerName) ? "" : ": " + CustomerName + "]")} - [{Brand}, {Model}, {Size}, {PlateNumber}]");

                    SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_VehicleList(VehicleId, VehicleBrand, VehicleModel, VehicleSize, PlateNumber, CustomerId) VALUES ('{VehicleID}', '{Brand}', '{Model}', '{Size}', '{PlateNumber}', '{(string.IsNullOrEmpty(CustomerID) ? "(None)" : CustomerID)}')", SQL);

                    Command.ExecuteNonQuery();

                    if (!string.IsNullOrEmpty(CustomerID))
                    {
                        SqlCommand Command1 = new SqlCommand($"UPDATE AUTOLANDIA_CustomerList SET PlateNumbers='{FinalCustomerPlateNumbers}' WHERE CustomerId='{CustomerID}'", SQL);

                        Command1.ExecuteNonQuery();
                    }

                    MaterialMessageBox.Show($"Successfully added new vehicle{(string.IsNullOrEmpty(CustomerID) ? "" : " for [Customer ID " + CustomerID)}{(string.IsNullOrEmpty(CustomerName) ? "" : ": " + CustomerName + "]")}!", "Notice");
                    PeopleForm.RefreshCustomers();
                    PeopleForm.RefreshVehicles();
                    if (PreviewCustomerDialog != null)
                    {
                        PreviewCustomerDialog.RefreshDetails();
                    }
                    GlobalActivityRecordForm.RefreshActivities();

                    if (NewCustomerDialog != null)
                    {
                        DialogResult NewDialogResult = MaterialMessageBox.Show("Add a new order?", "Notice", MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Right);
                        if (NewDialogResult == DialogResult.Yes)
                        {
                            new NewTransactionDialog(this, NewCustomerDialog, VehicleID).ShowDialog();
                        }
                        else
                        {
                            NewCustomerDialog.Close();
                            Close();
                        }
                    }
                    else
                    {
                        Close();
                    }
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
                MaterialMessageBox.Show(ErrorMessage, "Alert");
            }
        }

        string GetSize()
        {
            RadioButton[] RadioButtons = { RB_S, RB_M, RB_L, RB_XL, RB_XXL };
            foreach (RadioButton RadioButton in RadioButtons)
            {
                if (RadioButton.Checked)
                {
                    return RadioButton.Text;
                }
            }
            return "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (NewCustomerDialog != null)
            {
                NewCustomerDialog.Close();
            }
            Close();
        }
        private void PickVehicleBrandButton_Click(object sender, EventArgs e)
        {

        }

        private void PickVehicleModelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
