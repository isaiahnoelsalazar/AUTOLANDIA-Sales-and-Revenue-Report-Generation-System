using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class Startup : MaterialForm
    {
        Timer Timer = new Timer();

        public Startup()
        {
            InitializeComponent();

            SET_SKIN(this);

            Timer.Interval = 1000;
            Timer.Tick += (s, e) =>
            {
                try
                {
                    string Value = GetValues("SELECT * FROM AUTOLANDIA_PaymentMethodList");
                    if (!Value.Equals("None"))
                    {
                        string[] Values = Value.Split(new string[] { "row:" }, StringSplitOptions.None);
                        for (int a = 0; a < Values.Length; a++)
                        {
                            PaymentMethodList.Add(new PaymentMethodItem(Values[a].Split('=')[1].Replace(";", "")));
                        }
                    }

                    RecreateVehicleList();

                    //query = "";
                    //NewQuery(query);

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
    }
}
