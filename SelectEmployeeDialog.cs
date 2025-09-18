using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SelectEmployeeDialog : MaterialForm
    {
        NewTransactionDialog NewTransactionDialog;
        EditTransactionDialog EditTransactionDialog;
        string EmployeeList;

        public SelectEmployeeDialog(NewTransactionDialog NewTransactionDialog)
        {
            InitializeComponent();

            this.NewTransactionDialog = NewTransactionDialog;

            List<EmployeeItem> Temp = new List<EmployeeItem>(GlobalEmployeeList);
            Temp.Sort(new EmployeeNameComparer());
            Temp.Reverse();

            foreach (EmployeeItem Employee in Temp)
            {
                string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                if (!InCheckedListBox(EmployeeDetail))
                {
                    EmployeeListCheckBox.Items.Add(EmployeeDetail);
                }
            }

            if (NewTransactionDialog.EmployeeCheckedboxes != null)
            {
                NewTransactionDialog.EmployeeCheckedboxes.Reverse();
                for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                {
                    if (NewTransactionDialog.EmployeeCheckedboxes[a].Checked)
                    {
                        EmployeeListCheckBox.Items[a].Checked = true;
                    }
                }
            }
        }

        public SelectEmployeeDialog(EditTransactionDialog EditTransactionDialog, string EmployeeList)
        {
            InitializeComponent();

            this.EditTransactionDialog = EditTransactionDialog;
            this.EmployeeList = EmployeeList;

            List<EmployeeItem> Temp = new List<EmployeeItem>(GlobalEmployeeList);
            Temp.Sort(new EmployeeNameComparer());
            Temp.Reverse();

            foreach (EmployeeItem Employee in Temp)
            {
                string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                if (!InCheckedListBox(EmployeeDetail))
                {
                    EmployeeListCheckBox.Items.Add(EmployeeDetail);
                }
            }

            if (EditTransactionDialog.EmployeeCheckedboxes != null)
            {
                EditTransactionDialog.EmployeeCheckedboxes.Reverse();
                for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                {
                    if (EditTransactionDialog.EmployeeCheckedboxes[a].Checked)
                    {
                        EmployeeListCheckBox.Items[a].Checked = true;
                    }
                }
            }
            else
            {
                string[] EmployeeListSplit = EmployeeList.Split(',');
                foreach (string Employee in EmployeeListSplit)
                {
                    for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                    {
                        if (EmployeeListCheckBox.Items[a].Text.Equals(Employee.Trim()))
                        {
                            EmployeeListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
            }
        }

        bool InCheckedListBox(string text)
        {
            foreach (MaterialCheckbox Item in EmployeeListCheckBox.Items)
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
                NewTransactionDialog.SetEmployees(EmployeeListCheckBox.Items);
            }
            if (EditTransactionDialog != null)
            {
                EditTransactionDialog.SetEmployees(EmployeeListCheckBox.Items);
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectEmployeeDialog_Load(object sender, EventArgs e)
        {
            Timer Timer = new Timer();
            Timer.Interval = 1;
            Timer.Tick += (s, evt) =>
            {
                EmployeeListCheckBox.AutoScrollPosition = new Point(0, 0);
                Timer.Stop();
            };
            Timer.Start();
        }

        private void SelectEmployeeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewTransactionDialog != null)
            {
                if (NewTransactionDialog.EmployeeCheckedboxes != null)
                {
                    NewTransactionDialog.EmployeeCheckedboxes.Reverse();
                }
            }
            if (EditTransactionDialog != null)
            {
                if (EditTransactionDialog.EmployeeCheckedboxes != null)
                {
                    EditTransactionDialog.EmployeeCheckedboxes.Reverse();
                }
            }
        }

        private void SearchBarEmployee_TextChanged(object sender, EventArgs e)
        {
            EmployeeListCheckBox.Items.Clear();
            EmployeeListCheckBox.Controls.Clear();

            if (NewTransactionDialog != null)
            {
                List<EmployeeItem> Temp = new List<EmployeeItem>(GlobalEmployeeList);
                Temp.Sort(new EmployeeNameComparer());
                Temp.Reverse();

                foreach (EmployeeItem Employee in Temp)
                {
                    string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                    if (!InCheckedListBox(EmployeeDetail))
                    {
                        if (Employee.Name.ToUpper().Contains(SearchBarEmployee.Text.ToUpper()))
                        {
                            EmployeeListCheckBox.Items.Add(EmployeeDetail);
                        }
                        else if (string.IsNullOrEmpty(SearchBarEmployee.Text.ToUpper()))
                        {
                            EmployeeListCheckBox.Items.Add(EmployeeDetail);
                        }
                    }
                }

                if (NewTransactionDialog.EmployeeCheckedboxes != null)
                {
                    NewTransactionDialog.EmployeeCheckedboxes.Reverse();
                    for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                    {
                        if (NewTransactionDialog.EmployeeCheckedboxes[a].Checked)
                        {
                            EmployeeListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
            }
            if (EditTransactionDialog != null)
            {
                List<EmployeeItem> Temp = new List<EmployeeItem>(GlobalEmployeeList);
                Temp.Sort(new EmployeeNameComparer());
                Temp.Reverse();

                foreach (EmployeeItem Employee in Temp)
                {
                    string EmployeeDetail = $"{Employee.ID}: {Employee.Name}";
                    if (!InCheckedListBox(EmployeeDetail))
                    {
                        if (Employee.Name.ToUpper().Contains(SearchBarEmployee.Text.ToUpper()))
                        {
                            EmployeeListCheckBox.Items.Add(EmployeeDetail);
                        }
                        else if (string.IsNullOrEmpty(SearchBarEmployee.Text.ToUpper()))
                        {
                            EmployeeListCheckBox.Items.Add(EmployeeDetail);
                        }
                    }
                }

                if (EditTransactionDialog.EmployeeCheckedboxes != null)
                {
                    EditTransactionDialog.EmployeeCheckedboxes.Reverse();
                    for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                    {
                        if (EditTransactionDialog.EmployeeCheckedboxes[a].Checked)
                        {
                            EmployeeListCheckBox.Items[a].Checked = true;
                        }
                    }
                }
                else
                {
                    string[] EmployeeListSplit = EmployeeList.Split(',');
                    foreach (string Employee in EmployeeListSplit)
                    {
                        for (int a = 0; a < EmployeeListCheckBox.Items.Count; a++)
                        {
                            if (EmployeeListCheckBox.Items[a].Text.Equals(Employee.Trim()))
                            {
                                EmployeeListCheckBox.Items[a].Checked = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
