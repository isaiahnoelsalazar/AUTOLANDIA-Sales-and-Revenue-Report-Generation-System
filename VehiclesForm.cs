using System;
using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();

            VehicleTable.Columns.Add("Brand", -2);
            VehicleTable.Columns.Add("Model", -2);
            VehicleTable.Columns.Add("Size", -2);
            VehicleTable.Columns.Add("PlateNumber", -2);
            VehicleTable.Columns.Add("CustomerName", -2);
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
        }
    }
}
