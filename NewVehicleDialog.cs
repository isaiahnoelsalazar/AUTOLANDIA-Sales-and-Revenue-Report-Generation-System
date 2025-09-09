using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewVehicleDialog : MaterialForm
    {
        VehiclesForm VehiclesForm;

        public NewVehicleDialog(VehiclesForm VehiclesForm)
        {
            InitializeComponent();

            this.VehiclesForm = VehiclesForm;

            //foreach (VehicleItem Vehicle in VehicleList)
            //{
            //    if (!CB_Brand.Items.Contains(Vehicle.Brand))
            //    {
            //        CB_Brand.Items.Add(Vehicle.Brand);
            //    }
            //    if (!CB_Model.Items.Contains(Vehicle.Model))
            //    {
            //        CB_Model.Items.Add(Vehicle.Model);
            //    }
            //}
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Brand.Text) || Check.HasSymbols(TB_Brand.Text))
            {
                ErrorMessage += "Brand cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (Check.HasNumbers(TB_Model.Text) || Check.HasSymbols(TB_Model.Text))
            {
                ErrorMessage += "Model cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (GetSize().Equals(""))
            {
                ErrorMessage += "Please select a vehicle size." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_PlateNumber.Text))
            {
                ErrorMessage += "Please enter the vehicle's plate number." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string Brand = TB_Brand.Text.ToUpper();
                    string Model = TB_Model.Text.ToUpper();
                    string Size = GetSize().ToUpper();
                    string PlateNumber = TB_PlateNumber.Text.ToUpper();

                    DoneButton.Enabled = false;
                    CancelButton.Enabled = false;

                    RecordActivity($"Added new vehicle: {Brand}, {Model}, {Size}, {PlateNumber}");

                    SqlCommand Command = new SqlCommand($"INSERT INTO AUTOLANDIA_VehicleList(VehicleBrand, VehicleModel, VehicleSize, PlateNumber, CustomerName) VALUES ('{Brand}', '{Model}', '{Size}', '{PlateNumber}', '(None)')", SQL);

                    Command.ExecuteNonQuery();

                    MaterialMessageBox.Show("Successfully added new vehicle!", "Notice");
                    VehiclesForm.RefreshVehicles();
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
            else
            {
                MaterialMessageBox.Show(ErrorMessage, "Alert");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string GetSize()
        {
            RadioButton[] RadioButtons = { RB_S, RB_M, RB_L, RB_XL, RB_XXL };
            foreach (RadioButton RadioButton in RadioButtons)
            {
                if (RadioButton.Checked)
                {
                    return RadioButton.Text;
                }
            }
            return "";
        }

        private void CB_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Brand.Text = CB_Brand.Text;
        }

        private void CB_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Model.Text = CB_Model.Text;
        }
    }
}
