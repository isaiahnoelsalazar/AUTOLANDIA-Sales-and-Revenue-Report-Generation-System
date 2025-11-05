using MaterialSkin.Controls;
using System;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class BillDetailDialog : MaterialForm
    {
        BillingForm BillingForm;
        string BillingID;

        public BillDetailDialog(BillingForm BillingForm, string BillingID)
        {
            InitializeComponent();

            this.BillingForm = BillingForm;
            this.BillingID = BillingID;

            foreach (BillingItem Billing in GlobalBillingList)
            {
                if (Billing.ID.Equals(BillingID))
                {
                    TB_ID.Text = Billing.ID;
                    TB_Price.Text = Billing.Balance - Billing.Paid > 0? $"₱{(Billing.Balance - Billing.Paid).ToString("0.00")}" : "₱0.00";
                    if (Billing.Balance - Billing.Paid <= 0)
                    {
                        PayButton.Text = "Paid";
                        PayButton.Enabled = false;
                    }
                    L_Discount.Text = $"{Billing.Discount}%";
                    TB_LastUpdated.Text = Billing.LastUpdated;
                    TB_DateCreated.Text = Billing.DateCreated;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;

            string ErrorMessage = string.Empty;

            //if (string.IsNullOrEmpty(TB_Amount.Text))
            //{
            //    ErrorMessage += "Please enter a valid balance.\n";
            //}
            //else
            //{
            //    try
            //    {
            //        double.Parse(TB_Amount.Text);
            //    }
            //    catch
            //    {
            //        ErrorMessage += "Please enter a valid balance.\n";
            //    }
            //}

            //if (ErrorMessage.Equals(""))
            //{
            //    try
            //    {
            //        DoneButton.Enabled = false;
            //        CancelButton.Enabled = false;

            //        RecordActivity($"Updated details of billing with reference number [{BillingID}]");

            //        UpdateInBillingList(
            //            BillingID,
            //            double.Parse(TB_Price.Text),
            //            DiscountSlider.Value,
            //            double.Parse(TB_Price.Text) - double.Parse(TB_Amount.Text),
            //            double.Parse(TB_Price.Text) - double.Parse(TB_Amount.Text) <= 0 ? "Paid" : "Pending",
            //            $"{Now.ToString("yyyy")}/{Now.ToString("MM")}/{Now.ToString("dd")}" + $" {Now.ToString("HH")}:{Now.ToString("mm")}:{Now.ToString("ss")} {Now.ToString("tt")}"
            //        ).ExecuteNonQuery();

            //        NoticeMessageBox("Successfully updated billing details!");
            //        BillingForm.RefreshBillings();
            //        GlobalActivityRecordForm.RefreshActivities();
            //        Close();
            //    }
            //    catch (Exception Exception)
            //    {
            //        AlertMessageBox(Exception.Message);
            //        DoneButton.Enabled = true;
            //        CancelButton.Enabled = true;
            //    }
            //}
            //else
            //{
            //    AlertMessageBox(ErrorMessage);
            //}
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            new PaymentDialog(BillingID).ShowDialog();
        }
    }
}
