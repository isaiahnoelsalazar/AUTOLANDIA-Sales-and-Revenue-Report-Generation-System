using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
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

                    SqlCommand Command = new SqlCommand("SELECT * FROM AUTOLANDIA_PaymentMethodList", SQL);

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            PaymentMethodList.Add(new PaymentMethodItem(Reader.GetString(0)));
                        }
                    }

                    ProgressBar.Increment(25);

                    //new Do(() =>
                    //{
                    //    string Value = GetValues("SELECT * FROM AUTOLANDIA_PaymentMethodList");
                    //    if (!Value.Equals("None"))
                    //    {
                    //        string[] Values = Value.Split(new string[] { "row:" }, StringSplitOptions.None);
                    //        for (int a = 0; a < Values.Length; a++)
                    //        {
                    //            PaymentMethodList.Add(new PaymentMethodItem(Values[a].Split('=')[1].Replace(";", "")));
                    //        }
                    //    }
                    //})
                    //.AfterDo(() =>
                    //{
                    //    ProgressBar.Increment(100);

                    //    new Do(() =>
                    //    {
                    //        // nothing
                    //    }, 1000)
                    //    .AfterDo(() =>
                    //    {
                    //        new MainForm(this).Show();
                    //    });

                    //    //new Do(() =>
                    //    //{
                    //    //    RecreateVehicleList();
                    //    //})
                    //    //.AfterDo(() =>
                    //    //{
                    //    //    ProgressBar.Increment(33);

                    //    //    new Do(() =>
                    //    //    {
                    //    //        RecreateCustomerList();
                    //    //    })
                    //    //    .AfterDo(() =>
                    //    //    {
                    //    //        ProgressBar.Increment(34);


                    //    //    });
                    //    //});
                    //});

                    RecreateVehicleList();
                    ProgressBar.Increment(25);

                    RecreateCustomerList();
                    ProgressBar.Increment(25);

                    RecreateActivityList();
                    ProgressBar.Increment(25);

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
