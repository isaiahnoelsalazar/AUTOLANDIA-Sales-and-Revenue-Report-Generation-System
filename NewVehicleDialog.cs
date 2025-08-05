using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
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
                    string Query = $"INSERT INTO AUTOLANDIA_VehicleList(VehicleBrand, VehicleModel, VehicleSize, PlateNumber, CustomerName) VALUES ('{TB_Brand.Text.ToUpper()}', '{TB_Model.Text.ToUpper()}', '{GetSize().ToUpper()}', '{TB_PlateNumber.Text.ToUpper()}', '(None)')";
                    NewQuery(Query);

                    MaterialMessageBox.Show("Successfully added new vehicle!", "Success");
                    VehiclesForm.RefreshVehicles();
                    Close();
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
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
    }
}
