using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class GlobalValues
    {
        public static string hostname = "Data Source=sql.bsite.net\\MSSQL2016;";
        public static string database = "Initial Catalog=saiasamazingaspsite_SampleDB;";
        public static string username = "User ID=saiasamazingaspsite_SampleDB;";
        public static string password = "Password=DBSamplePW;";
        public static SqlConnection SQL = new SqlConnection(hostname + database + username + password);

        public static List<ServiceItem> ServiceList = new List<ServiceItem>();
        public static List<PackageItem> PackageList = new List<PackageItem>();
        public static List<OrderItem> OrderList = new List<OrderItem>();
        public static List<VehicleItem> VehicleList = new List<VehicleItem>();
        public static List<CustomerItem> CustomerList = new List<CustomerItem>();
        public static List<EmployeeItem> EmployeeList = new List<EmployeeItem>();
        public static List<PaymentMethodItem> PaymentMethodList = new List<PaymentMethodItem>();
        public static List<string> ActivityList = new List<string>();

        public static HomeForm GlobalHomeForm;
        public static OrdersForm GlobalOrdersForm;
        public static VehiclesForm GlobalVehiclesForm;
        public static CustomersForm GlobalCustomersForm;
        public static EmployeesForm GlobalEmployeesForm;
        public static ActivityRecordForm GlobalActivityRecordForm;

        public static void SET_SKIN(MaterialForm MaterialForm)
        {
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(MaterialForm);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(0, 0, Primary.Grey500, 0, TextShade.WHITE);
        }

        public static void RecreateVehicleList()
        {
            VehicleList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_VehicleList", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        VehicleList.Add(new VehicleItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateOrderList()
        {
            OrderList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_OrderList", SQL);
            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        OrderList.Add(new OrderItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetDouble(5), Reader.GetString(6), Reader.GetString(7)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateCustomerList()
        {
            CustomerList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_CustomerList", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        CustomerList.Add(new CustomerItem(Reader.GetString(0), Reader.GetString(1)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateEmployeeList()
        {
            EmployeeList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_EmployeeList", SQL);

            List<string> EmployeeNames = new List<string>();
            DateTime LatestDate = new DateTime();

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        EmployeeNames.Add(Reader.GetString(0));
                        LatestDate = DateTime.Parse(Reader.GetString(3));
                        EmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
                    }
                }

                EmployeeList = EmployeeList.GroupBy(E => E.EmployeeName)
                    .Select(Group => Group.LastOrDefault())
                    .ToList();
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }

            if (DateTime.Now.Date.CompareTo(LatestDate) > 0)
            {
                EmployeeList.Clear();

                foreach (string Name in EmployeeNames)
                {
                    try
                    {
                        SqlCommand Command1 = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET TimeOut = '{LatestDate.Date.AddDays(1).AddMinutes(-1).ToString("g")}' WHERE CONVERT(VARCHAR, EmployeeName)='{Name}' AND CONVERT(VARCHAR, DateRecorded)='{LatestDate.ToString("d")}'", SQL);
                        SqlCommand Command2 = new SqlCommand($"INSERT INTO AUTOLANDIA_EmployeeList(EmployeeName, TimeIn, TimeOut, DateRecorded) VALUES ('{Name}', '', '', '{DateTime.Now.Date.ToString("d")}')", SQL);

                        Command1.ExecuteNonQuery();
                        Command2.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        MaterialMessageBox.Show(exception.Message, "Alert");
                    }
                }

                SqlCommand Command3 = new SqlCommand("SELECT * FROM AUTOLANDIA_EmployeeList", SQL);

                try
                {
                    using (SqlDataReader Reader = Command3.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            EmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
                        }
                    }

                    EmployeeList = EmployeeList.GroupBy(E => E.EmployeeName)
                        .Select(Group => Group.LastOrDefault())
                        .ToList();
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
                }
            }
        }

        public static void RecreateActivityList()
        {
            ActivityList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_ActivityList", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        ActivityList.Add(Reader.GetString(0));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecordActivity(string Message/*, Action Todo*/)
        {
            SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_ActivityList(Message) VALUES ('{DateTime.Now.ToString() + " - " + Message}')", SQL);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public class VehicleItem
        {
            string brand, model, size, plateNumber, customerName;

            public VehicleItem(string brand, string model, string size, string plateNumber, string customerName)
            {
                this.brand = brand;
                this.model = model;
                this.size = size;
                this.plateNumber = plateNumber;
                this.customerName = customerName;
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Size
            {
                get { return size; }
                set { size = value; }
            }

            public string PlateNumber
            {
                get { return plateNumber; }
                set { plateNumber = value; }
            }

            public string CustomerName
            {
                get { return customerName; }
                set { customerName = value; }
            }
        }

        public class CustomerItem
        {
            string name, plateNumbers;

            public CustomerItem(string name, string plateNumbers)
            {
                this.name = name;
                this.plateNumbers = plateNumbers;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string PlateNumbers
            {
                get { return plateNumbers; }
                set { plateNumbers = value; }
            }
        }

        public class PaymentMethodItem
        {
            string name;

            public PaymentMethodItem(string name)
            {
                this.name = name;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        public class EmployeeItem
        {
            string employeeName, timeIn, timeOut, dateRecorded;

            public EmployeeItem(string employeeName, string timeIn, string timeOut, string dateRecorded)
            {
                this.employeeName = employeeName;
                this.timeIn = timeIn;
                this.timeOut = timeOut;
                this.dateRecorded = dateRecorded;
            }

            public string EmployeeName
            {
                get { return employeeName; }
                set { employeeName = value; }
            }

            public string TimeIn
            {
                get { return timeIn; }
                set { timeIn = value; }
            }

            public string TimeOut
            {
                get { return timeOut; }
                set { timeOut = value; }
            }

            public string DateRecorded
            {
                get { return dateRecorded; }
                set { dateRecorded = value; }
            }
        }

        public class OrderItem
        {
            string orderId, employeeName, plateNumber, serviceIdList, packageIdList, paymentMethodName, dateCreated;
            double orderBalance;

            public OrderItem(string orderId, string employeeName, string plateNumber, string serviceIdList, string packageIdList, double orderBalance, string paymentMethodName, string dateCreated)
            {
                this.orderId = orderId;
                this.employeeName = employeeName;
                this.plateNumber = plateNumber;
                this.serviceIdList = serviceIdList;
                this.packageIdList = packageIdList;
                this.orderBalance = orderBalance;
                this.paymentMethodName = paymentMethodName;
                this.dateCreated = dateCreated;
            }

            public string OrderId
            {
                get { return orderId; }
                set { orderId = value; }
            }

            public string EmployeeName
            {
                get { return employeeName; }
                set { employeeName = value; }
            }

            public string PlateNumber
            {
                get { return plateNumber; }
                set { plateNumber = value; }
            }

            public string ServiceIdList
            {
                get { return serviceIdList; }
                set { serviceIdList = value; }
            }

            public string PackageIdList
            {
                get { return packageIdList; }
                set { packageIdList = value; }
            }

            public double OrderBalance
            {
                get { return orderBalance; }
                set { orderBalance = value; }
            }

            public string PaymentMethodName
            {
                get { return paymentMethodName; }
                set { paymentMethodName = value; }
            }

            public string DateCreated
            {
                get { return dateCreated; }
                set { dateCreated = value; }
            }
        }

        public class ServiceItem
        {
            string id, name, size;
            double price;

            public ServiceItem(string id, string name, string size, double price)
            {
                this.id = id;
                this.name = name;
                this.size = size;
                this.price = price;
            }

            public string ID
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Size
            {
                get { return size; }
                set { size = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }
        }

        public class PackageItem
        {
            string id, name, details, size;
            double price;

            public PackageItem(string id, string name, string details, string size, double price)
            {
                this.id = id;
                this.name = name;
                this.details = details;
                this.size = size;
                this.price = price;
            }

            public string ID
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Details
            {
                get { return details; }
                set { details = value; }
            }

            public string Size
            {
                get { return size; }
                set { size = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }
        }
    }
}
