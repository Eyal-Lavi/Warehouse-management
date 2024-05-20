using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management
{
    public partial class order_list_Form : Form
    {
        public order_list_Form()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void order_list_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.OrderTable' table. You can move, or remove it, as needed.
            this.orderTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.OrderTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet2.OrderTable' table. You can move, or remove it, as needed.
            this.orderTableTableAdapter.Fill(this.warehouseManagementDataDataSet2.OrderTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.warehouseManagementDataDataSet.ProductTable);

        }
    }
}
