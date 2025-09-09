﻿using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SelectCustomerDialog : MaterialForm
    {
        Color DefaultBackgroundColor;
        LinkCustomerVehicleDialog LinkCustomerVehicleDialog;

        public SelectCustomerDialog(LinkCustomerVehicleDialog LinkCustomerVehicleDialog)
        {
            InitializeComponent();

            this.LinkCustomerVehicleDialog = LinkCustomerVehicleDialog;

            CustomerList.Controls.Clear();
            CustomerList.RowStyles.Clear();
            CustomerList.VerticalScroll.Visible = true;
            CustomerList.HorizontalScroll.Enabled = false;
            CustomerList.HorizontalScroll.Visible = false;

            RefreshCustomers();
        }

        public void RefreshCustomers()
        {
            CustomerList.Controls.Clear();
            CustomerList.RowStyles.Clear();

            foreach (CustomerItem Customer in GlobalCustomerList)
            {
                RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                TableLayoutPanel Panel = new TableLayoutPanel
                {
                    ColumnCount = 1
                };
                Label Name = new Label();

                if (DefaultBackgroundColor == null)
                {
                    DefaultBackgroundColor = Panel.BackColor;
                }

                Panel.Dock = DockStyle.Top;
                Panel.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Panel.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };
                Panel.ColumnStyles.Clear();
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
                Panel.Margin = new Padding(0);

                Name.Dock = DockStyle.Fill;
                Name.Text = $"{Customer.ID}: {Customer.Name}";
                Name.TextAlign = ContentAlignment.MiddleLeft;
                Name.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Name.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                Panel.Click += (sndr, evnt) =>
                {
                    LinkCustomerVehicleDialog.SetCustomerName($"{Customer.ID}: {Customer.Name}");
                    Close();
                };
                Name.Click += (sndr, evnt) =>
                {
                    LinkCustomerVehicleDialog.SetCustomerName($"{Customer.ID}: {Customer.Name}");
                    Close();
                };

                CustomerList.RowStyles.Add(Row);
                Panel.Controls.Add(Name, 0, 0);
                CustomerList.Controls.Add(Panel);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
