using CSSimpleFunctions;
using MaterialSkin.Controls;
using System;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class NewCustomerDialog : MaterialForm
    {
        CustomersForm CustomersForm;

        public NewCustomerDialog(CustomersForm CustomersForm)
        {
            InitializeComponent();

            this.CustomersForm = CustomersForm;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";

            if (Check.HasNumbers(TB_Name.Text) || Check.HasSymbols(TB_Name.Text))
            {
                ErrorMessage += "Customer name cannot contain numbers nor symbols." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TB_Name.Text))
            {
                ErrorMessage += "Please enter the customer's name." + Environment.NewLine;
            }

            if (ErrorMessage.Equals(""))
            {
                try
                {
                    string Name = TB_Name.Text.ToUpper();
                    
                    DoneButton.Enabled = false;

                    new Do(() =>
                    {
                        string Query = $"INSERT INTO AUTOLANDIA_CustomerList(CustomerName, PlateNumbers) VALUES ('{Name}', '(None)')";
                        NewQuery(Query);
                    })
                    .AfterDo(() =>
                    {
                        MaterialMessageBox.Show("Successfully added new customer!", "Notice");
                        CustomersForm.RefreshCustomers();
                        Close();
                    });
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(exception.Message, "Alert");
                }
            }
            else
            {
                MaterialMessageBox.Show(ErrorMessage, "Alert");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
