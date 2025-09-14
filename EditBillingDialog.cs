using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditBillingDialog : MaterialForm
    {
        BillingForm BillingForm;
        string BillingID;

        public EditBillingDialog(BillingForm BillingForm, string BillingID)
        {
            InitializeComponent();

            this.BillingForm = BillingForm;
            this.BillingID = BillingID;

            CB_Progress.Items.Add("Unpaid");
            CB_Progress.Items.Add("Incomplete");
            CB_Progress.Items.Add("Paid");

            foreach (string Payment in GlobalPaymentMethodList)
            {
                CB_PaymentMethod.Items.Add(Payment);
            }

            foreach (BillingItem Billing in GlobalBillingList)
            {
                if (Billing.ID.Equals(BillingID))
                {
                    TB_ID.Text = Billing.ID;
                    TB_Price.Text = Billing.Balance.ToString();
                    TB_LastUpdated.Text = Billing.LastUpdated;
                    TB_DateCreated.Text = Billing.DateCreated;

                    for (int a = 0; a < CB_PaymentMethod.Items.Count; a++)
                    {
                        if (Billing.PaymentMethod.Equals(CB_PaymentMethod.Items[a]))
                        {
                            CB_PaymentMethod.SelectedIndex = a;
                        }
                    }

                    if (Billing.Progress.Equals("Unpaid"))
                    {
                        CB_Progress.SelectedIndex = 0;
                    }
                    if (Billing.Progress.Equals("Incomplete"))
                    {
                        CB_Progress.SelectedIndex = 1;
                    }
                    if (Billing.Progress.Equals("Paid"))
                    {
                        CB_Progress.SelectedIndex = 2;
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
        }
    }
}
