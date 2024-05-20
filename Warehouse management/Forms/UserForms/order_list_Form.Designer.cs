namespace Warehouse_management
{
    partial class order_list_Form
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
            this.warehouseManagementDataDataSet = new Warehouse_management.WarehouseManagementDataDataSet();
            this.warehouseManagementDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEPRUDUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEPRUDUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIRYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXGETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet2 = new Warehouse_management.WarehouseManagementDataDataSet2();
            this.orderTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet2TableAdapters.OrderTableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.orderTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.OrderTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouseManagementDataDataSet
            // 
            this.warehouseManagementDataDataSet.DataSetName = "WarehouseManagementDataDataSet";
            this.warehouseManagementDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseManagementDataDataSetBindingSource
            // 
            this.warehouseManagementDataDataSetBindingSource.DataSource = this.warehouseManagementDataDataSet;
            this.warehouseManagementDataDataSetBindingSource.Position = 0;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.warehouseManagementDataDataSetBindingSource;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.tYPEPRUDUCTDataGridViewTextBoxColumn,
            this.nAMEPRUDUCTDataGridViewTextBoxColumn,
            this.eXPIRYDATEDataGridViewTextBoxColumn,
            this.eXGETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderTableBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            this.cOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPEPRUDUCTDataGridViewTextBoxColumn
            // 
            this.tYPEPRUDUCTDataGridViewTextBoxColumn.DataPropertyName = "TYPE_PRUDUCT";
            this.tYPEPRUDUCTDataGridViewTextBoxColumn.HeaderText = "TYPE_PRUDUCT";
            this.tYPEPRUDUCTDataGridViewTextBoxColumn.Name = "tYPEPRUDUCTDataGridViewTextBoxColumn";
            this.tYPEPRUDUCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEPRUDUCTDataGridViewTextBoxColumn
            // 
            this.nAMEPRUDUCTDataGridViewTextBoxColumn.DataPropertyName = "NAME_PRUDUCT";
            this.nAMEPRUDUCTDataGridViewTextBoxColumn.HeaderText = "NAME_PRUDUCT";
            this.nAMEPRUDUCTDataGridViewTextBoxColumn.Name = "nAMEPRUDUCTDataGridViewTextBoxColumn";
            this.nAMEPRUDUCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXPIRYDATEDataGridViewTextBoxColumn
            // 
            this.eXPIRYDATEDataGridViewTextBoxColumn.DataPropertyName = "EXPIRY_DATE";
            this.eXPIRYDATEDataGridViewTextBoxColumn.HeaderText = "EXPIRY_DATE";
            this.eXPIRYDATEDataGridViewTextBoxColumn.Name = "eXPIRYDATEDataGridViewTextBoxColumn";
            this.eXPIRYDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXGETDataGridViewTextBoxColumn
            // 
            this.eXGETDataGridViewTextBoxColumn.DataPropertyName = "EX_GET";
            this.eXGETDataGridViewTextBoxColumn.HeaderText = "EX_GET";
            this.eXGETDataGridViewTextBoxColumn.Name = "eXGETDataGridViewTextBoxColumn";
            this.eXGETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this.warehouseManagementDataDataSet2;
            // 
            // warehouseManagementDataDataSet2
            // 
            this.warehouseManagementDataDataSet2.DataSetName = "WarehouseManagementDataDataSet2";
            this.warehouseManagementDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableTableAdapter
            // 
            this.orderTableTableAdapter.ClearBeforeFill = true;
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
            // orderTableBindingSource1
            // 
            this.orderTableBindingSource1.DataMember = "OrderTable";
            this.orderTableBindingSource1.DataSource = this.eyallavi_SampleDBDataSet_WM;
            // 
            // orderTableTableAdapter1
            // 
            this.orderTableTableAdapter1.ClearBeforeFill = true;
            // 
            // order_list_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 536);
            this.Controls.Add(this.panel1);
            this.Name = "order_list_Form";
            this.Text = "Order list";
            this.Load += new System.EventHandler(this.order_list_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource warehouseManagementDataDataSetBindingSource;
        private WarehouseManagementDataDataSet warehouseManagementDataDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private WarehouseManagementDataDataSetTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WarehouseManagementDataDataSet2 warehouseManagementDataDataSet2;
        private System.Windows.Forms.BindingSource orderTableBindingSource;
        private WarehouseManagementDataDataSet2TableAdapters.OrderTableTableAdapter orderTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEPRUDUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEPRUDUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPIRYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXGETDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource orderTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.OrderTableTableAdapter orderTableTableAdapter1;
    }
}