namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class PreviewEmployeeDialog
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
            this.EditButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.EmployeeMobileNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EmployeeNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditButton.Depth = 0;
            this.EditButton.HighEmphasis = true;
            this.EditButton.Icon = null;
            this.EditButton.Location = new System.Drawing.Point(286, 194);
            this.EditButton.Margin = new System.Windows.Forms.Padding(8);
            this.EditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditButton.Name = "EditButton";
            this.EditButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditButton.Size = new System.Drawing.Size(64, 36);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditButton.UseAccentColor = false;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseButton.Depth = 0;
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(10, 194);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(8);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseButton.Size = new System.Drawing.Size(66, 36);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "Close";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EmployeeMobileNumberLabel
            // 
            this.EmployeeMobileNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeMobileNumberLabel.Depth = 0;
            this.EmployeeMobileNumberLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeeMobileNumberLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.EmployeeMobileNumberLabel.Location = new System.Drawing.Point(10, 81);
            this.EmployeeMobileNumberLabel.Margin = new System.Windows.Forms.Padding(8);
            this.EmployeeMobileNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeMobileNumberLabel.Name = "EmployeeMobileNumberLabel";
            this.EmployeeMobileNumberLabel.Size = new System.Drawing.Size(341, 29);
            this.EmployeeMobileNumberLabel.TabIndex = 23;
            this.EmployeeMobileNumberLabel.Text = "0000 000 0000";
            this.EmployeeMobileNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeNameLabel.Depth = 0;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeeNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(10, 36);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.EmployeeNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(340, 29);
            this.EmployeeNameLabel.TabIndex = 22;
            this.EmployeeNameLabel.Text = "Name";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 240);
            this.Controls.Add(this.EmployeeMobileNumberLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CloseButton);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EditEmployeeDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployeeDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton EditButton;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private MaterialSkin.Controls.MaterialLabel EmployeeMobileNumberLabel;
        private MaterialSkin.Controls.MaterialLabel EmployeeNameLabel;
    }
}