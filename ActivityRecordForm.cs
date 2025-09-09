using System.Collections.Generic;
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
            RecreateActivityList();

            ActivityTable.Items.Clear();

            List<string> Temp = new List<string>(ActivityList);
            Temp.Sort();
            Temp.Reverse();

            foreach (string Activity in Temp)
            {
                ActivityTable.Items.Add(new ListViewItem(Activity));
            }
            foreach (ColumnHeader ColumnHeader in ActivityTable.Columns)
            {
                ColumnHeader.Width = -2;
            }
        }
    }
}
