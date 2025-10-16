namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class SummaryDialog
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
            this.DateRange = new MaterialSkin.Controls.MaterialLabel();
            this.SearchBarSummary = new MaterialSkin.Controls.MaterialTextBox();
            this.SummaryCalendar = new System.Windows.Forms.MonthCalendar();
            this.SummaryText = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // DateRange
            // 
            this.DateRange.Depth = 0;
            this.DateRange.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateRange.Location = new System.Drawing.Point(245, 80);
            this.DateRange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.DateRange.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateRange.Name = "DateRange";
            this.DateRange.Size = new System.Drawing.Size(385, 29);
            this.DateRange.TabIndex = 106;
            this.DateRange.Text = "Date - Date";
            this.DateRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchBarSummary
            // 
            this.SearchBarSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBarSummary.AnimateReadOnly = false;
            this.SearchBarSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBarSummary.Depth = 0;
            this.SearchBarSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBarSummary.Hint = "Search";
            this.SearchBarSummary.LeadingIcon = null;
            this.SearchBarSummary.Location = new System.Drawing.Point(245, 36);
            this.SearchBarSummary.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.SearchBarSummary.MaxLength = 50;
            this.SearchBarSummary.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchBarSummary.Multiline = false;
            this.SearchBarSummary.Name = "SearchBarSummary";
            this.SearchBarSummary.Size = new System.Drawing.Size(385, 36);
            this.SearchBarSummary.TabIndex = 103;
            this.SearchBarSummary.Text = "";
            this.SearchBarSummary.TrailingIcon = null;
            this.SearchBarSummary.UseTallSize = false;
            // 
            // SummaryCalendar
            // 
            this.SummaryCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.SummaryCalendar.Location = new System.Drawing.Point(10, 36);
            this.SummaryCalendar.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.SummaryCalendar.MaxSelectionCount = 1;
            this.SummaryCalendar.Name = "SummaryCalendar";
            this.SummaryCalendar.TabIndex = 102;
            this.SummaryCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.SummaryCalendar_DateSelected);
            // 
            // SummaryText
            // 
            this.SummaryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryText.Depth = 0;
            this.SummaryText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SummaryText.Location = new System.Drawing.Point(245, 117);
            this.SummaryText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SummaryText.MouseState = MaterialSkin.MouseState.HOVER;
            this.SummaryText.Name = "SummaryText";
            this.SummaryText.Size = new System.Drawing.Size(385, 230);
            this.SummaryText.TabIndex = 107;
            this.SummaryText.Text = "SummaryText";
            // 
            // SummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.SummaryText);
            this.Controls.Add(this.DateRange);
            this.Controls.Add(this.SearchBarSummary);
            this.Controls.Add(this.SummaryCalendar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "SummaryDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryDialog";
            this.Load += new System.EventHandler(this.SummaryDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel DateRange;
        private MaterialSkin.Controls.MaterialTextBox SearchBarSummary;
        private System.Windows.Forms.MonthCalendar SummaryCalendar;
        private MaterialSkin.Controls.MaterialLabel SummaryText;
    }
}