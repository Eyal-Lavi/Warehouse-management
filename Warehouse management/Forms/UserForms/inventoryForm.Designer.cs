namespace Warehouse_management
{
    partial class inventoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIRYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet = new Warehouse_management.WarehouseManagementDataDataSet();
            this.productTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.productTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.ProductTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(972, 576);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 536);
            this.panel1.TabIndex = 1;
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
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 536);
            this.Controls.Add(this.panel1);
            this.Name = "inventoryForm";
            this.Text = "Warehouse stock";
            this.Load += new System.EventHandler(this.inventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WarehouseManagementDataDataSet warehouseManagementDataDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPIRYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource productTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.ProductTableTableAdapter productTableTableAdapter1;
    }
}