namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class NewOrderDialog
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
            this.CancelButton = new MaterialSkin.Controls.MaterialButton();
            this.DoneButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.RB_Package = new MaterialSkin.Controls.MaterialRadioButton();
            this.RB_Service = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CB_Vehicles = new MaterialSkin.Controls.MaterialComboBox();
            this.PackageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CB_Packages = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CB_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.SelectServicesButton = new MaterialSkin.Controls.MaterialButton();
            this.TB_Price = new MaterialSkin.Controls.MaterialTextBox2();
            this.ServiceTable = new System.Windows.Forms.ListView();
            this.PackageTable = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.CB_Employees = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelButton.Depth = 0;
            this.CancelButton.HighEmphasis = true;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(11, 463);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelButton.Size = new System.Drawing.Size(77, 36);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelButton.UseAccentColor = false;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoneButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DoneButton.Depth = 0;
            this.DoneButton.HighEmphasis = true;
            this.DoneButton.Icon = null;
            this.DoneButton.Location = new System.Drawing.Point(565, 463);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(8);
            this.DoneButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DoneButton.Size = new System.Drawing.Size(64, 36);
            this.DoneButton.TabIndex = 32;
            this.DoneButton.Text = "Done";
            this.DoneButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DoneButton.UseAccentColor = false;
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(11, 347);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(8);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 19);
            this.materialLabel6.TabIndex = 31;
            this.materialLabel6.Text = "Payment Method";
            // 
            // RB_Package
            // 
            this.RB_Package.AutoSize = true;
            this.RB_Package.Depth = 0;
            this.RB_Package.Location = new System.Drawing.Point(227, 227);
            this.RB_Package.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Package.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_Package.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_Package.Name = "RB_Package";
            this.RB_Package.Ripple = true;
            this.RB_Package.Size = new System.Drawing.Size(96, 37);
            this.RB_Package.TabIndex = 26;
            this.RB_Package.TabStop = true;
            this.RB_Package.Text = "Package";
            this.RB_Package.UseVisualStyleBackColor = true;
            this.RB_Package.Click += new System.EventHandler(this.RB_Package_Click);
            // 
            // RB_Service
            // 
            this.RB_Service.AutoSize = true;
            this.RB_Service.Depth = 0;
            this.RB_Service.Location = new System.Drawing.Point(139, 227);
            this.RB_Service.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Service.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_Service.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_Service.Name = "RB_Service";
            this.RB_Service.Ripple = true;
            this.RB_Service.Size = new System.Drawing.Size(86, 37);
            this.RB_Service.TabIndex = 25;
            this.RB_Service.TabStop = true;
            this.RB_Service.Text = "Service";
            this.RB_Service.UseVisualStyleBackColor = true;
            this.RB_Service.Click += new System.EventHandler(this.RB_Service_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(11, 237);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(8);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Type";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(11, 176);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Vehicle";
            // 
            // CB_Vehicles
            // 
            this.CB_Vehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Vehicles.AutoResize = false;
            this.CB_Vehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_Vehicles.Depth = 0;
            this.CB_Vehicles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_Vehicles.DropDownHeight = 174;
            this.CB_Vehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Vehicles.DropDownWidth = 121;
            this.CB_Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_Vehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_Vehicles.FormattingEnabled = true;
            this.CB_Vehicles.IntegralHeight = false;
            this.CB_Vehicles.ItemHeight = 43;
            this.CB_Vehicles.Location = new System.Drawing.Point(139, 162);
            this.CB_Vehicles.Margin = new System.Windows.Forms.Padding(8);
            this.CB_Vehicles.MaxDropDownItems = 4;
            this.CB_Vehicles.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_Vehicles.Name = "CB_Vehicles";
            this.CB_Vehicles.Size = new System.Drawing.Size(490, 49);
            this.CB_Vehicles.StartIndex = 0;
            this.CB_Vehicles.TabIndex = 40;
            this.CB_Vehicles.TextChanged += new System.EventHandler(this.CB_Vehicles_TextChanged);
            // 
            // PackageLabel
            // 
            this.PackageLabel.AutoSize = true;
            this.PackageLabel.Depth = 0;
            this.PackageLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PackageLabel.Location = new System.Drawing.Point(11, 286);
            this.PackageLabel.Margin = new System.Windows.Forms.Padding(8);
            this.PackageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PackageLabel.Name = "PackageLabel";
            this.PackageLabel.Size = new System.Drawing.Size(96, 19);
            this.PackageLabel.TabIndex = 46;
            this.PackageLabel.Text = "Pick Package";
            // 
            // CB_Packages
            // 
            this.CB_Packages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Packages.AutoResize = false;
            this.CB_Packages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_Packages.Depth = 0;
            this.CB_Packages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_Packages.DropDownHeight = 174;
            this.CB_Packages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Packages.DropDownWidth = 121;
            this.CB_Packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_Packages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_Packages.FormattingEnabled = true;
            this.CB_Packages.IntegralHeight = false;
            this.CB_Packages.ItemHeight = 43;
            this.CB_Packages.Location = new System.Drawing.Point(139, 270);
            this.CB_Packages.MaxDropDownItems = 4;
            this.CB_Packages.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_Packages.Name = "CB_Packages";
            this.CB_Packages.Size = new System.Drawing.Size(180, 49);
            this.CB_Packages.StartIndex = 0;
            this.CB_Packages.TabIndex = 47;
            this.CB_Packages.TextChanged += new System.EventHandler(this.CB_Packages_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 410);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(8);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(36, 19);
            this.materialLabel3.TabIndex = 49;
            this.materialLabel3.Text = "Price";
            // 
            // CB_PaymentMethod
            // 
            this.CB_PaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_PaymentMethod.AutoResize = false;
            this.CB_PaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_PaymentMethod.Depth = 0;
            this.CB_PaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_PaymentMethod.DropDownHeight = 174;
            this.CB_PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PaymentMethod.DropDownWidth = 121;
            this.CB_PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_PaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_PaymentMethod.FormattingEnabled = true;
            this.CB_PaymentMethod.IntegralHeight = false;
            this.CB_PaymentMethod.ItemHeight = 43;
            this.CB_PaymentMethod.Location = new System.Drawing.Point(139, 333);
            this.CB_PaymentMethod.Margin = new System.Windows.Forms.Padding(8);
            this.CB_PaymentMethod.MaxDropDownItems = 4;
            this.CB_PaymentMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_PaymentMethod.Name = "CB_PaymentMethod";
            this.CB_PaymentMethod.Size = new System.Drawing.Size(180, 49);
            this.CB_PaymentMethod.StartIndex = 0;
            this.CB_PaymentMethod.TabIndex = 50;
            // 
            // SelectServicesButton
            // 
            this.SelectServicesButton.AutoSize = false;
            this.SelectServicesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectServicesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SelectServicesButton.Depth = 0;
            this.SelectServicesButton.HighEmphasis = true;
            this.SelectServicesButton.Icon = null;
            this.SelectServicesButton.Location = new System.Drawing.Point(139, 270);
            this.SelectServicesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SelectServicesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectServicesButton.Name = "SelectServicesButton";
            this.SelectServicesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SelectServicesButton.Size = new System.Drawing.Size(180, 49);
            this.SelectServicesButton.TabIndex = 52;
            this.SelectServicesButton.Text = "Select Services";
            this.SelectServicesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SelectServicesButton.UseAccentColor = false;
            this.SelectServicesButton.UseVisualStyleBackColor = true;
            this.SelectServicesButton.Click += new System.EventHandler(this.SelectServicesButton_Click);
            // 
            // TB_Price
            // 
            this.TB_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Price.AnimateReadOnly = false;
            this.TB_Price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TB_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TB_Price.Depth = 0;
            this.TB_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Price.HideSelection = true;
            this.TB_Price.LeadingIcon = null;
            this.TB_Price.Location = new System.Drawing.Point(139, 398);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(8);
            this.TB_Price.MaxLength = 32767;
            this.TB_Price.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.PasswordChar = '\0';
            this.TB_Price.PrefixSuffixText = null;
            this.TB_Price.ReadOnly = true;
            this.TB_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_Price.SelectedText = "";
            this.TB_Price.SelectionLength = 0;
            this.TB_Price.SelectionStart = 0;
            this.TB_Price.ShortcutsEnabled = true;
            this.TB_Price.Size = new System.Drawing.Size(181, 48);
            this.TB_Price.TabIndex = 54;
            this.TB_Price.TabStop = false;
            this.TB_Price.Text = "0";
            this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_Price.TrailingIcon = null;
            this.TB_Price.UseSystemPasswordChar = false;
            // 
            // ServiceTable
            // 
            this.ServiceTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceTable.HideSelection = false;
            this.ServiceTable.Location = new System.Drawing.Point(331, 227);
            this.ServiceTable.Margin = new System.Windows.Forms.Padding(8);
            this.ServiceTable.Name = "ServiceTable";
            this.ServiceTable.Size = new System.Drawing.Size(298, 219);
            this.ServiceTable.TabIndex = 55;
            this.ServiceTable.UseCompatibleStateImageBehavior = false;
            this.ServiceTable.View = System.Windows.Forms.View.List;
            // 
            // PackageTable
            // 
            this.PackageTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageTable.HideSelection = false;
            this.PackageTable.Location = new System.Drawing.Point(331, 227);
            this.PackageTable.Margin = new System.Windows.Forms.Padding(8);
            this.PackageTable.Name = "PackageTable";
            this.PackageTable.Size = new System.Drawing.Size(298, 219);
            this.PackageTable.TabIndex = 56;
            this.PackageTable.UseCompatibleStateImageBehavior = false;
            this.PackageTable.View = System.Windows.Forms.View.List;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(9, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 16, 6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 29);
            this.materialLabel1.TabIndex = 57;
            this.materialLabel1.Text = "Create new order";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(9, 81);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(622, 2);
            this.materialDivider1.TabIndex = 58;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // CB_Employees
            // 
            this.CB_Employees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Employees.AutoResize = false;
            this.CB_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_Employees.Depth = 0;
            this.CB_Employees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_Employees.DropDownHeight = 174;
            this.CB_Employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Employees.DropDownWidth = 121;
            this.CB_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_Employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_Employees.FormattingEnabled = true;
            this.CB_Employees.IntegralHeight = false;
            this.CB_Employees.ItemHeight = 43;
            this.CB_Employees.Location = new System.Drawing.Point(139, 97);
            this.CB_Employees.Margin = new System.Windows.Forms.Padding(8);
            this.CB_Employees.MaxDropDownItems = 4;
            this.CB_Employees.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_Employees.Name = "CB_Employees";
            this.CB_Employees.Size = new System.Drawing.Size(490, 49);
            this.CB_Employees.StartIndex = 0;
            this.CB_Employees.TabIndex = 59;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(11, 111);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(8);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(70, 19);
            this.materialLabel5.TabIndex = 60;
            this.materialLabel5.Text = "Employee";
            // 
            // NewOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 510);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.CB_Employees);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.ServiceTable);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.CB_PaymentMethod);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.CB_Vehicles);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.RB_Package);
            this.Controls.Add(this.RB_Service);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.PackageTable);
            this.Controls.Add(this.SelectServicesButton);
            this.Controls.Add(this.CB_Packages);
            this.Controls.Add(this.PackageLabel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "NewOrderDialog";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrderDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton CancelButton;
        private MaterialSkin.Controls.MaterialButton DoneButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton RB_Package;
        private MaterialSkin.Controls.MaterialRadioButton RB_Service;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox CB_Vehicles;
        private MaterialSkin.Controls.MaterialLabel PackageLabel;
        private MaterialSkin.Controls.MaterialComboBox CB_Packages;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox CB_PaymentMethod;
        private MaterialSkin.Controls.MaterialButton SelectServicesButton;
        private MaterialSkin.Controls.MaterialTextBox2 TB_Price;
        private System.Windows.Forms.ListView ServiceTable;
        private System.Windows.Forms.ListView PackageTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialComboBox CB_Employees;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}