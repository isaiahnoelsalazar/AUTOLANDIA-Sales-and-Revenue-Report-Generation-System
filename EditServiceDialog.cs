using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditServiceDialog : MaterialForm
    {
        ServicesAndPackagesForm ServicesAndPackagesForm;
        string ServiceID, PreviousPrice;

        public EditServiceDialog(ServicesAndPackagesForm ServicesAndPackagesForm, string ServiceID)
        {
            InitializeComponent();

            this.ServicesAndPackagesForm = ServicesAndPackagesForm;
            this.ServiceID = ServiceID;

            foreach (ServiceItem Service in GlobalServiceList)
            {
                if (Service.ID.Equals(ServiceID))
                {
                    TB_ID.Text = Service.ID;
                    TB_Name.Text = Service.Name;
                    TB_Size.Text = Service.Size;
                    TB_Price.Text = Service.Price.ToString();
                    PreviousPrice = Service.Price.ToString();
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

                RecordActivity($"Updated service [{ServiceID}] price from [{PreviousPrice}] to [{Price}]");

                SqlCommand Command = new SqlCommand($"UPDATE AUTOLANDIA_ServiceList SET ServicePrice={Price} WHERE ServiceId='{ServiceID}'", SQL);

                Command.ExecuteNonQuery();

                MaterialMessageBox.Show("Successfully updated service details!", "Notice");
                ServicesAndPackagesForm.RefreshServices();
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
