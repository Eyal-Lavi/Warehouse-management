namespace Warehouse_management
{
    partial class SendingToBranchForm
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
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet = new Warehouse_management.WarehouseManagementDataDataSet();
            this.productTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter();
            this.branch_comboBox = new System.Windows.Forms.ComboBox();
            this.branchTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet3 = new Warehouse_management.WarehouseManagementDataDataSet3();
            this.branchTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet3TableAdapters.BranchTableTableAdapter();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.send_buttun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSending = new System.Windows.Forms.DataGridView();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.inventory_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIRYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.productTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.ProductTableTableAdapter();
            this.branchTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.BranchTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSending)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.warehouseManagementDataDataSet;
            // 
            // warehouseManagementDataDataSet
            // 
            this.warehouseManagementDataDataSet.DataSetName = "WarehouseManagementDataDataSet";
            this.warehouseManagementDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // branch_comboBox
            // 
            this.branch_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.branchTableBindingSource1, "BRANCH", true));
            this.branch_comboBox.DataSource = this.branchTableBindingSource1;
            this.branch_comboBox.DisplayMember = "BRANCH";
            this.branch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branch_comboBox.FormattingEnabled = true;
            this.branch_comboBox.Location = new System.Drawing.Point(594, 39);
            this.branch_comboBox.Name = "branch_comboBox";
            this.branch_comboBox.Size = new System.Drawing.Size(212, 21);
            this.branch_comboBox.TabIndex = 1;
            this.branch_comboBox.ValueMember = "BRANCH";
            this.branch_comboBox.SelectedIndexChanged += new System.EventHandler(this.branch_comboBox_SelectedIndexChanged);
            // 
            // branchTableBindingSource
            // 
            this.branchTableBindingSource.DataMember = "BranchTable";
            this.branchTableBindingSource.DataSource = this.warehouseManagementDataDataSet3;
            // 
            // warehouseManagementDataDataSet3
            // 
            this.warehouseManagementDataDataSet3.DataSetName = "WarehouseManagementDataDataSet3";
            this.warehouseManagementDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableTableAdapter
            // 
            this.branchTableTableAdapter.ClearBeforeFill = true;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(326, 39);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(129, 20);
            this.id_textBox.TabIndex = 3;
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            // 
            // add_button
            // 
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.ForeColor = System.Drawing.Color.FloralWhite;
            this.add_button.Location = new System.Drawing.Point(200, 37);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "הוסף";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            this.add_button.MouseEnter += new System.EventHandler(this.add_button_MouseEnter);
            this.add_button.MouseLeave += new System.EventHandler(this.add_button_MouseLeave);
            // 
            // send_buttun
            // 
            this.send_buttun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_buttun.ForeColor = System.Drawing.Color.FloralWhite;
            this.send_buttun.Location = new System.Drawing.Point(76, 37);
            this.send_buttun.Name = "send_buttun";
            this.send_buttun.Size = new System.Drawing.Size(75, 23);
            this.send_buttun.TabIndex = 5;
            this.send_buttun.Text = "שלח";
            this.send_buttun.UseVisualStyleBackColor = true;
            this.send_buttun.Click += new System.EventHandler(this.send_buttun_Click);
            this.send_buttun.MouseEnter += new System.EventHandler(this.send_buttun_MouseEnter);
            this.send_buttun.MouseLeave += new System.EventHandler(this.send_buttun_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(836, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "רשימת שילוח";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(828, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = " סניף";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(476, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = " של המוצר ID";
            // 
            // dataGridViewSending
            // 
            this.dataGridViewSending.AllowUserToAddRows = false;
            this.dataGridViewSending.AllowUserToDeleteRows = false;
            this.dataGridViewSending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branch,
            this.id,
            this.product_type,
            this.product_company,
            this.product_name,
            this.expiry_date});
            this.dataGridViewSending.Location = new System.Drawing.Point(156, 84);
            this.dataGridViewSending.Name = "dataGridViewSending";
            this.dataGridViewSending.ReadOnly = true;
            this.dataGridViewSending.Size = new System.Drawing.Size(641, 184);
            this.dataGridViewSending.TabIndex = 10;
            this.dataGridViewSending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSending_CellContentClick);
            // 
            // branch
            // 
            this.branch.HeaderText = "Branch";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // product_type
            // 
            this.product_type.HeaderText = "Product_type";
            this.product_type.Name = "product_type";
            this.product_type.ReadOnly = true;
            // 
            // product_company
            // 
            this.product_company.HeaderText = "Product_company";
            this.product_company.Name = "product_company";
            this.product_company.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Product_name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // expiry_date
            // 
            this.expiry_date.HeaderText = "Expiry_date";
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.error_label);
            this.panel1.Controls.Add(this.inventory_label);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.branch_comboBox);
            this.panel1.Controls.Add(this.dataGridViewSending);
            this.panel1.Controls.Add(this.id_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.send_buttun);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 536);
            this.panel1.TabIndex = 11;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.error_label.ForeColor = System.Drawing.Color.FloralWhite;
            this.error_label.Location = new System.Drawing.Point(12, 510);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(121, 17);
            this.error_label.TabIndex = 13;
            this.error_label.Text = "Senning complete";
            // 
            // inventory_label
            // 
            this.inventory_label.AutoSize = true;
            this.inventory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.inventory_label.ForeColor = System.Drawing.Color.FloralWhite;
            this.inventory_label.Location = new System.Drawing.Point(836, 394);
            this.inventory_label.Name = "inventory_label";
            this.inventory_label.Size = new System.Drawing.Size(72, 16);
            this.inventory_label.TabIndex = 12;
            this.inventory_label.Text = "קיים במלאי";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pRODUCTTYPEDataGridViewTextBoxColumn,
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.eXPIRYDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(200, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 221);
            this.dataGridView1.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTTYPEDataGridViewTextBoxColumn
            // 
            this.pRODUCTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_TYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.Name = "pRODUCTTYPEDataGridViewTextBoxColumn";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTCOMPANYDataGridViewTextBoxColumn
            // 
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_COMPANY";
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn.HeaderText = "PRODUCT_COMPANY";
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn.Name = "pRODUCTCOMPANYDataGridViewTextBoxColumn";
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXPIRYDATEDataGridViewTextBoxColumn
            // 
            this.eXPIRYDATEDataGridViewTextBoxColumn.DataPropertyName = "EXPIRY_DATE";
            this.eXPIRYDATEDataGridViewTextBoxColumn.HeaderText = "EXPIRY_DATE";
            this.eXPIRYDATEDataGridViewTextBoxColumn.Name = "eXPIRYDATEDataGridViewTextBoxColumn";
            this.eXPIRYDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eyallavi_SampleDBDataSet_WM
            // 
            this.eyallavi_SampleDBDataSet_WM.DataSetName = "eyallavi_SampleDBDataSet_WM";
            this.eyallavi_SampleDBDataSet_WM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableBindingSource1
            // 
            this.productTableBindingSource1.DataMember = "ProductTable";
            this.productTableBindingSource1.DataSource = this.eyallavi_SampleDBDataSet_WM;
            // 
            // productTableTableAdapter1
            // 
            this.productTableTableAdapter1.ClearBeforeFill = true;
            // 
            // branchTableBindingSource1
            // 
            this.branchTableBindingSource1.DataMember = "BranchTable";
            this.branchTableBindingSource1.DataSource = this.eyallavi_SampleDBDataSet_WM;
            // 
            // branchTableTableAdapter1
            // 
            this.branchTableTableAdapter1.ClearBeforeFill = true;
            // 
            // SendingToBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 536);
            this.Controls.Add(this.panel1);
            this.Name = "SendingToBranchForm";
            this.Text = "Delivery to the branch";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSending)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private WarehouseManagementDataDataSet warehouseManagementDataDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.ComboBox branch_comboBox;
        private WarehouseManagementDataDataSet3 warehouseManagementDataDataSet3;
        private System.Windows.Forms.BindingSource branchTableBindingSource;
        private WarehouseManagementDataDataSet3TableAdapters.BranchTableTableAdapter branchTableTableAdapter;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button send_buttun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSending;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiry_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label inventory_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPIRYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label error_label;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource productTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.ProductTableTableAdapter productTableTableAdapter1;
        private System.Windows.Forms.BindingSource branchTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.BranchTableTableAdapter branchTableTableAdapter1;
    }
}