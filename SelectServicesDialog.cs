using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SelectServicesDialog : MaterialForm
    {
        NewTransactionDialog NewTransactionDialog;
        EditTransactionDialog EditTransactionDialog;
        TableLayoutControlCollection ServiceListControls;

        public SelectServicesDialog(NewTransactionDialog NewTransactionDialog, string Brand)
        {
            InitializeComponent();
            this.NewTransactionDialog = NewTransactionDialog;

            if (Brand.Equals("GENERAL"))
            {
                List<ServiceItem> Temp = new List<ServiceItem>();
                Temp.Add(new ServiceItem("S_VCBW1", "Body Wash", "S", 120));
                Temp.Add(new ServiceItem("S_VCBW2", "Body Wash", "M", 150));
                Temp.Add(new ServiceItem("S_VCBW3", "Body Wash", "L", 200));
                Temp.Add(new ServiceItem("S_VCBWT", "Body Wash", "M", 220));
                Temp.Add(new ServiceItem("S_VCBWP", "Body Wash", "M", 400));
                Temp.Add(new ServiceItem("S_VCA1", "Armor", "S", 100));
                Temp.Add(new ServiceItem("S_VCA2", "Armor", "M", 100));
                Temp.Add(new ServiceItem("S_VCA3", "Armor", "L", 100));
                Temp.Add(new ServiceItem("S_VCW1", "Wax (Manual)", "S", 150));
                Temp.Add(new ServiceItem("S_VCW2", "Wax (Manual)", "M", 150));
                Temp.Add(new ServiceItem("S_VCW3", "Wax (Manual)", "L", 150));
                Temp.Reverse();

                foreach (ServiceItem Service in Temp)
                {
                    if (!InCheckedListBox(Service.Name))
                    {
                        ServiceListCheckBox.Items.Add(Service.Name);
                    }
                }

                if (NewTransactionDialog.ServiceCheckedboxes != null)
                {
                    NewTransactionDialog.ServiceCheckedboxes.Reverse();
                    for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                    {
                        if (NewTransactionDialog.ServiceCheckedboxes[a].Checked)
                        {
                            ServiceListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
            }
            else
            {
                List<ServiceItem> Temp = new List<ServiceItem>(GlobalServiceList);
                Temp.Reverse();

                foreach (ServiceItem Service in Temp)
                {
                    if (!InCheckedListBox(Service.Name))
                    {
                        ServiceListCheckBox.Items.Add(Service.Name);
                    }
                }

                if (NewTransactionDialog.ServiceCheckedboxes != null)
                {
                    NewTransactionDialog.ServiceCheckedboxes.Reverse();
                    for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                    {
                        if (NewTransactionDialog.ServiceCheckedboxes[a].Checked)
                        {
                            ServiceListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
            }
        }

        public SelectServicesDialog(EditTransactionDialog EditTransactionDialog, TableLayoutControlCollection ServiceListControls)
        {
            InitializeComponent();
            this.EditTransactionDialog = EditTransactionDialog;
            this.ServiceListControls = ServiceListControls;

            List<ServiceItem> Temp = new List<ServiceItem>(GlobalServiceList);
            Temp.Reverse();

            foreach (ServiceItem Service in Temp)
            {
                if (!InCheckedListBox(Service.Name))
                {
                    ServiceListCheckBox.Items.Add(Service.Name);
                }
            }

            if (EditTransactionDialog.ServiceCheckedboxes != null)
            {
                EditTransactionDialog.ServiceCheckedboxes.Reverse();
                for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                {
                    if (EditTransactionDialog.ServiceCheckedboxes[a].Checked)
                    {
                        ServiceListCheckBox.Items[a].Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control Service in ServiceListControls)
                {
                    for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                    {
                        if (ServiceListCheckBox.Items[a].Text.Equals(Service.Controls[0].Text.Trim()))
                        {
                            ServiceListCheckBox.Items[a].Checked = true;
                        }
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

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (NewTransactionDialog != null)
            {
                NewTransactionDialog.SetServices(ServiceListCheckBox.Items);
            }
            if (EditTransactionDialog != null)
            {
                EditTransactionDialog.SetServices(ServiceListCheckBox.Items);
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectServicesDialog_Load(object sender, EventArgs e)
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

        private void SelectServicesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewTransactionDialog != null)
            {
                if (NewTransactionDialog.ServiceCheckedboxes != null)
                {
                    NewTransactionDialog.ServiceCheckedboxes.Reverse();
                }
            }
            if (EditTransactionDialog != null)
            {
                if (EditTransactionDialog.ServiceCheckedboxes != null)
                {
                    EditTransactionDialog.ServiceCheckedboxes.Reverse();
                }
            }
        }

        private void SearchBarService_TextChanged(object sender, EventArgs e)
        {
            ServiceListCheckBox.Items.Clear();
            ServiceListCheckBox.Controls.Clear();

            if (NewTransactionDialog != null)
            {
                List<ServiceItem> Temp = new List<ServiceItem>(GlobalServiceList);
                Temp.Reverse();

                foreach (ServiceItem Service in Temp)
                {
                    if (!InCheckedListBox(Service.Name))
                    {
                        if (Service.Name.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                        {
                            ServiceListCheckBox.Items.Add(Service.Name);
                        }
                        else if (string.IsNullOrEmpty(SearchBarService.Text.ToUpper()))
                        {
                            ServiceListCheckBox.Items.Add(Service.Name);
                        }
                    }
                }

                if (NewTransactionDialog.ServiceCheckedboxes != null)
                {
                    NewTransactionDialog.ServiceCheckedboxes.Reverse();
                    for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                    {
                        if (NewTransactionDialog.ServiceCheckedboxes[a].Checked)
                        {
                            ServiceListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
            }
            if (EditTransactionDialog != null)
            {
                List<ServiceItem> Temp = new List<ServiceItem>(GlobalServiceList);
                Temp.Reverse();

                foreach (ServiceItem Service in Temp)
                {
                    if (!InCheckedListBox(Service.Name))
                    {
                        if (Service.Name.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                        {
                            ServiceListCheckBox.Items.Add(Service.Name);
                        }
                        else if (string.IsNullOrEmpty(SearchBarService.Text.ToUpper()))
                        {
                            ServiceListCheckBox.Items.Add(Service.Name);
                        }
                    }
                }

                if (EditTransactionDialog.ServiceCheckedboxes != null)
                {
                    EditTransactionDialog.ServiceCheckedboxes.Reverse();
                    for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                    {
                        if (EditTransactionDialog.ServiceCheckedboxes[a].Checked)
                        {
                            ServiceListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
                else
                {
                    foreach (Control Service in ServiceListControls)
                    {
                        for (int a = 0; a < ServiceListCheckBox.Items.Count; a++)
                        {
                            if (ServiceListCheckBox.Items[a].Text.Equals(Service.Controls[0].Text.Trim()))
                            {
                                ServiceListCheckBox.Items[a].Checked = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
