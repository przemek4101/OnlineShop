
namespace OnlineShop
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
            this.loginFormLoginValue = new System.Windows.Forms.TextBox();
            this.loginFormPasswordValue = new System.Windows.Forms.TextBox();
            this.loginFormLoginLabel = new System.Windows.Forms.Label();
            this.loginFormPasswordLabel = new System.Windows.Forms.Label();
            this.loginFormLoginButton = new System.Windows.Forms.Button();
            this.loginFormBackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormLoginValue
            // 
            this.loginFormLoginValue.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.loginFormLoginValue.Location = new System.Drawing.Point(198, 36);
            this.loginFormLoginValue.Multiline = true;
            this.loginFormLoginValue.Name = "loginFormLoginValue";
            this.loginFormLoginValue.Size = new System.Drawing.Size(204, 41);
            this.loginFormLoginValue.TabIndex = 0;
            this.loginFormLoginValue.Text = "admin";
            // 
            // loginFormPasswordValue
            // 
            this.loginFormPasswordValue.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.loginFormPasswordValue.Location = new System.Drawing.Point(198, 108);
            this.loginFormPasswordValue.Multiline = true;
            this.loginFormPasswordValue.Name = "loginFormPasswordValue";
            this.loginFormPasswordValue.Size = new System.Drawing.Size(204, 41);
            this.loginFormPasswordValue.TabIndex = 1;
            this.loginFormPasswordValue.Text = "admin";
            // 
            // loginFormLoginLabel
            // 
            this.loginFormLoginLabel.AutoSize = true;
            this.loginFormLoginLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginFormLoginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginFormLoginLabel.Location = new System.Drawing.Point(22, 32);
            this.loginFormLoginLabel.Name = "loginFormLoginLabel";
            this.loginFormLoginLabel.Size = new System.Drawing.Size(101, 45);
            this.loginFormLoginLabel.TabIndex = 2;
            this.loginFormLoginLabel.Text = "Login";
            // 
            // loginFormPasswordLabel
            // 
            this.loginFormPasswordLabel.AutoSize = true;
            this.loginFormPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginFormPasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginFormPasswordLabel.Location = new System.Drawing.Point(22, 104);
            this.loginFormPasswordLabel.Name = "loginFormPasswordLabel";
            this.loginFormPasswordLabel.Size = new System.Drawing.Size(155, 45);
            this.loginFormPasswordLabel.TabIndex = 3;
            this.loginFormPasswordLabel.Text = "Password";
            // 
            // loginFormLoginButton
            // 
            this.loginFormLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loginFormLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.loginFormLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loginFormLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginFormLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginFormLoginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginFormLoginButton.Location = new System.Drawing.Point(30, 218);
            this.loginFormLoginButton.Name = "loginFormLoginButton";
            this.loginFormLoginButton.Size = new System.Drawing.Size(372, 68);
            this.loginFormLoginButton.TabIndex = 27;
            this.loginFormLoginButton.Text = "Login";
            this.loginFormLoginButton.UseVisualStyleBackColor = true;
            this.loginFormLoginButton.Click += new System.EventHandler(this.loginFormLoginButton_Click);
            // 
            // loginFormBackButton
            // 
            this.loginFormBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loginFormBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.loginFormBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loginFormBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginFormBackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginFormBackButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginFormBackButton.Location = new System.Drawing.Point(12, 412);
            this.loginFormBackButton.Name = "loginFormBackButton";
            this.loginFormBackButton.Size = new System.Drawing.Size(176, 56);
            this.loginFormBackButton.TabIndex = 32;
            this.loginFormBackButton.Text = "Back";
            this.loginFormBackButton.UseVisualStyleBackColor = true;
            this.loginFormBackButton.Click += new System.EventHandler(this.loginFormBackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginFormLoginLabel);
            this.groupBox1.Controls.Add(this.loginFormLoginValue);
            this.groupBox1.Controls.Add(this.loginFormLoginButton);
            this.groupBox1.Controls.Add(this.loginFormPasswordValue);
            this.groupBox1.Controls.Add(this.loginFormPasswordLabel);
            this.groupBox1.Location = new System.Drawing.Point(219, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 331);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginFormBackButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginFormLoginValue;
        private System.Windows.Forms.TextBox loginFormPasswordValue;
        private System.Windows.Forms.Label loginFormLoginLabel;
        private System.Windows.Forms.Label loginFormPasswordLabel;
        private System.Windows.Forms.Button loginFormLoginButton;
        private System.Windows.Forms.Button loginFormBackButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}