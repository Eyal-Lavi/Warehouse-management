namespace Warehouse_management.Forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel_ChangePassword = new System.Windows.Forms.Panel();
            this.errorChangePassword_label = new System.Windows.Forms.Label();
            this.confirm_password_iconButton = new FontAwesome.Sharp.IconButton();
            this.Old_Password_textBox = new System.Windows.Forms.TextBox();
            this.NewPassword_textBox = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Management = new FontAwesome.Sharp.IconButton();
            this.btn_ExportToFile = new FontAwesome.Sharp.IconButton();
            this.btn_OrdersPending = new FontAwesome.Sharp.IconButton();
            this.btn_Inventory = new FontAwesome.Sharp.IconButton();
            this.btn_Order = new FontAwesome.Sharp.IconButton();
            this.btn_delivery = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.exit_iconButton = new FontAwesome.Sharp.IconButton();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.logoMid_pictureBox = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel_ChangePassword.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMid_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panel_ChangePassword);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btn_Management);
            this.panelMenu.Controls.Add(this.btn_ExportToFile);
            this.panelMenu.Controls.Add(this.btn_OrdersPending);
            this.panelMenu.Controls.Add(this.btn_Inventory);
            this.panelMenu.Controls.Add(this.btn_Order);
            this.panelMenu.Controls.Add(this.btn_delivery);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 659);
            this.panelMenu.TabIndex = 0;
            // 
            // panel_ChangePassword
            // 
            this.panel_ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_ChangePassword.Controls.Add(this.errorChangePassword_label);
            this.panel_ChangePassword.Controls.Add(this.confirm_password_iconButton);
            this.panel_ChangePassword.Controls.Add(this.Old_Password_textBox);
            this.panel_ChangePassword.Controls.Add(this.NewPassword_textBox);
            this.panel_ChangePassword.Location = new System.Drawing.Point(0, 506);
            this.panel_ChangePassword.Name = "panel_ChangePassword";
            this.panel_ChangePassword.Size = new System.Drawing.Size(217, 116);
            this.panel_ChangePassword.TabIndex = 8;
            this.panel_ChangePassword.Visible = false;
            // 
            // errorChangePassword_label
            // 
            this.errorChangePassword_label.AutoSize = true;
            this.errorChangePassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errorChangePassword_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.errorChangePassword_label.Location = new System.Drawing.Point(24, 97);
            this.errorChangePassword_label.Name = "errorChangePassword_label";
            this.errorChangePassword_label.Size = new System.Drawing.Size(177, 15);
            this.errorChangePassword_label.TabIndex = 3;
            this.errorChangePassword_label.Text = "Error in the information entered";
            this.errorChangePassword_label.Visible = false;
            // 
            // confirm_password_iconButton
            // 
            this.confirm_password_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_password_iconButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.confirm_password_iconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.confirm_password_iconButton.IconColor = System.Drawing.Color.Black;
            this.confirm_password_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirm_password_iconButton.Location = new System.Drawing.Point(32, 72);
            this.confirm_password_iconButton.Name = "confirm_password_iconButton";
            this.confirm_password_iconButton.Size = new System.Drawing.Size(160, 21);
            this.confirm_password_iconButton.TabIndex = 2;
            this.confirm_password_iconButton.Text = "Confirm";
            this.confirm_password_iconButton.UseVisualStyleBackColor = true;
            this.confirm_password_iconButton.Click += new System.EventHandler(this.confirm_password_iconButton_Click);
            // 
            // Old_Password_textBox
            // 
            this.Old_Password_textBox.Location = new System.Drawing.Point(12, 11);
            this.Old_Password_textBox.Name = "Old_Password_textBox";
            this.Old_Password_textBox.Size = new System.Drawing.Size(197, 20);
            this.Old_Password_textBox.TabIndex = 1;
            this.Old_Password_textBox.Text = "Enter your old Password";
            this.Old_Password_textBox.Click += new System.EventHandler(this.Old_Password_textBox_Click);
            // 
            // NewPassword_textBox
            // 
            this.NewPassword_textBox.Location = new System.Drawing.Point(12, 45);
            this.NewPassword_textBox.Name = "NewPassword_textBox";
            this.NewPassword_textBox.Size = new System.Drawing.Size(197, 20);
            this.NewPassword_textBox.TabIndex = 0;
            this.NewPassword_textBox.Text = "Enter your new Password";
            this.NewPassword_textBox.Click += new System.EventHandler(this.NewPassword_textBox_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(117, 624);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(103, 32);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Change Password";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 624);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(108, 32);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Logout";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_Management
            // 
            this.btn_Management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Management.FlatAppearance.BorderSize = 0;
            this.btn_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Management.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Management.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btn_Management.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Management.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Management.IconSize = 32;
            this.btn_Management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Management.Location = new System.Drawing.Point(0, 440);
            this.btn_Management.Name = "btn_Management";
            this.btn_Management.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Management.Size = new System.Drawing.Size(220, 60);
            this.btn_Management.TabIndex = 6;
            this.btn_Management.Text = "Management";
            this.btn_Management.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Management.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Management.UseVisualStyleBackColor = true;
            this.btn_Management.Click += new System.EventHandler(this.btn_Management_Click);
            // 
            // btn_ExportToFile
            // 
            this.btn_ExportToFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ExportToFile.FlatAppearance.BorderSize = 0;
            this.btn_ExportToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ExportToFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ExportToFile.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btn_ExportToFile.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_ExportToFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ExportToFile.IconSize = 32;
            this.btn_ExportToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportToFile.Location = new System.Drawing.Point(0, 380);
            this.btn_ExportToFile.Name = "btn_ExportToFile";
            this.btn_ExportToFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_ExportToFile.Size = new System.Drawing.Size(220, 60);
            this.btn_ExportToFile.TabIndex = 5;
            this.btn_ExportToFile.Text = "Export To File";
            this.btn_ExportToFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExportToFile.UseVisualStyleBackColor = true;
            this.btn_ExportToFile.Click += new System.EventHandler(this.btn_ExportToFile_Click);
            // 
            // btn_OrdersPending
            // 
            this.btn_OrdersPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_OrdersPending.FlatAppearance.BorderSize = 0;
            this.btn_OrdersPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrdersPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_OrdersPending.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_OrdersPending.IconChar = FontAwesome.Sharp.IconChar.FirstOrder;
            this.btn_OrdersPending.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_OrdersPending.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_OrdersPending.IconSize = 32;
            this.btn_OrdersPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrdersPending.Location = new System.Drawing.Point(0, 320);
            this.btn_OrdersPending.Name = "btn_OrdersPending";
            this.btn_OrdersPending.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_OrdersPending.Size = new System.Drawing.Size(220, 60);
            this.btn_OrdersPending.TabIndex = 4;
            this.btn_OrdersPending.Text = "Orders Pending";
            this.btn_OrdersPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrdersPending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OrdersPending.UseVisualStyleBackColor = true;
            this.btn_OrdersPending.Click += new System.EventHandler(this.btn_OrdersPending_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventory.FlatAppearance.BorderSize = 0;
            this.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Inventory.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btn_Inventory.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Inventory.IconSize = 32;
            this.btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 260);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Inventory.Size = new System.Drawing.Size(220, 60);
            this.btn_Inventory.TabIndex = 3;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Order.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Order.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Order.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Order.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Order.IconSize = 32;
            this.btn_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Order.Location = new System.Drawing.Point(0, 200);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Order.Size = new System.Drawing.Size(220, 60);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Order";
            this.btn_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_delivery
            // 
            this.btn_delivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delivery.FlatAppearance.BorderSize = 0;
            this.btn_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delivery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_delivery.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_delivery.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_delivery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delivery.IconSize = 32;
            this.btn_delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delivery.Location = new System.Drawing.Point(0, 140);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_delivery.Size = new System.Drawing.Size(220, 60);
            this.btn_delivery.TabIndex = 1;
            this.btn_delivery.Text = "delivery";
            this.btn_delivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delivery.UseVisualStyleBackColor = true;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.exit_iconButton);
            this.panelTitleBar.Controls.Add(this.labelChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(963, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // exit_iconButton
            // 
            this.exit_iconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.exit_iconButton.FlatAppearance.BorderSize = 0;
            this.exit_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_iconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_iconButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.exit_iconButton.IconColor = System.Drawing.Color.Black;
            this.exit_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_iconButton.Location = new System.Drawing.Point(888, 0);
            this.exit_iconButton.Name = "exit_iconButton";
            this.exit_iconButton.Size = new System.Drawing.Size(75, 75);
            this.exit_iconButton.TabIndex = 2;
            this.exit_iconButton.UseVisualStyleBackColor = false;
            this.exit_iconButton.Click += new System.EventHandler(this.exit_iconButton_Click);
            // 
            // labelChildForm
            // 
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChildForm.Location = new System.Drawing.Point(73, 34);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelChildForm.TabIndex = 1;
            this.labelChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(27, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(963, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.logoMid_pictureBox);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(963, 575);
            this.panelDesktop.TabIndex = 3;
            // 
            // logoMid_pictureBox
            // 
            this.logoMid_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoMid_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoMid_pictureBox.Image")));
            this.logoMid_pictureBox.Location = new System.Drawing.Point(368, 204);
            this.logoMid_pictureBox.Name = "logoMid_pictureBox";
            this.logoMid_pictureBox.Size = new System.Drawing.Size(225, 163);
            this.logoMid_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoMid_pictureBox.TabIndex = 0;
            this.logoMid_pictureBox.TabStop = false;
            this.logoMid_pictureBox.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 659);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel_ChangePassword.ResumeLayout(false);
            this.panel_ChangePassword.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMid_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_delivery;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_ExportToFile;
        private FontAwesome.Sharp.IconButton btn_OrdersPending;
        private FontAwesome.Sharp.IconButton btn_Inventory;
        private FontAwesome.Sharp.IconButton btn_Order;
        private FontAwesome.Sharp.IconButton btn_Management;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelChildForm;
        private FontAwesome.Sharp.IconButton exit_iconButton;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox logoMid_pictureBox;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel_ChangePassword;
        private FontAwesome.Sharp.IconButton confirm_password_iconButton;
        private System.Windows.Forms.TextBox Old_Password_textBox;
        private System.Windows.Forms.TextBox NewPassword_textBox;
        private System.Windows.Forms.Label errorChangePassword_label;
    }
}