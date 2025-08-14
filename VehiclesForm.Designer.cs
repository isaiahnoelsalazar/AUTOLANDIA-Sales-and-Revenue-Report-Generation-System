namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class VehiclesForm
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
            this.AddNewVehicleButton = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.VehicleTable = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // AddNewVehicleButton
            // 
            this.AddNewVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewVehicleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewVehicleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNewVehicleButton.Depth = 0;
            this.AddNewVehicleButton.HighEmphasis = true;
            this.AddNewVehicleButton.Icon = null;
            this.AddNewVehicleButton.Location = new System.Drawing.Point(476, 15);
            this.AddNewVehicleButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddNewVehicleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNewVehicleButton.Name = "AddNewVehicleButton";
            this.AddNewVehicleButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNewVehicleButton.Size = new System.Drawing.Size(149, 36);
            this.AddNewVehicleButton.TabIndex = 0;
            this.AddNewVehicleButton.Text = "Add new vehicle";
            this.AddNewVehicleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNewVehicleButton.UseAccentColor = false;
            this.AddNewVehicleButton.UseVisualStyleBackColor = true;
            this.AddNewVehicleButton.Click += new System.EventHandler(this.AddNewVehicleButton_Click);
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
            // VehicleTable
            // 
            this.VehicleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleTable.HideSelection = false;
            this.VehicleTable.Location = new System.Drawing.Point(15, 70);
            this.VehicleTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VehicleTable.Name = "VehicleTable";
            this.VehicleTable.Size = new System.Drawing.Size(610, 275);
            this.VehicleTable.TabIndex = 2;
            this.VehicleTable.UseCompatibleStateImageBehavior = false;
            this.VehicleTable.View = System.Windows.Forms.View.Details;
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
            this.materialLabel1.Size = new System.Drawing.Size(92, 29);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Vehicles";
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.VehicleTable);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.AddNewVehicleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton AddNewVehicleButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ListView VehicleTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}