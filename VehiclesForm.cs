using System;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

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

            RefreshVehicles();
        }

        public void RefreshVehicles()
        {
            RecreateVehicleList();

            VehicleTable.Items.Clear();
            foreach (VehicleItem Vehicle in VehicleList)
            {
                VehicleTable.Items.Add(new ListViewItem(new string[] { Vehicle.Brand, Vehicle.Model, Vehicle.Size, Vehicle.PlateNumber, Vehicle.CustomerName }));
            }
            foreach (ColumnHeader ColumnHeader in VehicleTable.Columns)
            {
                ColumnHeader.Width = -2;
            }

            //new Do(() =>
            //{
            //    RecreateVehicleList();
            //})
            //.AfterDo(() =>
            //{
            //    VehicleTable.Items.Clear();
            //    foreach (VehicleItem Vehicle in VehicleList)
            //    {
            //        VehicleTable.Items.Add(new ListViewItem(new string[] { Vehicle.Brand, Vehicle.Model, Vehicle.Size, Vehicle.PlateNumber, Vehicle.CustomerName }));
            //    }
            //    foreach (ColumnHeader ColumnHeader in VehicleTable.Columns)
            //    {
            //        ColumnHeader.Width = -2;
            //    }
            //});
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
            new NewVehicleDialog(this).ShowDialog();
        }
    }
}
