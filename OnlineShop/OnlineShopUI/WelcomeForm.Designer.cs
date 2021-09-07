
namespace OnlineShop
{
    partial class welcomeForm
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
            this.onlineShopLabel = new System.Windows.Forms.Label();
            this.welcomeFormLoginButton = new System.Windows.Forms.Button();
            this.welcomeFormRegisterButton = new System.Windows.Forms.Button();
            this.welcomeFormExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onlineShopLabel
            // 
            this.onlineShopLabel.AutoSize = true;
            this.onlineShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onlineShopLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.onlineShopLabel.Location = new System.Drawing.Point(281, 25);
            this.onlineShopLabel.Name = "onlineShopLabel";
            this.onlineShopLabel.Size = new System.Drawing.Size(239, 46);
            this.onlineShopLabel.TabIndex = 3;
            this.onlineShopLabel.Text = "OnlineShop";
            // 
            // welcomeFormLoginButton
            // 
            this.welcomeFormLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.welcomeFormLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.welcomeFormLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeFormLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeFormLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeFormLoginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeFormLoginButton.Location = new System.Drawing.Point(223, 149);
            this.welcomeFormLoginButton.Name = "welcomeFormLoginButton";
            this.welcomeFormLoginButton.Size = new System.Drawing.Size(361, 68);
            this.welcomeFormLoginButton.TabIndex = 28;
            this.welcomeFormLoginButton.Text = "Login";
            this.welcomeFormLoginButton.UseVisualStyleBackColor = true;
            this.welcomeFormLoginButton.Click += new System.EventHandler(this.welcomeFormLoginButton_Click);
            // 
            // welcomeFormRegisterButton
            // 
            this.welcomeFormRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.welcomeFormRegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.welcomeFormRegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeFormRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeFormRegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeFormRegisterButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeFormRegisterButton.Location = new System.Drawing.Point(223, 223);
            this.welcomeFormRegisterButton.Name = "welcomeFormRegisterButton";
            this.welcomeFormRegisterButton.Size = new System.Drawing.Size(361, 68);
            this.welcomeFormRegisterButton.TabIndex = 29;
            this.welcomeFormRegisterButton.Text = "Register";
            this.welcomeFormRegisterButton.UseVisualStyleBackColor = true;
            this.welcomeFormRegisterButton.Click += new System.EventHandler(this.welcomeFormRegisterButton_Click);
            // 
            // welcomeFormExitButton
            // 
            this.welcomeFormExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.welcomeFormExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.welcomeFormExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeFormExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeFormExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeFormExitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeFormExitButton.Location = new System.Drawing.Point(223, 297);
            this.welcomeFormExitButton.Name = "welcomeFormExitButton";
            this.welcomeFormExitButton.Size = new System.Drawing.Size(361, 68);
            this.welcomeFormExitButton.TabIndex = 30;
            this.welcomeFormExitButton.Text = "Exit";
            this.welcomeFormExitButton.UseVisualStyleBackColor = true;
            this.welcomeFormExitButton.Click += new System.EventHandler(this.welcomeFormExitButton_Click);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeFormExitButton);
            this.Controls.Add(this.welcomeFormRegisterButton);
            this.Controls.Add(this.welcomeFormLoginButton);
            this.Controls.Add(this.onlineShopLabel);
            this.Name = "welcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label onlineShopLabel;
        private System.Windows.Forms.Button welcomeFormLoginButton;
        private System.Windows.Forms.Button welcomeFormRegisterButton;
        private System.Windows.Forms.Button welcomeFormExitButton;
    }
}

