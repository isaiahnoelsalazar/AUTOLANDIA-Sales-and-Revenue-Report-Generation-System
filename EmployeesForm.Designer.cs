namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class EmployeesForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.AddNewEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.EmployeeTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(15, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 29);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Employees";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 56);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(610, 2);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNewEmployeeButton.Depth = 0;
            this.AddNewEmployeeButton.HighEmphasis = true;
            this.AddNewEmployeeButton.Icon = null;
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(460, 15);
            this.AddNewEmployeeButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddNewEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(165, 36);
            this.AddNewEmployeeButton.TabIndex = 4;
            this.AddNewEmployeeButton.Text = "Add new employee";
            this.AddNewEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewEmployeeButton.UseAccentColor = false;
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButton_Click);
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.AutoSize = true;
            this.EmployeeTable.ColumnCount = 4;
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmployeeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeTable.Location = new System.Drawing.Point(0, 0);
            this.EmployeeTable.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowCount = 1;
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmployeeTable.Size = new System.Drawing.Size(606, 0);
            this.EmployeeTable.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmployeeTable);
            this.panel1.Location = new System.Drawing.Point(17, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 271);
            this.panel1.TabIndex = 9;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.AddNewEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton AddNewEmployeeButton;
        private System.Windows.Forms.TableLayoutPanel EmployeeTable;
        private System.Windows.Forms.Panel panel1;
    }
}