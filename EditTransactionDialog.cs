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
    public partial class EditTransactionDialog : MaterialForm
    {
        TransactionsForm TransactionsForm;
        public MaterialCheckedListBox.ItemsList ServiceCheckedboxes, EmployeeCheckedboxes, ExtraCheckedboxes;
        Color DefaultBackgroundColor;
        string OrderID;
        double ServicePrice = 0;
        List<string> ExtraList = new List<string>();

        public EditTransactionDialog(TransactionsForm TransactionsForm, string OrderID)
        {
            InitializeComponent();

            this.TransactionsForm = TransactionsForm;
            this.OrderID = OrderID;

            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();
            SelectServicesButton.Visible = true;

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (!CB_Packages.Items.Contains(Package.Name))
                {
                    CB_Packages.Items.Add(Package.Name);
                }
            }

            ExtraList.Add("Perfume (150)");
            ExtraList.Add("Car w/ Carrier (20)");

            foreach (string Item in ExtraList)
            {
                ExtraListCheckBox.Items.Add(Item);
            }
        }

        public void SetEmployees(MaterialCheckedListBox.ItemsList EmployeeCheckboxes)
        {
            TB_Employee.Text = string.Empty;

            EmployeeCheckedboxes = EmployeeCheckboxes;

            for (int a = EmployeeCheckedboxes.Count - 1; a > -1; a--)
            {
                if (EmployeeCheckedboxes[a].Checked)
                {
                    foreach (EmployeeItem Employee in GlobalEmployeeList)
                    {
                        string EmployeeDetail = $"{Employee.ID}: {Employee.LastName}, {Employee.FirstName} {Employee.MiddleName}";
                        if (Employee.ID.Equals(EmployeeCheckedboxes[a].Text.Split(':')[0].Trim()))
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

            ServicePrice = 0;

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
            catch { }

            PackageItem RealPackage = null;

            if (!string.IsNullOrEmpty(CB_Packages.Text))
            {
                foreach (PackageItem Package in GlobalPackageList)
                {
                    if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                    {
                        RealPackage = Package;
                        break;
                    }
                }
            }

            if (RealPackage != null)
            {
                for (int a = ServiceCheckedboxes.Count - 1; a > -1; a--)
                {
                    foreach (string Item in RealPackage.Details.Split(','))
                    {
                        if (ServiceCheckedboxes[a].Text.Contains(Item))
                        {
                            ServiceCheckedboxes[a].Checked = false;
                        }
                    }
                }
            }

            for (int a = ServiceCheckedboxes.Count - 1; a > -1; a--)
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
                            ServicePrice += Service.Price;
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

            if (!string.IsNullOrEmpty(CB_Packages.Text))
            {
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

            ServicePrice = 0;

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
            catch { }

            PackageItem RealPackage = null;

            if (!string.IsNullOrEmpty(CB_Packages.Text))
            {
                foreach (PackageItem Package in GlobalPackageList)
                {
                    if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
                    {
                        RealPackage = Package;
                        break;
                    }
                }
            }

            if (RealPackage != null)
            {
                if (ServiceCheckedboxes != null)
                {
                    for (int a = ServiceCheckedboxes.Count - 1; a > -1; a--)
                    {
                        foreach (string Item in RealPackage.Details.Split(','))
                        {
                            if (ServiceCheckedboxes[a].Text.Contains(Item))
                            {
                                ServiceCheckedboxes[a].Checked = false;
                            }
                        }
                    }
                }
            }

            if (ServiceCheckedboxes != null)
            {
                List<MaterialCheckbox> Temp = ServiceCheckedboxes.ToList();
                Temp.Reverse();

                for (int a = Temp.Count - 1; a > -1; a--)
                {
                    if (Temp[a].Checked)
                    {
                        foreach (ServiceItem Service in GlobalServiceList)
                        {
                            if (Service.Name.Equals(Temp[a].Text) && Service.Size.Equals(RealVehicle != null ? RealVehicle.Size : "S"))
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
                                ServicePrice += Service.Price;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;

            string ErrorMessage = string.Empty;

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
                ErrorMessage += "Please select at least one service or a package.\n";
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
                            break;
                        }
                    }
                }
                ServiceIds = ServiceIds.Substring(0, ServiceIds.Length - 1);
                ServiceIds += "]";

                RealPrice += ServicePrice;

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

                    RecordActivity($"Updated details of order with reference number [{OrderID}]");

                    SqliteCommand Command = new SqliteCommand($"UPDATE AUTOLANDIA_OrderList SET EmployeeIdList='{EmployeeIds}', ServiceIdList='{ServiceIds}', PackageId='{PackageId}', VehicleId='{RealVehicle.ID}', OrderProgress='{CB_Progress.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE OrderId='{OrderID}'", SQL);
                    SqliteCommand Command1 = new SqliteCommand($"UPDATE AUTOLANDIA_BillingList SET OrderBalance={RealPrice}, DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE BillingId='{OrderID}'", SQL);

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

        private void EditTransactionDialog_Load(object sender, EventArgs e)
        {
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

                    if (RealVehicle != null)
                    {
                        if (RealVehicle.Brand.Equals("GENERAL"))
                        {
                            PackageLabel.Visible = false;
                            CB_Packages.Visible = false;
                        }
                        else
                        {
                            PackageLabel.Visible = true;
                            CB_Packages.Visible = true;
                        }
                    }

                    if (RealVehicle.Brand.Equals("GENERAL"))
                    {
                        if (!string.IsNullOrEmpty(Order.ServiceIDList))
                        {
                            string[] ServiceSplit = Order.ServiceIDList.Substring(1, Order.ServiceIDList.Length - 2).Split(',');
                            List<ServiceItem> Temp = new List<ServiceItem>();
                            Temp.Add(new ServiceItem("S_VCBW1", "Body Wash", "S", 120));
                            Temp.Add(new ServiceItem("S_VCBW2", "Body Wash", "M", 150));
                            Temp.Add(new ServiceItem("S_VCBW3", "Body Wash", "L", 200));
                            Temp.Add(new ServiceItem("S_VCBWT", "Body Wash", "M", 220));
                            Temp.Add(new ServiceItem("S_VCBWP", "Body Wash", "M", 400));
                            Temp.Add(new ServiceItem("S_VCA1", "Armor", "S", 100));
                            Temp.Add(new ServiceItem("S_VCA2", "Armor", "M", 100));
                            Temp.Add(new ServiceItem("S_VCA3", "Armor", "L", 100));
                            Temp.Add(new ServiceItem("S_VCW1", "Wax (Manual)", "S", 150));
                            Temp.Add(new ServiceItem("S_VCW2", "Wax (Manual)", "M", 150));
                            Temp.Add(new ServiceItem("S_VCW3", "Wax (Manual)", "L", 150));
                            foreach (string ServiceID in ServiceSplit)
                            {
                                foreach (ServiceItem Service in Temp)
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
                        if (!string.IsNullOrEmpty(Order.PackageID))
                        {
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
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Order.ServiceIDList))
                        {
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
                        if (!string.IsNullOrEmpty(Order.PackageID))
                        {
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
                    }

                    

                    CB_Progress.Items.Add("Ready");
                    CB_Progress.Items.Add("In progress");
                    CB_Progress.Items.Add("Complete");
                    CB_Progress.Items.Add("Cancelled");

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
                    if (Order.Progress.Equals("Cancelled"))
                    {
                        CB_Progress.SelectedIndex = 3;
                    }

                    foreach (char Item in Order.Extras)
                    {
                        for (int a = 0; a < ExtraListCheckBox.Items.Count; a++)
                        {
                            if (ExtraListCheckBox.Items[a].Text.First().Equals(Item))
                            {
                                ExtraListCheckBox.Items[a].Checked = true;
                            }
                        }
                    }

                    string[] Split = Order.EmployeeIDList.Substring(1, Order.EmployeeIDList.Length - 2).Split(',');
                    foreach (string EmployeeId in Split)
                    {
                        foreach (EmployeeItem Employee in GlobalEmployeeList)
                        {
                            string EmployeeDetail = $"{Employee.ID}: {Employee.LastName}, {Employee.FirstName} {Employee.MiddleName}";
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

        public void SetVehicle(string Vehicle)
        {
            TB_Vehicle.Text = Vehicle;
        }
    }
}
