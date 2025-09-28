using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EmployeeSalariesDialog : MaterialForm
    {
        Color DefaultBackgroundColor;

        public EmployeeSalariesDialog()
        {
            InitializeComponent();

            EmployeeList.Controls.Clear();
            EmployeeList.RowStyles.Clear();
            EmployeeList.VerticalScroll.Visible = true;
            EmployeeList.HorizontalScroll.Enabled = false;
            EmployeeList.HorizontalScroll.Visible = false;

            EmployeeCalendar.MaxDate = DateTime.Now.Date.AddDays(1);
            EmployeeCalendar.MinDate = DateTime.Now.Date.AddMonths(-2);

            RefreshEmployees(EmployeeCalendar.MaxDate, EmployeeCalendar.MaxDate);
        }

        void RefreshEmployees(DateTime DateTimeStart, DateTime DateTimeEnd)
        {
            DateRange.Text = $"{DateTimeStart.Date} - {DateTimeEnd.Date}";

            TimeSpan DateRangeTimeSpan = DateTimeEnd - DateTimeStart;
            DateTime[] DateTimeRange = new DateTime[DateRangeTimeSpan.Days + 1];

            for (int a = 0; a < DateTimeRange.Length; a++)
            {
                if (DateTimeRange[DateTimeRange.Length - 1].CompareTo(DateTimeEnd) != 0)
                {
                    DateTimeRange[a] = DateTimeStart.AddDays(a);
                }
            }

            EmployeeList.Controls.Clear();
            EmployeeList.RowStyles.Clear();

            foreach (EmployeeItem Employee in GlobalEmployeeList)
            {
                double TotalSalary = 0;

                foreach (OrderItem Order in GlobalOrderList)
                {
                    string[] Split = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');

                    if (DateTimeRange.Contains(DateTime.Parse(Order.DateCreated).Date) && Split.Contains(Employee.ID))
                    {
                        foreach (BillingItem Billing in GlobalBillingList)
                        {
                            if (Billing.ID.Equals(Order.ID))
                            {
                                TotalSalary += ((Billing.Balance * 0.3) / Split.Length);
                            }
                        }
                    }
                }

                RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                TableLayoutPanel Panel = new TableLayoutPanel
                {
                    ColumnCount = 2
                };
                Label Name = new Label();
                Label Salary = new Label();

                if (DefaultBackgroundColor == null)
                {
                    DefaultBackgroundColor = Panel.BackColor;
                }

                Panel.Dock = DockStyle.Top;
                Panel.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Panel.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };
                Panel.ColumnStyles.Clear();
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
                Panel.Margin = new Padding(0);

                Name.Dock = DockStyle.Fill;
                Name.Text = $"{Employee.LastName}, {Employee.FirstName} {Employee.MiddleName}";
                Name.TextAlign = ContentAlignment.MiddleCenter;
                Name.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Name.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                Salary.Dock = DockStyle.Fill;
                Salary.Text = TotalSalary.ToString();
                Salary.TextAlign = ContentAlignment.MiddleCenter;
                Salary.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Salary.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                EmployeeList.RowStyles.Add(Row);
                Panel.Controls.Add(Name, 0, 0);
                Panel.Controls.Add(Salary, 1, 0);
                EmployeeList.Controls.Add(Panel);

                tableLayoutPanel2.Width = EmployeeList.Width;
            }
        }

        private void EmployeeCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            RefreshEmployees(e.Start.Date, e.End.Date);
        }
    }
}
