using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_management.Forms;

namespace Warehouse_management
{
    public partial class SendingToBranchForm : Form
    {
        public SendingToBranchForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.BranchTable' table. You can move, or remove it, as needed.
            this.branchTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.BranchTable);
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.ProductTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet3.BranchTable' table. You can move, or remove it, as needed.
            this.branchTableTableAdapter.Fill(this.warehouseManagementDataDataSet3.BranchTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.warehouseManagementDataDataSet.ProductTable);
            error_label.Visible = false;

        }
        public void Reset()
        {
            branch_comboBox.SelectedIndex = -1;
            id_textBox.Text = string.Empty;
            dataGridViewSending.Rows.Clear();
            #region
            string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM ProductTable";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion
            error_label.Visible = false;
            //

        }
        private void add_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            if (branch_comboBox.SelectedIndex != -1 && id_textBox.Text.Length > 0)
            {

                if (int.TryParse(id_textBox.Text, out res))
                {
                    string[,] dataPruduct = Hellp_DATABASE_PRODUCT.GetAllDataID(id_textBox.Text);
                    if (dataPruduct != null)
                    {
                        string[,] dataGrid = new string[dataGridViewSending.Rows.Count, dataGridViewSending.Columns.Count];
                        bool tester = true, testerHave = false;
                        for (int i = 0; i < dataGridViewSending.Rows.Count; i++)
                        {
                            if (dataGridViewSending.Rows[i].Cells[1].Value.ToString() == id_textBox.Text)
                            {
                                tester = false;
                                break;
                            }
                        }
                        if (tester)
                        {

                            testerHave = true;
                            dataGridViewSending.Rows.Add(branch_comboBox.Text, dataPruduct[0, 0], dataPruduct[0, 1], dataPruduct[0, 2], dataPruduct[0, 3], dataPruduct[0, 4]);
                            for (int x = 0; x < dataGridView1.Rows.Count; x++)
                            {
                                if (dataGridView1.Rows[x].Cells[0].Value.ToString() == dataPruduct[0, 0])
                                {
                                    dataGridView1.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                                    break;
                                }
                            }

                        }
                        if (testerHave == false)
                        {
                            error_label.Text = "You was added this pruduct";
                            error_label.Visible = true;
                        }
                    }
                    else
                    {
                        error_label.Text = "There is no such product";
                        error_label.Visible = true;
                    }
                }
                else
                {
                    error_label.Text = "Enter Only numbers !";
                    error_label.Visible = true;

                }
            }
            else
            {
                error_label.Text = "Fill in the shipping details";
                error_label.Visible = true;
            }
         
        }


        private void dataGridViewSending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void send_buttun_Click(object sender, EventArgs e)
        {
            bool cheak = false;
            for (int i = 0; i < dataGridViewSending.Rows.Count; i++)
            {
                Hellp_DATABASE_PRODUCT.deleteRowProducts(dataGridViewSending.Rows[i].Cells[1].Value.ToString());
                cheak = true;
                Reset();
                

            }
            if (cheak)
            {
                error_label.Text = "Sent successfully";
                error_label.Visible = true;

            }
            else
            {
                error_label.Text = "Add pruduct !";
                error_label.Visible = true;

            }

        }

        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FloralWhite;
            add_button.ForeColor = Color.Black;
        }

        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FromArgb(34, 33, 74);
            add_button.ForeColor = Color.FloralWhite;
        }

        private void send_buttun_MouseEnter(object sender, EventArgs e)
        {
            send_buttun.BackColor = Color.FloralWhite;
            send_buttun.ForeColor = Color.Black;
        }

        private void send_buttun_MouseLeave(object sender, EventArgs e)
        {
            send_buttun.BackColor = Color.FromArgb(34, 33, 74);
            send_buttun.ForeColor = Color.FloralWhite;
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void branch_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

    }
}