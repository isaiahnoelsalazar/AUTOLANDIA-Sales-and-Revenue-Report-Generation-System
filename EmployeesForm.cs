using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

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

            //pictureBox1.Image = Resources.sample_employee_form;

            RefreshEmployees();
        }

        public void RefreshEmployees()
        {
            RecreateEmployeeList();

            EmployeeTable.Controls.Clear();
            EmployeeTable.RowStyles.Clear();
            EmployeeTable.RowCount = 0;

            foreach (EmployeeItem Employee in EmployeeList)
            {
                EmployeeTable.RowCount = EmployeeTable.RowCount + 1;
                EmployeeTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));

                string f_EmployeeName = Employee.EmployeeName;
                string f_DateRecorded = Employee.DateRecorded;

                MaterialLabel Name = new MaterialLabel();
                Name.Text = $"{Employee.EmployeeName}";
                Name.Dock = DockStyle.Fill;
                Name.AutoSize = false;
                Name.TextAlign = ContentAlignment.MiddleCenter;

                Button TimeIn = new Button();
                Button TimeOut = new Button();

                TimeIn.Text = "Time In";
                TimeIn.Dock = DockStyle.Fill;
                TimeIn.ForeColor = Color.White;
                TimeIn.BackColor = Color.Green;
                TimeIn.Click += (s, e) =>
                {
                    try
                    {
                        RecordActivity($"Employee \"{f_EmployeeName}\" timed in");

                        SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET TimeIn = 'true' WHERE CONVERT(VARCHAR, EmployeeName)='{f_EmployeeName}' AND CONVERT(VARCHAR, DateRecorded)='{f_DateRecorded}'", SQL);

                        Command.ExecuteNonQuery();

                        TimeIn.BackColor = SystemColors.Control;
                        TimeIn.Enabled = false;
                        TimeOut.ForeColor = Color.White;
                        TimeOut.BackColor = Color.FromArgb(200, 0, 0);
                        TimeOut.Enabled = true;

                        GlobalActivityRecordForm.RefreshActivities();
                    }
                    catch (Exception exception)
                    {
                        MaterialMessageBox.Show(exception.Message, "Alert");
                    }
                };

                TimeOut.Text = "Time Out";
                TimeOut.Dock = DockStyle.Fill;
                TimeOut.BackColor = SystemColors.Control;
                TimeOut.Enabled = false;
                TimeOut.Click += (s, e) =>
                {
                    try
                    {
                        RecordActivity($"Employee \"{f_EmployeeName}\" timed out");

                        SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET TimeOut = 'true' WHERE CONVERT(VARCHAR, EmployeeName)='{f_EmployeeName}' AND CONVERT(VARCHAR, DateRecorded)='{f_DateRecorded}'", SQL);

                        Command.ExecuteNonQuery();

                        TimeOut.BackColor = SystemColors.Control;
                        TimeOut.Enabled = false;

                        GlobalActivityRecordForm.RefreshActivities();
                    }
                    catch (Exception exception)
                    {
                        MaterialMessageBox.Show(exception.Message, "Alert");
                    }
                };

                MaterialLabel Date = new MaterialLabel();
                Date.Text = Employee.DateRecorded;
                Date.Dock = DockStyle.Fill;
                Date.AutoSize = false;
                Date.TextAlign = ContentAlignment.MiddleCenter;

                EmployeeTable.Controls.Add(Name, 0, EmployeeTable.RowCount - 1);
                EmployeeTable.Controls.Add(TimeIn, 1, EmployeeTable.RowCount - 1);
                EmployeeTable.Controls.Add(TimeOut, 2, EmployeeTable.RowCount - 1);
                EmployeeTable.Controls.Add(Date, 3, EmployeeTable.RowCount - 1);
            }
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            new NewEmployeeDialog(this).ShowDialog();
        }
    }
}
