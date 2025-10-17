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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TransactionListContainer = new System.Windows.Forms.Panel();
            this.TransactionList = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.TransactionListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateRange
            // 
            this.DateRange.Depth = 0;
            this.DateRange.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateRange.Location = new System.Drawing.Point(476, 80);
            this.DateRange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.DateRange.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateRange.Name = "DateRange";
            this.DateRange.Size = new System.Drawing.Size(364, 29);
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
            this.SearchBarSummary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBarSummary.Hint = "Search";
            this.SearchBarSummary.LeadingIcon = null;
            this.SearchBarSummary.Location = new System.Drawing.Point(476, 36);
            this.SearchBarSummary.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.SearchBarSummary.MaxLength = 50;
            this.SearchBarSummary.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchBarSummary.Multiline = false;
            this.SearchBarSummary.Name = "SearchBarSummary";
            this.SearchBarSummary.Size = new System.Drawing.Size(364, 36);
            this.SearchBarSummary.TabIndex = 103;
            this.SearchBarSummary.Text = "";
            this.SearchBarSummary.TrailingIcon = null;
            this.SearchBarSummary.UseTallSize = false;
            // 
            // SummaryCalendar
            // 
            this.SummaryCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
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
            this.SummaryText.Location = new System.Drawing.Point(476, 117);
            this.SummaryText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.SummaryText.MouseState = MaterialSkin.MouseState.HOVER;
            this.SummaryText.Name = "SummaryText";
            this.SummaryText.Size = new System.Drawing.Size(364, 81);
            this.SummaryText.TabIndex = 107;
            this.SummaryText.Text = "SummaryText";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 206);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(830, 48);
            this.tableLayoutPanel2.TabIndex = 109;
            // 
            // TransactionListContainer
            // 
            this.TransactionListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionListContainer.AutoScroll = true;
            this.TransactionListContainer.Controls.Add(this.TransactionList);
            this.TransactionListContainer.Location = new System.Drawing.Point(10, 254);
            this.TransactionListContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.TransactionListContainer.Name = "TransactionListContainer";
            this.TransactionListContainer.Size = new System.Drawing.Size(830, 376);
            this.TransactionListContainer.TabIndex = 108;
            // 
            // TransactionList
            // 
            this.TransactionList.AutoSize = true;
            this.TransactionList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransactionList.ColumnCount = 1;
            this.TransactionList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransactionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionList.Location = new System.Drawing.Point(0, 0);
            this.TransactionList.Margin = new System.Windows.Forms.Padding(0);
            this.TransactionList.Name = "TransactionList";
            this.TransactionList.RowCount = 1;
            this.TransactionList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransactionList.Size = new System.Drawing.Size(830, 0);
            this.TransactionList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee(s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plate Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(339, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vehicle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(504, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Service/Package";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(669, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 640);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.TransactionListContainer);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TransactionListContainer.ResumeLayout(false);
            this.TransactionListContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel DateRange;
        private MaterialSkin.Controls.MaterialTextBox SearchBarSummary;
        private System.Windows.Forms.MonthCalendar SummaryCalendar;
        private MaterialSkin.Controls.MaterialLabel SummaryText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel TransactionListContainer;
        private System.Windows.Forms.TableLayoutPanel TransactionList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}