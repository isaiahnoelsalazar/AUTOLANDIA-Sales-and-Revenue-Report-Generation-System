using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class TransactionsForm : Form
    {
        Color DefaultBackgroundColor;
        List<OrderItem> Temp = new List<OrderItem>(GlobalOrderList);
        DateTime Global;

        public TransactionsForm()
        {
            InitializeComponent();

            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();
            TransactionList.VerticalScroll.Visible = true;
            TransactionList.HorizontalScroll.Enabled = false;
            TransactionList.HorizontalScroll.Visible = false;

            FilterTransaction.Items.Add("ID");
            FilterTransaction.Items.Add("Employee(s)");
            FilterTransaction.Items.Add("Plate Number");
            FilterTransaction.Items.Add("Progress");

            Global = DateTime.Now;
            DatePickerButton.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        public void RefreshTransactions()
        {
            RecreateGlobalOrderList();

            Temp = new List<OrderItem>(GlobalOrderList);

            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();

            for (int a = 0; a < Temp.Count;)
            {
                if (!DateTime.Parse(Temp[a].DateCreated).Date.ToString("d").Equals(Global.Date.ToString("d")))
                {
                    Temp.Remove(Temp[a]);
                    a = 0;
                }
                else
                {
                    a++;
                }
            }

            foreach (OrderItem Order in Temp)
            {
                RefreshRows(Order);
            }
        }

        private void AddNewTransactionButton_Click(object sender, EventArgs e)
        {
            new NewTransactionDialog().ShowDialog();
        }

        private void SearchBarTransaction_TextChanged(object sender, EventArgs e)
        {
            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();

            foreach (OrderItem Order in Temp)
            {
                if (FilterTransaction.SelectedIndex == 0 || FilterTransaction.SelectedIndex == -1)
                {
                    if (Order.ID.Contains(SearchBarTransaction.Text))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 1)
                {
                    string EmployeeList1 = string.Empty;

                    string[] Split1 = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');
                    foreach (string EmployeeId in Split1)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            if (Employee.ID.Equals(EmployeeId.Trim()))
                            {
                                EmployeeList1 += $"({Employee.LastName}, {Employee.FirstName} {Employee.MiddleName})" + ",";
                            }
                        }
                    }
                    EmployeeList1 = EmployeeList1.Substring(0, EmployeeList1.Length - 1);

                    if (EmployeeList1.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 2)
                {
                    string RealPlateNumber1 = string.Empty;

                    foreach (VehicleItem Vehicle in GlobalVehicleList)
                    {
                        if (Vehicle.ID.Equals(Order.VehicleId))
                        {
                            RealPlateNumber1 = Vehicle.PlateNumber;
                        }
                    }

                    if (RealPlateNumber1.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 3)
                {
                    if (Order.Progress.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
            }
        }

        private void FilterTransaction_TextChanged(object sender, EventArgs e)
        {
            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();

            foreach (OrderItem Order in Temp)
            {
                if (FilterTransaction.SelectedIndex == 0 || FilterTransaction.SelectedIndex == -1)
                {
                    if (Order.ID.Contains(SearchBarTransaction.Text))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 1)
                {
                    string EmployeeList1 = string.Empty;

                    string[] Split1 = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');
                    foreach (string EmployeeId in Split1)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            if (Employee.ID.Equals(EmployeeId.Trim()))
                            {
                                EmployeeList1 += $"({Employee.LastName}, {Employee.FirstName} {Employee.MiddleName})" + ",";
                            }
                        }
                    }
                    EmployeeList1 = EmployeeList1.Substring(0, EmployeeList1.Length - 1);

                    if (EmployeeList1.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 2)
                {
                    string RealPlateNumber1 = string.Empty;

                    foreach (VehicleItem Vehicle in GlobalVehicleList)
                    {
                        if (Vehicle.ID.Equals(Order.VehicleId))
                        {
                            RealPlateNumber1 = Vehicle.PlateNumber;
                        }
                    }

                    if (RealPlateNumber1.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
                if (FilterTransaction.SelectedIndex == 3)
                {
                    if (Order.Progress.ToUpper().Contains(SearchBarTransaction.Text.ToUpper()))
                    {
                        RefreshRows(Order);
                    }
                }
            }
        }

        void RefreshRows(OrderItem Order)
        {
            string RealPlateNumber = string.Empty;
            string EmployeeList = string.Empty;

            string[] Split = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');
            foreach (string EmployeeId in Split)
            {
                foreach (EmployeeItem Employee in GlobalEmployeeList)
                {
                    if (Employee.ID.Equals(EmployeeId.Trim()))
                    {
                        EmployeeList += $"({Employee.LastName}, {Employee.FirstName} {Employee.MiddleName})" + ",";
                    }
                }
            }
            EmployeeList = EmployeeList.Substring(0, EmployeeList.Length - 1);
            foreach (VehicleItem Vehicle in GlobalVehicleList)
            {
                if (Vehicle.ID.Equals(Order.VehicleId))
                {
                    RealPlateNumber = Vehicle.PlateNumber;
                }
            }
            string ServicePackageDetail = string.Empty;
            foreach (PackageItem Package in GlobalPackageList)
            {
                if (Package.ID.Equals(Order.PackageID))
                {
                    ServicePackageDetail += $"[Package] - {Package.Name}, {Package.Size} ";
                    break;
                }
            }
            if (!string.IsNullOrEmpty(Order.ServiceIDList))
            {
                string[] ServiceSplit = Order.ServiceIDList.Substring(1, Order.ServiceIDList.Length - 2).Split(',');
                List<ServiceItem> ServiceTemp = new List<ServiceItem>(GlobalServiceList);
                ServiceTemp.Add(new ServiceItem("S_VCBW1", "Body Wash", "S", 120));
                ServiceTemp.Add(new ServiceItem("S_VCBW2", "Body Wash", "M", 150));
                ServiceTemp.Add(new ServiceItem("S_VCBW3", "Body Wash", "L", 200));
                ServiceTemp.Add(new ServiceItem("S_VCBWT", "Body Wash", "M", 220));
                ServiceTemp.Add(new ServiceItem("S_VCBWP", "Body Wash", "M", 400));
                ServiceTemp.Add(new ServiceItem("S_VCA1", "Armor", "S", 100));
                ServiceTemp.Add(new ServiceItem("S_VCA2", "Armor", "M", 100));
                ServiceTemp.Add(new ServiceItem("S_VCA3", "Armor", "L", 100));
                ServiceTemp.Add(new ServiceItem("S_VCW1", "Wax (Manual)", "S", 150));
                ServiceTemp.Add(new ServiceItem("S_VCW2", "Wax (Manual)", "M", 150));
                ServiceTemp.Add(new ServiceItem("S_VCW3", "Wax (Manual)", "L", 150));
                foreach (ServiceItem Service in ServiceTemp)
                {
                    if (ServiceSplit.Contains(Service.ID))
                    {
                        ServicePackageDetail += "[Services] - ";
                        ServicePackageDetail += Service.ID + ", ";
                    }
                }
                ServicePackageDetail = ServicePackageDetail.Substring(0, ServicePackageDetail.Length - 2);
            }

            RowStyle Row = new RowStyle(SizeType.Absolute, 75f);
            TableLayoutPanel Panel = new TableLayoutPanel
            {
                ColumnCount = 7
            };
            Label Id = new Label();
            Label Employees = new Label();
            Label Service_Package = new Label();
            Label PlateNumber = new Label();
            MaterialComboBox Progress = new MaterialComboBox();
            Label LastUpdated = new Label();
            Label DateCreated = new Label();

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
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.Margin = new Padding(0);

            Id.Dock = DockStyle.Fill;
            Id.Text = Order.ID;
            Id.TextAlign = ContentAlignment.MiddleCenter;
            Id.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Id.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Employees.Dock = DockStyle.Fill;
            Employees.Text = EmployeeList;
            Employees.TextAlign = ContentAlignment.MiddleCenter;
            Employees.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Employees.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Service_Package.Dock = DockStyle.Fill;
            Service_Package.Text = ServicePackageDetail;
            Service_Package.TextAlign = ContentAlignment.MiddleCenter;
            Service_Package.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Service_Package.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            PlateNumber.Dock = DockStyle.Fill;
            PlateNumber.Text = RealPlateNumber;
            PlateNumber.TextAlign = ContentAlignment.MiddleCenter;
            PlateNumber.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            PlateNumber.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Progress.Dock = DockStyle.Fill;
            Progress.Items.Add("Ready");
            Progress.Items.Add("In progress");
            Progress.Items.Add("Complete");
            Progress.Items.Add("Cancelled");

            if (Order.Progress.Equals("Ready"))
            {
                Progress.SelectedIndex = 0;
            }
            if (Order.Progress.Equals("In progress"))
            {
                Progress.SelectedIndex = 1;
            }
            if (Order.Progress.Equals("Complete"))
            {
                Progress.SelectedIndex = 2;
            }
            if (Order.Progress.Equals("Cancelled"))
            {
                Progress.SelectedIndex = 3;
            }

            Progress.SelectedIndexChanged += (sndr, evnt) =>
            {
                try
                {
                    DateTime Now = DateTime.Now;

                    RecordActivity($"Changed order reference number [{Order.ID}] progress from [{Order.Progress}] to [{Progress.Text}]");

                    SqliteCommand Command = new SqliteCommand($"UPDATE AUTOLANDIA_OrderList SET OrderProgress='{Progress.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE OrderId='{Order.ID}'", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully changed transaction progress!", "Notice");
                    RefreshTransactions();
                    GlobalActivityRecordForm.RefreshActivities();
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
                }
            };

            LastUpdated.Dock = DockStyle.Fill;
            LastUpdated.Text = Order.LastUpdated;
            LastUpdated.TextAlign = ContentAlignment.MiddleCenter;
            LastUpdated.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            LastUpdated.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            DateCreated.Dock = DockStyle.Fill;
            DateCreated.Text = Order.DateCreated;
            DateCreated.TextAlign = ContentAlignment.MiddleCenter;
            DateCreated.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            DateCreated.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Panel.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            Id.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            Employees.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            Service_Package.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            PlateNumber.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            LastUpdated.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };
            DateCreated.Click += (sndr, evnt) =>
            {
                new EditTransactionDialog(this, Order.ID).ShowDialog();
            };

            TransactionList.RowStyles.Add(Row);
            Panel.Controls.Add(Id, 0, 0);
            Panel.Controls.Add(Employees, 1, 0);
            Panel.Controls.Add(Service_Package, 2, 0);
            Panel.Controls.Add(PlateNumber, 3, 0);
            Panel.Controls.Add(Progress, 4, 0);
            Panel.Controls.Add(LastUpdated, 5, 0);
            Panel.Controls.Add(DateCreated, 6, 0);
            TransactionList.Controls.Add(Panel);

            tableLayoutPanel2.Width = TransactionList.Width;
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            RefreshTransactions();
        }

        public void SetDate(DateTime DateTime)
        {
            Global = DateTime;
            DatePickerButton.Text = DateTime.Date.ToString("yyyy/MM/dd");

            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();

            RefreshTransactions();
        }

        private void DatePickerButton_Click(object sender, EventArgs e)
        {
            new DatePickerDialog(this).ShowDialog();
        }
    }
}
