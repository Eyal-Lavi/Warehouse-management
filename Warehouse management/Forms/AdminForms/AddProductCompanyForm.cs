using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management.Forms
{
    public partial class AddProductCompanyForm : Form
    {
        public AddProductCompanyForm()
        {
            InitializeComponent();
            dataGridView_ProductSending.Columns.Add("ProductColumn","Product");
            dataGridView_ProductSending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Reset()
        {
            dataGridView_ProductSending.Rows.Clear();
            #region
            string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM {comboBox_CompanyName.Text.ToString()}_CompanyProductTable";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_productHaveONcompany.DataSource = dataTable;
                dataGridView_productHaveONcompany.AutoGenerateColumns = true;
                dataGridView_productHaveONcompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            #endregion
        }
        private void comboBox_CompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_CompanyName.SelectedIndex != -1)
            {
                #region
                string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = $"SELECT Product From {comboBox_CompanyName.Text.ToString()}_CompanyProductTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_productHaveONcompany.DataSource = dataTable;
                    dataGridView_productHaveONcompany.AutoGenerateColumns = true;
                    dataGridView_productHaveONcompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                #endregion
            }
        }

        private void AddProductCompanyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.CompaniesTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet3.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter.Fill(this.warehouseManagementDataDataSet3.CompaniesTable);
            comboBox_CompanyName.SelectedIndex= -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox_CompanyName.SelectedIndex!=-1&&Hellp_English_Sintax.EnglishWithMakaf(textBox_Product.Text))
            {
                int counter = 0;
                for(int i =0; i<textBox_Product.Text.Length; i++)
                {
                    if (textBox_Product.Text[i]==' ')
                    {
                        counter++;
                    }
                }
                if (counter > 3 ||counter==textBox_Product.Text.Length)
                {
                    counter = -1;
                }
                if (counter != -1)
                {
                    int x = 0;
                    for (int i = 0; i < dataGridView_productHaveONcompany.Rows.Count; i++)
                    {
                        if (dataGridView_productHaveONcompany.Rows[i].Cells[0].Value.ToString() == textBox_Product.Text)
                        {
                            x += 1;
                            break;
                        }
                    }
                    if (x == 0)
                    {
                        x = 0;
                        for (int i = 0; i < dataGridView_ProductSending.Rows.Count; i++)
                        {
                            if (dataGridView_ProductSending.Rows[i].Cells[0].Value.ToString() == textBox_Product.Text)
                            {
                                x += 1;
                                break;
                            }
                        }
                        if (x == 0)
                        {
                            dataGridView_ProductSending.Rows.Add(textBox_Product.Text);
                            textBox_Product.Text = string.Empty;
                        }
                        else
                        {
                            error_label.Text="Have was add this Product";
                            error_label.Location = new Point(324, 426);
                            error_label.Visible = true;
                        }
                    }
                    else
                    {
                        error_label.Text="Have this product on Company";
                        error_label.Location = new Point(308, 426);
                        error_label.Visible = true;
                    }
                }
               
            }
            else 
            {
                error_label.Text = "Select a company and enter a product name in English without spaces ";
                error_label.Location = new Point(194, 426);
                error_label.Visible = true;
                
            }
          
           
        }

        private void iconButton_Send_Click(object sender, EventArgs e)
        {
            if (dataGridView_ProductSending.Rows.Count > 0&&comboBox_CompanyName.SelectedIndex!=-1)
            {
                int count = 0;
                for(int i =0;i<dataGridView_ProductSending.Rows.Count;i++)
                {
                    if (Hellp_DATABASE_COMPANY.SendProductToCompanyProduct(comboBox_CompanyName.Text.ToString(),
                        dataGridView_ProductSending.Rows[i].Cells[0].Value.ToString()))
                    {
                        count++;
                    }
                }
                if(count != dataGridView_ProductSending.Rows.Count)
                {
                    error_label.Text = "Not all products have been added to the system!";
                    error_label.Location = new Point(267, 426);
                    error_label.Visible = true;
                }
                else
                {
                    Reset();
                    error_label.Text = "The products have been successfully added";
                    error_label.Location = new Point(271, 426);
                    error_label.Visible = true;
                }
            }
            else
            {
                error_label.Text = "Choose a company and add products!";
                error_label.Location = new Point(288, 426);
                error_label.Visible = true;
            }
        }

        private void comboBox_CompanyName_Click(object sender, EventArgs e)
        {
            error_label.Visible=false;
        }

        private void textBox_Product_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FloralWhite;
            button1.ForeColor = Color.Black;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(34, 33, 74);
            button1.ForeColor = Color.FloralWhite;
        }

        private void iconButton_Send_MouseEnter(object sender, EventArgs e)
        {
            iconButton_Send.BackColor = Color.FloralWhite;
            iconButton_Send.ForeColor = Color.Black;
        }

        private void iconButton_Send_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Send.BackColor = Color.FromArgb(34, 33, 74);
            iconButton_Send.ForeColor = Color.FloralWhite;
        }
    }
}
