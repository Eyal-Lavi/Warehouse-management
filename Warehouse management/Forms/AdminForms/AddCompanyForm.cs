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
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void addCompany_button_Click(object sender, EventArgs e)
        {

            if (Hellp_DATABASE_COMPANY.SyntaxEnglishCompanyName(company_textBox.Text)) 
            {
                if (Hellp_DATABASE_COMPANY.CheakIfCompanyHaveOnDataBase(company_textBox.Text))
                {
                    if (Hellp_DATABASE_COMPANY.SendParameterDataBaseCompany(company_textBox.Text))
                    {
                        if (Hellp_DATABASE_COMPANY.CreateTableForCompanyPruduct(company_textBox.Text))
                        {
                            for (int i = 0; i < dataGridView_Product.Rows.Count; i++)
                            {
                                try
                                {
                                    Hellp_DATABASE_COMPANY.SendProductToCompanyProduct(company_textBox.Text,
                                    dataGridView_Product.Rows[i].Cells[0].Value.ToString());
                                }
                                catch (Exception ex)
                                {
                                    
                                }
                                
                            }
                            //MessageBox.Show($" הוספנו את {company_textBox.Text} לרשימת החברות שעובדות איתנו !");
                            error_label.Text = "We have added the company to the system";
                            error_label.Location = new Point(280, 297);
                            error_label.Visible = true;
                        }

                    }
                }
                else
                {
                    error_label.Text = "Have a same company in the Data";
                    error_label.Location = new Point(297, 297);
                    error_label.Visible = true;
                }
            }
            else
            {
                error_label.Text = "Add a company name";
                error_label.Location = new Point(329, 297);
                error_label.Visible = true;
            }
        }


        private void addProduct_textBox_Click(object sender, EventArgs e)
        {
            if(Hellp_English_Sintax.EnglishWithMakaf(product_textBox.Text))
            {
                dataGridView_Product.Rows.Add(product_textBox.Text);

            }
        }

        private void addProduct_textBox_MouseEnter(object sender, EventArgs e)
        {
            addProduct_textBox.BackColor = Color.FloralWhite;
            addProduct_textBox.ForeColor = Color.Black;
        }

        private void addProduct_textBox_MouseLeave(object sender, EventArgs e)
        {
            addProduct_textBox.BackColor = Color.FromArgb(34, 33, 74);
            addProduct_textBox.ForeColor = Color.FloralWhite;
        }

        private void addCompany_button_MouseEnter(object sender, EventArgs e)
        {
            addCompany_button.BackColor = Color.FloralWhite;
            addCompany_button.ForeColor = Color.Black;
        }

        private void addCompany_button_MouseLeave(object sender, EventArgs e)
        {
            addCompany_button.BackColor = Color.FromArgb(34, 33, 74);
            addCompany_button.ForeColor = Color.FloralWhite;
        }

        private void company_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible= false;
        }

        private void product_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
