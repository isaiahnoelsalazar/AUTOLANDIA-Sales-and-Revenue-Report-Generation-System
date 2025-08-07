using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class MainForm : MaterialForm
    {
        bool TabMove = false;
        Point PanelLocation, CursorPosition;
        List<Form> Forms = new List<Form>()
        {
            new HomeForm(),
            new OrdersForm(),
            new VehiclesForm(),
            new CustomersForm()
        };
        List<MaterialButton> TabButtons = new List<MaterialButton>();

        public MainForm(Startup Startup)
        {
            InitializeComponent();

            Startup.Hide();

            Logo.Image = Resources.autolandia_logo;
            Logo.BackColor = Color.Black;
            TabPanel.BackColor = Color.Black;

            TabButtons.Add(HomeTab);
            TabButtons.Add(OrdersTab);
            TabButtons.Add(VehiclesTab);
            TabButtons.Add(CustomersTab);

            GlobalOrdersForm = (OrdersForm)Forms[1];
            GlobalVehiclesForm = (VehiclesForm)Forms[2];
            GlobalCustomersForm = (CustomersForm)Forms[3];

            SelectTab(0);

            Timer FocusTimer = new Timer();
            FocusTimer.Tick += (s, e) =>
            {
                HomeTab.Focus();
                FocusTimer.Stop();
            };
            FocusTimer.Start();
        }

        void SelectTab(int Index)
        {
            foreach (Form Form in Forms)
            {
                Form.SendToBack();
            }
            Forms[Index].MdiParent = this;
            Forms[Index].Dock = DockStyle.Fill;
            if (Forms[Index].Visible)
            {
                Forms[Index].BringToFront();
            }
            else
            {
                Forms[Index].Show();
            }
            
            foreach (Control Control in Forms[Index].Controls)
            {
                Control.GotFocus += (s1, e1) =>
                {
                    TabButtons[Index].Focus();
                };
            }

            TabButtons[Index].Focus();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            SelectTab(0);
        }

        private void OrdersTab_Click(object sender, EventArgs e)
        {
            SelectTab(1);
        }

        private void VehiclesTab_Click(object sender, EventArgs e)
        {
            SelectTab(2);
        }

        private void CustomersTab_Click(object sender, EventArgs e)
        {
            SelectTab(3);
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            TabMove = true;
            PanelLocation = Location;
            CursorPosition = Cursor.Position;
        }

        private void Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (TabMove)
            {
                Location = new Point(MousePosition.X - (CursorPosition.X - PanelLocation.X), MousePosition.Y - (CursorPosition.Y - PanelLocation.Y));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Logo_MouseUp(object sender, MouseEventArgs e)
        {
            TabMove = false;
        }
    }
}
