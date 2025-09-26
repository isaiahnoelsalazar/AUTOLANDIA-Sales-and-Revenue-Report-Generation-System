using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditEmployeeDialog : MaterialForm
    {
        PreviewEmployeeDialog PreviewEmployeeDialog;
        PeopleForm PeopleForm;
        string EmployeeID, PreviousEmployeeFirstName, PreviousEmployeeMiddleName, PreviousEmployeeLastName, PreviousAddress, PreviousMobileNumber;

        public EditEmployeeDialog(PreviewEmployeeDialog PreviewEmployeeDialog, string EmployeeID, PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PreviewEmployeeDialog = PreviewEmployeeDialog;
            this.EmployeeID = EmployeeID;
            this.PeopleForm = PeopleForm;

            foreach (EmployeeItem Employee in GlobalEmployeeList)
            {
                if (Employee.ID.Equals(EmployeeID))
                {
                    TB_FName.Text = Employee.FirstName;
                    TB_MName.Text = Employee.MiddleName;
                    TB_LName.Text = Employee.LastName;
                    PreviousEmployeeFirstName = Employee.FirstName;
                    PreviousEmployeeMiddleName = Employee.MiddleName;
                    PreviousEmployeeLastName = Employee.LastName;
                    if (!Employee.MobileNumber.Equals("(Mobile number not set)"))
                    {
                        TB_MobileNumber.Text = Employee.MobileNumber;
                        PreviousMobileNumber = Employee.MobileNumber;
                    }
                    if (!Employee.Address.Equals("(Address not set)"))
                    {
                        TB_Address.Text = Employee.Address;
                        PreviousAddress = Employee.Address;
                    }
                }
            }
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
                ErrorMessage += "Please enter the employee's first name." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_LName.Text))
            {
                ErrorMessage += "Please enter the employee's last name." + Environment.NewLine;
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

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Updated employee details from [{PreviousEmployeeLastName + ", " + PreviousEmployeeFirstName + " " + PreviousEmployeeMiddleName} ({(string.IsNullOrEmpty(PreviousMobileNumber) ? "Mobile number not set" : "Mobile number set and hidden")} | {(string.IsNullOrEmpty(PreviousAddress) ? "Address not set" : "Address set and hidden")})] to [{LName + ", " + FName + " " + MName} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : "Mobile number set and hidden")} | {(string.IsNullOrEmpty(Address) ? "Address not set" : "Address set and hidden")})]");

                    SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET FirstName='{FName}', MiddleName='{MName}', LastName='{LName}', MobileNumber='{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}', EmployeeAddress='{(string.IsNullOrEmpty(Address) ? "(Address not set)" : Address)}' WHERE EmployeeId='{EmployeeID}'", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully updated employee details!", "Notice");
                    PeopleForm.RefreshEmployees();
                    PreviewEmployeeDialog.RefreshDetails();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
