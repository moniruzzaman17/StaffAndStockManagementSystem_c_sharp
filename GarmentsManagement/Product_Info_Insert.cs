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
    public partial class Product_Info_Insert : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Product_Info_Insert()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Product_Info_Insert_Load(object sender, EventArgs e)
        {
            textBox_code.Text = "";
            textBox_price.Text = "";
            comboBox1.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                try
                {
                    string type = "Polo";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 product_code from product_info where type='" + type + "'order by product_code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["product_code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "pts" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if(comboBox1.SelectedIndex==1)
            {
                try
                {
                    string type = "Round Neck";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 product_code from product_info where type='" + type + "'order by product_code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["product_code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "rnts" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if(comboBox1.SelectedIndex==2)
            {
                try
                {
                    string type = "V Neck";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 product_code from product_info where type='" + type + "'order by product_code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["product_code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "vnts" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if(comboBox1.SelectedItem==null)
            {
                textBox_code.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_price.Text == "" || textBox_code.Text == "" || comboBox1.SelectedItem == null ||
               comboBox3.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Textfield cannot be empty..", "Warning");
            }
            else
            {
                try
                {
                    string theDate = dateTimePicker1.Value.ToShortDateString();
                    OleDbCommand cmd = new OleDbCommand("insert into product_info(product_code, price, product_name, manufacturing_date, type, [size], sleeves, status) values('" + textBox_code.Text + "','" + textBox_price.Text + "','" + textBox_name.Text + "',#" + theDate + "#,'" + comboBox1.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + textBox_status.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product has been added Successfully !!");
                    conn.Close();
                    Product_Info_Insert_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_Info_Insert_Load(sender, e);
        }
    }
}
