using System.Windows.Forms;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class PeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeListContainer = new System.Windows.Forms.Panel();
            this.EmployeeList = new System.Windows.Forms.TableLayoutPanel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.AddNewEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerListContainer = new System.Windows.Forms.Panel();
            this.CustomerList = new System.Windows.Forms.TableLayoutPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.AddNewCustomerButton = new MaterialSkin.Controls.MaterialButton();
            this.VehiclesTab = new System.Windows.Forms.TabPage();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.AddNewVehicleButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.VehicleListContainer = new System.Windows.Forms.Panel();
            this.VehicleList = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.EmployeeListContainer.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CustomerListContainer.SuspendLayout();
            this.VehiclesTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.VehicleListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeesTab);
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.VehiclesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 48);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 360);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.tableLayoutPanel2);
            this.EmployeesTab.Controls.Add(this.EmployeeListContainer);
            this.EmployeesTab.Controls.Add(this.materialDivider2);
            this.EmployeesTab.Controls.Add(this.AddNewEmployeeButton);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 52);
            this.EmployeesTab.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Size = new System.Drawing.Size(632, 304);
            this.EmployeesTab.TabIndex = 0;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            this.EmployeesTab.Enter += new System.EventHandler(this.EmployeesTab_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 62);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 48);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(469, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time Out";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(315, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time In";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(131, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeListContainer
            // 
            this.EmployeeListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeListContainer.AutoScroll = true;
            this.EmployeeListContainer.Controls.Add(this.EmployeeList);
            this.EmployeeListContainer.Location = new System.Drawing.Point(8, 110);
            this.EmployeeListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeListContainer.Name = "EmployeeListContainer";
            this.EmployeeListContainer.Size = new System.Drawing.Size(616, 189);
            this.EmployeeListContainer.TabIndex = 12;
            // 
            // EmployeeList
            // 
            this.EmployeeList.AutoSize = true;
            this.EmployeeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeList.ColumnCount = 1;
            this.EmployeeList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeList.Location = new System.Drawing.Point(0, 0);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowCount = 1;
            this.EmployeeList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeList.Size = new System.Drawing.Size(616, 0);
            this.EmployeeList.TabIndex = 0;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(8, 52);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(616, 2);
            this.materialDivider2.TabIndex = 11;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNewEmployeeButton.Depth = 0;
            this.AddNewEmployeeButton.HighEmphasis = true;
            this.AddNewEmployeeButton.Icon = null;
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(459, 8);
            this.AddNewEmployeeButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddNewEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(165, 36);
            this.AddNewEmployeeButton.TabIndex = 10;
            this.AddNewEmployeeButton.Text = "Add new employee";
            this.AddNewEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewEmployeeButton.UseAccentColor = false;
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButton_Click);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.tableLayoutPanel1);
            this.CustomersTab.Controls.Add(this.CustomerListContainer);
            this.CustomersTab.Controls.Add(this.materialDivider1);
            this.CustomersTab.Controls.Add(this.AddNewCustomerButton);
            this.CustomersTab.Location = new System.Drawing.Point(4, 52);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(632, 304);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            this.CustomersTab.Enter += new System.EventHandler(this.CustomersTab_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 48);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(365, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owned Vehicle Plate Numbers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(162, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerListContainer
            // 
            this.CustomerListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerListContainer.AutoScroll = true;
            this.CustomerListContainer.Controls.Add(this.CustomerList);
            this.CustomerListContainer.Location = new System.Drawing.Point(8, 110);
            this.CustomerListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerListContainer.Name = "CustomerListContainer";
            this.CustomerListContainer.Size = new System.Drawing.Size(616, 189);
            this.CustomerListContainer.TabIndex = 8;
            // 
            // CustomerList
            // 
            this.CustomerList.AutoSize = true;
            this.CustomerList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomerList.ColumnCount = 1;
            this.CustomerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerList.Location = new System.Drawing.Point(0, 0);
            this.CustomerList.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.RowCount = 1;
            this.CustomerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomerList.Size = new System.Drawing.Size(616, 0);
            this.CustomerList.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 52);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(616, 2);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewCustomerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNewCustomerButton.Depth = 0;
            this.AddNewCustomerButton.HighEmphasis = true;
            this.AddNewCustomerButton.Icon = null;
            this.AddNewCustomerButton.Location = new System.Drawing.Point(457, 8);
            this.AddNewCustomerButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddNewCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewCustomerButton.Size = new System.Drawing.Size(167, 36);
            this.AddNewCustomerButton.TabIndex = 1;
            this.AddNewCustomerButton.Text = "Add new customer";
            this.AddNewCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewCustomerButton.UseAccentColor = false;
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // VehiclesTab
            // 
            this.VehiclesTab.Controls.Add(this.tableLayoutPanel3);
            this.VehiclesTab.Controls.Add(this.VehicleListContainer);
            this.VehiclesTab.Controls.Add(this.materialDivider3);
            this.VehiclesTab.Controls.Add(this.AddNewVehicleButton);
            this.VehiclesTab.Location = new System.Drawing.Point(4, 52);
            this.VehiclesTab.Margin = new System.Windows.Forms.Padding(0);
            this.VehiclesTab.Name = "VehiclesTab";
            this.VehiclesTab.Size = new System.Drawing.Size(632, 304);
            this.VehiclesTab.TabIndex = 2;
            this.VehiclesTab.Text = "Vehicles";
            this.VehiclesTab.UseVisualStyleBackColor = true;
            this.VehiclesTab.Enter += new System.EventHandler(this.VehiclesTab_Enter);
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(8, 52);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(616, 2);
            this.materialDivider3.TabIndex = 9;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // AddNewVehicleButton
            // 
            this.AddNewVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewVehicleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewVehicleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNewVehicleButton.Depth = 0;
            this.AddNewVehicleButton.HighEmphasis = true;
            this.AddNewVehicleButton.Icon = null;
            this.AddNewVehicleButton.Location = new System.Drawing.Point(475, 8);
            this.AddNewVehicleButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddNewVehicleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewVehicleButton.Name = "AddNewVehicleButton";
            this.AddNewVehicleButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewVehicleButton.Size = new System.Drawing.Size(149, 36);
            this.AddNewVehicleButton.TabIndex = 8;
            this.AddNewVehicleButton.Text = "Add new vehicle";
            this.AddNewVehicleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewVehicleButton.UseAccentColor = false;
            this.AddNewVehicleButton.UseVisualStyleBackColor = true;
            this.AddNewVehicleButton.Click += new System.EventHandler(this.AddNewVehicleButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label13, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 48);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(376, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Plate Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(315, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Size";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(192, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Model";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(69, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Brand";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleListContainer
            // 
            this.VehicleListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleListContainer.AutoScroll = true;
            this.VehicleListContainer.Controls.Add(this.VehicleList);
            this.VehicleListContainer.Location = new System.Drawing.Point(8, 110);
            this.VehicleListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.VehicleListContainer.Name = "VehicleListContainer";
            this.VehicleListContainer.Size = new System.Drawing.Size(616, 189);
            this.VehicleListContainer.TabIndex = 18;
            // 
            // VehicleList
            // 
            this.VehicleList.AutoSize = true;
            this.VehicleList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VehicleList.ColumnCount = 1;
            this.VehicleList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.VehicleList.Location = new System.Drawing.Point(0, 0);
            this.VehicleList.Margin = new System.Windows.Forms.Padding(0);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.RowCount = 1;
            this.VehicleList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleList.Size = new System.Drawing.Size(616, 0);
            this.VehicleList.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "ID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(499, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Owner Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.EmployeesTab.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.EmployeeListContainer.ResumeLayout(false);
            this.EmployeeListContainer.PerformLayout();
            this.CustomersTab.ResumeLayout(false);
            this.CustomersTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CustomerListContainer.ResumeLayout(false);
            this.CustomerListContainer.PerformLayout();
            this.VehiclesTab.ResumeLayout(false);
            this.VehiclesTab.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.VehicleListContainer.ResumeLayout(false);
            this.VehicleListContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage EmployeesTab;
        private TabPage CustomersTab;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton AddNewCustomerButton;
        private TabPage VehiclesTab;
        private Panel CustomerListContainer;
        private TableLayoutPanel CustomerList;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel EmployeeListContainer;
        private TableLayoutPanel EmployeeList;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton AddNewEmployeeButton;
        private Label label7;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialButton AddNewVehicleButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel VehicleListContainer;
        private TableLayoutPanel VehicleList;
        private Label label12;
        private Label label13;
    }
}