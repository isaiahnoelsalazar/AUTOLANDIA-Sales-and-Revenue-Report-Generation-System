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
        public static List<BillingItem> GlobalBillingList = new List<BillingItem>();
        public static List<VehicleItem> GlobalVehicleList = new List<VehicleItem>();
        public static List<CustomerItem> GlobalCustomerList = new List<CustomerItem>();
        public static List<EmployeeItem> GlobalEmployeeList = new List<EmployeeItem>();
        public static List<EmployeeTimeItem> GlobalEmployeeTimeList = new List<EmployeeTimeItem>();
        public static List<string> GlobalPaymentMethodList = new List<string>();
        public static List<string> GlobalActivityList = new List<string>();

        public static HomeForm GlobalHomeForm;
        public static PeopleForm GlobalPeopleForm;
        public static ServicesAndPackagesForm GlobalServicesAndPackagesForm;
        public static BillingForm GlobalBillingForm;
        public static ActivityRecordForm GlobalActivityRecordForm;

        public static void SET_SKIN(MaterialForm MaterialForm)
        {
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(MaterialForm);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(0, 0, Primary.Grey500, 0, TextShade.WHITE);
        }

        public class EmployeeNameComparer : IComparer<EmployeeItem>
        {
            public int Compare(EmployeeItem a, EmployeeItem b)
            {
                return a.Name.CompareTo(b.Name);
            }
        }

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

        public static void RecreateGlobalOrderList()
        {
            GlobalOrderList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_OrderList ORDER BY OrderId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalOrderList.Add(new OrderItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6), Reader.GetString(7)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalBillingList()
        {
            GlobalBillingList.Clear();

            SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_BillingList ORDER BY BillingId ASC", SQL);

            try
            {
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalBillingList.Add(new BillingItem(Reader.GetString(0), Reader.GetDouble(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5)));
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
