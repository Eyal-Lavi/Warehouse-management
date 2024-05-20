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
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void inventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.ProductTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.warehouseManagementDataDataSet.ProductTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
