namespace Warehouse_management
{
    partial class addUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.permissions_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 497);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(137, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 287);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.error_label);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.password_textBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.username_textBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.permissions_comboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.email_textBox);
            this.panel2.Controls.Add(this.send_button);
            this.panel2.Location = new System.Drawing.Point(40, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 225);
            this.panel2.TabIndex = 9;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.error_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_label.Location = new System.Drawing.Point(148, 195);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(252, 16);
            this.error_label.TabIndex = 9;
            this.error_label.Text = "An error in one of the entered parameters ";
            this.error_label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(61, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Permissions";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(141, 74);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(261, 20);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.Click += new System.EventHandler(this.password_textBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(141, 37);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(261, 20);
            this.username_textBox.TabIndex = 2;
            this.username_textBox.Click += new System.EventHandler(this.username_textBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User name";
            // 
            // permissions_comboBox
            // 
            this.permissions_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.permissions_comboBox.FormattingEnabled = true;
            this.permissions_comboBox.Items.AddRange(new object[] {
            "SADMIN",
            "SUSER"});
            this.permissions_comboBox.Location = new System.Drawing.Point(141, 152);
            this.permissions_comboBox.Name = "permissions_comboBox";
            this.permissions_comboBox.Size = new System.Drawing.Size(118, 21);
            this.permissions_comboBox.TabIndex = 1;
            this.permissions_comboBox.Click += new System.EventHandler(this.permissions_comboBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(141, 112);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(261, 20);
            this.email_textBox.TabIndex = 4;
            this.email_textBox.Click += new System.EventHandler(this.email_textBox_Click);
            // 
            // send_button
            // 
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.send_button.Location = new System.Drawing.Point(288, 152);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(114, 28);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Confirm";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            this.send_button.MouseEnter += new System.EventHandler(this.send_button_MouseEnter);
            this.send_button.MouseLeave += new System.EventHandler(this.send_button_MouseLeave);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.panel1);
            this.Name = "addUserForm";
            this.Text = "Add user ";
            this.Load += new System.EventHandler(this.addUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox permissions_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label error_label;
    }
}