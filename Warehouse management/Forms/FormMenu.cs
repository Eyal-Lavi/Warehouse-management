using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Warehouse_management.Forms.UserForms;

namespace Warehouse_management.Forms
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMenu()
        {
            InitializeComponent();
            leftBorderBtn= new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172,126,241 );
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249,118,176 );
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }
        private void ActivateButtun(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {   
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location= new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current child Form
                iconCurrentChildForm.IconChar= currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //label text current child Form
                labelChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn!= null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChildForm.Text= childForm.Text;
        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color1);
            OpenChildForm(new SendingToBranchForm());
        }

        private void btn_ExportToFile_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color2);
            OpenChildForm(new exportToExcelFileFrom());
        }

        private void btn_OrdersPending_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color3);
            OpenChildForm(new order_list_Form());
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color4);
            OpenChildForm(new inventoryForm());
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color5);
            OpenChildForm(new orderForm());
        }

        private void btn_Management_Click(object sender, EventArgs e)
        {
            ActivateButtun(sender, RGBColors.color6);
            OpenChildForm(new AdminForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();    
        }
        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            labelChildForm.Text = "Home";
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void exit_iconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (LoginRightNow.GetLoginStatus() == false)
            {
                btn_Management.Enabled = false;
            }
            LoginRightNow.UpdateData();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LogInStartForm a = new LogInStartForm();
            a.Show();
            this.Close();
        }

        private void confirm_password_iconButton_Click(object sender, EventArgs e)
        {
            if (Hellp_DATABASE_USERS.ChangePasswordInTheApp(Old_Password_textBox.Text, NewPassword_textBox.Text))
            {
                errorChangePassword_label.Location = new Point(52, 97);
                errorChangePassword_label.Text = "Changed successfully";
                Old_Password_textBox.Text = "";
                NewPassword_textBox.Text = "";
                errorChangePassword_label.ForeColor = System.Drawing.Color.Green;
                errorChangePassword_label.Visible = true;
            }
            else
            {
                errorChangePassword_label.Location = new Point(24, 97);
                errorChangePassword_label.Text = "Error in the information entered";
                errorChangePassword_label.ForeColor = System.Drawing.Color.Red;
                errorChangePassword_label.Visible = true;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (errorChangePassword_label.Visible == true)
            {
                errorChangePassword_label.Visible=false;
            }
            if(iconButton2.Text== "Change Password")
            {
                iconButton2.Text = "Close";
                panel_ChangePassword.Visible = true;

            }
            else 
            {
                iconButton2.Text = "Change Password";
                Old_Password_textBox.Text = "Enter your old Password";
                NewPassword_textBox.Text = "Enter your new Password";
                panel_ChangePassword.Visible = false;
            }

        }

        private void Old_Password_textBox_Click(object sender, EventArgs e)
        {
            Old_Password_textBox.SelectAll();
            errorChangePassword_label.Visible = false;
        }

        private void NewPassword_textBox_Click(object sender, EventArgs e)
        {
            NewPassword_textBox.SelectAll();
            errorChangePassword_label.Visible = false;
        }
    }
}
