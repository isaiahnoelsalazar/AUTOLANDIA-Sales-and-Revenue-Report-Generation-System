using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditEmployeesDataForm : MaterialForm
    {
        EmployeesForm EmployeesForm;
        string PreviousCellValue = string.Empty, CurrentFocusedRowId = string.Empty;
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT DISTINCT CAST(EmployeeName AS nvarchar(MAX)), CAST(TimeIn AS nvarchar(MAX)), CAST(TimeOut AS nvarchar(MAX)), CAST(DateRecorded AS nvarchar(MAX)) FROM AUTOLANDIA_EmployeeList", SQL);
        DataSet DataSet = new DataSet();

        private void EmployeeTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            PreviousCellValue = EmployeeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;
        }

        private void EmployeeTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand UpdateRow = new SqlCommand("UPDATE AUTOLANDIA_EmployeeList SET EmployeeName=@NewEmployeeName WHERE EmployeeName LIKE @OldEmployeeName", SQL);
            UpdateRow.Parameters.AddWithValue("@OldEmployeeName", PreviousCellValue);
            UpdateRow.Parameters.AddWithValue("@NewEmployeeName", EmployeeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            UpdateRow.ExecuteNonQuery();

            RecordActivity($"Employee table value changed from [EmployeeName: {PreviousCellValue}] to [EmployeeName: {EmployeeTable.Rows[e.RowIndex].Cells[0].Value}]");
            EmployeesForm.RefreshEmployees();
            GlobalActivityRecordForm.RefreshActivities();
        }

        private void EmployeeTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    SqlCommand DeleteRow = new SqlCommand("DELETE FROM AUTOLANDIA_EmployeeList WHERE EmployeeName LIKE @EmployeeName", SQL);
                    DeleteRow.Parameters.AddWithValue("@EmployeeName", CurrentFocusedRowId);
                    DeleteRow.ExecuteNonQuery();
                    RecordActivity($"Employee table value row with [EmployeeName {e.Row.Cells[0].Value}] deleted");
                    EmployeesForm.RefreshEmployees();
                    GlobalActivityRecordForm.RefreshActivities();
                }
            }
        }

        private void EmployeeTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentFocusedRowId = EmployeeTable.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
        }

        public EditEmployeesDataForm(EmployeesForm EmployeesForm)
        {
            InitializeComponent();

            this.EmployeesForm = EmployeesForm;

            SqlCommandBuilder SqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            SqlDataAdapter.Fill(DataSet, "AUTOLANDIA_EmployeeList");
            BindingSource BindingSource = new BindingSource();
            BindingSource.DataSource = DataSet.Tables["AUTOLANDIA_EmployeeList"];
            EmployeeTable.DataSource = BindingSource;
        }
    }
}
