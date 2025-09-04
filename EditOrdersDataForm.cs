using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class EditOrdersDataForm : MaterialForm
    {
        OrdersForm OrdersForm;
        string PreviousCellValue = string.Empty, CurrentFocusedRowId = string.Empty;
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT * FROM AUTOLANDIA_OrderList ORDER BY CAST(OrderId AS nvarchar(MAX)) ASC", SQL);
        DataSet DataSet = new DataSet();

        public EditOrdersDataForm(OrdersForm OrdersForm)
        {
            InitializeComponent();

            this.OrdersForm = OrdersForm;

            SqlDataAdapter.UpdateCommand = new SqlCommand("UPDATE AUTOLANDIA_OrderList SET EmployeeName=@EmployeeName, PlateNumber=@PlateNumber, ServiceIdList=@ServiceIdList, PackageIdList=@PackageIdList, OrderBalance=@OrderBalance, PaymentMethodName=@PaymentMethodName, DateCreated=@DateCreated WHERE OrderId LIKE @OrderId", SQL);
            SqlDataAdapter.UpdateCommand.Parameters.Add("@EmployeeName", SqlDbType.Text, -1, "EmployeeName");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@PlateNumber", SqlDbType.Text, -1, "PlateNumber");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@ServiceIdList", SqlDbType.Text, -1, "ServiceIdList");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@PackageIdList", SqlDbType.Text, -1, "PackageIdList");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@OrderBalance", SqlDbType.Float, 0, "OrderBalance");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@PaymentMethodName", SqlDbType.Text, -1, "PaymentMethodName");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@DateCreated", SqlDbType.Text, -1, "DateCreated");
            SqlDataAdapter.UpdateCommand.Parameters.Add("@OrderId", SqlDbType.Text, -1, "OrderId");

            SqlCommandBuilder SqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            SqlDataAdapter.Fill(DataSet, "AUTOLANDIA_OrderList");
            BindingSource BindingSource = new BindingSource();
            BindingSource.DataSource = DataSet.Tables["AUTOLANDIA_OrderList"];
            OrderTable.DataSource = BindingSource;
        }

        private void OrderTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DataTable = DataSet.Tables["AUTOLANDIA_OrderList"];
            OrderTable.BindingContext[DataTable].EndCurrentEdit();
            SqlDataAdapter.Update(DataTable);
            RecordActivity($"Order table value changed at [OrderID {OrderTable.Rows[e.RowIndex].Cells[0].Value}]: [{OrderTable.Columns[e.ColumnIndex].Name}] column, from [{PreviousCellValue}] to [{OrderTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}]");
            OrdersForm.RefreshOrders();
            GlobalActivityRecordForm.RefreshActivities();
        }

        private void OrderTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            PreviousCellValue = OrderTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;
        }

        private void OrderTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    SqlCommand DeleteRow = new SqlCommand("DELETE FROM AUTOLANDIA_OrderList WHERE OrderId LIKE @OrderId", SQL);
                    DeleteRow.Parameters.AddWithValue("@OrderId", CurrentFocusedRowId);
                    DeleteRow.ExecuteNonQuery();
                    RecordActivity($"Order table value row [OrderID {e.Row.Cells[0].Value}] deleted");
                    OrdersForm.RefreshOrders();
                    GlobalActivityRecordForm.RefreshActivities();
                }
            }
        }

        private void OrderTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentFocusedRowId = OrderTable.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
        }
    }
}
