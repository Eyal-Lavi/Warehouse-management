namespace Warehouse_management.Forms
{
    partial class AddProductCompanyForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.iconButton_Send = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_productHaveONcompany = new System.Windows.Forms.DataGridView();
            this.dataGridView_ProductSending = new System.Windows.Forms.DataGridView();
            this.comboBox_CompanyName = new System.Windows.Forms.ComboBox();
            this.companiesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Product = new System.Windows.Forms.TextBox();
            this.companiesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet3 = new Warehouse_management.WarehouseManagementDataDataSet3();
            this.companiesTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter();
            this.companiesTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productHaveONcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductSending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.error_label);
            this.panel1.Controls.Add(this.iconButton_Send);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView_productHaveONcompany);
            this.panel1.Controls.Add(this.dataGridView_ProductSending);
            this.panel1.Controls.Add(this.comboBox_CompanyName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 484);
            this.panel1.TabIndex = 0;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(288, 426);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(235, 16);
            this.error_label.TabIndex = 7;
            this.error_label.Text = "Choose a company and add products!";
            this.error_label.Visible = false;
            // 
            // iconButton_Send
            // 
            this.iconButton_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Send.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Send.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton_Send.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Send.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Send.IconSize = 29;
            this.iconButton_Send.Location = new System.Drawing.Point(68, 111);
            this.iconButton_Send.Name = "iconButton_Send";
            this.iconButton_Send.Size = new System.Drawing.Size(59, 47);
            this.iconButton_Send.TabIndex = 6;
            this.iconButton_Send.Text = "Confirm";
            this.iconButton_Send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton_Send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton_Send.UseVisualStyleBackColor = true;
            this.iconButton_Send.Click += new System.EventHandler(this.iconButton_Send_Click);
            this.iconButton_Send.MouseEnter += new System.EventHandler(this.iconButton_Send_MouseEnter);
            this.iconButton_Send.MouseLeave += new System.EventHandler(this.iconButton_Send_MouseLeave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(233, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // dataGridView_productHaveONcompany
            // 
            this.dataGridView_productHaveONcompany.AllowUserToAddRows = false;
            this.dataGridView_productHaveONcompany.AllowUserToDeleteRows = false;
            this.dataGridView_productHaveONcompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_productHaveONcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productHaveONcompany.Location = new System.Drawing.Point(413, 167);
            this.dataGridView_productHaveONcompany.Name = "dataGridView_productHaveONcompany";
            this.dataGridView_productHaveONcompany.ReadOnly = true;
            this.dataGridView_productHaveONcompany.Size = new System.Drawing.Size(359, 226);
            this.dataGridView_productHaveONcompany.TabIndex = 4;
            // 
            // dataGridView_ProductSending
            // 
            this.dataGridView_ProductSending.AllowUserToAddRows = false;
            this.dataGridView_ProductSending.AllowUserToDeleteRows = false;
            this.dataGridView_ProductSending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductSending.Location = new System.Drawing.Point(39, 167);
            this.dataGridView_ProductSending.Name = "dataGridView_ProductSending";
            this.dataGridView_ProductSending.ReadOnly = true;
            this.dataGridView_ProductSending.Size = new System.Drawing.Size(370, 226);
            this.dataGridView_ProductSending.TabIndex = 3;
            // 
            // comboBox_CompanyName
            // 
            this.comboBox_CompanyName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companiesTableBindingSource1, "COMPANY", true));
            this.comboBox_CompanyName.DataSource = this.companiesTableBindingSource1;
            this.comboBox_CompanyName.DisplayMember = "COMPANY";
            this.comboBox_CompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CompanyName.FormattingEnabled = true;
            this.comboBox_CompanyName.Location = new System.Drawing.Point(397, 77);
            this.comboBox_CompanyName.Name = "comboBox_CompanyName";
            this.comboBox_CompanyName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_CompanyName.TabIndex = 2;
            this.comboBox_CompanyName.ValueMember = "COMPANY";
            this.comboBox_CompanyName.SelectedIndexChanged += new System.EventHandler(this.comboBox_CompanyName_SelectedIndexChanged);
            this.comboBox_CompanyName.Click += new System.EventHandler(this.comboBox_CompanyName_Click);
            // 
            // companiesTableBindingSource1
            // 
            this.companiesTableBindingSource1.DataMember = "CompaniesTable";
            this.companiesTableBindingSource1.DataSource = this.eyallavi_SampleDBDataSet_WM;
            // 
            // eyallavi_SampleDBDataSet_WM
            // 
            this.eyallavi_SampleDBDataSet_WM.DataSetName = "eyallavi_SampleDBDataSet_WM";
            this.eyallavi_SampleDBDataSet_WM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(304, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adding a product to the company\'s product list";
            // 
            // textBox_Product
            // 
            this.textBox_Product.Location = new System.Drawing.Point(351, 123);
            this.textBox_Product.Name = "textBox_Product";
            this.textBox_Product.Size = new System.Drawing.Size(210, 20);
            this.textBox_Product.TabIndex = 0;
            this.textBox_Product.Click += new System.EventHandler(this.textBox_Product_Click);
            // 
            // companiesTableBindingSource
            // 
            this.companiesTableBindingSource.DataMember = "CompaniesTable";
            this.companiesTableBindingSource.DataSource = this.warehouseManagementDataDataSet3;
            // 
            // warehouseManagementDataDataSet3
            // 
            this.warehouseManagementDataDataSet3.DataSetName = "WarehouseManagementDataDataSet3";
            this.warehouseManagementDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesTableTableAdapter
            // 
            this.companiesTableTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableTableAdapter1
            // 
            this.companiesTableTableAdapter1.ClearBeforeFill = true;
            // 
            // AddProductCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 484);
            this.Controls.Add(this.panel1);
            this.Name = "AddProductCompanyForm";
            this.Text = "AddProductCompanyForm";
            this.Load += new System.EventHandler(this.AddProductCompanyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productHaveONcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductSending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_productHaveONcompany;
        private System.Windows.Forms.DataGridView dataGridView_ProductSending;
        private System.Windows.Forms.ComboBox comboBox_CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Product;
        private WarehouseManagementDataDataSet3 warehouseManagementDataDataSet3;
        private System.Windows.Forms.BindingSource companiesTableBindingSource;
        private WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton_Send;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource companiesTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter1;
        private System.Windows.Forms.Label error_label;
    }
}