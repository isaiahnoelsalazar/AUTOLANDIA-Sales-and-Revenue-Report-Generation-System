namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class EditEmployeesDataForm
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(319, 44);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(312, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "[Enter] to save an edit, [Esc] to cancel an edit";
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(9, 95);
            this.EmployeeTable.Margin = new System.Windows.Forms.Padding(6);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.Size = new System.Drawing.Size(622, 296);
            this.EmployeeTable.TabIndex = 15;
            this.EmployeeTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.EmployeeTable_CellBeginEdit);
            this.EmployeeTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeTable_CellValueChanged);
            this.EmployeeTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeTable_RowEnter);
            this.EmployeeTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.EmployeeTable_UserDeletingRow);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(9, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 16, 6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(266, 29);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Edit employee table data";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(9, 81);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(622, 2);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // EditEmployeesDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.EmployeeTable);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EditEmployeesDataForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployeesDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView EmployeeTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}