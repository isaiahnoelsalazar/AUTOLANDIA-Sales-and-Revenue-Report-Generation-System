using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ActivityRecordForm : Form
    {
        public ActivityRecordForm()
        {
            InitializeComponent();

            ActivityTable.Columns.Add("Activity", -2);

            RefreshActivities();
        }

        public void RefreshActivities()
        {
            RecreateGlobalActivityList();

            ActivityTable.Items.Clear();

            foreach (string Activity in GlobalActivityList)
            {
                ActivityTable.Items.Add(new ListViewItem(Activity));
            }
            foreach (ColumnHeader ColumnHeader in ActivityTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }

        private void SearchBarActivity_TextChanged(object sender, System.EventArgs e)
        {
            ActivityTable.Items.Clear();

            foreach (string Activity in GlobalActivityList)
            {
                if (Activity.ToUpper().Contains(SearchBarActivity.Text.ToUpper()))
                {
                    ActivityTable.Items.Add(new ListViewItem(Activity));
                }
            }
            foreach (ColumnHeader ColumnHeader in ActivityTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }
    }
}
