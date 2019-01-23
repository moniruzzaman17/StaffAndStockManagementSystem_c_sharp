namespace GarmentsManagement
{
    partial class Forget_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_vcode_com = new System.Windows.Forms.Label();
            this.radioButton_stock = new System.Windows.Forms.RadioButton();
            this.radioButton_staff = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.label_email_com = new System.Windows.Forms.Label();
            this.label_phone_com = new System.Windows.Forms.Label();
            this.label_id_com = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_vcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_random = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please give all the registered information for reset your password\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_vcode_com);
            this.groupBox1.Controls.Add(this.radioButton_stock);
            this.groupBox1.Controls.Add(this.radioButton_staff);
            this.groupBox1.Controls.Add(this.radioButton_admin);
            this.groupBox1.Controls.Add(this.label_email_com);
            this.groupBox1.Controls.Add(this.label_phone_com);
            this.groupBox1.Controls.Add(this.label_id_com);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox_vcode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_mail);
            this.groupBox1.Controls.Add(this.textBox_mobile);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(41, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill Up the information";
            // 
            // label_vcode_com
            // 
            this.label_vcode_com.AutoSize = true;
            this.label_vcode_com.ForeColor = System.Drawing.Color.Red;
            this.label_vcode_com.Location = new System.Drawing.Point(196, 268);
            this.label_vcode_com.Name = "label_vcode_com";
            this.label_vcode_com.Size = new System.Drawing.Size(10, 13);
            this.label_vcode_com.TabIndex = 19;
            this.label_vcode_com.Text = " ";
            // 
            // radioButton_stock
            // 
            this.radioButton_stock.AutoSize = true;
            this.radioButton_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_stock.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton_stock.Location = new System.Drawing.Point(311, 161);
            this.radioButton_stock.Name = "radioButton_stock";
            this.radioButton_stock.Size = new System.Drawing.Size(121, 19);
            this.radioButton_stock.TabIndex = 18;
            this.radioButton_stock.TabStop = true;
            this.radioButton_stock.Text = "Stock Manager";
            this.radioButton_stock.UseVisualStyleBackColor = true;
            this.radioButton_stock.CheckedChanged += new System.EventHandler(this.radioButton_stock_CheckedChanged);
            // 
            // radioButton_staff
            // 
            this.radioButton_staff.AutoSize = true;
            this.radioButton_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_staff.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton_staff.Location = new System.Drawing.Point(159, 161);
            this.radioButton_staff.Name = "radioButton_staff";
            this.radioButton_staff.Size = new System.Drawing.Size(115, 19);
            this.radioButton_staff.TabIndex = 17;
            this.radioButton_staff.TabStop = true;
            this.radioButton_staff.Text = "Staff Manager";
            this.radioButton_staff.UseVisualStyleBackColor = true;
            this.radioButton_staff.CheckedChanged += new System.EventHandler(this.radioButton_staff_CheckedChanged);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_admin.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton_admin.Location = new System.Drawing.Point(53, 161);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(65, 19);
            this.radioButton_admin.TabIndex = 16;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "Admin";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // label_email_com
            // 
            this.label_email_com.AutoSize = true;
            this.label_email_com.ForeColor = System.Drawing.Color.Red;
            this.label_email_com.Location = new System.Drawing.Point(171, 145);
            this.label_email_com.Name = "label_email_com";
            this.label_email_com.Size = new System.Drawing.Size(10, 13);
            this.label_email_com.TabIndex = 15;
            this.label_email_com.Text = " ";
            // 
            // label_phone_com
            // 
            this.label_phone_com.AutoSize = true;
            this.label_phone_com.ForeColor = System.Drawing.Color.Red;
            this.label_phone_com.Location = new System.Drawing.Point(171, 96);
            this.label_phone_com.Name = "label_phone_com";
            this.label_phone_com.Size = new System.Drawing.Size(10, 13);
            this.label_phone_com.TabIndex = 14;
            this.label_phone_com.Text = " ";
            // 
            // label_id_com
            // 
            this.label_id_com.AutoSize = true;
            this.label_id_com.ForeColor = System.Drawing.Color.Red;
            this.label_id_com.Location = new System.Drawing.Point(171, 53);
            this.label_id_com.Name = "label_id_com";
            this.label_id_com.Size = new System.Drawing.Size(10, 13);
            this.label_id_com.TabIndex = 13;
            this.label_id_com.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Send a varification code to your Mail";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_vcode
            // 
            this.textBox_vcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vcode.Location = new System.Drawing.Point(196, 243);
            this.textBox_vcode.Name = "textBox_vcode";
            this.textBox_vcode.Size = new System.Drawing.Size(169, 22);
            this.textBox_vcode.TabIndex = 10;
            this.textBox_vcode.TextChanged += new System.EventHandler(this.textBox_vcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter a varification code";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(174, 120);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(191, 22);
            this.textBox_mail.TabIndex = 8;
            this.textBox_mail.TextChanged += new System.EventHandler(this.textBox_mail_TextChanged);
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mobile.Location = new System.Drawing.Point(174, 73);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(191, 22);
            this.textBox_mobile.TabIndex = 7;
            this.textBox_mobile.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(174, 28);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(191, 22);
            this.textBox_id.TabIndex = 6;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(506, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_random
            // 
            this.text_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_random.Location = new System.Drawing.Point(409, 78);
            this.text_random.Name = "text_random";
            this.text_random.PasswordChar = '*';
            this.text_random.ReadOnly = true;
            this.text_random.Size = new System.Drawing.Size(191, 22);
            this.text_random.TabIndex = 9;
            this.text_random.Visible = false;
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 410);
            this.Controls.Add(this.text_random);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(628, 448);
            this.MinimumSize = new System.Drawing.Size(628, 448);
            this.Name = "Forget_Password";
            this.Text = "Forget_Password";
            this.Load += new System.EventHandler(this.Forget_Password_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_vcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_random;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_email_com;
        private System.Windows.Forms.Label label_phone_com;
        private System.Windows.Forms.Label label_id_com;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_stock;
        private System.Windows.Forms.RadioButton radioButton_staff;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Label label_vcode_com;
    }
}