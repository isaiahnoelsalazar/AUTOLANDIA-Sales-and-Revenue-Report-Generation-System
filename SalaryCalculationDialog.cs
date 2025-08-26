using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
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
            SalaryCalculationTable.Columns.Add("WeeklyEmployeeSalary", -2);

            SalaryCalculationTable.Items.Clear();

            DateTime Today = DateTime.Now;
            DateTime[] Days = new DateTime[7];

            DateTime StartOfWeek = Today.AddDays(-(int)Today.DayOfWeek);

            for (int a = 0; a < 7; a++)
            {
                Days[a] = StartOfWeek.AddDays(a).Date;
            }

            List<EmployeeItem> Temp = new List<EmployeeItem>(EmployeeList);
            Temp.Sort(new EmployeeItemComparer());

            foreach (EmployeeItem Employee in Temp)
            {
                double TotalSalary = 0;

                foreach (OrderItem Order in OrderList)
                {
                    if (Order.EmployeeName.Equals(Employee.EmployeeName) && Days.Contains(DateTime.Parse(DateTime.Parse(Order.DateCreated).Date.ToString("d"))))
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
