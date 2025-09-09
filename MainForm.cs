﻿using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
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
            new PeopleForm(),
            new ServicesAndPackagesForm(),
            new ActivityRecordForm(),
            new ActivityRecordForm(),
            new ActivityRecordForm(),
            new ActivityRecordForm()

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
            TabButtons.Add(PeopleTab);
            TabButtons.Add(ServicesAndPackagesTab);
            TabButtons.Add(TransactionsTab);
            TabButtons.Add(BillingTab);
            TabButtons.Add(ReportsTab);
            TabButtons.Add(ActivityRecordTab);

            GlobalHomeForm = (HomeForm)Forms[0];
            GlobalPeopleForm = (PeopleForm)Forms[1];
            GlobalServicesAndPackagesForm = (ServicesAndPackagesForm)Forms[2];
            GlobalActivityRecordForm = (ActivityRecordForm)Forms[6];

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

        private void TransactionsTab_Click(object sender, EventArgs e)
        {
            SelectTab(3);
        }

        private void BillingTab_Click(object sender, EventArgs e)
        {
            SelectTab(4);
        }

        private void PeopleTab_Click(object sender, EventArgs e)
        {
            SelectTab(1);
        }

        private void ActivityRecordTab_Click(object sender, EventArgs e)
        {
            SelectTab(6);
        }

        private void ServicesAndPackagesTab_Click(object sender, EventArgs e)
        {
            SelectTab(2);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void AccountButton_Click(object sender, EventArgs e)
        {
        }

        private void ReportsTab_Click(object sender, EventArgs e)
        {
            SelectTab(5);
        }

        private void Logo_MouseUp(object sender, MouseEventArgs e)
        {
            TabMove = false;
        }
    }
}
