namespace Warehouse_management
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.sendToBrunch_button = new System.Windows.Forms.Button();
            this.adminLogin_button = new System.Windows.Forms.Button();
            this.orderList_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderProduct_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendToBrunch_button
            // 
            this.sendToBrunch_button.Location = new System.Drawing.Point(46, 108);
            this.sendToBrunch_button.Name = "sendToBrunch_button";
            this.sendToBrunch_button.Size = new System.Drawing.Size(217, 154);
            this.sendToBrunch_button.TabIndex = 0;
            this.sendToBrunch_button.UseVisualStyleBackColor = true;
            this.sendToBrunch_button.Click += new System.EventHandler(this.sendToBrunch_button_Click);
            // 
            // adminLogin_button
            // 
            this.adminLogin_button.Location = new System.Drawing.Point(595, 108);
            this.adminLogin_button.Name = "adminLogin_button";
            this.adminLogin_button.Size = new System.Drawing.Size(217, 154);
            this.adminLogin_button.TabIndex = 0;
            this.adminLogin_button.UseVisualStyleBackColor = true;
            this.adminLogin_button.Click += new System.EventHandler(this.adminLogin_button_Click);
            // 
            // orderList_button
            // 
            this.orderList_button.Location = new System.Drawing.Point(46, 336);
            this.orderList_button.Name = "orderList_button";
            this.orderList_button.Size = new System.Drawing.Size(217, 154);
            this.orderList_button.TabIndex = 0;
            this.orderList_button.UseVisualStyleBackColor = true;
            this.orderList_button.Click += new System.EventHandler(this.orderList_button_Click);
            // 
            // inventory_button
            // 
            this.inventory_button.Location = new System.Drawing.Point(595, 336);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(217, 154);
            this.inventory_button.TabIndex = 0;
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "שלח לסניף";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "התחברות מנהל";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "רשימת הזמנות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "מלאי מחסן";
            // 
            // orderProduct_button
            // 
            this.orderProduct_button.Location = new System.Drawing.Point(318, 336);
            this.orderProduct_button.Name = "orderProduct_button";
            this.orderProduct_button.Size = new System.Drawing.Size(217, 154);
            this.orderProduct_button.TabIndex = 0;
            this.orderProduct_button.UseVisualStyleBackColor = true;
            this.orderProduct_button.Click += new System.EventHandler(this.orderProduct_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "הזמנת/הזנת מוצרים";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 507);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(355, 249);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(153, 13);
            this.status_label.TabIndex = 4;
            this.status_label.Text = "אתה מחובר בהרשאת משתמש";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 519);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventory_button);
            this.Controls.Add(this.orderList_button);
            this.Controls.Add(this.orderProduct_button);
            this.Controls.Add(this.adminLogin_button);
            this.Controls.Add(this.sendToBrunch_button);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "WarehouseManagement";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendToBrunch_button;
        private System.Windows.Forms.Button adminLogin_button;
        private System.Windows.Forms.Button orderList_button;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button orderProduct_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status_label;
    }
}