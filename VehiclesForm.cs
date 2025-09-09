using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class VehiclesForm : Form
    {
        int LastClickedColumn = 0;
        bool Reverse = false;

        public VehiclesForm()
        {
            InitializeComponent();

            VehicleTable.Columns.Add("Brand", -2);
            VehicleTable.Columns.Add("Model", -2);
            VehicleTable.Columns.Add("Size", -2);
            VehicleTable.Columns.Add("PlateNumber", -2);
            VehicleTable.Columns.Add("CustomerName", -2);

            //VehicleTable.ColumnClick += (s, e) =>
            //{
            //    List<VehicleItem> Temp = new List<VehicleItem>(VehicleList);
            //    Temp.Sort(new VehicleItemComparer(e.Column));

            //    if (LastClickedColumn == e.Column)
            //    {
            //        if (!Reverse)
            //        {
            //            Temp.Reverse();
            //            Reverse = true;
            //        }
            //        else
            //        {
            //            Reverse = false;
            //        }
            //    }
            //    else
            //    {
            //        LastClickedColumn = e.Column;
            //        Reverse = false;
            //    }

            //    VehicleTable.Items.Clear();
            //    foreach (VehicleItem Vehicle in Temp)
            //    {
            //        //VehicleTable.Items.Add(new ListViewItem(new string[] { Vehicle.Brand, Vehicle.Model, Vehicle.Size, Vehicle.PlateNumber, Vehicle.CustomerName }));
            //    }
            //    foreach (ColumnHeader ColumnHeader in VehicleTable.Columns)
            //    {
            //        ColumnHeader.Width = -2;
            //    }
            //};

            RefreshVehicles();
        }

        public void RefreshVehicles()
        {
            //RecreateVehicleList();

            //List<VehicleItem> Temp = new List<VehicleItem>(VehicleList);
            //Temp.Sort(new VehicleItemComparer(LastClickedColumn));

            //VehicleTable.Items.Clear();
            //foreach (VehicleItem Vehicle in Temp)
            //{
            //    //VehicleTable.Items.Add(new ListViewItem(new string[] { Vehicle.Brand, Vehicle.Model, Vehicle.Size, Vehicle.PlateNumber, Vehicle.CustomerName }));
            //}
            //foreach (ColumnHeader ColumnHeader in VehicleTable.Columns)
            //{
            //    ColumnHeader.Width = -2;
            //}
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
            new NewVehicleDialog(this).ShowDialog();
        }

        private void EditTableValuesButton_Click(object sender, EventArgs e)
        {
            new EditVehiclesDataForm(this).ShowDialog();
        }
    }
}
