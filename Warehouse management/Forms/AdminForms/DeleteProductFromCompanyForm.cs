using FontAwesome.Sharp;
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
    public partial class DeleteProductFromCompanyForm : Form
    {
        public DeleteProductFromCompanyForm()
        {
            InitializeComponent();
            
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Company.SelectedIndex != -1)
            {
                c.DataSource = null;
                c.Items.Clear();

                #region
                string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT Product FROM {comboBox_Company.Text.ToString()}_CompanyProductTable";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, $"{comboBox_Company.Text.ToString()}_CompanyProductTable");

                for (int i = 0; i < dataSet.Tables[$"{comboBox_Company.Text.ToString()}_CompanyProductTable"].Rows.Count; i++)
                {
                    c.Items.Add(dataSet.Tables[$"{comboBox_Company.Text.ToString()}_CompanyProductTable"].Rows[i]["Product"].ToString());
                }
                connection.Close();
                #endregion


            }
        }

        private void DeleteProductFromCompanyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.CompaniesTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet3.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter.Fill(this.warehouseManagementDataDataSet3.CompaniesTable);
            comboBox_Company.SelectedIndex = -1;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox_Company.SelectedIndex != -1 && c.SelectedIndex != -1)
            {
                try
                {
                    string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand($"DELETE FROM {comboBox_Company.Text.ToString()}_CompanyProductTable WHERE Product ='{c.Text.ToString()}'", con))//לבדוק תקינות
                        {
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    c.DataSource = null;
                    c.Items.Clear();

                    #region
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query = $"SELECT Product FROM {comboBox_Company.Text.ToString()}_CompanyProductTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, $"{comboBox_Company.Text.ToString()}_CompanyProductTable");

                    for (int i = 0; i < dataSet.Tables[$"{comboBox_Company.Text.ToString()}_CompanyProductTable"].Rows.Count; i++)
                    {
                        c.Items.Add(dataSet.Tables[$"{comboBox_Company.Text.ToString()}_CompanyProductTable"].Rows[i]["Product"].ToString());
                    }
                    #endregion
                    connection.Close();
                    error_label.Text = "The product has been successfully deleted";
                    error_label.Location = new Point(72, 232);
                    error_label.Visible = true;

                }
                catch (SystemException ex)
                {
                   error_label.Text=string.Format("An error occurred: {0}", ex.Message);
                   error_label.Visible = true;
                }
            }
            else
            {
                error_label.Location = new Point(101, 232);
                error_label.Text = "Select a company and product";
                error_label.Visible = true;
            }

        }

        private void button_Delete_MouseEnter(object sender, EventArgs e)
        {
            button_Delete.BackColor = Color.FloralWhite;
            button_Delete.ForeColor = Color.Black;
        }

        private void button_Delete_MouseLeave(object sender, EventArgs e)
        {
            button_Delete.BackColor = Color.FromArgb(34, 33, 74);
            button_Delete.ForeColor = Color.FloralWhite;
        }

        private void comboBox_Company_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void c_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
