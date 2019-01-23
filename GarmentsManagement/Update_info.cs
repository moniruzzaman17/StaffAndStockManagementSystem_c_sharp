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
    public partial class Update_info : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Update_info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox2.Text, "^[a-zA-Z ]*$").Success)
            {
                label_name_com.Visible = true;
                label_name_com.Text = "only alphabet and space is allowed**";
            }
            else
            {
                label_name_com.Text = "";
                label_name_com.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox3.Text, "^[a-z0-9_.+-]+@[a-z0-9-]+.[a-zA-Z0-9-.]+$").Success)
            {
                label_email_com.Visible = true;
                label_email_com.Text = "Email address pattern is not currect**";
            }
            else
            {
                label_email_com.Text = "";
                label_email_com.Visible = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox5.Text, "^[0-9]*$").Success)
            {
                label_age_com.Visible = true;
                label_age_com.Text = "Age must be a numeric value **";
            }
            else
            {
                try
                {
                    int t5 = Convert.ToInt16(textBox5.Text);
                    if (t5 < 18 || t5 > 45)
                    {
                        label_age_com.Visible = true;
                        label_age_com.Text = "age must be between 18-45 years**";
                    }
                    else
                    {
                        label_age_com.Text = "";
                        label_age_com.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    label_email_com.Visible = true;
                    label_age_com.Text = "Only number can converted into integer **";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox4.Text, "^[01]{2}[0-9]{9}$").Success)
            {
                label_cell_com.Visible = true;
                label_cell_com.Text = "Cell number is not valid**";
            }
            else
            {
                label_cell_com.Text = "";
                label_cell_com.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox7.Text, "^([a-zA-Z0-9, ])*$").Success)
            {
                label_address_com.Visible = true;
                label_address_com.Text = "Allow only any number of alphanumeric value**";
            }
            else
            {
                label_address_com.Text = "";
                label_address_com.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox6.Text, "^[0-9]*$").Success)
            {
                label_salary_com.Visible = true;
                label_salary_com.Text = "Allow only numeric value**";
            }
            else
            {
                label_salary_com.Text = "";
                label_salary_com.Visible = false;
            }
        }

        private void Update_info_Load(object sender, EventArgs e)
        {
                textBox1.Text = Employee_Info.id_update;

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
                if (label_name_com.Visible==true || label_email_com.Visible == true || label_age_com.Visible == true || label_cell_com.Visible == true || label_address_com.Visible == true || label_salary_com.Visible == true) 
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
