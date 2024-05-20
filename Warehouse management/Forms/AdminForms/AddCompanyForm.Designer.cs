namespace Warehouse_management
{
    partial class AddCompanyForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCompany_button = new System.Windows.Forms.Button();
            this.product_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addProduct_textBox = new System.Windows.Forms.Button();
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 513);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(100, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 380);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.error_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addCompany_button);
            this.panel2.Controls.Add(this.product_textBox);
            this.panel2.Controls.Add(this.dataGridView_Product);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addProduct_textBox);
            this.panel2.Controls.Add(this.company_textBox);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(30, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 325);
            this.panel2.TabIndex = 8;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(329, 297);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(110, 13);
            this.error_label.TabIndex = 7;
            this.error_label.Text = "Add a company name";
            this.error_label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(315, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add product to this Company";
            // 
            // addCompany_button
            // 
            this.addCompany_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCompany_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.addCompany_button.Location = new System.Drawing.Point(308, 259);
            this.addCompany_button.Name = "addCompany_button";
            this.addCompany_button.Size = new System.Drawing.Size(150, 23);
            this.addCompany_button.TabIndex = 0;
            this.addCompany_button.Text = "Confirm";
            this.addCompany_button.UseVisualStyleBackColor = true;
            this.addCompany_button.Click += new System.EventHandler(this.addCompany_button_Click);
            this.addCompany_button.MouseEnter += new System.EventHandler(this.addCompany_button_MouseEnter);
            this.addCompany_button.MouseLeave += new System.EventHandler(this.addCompany_button_MouseLeave);
            // 
            // product_textBox
            // 
            this.product_textBox.Location = new System.Drawing.Point(274, 175);
            this.product_textBox.Name = "product_textBox";
            this.product_textBox.Size = new System.Drawing.Size(221, 20);
            this.product_textBox.TabIndex = 4;
            this.product_textBox.Click += new System.EventHandler(this.product_textBox_Click);
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AllowUserToAddRows = false;
            this.dataGridView_Product.AllowUserToDeleteRows = false;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product});
            this.dataGridView_Product.Location = new System.Drawing.Point(39, 32);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.ReadOnly = true;
            this.dataGridView_Product.Size = new System.Drawing.Size(143, 261);
            this.dataGridView_Product.TabIndex = 3;
            // 
            // Product
            // 
            this.Product.Frozen = true;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(271, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fill in the name of the company you want to add";
            // 
            // addProduct_textBox
            // 
            this.addProduct_textBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_textBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.addProduct_textBox.Location = new System.Drawing.Point(345, 210);
            this.addProduct_textBox.Name = "addProduct_textBox";
            this.addProduct_textBox.Size = new System.Drawing.Size(75, 23);
            this.addProduct_textBox.TabIndex = 5;
            this.addProduct_textBox.Text = "Add";
            this.addProduct_textBox.UseVisualStyleBackColor = true;
            this.addProduct_textBox.Click += new System.EventHandler(this.addProduct_textBox_Click);
            this.addProduct_textBox.MouseEnter += new System.EventHandler(this.addProduct_textBox_MouseEnter);
            this.addProduct_textBox.MouseLeave += new System.EventHandler(this.addProduct_textBox_MouseLeave);
            // 
            // company_textBox
            // 
            this.company_textBox.Location = new System.Drawing.Point(274, 92);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(221, 20);
            this.company_textBox.TabIndex = 1;
            this.company_textBox.Click += new System.EventHandler(this.company_textBox_Click);
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 513);
            this.Controls.Add(this.panel1);
            this.Name = "AddCompanyForm";
            this.Text = "Add Company";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProduct_textBox;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.TextBox company_textBox;
        private System.Windows.Forms.Button addCompany_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label error_label;
    }
}