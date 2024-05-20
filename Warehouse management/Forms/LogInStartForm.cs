using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_management.Forms;

namespace Warehouse_management
{
    public partial class LogInStartForm : Form
    {
        public static int count ;
        public LogInStartForm()
        {
            InitializeComponent();
            
        }

        //Code to move the window see where metoda panel click
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Code to move the window

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (InternetCheaker.Cheak())
            {
                if (Hellp_DATABASE_USERS.CheakLogIn(username_textBox.Text, password_textBox.Text))
                {
                    FormMenu SystemU = new FormMenu();
                    SystemU.Show();
                    this.Hide();
                }
                else
                {
                    error_label.Text = "Invalid User name or Password";
                    error_panel.Visible = true;
                }
            }
            else
            { 
                error_label.Text = "No internet connection !";
                error_panel.Visible = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginRightNow.LoginStatusToFalse();
            error_panel.Visible = false;
            forgot_error_label2.Visible = false;
            forgotPassword_panel.Visible = false;
            forgot_statusNewPass_label.Visible = false;
            count = 0;
           /* Task.Run(() =>
            {
                loading_pictureBox.Image = Image.FromFile("C:\\Users\\97250\\Desktop\\אייל\\פרויקטים אפליקציות\\ניהול מחסן\\loading.gif");
            });*/
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                username_textBox.ForeColor = Color.White;
                
            }
            catch { }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                password_textBox.PasswordChar = '●';
                password_textBox.ForeColor = Color.White;
            }
            catch { }
        }

        private void username_textBox_Click(object sender, EventArgs e)
        {
            try
            {
                username_textBox.SelectAll();
                error_panel.Visible = false;
            }
            catch { }
        }

        private void password_textBox_Click(object sender, EventArgs e)
        {
            try
            {
                password_textBox.SelectAll();
                error_panel.Visible = false;
            }
            catch { }
        }

        private void connect_button_MouseEnter(object sender, EventArgs e)
        {
            connect_button.ForeColor = Color.Black;
        }

        private void connect_button_MouseLeave(object sender, EventArgs e)
        {
            connect_button.ForeColor = Color.Lime;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgotPassword_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            forgotPassword_panel.Visible = true;
            password_textBox.Visible = false;
            username_textBox.Visible = false;
            connect_button.Visible = false;
            forgotPassword_linkLabel.Visible = false;
        }

        private void forgotConfirn_button_MouseEnter(object sender, EventArgs e)
        {
                forgotConfirn_button.ForeColor = Color.Black;
                forgotConfirn_button.BackColor = Color.Lime;

        }

        private void forgotConfirn_button_MouseLeave(object sender, EventArgs e)
        {
            forgotConfirn_button.ForeColor = Color.Lime;
            forgotConfirn_button.BackColor = Color.FromArgb(30,30,30);
        }

        private void forgotConfirn_button_Click(object sender, EventArgs e)
        {
            if (InternetCheaker.Cheak())
            {
                if (count < 2)
                {
                    if (Hellp_DATABASE_USERS.CheakHaveEmailAndUserNameOnDataAndDoIt2(forgotUsername_textBox2.Text, forgotEmail_textBox1.Text))
                    {
                        forgot_statusNewPass_label.Text = "Check your email for a new password!";
                        forgot_statusNewPass_label.Visible = true;
                        forgot_statusNewPass_label.Location = new Point(256, 357);
                        count++;
                    }
                    else
                    {
                        forgot_error_label2.Visible = true;
                    }
                }
                else
                {
                    forgot_statusNewPass_label.Text = "You can send only 3 times !";
                    forgot_statusNewPass_label.Visible = true;
                    forgot_statusNewPass_label.Location = new Point(256, 357);
                }
            }
            else
            {
                forgot_statusNewPass_label.Text = "No Internet connection !";
                forgot_statusNewPass_label.Visible = true;
                forgot_statusNewPass_label.Location = new Point(301, 356);
            }

        }

        private void forgot_backTOlogin_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword_panel.Visible = false;
            password_textBox.Visible = true;
            username_textBox.Visible = true;
            connect_button.Visible = true;
            forgotPassword_linkLabel.Visible = true;

        }

        private void forgotUsername_textBox2_Click(object sender, EventArgs e)
        {
            try
            {
                forgotUsername_textBox2.SelectAll();
                forgot_error_label2.Visible = false;
            }
            catch { }
        }

        private void forgotEmail_textBox1_Click(object sender, EventArgs e)
        {
            try
            {
                forgotEmail_textBox1.SelectAll();
                forgot_error_label2.Visible=false;
            }
            catch { }
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {   //code move the window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            //code move the window
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
