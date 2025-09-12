using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class BillingForm : Form
    {
        Color DefaultBackgroundColor;

        public BillingForm()
        {
            InitializeComponent();

            BillingList.Controls.Clear();
            BillingList.RowStyles.Clear();
            BillingList.VerticalScroll.Visible = true;
            BillingList.HorizontalScroll.Enabled = false;
            BillingList.HorizontalScroll.Visible = false;

            RefreshBillings();
        }

        public void RefreshBillings()
        {
            RecreateGlobalBillingList();

            BillingList.Controls.Clear();
            BillingList.RowStyles.Clear();

            foreach (BillingItem Billing in GlobalBillingList)
            {
                RowStyle Row = new RowStyle(SizeType.Absolute, 55f);
                TableLayoutPanel Panel = new TableLayoutPanel

                {
                    ColumnCount = 6
                };
                Label Id = new Label();
                Label Balance = new Label();
                MaterialComboBox Progress = new MaterialComboBox();
                MaterialComboBox PaymentMethod = new MaterialComboBox();
                Label LastUpdated = new Label();
                Label DateCreated = new Label();

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
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                Panel.Margin = new Padding(0);

                Id.Dock = DockStyle.Fill;
                Id.Text = Billing.ID;
                Id.TextAlign = ContentAlignment.MiddleCenter;
                Id.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Id.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                Balance.Dock = DockStyle.Fill;
                Balance.Text = Billing.Balance.ToString();
                Balance.TextAlign = ContentAlignment.MiddleCenter;
                Balance.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                Balance.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                Progress.Dock = DockStyle.Fill;
                Progress.Items.Add("Unpaid");
                Progress.Items.Add("Incomplete");
                Progress.Items.Add("Paid");

                if (Billing.Progress.Equals("Unpaid"))
                {
                    Progress.SelectedIndex = 0;
                }
                if (Billing.Progress.Equals("Incomplete"))
                {
                    Progress.SelectedIndex = 1;
                }
                if (Billing.Progress.Equals("Paid"))
                {
                    Progress.SelectedIndex = 2;
                }

                Progress.SelectedIndexChanged += (sndr, evnt) =>
                {
                    try
                    {
                        DateTime Now = DateTime.Now;

                        RecordActivity($"Changed billing reference number [{Billing.ID}] progress from [{Billing.Progress}] to [{Progress.Text}]");

                        SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_BillingList SET BillingProgress='{Progress.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE BillingId='{Billing.ID}'", SQL);

                        Command.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully changed billing progress!", "Notice");
                        RefreshBillings();
                        GlobalActivityRecordForm.RefreshActivities();
                    }
                    catch (Exception exception)
                    {
                        MaterialMessageBox.Show(exception.Message, "Alert");
                    }
                };

                PaymentMethod.Dock = DockStyle.Fill;
                foreach (string Payment in GlobalPaymentMethodList)
                {
                    PaymentMethod.Items.Add(Payment);
                }
                for (int a = 0; a < PaymentMethod.Items.Count; a++)
                {
                    if (Billing.PaymentMethod.Equals(PaymentMethod.Items[a]))
                    {
                        PaymentMethod.SelectedIndex = a;
                    }
                }
               
                PaymentMethod.SelectedIndexChanged += (sndr, evnt) =>
                {
                    try
                    {
                        DateTime Now = DateTime.Now;

                        RecordActivity($"Changed billing reference number [{Billing.ID}] payment method from [{Billing.PaymentMethod}] to [{PaymentMethod.Text}]");

                        SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_BillingList SET PaymentMethodName='{PaymentMethod.Text}', DateUpdated='{$"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"}' WHERE BillingId='{Billing.ID}'", SQL);

                        Command.ExecuteNonQuery();

                        MaterialMessageBox.Show("Successfully changed billing payment method!", "Notice");
                        RefreshBillings();
                        GlobalActivityRecordForm.RefreshActivities();
                    }
                    catch (Exception exception)
                    {
                        MaterialMessageBox.Show(exception.Message, "Alert");
                    }
                };

                LastUpdated.Dock = DockStyle.Fill;
                LastUpdated.Text = Billing.LastUpdated;
                LastUpdated.TextAlign = ContentAlignment.MiddleCenter;
                LastUpdated.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                LastUpdated.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                DateCreated.Dock = DockStyle.Fill;
                DateCreated.Text = Billing.DateCreated;
                DateCreated.TextAlign = ContentAlignment.MiddleCenter;
                DateCreated.MouseEnter += (sndr, evnt) =>
                {
                    Panel.BackColor = Color.FromArgb(200, 200, 200);
                };
                DateCreated.MouseLeave += (sndr, evnt) =>
                {
                    Panel.BackColor = DefaultBackgroundColor;
                };

                Panel.Click += (sndr, evnt) =>
                {
                };
                Id.Click += (sndr, evnt) =>
                {
                };
                Balance.Click += (sndr, evnt) =>
                {
                };
                Progress.Click += (sndr, evnt) =>
                {
                };
                LastUpdated.Click += (sndr, evnt) =>
                {
                };
                LastUpdated.Click += (sndr, evnt) =>
                {
                };
                DateCreated.Click += (sndr, evnt) =>
                {
                };

                BillingList.RowStyles.Add(Row);
                Panel.Controls.Add(Id, 0, 0);
                Panel.Controls.Add(Balance, 1, 0);
                Panel.Controls.Add(Progress, 2, 0);
                Panel.Controls.Add(PaymentMethod, 3, 0);
                Panel.Controls.Add(LastUpdated, 4, 0);
                Panel.Controls.Add(DateCreated, 5, 0);
                BillingList.Controls.Add(Panel);

                tableLayoutPanel2.Width = BillingList.Width;
            }
        }
    }
}
