using System;
using System.Drawing;
using System.Windows.Forms;
using static AUTOLANDIA_Sales_and_Revenue_Report_Generation_System.GlobalValues;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public partial class ServicesAndPackagesForm : Form
    {
        Color DefaultBackgroundColor;

        public ServicesAndPackagesForm()
        {
            InitializeComponent();

            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();
            ServiceList.VerticalScroll.Visible = true;
            ServiceList.HorizontalScroll.Enabled = false;
            ServiceList.HorizontalScroll.Visible = false;

            PackageList.Controls.Clear();
            PackageList.RowStyles.Clear();
            PackageList.VerticalScroll.Visible = true;
            PackageList.HorizontalScroll.Enabled = false;
            PackageList.HorizontalScroll.Visible = false;

            FilterService.Items.Add("ID");
            FilterService.Items.Add("Name");
            FilterService.SelectedIndex = 1;

            FilterPackage.Items.Add("ID");
            FilterPackage.Items.Add("Name");
            FilterPackage.Items.Add("Services Included");
            FilterPackage.SelectedIndex = 1;
        }

        public void RefreshServices()
        {
            RecreateGlobalServiceList();

            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();

            foreach (ServiceItem Service in GlobalServiceList)
            {
                RefreshRows(Service);
            }
        }

        public void RefreshPackages()
        {
            RecreateGlobalPackageList();

            PackageList.Controls.Clear();
            PackageList.RowStyles.Clear();

            foreach (PackageItem Package in GlobalPackageList)
            {
                RefreshRows(Package);
            }
        }

        private void ServicesAndPackagesForm_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.Width = ServiceList.Width;
            tableLayoutPanel1.Width = PackageList.Width;
            RefreshServices();
            RefreshPackages();
        }

        private void ServicesTab_Enter(object sender, EventArgs e)
        {
            tableLayoutPanel2.Width = ServiceList.Width;
        }

        private void PackagesTab_Enter(object sender, EventArgs e)
        {
            tableLayoutPanel1.Width = PackageList.Width;
        }

        private void SearchBarService_TextChanged(object sender, EventArgs e)
        {
            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();

            foreach (ServiceItem Service in GlobalServiceList)
            {
                if (FilterService.SelectedIndex == 0 || FilterService.SelectedIndex == -1)
                {
                    if (Service.ID.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                    {
                        RefreshRows(Service);
                    }
                }
                if (FilterService.SelectedIndex == 1)
                {
                    if (Service.Name.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                    {
                        RefreshRows(Service);
                    }
                }
            }
        }

        private void SearchBarPackage_TextChanged(object sender, EventArgs e)
        {
            PackageList.Controls.Clear();
            PackageList.RowStyles.Clear();

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (FilterPackage.SelectedIndex == 0 || FilterPackage.SelectedIndex == -1)
                {
                    if (Package.ID.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
                if (FilterPackage.SelectedIndex == 1)
                {
                    if (Package.Name.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
                if (FilterPackage.SelectedIndex == 2)
                {
                    if (Package.Details.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
            }
        }

        private void FilterPackage_TextChanged(object sender, EventArgs e)
        {
            PackageList.Controls.Clear();
            PackageList.RowStyles.Clear();

            foreach (PackageItem Package in GlobalPackageList)
            {
                if (FilterPackage.SelectedIndex == 0)
                {
                    if (Package.ID.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
                if (FilterPackage.SelectedIndex == 1)
                {
                    if (Package.Name.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
                if (FilterPackage.SelectedIndex == 2)
                {
                    if (Package.Details.ToUpper().Contains(SearchBarPackage.Text.ToUpper()))
                    {
                        RefreshRows(Package);
                    }
                }
            }
        }

        private void FilterService_TextChanged(object sender, EventArgs e)
        {
            ServiceList.Controls.Clear();
            ServiceList.RowStyles.Clear();

            foreach (ServiceItem Service in GlobalServiceList)
            {
                if (FilterService.SelectedIndex == 0)
                {
                    if (Service.ID.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                    {
                        RefreshRows(Service);
                    }
                }
                if (FilterService.SelectedIndex == 1)
                {
                    if (Service.Name.ToUpper().Contains(SearchBarService.Text.ToUpper()))
                    {
                        RefreshRows(Service);
                    }
                }
            }
        }

        void RefreshRows(PackageItem Package)
        {
            RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
            TableLayoutPanel Panel = new TableLayoutPanel
            {
                ColumnCount = 5
            };
            Label Id = new Label();
            Label Name = new Label();
            Label Details = new Label();
            Label Size = new Label();
            Label Price = new Label();

            if (DefaultBackgroundColor == null)
            {
                DefaultBackgroundColor = Panel.BackColor;
            }

            Panel.Dock = DockStyle.Fill;
            Panel.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Panel.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };
            Panel.ColumnStyles.Clear();
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            Panel.Margin = new Padding(0);

            Id.Dock = DockStyle.Fill;
            Id.Text = Package.ID;
            Id.TextAlign = ContentAlignment.MiddleCenter;
            Id.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Id.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Name.Dock = DockStyle.Fill;
            Name.Text = Package.Name;
            Name.TextAlign = ContentAlignment.MiddleCenter;
            Name.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Name.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Details.Dock = DockStyle.Fill;
            Details.Text = Package.Details;
            Details.TextAlign = ContentAlignment.MiddleCenter;
            Details.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Details.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Size.Dock = DockStyle.Fill;
            Size.Text = Package.Size;
            Size.TextAlign = ContentAlignment.MiddleCenter;
            Size.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Size.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Price.Dock = DockStyle.Fill;
            Price.Text = $"₱{Package.Price.ToString("0.00")}";
            Price.TextAlign = ContentAlignment.MiddleCenter;
            Price.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Price.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Panel.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };
            Id.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };
            Name.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };
            Details.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };
            Size.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };
            Price.Click += (sndr, evnt) =>
            {
                new EditPackageDialog(this, Package.ID).ShowDialog();
            };

            PackageList.RowStyles.Add(Row);
            Panel.Controls.Add(Id, 0, 0);
            Panel.Controls.Add(Name, 1, 0);
            Panel.Controls.Add(Details, 2, 0);
            Panel.Controls.Add(Size, 3, 0);
            Panel.Controls.Add(Price, 4, 0);
            PackageList.Controls.Add(Panel);

            tableLayoutPanel1.Width = PackageList.Width;
        }

        void RefreshRows(ServiceItem Service)
        {
            RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
            TableLayoutPanel Panel = new TableLayoutPanel
            {
                ColumnCount = 4
            };
            Label Id = new Label();
            Label Name = new Label();
            Label Size = new Label();
            Label Price = new Label();

            if (DefaultBackgroundColor == null)
            {
                DefaultBackgroundColor = Panel.BackColor;
            }

            Panel.Dock = DockStyle.Fill;
            Panel.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Panel.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };
            Panel.ColumnStyles.Clear();
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27f));
            Panel.Margin = new Padding(0);

            Id.Dock = DockStyle.Fill;
            Id.Text = Service.ID;
            Id.TextAlign = ContentAlignment.MiddleCenter;
            Id.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Id.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Name.Dock = DockStyle.Fill;
            Name.Text = Service.Name;
            Name.TextAlign = ContentAlignment.MiddleCenter;
            Name.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Name.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Size.Dock = DockStyle.Fill;
            Size.Text = Service.Size;
            Size.TextAlign = ContentAlignment.MiddleCenter;
            Size.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Size.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Price.Dock = DockStyle.Fill;
            Price.Text = $"₱{Service.Price.ToString("0.00")}";
            Price.TextAlign = ContentAlignment.MiddleCenter;
            Price.MouseEnter += (sndr, evnt) =>
            {
                Panel.BackColor = Color.FromArgb(200, 200, 200);
            };
            Price.MouseLeave += (sndr, evnt) =>
            {
                Panel.BackColor = DefaultBackgroundColor;
            };

            Panel.Click += (sndr, evnt) =>
            {
                new EditServiceDialog(this, Service.ID).ShowDialog();
            };
            Id.Click += (sndr, evnt) =>
            {
                new EditServiceDialog(this, Service.ID).ShowDialog();
            };
            Name.Click += (sndr, evnt) =>
            {
                new EditServiceDialog(this, Service.ID).ShowDialog();
            };
            Size.Click += (sndr, evnt) =>
            {
                new EditServiceDialog(this, Service.ID).ShowDialog();
            };
            Price.Click += (sndr, evnt) =>
            {
                new EditServiceDialog(this, Service.ID).ShowDialog();
            };

            ServiceList.RowStyles.Add(Row);
            Panel.Controls.Add(Id, 0, 0);
            Panel.Controls.Add(Name, 1, 0);
            Panel.Controls.Add(Size, 2, 0);
            Panel.Controls.Add(Price, 3, 0);
            ServiceList.Controls.Add(Panel);

            tableLayoutPanel2.Width = ServiceList.Width;
        }
    }
}
