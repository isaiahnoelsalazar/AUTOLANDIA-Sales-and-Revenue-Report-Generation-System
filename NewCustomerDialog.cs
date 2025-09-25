using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewCustomerDialog : MaterialForm
    {
        PeopleForm PeopleForm;

        public NewCustomerDialog(PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PeopleForm = PeopleForm;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Name.Text) || Check.HasSymbols(TB_Name.Text))
            {
                ErrorMessage += "Customer name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (!Check.IsAValidPhilippineMobileNumber(TB_MobileNumber.Text) && !string.IsNullOrEmpty(TB_MobileNumber.Text))
            {
                ErrorMessage += "Mobile number is not valid. Use the prefixes \"09\", \"+639\", or \"639\"." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_Name.Text))
            {
                ErrorMessage += "Please enter the customer's name." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string Name = TB_Name.Text.ToUpper();
                    string MobileNumber = TB_MobileNumber.Text.ToUpper();
                    string CustomerID = (GlobalCustomerList.Count + 1).ToString();

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Added new customer: {Name} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : MobileNumber)})");

                    SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_CustomerList(CustomerId, CustomerName, PlateNumbers, MobileNumber) VALUES ('{CustomerID}', '{Name}', '(None)', '{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}')", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully added new customer!", "Notice");
                    PeopleForm.RefreshCustomers();
                    GlobalActivityRecordForm.RefreshActivities();

                    DialogResult NewDialogResult = MaterialMessageBox.Show("Add a new vehicle?", "Notice", MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Right);
                    if (NewDialogResult == DialogResult.Yes)
                    {
                        new AddCustomerVehicleDialog(this, PeopleForm, CustomerID).ShowDialog();
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
