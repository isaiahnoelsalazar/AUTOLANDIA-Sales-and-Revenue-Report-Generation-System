using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditVehiclesDataForm : MaterialForm
    {
        VehiclesForm VehiclesForm;
        string PreviousCellValue = string.Empty, CurrentFocusedRowId = string.Empty;
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT * FROM AUTOLANDIA_VehicleList ORDER BY CAST(VehicleBrand AS nvarchar(MAX)) ASC", SQL);
        DataSet DataSet = new DataSet();

        public EditVehiclesDataForm(VehiclesForm VehiclesForm)
        {
            InitializeComponent();

            this.VehiclesForm = VehiclesForm;

            SqlCommandBuilder SqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            SqlDataAdapter.Fill(DataSet, "AUTOLANDIA_VehicleList");
            BindingSource BindingSource = new BindingSource();
            BindingSource.DataSource = DataSet.Tables["AUTOLANDIA_VehicleList"];
            VehicleTable.DataSource = BindingSource;
        }

        private void VehicleTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                SqlCommand UpdateRow = new SqlCommand("UPDATE AUTOLANDIA_VehicleList SET PlateNumber=@NewPlateNumber WHERE PlateNumber LIKE @OldPlateNumber", SQL);
                UpdateRow.Parameters.AddWithValue("@OldPlateNumber", PreviousCellValue);
                UpdateRow.Parameters.AddWithValue("@NewPlateNumber", VehicleTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                UpdateRow.ExecuteNonQuery();
            }
            else
            {
                SqlCommand UpdateRow = new SqlCommand("UPDATE AUTOLANDIA_VehicleList SET VehicleBrand=@VehicleBrand, VehicleModel=@VehicleModel, VehicleSize=@VehicleSize, CustomerName=@CustomerName WHERE PlateNumber LIKE @PlateNumber", SQL);
                UpdateRow.Parameters.AddWithValue("@VehicleBrand", VehicleTable.Rows[e.RowIndex].Cells[0].Value);
                UpdateRow.Parameters.AddWithValue("@VehicleModel", VehicleTable.Rows[e.RowIndex].Cells[1].Value);
                UpdateRow.Parameters.AddWithValue("@VehicleSize", VehicleTable.Rows[e.RowIndex].Cells[2].Value);
                UpdateRow.Parameters.AddWithValue("@PlateNumber", VehicleTable.Rows[e.RowIndex].Cells[3].Value);
                UpdateRow.Parameters.AddWithValue("@CustomerName", VehicleTable.Rows[e.RowIndex].Cells[4].Value);
                UpdateRow.ExecuteNonQuery();
            }

            RecordActivity($"Vehicle table value changed at [PlateNumber {VehicleTable.Rows[e.RowIndex].Cells[3].Value}]: [{VehicleTable.Columns[e.ColumnIndex].Name}] column, from [{PreviousCellValue}] to [{VehicleTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}]");
            VehiclesForm.RefreshVehicles();
            GlobalActivityRecordForm.RefreshActivities();
        }

        private void VehicleTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                DialogResult DialogResult = MaterialMessageBox.Show("Are you sure you want to delete this row?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    SqlCommand DeleteRow = new SqlCommand("DELETE FROM AUTOLANDIA_VehicleList WHERE PlateNumber LIKE @PlateNumber", SQL);
                    DeleteRow.Parameters.AddWithValue("@PlateNumber", CurrentFocusedRowId);
                    DeleteRow.ExecuteNonQuery();
                    RecordActivity($"Vehicle table value row with [PlateNumber {e.Row.Cells[1].Value}] deleted");
                    VehiclesForm.RefreshVehicles();
                    GlobalActivityRecordForm.RefreshActivities();
                }
            }
        }

        private void VehicleTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentFocusedRowId = VehicleTable.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
        }

        private void VehicleTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            PreviousCellValue = VehicleTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;
        }
    }
}
