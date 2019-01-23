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
    public partial class Update_Info_Manager : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Update_Info_Manager()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Update_Info_Manager_Load(object sender, EventArgs e)
        {
            textBox1.Text = Employee_info_Manager.id_update;

            label_name_com.Visible = false;
            label_email_com.Visible = false;
            label_address_com.Visible = false;
            label_cell_com.Visible = false;
            label_salary_com.Visible = false;
            label_age_com.Visible = false;



            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id='" + textBox1.Text + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox2.Text = (dr["name"].ToString());
                    textBox3.Text = (dr["email"].ToString());
                    textBox5.Text = (dr["age"].ToString());
                    textBox4.Text = (dr["mobile"].ToString());
                    textBox7.Text = (dr["address"].ToString());
                    textBox6.Text = (dr["salary"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something happened Wrong, Please check agein!! ", "ERROR");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update employee_info set name= '" + textBox2.Text + "', email='" + textBox3.Text + "', age='" + textBox5.Text + "', mobile='" + textBox4.Text + "', address='" + textBox7.Text + "', salary='" + textBox6.Text + "' Where employee_id='" + textBox1.Text + "'", conn);
                if (label_name_com.Visible == true || label_email_com.Visible == true || label_age_com.Visible == true || label_cell_com.Visible == true || label_address_com.Visible == true || label_salary_com.Visible == true)
                {
                    MessageBox.Show("Something Went Wrong, Please Check agein", "Warning");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully..");
                    Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }
    }
}
