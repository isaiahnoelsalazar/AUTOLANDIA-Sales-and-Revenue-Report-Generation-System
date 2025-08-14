namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class OrdersForm
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
            this.OrderTable = new System.Windows.Forms.ListView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.CreateNewOrderButton = new MaterialSkin.Controls.MaterialButton();
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
            this.materialLabel1.Size = new System.Drawing.Size(73, 29);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Orders";
            // 
            // OrderTable
            // 
            this.OrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderTable.HideSelection = false;
            this.OrderTable.Location = new System.Drawing.Point(15, 70);
            this.OrderTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.Size = new System.Drawing.Size(610, 275);
            this.OrderTable.TabIndex = 2;
            this.OrderTable.UseCompatibleStateImageBehavior = false;
            this.OrderTable.View = System.Windows.Forms.View.Details;
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
            this.materialDivider1.Size = new System.Drawing.Size(610, 2);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // CreateNewOrderButton
            // 
            this.CreateNewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateNewOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateNewOrderButton.Depth = 0;
            this.CreateNewOrderButton.HighEmphasis = true;
            this.CreateNewOrderButton.Icon = null;
            this.CreateNewOrderButton.Location = new System.Drawing.Point(463, 15);
            this.CreateNewOrderButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CreateNewOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateNewOrderButton.Name = "CreateNewOrderButton";
            this.CreateNewOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateNewOrderButton.Size = new System.Drawing.Size(162, 36);
            this.CreateNewOrderButton.TabIndex = 0;
            this.CreateNewOrderButton.Text = "Create new order";
            this.CreateNewOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateNewOrderButton.UseAccentColor = false;
            this.CreateNewOrderButton.UseVisualStyleBackColor = true;
            this.CreateNewOrderButton.Click += new System.EventHandler(this.CreateNewOrderButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.OrderTable);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.CreateNewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView OrderTable;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton CreateNewOrderButton;
    }
}