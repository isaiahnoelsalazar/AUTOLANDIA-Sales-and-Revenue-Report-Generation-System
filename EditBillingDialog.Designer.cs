namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class EditBillingDialog
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
            this.TB_ID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CancelButton = new MaterialSkin.Controls.MaterialButton();
            this.DoneButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TB_Price = new MaterialSkin.Controls.MaterialTextBox();
            this.CB_Progress = new MaterialSkin.Controls.MaterialComboBox();
            this.TB_DateCreated = new MaterialSkin.Controls.MaterialLabel();
            this.TB_LastUpdated = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.CB_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.DiscountSlider = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_Unpaid = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // TB_ID
            // 
            this.TB_ID.AutoSize = true;
            this.TB_ID.Depth = 0;
            this.TB_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_ID.Location = new System.Drawing.Point(200, 105);
            this.TB_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(64, 19);
            this.TB_ID.TabIndex = 45;
            this.TB_ID.Text = "Billing ID";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(12, 326);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "Progress";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 164);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 19);
            this.materialLabel3.TabIndex = 41;
            this.materialLabel3.Text = "Order Balance";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 40;
            this.materialLabel2.Text = "Billing ID";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelButton.Depth = 0;
            this.CancelButton.HighEmphasis = true;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(10, 548);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelButton.Size = new System.Drawing.Size(77, 36);
            this.CancelButton.TabIndex = 39;
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
            this.DoneButton.Location = new System.Drawing.Point(566, 548);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(8);
            this.DoneButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DoneButton.Size = new System.Drawing.Size(64, 36);
            this.DoneButton.TabIndex = 38;
            this.DoneButton.Text = "Done";
            this.DoneButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DoneButton.UseAccentColor = false;
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(10, 36);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 29);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Edit billing details";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 81);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(8);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(620, 2);
            this.materialDivider1.TabIndex = 37;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TB_Price
            // 
            this.TB_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Price.AnimateReadOnly = false;
            this.TB_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Price.Depth = 0;
            this.TB_Price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Price.LeadingIcon = null;
            this.TB_Price.Location = new System.Drawing.Point(203, 149);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.TB_Price.MaxLength = 50;
            this.TB_Price.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_Price.Multiline = false;
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(427, 50);
            this.TB_Price.TabIndex = 49;
            this.TB_Price.Text = "";
            this.TB_Price.TrailingIcon = null;
            // 
            // CB_Progress
            // 
            this.CB_Progress.AutoResize = false;
            this.CB_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_Progress.Depth = 0;
            this.CB_Progress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_Progress.DropDownHeight = 174;
            this.CB_Progress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Progress.DropDownWidth = 121;
            this.CB_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_Progress.FormattingEnabled = true;
            this.CB_Progress.IntegralHeight = false;
            this.CB_Progress.ItemHeight = 43;
            this.CB_Progress.Location = new System.Drawing.Point(203, 312);
            this.CB_Progress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.CB_Progress.MaxDropDownItems = 4;
            this.CB_Progress.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_Progress.Name = "CB_Progress";
            this.CB_Progress.Size = new System.Drawing.Size(427, 49);
            this.CB_Progress.StartIndex = 0;
            this.CB_Progress.TabIndex = 84;
            // 
            // TB_DateCreated
            // 
            this.TB_DateCreated.AutoSize = true;
            this.TB_DateCreated.Depth = 0;
            this.TB_DateCreated.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_DateCreated.Location = new System.Drawing.Point(200, 499);
            this.TB_DateCreated.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_DateCreated.Name = "TB_DateCreated";
            this.TB_DateCreated.Size = new System.Drawing.Size(92, 19);
            this.TB_DateCreated.TabIndex = 95;
            this.TB_DateCreated.Text = "Date Created";
            // 
            // TB_LastUpdated
            // 
            this.TB_LastUpdated.AutoSize = true;
            this.TB_LastUpdated.Depth = 0;
            this.TB_LastUpdated.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_LastUpdated.Location = new System.Drawing.Point(200, 442);
            this.TB_LastUpdated.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_LastUpdated.Name = "TB_LastUpdated";
            this.TB_LastUpdated.Size = new System.Drawing.Size(95, 19);
            this.TB_LastUpdated.TabIndex = 94;
            this.TB_LastUpdated.Text = "Last Updated";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(12, 499);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 19);
            this.materialLabel6.TabIndex = 93;
            this.materialLabel6.Text = "Date Created";
            // 
            // CB_PaymentMethod
            // 
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
            this.CB_PaymentMethod.Location = new System.Drawing.Point(203, 369);
            this.CB_PaymentMethod.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.CB_PaymentMethod.MaxDropDownItems = 4;
            this.CB_PaymentMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_PaymentMethod.Name = "CB_PaymentMethod";
            this.CB_PaymentMethod.Size = new System.Drawing.Size(427, 49);
            this.CB_PaymentMethod.StartIndex = 0;
            this.CB_PaymentMethod.TabIndex = 92;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(12, 442);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(95, 19);
            this.materialLabel4.TabIndex = 91;
            this.materialLabel4.Text = "Last Updated";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(12, 383);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(122, 19);
            this.materialLabel7.TabIndex = 90;
            this.materialLabel7.Text = "Payment Method";
            // 
            // DiscountSlider
            // 
            this.DiscountSlider.Depth = 0;
            this.DiscountSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DiscountSlider.Location = new System.Drawing.Point(203, 207);
            this.DiscountSlider.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.DiscountSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscountSlider.Name = "DiscountSlider";
            this.DiscountSlider.Size = new System.Drawing.Size(427, 40);
            this.DiscountSlider.TabIndex = 96;
            this.DiscountSlider.Text = "";
            this.DiscountSlider.Value = 0;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(12, 217);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 19);
            this.materialLabel8.TabIndex = 97;
            this.materialLabel8.Text = "Discount";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(12, 269);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(51, 19);
            this.materialLabel9.TabIndex = 98;
            this.materialLabel9.Text = "Unpaid";
            // 
            // TB_Unpaid
            // 
            this.TB_Unpaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Unpaid.AnimateReadOnly = false;
            this.TB_Unpaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Unpaid.Depth = 0;
            this.TB_Unpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Unpaid.LeadingIcon = null;
            this.TB_Unpaid.Location = new System.Drawing.Point(203, 254);
            this.TB_Unpaid.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.TB_Unpaid.MaxLength = 50;
            this.TB_Unpaid.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_Unpaid.Multiline = false;
            this.TB_Unpaid.Name = "TB_Unpaid";
            this.TB_Unpaid.Size = new System.Drawing.Size(427, 50);
            this.TB_Unpaid.TabIndex = 100;
            this.TB_Unpaid.Text = "";
            this.TB_Unpaid.TrailingIcon = null;
            // 
            // EditBillingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 594);
            this.Controls.Add(this.TB_Unpaid);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.DiscountSlider);
            this.Controls.Add(this.TB_DateCreated);
            this.Controls.Add(this.TB_LastUpdated);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.CB_PaymentMethod);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.CB_Progress);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EditBillingDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBillingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel TB_ID;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton CancelButton;
        private MaterialSkin.Controls.MaterialButton DoneButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox TB_Price;
        private MaterialSkin.Controls.MaterialComboBox CB_Progress;
        private MaterialSkin.Controls.MaterialLabel TB_DateCreated;
        private MaterialSkin.Controls.MaterialLabel TB_LastUpdated;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox CB_PaymentMethod;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSlider DiscountSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox TB_Unpaid;
    }
}