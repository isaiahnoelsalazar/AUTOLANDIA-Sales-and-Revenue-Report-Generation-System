using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SelectServicesDialog : MaterialForm
    {
        NewOrderDialog NewOrderDialog;

        public SelectServicesDialog(NewOrderDialog NewOrderDialog)
        {
            InitializeComponent();
            this.NewOrderDialog = NewOrderDialog;

            //foreach (ServiceItem Service in ServiceList)
            //{
            //    if (!InCheckedListBox(Service.Name))
            //    {
            //        ServiceListCheckBox.Items.Add(Service.Name);
            //    }
            //}

            if (NewOrderDialog.Checkedboxes != null)
            {
                NewOrderDialog.Checkedboxes.Reverse();
                for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                {
                    if (NewOrderDialog.Checkedboxes[a].Checked)
                    {
                        ServiceListCheckBox.Items[a].Checked = true;
                    }
                }
            }
        }

        bool InCheckedListBox(string text)
        {
            foreach (MaterialCheckbox Item in ServiceListCheckBox.Items)
            {
                if (Item.Text == text)
                {
                    return true;
                }
            }
            return false;
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            NewOrderDialog.SetServices(ServiceListCheckBox.Items);
            Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            if (NewOrderDialog.Checkedboxes != null)
            {
                NewOrderDialog.Checkedboxes.Reverse();
            }

            Close();
        }

        private void SelectServicesDialog_Load(object sender, System.EventArgs e)
        {
            Timer Timer = new Timer();
            Timer.Interval = 1;
            Timer.Tick += (s, evt) =>
            {
                ServiceListCheckBox.AutoScrollPosition = new Point(0, 0);
                Timer.Stop();
            };
            Timer.Start();
        }
    }
}
