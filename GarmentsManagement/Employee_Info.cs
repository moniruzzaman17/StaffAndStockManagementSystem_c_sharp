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
    public partial class Employee_Info : Form
    {
        string decrypted_pass;

        public static string pass_value;
        public static string title;
        public static string name;
        public static string type;
        public static string id_update;

        string user = "";
        OleDbConnection conn = new OleDbConnection();

        public Employee_Info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Employee_Info_Load(object sender, EventArgs e)
        {
            textBox_search.Text = "Search by ID";
            textBox_search.ForeColor = Color.Gray;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedItem = null;


            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select [name],[employee_id],[em_password],[em_type],[age],[gender],[Email],[mobile],[address],[salary] from employee_info", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            conn.Close();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = "";
                decrypted_pass = row.Cells[2].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
            {
                MessageBox.Show("Please select Employee First", "Warning");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    pass_value = textBox2.Text;
                    name = textBox1.Text;
                    type = "admin";
                    title = "Admin Update Form";
                    admin_and_manager_update amu = new admin_and_manager_update();
                    amu.Show();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    pass_value = textBox2.Text;
                    name = textBox1.Text;
                    type = "staff manager";
                    title = "Staff Manager Update Form";
                    admin_and_manager_update amu = new admin_and_manager_update();
                    amu.Show();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    pass_value = textBox2.Text;
                    name = textBox1.Text;
                    type = "stock manager";
                    title = "Stock Manager Update Form";
                    admin_and_manager_update amu = new admin_and_manager_update();
                    amu.Show();
                }
                else
                {
                    pass_value = textBox2.Text;
                    name = textBox1.Text;
                    type = "";
                    title = "Designation Changing Form";
                    admin_and_manager_update amu = new admin_and_manager_update();
                    amu.Show();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = Decryptdata(decrypted_pass);
                textBox3.Text = pass;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something happend wrong, please select the right Employee", "Warning");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id='" + textBox_search.Text + "'", conn);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void textBox_search_Enter(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            textBox_search.ForeColor = Color.Black;
        }

        private void textBox_search_Leave(object sender, EventArgs e)
        {
            user = textBox_search.Text;
            if (user.Equals("Search by ID"))
            {
                textBox_search.Text = "Search by ID";
                textBox_search.ForeColor = Color.Gray;
             }
             else
             {
                 if (user.Equals(""))
                 {
                    textBox_search.Text = "Search by ID";
                    textBox_search.ForeColor = Color.Gray;
                 }
                 else
                 {
                    textBox_search.Text = user;
                    textBox_search.ForeColor = Color.Black;
                 }
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("delete from employee_info Where employee_id='" + textBox2.Text + "'", conn);
                if (textBox1.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfull");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                    MessageBox.Show("User name not selsected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
            conn.Close();
            Employee_Info_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please select Employee First, for update information", "Warning");
            }
            else
            {
                id_update = textBox2.Text;
                Update_info u = new Update_info();
                u.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee_Info_Load(sender, e);
        }
    }
}
