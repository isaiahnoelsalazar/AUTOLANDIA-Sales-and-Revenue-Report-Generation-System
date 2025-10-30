using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class GlobalValues
    {
        //public static string hostname = "Data Source=sql.bsite.net\\MSSQL2016;";
        //public static string database = "Initial Catalog=saiasamazingaspsite_SampleDB;";
        //public static string username = "User ID=saiasamazingaspsite_SampleDB;";
        //public static string password = "Password=DBSamplePW;";
        //public static SqlConnection SQL = new SqlConnection(hostname + database + username + password);
        public static SqliteConnection SQL = new SqliteConnection("Data Source=AUTOLANDIA.db;");

        public static List<ServiceItem> GlobalServiceList = new List<ServiceItem>();
        public static List<ServiceItemDisplay> GlobalServiceDisplayList = new List<ServiceItemDisplay>();
        public static List<PackageItem> GlobalPackageList = new List<PackageItem>();
        public static List<PackageItemDisplay> GlobalPackageDisplayList = new List<PackageItemDisplay>();
        public static List<OrderItem> GlobalOrderList = new List<OrderItem>();
        public static List<BillingItem> GlobalBillingList = new List<BillingItem>();
        public static List<VehicleItem> GlobalVehicleList = new List<VehicleItem>();
        public static List<VehicleModelItem> GlobalVehicleModelList = new List<VehicleModelItem>();
        public static List<CustomerItem> GlobalCustomerList = new List<CustomerItem>();
        public static List<EmployeeItem> GlobalEmployeeList = new List<EmployeeItem>();
        public static List<EmployeeTimeItem> GlobalEmployeeTimeList = new List<EmployeeTimeItem>();
        public static List<string> GlobalPaymentMethodList = new List<string>();
        public static List<string> GlobalActivityList = new List<string>();

        public static HomeForm GlobalHomeForm;
        public static PeopleForm GlobalPeopleForm;
        public static ServicesAndPackagesForm GlobalServicesAndPackagesForm;
        public static TransactionsForm GlobalTransactionsForm;
        public static BillingForm GlobalBillingForm;
        public static ReportsForm GlobalReportsForm;
        public static ActivityRecordForm GlobalActivityRecordForm;

        public static void SET_SKIN(MaterialForm MaterialForm)
        {
            MaterialSkinManager SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(MaterialForm);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(0, 0, Primary.Grey500, 0, TextShade.WHITE);
        }

        public class EmployeeNameComparer : IComparer<EmployeeItem>
        {
            public int Compare(EmployeeItem a, EmployeeItem b)
            {
                return $"{a.LastName}, {a.FirstName} {a.MiddleName}".CompareTo($"{b.LastName}, {b.FirstName} {b.MiddleName}");
            }
        }

        public class VehicleBrandComparer : IComparer<VehicleModelItem>
        {
            public int Compare(VehicleModelItem a, VehicleModelItem b)
            {
                return a.Brand.CompareTo(b.Brand);
            }
        }

        public static void RecreateAllGlobalData()
        {
            try
            {
                RecreateGlobalPaymentMethodList();
                RecreateGlobalServiceList();
                RecreateGlobalPackageList();
                RecreateGlobalVehicleModelList();
                RecreateGlobalCustomerList();
                RecreateGlobalVehicleList();
                RecreateGlobalEmployeeList();
                RecreateGlobalEmployeeTimeList();
                RecreateGlobalOrderList();
                RecreateGlobalBillingList();
                RecreateGlobalActivityList();
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public static void RecreateGlobalPaymentMethodList()
        {
            GlobalPaymentMethodList.Clear();

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_PaymentMethodList ORDER BY PaymentMethodName ASC", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_PackageList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_ServiceList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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

        public static void RecreateGlobalServiceDisplayList()
        {
            GlobalServiceDisplayList.Clear();

            SqliteCommand Command = new SqliteCommand("SELECT\r\n  ServiceName AS Name,\r\n  COALESCE(MAX(CASE WHEN ServiceSize = 'S'   THEN ServicePrice END), -1) AS S,\r\n  COALESCE(MAX(CASE WHEN ServiceSize = 'M'   THEN ServicePrice END), -1) AS M,\r\n  COALESCE(MAX(CASE WHEN ServiceSize = 'L'   THEN ServicePrice END), -1) AS L,\r\n  COALESCE(MAX(CASE WHEN ServiceSize = 'XL'  THEN ServicePrice END), -1) AS XL,\r\n  COALESCE(MAX(CASE WHEN ServiceSize = 'XXL' THEN ServicePrice END), -1) AS XXL\r\nFROM\r\n  AUTOLANDIA_ServiceList\r\nGROUP BY\r\n  ServiceName;", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalServiceDisplayList.Add(new ServiceItemDisplay(Reader.GetString(0), Reader.GetDouble(1), Reader.GetDouble(2), Reader.GetDouble(3), Reader.GetDouble(4), Reader.GetDouble(5)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }

            List<ServiceItemDisplay> UpdatedServiceDisplayList = new List<ServiceItemDisplay>();

            foreach (ServiceItem Service in GlobalServiceList)
            {
                foreach (ServiceItemDisplay ServiceDisplay in GlobalServiceDisplayList)
                {
                    if (Service.Name.Equals(ServiceDisplay.Name) && !UpdatedServiceDisplayList.Contains(ServiceDisplay))
                    {
                        UpdatedServiceDisplayList.Add(ServiceDisplay);
                    }
                }
            }
            GlobalServiceDisplayList = UpdatedServiceDisplayList;
        }

        public static void RecreateGlobalPackageDisplayList()
        {
            GlobalPackageDisplayList.Clear();

            SqliteCommand Command = new SqliteCommand("SELECT\r\n  PackageName AS Name,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'S'   THEN PackageDetails END), '') AS Details,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'S'   THEN PackagePrice END), -1) AS S,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'M'   THEN PackagePrice END), -1) AS M,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'L'   THEN PackagePrice END), -1) AS L,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'XL'  THEN PackagePrice END), -1) AS XL,\r\n  COALESCE(MAX(CASE WHEN PackageSize = 'XXL' THEN PackagePrice END), -1) AS XXL\r\nFROM\r\n  AUTOLANDIA_PackageList\r\nGROUP BY\r\n  PackageName;", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalPackageDisplayList.Add(new PackageItemDisplay(Reader.GetString(0), Reader.GetString(1), Reader.GetDouble(2), Reader.GetDouble(3), Reader.GetDouble(4), Reader.GetDouble(5), Reader.GetDouble(6)));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }

            List<PackageItemDisplay> UpdatedPackageDisplayList = new List<PackageItemDisplay>();

            foreach (PackageItem Package in GlobalPackageList)
            {
                foreach (PackageItemDisplay PackageDisplay in GlobalPackageDisplayList)
                {
                    if (Package.Name.Equals(PackageDisplay.Name) && !UpdatedPackageDisplayList.Contains(PackageDisplay))
                    {
                        UpdatedPackageDisplayList.Add(PackageDisplay);
                    }
                }
            }
            GlobalPackageDisplayList = UpdatedPackageDisplayList;
        }

        public static void RecreateGlobalEmployeeList()
        {
            GlobalEmployeeList.Clear();

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_EmployeeList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalEmployeeList.Add(new EmployeeItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6)));
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_EmployeeTimeList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_CustomerList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalCustomerList.Add(new CustomerItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6)));
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_OrderList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalOrderList.Add(new OrderItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6), Reader.GetString(7), Reader.GetString(8)));
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_BillingList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        GlobalBillingList.Add(new BillingItem(Reader.GetString(0), Reader.GetDouble(1), Reader.GetDouble(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6), Reader.GetDouble(7)));
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

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_VehicleList", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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

        public static void RecreateGlobalVehicleModelList()
        {
            GlobalVehicleModelList.Clear();

            string[] AllVehicleModels = ConstantVehicleModelList.VehicleModelList.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string VehicleModel in AllVehicleModels)
            {
                string[] Split = VehicleModel.Split(':');
                GlobalVehicleModelList.Add(new VehicleModelItem(Split[0].Trim(), Split[1].Trim()));
            }
            GlobalVehicleModelList.Add(new VehicleModelItem("GENERAL", "EBIKE"));
            GlobalVehicleModelList.Add(new VehicleModelItem("GENERAL", "MOTOR"));
            GlobalVehicleModelList.Add(new VehicleModelItem("GENERAL", "PUV"));
            GlobalVehicleModelList.Add(new VehicleModelItem("GENERAL", "TRICYCLE"));
            GlobalVehicleModelList.Add(new VehicleModelItem("GENERAL", "TRUCK"));

            //
            // The feature below is currently disabled.
            // Regularly getting data from the database for vehicle models is causing performance issues.
            //

            //GlobalVehicleModelList.Clear();

            //SqliteCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_VehicleModelList ORDER BY VehicleBrand ASC", SQL);

            //try
            //{
            //    using (SqlDataReader Reader = Command.ExecuteReader())
            //    {
            //        while (Reader.Read())
            //        {
            //            GlobalVehicleModelList.Add(new VehicleModelItem(Reader.GetString(0), Reader.GetString(1)));
            //        }
            //    }
            //}
            //catch (Exception exception)
            //{
            //    MaterialMessageBox.Show(exception.Message, "Alert");
            //}
        }

        public static void RecreateGlobalActivityList()
        {
            GlobalActivityList.Clear();

            SqliteCommand Command = new SqliteCommand("SELECT * FROM AUTOLANDIA_ActivityList ORDER BY Message DESC", SQL);

            try
            {
                using (SqliteDataReader Reader = Command.ExecuteReader())
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
            SqliteCommand Command = new SqliteCommand($"INSERT INTO AUTOLANDIA_ActivityList(Message) VALUES ('{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}" + " - " + Message}')", SQL);

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
