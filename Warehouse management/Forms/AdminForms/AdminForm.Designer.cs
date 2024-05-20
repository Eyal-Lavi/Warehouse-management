namespace Warehouse_management
{
    partial class AdminForm
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
            this.panel_BackGroud = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton_AddUser = new FontAwesome.Sharp.IconButton();
            this.iconButton_AddBranch = new FontAwesome.Sharp.IconButton();
            this.iconButton_Company = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel_BackGroud.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BackGroud
            // 
            this.panel_BackGroud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_BackGroud.Controls.Add(this.panelDesktop);
            this.panel_BackGroud.Controls.Add(this.panelMenu);
            this.panel_BackGroud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BackGroud.Location = new System.Drawing.Point(0, 0);
            this.panel_BackGroud.Name = "panel_BackGroud";
            this.panel_BackGroud.Size = new System.Drawing.Size(963, 549);
            this.panel_BackGroud.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(799, 549);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton_AddUser);
            this.panelMenu.Controls.Add(this.iconButton_AddBranch);
            this.panelMenu.Controls.Add(this.iconButton_Company);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Location = new System.Drawing.Point(799, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(164, 549);
            this.panelMenu.TabIndex = 6;
            // 
            // iconButton_AddUser
            // 
            this.iconButton_AddUser.FlatAppearance.BorderSize = 0;
            this.iconButton_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_AddUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddUser.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            this.iconButton_AddUser.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_AddUser.Location = new System.Drawing.Point(0, 258);
            this.iconButton_AddUser.Name = "iconButton_AddUser";
            this.iconButton_AddUser.Size = new System.Drawing.Size(164, 60);
            this.iconButton_AddUser.TabIndex = 10;
            this.iconButton_AddUser.Text = "Add user";
            this.iconButton_AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_AddUser.UseVisualStyleBackColor = true;
            this.iconButton_AddUser.Click += new System.EventHandler(this.iconButton_AddUser_Click);
            // 
            // iconButton_AddBranch
            // 
            this.iconButton_AddBranch.FlatAppearance.BorderSize = 0;
            this.iconButton_AddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_AddBranch.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddBranch.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            this.iconButton_AddBranch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddBranch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_AddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_AddBranch.Location = new System.Drawing.Point(0, 194);
            this.iconButton_AddBranch.Name = "iconButton_AddBranch";
            this.iconButton_AddBranch.Size = new System.Drawing.Size(164, 60);
            this.iconButton_AddBranch.TabIndex = 11;
            this.iconButton_AddBranch.Text = "Add Branch";
            this.iconButton_AddBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_AddBranch.UseVisualStyleBackColor = true;
            this.iconButton_AddBranch.Click += new System.EventHandler(this.iconButton_AddBranch_Click);
            // 
            // iconButton_Company
            // 
            this.iconButton_Company.FlatAppearance.BorderSize = 0;
            this.iconButton_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Company.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Company.IconChar = FontAwesome.Sharp.IconChar.SpellCheck;
            this.iconButton_Company.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Company.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Company.Location = new System.Drawing.Point(0, 132);
            this.iconButton_Company.Name = "iconButton_Company";
            this.iconButton_Company.Size = new System.Drawing.Size(164, 60);
            this.iconButton_Company.TabIndex = 8;
            this.iconButton_Company.Text = "Company";
            this.iconButton_Company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Company.UseVisualStyleBackColor = true;
            this.iconButton_Company.Click += new System.EventHandler(this.iconButton_Company_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 130);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelChildForm
            // 
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChildForm.Location = new System.Drawing.Point(56, 98);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(59, 17);
            this.labelChildForm.TabIndex = 9;
            this.labelChildForm.Text = "Settings";
            this.labelChildForm.Click += new System.EventHandler(this.labelChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 66;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(52, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(71, 66);
            this.iconCurrentChildForm.TabIndex = 8;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.panel_BackGroud);
            this.Name = "AdminForm";
            this.Text = "Manager options";
            this.panel_BackGroud.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_BackGroud;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton_Company;
        private FontAwesome.Sharp.IconButton iconButton_AddUser;
        private FontAwesome.Sharp.IconButton iconButton_AddBranch;
    }
}