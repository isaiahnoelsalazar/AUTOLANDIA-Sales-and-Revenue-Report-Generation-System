using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewEmployeeDialog : MaterialForm
    {
        EmployeesForm EmployeesForm;

        public NewEmployeeDialog(EmployeesForm EmployeesForm)
        {
            InitializeComponent();

            this.EmployeesForm = EmployeesForm;
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Name.Text) || Check.HasSymbols(TB_Name.Text))
            {
                ErrorMessage += "Employee name cannot contain numbers nor symbols." + Environment.NewLine;
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

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Added new employee: {Name}");

                    SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_EmployeeList(EmployeeName, TimeIn, TimeOut, DateRecorded) VALUES ('{Name}', '', '', '{DateTime.Now.Date.ToString("d")}')", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully added new employee!", "Notice");
                    EmployeesForm.RefreshEmployees();
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
