using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ResultDialog : MaterialForm
    {
        public ResultDialog(List<ServiceItem> Services, string Package, string Addon, int PerfumeCount, double Price, int Discount, double Total, double AmountPaid, double Change)
        {
            InitializeComponent();

            //L_Service.Text = "₱" + Price.ToString("N2");
            string ServiceNames = "[Services] ";
            foreach (var service in Services)
            {
                ServiceNames += service.Name + ", ";
            }
            ServiceNames = ServiceNames.TrimEnd(',', ' ');

            string Addons = "[Add-ons] ";
            if (PerfumeCount > 0)
            {
                Addons += $"{PerfumeCount} Perfume(s), ";
            }
            if (Addon.Contains('C'))
            {
                int carWashCount = Addon.Count(c => c == 'C');
                Addons += $"Car w/ Carrier";
            }
            else
            {
                Addons = Addons.TrimEnd(',', ' ');
            }

            L_Service.Text = $"{(ServiceNames.Equals("[Services]") ? string.Empty : ServiceNames)} {Package}";
            L_Service.Text = L_Service.Text.EndsWith(" [ - ]") ? L_Service.Text.Split(new string[] { " [ - ]" }, StringSplitOptions.None)[0] : L_Service.Text;
            L_Discount.Text = Discount.ToString() + "%";
            L_Addon.Text = Addons.Equals("[Add-ons] ".TrimEnd(',', ' ')) ? "None" : Addons;
            L_Total.Text = "₱" + Total.ToString("N2");
            L_Paid.Text = "₱" + AmountPaid.ToString("N2");
            L_Change.Text = "₱" + Change.ToString("N2");
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
