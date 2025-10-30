namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class ShowGCashQRDialog
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
            this.Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Banner.Location = new System.Drawing.Point(3, 24);
            this.Banner.Margin = new System.Windows.Forms.Padding(0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(475, 694);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Banner.TabIndex = 2;
            this.Banner.TabStop = false;
            // 
            // ShowGCashQRDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 720);
            this.Controls.Add(this.Banner);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ShowGCashQRDialog";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowGCashQRDialog";
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Banner;
    }
}