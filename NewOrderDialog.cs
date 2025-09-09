using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewOrderDialog : MaterialForm
    {
        OrdersForm OrdersForm;
        public MaterialCheckedListBox.ItemsList Checkedboxes;
        VehicleItem SelectedVehicle;
        List<ServiceItem> Temp = new List<ServiceItem>();

        public NewOrderDialog(OrdersForm OrdersForm)
        {
            InitializeComponent();
            this.OrdersForm = OrdersForm;

            RB_Service.Checked = true;
            PackageTable.Visible = false;
            PackageLabel.Visible = false;
            CB_Packages.Visible = false;

            //foreach (ServiceItem Service in ServiceList)
            //{
            //    Temp.Add(Service);
            //}
            //Temp.Reverse();

            //List<EmployeeItem> TempEmployeeList = new List<EmployeeItem>(EmployeeList);
            //TempEmployeeList.Sort(new EmployeeItemComparer());

            //foreach (EmployeeItem Employee in TempEmployeeList)
            //{
            //    if (DateTime.Parse(Employee.DateRecorded).ToString("d").Equals(DateTime.Now.Date.ToString("d")) &&
            //        !Employee.TimeIn.Equals("") && Employee.TimeOut.Equals(""))
            //    {
            //        CB_Employees.Items.Add(Employee.EmployeeName);
            //    }
            //}

            //List<PaymentMethodItem> TempPaymentMethodList = new List<PaymentMethodItem>(PaymentMethodList);
            //TempPaymentMethodList.Sort(new PaymentMethodItemComparer());

            //foreach (PaymentMethodItem Method in TempPaymentMethodList)
            //{
            //    CB_PaymentMethod.Items.Add(Method.Name);
            //}

            //List<VehicleItem> TempVehicleList = new List<VehicleItem>(VehicleList);
            //TempVehicleList.Sort(new VehicleItemComparer(4));

            //foreach (VehicleItem Vehicle in TempVehicleList)
            //{
            //    if (!Vehicle.CustomerName.Equals("(None)"))
            //    {
            //        CB_Vehicles.Items.Add(Vehicle.CustomerName + ", " + Vehicle.PlateNumber + ", " + Vehicle.Brand + ", " + Vehicle.Model);
            //    }
            //}

            //foreach (PackageItem Package in PackageList)
            //{
            //    if (!CB_Packages.Items.Contains(Package.Name))
            //    {
            //        CB_Packages.Items.Add(Package.Name);
            //    }
            //}
        }

        public void SetServices(MaterialCheckedListBox.ItemsList Checkboxes)
        {
            ServiceTable.Items.Clear();
            Checkedboxes = Checkboxes;
            Checkboxes.Reverse();
            foreach (MaterialCheckbox Item in Checkboxes)
            {
                if (Item.Checked)
                {
                    ServiceTable.Items.Add(Item.Text);
                }
            }
            RefreshPrice();
        }

        public void RefreshPrice()
        {
            double Price = 0;

            if (SelectedVehicle != null)
            {
                if (RB_Service.Checked)
                {
                    for (int a = 0; a < ServiceTable.Items.Count; a++)
                    {
                        foreach (ServiceItem Service in Temp)
                        {
                            if (ServiceTable.Items[a].Text.Equals(Service.Name) && Service.Size.Equals(SelectedVehicle.Size))
                            {
                                Price += Service.Price;
                                break;
                            }
                        }
                    }
                }

                if (RB_Package.Checked)
                {
                    //foreach (PackageItem Package in PackageList)
                    //{
                    //    if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(SelectedVehicle.Size))
                    //    {
                    //        Price += Package.Price;
                    //        break;
                    //    }
                    //}
                }
            }

            TB_Price.Text = Price.ToString();
        }

        private void SelectServicesButton_Click(object sender, EventArgs e)
        {
            new SelectServicesDialog(this).ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;

            string ErrorMessage = string.Empty;

            if (RB_Service.Checked)
            {
                if (CB_Employees.Text.Equals(""))
                {
                    ErrorMessage += "Please select an employee.\n";
                }
                if (CB_Vehicles.Text.Equals(""))
                {
                    ErrorMessage += "Please select a vehicle.\n";
                }
                if (ServiceTable.Items.Count == 0)
                {
                    ErrorMessage += "Please select at least one service.\n";
                }
                if (CB_PaymentMethod.Text.Equals(""))
                {
                    ErrorMessage += "Please select a payment method.\n";
                }

                if (ErrorMessage.Equals(""))
                {
                    string ServiceIds = "[";
                    for (int a = 0; a < ServiceTable.Items.Count; a++)
                    {
                        foreach (ServiceItem Service in Temp)
                        {
                            if (ServiceTable.Items[a].Text.Equals(Service.Name) && Service.Size.Equals(SelectedVehicle.Size))
                            {
                                ServiceIds += Service.ID + ", ";
                                break;
                            }
                        }
                    }
                    ServiceIds = ServiceIds.Substring(0, ServiceIds.Length - 2);
                    ServiceIds += "]";

                    try
                    {
                        DoneButton.Enabled = false;
                        CancelButton.Enabled = false;

                        //RecordActivity($"Added new order with reference number: {OrderList.Count + 1}");

                        //SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_OrderList(OrderId, EmployeeName, PlateNumber, ServiceIdList, PackageIdList, OrderBalance, PaymentMethodName, DateCreated) VALUES ('{OrderList.Count + 1}', '{CB_Employees.Text}', '{SelectedVehicle.PlateNumber}', '{ServiceIds}', '(None)', {TB_Price.Text}, '{CB_PaymentMethod.Text}', '{Today.ToString()}')", SQL);

                        //Command.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully added new order!", "Notice");
                        OrdersForm.RefreshOrders();
                        GlobalActivityRecordForm.RefreshActivities();
                        //GlobalHomeForm.RefreshHome();
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
                if (CB_Employees.Text.Equals(""))
                {
                    ErrorMessage += "Please select an employee.\n";
                }
                if (CB_Vehicles.Text.Equals(""))
                {
                    ErrorMessage += "Please select a vehicle.\n";
                }
                if (PackageTable.Items.Count == 0)
                {
                    ErrorMessage += "Please select a package.\n";
                }
                if (CB_PaymentMethod.Text.Equals(""))
                {
                    ErrorMessage += "Please select a payment method.\n";
                }

                if (ErrorMessage.Equals(""))
                {
                    string PackageId = string.Empty;

                    //foreach (PackageItem Package in PackageList)
                    //{
                    //    if (Package.Name.Equals(CB_Packages.Text) && Package.Size.Equals(SelectedVehicle.Size))
                    //    {
                    //        PackageId = Package.ID;
                    //        break;
                    //    }
                    //}

                    try
                    {
                        DoneButton.Enabled = false;
                        CancelButton.Enabled = false;

                        //RecordActivity($"Added new order with reference number: {OrderList.Count + 1}");

                        //SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_OrderList(OrderId, EmployeeName, PlateNumber, ServiceIdList, PackageIdList, OrderBalance, PaymentMethodName, DateCreated) VALUES ('{OrderList.Count + 1}', '{CB_Employees.Text}', '{SelectedVehicle.PlateNumber}', '(None)', '{PackageId}', {TB_Price.Text}, '{CB_PaymentMethod.Text}', '{Today.ToString()}')", SQL);

                        //Command.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully added new order!", "Notice");
                        OrdersForm.RefreshOrders();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RB_Service_Click(object sender, EventArgs e)
        {
            if (RB_Service.Checked)
            {
                TB_Price.Text = "0";
                ServiceTable.Visible = true;
                SelectServicesButton.Visible = true;
                PackageTable.Visible = false;
                PackageLabel.Visible = false;
                CB_Packages.Visible = false;
            }
        }

        private void RB_Package_Click(object sender, EventArgs e)
        {
            if (RB_Package.Checked)
            {
                TB_Price.Text = "0";
                ServiceTable.Visible = false;
                SelectServicesButton.Visible = false;
                PackageTable.Visible = true;
                PackageLabel.Visible = true;
                CB_Packages.Visible = true;
            }
        }

        private void CB_Vehicles_TextChanged(object sender, EventArgs e)
        {
            //foreach (VehicleItem Vehicle in VehicleList)
            //{
            //    if (CB_Vehicles.Text.Split(',')[0].Equals(Vehicle.CustomerName) && CB_Vehicles.Text.Split(',')[1].Trim().Equals(Vehicle.PlateNumber))
            //    {
            //        SelectedVehicle = Vehicle;
            //    }
            //}

            RefreshPrice();
        }

        private void CB_Packages_TextChanged(object sender, EventArgs e)
        {
            PackageTable.Items.Clear();

            //foreach (PackageItem Package in PackageList)
            //{
            //    if (Package.Name.Equals(CB_Packages.Text))
            //    {
            //        foreach (string Item in Package.Details.Split(','))
            //        {
            //            PackageTable.Items.Add(Item);
            //        }
            //        break;
            //    }
            //}

            RefreshPrice();
        }
    }
}
