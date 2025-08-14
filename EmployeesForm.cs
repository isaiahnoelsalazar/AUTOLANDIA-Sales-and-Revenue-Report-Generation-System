using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using System;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();

            //EmployeeTable.Columns.Add("EmployeeName", -2);
            //EmployeeTable.Columns.Add("TimeIn", -2);
            //EmployeeTable.Columns.Add("TimeOut", -2);
            //EmployeeTable.Columns.Add("DateRecorded", -2);

            pictureBox1.Image = Resources.sample_employee_form;
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
