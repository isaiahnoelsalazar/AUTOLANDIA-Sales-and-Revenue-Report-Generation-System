namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class HomeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.WeeklySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MonthlySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewWeeklySalesButton = new MaterialSkin.Controls.MaterialButton();
            this.ViewMonthlySalesButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySalesChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeeklySalesChart
            // 
            chartArea3.Name = "ChartArea1";
            this.WeeklySalesChart.ChartAreas.Add(chartArea3);
            this.WeeklySalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeeklySalesChart.Location = new System.Drawing.Point(0, 0);
            this.WeeklySalesChart.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.WeeklySalesChart.Name = "WeeklySalesChart";
            this.WeeklySalesChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.WeeklySalesChart.Size = new System.Drawing.Size(301, 227);
            this.WeeklySalesChart.TabIndex = 0;
            this.WeeklySalesChart.Text = "Weekly Sales";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(15, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 29);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Summary";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 56);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(610, 2);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 227);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MonthlySalesChart
            // 
            chartArea4.Name = "ChartArea1";
            this.MonthlySalesChart.ChartAreas.Add(chartArea4);
            this.MonthlySalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlySalesChart.Location = new System.Drawing.Point(309, 0);
            this.MonthlySalesChart.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MonthlySalesChart.Name = "MonthlySalesChart";
            this.MonthlySalesChart.Size = new System.Drawing.Size(301, 227);
            this.MonthlySalesChart.TabIndex = 1;
            this.MonthlySalesChart.Text = "Weekly Sales";
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
            this.ViewWeeklySalesButton.Size = new System.Drawing.Size(301, 38);
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
            this.ViewMonthlySalesButton.Location = new System.Drawing.Point(309, 0);
            this.ViewMonthlySalesButton.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ViewMonthlySalesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewMonthlySalesButton.Name = "ViewMonthlySalesButton";
            this.ViewMonthlySalesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ViewMonthlySalesButton.Size = new System.Drawing.Size(301, 38);
            this.ViewMonthlySalesButton.TabIndex = 7;
            this.ViewMonthlySalesButton.Text = "View Monthly Sales Data";
            this.ViewMonthlySalesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ViewMonthlySalesButton.UseAccentColor = false;
            this.ViewMonthlySalesButton.UseVisualStyleBackColor = true;
            this.ViewMonthlySalesButton.Click += new System.EventHandler(this.ViewMonthlySalesButton_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 310);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(610, 38);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySalesChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WeeklySalesChart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton ViewWeeklySalesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlySalesChart;
        private MaterialSkin.Controls.MaterialButton ViewMonthlySalesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}