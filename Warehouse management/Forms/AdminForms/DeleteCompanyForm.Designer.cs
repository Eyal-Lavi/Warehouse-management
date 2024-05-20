namespace Warehouse_management.Forms
{
    partial class DeleteCompanyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Del = new System.Windows.Forms.ComboBox();
            this.companiesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.button_Del = new System.Windows.Forms.Button();
            this.companiesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet3 = new Warehouse_management.WarehouseManagementDataDataSet3();
            this.companiesTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter();
            this.companiesTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter();
            this.error_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 418);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(175, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 292);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.error_label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_Del);
            this.panel2.Controls.Add(this.button_Del);
            this.panel2.Location = new System.Drawing.Point(29, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 234);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the company you want to remove";
            // 
            // comboBox_Del
            // 
            this.comboBox_Del.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companiesTableBindingSource1, "COMPANY", true));
            this.comboBox_Del.DataSource = this.companiesTableBindingSource1;
            this.comboBox_Del.DisplayMember = "COMPANY";
            this.comboBox_Del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Del.FormattingEnabled = true;
            this.comboBox_Del.Location = new System.Drawing.Point(76, 90);
            this.comboBox_Del.Name = "comboBox_Del";
            this.comboBox_Del.Size = new System.Drawing.Size(234, 21);
            this.comboBox_Del.TabIndex = 1;
            this.comboBox_Del.ValueMember = "COMPANY";
            this.comboBox_Del.Click += new System.EventHandler(this.comboBox_Del_Click);
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
            // button_Del
            // 
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Del.Location = new System.Drawing.Point(86, 141);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(215, 37);
            this.button_Del.TabIndex = 0;
            this.button_Del.Text = "Delete";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button1_Click);
            this.button_Del.MouseEnter += new System.EventHandler(this.button_Del_MouseEnter);
            this.button_Del.MouseLeave += new System.EventHandler(this.button_Del_MouseLeave);
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
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(145, 201);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(92, 13);
            this.error_label.TabIndex = 3;
            this.error_label.Text = "Select a company";
            this.error_label.Visible = false;
            // 
            // DeleteCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 418);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteCompanyForm";
            this.Text = "Delete Company";
            this.Load += new System.EventHandler(this.DeleteCompanyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Del;
        private System.Windows.Forms.Button button_Del;
        private WarehouseManagementDataDataSet3 warehouseManagementDataDataSet3;
        private System.Windows.Forms.BindingSource companiesTableBindingSource;
        private WarehouseManagementDataDataSet3TableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource companiesTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_label;
    }
}