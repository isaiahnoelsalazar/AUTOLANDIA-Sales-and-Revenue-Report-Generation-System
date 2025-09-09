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
        string EmployeeID, PreviousEmployeeName, PreviousMobileNumber;

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
                    TB_Name.Text = Employee.Name;
                    TB_MobileNumber.Text = Employee.MobileNumber;
                    PreviousEmployeeName = Employee.Name;
                    PreviousMobileNumber = Employee.MobileNumber;
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Name.Text) || Check.HasSymbols(TB_Name.Text))
            {
                ErrorMessage += "Employee name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (!Check.IsAValidPhilippineMobileNumber(TB_MobileNumber.Text) && !string.IsNullOrEmpty(TB_MobileNumber.Text))
            {
                ErrorMessage += "Mobile number is not valid. Use the prefixes \"09\", \"+639\", or \"639\"." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_Name.Text))
            {
                ErrorMessage += "Please enter the employee's name." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string Name = TB_Name.Text.ToUpper();
                    string MobileNumber = TB_MobileNumber.Text.ToUpper();

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Updated employee details from [{PreviousEmployeeName} ({(string.IsNullOrEmpty(PreviousMobileNumber) ? "Mobile number not set" : PreviousMobileNumber)})] to [{Name} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : MobileNumber)})]");

                    SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET EmployeeName='{Name}', MobileNumber='{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}' WHERE EmployeeId='{EmployeeID}'", SQL);

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
