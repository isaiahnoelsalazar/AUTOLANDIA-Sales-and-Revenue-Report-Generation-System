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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewWeeklySalesButton = new MaterialSkin.Controls.MaterialButton();
            this.ViewMonthlySalesButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MonthlySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeeklySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ViewWeeklySalesButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ViewMonthlySalesButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 311);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 38);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // ViewWeeklySalesButton
            // 
            this.ViewWeeklySalesButton.AutoSize = false;
            this.ViewWeeklySalesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewWeeklySalesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ViewWeeklySalesButton.Depth = 0;
            this.ViewWeeklySalesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewWeeklySalesButton.HighEmphasis = true;
            this.ViewWeeklySalesButton.Icon = null;
            this.ViewWeeklySalesButton.Location = new System.Drawing.Point(0, 0);
            this.ViewWeeklySalesButton.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ViewWeeklySalesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewWeeklySalesButton.Name = "ViewWeeklySalesButton";
            this.ViewWeeklySalesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ViewWeeklySalesButton.Size = new System.Drawing.Size(305, 38);
            this.ViewWeeklySalesButton.TabIndex = 1;
            this.ViewWeeklySalesButton.Text = "View Weekly Sales Data";
            this.ViewWeeklySalesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ViewWeeklySalesButton.UseAccentColor = false;
            this.ViewWeeklySalesButton.UseVisualStyleBackColor = true;
            this.ViewWeeklySalesButton.Click += new System.EventHandler(this.ViewWeeklySalesButton_Click);
            // 
            // ViewMonthlySalesButton
            // 
            this.ViewMonthlySalesButton.AutoSize = false;
            this.ViewMonthlySalesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewMonthlySalesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ViewMonthlySalesButton.Depth = 0;
            this.ViewMonthlySalesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewMonthlySalesButton.HighEmphasis = true;
            this.ViewMonthlySalesButton.Icon = null;
            this.ViewMonthlySalesButton.Location = new System.Drawing.Point(313, 0);
            this.ViewMonthlySalesButton.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ViewMonthlySalesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewMonthlySalesButton.Name = "ViewMonthlySalesButton";
            this.ViewMonthlySalesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ViewMonthlySalesButton.Size = new System.Drawing.Size(305, 38);
            this.ViewMonthlySalesButton.TabIndex = 7;
            this.ViewMonthlySalesButton.Text = "View Monthly Sales Data";
            this.ViewMonthlySalesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ViewMonthlySalesButton.UseAccentColor = false;
            this.ViewMonthlySalesButton.UseVisualStyleBackColor = true;
            this.ViewMonthlySalesButton.Click += new System.EventHandler(this.ViewMonthlySalesButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MonthlySalesChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeeklySalesChart, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 295);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // MonthlySalesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MonthlySalesChart.ChartAreas.Add(chartArea1);
            this.MonthlySalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlySalesChart.Location = new System.Drawing.Point(313, 0);
            this.MonthlySalesChart.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MonthlySalesChart.Name = "MonthlySalesChart";
            this.MonthlySalesChart.Size = new System.Drawing.Size(305, 295);
            this.MonthlySalesChart.TabIndex = 1;
            this.MonthlySalesChart.Text = "Weekly Sales";
            // 
            // WeeklySalesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WeeklySalesChart.ChartAreas.Add(chartArea2);
            this.WeeklySalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeeklySalesChart.Location = new System.Drawing.Point(0, 0);
            this.WeeklySalesChart.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.WeeklySalesChart.Name = "WeeklySalesChart";
            this.WeeklySalesChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.WeeklySalesChart.Size = new System.Drawing.Size(305, 295);
            this.WeeklySalesChart.TabIndex = 0;
            this.WeeklySalesChart.Text = "Weekly Sales";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySalesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton ViewWeeklySalesButton;
        private MaterialSkin.Controls.MaterialButton ViewMonthlySalesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlySalesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeeklySalesChart;
    }
}