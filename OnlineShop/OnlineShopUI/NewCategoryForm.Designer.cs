
namespace OnlineShop
{
    partial class NewCategoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createNewCategoryFormCategoryValue = new System.Windows.Forms.TextBox();
            this.createNewCategoryFormCreateButton = new System.Windows.Forms.Button();
            this.createNewCategoryFormCategoryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createNewCategoryFormCategoryValue);
            this.groupBox1.Controls.Add(this.createNewCategoryFormCreateButton);
            this.groupBox1.Controls.Add(this.createNewCategoryFormCategoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 304);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a new category";
            // 
            // createNewCategoryFormCategoryValue
            // 
            this.createNewCategoryFormCategoryValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewCategoryFormCategoryValue.Location = new System.Drawing.Point(14, 92);
            this.createNewCategoryFormCategoryValue.Multiline = true;
            this.createNewCategoryFormCategoryValue.Name = "createNewCategoryFormCategoryValue";
            this.createNewCategoryFormCategoryValue.Size = new System.Drawing.Size(282, 45);
            this.createNewCategoryFormCategoryValue.TabIndex = 28;
            // 
            // createNewCategoryFormCreateButton
            // 
            this.createNewCategoryFormCreateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createNewCategoryFormCreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createNewCategoryFormCreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createNewCategoryFormCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewCategoryFormCreateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewCategoryFormCreateButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createNewCategoryFormCreateButton.Location = new System.Drawing.Point(14, 208);
            this.createNewCategoryFormCreateButton.Name = "createNewCategoryFormCreateButton";
            this.createNewCategoryFormCreateButton.Size = new System.Drawing.Size(282, 90);
            this.createNewCategoryFormCreateButton.TabIndex = 26;
            this.createNewCategoryFormCreateButton.Text = "Create new category";
            this.createNewCategoryFormCreateButton.UseVisualStyleBackColor = true;
            this.createNewCategoryFormCreateButton.Click += new System.EventHandler(this.createNewCategoryFormCreateButton_Click);
            // 
            // createNewCategoryFormCategoryLabel
            // 
            this.createNewCategoryFormCategoryLabel.AutoSize = true;
            this.createNewCategoryFormCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewCategoryFormCategoryLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createNewCategoryFormCategoryLabel.Location = new System.Drawing.Point(6, 32);
            this.createNewCategoryFormCategoryLabel.Name = "createNewCategoryFormCategoryLabel";
            this.createNewCategoryFormCategoryLabel.Size = new System.Drawing.Size(150, 45);
            this.createNewCategoryFormCategoryLabel.TabIndex = 27;
            this.createNewCategoryFormCategoryLabel.Text = "Category";
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCategoryForm";
            this.Text = "NewCategoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox createNewCategoryFormCategoryValue;
        private System.Windows.Forms.Button createNewCategoryFormCreateButton;
        private System.Windows.Forms.Label createNewCategoryFormCategoryLabel;
    }
}