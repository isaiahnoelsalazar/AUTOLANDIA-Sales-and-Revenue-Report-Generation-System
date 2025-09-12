using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditTransactionDialog : MaterialForm
    {
        TransactionsForm TransactionsForm;
        public MaterialCheckedListBox.ItemsList ServiceCheckedboxes, EmployeeCheckedboxes;
        Color DefaultBackgroundColor;

        public EditTransactionDialog(TransactionsForm TransactionsForm, string OrderID)
        {
            InitializeComponent();

            this.TransactionsForm = TransactionsForm;

            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();
            SelectServicesButton.Visible = true;
            PackageLabel.Text = "Select services";

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (!CB_Packages.Items.Contains(Package.Name))
                {
                    CB_Packages.Items.Add(Package.Name);
                }
            }

            foreach (OrderItem Order in GlobalOrderList)
            {
                if (Order.ID.Equals(OrderID))
                {
                    TB_ID.Text = Order.ID;
                    TB_LastUpdated.Text = Order.LastUpdated;
                    TB_DateCreated.Text = Order.DateCreated;

                    VehicleItem RealVehicle = null;

                    foreach (VehicleItem Vehicle in GlobalVehicleList)
                    {
                        if (Vehicle.ID.Equals(Order.VehicleId))
                        {
                            RealVehicle = Vehicle;
                            TB_Vehicle.Text = $"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}";
                        }
                    }

                    if (string.IsNullOrEmpty(Order.ServiceIDList))
                    {
                        RB_Package.Checked = true;
                        SelectServicesButton.Visible = false;
                        PackageLabel.Text = "Pick a package";
                        foreach (PackageItem Package in GlobalPackageList)
                        {
                            if (Package.ID.Equals(Order.PackageID) && Package.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                            {
                                RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                                TableLayoutPanel Panel = new TableLayoutPanel
                                {
                                    ColumnCount = 2
                                };
                                Label Name = new Label();
                                Label Price = new Label();

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
                                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                                Panel.Margin = new Padding(0);

                                Name.Dock = DockStyle.Fill;
                                Name.Text = Package.Name;
                                Name.TextAlign = ContentAlignment.MiddleLeft;
                                Name.MouseEnter += (sndr, evnt) =>
                                {
                                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                                };
                                Name.MouseLeave += (sndr, evnt) =>
                                {
                                    Panel.BackColor = DefaultBackgroundColor;
                                };

                                Price.Dock = DockStyle.Fill;
                                Price.Text = Package.Price.ToString();
                                Price.TextAlign = ContentAlignment.MiddleCenter;
                                Price.MouseEnter += (sndr, evnt) =>
                                {
                                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                                };
                                Price.MouseLeave += (sndr, evnt) =>
                                {
                                    Panel.BackColor = DefaultBackgroundColor;
                                };

                                ServiceList.RowStyles.Add(Row);
                                Panel.Controls.Add(Name, 0, 0);
                                Panel.Controls.Add(Price, 1, 0);
                                ServiceList.Controls.Add(Panel);

                                tableLayoutPanel2.Width = ServiceList.Width;

                                foreach (string Item in Package.Details.Split(','))
                                {
                                    RowStyle Row1 = new RowStyle(SizeType.Absolute, 48f);
                                    TableLayoutPanel Panel1 = new TableLayoutPanel
                                    {
                                        ColumnCount = 2
                                    };
                                    Label Name1 = new Label();
                                    Label Price1 = new Label();

                                    if (DefaultBackgroundColor == null)
                                    {
                                        DefaultBackgroundColor = Panel1.BackColor;
                                    }

                                    Panel1.Dock = DockStyle.Top;
                                    Panel1.MouseEnter += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = Color.FromArgb(200, 200, 200);
                                    };
                                    Panel1.MouseLeave += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = DefaultBackgroundColor;
                                    };
                                    Panel1.ColumnStyles.Clear();
                                    Panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                                    Panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                                    Panel1.Margin = new Padding(0);

                                    Name1.Dock = DockStyle.Fill;
                                    Name1.Text = Item;
                                    Name1.TextAlign = ContentAlignment.MiddleLeft;
                                    Name1.MouseEnter += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = Color.FromArgb(200, 200, 200);
                                    };
                                    Name1.MouseLeave += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = DefaultBackgroundColor;
                                    };

                                    Price1.Dock = DockStyle.Fill;
                                    Price1.Text = "";
                                    Price1.TextAlign = ContentAlignment.MiddleCenter;
                                    Price1.MouseEnter += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = Color.FromArgb(200, 200, 200);
                                    };
                                    Price1.MouseLeave += (sndr, evnt) =>
                                    {
                                        Panel1.BackColor = DefaultBackgroundColor;
                                    };

                                    ServiceList.RowStyles.Add(Row1);
                                    Panel1.Controls.Add(Name1, 0, 0);
                                    Panel1.Controls.Add(Price1, 1, 0);
                                    ServiceList.Controls.Add(Panel1);

                                    tableLayoutPanel2.Width = ServiceList.Width;
                                }
                                break;
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(Order.PackageID))
                    {
                        RB_Service.Checked = true;
                        SelectServicesButton.Visible = true;
                        PackageLabel.Text = "Select services";
                        string[] ServiceSplit = Order.ServiceIDList.Substring(1, Order.ServiceIDList.Length - 2).Split(',');
                        foreach (string ServiceID in ServiceSplit)
                        {
                            foreach (ServiceItem Service in GlobalServiceList)
                            {
                                if (Service.ID.Equals(ServiceID) && Service.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                                {
                                    RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                                    TableLayoutPanel Panel = new TableLayoutPanel
                                    {
                                        ColumnCount = 2
                                    };
                                    Label Name = new Label();
                                    Label Price = new Label();

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
                                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                                    Panel.Margin = new Padding(0);

                                    Name.Dock = DockStyle.Fill;
                                    Name.Text = Service.Name;
                                    Name.TextAlign = ContentAlignment.MiddleLeft;
                                    Name.MouseEnter += (sndr, evnt) =>
                                    {
                                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                                    };
                                    Name.MouseLeave += (sndr, evnt) =>
                                    {
                                        Panel.BackColor = DefaultBackgroundColor;
                                    };

                                    Price.Dock = DockStyle.Fill;
                                    Price.Text = Service.Price.ToString();
                                    Price.TextAlign = ContentAlignment.MiddleCenter;
                                    Price.MouseEnter += (sndr, evnt) =>
                                    {
                                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                                    };
                                    Price.MouseLeave += (sndr, evnt) =>
                                    {
                                        Panel.BackColor = DefaultBackgroundColor;
                                    };

                                    ServiceList.RowStyles.Add(Row);
                                    Panel.Controls.Add(Name, 0, 0);
                                    Panel.Controls.Add(Price, 1, 0);
                                    ServiceList.Controls.Add(Panel);

                                    tableLayoutPanel2.Width = ServiceList.Width;
                                    break;
                                }
                            }
                        }
                    }

                    CB_Progress.Items.Add("Ready");
                    CB_Progress.Items.Add("In progress");
                    CB_Progress.Items.Add("Complete");

                    if (Order.Progress.Equals("Ready"))
                    {
                        CB_Progress.SelectedIndex = 0;
                    }
                    if (Order.Progress.Equals("In progress"))
                    {
                        CB_Progress.SelectedIndex = 1;
                    }
                    if (Order.Progress.Equals("Complete"))
                    {
                        CB_Progress.SelectedIndex = 2;
                    }

                    string[] Split = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');
                    foreach (string EmployeeId in Split)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                            if (Employee.ID.Equals(EmployeeId.Trim()))
                            {
                                TB_Employee.Text += EmployeeDetail + ", ";
                                break;
                            }
                        }
                    }
                    TB_Employee.Text = TB_Employee.Text.Substring(0, TB_Employee.Text.Length - 2);
                }
            }
        }

        public void SetEmployees(MaterialCheckedListBox.ItemsList EmployeeCheckboxes)
        {
            TB_Employee.Text = string.Empty;

            EmployeeCheckedboxes = EmployeeCheckboxes;

            for (int a = EmployeeCheckedboxes.Count - 1; a > 0; a--)
            {
                if (EmployeeCheckedboxes[a].Checked)
                {
                    foreach (EmployeeItem Employee in GlobalEmployeeList)
                    {
                        string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                        if (Employee.ID.Equals(EmployeeCheckedboxes[a].Text.Split(':')[0].Trim()) && Employee.Name.Equals(EmployeeCheckedboxes[a].Text.Split(':')[1].Trim()))
                        {
                            TB_Employee.Text += EmployeeDetail + ", ";
                            break;
                        }
                    }
                }
            }

            TB_Employee.Text = TB_Employee.Text.Substring(0, TB_Employee.Text.Length - 2);
        }

        public void SetServices(MaterialCheckedListBox.ItemsList ServiceCheckboxes)
        {
            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();

            ServiceCheckedboxes = ServiceCheckboxes;

            VehicleItem RealVehicle = null;

            try
            {
                foreach (VehicleItem Vehicle in GlobalVehicleList)
                {
                    if (Vehicle.ID.Equals(TB_Vehicle.Text.Split(',')[0].Split(':')[0].Trim()))
                    {
                        RealVehicle = Vehicle;
                    }
                }
            }
            catch
            {
            }

            for (int a = ServiceCheckedboxes.Count - 1; a > 0; a--)
            {
                if (ServiceCheckedboxes[a].Checked)
                {
                    foreach (ServiceItem Service in GlobalServiceList)
                    {
                        if (Service.Name.Equals(ServiceCheckedboxes[a].Text) && Service.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                        {
                            RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                            TableLayoutPanel Panel = new TableLayoutPanel
                            {
                                ColumnCount = 2
                            };
                            Label Name = new Label();
                            Label Price = new Label();

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
                            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                            Panel.Margin = new Padding(0);

                            Name.Dock = DockStyle.Fill;
                            Name.Text = Service.Name;
                            Name.TextAlign = ContentAlignment.MiddleLeft;
                            Name.MouseEnter += (sndr, evnt) =>
                            {
                                Panel.BackColor = Color.FromArgb(200, 200, 200);
                            };
                            Name.MouseLeave += (sndr, evnt) =>
                            {
                                Panel.BackColor = DefaultBackgroundColor;
                            };

                            Price.Dock = DockStyle.Fill;
                            Price.Text = Service.Price.ToString();
                            Price.TextAlign = ContentAlignment.MiddleCenter;
                            Price.MouseEnter += (sndr, evnt) =>
                            {
                                Panel.BackColor = Color.FromArgb(200, 200, 200);
                            };
                            Price.MouseLeave += (sndr, evnt) =>
                            {
                                Panel.BackColor = DefaultBackgroundColor;
                            };

                            ServiceList.RowStyles.Add(Row);
                            Panel.Controls.Add(Name, 0, 0);
                            Panel.Controls.Add(Price, 1, 0);
                            ServiceList.Controls.Add(Panel);

                            tableLayoutPanel2.Width = ServiceList.Width;
                            break;
                        }
                    }
                }
            }
        }

        private void TB_Employee_Click(object sender, EventArgs e)
        {
            new SelectEmployeeDialog(this, TB_Employee.Text).ShowDialog();
        }

        private void PickEmployeeButton_Click(object sender, EventArgs e)
        {
            new SelectEmployeeDialog(this, TB_Employee.Text).ShowDialog();
        }

        private void TB_Vehicle_Click(object sender, EventArgs e)
        {
            new SelectVehicleDialog(this).ShowDialog();
        }

        private void PickVehicleButton_Click(object sender, EventArgs e)
        {
            new SelectVehicleDialog(this).ShowDialog();
        }

        private void SelectServicesButton_Click(object sender, EventArgs e)
        {
            new SelectServicesDialog(this, ServiceList.Controls).ShowDialog();
        }

        private void CB_Packages_TextChanged(object sender, EventArgs e)
        {
            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();

            VehicleItem RealVehicle = null;

            try
            {
                foreach (VehicleItem Vehicle in GlobalVehicleList)
                {
                    if (Vehicle.ID.Equals(TB_Vehicle.Text.Split(',')[0].Split(':')[0].Trim()))
                    {
                        RealVehicle = Vehicle;
                    }
                }
            }
            catch
            {
            }

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                {
                    RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                    TableLayoutPanel Panel = new TableLayoutPanel
                    {
                        ColumnCount = 2
                    };
                    Label Name = new Label();
                    Label Price = new Label();

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
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                    Panel.Margin = new Padding(0);

                    Name.Dock = DockStyle.Fill;
                    Name.Text = Package.Name;
                    Name.TextAlign = ContentAlignment.MiddleLeft;
                    Name.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Name.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    Price.Dock = DockStyle.Fill;
                    Price.Text = Package.Price.ToString();
                    Price.TextAlign = ContentAlignment.MiddleCenter;
                    Price.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Price.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    ServiceList.RowStyles.Add(Row);
                    Panel.Controls.Add(Name, 0, 0);
                    Panel.Controls.Add(Price, 1, 0);
                    ServiceList.Controls.Add(Panel);

                    tableLayoutPanel2.Width = ServiceList.Width;

                    foreach (string Item in Package.Details.Split(','))
                    {
                        RowStyle Row1 = new RowStyle(SizeType.Absolute, 48f);
                        TableLayoutPanel Panel1 = new TableLayoutPanel
                        {
                            ColumnCount = 2
                        };
                        Label Name1 = new Label();
                        Label Price1 = new Label();

                        if (DefaultBackgroundColor == null)
                        {
                            DefaultBackgroundColor = Panel1.BackColor;
                        }

                        Panel1.Dock = DockStyle.Top;
                        Panel1.MouseEnter += (sndr, evnt) =>
                        {
                            Panel1.BackColor = Color.FromArgb(200, 200, 200);
                        };
                        Panel1.MouseLeave += (sndr, evnt) =>
                        {
                            Panel1.BackColor = DefaultBackgroundColor;
                        };
                        Panel1.ColumnStyles.Clear();
                        Panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65f));
                        Panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
                        Panel1.Margin = new Padding(0);

                        Name1.Dock = DockStyle.Fill;
                        Name1.Text = Item;
                        Name1.TextAlign = ContentAlignment.MiddleLeft;
                        Name1.MouseEnter += (sndr, evnt) =>
                        {
                            Panel1.BackColor = Color.FromArgb(200, 200, 200);
                        };
                        Name1.MouseLeave += (sndr, evnt) =>
                        {
                            Panel1.BackColor = DefaultBackgroundColor;
                        };

                        Price1.Dock = DockStyle.Fill;
                        Price1.Text = "";
                        Price1.TextAlign = ContentAlignment.MiddleCenter;
                        Price1.MouseEnter += (sndr, evnt) =>
                        {
                            Panel1.BackColor = Color.FromArgb(200, 200, 200);
                        };
                        Price1.MouseLeave += (sndr, evnt) =>
                        {
                            Panel1.BackColor = DefaultBackgroundColor;
                        };

                        ServiceList.RowStyles.Add(Row1);
                        Panel1.Controls.Add(Name1, 0, 0);
                        Panel1.Controls.Add(Price1, 1, 0);
                        ServiceList.Controls.Add(Panel1);

                        tableLayoutPanel2.Width = ServiceList.Width;
                    }
                    break;
                }
            }
        }

        private void RB_Service_Click(object sender, EventArgs e)
        {
            if (RB_Service.Checked)
            {
                ServiceList.Controls.Clear();
                ServiceList.RowStyles.Clear();
                SelectServicesButton.Visible = true;
                PackageLabel.Text = "Select services";
            }
        }

        private void RB_Package_Click(object sender, EventArgs e)
        {
            if (RB_Package.Checked)
            {
                ServiceList.Controls.Clear();
                ServiceList.RowStyles.Clear();
                SelectServicesButton.Visible = false;
                PackageLabel.Text = "Pick package";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;

            string ErrorMessage = string.Empty;

            if (RB_Service.Checked)
            {
                if (string.IsNullOrEmpty(TB_Employee.Text))
                {
                    ErrorMessage += "Please select an employee.\n";
                }
                if (string.IsNullOrEmpty(TB_Vehicle.Text))
                {
                    ErrorMessage += "Please select a vehicle.\n";
                }
                if (ServiceList.Controls.Count == 0)
                {
                    ErrorMessage += "Please select at least one service.\n";
                }

                if (ErrorMessage.Equals(""))
                {
                    double RealPrice = 0;

                    VehicleItem RealVehicle = null;

                    foreach (VehicleItem Vehicle in GlobalVehicleList)
                    {
                        if (Vehicle.ID.Equals(TB_Vehicle.Text.Split(',')[0].Split(':')[0].Trim()))
                        {
                            RealVehicle = Vehicle;
                        }
                    }

                    string ServiceIds = "[";
                    for (int a = 0; a < ServiceList.Controls.Count; a++)
                    {
                        foreach (ServiceItem Service in GlobalServiceList)
                        {
                            if (Service.Name.Equals(ServiceList.Controls[a].Controls[0].Text) && Service.Size.Equals(RealVehicle.Size))
                            {
                                ServiceIds += Service.ID + ",";
                                RealPrice += Service.Price;
                                break;
                            }
                        }
                    }
                    ServiceIds = ServiceIds.Substring(0, ServiceIds.Length - 1);
                    ServiceIds += "]";

                    string EmployeeIds = "[";
                    string[] SplitComma = TB_Employee.Text.Split(',');
                    for (int a = 0; a < SplitComma.Length; a++)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            if (Employee.ID.Equals(SplitComma[a].Split(':')[0].Trim()))
                            {
                                EmployeeIds += Employee.ID + ",";
                                break;
                            }
                        }
                    }
                    EmployeeIds = EmployeeIds.Substring(0, EmployeeIds.Length - 1);
                    EmployeeIds += "]";

                    try
                    {
                        DoneButton.Enabled = false;
                        CancelButton.Enabled = false;

                        RecordActivity($"Updated details of order with reference number [{GlobalOrderList.Count + 1}]");

                        SqlCommand Command = new SqlCommand($"UPDATE SET AUTOLANDIA_OrderList EmployeeIdList='{EmployeeIds}', ServiceIdList='{ServiceIds}', PackageId='', VehicleId='{RealVehicle.ID}', OrderProgress='{CB_Progress.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE OrderId='{GlobalOrderList.Count + 1}'", SQL);
                        SqlCommand Command1 = new SqlCommand($"UPDATE SET AUTOLANDIA_BillingList OrderBalance={RealPrice}, DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE BillingId='{GlobalOrderList.Count + 1}'", SQL);

                        Command.ExecuteNonQuery();
                        Command1.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully updated transaction details!", "Notice");
                        TransactionsForm.RefreshTransactions();
                        GlobalBillingForm.RefreshBillings();
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
            if (RB_Package.Checked)
            {
                if (string.IsNullOrEmpty(TB_Employee.Text))
                {
                    ErrorMessage += "Please select an employee.\n";
                }
                if (string.IsNullOrEmpty(TB_Vehicle.Text))
                {
                    ErrorMessage += "Please select a vehicle.\n";
                }
                if (ServiceList.Controls.Count == 0)
                {
                    ErrorMessage += "Please select a package.\n";
                }

                if (ErrorMessage.Equals(""))
                {
                    double RealPrice = 0;

                    VehicleItem RealVehicle = null;

                    foreach (VehicleItem Vehicle in GlobalVehicleList)
                    {
                        if (Vehicle.ID.Equals(TB_Vehicle.Text.Split(',')[0].Split(':')[0].Trim()))
                        {
                            RealVehicle = Vehicle;
                        }
                    }

                    string PackageId = string.Empty;

                    foreach (PackageItem Package in GlobalPackageList)
                    {
                        if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(RealVehicle.Size))
                        {
                            PackageId = Package.ID;
                            RealPrice += Package.Price;
                            break;
                        }
                    }

                    string EmployeeIds = "[";
                    string[] SplitComma = TB_Employee.Text.Split(',');
                    for (int a = 0; a < SplitComma.Length; a++)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            if (Employee.ID.Equals(SplitComma[a].Split(':')[0].Trim()))
                            {
                                EmployeeIds += Employee.ID + ",";
                                break;
                            }
                        }
                    }
                    EmployeeIds = EmployeeIds.Substring(0, EmployeeIds.Length - 1);
                    EmployeeIds += "]";

                    try
                    {
                        DoneButton.Enabled = false;
                        CancelButton.Enabled = false;

                        RecordActivity($"Updated details of order with reference number [{GlobalOrderList.Count + 1}]");

                        SqlCommand Command = new SqlCommand($"UPDATE SET AUTOLANDIA_OrderList EmployeeIdList='{EmployeeIds}', ServiceIdList='', PackageId='{PackageId}', VehicleId='{RealVehicle.ID}', OrderProgress='{CB_Progress.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE OrderId='{GlobalOrderList.Count + 1}'", SQL);
                        SqlCommand Command1 = new SqlCommand($"UPDATE SET AUTOLANDIA_BillingList OrderBalance={RealPrice}, DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE BillingId='{GlobalOrderList.Count + 1}'", SQL);

                        Command.ExecuteNonQuery();
                        Command1.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully updated transaction details!", "Notice");
                        TransactionsForm.RefreshTransactions();
                        GlobalBillingForm.RefreshBillings();
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
        }

        public void SetVehicle(string Vehicle)
        {
            TB_Vehicle.Text = Vehicle;
        }
    }
}
