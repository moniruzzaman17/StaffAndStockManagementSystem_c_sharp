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
using System.IO;

namespace GarmentsManagement
{
    public partial class Registration : Form
    {
        public string image_file;
        OleDbConnection conn = new OleDbConnection();
        public Registration()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset textbox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            //reset comment box
            label_name_com.Text = "";
            label_id_com.Text = "";
            label_age_com.Text = "";
            label_address_com.Text = "";
            label_cell_com.Text = "";
            label_salary_com.Text = "";
            label_email_com.Text = "";

            //reset combobox
            comboBox1.SelectedItem = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox1.Text, "^[a-zA-Z ]*$").Success)
            {
                /* // first name was incorrect
                 MessageBox.Show("Invalid first name", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                 firstNameTextBox.Focus();
                 return; */
                label_name_com.Text = "only alphabet and space is allowed**";
                
               // return;
            }
            else if(textBox1.Text.Equals(null))
            {
                label_name_com.Text = "";
            }
            else
            {
                label_name_com.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where employee_id='" + textBox2.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_id_com.Text = "Sorry this ID already taken** choose another one**";
                }
                else if (textBox2.Text.Equals(null))
                {
                    label_id_com.Text = "";
                }
                else
                {
                    label_id_com.Text = "";
                }
            }
            catch (Exception ex)
            {
                label_id_com.Text = "";
            }
            conn.Close();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox5.Text, "^[0-9]*$").Success)
            {
                label_age_com.Text = "Age must be a numeric value **";
            }
            else if (textBox5.Text=="")
            {
                label_age_com.Text = "";
            }
            else
            {
                try
                {
                    int t5 = Convert.ToInt16(textBox5.Text);
                    if (t5 < 18 || t5 > 45)
                    {
                        label_age_com.Text = "age must be between 18-45 years**";
                    }
                    else
                    {
                        label_age_com.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    label_age_com.Text = "Only number can converted into integer **";
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox6.Text, "^[a-z0-9_.+-]+@[a-z0-9-]+.[a-zA-Z0-9-.]+$").Success)
            {
                label_email_com.Text = "Email address pattern is not currect**";
            }
            else if (textBox6.Text.Equals(null)) 
            {
                label_email_com.Text = "";
            }
            else
            {
                label_email_com.Text = "";
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

        //Decryption Code
        public static string Decryptdata(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
           {
                /*
                string pass_parameter = textBox3.Text;
                string pass = Encryptdata(pass_parameter); */

                if (textBox1.Text == "" || textBox2.Text == "" || 
                    textBox5.Text == "" || textBox6.Text == "" || comboBox1.SelectedIndex == null ||
                    label_name_com.Text != "" || label_id_com.Text != "" || 
                    label_age_com.Text != "" || label_email_com.Text != "")
                {
                    MessageBox.Show("Textfield cannot be empty..", "Warning");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("insert into employee_info(name, employee_id, age, gender, email, mobile, address, salary) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration Successfull !!");

                    button2_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !!" + ex);
            }
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox7.Text, "^[01]{2}[0-9]{9}$").Success)
            {
                label_cell_com.Text = "Cell number is not valid**";
            }
            else if (textBox7.Text == "") 
            {
                label_cell_com.Text = "You can not leave blank textfield**";
            }
            else
            {
                label_cell_com.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox8.Text, "^([a-zA-Z0-9, ])*$").Success)
            {
                label_address_com.Text = "Allow only any number of alphanumeric value**";
            }
            else if (textBox8.Text.Equals(null))
            {
                label_address_com.Text = "";
            }
            else
            {
                label_address_com.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox9.Text, "^[0-9]*$").Success)
            {
                label_salary_com.Text = "Allow only numeric value**";
            }
            else if (textBox9.Text.Equals(null))
            {
                label_salary_com.Text = "";
            }
            else
            {
                label_salary_com.Text = "";
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
