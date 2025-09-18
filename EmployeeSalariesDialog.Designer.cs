namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class EmployeeSalariesDialog
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBarEmployee = new MaterialSkin.Controls.MaterialTextBox();
            this.EmployeeCalendar = new System.Windows.Forms.MonthCalendar();
            this.EmployeeListContainer = new System.Windows.Forms.Panel();
            this.EmployeeList = new System.Windows.Forms.TableLayoutPanel();
            this.DateRange = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel2.SuspendLayout();
            this.EmployeeListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(245, 117);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 48);
            this.tableLayoutPanel2.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(239, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBarEmployee
            // 
            this.SearchBarEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBarEmployee.AnimateReadOnly = false;
            this.SearchBarEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBarEmployee.Depth = 0;
            this.SearchBarEmployee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBarEmployee.Hint = "Search";
            this.SearchBarEmployee.LeadingIcon = null;
            this.SearchBarEmployee.Location = new System.Drawing.Point(245, 36);
            this.SearchBarEmployee.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.SearchBarEmployee.MaxLength = 50;
            this.SearchBarEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchBarEmployee.Multiline = false;
            this.SearchBarEmployee.Name = "SearchBarEmployee";
            this.SearchBarEmployee.Size = new System.Drawing.Size(385, 36);
            this.SearchBarEmployee.TabIndex = 98;
            this.SearchBarEmployee.Text = "";
            this.SearchBarEmployee.TrailingIcon = null;
            this.SearchBarEmployee.UseTallSize = false;
            // 
            // EmployeeCalendar
            // 
            this.EmployeeCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.EmployeeCalendar.Location = new System.Drawing.Point(10, 36);
            this.EmployeeCalendar.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.EmployeeCalendar.Name = "EmployeeCalendar";
            this.EmployeeCalendar.ShowToday = false;
            this.EmployeeCalendar.ShowTodayCircle = false;
            this.EmployeeCalendar.TabIndex = 97;
            this.EmployeeCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.EmployeeCalendar_DateSelected);
            // 
            // EmployeeListContainer
            // 
            this.EmployeeListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeListContainer.AutoScroll = true;
            this.EmployeeListContainer.Controls.Add(this.EmployeeList);
            this.EmployeeListContainer.Location = new System.Drawing.Point(245, 165);
            this.EmployeeListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeListContainer.Name = "EmployeeListContainer";
            this.EmployeeListContainer.Size = new System.Drawing.Size(385, 182);
            this.EmployeeListContainer.TabIndex = 99;
            // 
            // EmployeeList
            // 
            this.EmployeeList.AutoSize = true;
            this.EmployeeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeList.ColumnCount = 1;
            this.EmployeeList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeList.Location = new System.Drawing.Point(0, 0);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowCount = 1;
            this.EmployeeList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmployeeList.Size = new System.Drawing.Size(385, 0);
            this.EmployeeList.TabIndex = 0;
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
            this.DateRange.TabIndex = 101;
            this.DateRange.Text = "Date - Date";
            this.DateRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeSalariesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.DateRange);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.SearchBarEmployee);
            this.Controls.Add(this.EmployeeCalendar);
            this.Controls.Add(this.EmployeeListContainer);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EmployeeSalariesDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalariesDialog";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.EmployeeListContainer.ResumeLayout(false);
            this.EmployeeListContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox SearchBarEmployee;
        private System.Windows.Forms.MonthCalendar EmployeeCalendar;
        private System.Windows.Forms.Panel EmployeeListContainer;
        private System.Windows.Forms.TableLayoutPanel EmployeeList;
        private MaterialSkin.Controls.MaterialLabel DateRange;
    }
}