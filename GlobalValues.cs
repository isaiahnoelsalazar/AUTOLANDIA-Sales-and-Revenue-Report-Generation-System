using MaterialSkin;
using MaterialSkin.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class GlobalValues
    {
        public static List<VehicleItem> VehicleList = new List<VehicleItem>();
        public static List<CustomerItem> CustomerList = new List<CustomerItem>();
        public static List<PaymentMethodItem> PaymentMethodList = new List<PaymentMethodItem>();

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

            try
            {
                string Value = GetValues("SELECT * FROM AUTOLANDIA_VehicleList");
                if (!Value.Equals("None"))
                {
                    string[] Values = Value.Split(new string[] { "row:" }, StringSplitOptions.None);
                    for (int a = 0; a < Values.Length; a++)
                    {
                        string[] Split = Values[a].Split(';');
                        VehicleList.Add(new VehicleItem(Split[0].Split('=')[1], Split[1].Split('=')[1], Split[2].Split('=')[1], Split[3].Split('=')[1], Split[4].Split('=')[1]));
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

            try
            {
                string Value = GetValues("SELECT * FROM AUTOLANDIA_CustomerList");
                if (!Value.Equals("None"))
                {
                    string[] Values = Value.Split(new string[] { "row:" }, StringSplitOptions.None);
                    for (int a = 0; a < Values.Length; a++)
                    {
                        string[] Split = Values[a].Split(';');
                        CustomerList.Add(new CustomerItem(Split[0].Split('=')[1], Split[1].Split('=')[1]));
                    }
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
            }
        }

        public class Do
        {
            Thread Thread;
            bool IsDone = false;

            public Do(Action Action)
            {
                Thread = new Thread(new ThreadStart(() =>
                {
                    Action();
                    IsDone = true;
                }));
                Thread.Start();
            }

            public Do(Action Action, int Delay)
            {
                Thread.Sleep(Delay);
                Thread = new Thread(new ThreadStart(() =>
                {
                    Action();
                    IsDone = true;
                }));
                Thread.Start();
            }

            public void AfterDo(Action Action)
            {
                System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
                Timer.Interval = 1;
                Timer.Tick += (s, e) =>
                {
                    if (IsDone)
                    {
                        Timer.Stop();
                        Action();
                    }
                };
                Timer.Start();
            }
        }

        public static string GetValues(string Query)
        {
            string Response = string.Empty;
            using (IWebDriver Driver = SeleniumDriver())
            {
                Driver.Navigate().GoToUrl("https://remotephpmysqldbaccess.wuaze.com/get.php?get=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Query)));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                Response = (string)js.ExecuteScript("return document.body.innerText");
                Driver.Quit();
            }
            return Response.Equals("None") ? "None" : Response.Substring(4);
        }

        public static void NewQuery(string Query)
        {
            using (IWebDriver Driver = SeleniumDriver())
            {
                Driver.Navigate().GoToUrl("https://remotephpmysqldbaccess.wuaze.com/query.php?query=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Query)));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                string Response = (string)js.ExecuteScript("return document.body.innerText");
                Driver.Quit();
            }
        }

        static IWebDriver SeleniumDriver()
        {
            var DriverService = ChromeDriverService.CreateDefaultService();
            DriverService.HideCommandPromptWindow = true;
            var Options = new ChromeOptions();
            Options.AddArgument("--headless");
            Options.AddArgument("--disable-gpu");
            Options.AddArgument("--no-sandbox");
            Options.AddArgument("--disable-dev-shm-usage");
            return new ChromeDriver(DriverService, Options);
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
    }
}
