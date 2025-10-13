namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DailyButton = new MaterialSkin.Controls.MaterialButton();
            this.MonthlyButton = new MaterialSkin.Controls.MaterialButton();
            this.EmployeeSalariesButton = new MaterialSkin.Controls.MaterialButton();
            this.DailySummaryButton = new MaterialSkin.Controls.MaterialButton();
            this.MonthlySummaryButton = new MaterialSkin.Controls.MaterialButton();
            this.ExportDataButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesChart
            // 
            this.SalesChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.SalesChart.ChartAreas.Add(chartArea1);
            this.SalesChart.Location = new System.Drawing.Point(169, 8);
            this.SalesChart.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.SalesChart.Size = new System.Drawing.Size(460, 461);
            this.SalesChart.TabIndex = 11;
            this.SalesChart.Text = "Sales";
            // 
            // DailyButton
            // 
            this.DailyButton.AutoSize = false;
            this.DailyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DailyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DailyButton.Depth = 0;
            this.DailyButton.HighEmphasis = true;
            this.DailyButton.Icon = null;
            this.DailyButton.Location = new System.Drawing.Point(11, 8);
            this.DailyButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.DailyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DailyButton.Name = "DailyButton";
            this.DailyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DailyButton.Size = new System.Drawing.Size(150, 36);
            this.DailyButton.TabIndex = 27;
            this.DailyButton.Text = "Daily Sales";
            this.DailyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DailyButton.UseAccentColor = false;
            this.DailyButton.UseVisualStyleBackColor = true;
            this.DailyButton.Click += new System.EventHandler(this.DailyButton_Click);
            // 
            // MonthlyButton
            // 
            this.MonthlyButton.AutoSize = false;
            this.MonthlyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MonthlyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MonthlyButton.Depth = 0;
            this.MonthlyButton.HighEmphasis = true;
            this.MonthlyButton.Icon = null;
            this.MonthlyButton.Location = new System.Drawing.Point(11, 52);
            this.MonthlyButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.MonthlyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MonthlyButton.Name = "MonthlyButton";
            this.MonthlyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MonthlyButton.Size = new System.Drawing.Size(150, 36);
            this.MonthlyButton.TabIndex = 29;
            this.MonthlyButton.Text = "Monthly Sales";
            this.MonthlyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MonthlyButton.UseAccentColor = false;
            this.MonthlyButton.UseVisualStyleBackColor = true;
            this.MonthlyButton.Click += new System.EventHandler(this.MonthlyButton_Click);
            // 
            // EmployeeSalariesButton
            // 
            this.EmployeeSalariesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeSalariesButton.AutoSize = false;
            this.EmployeeSalariesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeSalariesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EmployeeSalariesButton.Depth = 0;
            this.EmployeeSalariesButton.HighEmphasis = true;
            this.EmployeeSalariesButton.Icon = null;
            this.EmployeeSalariesButton.Location = new System.Drawing.Point(11, 433);
            this.EmployeeSalariesButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.EmployeeSalariesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeSalariesButton.Name = "EmployeeSalariesButton";
            this.EmployeeSalariesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EmployeeSalariesButton.Size = new System.Drawing.Size(150, 36);
            this.EmployeeSalariesButton.TabIndex = 31;
            this.EmployeeSalariesButton.Text = "Employee Salaries";
            this.EmployeeSalariesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EmployeeSalariesButton.UseAccentColor = false;
            this.EmployeeSalariesButton.UseVisualStyleBackColor = true;
            this.EmployeeSalariesButton.Click += new System.EventHandler(this.EmployeeSalariesButton_Click);
            // 
            // DailySummaryButton
            // 
            this.DailySummaryButton.AutoSize = false;
            this.DailySummaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DailySummaryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DailySummaryButton.Depth = 0;
            this.DailySummaryButton.HighEmphasis = true;
            this.DailySummaryButton.Icon = null;
            this.DailySummaryButton.Location = new System.Drawing.Point(11, 96);
            this.DailySummaryButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.DailySummaryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DailySummaryButton.Name = "DailySummaryButton";
            this.DailySummaryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DailySummaryButton.Size = new System.Drawing.Size(150, 50);
            this.DailySummaryButton.TabIndex = 32;
            this.DailySummaryButton.Text = "Daily Sales Summary";
            this.DailySummaryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DailySummaryButton.UseAccentColor = false;
            this.DailySummaryButton.UseVisualStyleBackColor = true;
            this.DailySummaryButton.Click += new System.EventHandler(this.DailySummaryButton_Click);
            // 
            // MonthlySummaryButton
            // 
            this.MonthlySummaryButton.AutoSize = false;
            this.MonthlySummaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MonthlySummaryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MonthlySummaryButton.Depth = 0;
            this.MonthlySummaryButton.HighEmphasis = true;
            this.MonthlySummaryButton.Icon = null;
            this.MonthlySummaryButton.Location = new System.Drawing.Point(11, 154);
            this.MonthlySummaryButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.MonthlySummaryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MonthlySummaryButton.Name = "MonthlySummaryButton";
            this.MonthlySummaryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MonthlySummaryButton.Size = new System.Drawing.Size(150, 50);
            this.MonthlySummaryButton.TabIndex = 33;
            this.MonthlySummaryButton.Text = "Monthly Sales Summary";
            this.MonthlySummaryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MonthlySummaryButton.UseAccentColor = false;
            this.MonthlySummaryButton.UseVisualStyleBackColor = true;
            this.MonthlySummaryButton.Click += new System.EventHandler(this.MonthlySummaryButton_Click);
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.AutoSize = false;
            this.ExportDataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportDataButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExportDataButton.Depth = 0;
            this.ExportDataButton.HighEmphasis = true;
            this.ExportDataButton.Icon = null;
            this.ExportDataButton.Location = new System.Drawing.Point(11, 212);
            this.ExportDataButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ExportDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExportDataButton.Size = new System.Drawing.Size(150, 36);
            this.ExportDataButton.TabIndex = 34;
            this.ExportDataButton.Text = "Export Data";
            this.ExportDataButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExportDataButton.UseAccentColor = false;
            this.ExportDataButton.UseVisualStyleBackColor = true;
            this.ExportDataButton.Click += new System.EventHandler(this.ExportDataButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.ExportDataButton);
            this.Controls.Add(this.MonthlySummaryButton);
            this.Controls.Add(this.DailySummaryButton);
            this.Controls.Add(this.EmployeeSalariesButton);
            this.Controls.Add(this.MonthlyButton);
            this.Controls.Add(this.DailyButton);
            this.Controls.Add(this.SalesChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private MaterialSkin.Controls.MaterialButton DailyButton;
        private MaterialSkin.Controls.MaterialButton MonthlyButton;
        private MaterialSkin.Controls.MaterialButton EmployeeSalariesButton;
        private MaterialSkin.Controls.MaterialButton DailySummaryButton;
        private MaterialSkin.Controls.MaterialButton MonthlySummaryButton;
        private MaterialSkin.Controls.MaterialButton ExportDataButton;
    }
}