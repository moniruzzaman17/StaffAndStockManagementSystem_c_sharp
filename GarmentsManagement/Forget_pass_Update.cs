using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace GarmentsManagement
{
    public partial class Forget_pass_Update : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Forget_pass_Update()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Forget_pass_Update_Load(object sender, EventArgs e)
        {
            textBox5.Text = Forget_Password.pass_type;
            update_title.Text = Forget_Password.pass_utitle;
            textBox1.Text = Forget_Password.pass_uid;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox3.Text, "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,10})$").Success)
            {
                label_input_pass_com.Text = "Must contain Character and number(min=5, Max=10)";
            }
            else if (textBox3.Text.Equals(null))
            {
                label_input_pass_com.Text = "";
            }
            else
            {
                label_input_pass_com.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox3.Text)
            {
                label_confirm_pass_com.Text = "";
            }
            else
            {
                label_confirm_pass_com.Text = "Password not matched**";
            }
        }

        //Encryption Code
        public static string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass_parameter = textBox4.Text;
                string pass = Encryptdata(pass_parameter);

                if (textBox3.Text == "" || textBox4.Text == "" || label_confirm_pass_com.Text != "" || label_input_pass_com.Text != "")
                {
                    MessageBox.Show("Something went wrong please check again..", "Warning");
                }
                else
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("update employee_info set em_password= '" + pass + "', em_type='" + textBox5.Text + "' Where employee_id='" + textBox1.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Re-registration Successfull !!");

                    Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !!" + ex);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
