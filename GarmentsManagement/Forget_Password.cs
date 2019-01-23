using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;

namespace GarmentsManagement
{
    public partial class Forget_Password : Form
    {
        public static string pass_type;
        public static string pass_uid;
        public static string pass_upass;
        public static string pass_utitle;

        string type;
        OleDbConnection conn = new OleDbConnection();

        public Forget_Password()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            text_random.Text = r.Next().ToString();
            textBox_mobile.ReadOnly = true;
            textBox_mail.ReadOnly = true;
            textBox_vcode.ReadOnly = true;

            radioButton_admin.Enabled = false;
            radioButton_staff.Enabled = false;
            radioButton_stock.Enabled = false;

            button2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_mail.Text!=null)
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("radialgroups@gmail.com");
                    mail.To.Add(textBox_mail.Text);
                    mail.Subject = "Mail verification from Radial International LTD";
                    mail.Body = "This is your verification Code: " + text_random.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("radialgroups", "radialgroups123");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Enter the correct information what you have registered..", "Warning");
            }
        }

        private void textBox_mail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where email='" + textBox_mail.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_email_com.Text = "";

                    textBox_vcode.ReadOnly = false;

                    radioButton_admin.Enabled = true;
                    radioButton_staff.Enabled = true;
                    radioButton_stock.Enabled = true;

                    button2.Enabled = true;
                }
                else
                {
                    label_email_com.Text = "your input email is not matched with registered email**";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong please check everything again", "ERROR");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_mobile.Text == "" || textBox_mail.Text == "" || textBox_vcode.Text == "")
            {
                MessageBox.Show("TextField Can not be Empty..", "Warning");
            }
            else if (radioButton_admin.Checked == false && radioButton_staff.Checked == false && radioButton_stock.Checked == false) 
            {
                MessageBox.Show("Please Checked in Designation or Type", "Warning");
            }
            else if(text_random.Text == textBox_vcode.Text)
            {
                Dispose();
                Forget_pass_Update fpu = new Forget_pass_Update();
                fpu.Show();
            }
            else
            {
                MessageBox.Show("Please Enter the correct Information for update password", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where employee_id='" + textBox_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_id_com.Text = "";

                    textBox_mobile.ReadOnly = false;
                    textBox_mail.ReadOnly = true;
                    textBox_vcode.ReadOnly = true;
                }
                else
                {
                    label_id_com.Text = "your input ID is not matched with registered ID**";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong please check everything again", "ERROR");
            }
            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where mobile='" + textBox_mobile.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_phone_com.Text = "";

                    textBox_mail.ReadOnly = false;
                    textBox_vcode.ReadOnly = true;

                    radioButton_admin.Enabled = false;
                    radioButton_staff.Enabled = false;
                    radioButton_stock.Enabled = false;
                }
                else
                {
                    label_phone_com.Text = "your input number is not matched with registered number**";
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("something went wrong please check everything again", "ERROR");
                MessageBox.Show(ex + "Error");

            }
            conn.Close();
        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_admin.Checked == true)
            {
                try
                {
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id ='" + textBox_id.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        type = (dr["em_type"].ToString());

                    }
                    if (type=="admin")
                    {
                        pass_type = "admin";
                        pass_uid = textBox_id.Text;
                        pass_upass = textBox_mobile.Text;
                        pass_utitle = "Admin Password Recovery Form";
                    }
                    else
                    {
                        MessageBox.Show("Sorry Your ID not matched with Designation or Type.. ","Error");
                        radioButton_admin.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error");

                }
                conn.Close();
            }
        }

        private void radioButton_staff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_staff.Checked == true)
            {
                try
                {
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id ='" + textBox_id.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        type = (dr["em_type"].ToString());

                    }
                    if (type == "staff manager")
                    {
                        pass_type = "staff manager";
                        pass_uid = textBox_id.Text;
                        pass_upass = textBox_mobile.Text;
                        pass_utitle = "Staff Manager Password Recovery Form";
                    }
                    else
                    {
                        MessageBox.Show("Sorry Your ID not matched with Designation or Type.. ", "Error");
                        radioButton_staff.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error");

                }
                conn.Close();
            }
        }

        private void radioButton_stock_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_stock.Checked == true)
            {
                try
                {
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id ='" + textBox_id.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        type = (dr["em_type"].ToString());

                    }
                    if (type == "stock manager")
                    {
                        pass_type = "stock manager";
                        pass_uid = textBox_id.Text;
                        pass_upass = textBox_mobile.Text;
                        pass_utitle = "Stock Manager Password Recovery Form";
                    }
                    else
                    {
                        MessageBox.Show("Sorry Your ID not matched with Designation or Type.. ", "Error");
                        radioButton_stock.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error");

                }
                conn.Close();
            }
        }

        private void textBox_vcode_TextChanged(object sender, EventArgs e)
        {
            if(text_random.Text==textBox_vcode.Text)
            {
                label_vcode_com.Text = "";
            }
            else
            {
                label_vcode_com.Text = "Varification Code not Matched**";
            }
        }
    }
}
