namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    partial class LoginForm
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
            this.TB_Username = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_Password = new MaterialSkin.Controls.MaterialTextBox();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Username.AnimateReadOnly = false;
            this.TB_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Username.Depth = 0;
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Username.Hint = "Username";
            this.TB_Username.LeadingIcon = null;
            this.TB_Username.Location = new System.Drawing.Point(11, 149);
            this.TB_Username.Margin = new System.Windows.Forms.Padding(8);
            this.TB_Username.MaxLength = 50;
            this.TB_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_Username.Multiline = false;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(493, 50);
            this.TB_Username.TabIndex = 84;
            this.TB_Username.Text = "";
            this.TB_Username.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(11, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(493, 93);
            this.materialLabel1.TabIndex = 82;
            this.materialLabel1.Text = "Log In";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Password
            // 
            this.TB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Password.AnimateReadOnly = false;
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Password.Depth = 0;
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Password.Hint = "Password";
            this.TB_Password.LeadingIcon = null;
            this.TB_Password.Location = new System.Drawing.Point(11, 215);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(8);
            this.TB_Password.MaxLength = 50;
            this.TB_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.TB_Password.Multiline = false;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(493, 50);
            this.TB_Password.TabIndex = 85;
            this.TB_Password.Text = "";
            this.TB_Password.TrailingIcon = null;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginButton.Depth = 0;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(11, 317);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginButton.Size = new System.Drawing.Size(493, 49);
            this.LoginButton.TabIndex = 86;
            this.LoginButton.Text = "Log In";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TB_Username;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TB_Password;
        private MaterialSkin.Controls.MaterialButton LoginButton;
    }
}