using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class GlobalValues
    {
        public static string hostname = "Data Source=sql.bsite.net\\MSSQL2016;";
        public static string database = "Initial Catalog=saiasamazingaspsite_SampleDB;";
        public static string username = "User ID=saiasamazingaspsite_SampleDB;";
        public static string password = "Password=DBSamplePW;";
        public static SqlConnection SQL = new SqlConnection(hostname + database + username + password);

        public static List<ServiceItem> GlobalServiceList = new List<ServiceItem>();
        public static List<PackageItem> GlobalPackageList = new List<PackageItem>();
        public static List<OrderItem> GlobalOrderList = new List<OrderItem>();
        public static List<VehicleItem> GlobalVehicleList = new List<VehicleItem>();
        public static List<CustomerItem> GlobalCustomerList = new List<CustomerItem>();
        public static List<EmployeeItem> GlobalEmployeeList = new List<EmployeeItem>();
        public static List<EmployeeTimeItem> GlobalEmployeeTimeList = new List<EmployeeTimeItem>();
        public static List<string> GlobalPaymentMethodList = new List<string>();
        public static List<string> GlobalActivityList = new List<string>();

        public static HomeForm GlobalHomeForm;
        public static PeopleForm GlobalPeopleForm;
        public static ServicesAndPackagesForm GlobalServicesAndPackagesForm;
        public static ActivityRecordForm GlobalActivityRecordForm;

        public static void SET_SKIN(MaterialForm MaterialForm)
        {
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(MaterialForm);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(0, 0, Primary.Grey500, 0, TextShade.WHITE);
        }

        public class PaymentMethodItemComparer : IComparer<string>
        {
            public int Compare(string a, string b)
            {
                return a.CompareTo(b);
            }
        }

        //public class EmployeeItemComparer : IComparer<EmployeeItem>
        //{
        //    public int Compare(EmployeeItem a, EmployeeItem b)
        //    {
        //        return a.EmployeeName.CompareTo(b.EmployeeName);
        //    }
        //}

        public class CustomerItemComparer : IComparer<CustomerItem>
        {
            int Type;

            public CustomerItemComparer(int Type)
            {
                this.Type = Type;
            }

            public int Compare(CustomerItem a, CustomerItem b)
            {
                switch (Type)
                {
                    case 0:
                        return a.Name.CompareTo(b.Name);
                    case 1:
                        return a.PlateNumbers.Equals("(None)") && b.PlateNumbers.Equals("(None)") ? a.Name.CompareTo(b.Name) : a.PlateNumbers.CompareTo(b.PlateNumbers);
                    default:
                        return 0;
                }
            }
        }

        public class VehicleItemComparer : IComparer<VehicleItem>
        {
            int Type;

            public VehicleItemComparer(int Type)
            {
                this.Type = Type;
            }

            public int Compare(VehicleItem a, VehicleItem b)
            {
                switch (Type)
                {
                    case 0:
                        return a.Brand.CompareTo(b.Brand);
                    case 1:
                        return a.Model.CompareTo(b.Model);
                    case 2:
                        return a.Size.CompareTo(b.Size);
                    case 3:
                        return a.PlateNumber.CompareTo(b.PlateNumber);
                    //case 4:
                    //    return a.CustomerName.Equals("(None)") && b.CustomerName.Equals("(None)") ? a.Brand.CompareTo(b.Brand) : a.CustomerName.CompareTo(b.CustomerName);
                    default:
                        return 0;
                }
            }
        }

        //public class OrderItemComparer : IComparer<OrderItem>
        //{
        //    int Type;

        //    public OrderItemComparer(int Type)
        //    {
        //        this.Type = Type;
        //    }

        //    public int Compare(OrderItem a, OrderItem b)
        //    {
        //        switch (Type)
        //        {
        //            case 0:
        //                return a.OrderId.CompareTo(b.OrderId);
        //            case 1:
        //                return a.EmployeeName.CompareTo(b.EmployeeName);
        //            case 2:
        //                return a.PlateNumber.CompareTo(b.PlateNumber);
        //            case 3:
        //                return a.ServiceIdList.Equals("(None)") && b.ServiceIdList.Equals("(None)") ? a.OrderId.CompareTo(b.OrderId) : a.ServiceIdList.CompareTo(b.ServiceIdList);
        //            case 4:
        //                return a.PackageIdList.Equals("(None)") && b.PackageIdList.Equals("(None)") ? a.OrderId.CompareTo(b.OrderId) : a.PackageIdList.CompareTo(b.PackageIdList);
        //            case 5:
        //                return a.OrderBalance.CompareTo(b.OrderBalance);
        //            case 6:
        //                return a.PaymentMethodName.CompareTo(b.PaymentMethodName);
        //            case 7:
        //                return a.DateCreated.CompareTo(b.DateCreated);
        //            default:
        //                return 0;
        //        }
        //    }
        //}

        //public static void RecreateVehicleList()
        //{
        //    VehicleList.Clear();

        //    SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_VehicleList", SQL);

        //    try
        //    {
        //        using (SqlDataReader Reader = Command.ExecuteReader())
        //        {
        //            while (Reader.Read())
        //            {
        //                VehicleList.Add(new VehicleItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4)));
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MaterialMessageBox.Show(exception.Message, "Alert");
        //    }
        //}

        //public static void RecreateOrderList()
        //{
        //    OrderList.Clear();

        //    SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_OrderList", SQL);
        //    try
        //    {
        //        using (SqlDataReader Reader = Command.ExecuteReader())
        //        {
        //            while (Reader.Read())
        //            {
        //                OrderList.Add(new OrderItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetDouble(5), Reader.GetString(6), Reader.GetString(7)));
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MaterialMessageBox.Show(exception.Message, "Alert");
        //    }
        //}

        //public static void RecreateEmployeeList()
        //{
        //    EmployeeList.Clear();

        //    SqlCommand Command = new SqlCommand("SELECT DISTINCT CAST(EmployeeName AS nvarchar(MAX)), CAST(TimeIn AS nvarchar(MAX)), CAST(TimeOut AS nvarchar(MAX)), CAST(DateRecorded AS nvarchar(MAX)) FROM AUTOLANDIA_EmployeeList", SQL);

        //    List<string> EmployeeNames = new List<string>();
        //    DateTime LatestDate = new DateTime();

        //    try
        //    {
        //        using (SqlDataReader Reader = Command.ExecuteReader())
        //        {
        //            while (Reader.Read())
        //            {
        //                EmployeeNames.Add(Reader.GetString(0));
        //                LatestDate = DateTime.Parse(Reader.GetString(3));
        //                //EmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
        //            }
        //        }

        //        EmployeeList = EmployeeList.GroupBy(E => E.EmployeeName)
        //            .Select(Group => Group.LastOrDefault())
        //            .ToList();
        //    }
        //    catch (Exception exception)
        //    {
        //        MaterialMessageBox.Show(exception.Message, "Alert");
        //    }

        //    if (DateTime.Now.Date.CompareTo(LatestDate) > 0)
        //    {
        //        EmployeeList.Clear();

        //        foreach (string Name in EmployeeNames)
        //        {
        //            try
        //            {
        //                SqlCommand Command1 = new SqlCommand($"UPDATE AUTOLANDIA_EmployeeList SET TimeOut = '{LatestDate.Date.AddDays(1).AddMinutes(-1).ToString("g")}' WHERE CONVERT(VARCHAR, EmployeeName)='{Name}' AND CONVERT(VARCHAR, DateRecorded)='{LatestDate.ToString("d")}'", SQL);
        //                SqlCommand Command2 = new SqlCommand($"INSERT INTO AUTOLANDIA_EmployeeList(EmployeeName, TimeIn, TimeOut, DateRecorded) VALUES ('{Name}', '', '', '{DateTime.Now.Date.ToString("d")}')", SQL);

        //                Command1.ExecuteNonQuery();
        //                Command2.ExecuteNonQuery();
        //            }
        //            catch (Exception exception)
        //            {
        //                MaterialMessageBox.Show(exception.Message, "Alert");
        //            }
        //        }

        //        SqlCommand Command3 = new SqlCommand("SELECT * FROM AUTOLANDIA_EmployeeList", SQL);

        //        try
        //        {
        //            using (SqlDataReader Reader = Command3.ExecuteReader())
        //            {
        //                while (Reader.Read())
        //                {
        //                    //EmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
        //                }
        //            }

        //            EmployeeList = EmployeeList.GroupBy(E => E.EmployeeName)
        //                .Select(Group => Group.LastOrDefault())
        //                .ToList();
        //        }
        //        catch (Exception exception)
        //        {
        //            MaterialMessageBox.Show(exception.Message, "Alert");
        //        }
        //    }
        //}

        public static void RecreateGlobalPaymentMethodList()
        {
            GlobalPaymentMethodList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_PaymentMethodList ORDER BY PaymentMethodName ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalPaymentMethodList.Add(Reader.GetString(0));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalPackageList()
        {
            GlobalPackageList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_PackageList", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalPackageList.Add(new PackageItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetDouble(4)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalServiceList()
        {
            GlobalServiceList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_ServiceList", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalServiceList.Add(new ServiceItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetDouble(3)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalEmployeeList()
        {
            GlobalEmployeeList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_EmployeeList ORDER BY EmployeeId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalEmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalEmployeeTimeList()
        {
            GlobalEmployeeTimeList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_EmployeeTimeList ORDER BY EmployeeId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalEmployeeTimeList.Add(new EmployeeTimeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalCustomerList()
        {
            GlobalCustomerList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_CustomerList ORDER BY CustomerId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalCustomerList.Add(new CustomerItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalVehicleList()
        {
            GlobalVehicleList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_VehicleList ORDER BY VehicleId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalVehicleList.Add(new VehicleItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalActivityList()
        {
            GlobalActivityList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_ActivityList ORDER BY Message DESC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalActivityList.Add(Reader.GetString(0));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecordActivity(string Message)
        {
            DateTime Now = DateTime.Now;
            SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_ActivityList(Message) VALUES ('{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}" + " - " + Message}')", SQL);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }
    }
}
