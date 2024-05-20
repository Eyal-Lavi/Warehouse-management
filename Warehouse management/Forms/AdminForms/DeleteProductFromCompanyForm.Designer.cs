namespace Warehouse_management.Forms
{
    partial class DeleteProductFromCompanyForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.companiesTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.c = new System.Windows.Forms.ComboBox();
            this.companiesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet3 = new Warehouse_management.WarehouseManagementDataDataSet3();
            this.companiesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter();
            this.companiesTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(199, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 302);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.error_label);
            this.panel2.Controls.Add(this.label_product);
            this.panel2.Controls.Add(this.label_company);
            this.panel2.Controls.Add(this.label_top);
            this.panel2.Controls.Add(this.button_Delete);
            this.panel2.Controls.Add(this.comboBox_Company);
            this.panel2.Controls.Add(this.c);
            this.panel2.Location = new System.Drawing.Point(26, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 255);
            this.panel2.TabIndex = 4;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(101, 232);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(152, 13);
            this.error_label.TabIndex = 4;
            this.error_label.Text = "Select a company and product";
            this.error_label.Visible = false;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_product.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_product.Location = new System.Drawing.Point(262, 152);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(53, 16);
            this.label_product.TabIndex = 3;
            this.label_product.Text = "Product";
            // 
            // label_company
            // 
            this.label_company.AutoSize = true;
            this.label_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_company.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_company.Location = new System.Drawing.Point(261, 79);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(65, 16);
            this.label_company.TabIndex = 3;
            this.label_company.Text = "Company";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_top.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_top.Location = new System.Drawing.Point(79, 21);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(210, 16);
            this.label_top.TabIndex = 3;
            this.label_top.Text = "Chooshe product that you want del";
            // 
            // button_Delete
            // 
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Delete.Location = new System.Drawing.Point(116, 196);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            this.button_Delete.MouseEnter += new System.EventHandler(this.button_Delete_MouseEnter);
            this.button_Delete.MouseLeave += new System.EventHandler(this.button_Delete_MouseLeave);
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companiesTableBindingSource2, "COMPANY", true));
            this.comboBox_Company.DataSource = this.companiesTableBindingSource2;
            this.comboBox_Company.DisplayMember = "COMPANY";
            this.comboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(115, 71);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Company.TabIndex = 1;
            this.comboBox_Company.ValueMember = "COMPANY";
            this.comboBox_Company.SelectedIndexChanged += new System.EventHandler(this.comboBox_Company_SelectedIndexChanged);
            this.comboBox_Company.Click += new System.EventHandler(this.comboBox_Company_Click);
            // 
            // companiesTableBindingSource2
            // 
            this.companiesTableBindingSource2.DataMember = "CompaniesTable";
            this.companiesTableBindingSource2.DataSource = this.eyallavi_SampleDBDataSet_WM;
            // 
            // eyallavi_SampleDBDataSet_WM
            // 
            this.eyallavi_SampleDBDataSet_WM.DataSetName = "eyallavi_SampleDBDataSet_WM";
            this.eyallavi_SampleDBDataSet_WM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c
            // 
            this.c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c.FormattingEnabled = true;
            this.c.Location = new System.Drawing.Point(116, 149);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(121, 21);
            this.c.TabIndex = 0;
            this.c.Click += new System.EventHandler(this.c_Click);
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
            // companiesTableBindingSource1
            // 
            this.companiesTableBindingSource1.DataMember = "CompaniesTable";
            this.companiesTableBindingSource1.DataSource = this.warehouseManagementDataDataSet3;
            // 
            // companiesTableTableAdapter
            // 
            this.companiesTableTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableTableAdapter1
            // 
            this.companiesTableTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteProductFromCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 465);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteProductFromCompanyForm";
            this.Text = "DeleteProductFromCompanyForm";
            this.Load += new System.EventHandler(this.DeleteProductFromCompanyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WarehouseManagementDataDataSet3 warehouseManagementDataDataSet3;
        private System.Windows.Forms.BindingSource companiesTableBindingSource;
        private WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter;
        private System.Windows.Forms.BindingSource companiesTableBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.ComboBox c;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource companiesTableBindingSource2;
        private eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter1;
        private System.Windows.Forms.Label error_label;
    }
}