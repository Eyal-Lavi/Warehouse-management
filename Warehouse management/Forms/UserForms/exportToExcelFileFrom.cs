using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management.Forms.UserForms
{
    public partial class exportToExcelFileFrom : Form
    {
        public exportToExcelFileFrom()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textBox_nameFile.Text.Length > 0 && textDirectory.Text.Length > 0)
            {
                string connectionString = $"Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=eyallavi_SampleDB;Persist Security Info=True;User ID=eyallavi_SampleDB;Password={Properties.Resources.KeyConnectionStringDB}";


                SqlConnection connection = new SqlConnection(connectionString);

                string query = $"SELECT * FROM {comboBox_dataSelected.Text}Table";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Get the number of columns and rows in the result set
                int numColumns = reader.FieldCount;
                int numRows = 0;
                while (reader.Read())
                {
                    numRows++;
                }

                // Create a 2D string array to hold the data
                string[,] data = new string[numRows, numColumns];

                // ResetText the reader and read the data into the array
                reader.Close();
                reader = command.ExecuteReader();
                int row = 0;
                while (reader.Read())
                {
                    for (int col = 0; col < numColumns; col++)
                    {
                        data[row, col] = reader[col].ToString();
                    }
                    row++;
                }

                reader.Close();
                connection.Close();

                // Create a new Excel workbook
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Add();
                var worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets[1];

                // Write the data to the worksheet
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numColumns; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = data[i, j];
                    }
                }

                // Save the workbook and close Excel
                //workbook.SaveAs($"C:\\Users\\97250\\Desktop\\אייל\\פרויקטים אפליקציות\\ניהול מחסן\\{textBox_nameFile.Text}.xlsx");
                workbook.SaveAs($"{textDirectory.Text}\\{textBox_nameFile.Text}.xlsx");

                workbook.Close();
                excelApp.Quit();

            }


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog a = new FolderBrowserDialog();
            a.ShowDialog();
            textDirectory.Text = a.SelectedPath;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FloralWhite;
            iconButton1.ForeColor = Color.Black;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(34, 33, 74);
            iconButton1.ForeColor = Color.FloralWhite;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FloralWhite;
            iconButton2.ForeColor = Color.Black;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(34, 33, 74);
            iconButton2.ForeColor = Color.FloralWhite;
        }

        private void comboBox_dataSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_dataSelected.SelectedIndex != -1 && textBox_nameFile.Text.Length > 0 && textDirectory.Text.Length > 0)
            {
                iconButton1.Enabled = true;
            }
            else
            {
                iconButton1.Enabled = false;
            }
        }

        private void textBox_nameFile_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_dataSelected.SelectedIndex != -1 && textBox_nameFile.Text.Length > 0 && textDirectory.Text.Length > 0)
            {
                iconButton1.Enabled = true;
            }
            else
            {
                iconButton1.Enabled = false;
            }
        }

        private void textDirectory_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_dataSelected.SelectedIndex != -1 && textBox_nameFile.Text.Length > 0 && textDirectory.Text.Length > 0)
            {
                iconButton1.Enabled = true;
            }
            else
            {
                iconButton1.Enabled = false;
            }
        }

        private void exportToExcelFileFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
