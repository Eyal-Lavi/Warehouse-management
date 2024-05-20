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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void orderProduct_button_Click(object sender, EventArgs e)
        {
            orderForm a = new orderForm();
            a.Show();
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            inventoryForm a = new inventoryForm();
            a.Show();
        }

        private void adminLogin_button_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (LoginRightNow.GetLoginStatus() == false)
            {
                adminLogin_button.Enabled = false; 
            }
            status_label.Text = "אתה מחובר בהרשאת מנהל";
            LoginRightNow.UpdateData();

        }

        private void orderList_button_Click(object sender, EventArgs e)
        {
            order_list_Form a = new order_list_Form();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sendToBrunch_button_Click(object sender, EventArgs e)
        {
            SendingToBranchForm a = new SendingToBranchForm();
            a.Show();
        }
    }
}
