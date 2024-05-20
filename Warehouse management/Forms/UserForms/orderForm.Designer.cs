namespace Warehouse_management
{
    partial class orderForm
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
            this.type_textBox = new System.Windows.Forms.TextBox();
            this.ex_textBox = new System.Windows.Forms.TextBox();
            this.exGet_textBox = new System.Windows.Forms.TextBox();
            this.company_comboBox = new System.Windows.Forms.ComboBox();
            this.companiesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eyallavi_SampleDBDataSet_WM = new Warehouse_management.eyallavi_SampleDBDataSet_WM();
            this.companiesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseManagementDataDataSet1 = new Warehouse_management.WarehouseManagementDataDataSet1();
            this.accept_button = new System.Windows.Forms.Button();
            this.companiesTableTableAdapter = new Warehouse_management.WarehouseManagementDataDataSet1TableAdapters.CompaniesTableTableAdapter();
            this.sendToDataOrder_button = new System.Windows.Forms.Button();
            this.dataBeforeOrder = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePruduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePruduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howMany_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_NameProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.companiesTableTableAdapter1 = new Warehouse_management.eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBeforeOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_textBox
            // 
            this.type_textBox.Location = new System.Drawing.Point(101, 76);
            this.type_textBox.Name = "type_textBox";
            this.type_textBox.Size = new System.Drawing.Size(209, 20);
            this.type_textBox.TabIndex = 0;
            this.type_textBox.TextChanged += new System.EventHandler(this.type_textBox_TextChanged);
            // 
            // ex_textBox
            // 
            this.ex_textBox.Location = new System.Drawing.Point(101, 189);
            this.ex_textBox.Name = "ex_textBox";
            this.ex_textBox.Size = new System.Drawing.Size(209, 20);
            this.ex_textBox.TabIndex = 0;
            this.ex_textBox.TextChanged += new System.EventHandler(this.ex_textBox_TextChanged);
            // 
            // exGet_textBox
            // 
            this.exGet_textBox.Location = new System.Drawing.Point(101, 245);
            this.exGet_textBox.Name = "exGet_textBox";
            this.exGet_textBox.Size = new System.Drawing.Size(209, 20);
            this.exGet_textBox.TabIndex = 4;
            this.exGet_textBox.TextChanged += new System.EventHandler(this.exGet_textBox_TextChanged);
            // 
            // company_comboBox
            // 
            this.company_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companiesTableBindingSource1, "COMPANY", true));
            this.company_comboBox.DataSource = this.companiesTableBindingSource1;
            this.company_comboBox.DisplayMember = "COMPANY";
            this.company_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_comboBox.FormattingEnabled = true;
            this.company_comboBox.Location = new System.Drawing.Point(101, 23);
            this.company_comboBox.Name = "company_comboBox";
            this.company_comboBox.Size = new System.Drawing.Size(209, 21);
            this.company_comboBox.TabIndex = 3;
            this.company_comboBox.ValueMember = "COMPANY";
            this.company_comboBox.SelectedIndexChanged += new System.EventHandler(this.company_comboBox_SelectedIndexChanged);
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
            // companiesTableBindingSource
            // 
            this.companiesTableBindingSource.DataMember = "CompaniesTable";
            this.companiesTableBindingSource.DataSource = this.warehouseManagementDataDataSet1;
            // 
            // warehouseManagementDataDataSet1
            // 
            this.warehouseManagementDataDataSet1.DataSetName = "WarehouseManagementDataDataSet1";
            this.warehouseManagementDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accept_button
            // 
            this.accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.accept_button.Location = new System.Drawing.Point(61, 289);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 2;
            this.accept_button.Text = "Add";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.button1_Click);
            this.accept_button.MouseEnter += new System.EventHandler(this.accept_button_MouseEnter);
            this.accept_button.MouseLeave += new System.EventHandler(this.accept_button_MouseLeave);
            // 
            // companiesTableTableAdapter
            // 
            this.companiesTableTableAdapter.ClearBeforeFill = true;
            // 
            // sendToDataOrder_button
            // 
            this.sendToDataOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendToDataOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendToDataOrder_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.sendToDataOrder_button.Location = new System.Drawing.Point(616, 412);
            this.sendToDataOrder_button.Name = "sendToDataOrder_button";
            this.sendToDataOrder_button.Size = new System.Drawing.Size(127, 51);
            this.sendToDataOrder_button.TabIndex = 3;
            this.sendToDataOrder_button.Text = "Confirm";
            this.sendToDataOrder_button.UseVisualStyleBackColor = true;
            this.sendToDataOrder_button.Click += new System.EventHandler(this.sendToDataOrder_button_Click);
            this.sendToDataOrder_button.MouseEnter += new System.EventHandler(this.sendToDataOrder_button_MouseEnter);
            this.sendToDataOrder_button.MouseLeave += new System.EventHandler(this.sendToDataOrder_button_MouseLeave);
            // 
            // dataBeforeOrder
            // 
            this.dataBeforeOrder.AllowUserToAddRows = false;
            this.dataBeforeOrder.AllowUserToDeleteRows = false;
            this.dataBeforeOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBeforeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBeforeOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.TypeProduct,
            this.NamePruduct,
            this.DatePruduct,
            this.exGet});
            this.dataBeforeOrder.Location = new System.Drawing.Point(398, 96);
            this.dataBeforeOrder.Name = "dataBeforeOrder";
            this.dataBeforeOrder.ReadOnly = true;
            this.dataBeforeOrder.Size = new System.Drawing.Size(537, 297);
            this.dataBeforeOrder.TabIndex = 4;
            // 
            // Company
            // 
            this.Company.Frozen = true;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // TypeProduct
            // 
            this.TypeProduct.Frozen = true;
            this.TypeProduct.HeaderText = "TypeProduct";
            this.TypeProduct.Name = "TypeProduct";
            this.TypeProduct.ReadOnly = true;
            // 
            // NamePruduct
            // 
            this.NamePruduct.Frozen = true;
            this.NamePruduct.HeaderText = "NamePruduct";
            this.NamePruduct.Name = "NamePruduct";
            this.NamePruduct.ReadOnly = true;
            // 
            // DatePruduct
            // 
            this.DatePruduct.Frozen = true;
            this.DatePruduct.HeaderText = "DatePruduct";
            this.DatePruduct.Name = "DatePruduct";
            this.DatePruduct.ReadOnly = true;
            // 
            // exGet
            // 
            this.exGet.Frozen = true;
            this.exGet.HeaderText = "ExGet";
            this.exGet.Name = "exGet";
            this.exGet.ReadOnly = true;
            // 
            // howMany_comboBox
            // 
            this.howMany_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.howMany_comboBox.FormattingEnabled = true;
            this.howMany_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63 ",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.howMany_comboBox.Location = new System.Drawing.Point(256, 289);
            this.howMany_comboBox.Name = "howMany_comboBox";
            this.howMany_comboBox.Size = new System.Drawing.Size(51, 21);
            this.howMany_comboBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.error_label);
            this.panel1.Controls.Add(this.sendToDataOrder_button);
            this.panel1.Controls.Add(this.dataBeforeOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 536);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 366);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.comboBox_NameProduct);
            this.panel2.Controls.Add(this.howMany_comboBox);
            this.panel2.Controls.Add(this.type_textBox);
            this.panel2.Controls.Add(this.exGet_textBox);
            this.panel2.Controls.Add(this.company_comboBox);
            this.panel2.Controls.Add(this.ex_textBox);
            this.panel2.Controls.Add(this.accept_button);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 333);
            this.panel2.TabIndex = 6;
            // 
            // comboBox_NameProduct
            // 
            this.comboBox_NameProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NameProduct.FormattingEnabled = true;
            this.comboBox_NameProduct.Location = new System.Drawing.Point(101, 134);
            this.comboBox_NameProduct.Name = "comboBox_NameProduct";
            this.comboBox_NameProduct.Size = new System.Drawing.Size(209, 21);
            this.comboBox_NameProduct.TabIndex = 8;
            this.comboBox_NameProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox_NameProduct_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(22, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Expiry get";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Type product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(22, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Product";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(21, 447);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 16);
            this.error_label.TabIndex = 5;
            // 
            // companiesTableTableAdapter1
            // 
            this.companiesTableTableAdapter1.ClearBeforeFill = true;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 536);
            this.Controls.Add(this.panel1);
            this.Name = "orderForm";
            this.Text = "Order Pruduct";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyallavi_SampleDBDataSet_WM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseManagementDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBeforeOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox type_textBox;
        private System.Windows.Forms.TextBox ex_textBox;
        private System.Windows.Forms.ComboBox company_comboBox;
        private WarehouseManagementDataDataSet1 warehouseManagementDataDataSet1;
        private System.Windows.Forms.BindingSource companiesTableBindingSource;
        private WarehouseManagementDataDataSet1TableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button sendToDataOrder_button;
        private System.Windows.Forms.DataGridView dataBeforeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePruduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePruduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn exGet;
        private System.Windows.Forms.TextBox exGet_textBox;
        private System.Windows.Forms.ComboBox howMany_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NameProduct;
        private eyallavi_SampleDBDataSet_WM eyallavi_SampleDBDataSet_WM;
        private System.Windows.Forms.BindingSource companiesTableBindingSource1;
        private eyallavi_SampleDBDataSet_WMTableAdapters.CompaniesTableTableAdapter companiesTableTableAdapter1;
    }
}