using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SalaryCalculationDialog : MaterialForm
    {
        public SalaryCalculationDialog()
        {
            InitializeComponent();

            SalaryCalculationTable.Columns.Add("EmployeeName", -2);
            SalaryCalculationTable.Columns.Add("EmployeeSalary", -2);

            SalaryCalculationTable.Items.Clear();

            foreach (EmployeeItem Employee in EmployeeList)
            {
                double TotalSalary = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Order.EmployeeName.Equals(Employee.EmployeeName))
                    {
                        TotalSalary += Order.OrderBalance;
                    }
                }

                TotalSalary *= 0.3;

                SalaryCalculationTable.Items.Add(new ListViewItem(new string[] { Employee.EmployeeName, TotalSalary.ToString() }));
            }
            foreach (ColumnHeader ColumnHeader in SalaryCalculationTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
