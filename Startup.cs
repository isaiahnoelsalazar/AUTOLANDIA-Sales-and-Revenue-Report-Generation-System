using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class Startup : MaterialForm
    {
        Timer Timer = new Timer();
        bool TabMove = false;
        Point PanelLocation, CursorPosition;

        public Startup()
        {
            InitializeComponent();

            SET_SKIN(this);

            Banner.Image = Resources.autolandia_logo;
            Banner.BackColor = Color.Black;

            Timer.Interval = 1000;
            Timer.Tick += (s, e) =>
            {
                try
                {
                    SQL.Open();

                    SqlCommand Command1 = new SqlCommand("SELECT * FROM AUTOLANDIA_PaymentMethodList", SQL);
                    SqlCommand Command2 = new SqlCommand("SELECT * FROM AUTOLANDIA_ServiceList", SQL);
                    SqlCommand Command3 = new SqlCommand("SELECT * FROM AUTOLANDIA_PackageList", SQL);

                    using (SqlDataReader Reader = Command1.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            PaymentMethodList.Add(new PaymentMethodItem(Reader.GetString(0)));
                        }
                    }

                    ProgressBar.Increment(5);

                    using (SqlDataReader Reader = Command2.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ServiceList.Add(new ServiceItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetDouble(3)));
                        }
                        ServiceList.Reverse();
                    }

                    ProgressBar.Increment(5);

                    using (SqlDataReader Reader = Command3.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            PackageList.Add(new PackageItem(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetDouble(4)));
                        }
                    }

                    ProgressBar.Increment(10);

                    RecreateOrderList();
                    ProgressBar.Increment(10);

                    RecreateVehicleList();
                    ProgressBar.Increment(10);

                    RecreateCustomerList();
                    ProgressBar.Increment(20);

                    RecreateEmployeeList();
                    ProgressBar.Increment(20);

                    RecreateActivityList();
                    ProgressBar.Increment(20);

                    Timer.Stop();
                    new MainForm(this).Show();
                }
                catch (Exception exception)
                {
                    Timer.Stop();
                    MaterialMessageBox.Show(exception.Message, "Alert");
                    Application.Exit();
                }
            };
            Timer.Start();
        }

        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Banner_MouseDown(object sender, MouseEventArgs e)
        {
            TabMove = true;
            PanelLocation = Location;
            CursorPosition = Cursor.Position;
        }

        private void Banner_MouseMove(object sender, MouseEventArgs e)
        {
            if (TabMove)
            {
                Location = new Point(MousePosition.X - (CursorPosition.X - PanelLocation.X), MousePosition.Y - (CursorPosition.Y - PanelLocation.Y));
            }
        }

        private void Banner_MouseUp(object sender, MouseEventArgs e)
        {
            TabMove = false;
        }
    }
}
