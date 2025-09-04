using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditCustomersDataForm : MaterialForm
    {
        CustomersForm CustomersForm;
        string PreviousCellValue = string.Empty;
        Dictionary<string, string> CurrentFocusedRow = new Dictionary<string, string>();
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT * FROM AUTOLANDIA_CustomerList ORDER BY CAST(CustomerName AS nvarchar(MAX)) ASC", SQL);
        DataSet DataSet = new DataSet();

        public EditCustomersDataForm(CustomersForm CustomersForm)
        {
            InitializeComponent();

            this.CustomersForm = CustomersForm;

            SqlCommandBuilder SqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            SqlDataAdapter.Fill(DataSet, "AUTOLANDIA_CustomerList");
            BindingSource BindingSource = new BindingSource();
            BindingSource.DataSource = DataSet.Tables["AUTOLANDIA_CustomerList"];
            CustomerTable.DataSource = BindingSource;
        }

        private void CustomerTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DataTable = DataSet.Tables["AUTOLANDIA_CustomerList"];

            List<Dictionary<string, string>> CustomerNames_PlateNumbers = new List<Dictionary<string, string>>();

            foreach (DataRow Row in DataTable.Rows)
            {
                CustomerNames_PlateNumbers.Add(new Dictionary<string, string> { { "CustomerName", Row["CustomerName"].ToString() }, { "PlateNumbers", Row["PlateNumbers"].ToString() } });
            }

            SqlCommand ClearTable = new SqlCommand("DELETE FROM AUTOLANDIA_CustomerList", SQL);
            ClearTable.ExecuteNonQuery();

            foreach (Dictionary<string, string> CustomerName_PlateNumber in CustomerNames_PlateNumbers)
            {
                SqlCommand InsertRow = new SqlCommand("INSERT INTO AUTOLANDIA_CustomerList (CustomerName, PlateNumbers) VALUES (@CustomerName, @PlateNumbers)", SQL);
                InsertRow.Parameters.AddWithValue("@CustomerName", CustomerName_PlateNumber["CustomerName"]);
                InsertRow.Parameters.AddWithValue("@PlateNumbers", CustomerName_PlateNumber["PlateNumbers"]);
                InsertRow.ExecuteNonQuery();
            }

            if (e.ColumnIndex == 0)
            {
                RecordActivity($"Customer table value changed from [CustomerName: {PreviousCellValue}]-[PlateNumbers: {CustomerTable.Rows[e.RowIndex].Cells[1].Value}] to [CustomerName: {CustomerTable.Rows[e.RowIndex].Cells[0].Value}]-[PlateNumbers: {CustomerTable.Rows[e.RowIndex].Cells[1].Value}]");
            }
            if (e.ColumnIndex == 1)
            {
                RecordActivity($"Customer table value changed from [CustomerName: {CustomerTable.Rows[e.RowIndex].Cells[0].Value}]-[PlateNumbers: {PreviousCellValue}] to [CustomerName: {CustomerTable.Rows[e.RowIndex].Cells[0].Value}]-[PlateNumbers: {CustomerTable.Rows[e.RowIndex].Cells[1].Value}]");
            }
            CustomersForm.RefreshCustomers();
            GlobalActivityRecordForm.RefreshActivities();
        }

        private void CustomerTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    SqlCommand DeleteRow = new SqlCommand("DELETE FROM AUTOLANDIA_CustomerList WHERE CustomerName LIKE @CustomerName AND PlateNumbers LIKE @PlateNumbers", SQL);
                    DeleteRow.Parameters.AddWithValue("@CustomerName", CurrentFocusedRow["CustomerName"]);
                    DeleteRow.Parameters.AddWithValue("@PlateNumbers", CurrentFocusedRow["PlateNumbers"]);
                    DeleteRow.ExecuteNonQuery();
                    RecordActivity($"Customer table value row with [CustomerName {e.Row.Cells[0].Value}] deleted");
                    CustomersForm.RefreshCustomers();
                    GlobalActivityRecordForm.RefreshActivities();
                }
            }
        }

        private void CustomerTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            PreviousCellValue = CustomerTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;
        }

        private void CustomerTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentFocusedRow.Clear();
            CurrentFocusedRow.Add("CustomerName", CustomerTable.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty);
            CurrentFocusedRow.Add("PlateNumbers", CustomerTable.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty);
        }
    }
}
