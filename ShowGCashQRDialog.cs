using AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.Properties;
using MaterialSkin.Controls;
using System.Drawing;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ShowGCashQRDialog : MaterialForm
    {
        public ShowGCashQRDialog()
        {
            InitializeComponent();

            Banner.Image = Resources.sample_gcash_qr;
            Banner.BackColor = Color.Black;
        }
    }
}
