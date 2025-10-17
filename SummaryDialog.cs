using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SummaryDialog : MaterialForm
    {
        Color DefaultBackgroundColor;
        bool FirstDateSelected = false;
        DateTime FirstDate;

        public SummaryDialog()
        {
            InitializeComponent();

            SummaryText.Text = string.Empty;

            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();
            TransactionList.VerticalScroll.Visible = true;
            TransactionList.HorizontalScroll.Enabled = false;
            TransactionList.HorizontalScroll.Visible = false;

            SummaryCalendar.MaxDate = DateTime.Now.Date;
            SummaryCalendar.MinDate = DateTime.Now.Date.AddMonths(-2);
        }

        private void SummaryDialog_Load(object sender, EventArgs e)
        {
            RefreshBilling(SummaryCalendar.MaxDate, SummaryCalendar.MaxDate);
        }

        void RefreshBilling(DateTime DateTimeStart, DateTime DateTimeEnd)
        {
            DateRange.Text = $"{DateTimeStart.Date.ToString("d")} - {DateTimeEnd.Date.ToString("d")}";

            TimeSpan DateRangeTimeSpan = DateTimeEnd - DateTimeStart;
            DateTime[] DateTimeRange = new DateTime[DateRangeTimeSpan.Days + 1];

            for (int a = 0; a < DateTimeRange.Length; a++)
            {
                if (DateTimeRange[DateTimeRange.Length - 1].CompareTo(DateTimeEnd) != 0)
                {
                    DateTimeRange[a] = DateTimeStart.AddDays(a);
                }
            }

            double TotalSales = 0;
            double TotalTransactions = 0;

            foreach (BillingItem Billing in GlobalBillingList)
            {
                if (DateTimeRange.Contains(DateTime.Parse(Billing.DateCreated).Date) && Billing.Progress.Equals("Paid"))
                {
                    TotalSales += Convert.ToDouble(Billing.Balance);
                    TotalTransactions++;
                }
            }

            SummaryText.Text = $"Total sales: {TotalSales}\n\nTotal transactions: {TotalTransactions}";

            TransactionList.Controls.Clear();
            TransactionList.RowStyles.Clear();

            foreach (OrderItem Order in GlobalOrderList)
            {
                if (DateTimeRange.Contains(DateTime.Parse(Order.DateCreated).Date))
                {
                    //string CustomerName = string.Empty;

                    //foreach (VehicleItem Vehicle in GlobalVehicleList)
                    //{
                    //    if (Vehicle.ID.Equals(Order.VehicleId))
                    //    {
                    //        foreach (CustomerItem Customer in GlobalCustomerList)
                    //        {
                    //            if (Customer.ID.Equals(Vehicle.CustomerID))
                    //            {
                    //                CustomerName = $"{Customer.LastName}, {Customer.FirstName}{(string.IsNullOrEmpty(Customer.MiddleName) ? "" : $" {Customer.MiddleName}")}";
                    //                break;
                    //            }
                    //        }
                    //    }
                    //}

                    //RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                    //TableLayoutPanel Panel = new TableLayoutPanel
                    //{
                    //    ColumnCount = 1
                    //};
                    //Label Name = new Label();

                    //if (DefaultBackgroundColor == null)
                    //{
                    //    DefaultBackgroundColor = Panel.BackColor;
                    //}

                    //Panel.Dock = DockStyle.Top;
                    //Panel.MouseEnter += (sndr, evnt) =>
                    //{
                    //    Panel.BackColor = Color.FromArgb(200, 200, 200);
                    //};
                    //Panel.MouseLeave += (sndr, evnt) =>
                    //{
                    //    Panel.BackColor = DefaultBackgroundColor;
                    //};
                    //Panel.ColumnStyles.Clear();
                    //Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
                    //Panel.Margin = new Padding(0);

                    //Name.Dock = DockStyle.Fill;
                    //Name.Text = $"[Order: {Order.ID}] {CustomerName} - {(string.IsNullOrEmpty(Order.ServiceIDList) ? $"{Order.PackageID}" : $"{Order.ServiceIDList}")}";
                    //Name.TextAlign = ContentAlignment.MiddleLeft;
                    //Name.MouseEnter += (sndr, evnt) =>
                    //{
                    //    Panel.BackColor = Color.FromArgb(200, 200, 200);
                    //};
                    //Name.MouseLeave += (sndr, evnt) =>
                    //{
                    //    Panel.BackColor = DefaultBackgroundColor;
                    //};

                    //TransactionList.RowStyles.Add(Row);
                    //Panel.Controls.Add(Name, 0, 0);
                    //TransactionList.Controls.Add(Panel);

                    //tableLayoutPanel2.Width = TransactionList.Width;
                    VehicleItem RealVehicle = null;
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
                            RealVehicle = Vehicle;
                        }
                    }
                    double RealAmount = 0;
                    foreach (BillingItem Billing in GlobalBillingList)
                    {
                        if (Billing.ID.Equals(Order.ID))
                        {
                            RealAmount = Billing.Balance;
                        }
                    }
                    string ServicePackageDetail = string.Empty;
                    if (!string.IsNullOrEmpty(Order.ServiceIDList))
                    {
                        string[] ServiceSplit = Order.ServiceIDList.Substring(1, Order.ServiceIDList.Length - 2).Split(',');
                        foreach (ServiceItem Service in GlobalServiceList)
                        {
                            if (ServiceSplit.Contains(Service.ID))
                            {
                                ServicePackageDetail += Service.Name + ", ";
                            }
                        }
                        ServicePackageDetail = ServicePackageDetail.Substring(0, ServicePackageDetail.Length - 1);
                    }
                    else
                    {
                        foreach (PackageItem Package in GlobalPackageList)
                        {
                            if (Package.ID.Equals(Order.PackageID))
                            {
                                ServicePackageDetail = $"[{Package.Name}, {Package.Size}] - {Package.Details}";
                                break;
                            }
                        }
                    }

                    RowStyle Row = new RowStyle(SizeType.Absolute, 55f);
                    TableLayoutPanel Panel = new TableLayoutPanel
                    {
                        ColumnCount = 7
                    };
                    Label Employees = new Label();
                    Label PlateNumber = new Label();
                    Label VehicleName = new Label();
                    Label Service_Package = new Label();
                    Label Amount = new Label();

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
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    Panel.Margin = new Padding(0);

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

                    PlateNumber.Dock = DockStyle.Fill;
                    PlateNumber.Text = RealVehicle.PlateNumber;
                    PlateNumber.TextAlign = ContentAlignment.MiddleCenter;
                    PlateNumber.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    PlateNumber.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    VehicleName.Dock = DockStyle.Fill;
                    VehicleName.Text = $"{RealVehicle.Brand}, {RealVehicle.Model}";
                    VehicleName.TextAlign = ContentAlignment.MiddleCenter;
                    VehicleName.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    VehicleName.MouseLeave += (sndr, evnt) =>
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

                    Amount.Dock = DockStyle.Fill;
                    Amount.Text = RealAmount.ToString();
                    Amount.TextAlign = ContentAlignment.MiddleCenter;
                    Amount.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Amount.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    Panel.Click += (sndr, evnt) =>
                    {
                    };
                    Employees.Click += (sndr, evnt) =>
                    {
                    };
                    PlateNumber.Click += (sndr, evnt) =>
                    {
                    };
                    VehicleName.Click += (sndr, evnt) =>
                    {
                    };
                    Service_Package.Click += (sndr, evnt) =>
                    {
                    };

                    TransactionList.RowStyles.Add(Row);
                    Panel.Controls.Add(Employees, 0, 0);
                    Panel.Controls.Add(PlateNumber, 1, 0);
                    Panel.Controls.Add(VehicleName, 2, 0);
                    Panel.Controls.Add(Service_Package, 3, 0);
                    Panel.Controls.Add(Amount, 4, 0);
                    TransactionList.Controls.Add(Panel);

                    tableLayoutPanel2.Width = TransactionList.Width;
                }
            }
        }

        private void SummaryCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!FirstDateSelected)
            {
                SummaryText.Text = string.Empty;
                FirstDate = e.Start.Date;
                FirstDateSelected = true;
                DateRange.Text = $"{FirstDate.Date.ToString("d")} - (Select end date)";
            }
            else
            {
                FirstDateSelected = false;
                DateRange.Text = $"{FirstDate.Date.ToString("d")} - {e.Start.Date.ToString("d")}";
                RefreshBilling(FirstDate, e.Start.Date);
            }
        }
    }
}
