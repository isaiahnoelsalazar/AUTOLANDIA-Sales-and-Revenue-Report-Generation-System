using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class SelectVehicleDialog : MaterialForm
    {
        Color DefaultBackgroundColor;
        LinkCustomerVehicleDialog LinkCustomerVehicleDialog;
        NewTransactionDialog NewTransactionDialog;
        EditTransactionDialog EditTransactionDialog;

        public SelectVehicleDialog(LinkCustomerVehicleDialog LinkCustomerVehicleDialog)
        {
            InitializeComponent();

            this.LinkCustomerVehicleDialog = LinkCustomerVehicleDialog;

            VehicleList.Controls.Clear();
            VehicleList.RowStyles.Clear();
            VehicleList.VerticalScroll.Visible = true;
            VehicleList.HorizontalScroll.Enabled = false;
            VehicleList.HorizontalScroll.Visible = false;

            RefreshVehicles();
        }

        public SelectVehicleDialog(NewTransactionDialog NewTransactionDialog)
        {
            InitializeComponent();

            this.NewTransactionDialog = NewTransactionDialog;

            VehicleList.Controls.Clear();
            VehicleList.RowStyles.Clear();
            VehicleList.VerticalScroll.Visible = true;
            VehicleList.HorizontalScroll.Enabled = false;
            VehicleList.HorizontalScroll.Visible = false;

            RefreshVehicles();
        }

        public SelectVehicleDialog(EditTransactionDialog EditTransactionDialog)
        {
            InitializeComponent();

            this.EditTransactionDialog = EditTransactionDialog;

            VehicleList.Controls.Clear();
            VehicleList.RowStyles.Clear();
            VehicleList.VerticalScroll.Visible = true;
            VehicleList.HorizontalScroll.Enabled = false;
            VehicleList.HorizontalScroll.Visible = false;

            RefreshVehicles();
        }

        public void RefreshVehicles()
        {
            VehicleList.Controls.Clear();
            VehicleList.RowStyles.Clear();

            foreach (VehicleItem Vehicle in GlobalVehicleList)
            {
                if (NewTransactionDialog != null)
                {
                    RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                    TableLayoutPanel Panel = new TableLayoutPanel
                    {
                        ColumnCount = 1
                    };
                    Label Name = new Label();

                    if (DefaultBackgroundColor == null)
                    {
                        DefaultBackgroundColor = Panel.BackColor;
                    }

                    Panel.Dock = DockStyle.Top;
                    Panel.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Panel.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };
                    Panel.ColumnStyles.Clear();
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
                    Panel.Margin = new Padding(0);

                    Name.Dock = DockStyle.Fill;
                    Name.Text = $"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}";
                    Name.TextAlign = ContentAlignment.MiddleLeft;
                    Name.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Name.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    Panel.Click += (sndr, evnt) =>
                    {
                        if (LinkCustomerVehicleDialog != null)
                        {
                            LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        if (NewTransactionDialog != null)
                        {
                            NewTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        Close();
                    };
                    Name.Click += (sndr, evnt) =>
                    {
                        if (LinkCustomerVehicleDialog != null)
                        {
                            LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        if (NewTransactionDialog != null)
                        {
                            NewTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        Close();
                    };

                    VehicleList.RowStyles.Add(Row);
                    Panel.Controls.Add(Name, 0, 0);
                    VehicleList.Controls.Add(Panel);
                }
                else if (EditTransactionDialog != null)
                {
                    RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                    TableLayoutPanel Panel = new TableLayoutPanel
                    {
                        ColumnCount = 1
                    };
                    Label Name = new Label();

                    if (DefaultBackgroundColor == null)
                    {
                        DefaultBackgroundColor = Panel.BackColor;
                    }

                    Panel.Dock = DockStyle.Top;
                    Panel.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Panel.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };
                    Panel.ColumnStyles.Clear();
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
                    Panel.Margin = new Padding(0);

                    Name.Dock = DockStyle.Fill;
                    Name.Text = $"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}";
                    Name.TextAlign = ContentAlignment.MiddleLeft;
                    Name.MouseEnter += (sndr, evnt) =>
                    {
                        Panel.BackColor = Color.FromArgb(200, 200, 200);
                    };
                    Name.MouseLeave += (sndr, evnt) =>
                    {
                        Panel.BackColor = DefaultBackgroundColor;
                    };

                    Panel.Click += (sndr, evnt) =>
                    {
                        if (LinkCustomerVehicleDialog != null)
                        {
                            LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        if (EditTransactionDialog != null)
                        {
                            EditTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        Close();
                    };
                    Name.Click += (sndr, evnt) =>
                    {
                        if (LinkCustomerVehicleDialog != null)
                        {
                            LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        if (EditTransactionDialog != null)
                        {
                            EditTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                        }
                        Close();
                    };

                    VehicleList.RowStyles.Add(Row);
                    Panel.Controls.Add(Name, 0, 0);
                    VehicleList.Controls.Add(Panel);
                }
                else
                {
                    if (Vehicle.CustomerID.Equals("(None)"))
                    {
                        RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
                        TableLayoutPanel Panel = new TableLayoutPanel
                        {
                            ColumnCount = 1
                        };
                        Label Name = new Label();

                        if (DefaultBackgroundColor == null)
                        {
                            DefaultBackgroundColor = Panel.BackColor;
                        }

                        Panel.Dock = DockStyle.Top;
                        Panel.MouseEnter += (sndr, evnt) =>
                        {
                            Panel.BackColor = Color.FromArgb(200, 200, 200);
                        };
                        Panel.MouseLeave += (sndr, evnt) =>
                        {
                            Panel.BackColor = DefaultBackgroundColor;
                        };
                        Panel.ColumnStyles.Clear();
                        Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
                        Panel.Margin = new Padding(0);

                        Name.Dock = DockStyle.Fill;
                        Name.Text = $"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}";
                        Name.TextAlign = ContentAlignment.MiddleLeft;
                        Name.MouseEnter += (sndr, evnt) =>
                        {
                            Panel.BackColor = Color.FromArgb(200, 200, 200);
                        };
                        Name.MouseLeave += (sndr, evnt) =>
                        {
                            Panel.BackColor = DefaultBackgroundColor;
                        };

                        Panel.Click += (sndr, evnt) =>
                        {
                            if (LinkCustomerVehicleDialog != null)
                            {
                                LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            if (NewTransactionDialog != null)
                            {
                                NewTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            if (EditTransactionDialog != null)
                            {
                                EditTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            Close();
                        };
                        Name.Click += (sndr, evnt) =>
                        {
                            if (LinkCustomerVehicleDialog != null)
                            {
                                LinkCustomerVehicleDialog.SetUnlinkedVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            if (NewTransactionDialog != null)
                            {
                                NewTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            if (EditTransactionDialog != null)
                            {
                                EditTransactionDialog.SetVehicle($"{Vehicle.ID}: {Vehicle.Brand}, {Vehicle.Model}, {Vehicle.PlateNumber}");
                            }
                            Close();
                        };

                        VehicleList.RowStyles.Add(Row);
                        Panel.Controls.Add(Name, 0, 0);
                        VehicleList.Controls.Add(Panel);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
