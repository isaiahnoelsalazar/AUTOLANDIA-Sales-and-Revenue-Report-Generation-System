using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditCustomerDialog : MaterialForm
    {
        PreviewCustomerDialog PreviewCustomerDialog;
        PeopleForm PeopleForm;
        string CustomerID, PreviousCustomerName, PreviousMobileNumber;

        public EditCustomerDialog(PreviewCustomerDialog PreviewCustomerDialog, string CustomerID, PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PreviewCustomerDialog = PreviewCustomerDialog;
            this.CustomerID = CustomerID;
            this.PeopleForm = PeopleForm;

            foreach (CustomerItem Customer in GlobalCustomerList)
            {
                if (Customer.ID.Equals(CustomerID))
                {
                    TB_Name.Text = Customer.Name;
                    PreviousCustomerName = Customer.Name;
                    if (!Customer.MobileNumber.Equals("(Mobile number not set)"))
                    {
                        TB_MobileNumber.Text = Customer.MobileNumber;
                        PreviousMobileNumber = Customer.MobileNumber;
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
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

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Updated customer from [{PreviousCustomerName} ({(string.IsNullOrEmpty(PreviousMobileNumber) ? "Mobile number not set" : PreviousMobileNumber)})] to [{Name} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : MobileNumber)})]");

                    SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_CustomerList SET CustomerName='{Name}', MobileNumber='{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}' WHERE CustomerId='{CustomerID}'", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully updated customer details!", "Notice");
                    PeopleForm.RefreshCustomers();
                    PreviewCustomerDialog.RefreshDetails();
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
                MaterialMessageBox.Show(ErrorMessage, "Alert");
            }
        }
    }
}
