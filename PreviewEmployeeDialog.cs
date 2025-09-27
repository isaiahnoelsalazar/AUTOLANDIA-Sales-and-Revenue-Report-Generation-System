using MaterialSkin.Controls;
using System;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class PreviewEmployeeDialog : MaterialForm
    {
        PeopleForm PeopleForm;
        string EmployeeID;

        public PreviewEmployeeDialog(PeopleForm PeopleForm, string EmployeeID)
        {
            InitializeComponent();

            this.PeopleForm = PeopleForm;
            this.EmployeeID = EmployeeID;

            RefreshDetails();
        }

        public void RefreshDetails()
        {
            foreach (EmployeeItem Employee in GlobalEmployeeList)
            {
                if (Employee.ID.Equals(EmployeeID))
                {
                    EmployeeNameLabel.Text = $"{Employee.LastName}, {Employee.FirstName} {Employee.MiddleName}";
                    EmployeeMobileNumberLabel.Text = Employee.MobileNumber;
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new EditEmployeeDialog(this, EmployeeID).ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
