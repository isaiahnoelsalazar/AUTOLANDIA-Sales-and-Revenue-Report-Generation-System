namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class CustomersForm
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
            this.CustomerTable = new System.Windows.Forms.ListView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.AddNewCustomerButton = new MaterialSkin.Controls.MaterialButton();
            this.AssignCustomerButton = new MaterialSkin.Controls.MaterialButton();
            this.UnassignCustomerButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(15, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 29);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Customers";
            // 
            // CustomerTable
            // 
            this.CustomerTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerTable.HideSelection = false;
            this.CustomerTable.Location = new System.Drawing.Point(15, 70);
            this.CustomerTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.Size = new System.Drawing.Size(930, 275);
            this.CustomerTable.TabIndex = 4;
            this.CustomerTable.UseCompatibleStateImageBehavior = false;
            this.CustomerTable.View = System.Windows.Forms.View.Details;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 56);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(930, 2);
            this.materialDivider1.TabIndex = 3;
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
            this.AddNewCustomerButton.Location = new System.Drawing.Point(781, 15);
            this.AddNewCustomerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddNewCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewCustomerButton.Size = new System.Drawing.Size(167, 36);
            this.AddNewCustomerButton.TabIndex = 0;
            this.AddNewCustomerButton.Text = "Add new customer";
            this.AddNewCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewCustomerButton.UseAccentColor = false;
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // AssignCustomerButton
            // 
            this.AssignCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AssignCustomerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AssignCustomerButton.Depth = 0;
            this.AssignCustomerButton.HighEmphasis = true;
            this.AssignCustomerButton.Icon = null;
            this.AssignCustomerButton.Location = new System.Drawing.Point(529, 15);
            this.AssignCustomerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AssignCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AssignCustomerButton.Name = "AssignCustomerButton";
            this.AssignCustomerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AssignCustomerButton.Size = new System.Drawing.Size(240, 36);
            this.AssignCustomerButton.TabIndex = 1;
            this.AssignCustomerButton.Text = "Assign customer to vehicle";
            this.AssignCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AssignCustomerButton.UseAccentColor = false;
            this.AssignCustomerButton.UseVisualStyleBackColor = true;
            this.AssignCustomerButton.Click += new System.EventHandler(this.AssignCustomerButton_Click);
            // 
            // UnassignCustomerButton
            // 
            this.UnassignCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnassignCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnassignCustomerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UnassignCustomerButton.Depth = 0;
            this.UnassignCustomerButton.HighEmphasis = true;
            this.UnassignCustomerButton.Icon = null;
            this.UnassignCustomerButton.Location = new System.Drawing.Point(257, 15);
            this.UnassignCustomerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UnassignCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnassignCustomerButton.Name = "UnassignCustomerButton";
            this.UnassignCustomerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UnassignCustomerButton.Size = new System.Drawing.Size(260, 36);
            this.UnassignCustomerButton.TabIndex = 2;
            this.UnassignCustomerButton.Text = "Unassign customer to vehicle";
            this.UnassignCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UnassignCustomerButton.UseAccentColor = false;
            this.UnassignCustomerButton.UseVisualStyleBackColor = true;
            this.UnassignCustomerButton.Click += new System.EventHandler(this.UnassignCustomerButton_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 360);
            this.Controls.Add(this.UnassignCustomerButton);
            this.Controls.Add(this.AssignCustomerButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CustomerTable);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.AddNewCustomerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView CustomerTable;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton AddNewCustomerButton;
        private MaterialSkin.Controls.MaterialButton AssignCustomerButton;
        private MaterialSkin.Controls.MaterialButton UnassignCustomerButton;
    }
}