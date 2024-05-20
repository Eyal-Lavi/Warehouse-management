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
    public partial class DeleteCompanyForm : Form
    {
        public DeleteCompanyForm()
        {
            InitializeComponent();
        }

        private void DeleteCompanyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.CompaniesTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet3.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter.Fill(this.warehouseManagementDataDataSet3.CompaniesTable);
            comboBox_Del.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Del.SelectedIndex != -1)
            {
                try
                {
                    string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand($"DROP TABLE {comboBox_Del.Text.ToString()}_CompanyProductTable DELETE FROM CompaniesTable WHERE COMPANY = '{comboBox_Del.Text.ToString()}'", con))//לבדוק תקינות
                        {
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        comboBox_Del.DataSource = null;
                        comboBox_Del.Items.Clear();
                        #region
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        string query = $"SELECT COMPANY FROM CompaniesTable";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, $"CompaniesTable");

                        for (int i = 0; i < dataSet.Tables[$"CompaniesTable"].Rows.Count; i++)
                        {
                            comboBox_Del.Items.Add(dataSet.Tables[$"CompaniesTable"].Rows[i]["COMPANY"].ToString());
                        }
                        connection.Close();
                        #endregion
                        error_label.Location = new Point(88, 201);
                        error_label.Text = "The company has been successfully deleted";
                        error_label.Visible = true;
                    }


                }
                catch (SystemException ex)
                {
                    
                    error_label.Text=string.Format("An error occurred: {0}", ex.Message);
                }
            }
            else
            {
                error_label.Location = new Point(145, 201);
                error_label.Text = "Select a company";
                error_label.Visible = true;
            }
           
        }

        private void comboBox_Del_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Del_MouseEnter(object sender, EventArgs e)
        {
            button_Del.BackColor = Color.FloralWhite;
            button_Del.ForeColor = Color.Black;
        }

        private void button_Del_MouseLeave(object sender, EventArgs e)
        {
            button_Del.BackColor = Color.FromArgb(34, 33, 74);
            button_Del.ForeColor = Color.FloralWhite;
        }

        private void comboBox_Del_Click(object sender, EventArgs e)
        {
            error_label.Visible= false;
        }
    }
}
