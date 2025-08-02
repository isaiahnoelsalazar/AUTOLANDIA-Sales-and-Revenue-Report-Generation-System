using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using MaterialSkin.Controls;
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

        public MainForm()
        {
            InitializeComponent();

            SET_SKIN(this);
            Logo.Image = Resources.autolandia_logo;
            Logo.BackColor = Color.Black;
            TabPanel.BackColor = Color.Black;

            TabButtons.Add(HomeTab);
            TabButtons.Add(OrdersTab);
            TabButtons.Add(VehiclesTab);
            TabButtons.Add(CustomersTab);

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
                Form.Hide();
            }
            Forms[Index].MdiParent = this;
            Forms[Index].Dock = DockStyle.Fill;
            Forms[Index].Show();

            TabButtons[Index].Focus();
        }

        private void HomeTab_Click(object sender, System.EventArgs e)
        {
            SelectTab(0);
        }

        private void OrdersTab_Click(object sender, System.EventArgs e)
        {
            SelectTab(1);
        }

        private void VehiclesTab_Click(object sender, System.EventArgs e)
        {
            SelectTab(2);
        }

        private void CustomersTab_Click(object sender, System.EventArgs e)
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

        private void Logo_MouseUp(object sender, MouseEventArgs e)
        {
            TabMove = false;
        }
    }
}
