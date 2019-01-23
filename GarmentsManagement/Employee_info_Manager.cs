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
    public partial class Employee_info_Manager : Form
    {
        public static string id_update;
        OleDbConnection conn = new OleDbConnection();
        string user = "";
        public string type;


        public Employee_info_Manager()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Employee_info_Manager_Load(object sender, EventArgs e)
        {
            textBox_search.Text = "Search by ID";
            textBox_search.ForeColor = Color.Gray;
            textBox1.Text = "";
            textBox2.Text = "";


            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select [name],[employee_id],[em_type],[age],[gender],[Email],[mobile],[address],[salary] from employee_info", conn);
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Employee_info_Manager_Load(sender, e);
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

                try
                {
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id='" + textBox2.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        type = (dr["em_type"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
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
                Update_Info_Manager uim = new Update_Info_Manager();
                uim.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string admin_type = "admin";
            string staff_type = "staff manager";
            string stock_type = "stock manager";

            if (type == admin_type)
            {
                MessageBox.Show("Sorry you don't have right to Delete this Information...", "Warning");
            }
            else if (type == staff_type)
            {
                MessageBox.Show("Sorry you don't have right to Delete this Information...", "Warning");
            }
            else if (type == stock_type)
            {
                MessageBox.Show("Sorry you don't have right to Delete this Information...", "Warning");
            }
            else
            {

                DialogResult msg = MessageBox.Show("Are You Sure want to delete information?", "Important Question", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
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
                        }
                        else
                            MessageBox.Show("User name not selsected");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    conn.Close();
                    Employee_info_Manager_Load(sender, e);
                }
                else if (msg == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
