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
    public partial class AddBranch_From : Form
    {
        public AddBranch_From()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(Hellp_English_Sintax.EnglishWithMakaf(branch_textBox.Text))
            {
                string[,] dataBranch = Hellp_DATABASE_BRANCH.GetFromDatabaseBranch();
                bool cheak = true;
                for (int i = 0; i < dataBranch.GetLength(0); i++)
                {
                    if (branch_textBox.Text == dataBranch[i, 1])
                    {
                        cheak = false;
                        break;
                    }
                }
                if (cheak)
                {
                    Hellp_DATABASE_BRANCH.SendParameterDataBaseBranch(branch_textBox.Text);
                    error_label.Text = "The branch added";
                    error_label.Location = new Point(154, 184);
                    error_label.Visible= true;
                }
                else
                {
                    error_label.Text = "The branch already exists in the system";
                    error_label.Location = new Point(103, 184);
                    error_label.Visible = true;
                }
            }
            else
            {
                error_label.Text = "Enter the name of a branch without spaces!";
                error_label.Location = new Point(92, 184);
                error_label.Visible = true;
            }

        }

        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FloralWhite;
            add_button.ForeColor = Color.Black;
        }

        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FromArgb(34, 33, 74);
            add_button.ForeColor = Color.FloralWhite;
        }

        private void branch_textBox_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
