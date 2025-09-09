namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class ServicesAndPackagesForm
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
            this.ServicesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceListContainer = new System.Windows.Forms.Panel();
            this.ServiceList = new System.Windows.Forms.TableLayoutPanel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.EditServiceListButton = new MaterialSkin.Controls.MaterialButton();
            this.PackagesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PackageListContainer = new System.Windows.Forms.Panel();
            this.PackageList = new System.Windows.Forms.TableLayoutPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.EditPackageListButton = new MaterialSkin.Controls.MaterialButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ServicesTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ServiceListContainer.SuspendLayout();
            this.PackagesTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PackageListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServicesTab);
            this.tabControl1.Controls.Add(this.PackagesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 48);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 360);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // ServicesTab
            // 
            this.ServicesTab.Controls.Add(this.tableLayoutPanel2);
            this.ServicesTab.Controls.Add(this.ServiceListContainer);
            this.ServicesTab.Controls.Add(this.materialDivider2);
            this.ServicesTab.Controls.Add(this.EditServiceListButton);
            this.ServicesTab.Location = new System.Drawing.Point(4, 52);
            this.ServicesTab.Margin = new System.Windows.Forms.Padding(0);
            this.ServicesTab.Name = "ServicesTab";
            this.ServicesTab.Size = new System.Drawing.Size(632, 304);
            this.ServicesTab.TabIndex = 0;
            this.ServicesTab.Text = "Services";
            this.ServicesTab.UseVisualStyleBackColor = true;
            this.ServicesTab.Enter += new System.EventHandler(this.ServicesTab_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
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
            this.label7.Location = new System.Drawing.Point(457, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(365, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(131, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 32);
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
            // ServiceListContainer
            // 
            this.ServiceListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceListContainer.AutoScroll = true;
            this.ServiceListContainer.Controls.Add(this.ServiceList);
            this.ServiceListContainer.Location = new System.Drawing.Point(8, 110);
            this.ServiceListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceListContainer.Name = "ServiceListContainer";
            this.ServiceListContainer.Size = new System.Drawing.Size(616, 189);
            this.ServiceListContainer.TabIndex = 12;
            // 
            // ServiceList
            // 
            this.ServiceList.AutoSize = true;
            this.ServiceList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServiceList.ColumnCount = 1;
            this.ServiceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ServiceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceList.Location = new System.Drawing.Point(0, 0);
            this.ServiceList.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceList.Name = "ServiceList";
            this.ServiceList.RowCount = 1;
            this.ServiceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ServiceList.Size = new System.Drawing.Size(616, 0);
            this.ServiceList.TabIndex = 0;
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
            // EditServiceListButton
            // 
            this.EditServiceListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditServiceListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditServiceListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditServiceListButton.Depth = 0;
            this.EditServiceListButton.HighEmphasis = true;
            this.EditServiceListButton.Icon = null;
            this.EditServiceListButton.Location = new System.Drawing.Point(476, 8);
            this.EditServiceListButton.Margin = new System.Windows.Forms.Padding(8);
            this.EditServiceListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditServiceListButton.Name = "EditServiceListButton";
            this.EditServiceListButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditServiceListButton.Size = new System.Drawing.Size(148, 36);
            this.EditServiceListButton.TabIndex = 10;
            this.EditServiceListButton.Text = "Edit service list";
            this.EditServiceListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditServiceListButton.UseAccentColor = false;
            this.EditServiceListButton.UseVisualStyleBackColor = true;
            this.EditServiceListButton.Click += new System.EventHandler(this.EditServiceListButton_Click);
            // 
            // PackagesTab
            // 
            this.PackagesTab.Controls.Add(this.tableLayoutPanel1);
            this.PackagesTab.Controls.Add(this.PackageListContainer);
            this.PackagesTab.Controls.Add(this.materialDivider1);
            this.PackagesTab.Controls.Add(this.EditPackageListButton);
            this.PackagesTab.Location = new System.Drawing.Point(4, 52);
            this.PackagesTab.Margin = new System.Windows.Forms.Padding(0);
            this.PackagesTab.Name = "PackagesTab";
            this.PackagesTab.Size = new System.Drawing.Size(632, 304);
            this.PackagesTab.TabIndex = 1;
            this.PackagesTab.Text = "Packages";
            this.PackagesTab.UseVisualStyleBackColor = true;
            this.PackagesTab.Enter += new System.EventHandler(this.PackagesTab_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
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
            this.label3.Location = new System.Drawing.Point(229, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Services Included";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(106, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
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
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PackageListContainer
            // 
            this.PackageListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageListContainer.AutoScroll = true;
            this.PackageListContainer.Controls.Add(this.PackageList);
            this.PackageListContainer.Location = new System.Drawing.Point(8, 110);
            this.PackageListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PackageListContainer.Name = "PackageListContainer";
            this.PackageListContainer.Size = new System.Drawing.Size(616, 189);
            this.PackageListContainer.TabIndex = 8;
            // 
            // PackageList
            // 
            this.PackageList.AutoSize = true;
            this.PackageList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PackageList.ColumnCount = 1;
            this.PackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PackageList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PackageList.Location = new System.Drawing.Point(0, 0);
            this.PackageList.Margin = new System.Windows.Forms.Padding(0);
            this.PackageList.Name = "PackageList";
            this.PackageList.RowCount = 1;
            this.PackageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PackageList.Size = new System.Drawing.Size(616, 0);
            this.PackageList.TabIndex = 0;
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
            // EditPackageListButton
            // 
            this.EditPackageListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPackageListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditPackageListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditPackageListButton.Depth = 0;
            this.EditPackageListButton.HighEmphasis = true;
            this.EditPackageListButton.Icon = null;
            this.EditPackageListButton.Location = new System.Drawing.Point(468, 8);
            this.EditPackageListButton.Margin = new System.Windows.Forms.Padding(8);
            this.EditPackageListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditPackageListButton.Name = "EditPackageListButton";
            this.EditPackageListButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditPackageListButton.Size = new System.Drawing.Size(156, 36);
            this.EditPackageListButton.TabIndex = 1;
            this.EditPackageListButton.Text = "Edit package list";
            this.EditPackageListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditPackageListButton.UseAccentColor = false;
            this.EditPackageListButton.UseVisualStyleBackColor = true;
            this.EditPackageListButton.Click += new System.EventHandler(this.EditPackageListButton_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(426, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(499, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesAndPackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicesAndPackagesForm";
            this.Text = "ServicesAndPackagesForm";
            this.Load += new System.EventHandler(this.ServicesAndPackagesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ServicesTab.ResumeLayout(false);
            this.ServicesTab.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ServiceListContainer.ResumeLayout(false);
            this.ServiceListContainer.PerformLayout();
            this.PackagesTab.ResumeLayout(false);
            this.PackagesTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PackageListContainer.ResumeLayout(false);
            this.PackageListContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServicesTab;
        private System.Windows.Forms.TabPage PackagesTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PackageListContainer;
        private System.Windows.Forms.TableLayoutPanel PackageList;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton EditPackageListButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ServiceListContainer;
        private System.Windows.Forms.TableLayoutPanel ServiceList;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton EditServiceListButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}