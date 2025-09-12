namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class ActivityRecordForm
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
            this.ActivityTable = new System.Windows.Forms.ListView();
            this.SearchBarActivity = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // ActivityTable
            // 
            this.ActivityTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivityTable.HideSelection = false;
            this.ActivityTable.Location = new System.Drawing.Point(9, 63);
            this.ActivityTable.Margin = new System.Windows.Forms.Padding(0);
            this.ActivityTable.Name = "ActivityTable";
            this.ActivityTable.Size = new System.Drawing.Size(622, 288);
            this.ActivityTable.TabIndex = 7;
            this.ActivityTable.UseCompatibleStateImageBehavior = false;
            this.ActivityTable.View = System.Windows.Forms.View.Details;
            // 
            // SearchBarActivity
            // 
            this.SearchBarActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBarActivity.AnimateReadOnly = false;
            this.SearchBarActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBarActivity.Depth = 0;
            this.SearchBarActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBarActivity.Hint = "Search";
            this.SearchBarActivity.LeadingIcon = null;
            this.SearchBarActivity.Location = new System.Drawing.Point(9, 9);
            this.SearchBarActivity.MaxLength = 50;
            this.SearchBarActivity.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchBarActivity.Multiline = false;
            this.SearchBarActivity.Name = "SearchBarActivity";
            this.SearchBarActivity.Size = new System.Drawing.Size(360, 36);
            this.SearchBarActivity.TabIndex = 24;
            this.SearchBarActivity.Text = "";
            this.SearchBarActivity.TrailingIcon = null;
            this.SearchBarActivity.UseTallSize = false;
            this.SearchBarActivity.TextChanged += new System.EventHandler(this.SearchBarActivity_TextChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(9, 53);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(622, 2);
            this.materialDivider2.TabIndex = 23;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // ActivityRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.SearchBarActivity);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.ActivityTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActivityRecordForm";
            this.Text = "ActivityRecordForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ActivityTable;
        private MaterialSkin.Controls.MaterialTextBox SearchBarActivity;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}