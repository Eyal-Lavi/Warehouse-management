namespace Warehouse_management.Forms
{
    partial class Company
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton_AddProductToCompany = new FontAwesome.Sharp.IconButton();
            this.iconButton_DelteProductFromCompany = new FontAwesome.Sharp.IconButton();
            this.iconButton_AddCompany = new FontAwesome.Sharp.IconButton();
            this.iconButton_DeleteCompany = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panelDesktop);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 497);
            this.panel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 40);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(823, 457);
            this.panelDesktop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton_AddProductToCompany);
            this.panel2.Controls.Add(this.iconButton_DelteProductFromCompany);
            this.panel2.Controls.Add(this.iconButton_AddCompany);
            this.panel2.Controls.Add(this.iconButton_DeleteCompany);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 40);
            this.panel2.TabIndex = 0;
            // 
            // iconButton_AddProductToCompany
            // 
            this.iconButton_AddProductToCompany.FlatAppearance.BorderSize = 0;
            this.iconButton_AddProductToCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_AddProductToCompany.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButton_AddProductToCompany.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddProductToCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_AddProductToCompany.Location = new System.Drawing.Point(415, 0);
            this.iconButton_AddProductToCompany.Name = "iconButton_AddProductToCompany";
            this.iconButton_AddProductToCompany.Size = new System.Drawing.Size(203, 40);
            this.iconButton_AddProductToCompany.TabIndex = 2;
            this.iconButton_AddProductToCompany.UseVisualStyleBackColor = true;
            this.iconButton_AddProductToCompany.Click += new System.EventHandler(this.iconButton_AddProductToCompany_Click);
            // 
            // iconButton_DelteProductFromCompany
            // 
            this.iconButton_DelteProductFromCompany.FlatAppearance.BorderSize = 0;
            this.iconButton_DelteProductFromCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_DelteProductFromCompany.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.iconButton_DelteProductFromCompany.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_DelteProductFromCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_DelteProductFromCompany.Location = new System.Drawing.Point(205, 0);
            this.iconButton_DelteProductFromCompany.Name = "iconButton_DelteProductFromCompany";
            this.iconButton_DelteProductFromCompany.Size = new System.Drawing.Size(211, 40);
            this.iconButton_DelteProductFromCompany.TabIndex = 1;
            this.iconButton_DelteProductFromCompany.UseVisualStyleBackColor = true;
            this.iconButton_DelteProductFromCompany.Click += new System.EventHandler(this.iconButton_DelteProductFromCompany_Click);
            // 
            // iconButton_AddCompany
            // 
            this.iconButton_AddCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton_AddCompany.FlatAppearance.BorderSize = 0;
            this.iconButton_AddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_AddCompany.IconChar = FontAwesome.Sharp.IconChar.NfcSymbol;
            this.iconButton_AddCompany.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_AddCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_AddCompany.Location = new System.Drawing.Point(618, 0);
            this.iconButton_AddCompany.Name = "iconButton_AddCompany";
            this.iconButton_AddCompany.Size = new System.Drawing.Size(205, 40);
            this.iconButton_AddCompany.TabIndex = 1;
            this.iconButton_AddCompany.UseVisualStyleBackColor = true;
            this.iconButton_AddCompany.Click += new System.EventHandler(this.iconButton_AddCompany_Click);
            // 
            // iconButton_DeleteCompany
            // 
            this.iconButton_DeleteCompany.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_DeleteCompany.FlatAppearance.BorderSize = 0;
            this.iconButton_DeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_DeleteCompany.IconChar = FontAwesome.Sharp.IconChar.OilWell;
            this.iconButton_DeleteCompany.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_DeleteCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_DeleteCompany.Location = new System.Drawing.Point(0, 0);
            this.iconButton_DeleteCompany.Name = "iconButton_DeleteCompany";
            this.iconButton_DeleteCompany.Size = new System.Drawing.Size(205, 40);
            this.iconButton_DeleteCompany.TabIndex = 1;
            this.iconButton_DeleteCompany.UseVisualStyleBackColor = true;
            this.iconButton_DeleteCompany.Click += new System.EventHandler(this.iconButton_DeleteCompany_Click);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Company";
            this.Text = "Company Product";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton_AddCompany;
        private FontAwesome.Sharp.IconButton iconButton_DelteProductFromCompany;
        private FontAwesome.Sharp.IconButton iconButton_DeleteCompany;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton_AddProductToCompany;
    }
}