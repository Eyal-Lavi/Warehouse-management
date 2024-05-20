using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_management
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if ( email_textBox.Text.Length > 0 &&
                permissions_comboBox.SelectedIndex != -1&&
                Hellp_DATABASE_USERS.CheakHaveUserNameLikeThis(username_textBox.Text)==false&&
                Hellp_English_Sintax.EnglishOnlyAndNumbers(username_textBox.Text)&&
                Hellp_DATABASE_USERS.CheakSyntaxPass(password_textBox.Text))
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(email_textBox.Text);
                    if(Hellp_DATABASE_USERS.SendParameterDataBaseUsers(username_textBox.Text, password_textBox.Text, permissions_comboBox.Text.ToString(), email_textBox.Text))
                    {
                        error_label.Location = new Point(184, 195);
                        error_label.Text = "A new user has been created !";
                        error_label.Visible = true;
                    }
                    
                }
                catch (FormatException)
                {
                    error_label.Text = "The email is invalid !";
                    error_label.Visible = true;
                }

            }
            else
            {
                //An error in one of the entered parameters
                error_label.Location = new Point(148,195);
                error_label.Text = "An error in one of the entered parameters !";
                error_label.Visible = true;
            }
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }

        private void send_button_MouseEnter(object sender, EventArgs e)
        {
            send_button.BackColor = Color.FloralWhite;
            send_button.ForeColor = Color.Black;

        }

        private void send_button_MouseLeave(object sender, EventArgs e)
        {
            send_button.BackColor = Color.FromArgb(34, 33, 74);
            send_button.ForeColor = Color.FloralWhite;
        }

        private void username_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void password_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void email_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void permissions_comboBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
