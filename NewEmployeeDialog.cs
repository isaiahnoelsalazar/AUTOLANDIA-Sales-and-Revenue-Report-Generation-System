using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewEmployeeDialog : MaterialForm
    {
        PeopleForm PeopleForm;

        public NewEmployeeDialog(PeopleForm PeopleForm)
        {
            InitializeComponent();

            this.PeopleForm = PeopleForm;
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

                    RecordActivity($"Added new employee: {Name} ({(string.IsNullOrEmpty(MobileNumber) ? "Mobile number not set" : MobileNumber)})");

                    SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_EmployeeList(EmployeeId, EmployeeName, MobileNumber) VALUES ('{GlobalEmployeeList.Count + 1}', '{Name}', '{(string.IsNullOrEmpty(MobileNumber) ? "(Mobile number not set)" : MobileNumber)}')", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully added new employee!", "Notice");
                    PeopleForm.RefreshEmployees();
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

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
