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

namespace Warehouse_management
{
    public partial class orderForm : Form
    {
        int count = 0;
        public orderForm()
        {
            InitializeComponent();
          
        }
        public void ResetText()
        {
            //company_comboBox.ResetText(); 
            company_comboBox.SelectedIndex = -1;
            type_textBox.Text = string.Empty;
            //name_textBox.Text = string.Empty;
            comboBox_NameProduct.SelectedIndex= -1;
            ex_textBox.Text = string.Empty;
            exGet_textBox.Text = string.Empty;
            howMany_comboBox.SelectedIndex = 0;
            comboBox_NameProduct.DataSource = null;
            comboBox_NameProduct.Items.Clear();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyallavi_SampleDBDataSet_WM.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter1.Fill(this.eyallavi_SampleDBDataSet_WM.CompaniesTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet1.CompaniesTable' table. You can move, or remove it, as needed.
            this.companiesTableTableAdapter.Fill(this.warehouseManagementDataDataSet1.CompaniesTable);
            // TODO: This line of code loads data into the 'warehouseManagementDataDataSet.ProductTable' table. You can move, or remove it, as needed.
            accept_button.Enabled = false;
            company_comboBox.SelectedIndex = -1;
            howMany_comboBox.SelectedIndex = 0;
            comboBox_NameProduct.SelectedIndex= -1;
            sendToDataOrder_button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hellp_expiry_Sintax.cheakTheSintaxDate(ex_textBox.Text)&&Hellp_expiry_Sintax.cheakTheSintaxDate(exGet_textBox.Text)&&Hellp_English_Sintax.EnglishWithMakaf(type_textBox.Text))
            {
                for(int i = 0; i < int.Parse(howMany_comboBox.SelectedItem.ToString()); i++)
                {
                    dataBeforeOrder.Rows.Add(company_comboBox.Text, type_textBox.Text, comboBox_NameProduct.Text.ToString(), ex_textBox.Text, exGet_textBox.Text);
                }
                ResetText();
                sendToDataOrder_button.Enabled = true;

                
            }
            else
            {
                //error_label.Text ="בעיה ! \r\nהכנס תאריך בצורת 01/01/0001 \r\nאו\r\nשאחד משני התאריכים שהוזן לא אפשרי !";
                error_label.Text = "Enter a date in the form 01/01/0001\r\nor\r\nthat one of the two dates entered is not possible!\n or Write in Engilsh !";
            }
           
        }

        private void type_textBox_TextChanged(object sender, EventArgs e)
        {
            if(ex_textBox.Text.Length>0&& comboBox_NameProduct.SelectedIndex != -1 && type_textBox.Text.Length>0&&company_comboBox.SelectedIndex!=-1 && exGet_textBox.Text.Length > 0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled = false;
            }
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ex_textBox.Text.Length > 0 && comboBox_NameProduct.SelectedIndex!=-1 && type_textBox.Text.Length > 0 && company_comboBox.SelectedIndex != -1 && exGet_textBox.Text.Length > 0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled = false;
            }
        }

        private void ex_textBox_TextChanged(object sender, EventArgs e)
        {
            if (error_label.Text != string.Empty)
            {
                error_label.Text = string.Empty;
            }
            if (ex_textBox.Text.Length > 0 && comboBox_NameProduct.SelectedIndex!=-1 && type_textBox.Text.Length > 0 && company_comboBox.SelectedIndex != -1 && exGet_textBox.Text.Length > 0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled=false;
            }
        }

        private void sendToDataOrder_button_Click(object sender, EventArgs e)
        {
            if (dataBeforeOrder.Rows.Count > 0)
            {
                string[,] allData = new string[dataBeforeOrder.Rows.Count, dataBeforeOrder.Columns.Count];
                for (int i = 0; i < dataBeforeOrder.Rows.Count; i++)
                {
                    for (int j = 0; j < dataBeforeOrder.Columns.Count; j++)
                    {
                        allData[i, j] += dataBeforeOrder.Rows[i].Cells[j].Value.ToString();

                    }
                }
                int count = 0;
                for (int i = 0; i < allData.GetLength(0); i++)
                {
                    if (Hellp_DATABASE_ORDER.SendParameterDataBaseOrderProduct(allData[i, 0], allData[i, 1], allData[i, 2], allData[i, 3], allData[i, 4]))
                    {
                        count++;
                    }
                }
            }
            //MessageBox.Show(count == allData.GetLength(0) ? "Sending was successful" : "Sending problem");
        }

        private void exGet_textBox_TextChanged(object sender, EventArgs e)
        {
            if (error_label.Text != string.Empty)
            {
                error_label.Text = string.Empty;
            }
            if (ex_textBox.Text.Length > 0 && comboBox_NameProduct.SelectedIndex!=-1 && type_textBox.Text.Length > 0 && company_comboBox.SelectedIndex != -1 &&exGet_textBox.Text.Length>0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled = false;
            }
        }

        private void company_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ex_textBox.Text.Length > 0 && comboBox_NameProduct.SelectedIndex!=-1 && type_textBox.Text.Length > 0 && company_comboBox.SelectedIndex != -1 && exGet_textBox.Text.Length > 0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled = false;
            }
            if (company_comboBox.SelectedIndex != -1)
            {
                comboBox_NameProduct.DataSource = null;
                comboBox_NameProduct.Items.Clear();

                #region
                string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT Product FROM {company_comboBox.Text.ToString()}_CompanyProductTable";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, $"{company_comboBox.Text.ToString()}_CompanyProductTable");

                for (int i = 0; i < dataSet.Tables[$"{company_comboBox.Text.ToString()}_CompanyProductTable"].Rows.Count; i++)
                {
                    comboBox_NameProduct.Items.Add(dataSet.Tables[$"{company_comboBox.Text.ToString()}_CompanyProductTable"].Rows[i]["Product"].ToString());
                }
                #endregion
            }
        }

        private void sendToDataOrder_button_MouseEnter(object sender, EventArgs e)
        {
            sendToDataOrder_button.BackColor = Color.FloralWhite;
            sendToDataOrder_button.ForeColor = Color.Black;
        }

        private void sendToDataOrder_button_MouseLeave(object sender, EventArgs e)
        {
            sendToDataOrder_button.BackColor = Color.FromArgb(34, 33, 74);
            sendToDataOrder_button.ForeColor = Color.FloralWhite;
        }

        private void accept_button_MouseEnter(object sender, EventArgs e)
        {
            accept_button.BackColor = Color.FloralWhite;
            accept_button.ForeColor = Color.Black;
        }

        private void accept_button_MouseLeave(object sender, EventArgs e)
        {
            accept_button.BackColor = Color.FromArgb(34, 33, 74);
            accept_button.ForeColor = Color.FloralWhite;
        }

        private void comboBox_NameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ex_textBox.Text.Length > 0 && comboBox_NameProduct.SelectedIndex != -1 && type_textBox.Text.Length > 0 && company_comboBox.SelectedIndex != -1 && exGet_textBox.Text.Length > 0)
            {
                accept_button.Enabled = true;
            }
            else
            {
                accept_button.Enabled = false;
            }
           

        }
    }
}
