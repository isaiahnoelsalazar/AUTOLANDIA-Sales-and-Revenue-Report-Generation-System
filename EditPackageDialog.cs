using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditPackageDialog : MaterialForm
    {
        ServicesAndPackagesForm ServicesAndPackagesForm;
        string PackageID, PreviousPrice;

        public EditPackageDialog(ServicesAndPackagesForm ServicesAndPackagesForm, string PackageID)
        {
            InitializeComponent();

            this.ServicesAndPackagesForm = ServicesAndPackagesForm;
            this.PackageID = PackageID;

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (Package.ID.Equals(PackageID))
                {
                    TB_ID.Text = Package.ID;
                    TB_Name.Text = Package.Name;
                    TB_Services.Text = Package.Details;
                    TB_Size.Text = Package.Size;
                    TB_Price.Text = Package.Price.ToString();
                    PreviousPrice = Package.Price.ToString();
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Price = TB_Price.Text.ToUpper();

                DoneButton.Enabled = false;
                CancelButton.Enabled = false;

                RecordActivity($"Updated package [{PackageID}] price from [{PreviousPrice}] to [{Price}]");

                SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_PackageList SET PackagePrice={Price} WHERE PackageId='{PackageID}'", SQL);

                Command.ExecuteNonQuery();

                MaterialMessageBox.Show("Successfully updated package details!", "Notice");
                ServicesAndPackagesForm.RefreshPackages();
                GlobalActivityRecordForm.RefreshActivities();
                Close();
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show(exception.Message, "Alert");
                DoneButton.Enabled = true;
                CancelButton.Enabled = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
