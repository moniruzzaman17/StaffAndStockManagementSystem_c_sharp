using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GarmentsManagement
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string user = "";
        string pass = "";

        public Form1()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            user = textBox1.Text;
            if (user.Equals("User Name"))
            {
                textBox1.Text = "User Name";
                textBox1.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    textBox1.Text = "User Name";
                    textBox1.ForeColor = Color.Gray;
                }
                else
                {
                    textBox1.Text = user;
                    textBox1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            pass = textBox2.Text;
            if (pass.Equals("Password"))
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
            else
            {
                if (pass.Equals(""))
                {
                    textBox2.PasswordChar = '\0';
                    textBox2.Text = "Password";
                    textBox2.ForeColor = Color.Gray;
                }
                else
                {
                    textBox2.PasswordChar = '*';
                    textBox2.Text = pass;
                    textBox2.ForeColor = Color.Black;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
            pictureBox1.Focus();
            textBox1.Text = "User Name";
            textBox2.Text = "Password";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -300)
            {
                label1.Left = label1.Left + 900;
            }
            else
            {
                label1.Left -= 1;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            textBox1.Text = "User Name";
            textBox2.Text = "Password";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            comboBox1.SelectedItem = null;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Make sure that your internet connection is on....");
            Forget_Password fp = new Forget_Password();
            fp.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string pass_parameter = textBox2.Text;
                string pass = Encryptdata(pass_parameter);

                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where employee_id='" + textBox1.Text + "' and em_type = '" + comboBox1.SelectedItem.ToString() + "' and em_password='" + pass + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        Visible = false;
                        Admin_Home ah = new Admin_Home();
                        ah.Show();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        Visible = false;
                        Staff_Home sh = new Staff_Home();
                        sh.Show();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        Visible = false;
                        Stock_Home sth = new Stock_Home();
                        sth.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input or Type !!");
                    }
                }
                else
                {
                    string pass_parameter2 = textBox2.Text;
                    string pass2 = Encryptdata(pass_parameter2);
                    string type = "admin";
                    OleDbDataReader dr2 = null;
                    OleDbCommand cmd2 = new OleDbCommand("select * from employee_info where employee_id='" + textBox1.Text + "' and em_type = '" + type + "' and em_password='" + pass2 + "'", conn);
                    dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        if (comboBox1.SelectedIndex == 1)
                        {
                            Visible = false;
                            Staff_Home sh = new Staff_Home();
                            sh.Show();
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            Visible = false;
                            Stock_Home sth = new Stock_Home();
                            sth.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input or Type !!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input or Type !!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
