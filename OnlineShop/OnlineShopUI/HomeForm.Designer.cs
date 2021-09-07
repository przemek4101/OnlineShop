
namespace OnlineShop
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
            this.onlineShopLabel = new System.Windows.Forms.Label();
            this.homeFormSearchValue = new System.Windows.Forms.TextBox();
            this.homeFormCurrentlyLoggedLabel = new System.Windows.Forms.Label();
            this.homeFormProductsNameListBox = new System.Windows.Forms.ListBox();
            this.homeFormAddButton = new System.Windows.Forms.Button();
            this.homeFormQuantityValue = new System.Windows.Forms.TextBox();
            this.homeFormQuantityLabel = new System.Windows.Forms.Label();
            this.homeFormQuantityPlusButton = new System.Windows.Forms.Button();
            this.homeFormQuantityMinButton = new System.Windows.Forms.Button();
            this.homeFormTextProductNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homeFormTextProductNameValue = new System.Windows.Forms.Label();
            this.homeFormGoToCartButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.homeFormSearchButton = new System.Windows.Forms.Button();
            this.adminFormAdminOptionsLink = new System.Windows.Forms.LinkLabel();
            this.homeFormAdminRefreshButton = new System.Windows.Forms.Button();
            this.homeFormProductsDescriptionListBox = new System.Windows.Forms.ListBox();
            this.homeFormProductsPriceListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.homeFormSortBycomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.homeFormLogoutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.homeFormProductsCategoryListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // onlineShopLabel
            // 
            this.onlineShopLabel.AutoSize = true;
            this.onlineShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onlineShopLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.onlineShopLabel.Location = new System.Drawing.Point(12, 53);
            this.onlineShopLabel.Name = "onlineShopLabel";
            this.onlineShopLabel.Size = new System.Drawing.Size(239, 46);
            this.onlineShopLabel.TabIndex = 4;
            this.onlineShopLabel.Text = "OnlineShop";
            // 
            // homeFormSearchValue
            // 
            this.homeFormSearchValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.homeFormSearchValue.Location = new System.Drawing.Point(20, 123);
            this.homeFormSearchValue.Multiline = true;
            this.homeFormSearchValue.Name = "homeFormSearchValue";
            this.homeFormSearchValue.Size = new System.Drawing.Size(400, 45);
            this.homeFormSearchValue.TabIndex = 29;
            // 
            // homeFormCurrentlyLoggedLabel
            // 
            this.homeFormCurrentlyLoggedLabel.AutoSize = true;
            this.homeFormCurrentlyLoggedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.homeFormCurrentlyLoggedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormCurrentlyLoggedLabel.Location = new System.Drawing.Point(758, 9);
            this.homeFormCurrentlyLoggedLabel.Name = "homeFormCurrentlyLoggedLabel";
            this.homeFormCurrentlyLoggedLabel.Size = new System.Drawing.Size(152, 30);
            this.homeFormCurrentlyLoggedLabel.TabIndex = 34;
            this.homeFormCurrentlyLoggedLabel.Text = "RandomLogin";
            this.homeFormCurrentlyLoggedLabel.Click += new System.EventHandler(this.homeFormCurrentlyLoggedLabel_Click);
            // 
            // homeFormProductsNameListBox
            // 
            this.homeFormProductsNameListBox.FormattingEnabled = true;
            this.homeFormProductsNameListBox.HorizontalScrollbar = true;
            this.homeFormProductsNameListBox.ItemHeight = 16;
            this.homeFormProductsNameListBox.Location = new System.Drawing.Point(114, 242);
            this.homeFormProductsNameListBox.Name = "homeFormProductsNameListBox";
            this.homeFormProductsNameListBox.Size = new System.Drawing.Size(129, 324);
            this.homeFormProductsNameListBox.TabIndex = 37;
            this.homeFormProductsNameListBox.SelectedIndexChanged += new System.EventHandler(this.homeFormProductsListBox_SelectedIndexChanged);
            // 
            // homeFormAddButton
            // 
            this.homeFormAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormAddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormAddButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormAddButton.Location = new System.Drawing.Point(4, 249);
            this.homeFormAddButton.Name = "homeFormAddButton";
            this.homeFormAddButton.Size = new System.Drawing.Size(217, 86);
            this.homeFormAddButton.TabIndex = 38;
            this.homeFormAddButton.Text = "Add product to cart ";
            this.homeFormAddButton.UseVisualStyleBackColor = true;
            this.homeFormAddButton.Click += new System.EventHandler(this.homeFormAddButton_Click);
            // 
            // homeFormQuantityValue
            // 
            this.homeFormQuantityValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormQuantityValue.Location = new System.Drawing.Point(66, 170);
            this.homeFormQuantityValue.Multiline = true;
            this.homeFormQuantityValue.Name = "homeFormQuantityValue";
            this.homeFormQuantityValue.Size = new System.Drawing.Size(88, 49);
            this.homeFormQuantityValue.TabIndex = 40;
            this.homeFormQuantityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // homeFormQuantityLabel
            // 
            this.homeFormQuantityLabel.AutoSize = true;
            this.homeFormQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormQuantityLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormQuantityLabel.Location = new System.Drawing.Point(50, 119);
            this.homeFormQuantityLabel.Name = "homeFormQuantityLabel";
            this.homeFormQuantityLabel.Size = new System.Drawing.Size(123, 38);
            this.homeFormQuantityLabel.TabIndex = 39;
            this.homeFormQuantityLabel.Text = "Quantity";
            // 
            // homeFormQuantityPlusButton
            // 
            this.homeFormQuantityPlusButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormQuantityPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormQuantityPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormQuantityPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormQuantityPlusButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormQuantityPlusButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormQuantityPlusButton.Location = new System.Drawing.Point(164, 170);
            this.homeFormQuantityPlusButton.Name = "homeFormQuantityPlusButton";
            this.homeFormQuantityPlusButton.Size = new System.Drawing.Size(53, 49);
            this.homeFormQuantityPlusButton.TabIndex = 41;
            this.homeFormQuantityPlusButton.Text = "+";
            this.homeFormQuantityPlusButton.UseVisualStyleBackColor = true;
            this.homeFormQuantityPlusButton.Click += new System.EventHandler(this.homeFormQuantityPlusButton_Click);
            // 
            // homeFormQuantityMinButton
            // 
            this.homeFormQuantityMinButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormQuantityMinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormQuantityMinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormQuantityMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormQuantityMinButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormQuantityMinButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormQuantityMinButton.Location = new System.Drawing.Point(6, 170);
            this.homeFormQuantityMinButton.Name = "homeFormQuantityMinButton";
            this.homeFormQuantityMinButton.Size = new System.Drawing.Size(53, 49);
            this.homeFormQuantityMinButton.TabIndex = 42;
            this.homeFormQuantityMinButton.Text = "-";
            this.homeFormQuantityMinButton.UseVisualStyleBackColor = true;
            this.homeFormQuantityMinButton.Click += new System.EventHandler(this.homeFormQuantityMinButton_Click);
            // 
            // homeFormTextProductNameLabel
            // 
            this.homeFormTextProductNameLabel.AutoSize = true;
            this.homeFormTextProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormTextProductNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormTextProductNameLabel.Location = new System.Drawing.Point(6, 29);
            this.homeFormTextProductNameLabel.Name = "homeFormTextProductNameLabel";
            this.homeFormTextProductNameLabel.Size = new System.Drawing.Size(195, 38);
            this.homeFormTextProductNameLabel.TabIndex = 43;
            this.homeFormTextProductNameLabel.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.homeFormTextProductNameValue);
            this.groupBox1.Controls.Add(this.homeFormTextProductNameLabel);
            this.groupBox1.Controls.Add(this.homeFormGoToCartButton);
            this.groupBox1.Controls.Add(this.homeFormAddButton);
            this.groupBox1.Controls.Add(this.homeFormQuantityMinButton);
            this.groupBox1.Controls.Add(this.homeFormQuantityLabel);
            this.groupBox1.Controls.Add(this.homeFormQuantityPlusButton);
            this.groupBox1.Controls.Add(this.homeFormQuantityValue);
            this.groupBox1.Location = new System.Drawing.Point(706, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 443);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // homeFormTextProductNameValue
            // 
            this.homeFormTextProductNameValue.BackColor = System.Drawing.SystemColors.Control;
            this.homeFormTextProductNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormTextProductNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormTextProductNameValue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.homeFormTextProductNameValue.Location = new System.Drawing.Point(9, 67);
            this.homeFormTextProductNameValue.Name = "homeFormTextProductNameValue";
            this.homeFormTextProductNameValue.Size = new System.Drawing.Size(199, 49);
            this.homeFormTextProductNameValue.TabIndex = 44;
            this.homeFormTextProductNameValue.Text = "Product Name";
            // 
            // homeFormGoToCartButton
            // 
            this.homeFormGoToCartButton.BackColor = System.Drawing.Color.LightGray;
            this.homeFormGoToCartButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormGoToCartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormGoToCartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormGoToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormGoToCartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormGoToCartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormGoToCartButton.Location = new System.Drawing.Point(6, 361);
            this.homeFormGoToCartButton.Name = "homeFormGoToCartButton";
            this.homeFormGoToCartButton.Size = new System.Drawing.Size(215, 86);
            this.homeFormGoToCartButton.TabIndex = 45;
            this.homeFormGoToCartButton.Text = "Go to cart";
            this.homeFormGoToCartButton.UseVisualStyleBackColor = false;
            this.homeFormGoToCartButton.Click += new System.EventHandler(this.homeFormGoToCartButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OnlineShop.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(706, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 55);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // homeFormSearchButton
            // 
            this.homeFormSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormSearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormSearchButton.Image = global::OnlineShop.Properties.Resources.search;
            this.homeFormSearchButton.Location = new System.Drawing.Point(426, 122);
            this.homeFormSearchButton.Name = "homeFormSearchButton";
            this.homeFormSearchButton.Size = new System.Drawing.Size(51, 46);
            this.homeFormSearchButton.TabIndex = 30;
            this.homeFormSearchButton.UseVisualStyleBackColor = true;
            // 
            // adminFormAdminOptionsLink
            // 
            this.adminFormAdminOptionsLink.AutoSize = true;
            this.adminFormAdminOptionsLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminFormAdminOptionsLink.Location = new System.Drawing.Point(705, 70);
            this.adminFormAdminOptionsLink.Name = "adminFormAdminOptionsLink";
            this.adminFormAdminOptionsLink.Size = new System.Drawing.Size(138, 25);
            this.adminFormAdminOptionsLink.TabIndex = 46;
            this.adminFormAdminOptionsLink.TabStop = true;
            this.adminFormAdminOptionsLink.Text = "Admin options";
            this.adminFormAdminOptionsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminFormAdminOptionsLink_LinkClicked);
            // 
            // homeFormAdminRefreshButton
            // 
            this.homeFormAdminRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormAdminRefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormAdminRefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormAdminRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormAdminRefreshButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormAdminRefreshButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormAdminRefreshButton.Location = new System.Drawing.Point(855, 74);
            this.homeFormAdminRefreshButton.Name = "homeFormAdminRefreshButton";
            this.homeFormAdminRefreshButton.Size = new System.Drawing.Size(74, 30);
            this.homeFormAdminRefreshButton.TabIndex = 45;
            this.homeFormAdminRefreshButton.Text = "Refresh";
            this.homeFormAdminRefreshButton.UseVisualStyleBackColor = true;
            this.homeFormAdminRefreshButton.Click += new System.EventHandler(this.homeFormAdminRefreshButton_Click);
            // 
            // homeFormProductsDescriptionListBox
            // 
            this.homeFormProductsDescriptionListBox.FormattingEnabled = true;
            this.homeFormProductsDescriptionListBox.HorizontalScrollbar = true;
            this.homeFormProductsDescriptionListBox.ItemHeight = 16;
            this.homeFormProductsDescriptionListBox.Location = new System.Drawing.Point(249, 242);
            this.homeFormProductsDescriptionListBox.Name = "homeFormProductsDescriptionListBox";
            this.homeFormProductsDescriptionListBox.Size = new System.Drawing.Size(276, 324);
            this.homeFormProductsDescriptionListBox.TabIndex = 47;
            // 
            // homeFormProductsPriceListBox
            // 
            this.homeFormProductsPriceListBox.FormattingEnabled = true;
            this.homeFormProductsPriceListBox.HorizontalScrollbar = true;
            this.homeFormProductsPriceListBox.ItemHeight = 16;
            this.homeFormProductsPriceListBox.Location = new System.Drawing.Point(531, 242);
            this.homeFormProductsPriceListBox.Name = "homeFormProductsPriceListBox";
            this.homeFormProductsPriceListBox.Size = new System.Drawing.Size(91, 324);
            this.homeFormProductsPriceListBox.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(114, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(249, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Describtion";
            // 
            // homeFormSortBycomboBox
            // 
            this.homeFormSortBycomboBox.FormattingEnabled = true;
            this.homeFormSortBycomboBox.Location = new System.Drawing.Point(110, 172);
            this.homeFormSortBycomboBox.Name = "homeFormSortBycomboBox";
            this.homeFormSortBycomboBox.Size = new System.Drawing.Size(367, 24);
            this.homeFormSortBycomboBox.TabIndex = 70;
            this.homeFormSortBycomboBox.SelectedIndexChanged += new System.EventHandler(this.homeFormSortBycomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(20, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Sort By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(531, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Price [ zł.]";
            // 
            // homeFormLogoutButton
            // 
            this.homeFormLogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeFormLogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.homeFormLogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeFormLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeFormLogoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeFormLogoutButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeFormLogoutButton.Location = new System.Drawing.Point(763, 42);
            this.homeFormLogoutButton.Name = "homeFormLogoutButton";
            this.homeFormLogoutButton.Size = new System.Drawing.Size(166, 30);
            this.homeFormLogoutButton.TabIndex = 73;
            this.homeFormLogoutButton.Text = "Logout";
            this.homeFormLogoutButton.UseVisualStyleBackColor = true;
            this.homeFormLogoutButton.Click += new System.EventHandler(this.homeFormLogoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(20, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Category";
            // 
            // homeFormProductsCategoryListBox
            // 
            this.homeFormProductsCategoryListBox.FormattingEnabled = true;
            this.homeFormProductsCategoryListBox.HorizontalScrollbar = true;
            this.homeFormProductsCategoryListBox.ItemHeight = 16;
            this.homeFormProductsCategoryListBox.Location = new System.Drawing.Point(20, 241);
            this.homeFormProductsCategoryListBox.Name = "homeFormProductsCategoryListBox";
            this.homeFormProductsCategoryListBox.Size = new System.Drawing.Size(86, 324);
            this.homeFormProductsCategoryListBox.TabIndex = 74;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.homeFormProductsCategoryListBox);
            this.Controls.Add(this.homeFormLogoutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeFormSortBycomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeFormProductsPriceListBox);
            this.Controls.Add(this.homeFormProductsDescriptionListBox);
            this.Controls.Add(this.homeFormAdminRefreshButton);
            this.Controls.Add(this.adminFormAdminOptionsLink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.homeFormProductsNameListBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.homeFormCurrentlyLoggedLabel);
            this.Controls.Add(this.homeFormSearchButton);
            this.Controls.Add(this.homeFormSearchValue);
            this.Controls.Add(this.onlineShopLabel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label onlineShopLabel;
        private System.Windows.Forms.TextBox homeFormSearchValue;
        private System.Windows.Forms.Button homeFormSearchButton;
        private System.Windows.Forms.Label homeFormCurrentlyLoggedLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox homeFormProductsNameListBox;
        private System.Windows.Forms.Button homeFormAddButton;
        private System.Windows.Forms.TextBox homeFormQuantityValue;
        private System.Windows.Forms.Label homeFormQuantityLabel;
        private System.Windows.Forms.Button homeFormQuantityPlusButton;
        private System.Windows.Forms.Button homeFormQuantityMinButton;
        private System.Windows.Forms.Label homeFormTextProductNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label homeFormTextProductNameValue;
        private System.Windows.Forms.Button homeFormGoToCartButton;
        private System.Windows.Forms.LinkLabel adminFormAdminOptionsLink;
        private System.Windows.Forms.Button homeFormAdminRefreshButton;
        private System.Windows.Forms.ListBox homeFormProductsDescriptionListBox;
        private System.Windows.Forms.ListBox homeFormProductsPriceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox homeFormSortBycomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button homeFormLogoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox homeFormProductsCategoryListBox;
    }
}