using CSSimpleFunctions;
using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewCustomerDialog : MaterialForm
    {
        public NewCustomerDialog()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_FName.Text) || Check.HasSymbols(TB_FName.Text))
            {
                ErrorMessage += "First name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (Check.HasNumbers(TB_MName.Text) || Check.HasSymbols(TB_MName.Text))
            {
                ErrorMessage += "Middle name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (Check.HasNumbers(TB_LName.Text) || Check.HasSymbols(TB_LName.Text))
            {
                ErrorMessage += "Last name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (!Check.IsAValidPhilippineMobileNumber(TB_MobileNumber.Text) && !string.IsNullOrEmpty(TB_MobileNumber.Text))
            {
                ErrorMessage += "Mobile number is not valid. Use the prefixes \"09\", \"+639\", or \"639\"." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_FName.Text))
            {
                ErrorMessage += "Please enter the customer's first name." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_LName.Text))
            {
                ErrorMessage += "Please enter the customer's last name." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string FName = TB_FName.Text.ToUpper();
                    string MName = TB_MName.Text.ToUpper();
                    string LName = TB_LName.Text.ToUpper();
                    string Address = TB_Address.Text.ToUpper();
                    string MobileNumber = TB_MobileNumber.Text.ToUpper();
                    string CustomerID = (GlobalCustomerList.Count + 1).ToString();

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Added new customer: {LName}, {FName}{(!string.IsNullOrEmpty(MName) ? $" {MName}" : string.Empty)} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : "Mobile number set and hidden")} | {(string.IsNullOrEmpty(Address) ? "Address not set" : "Address set and hidden")})");

                    SqliteCommand Command = new SqliteCommand($"INSERT INTO AUTOLANDIA_CustomerList(CustomerId, FirstName, PlateNumbers, MobileNumber, CustomerAddress, LastName, MiddleName) VALUES ('{CustomerID}', '{FName}', '(None)', '{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}', '{(string.IsNullOrEmpty(Address) ? "(Address not set)" : Address)}', '{LName}', '{MName}')", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully added new customer!", "Notice");
                    GlobalPeopleForm.RefreshCustomers();
                    GlobalActivityRecordForm.RefreshActivities();

                    DialogResult NewDialogResult = MaterialMessageBox.Show("Add a new vehicle?", "Notice", MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Right);
                    if (NewDialogResult == DialogResult.Yes)
                    {
                        new AddCustomerVehicleDialog(this, CustomerID).ShowDialog();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
