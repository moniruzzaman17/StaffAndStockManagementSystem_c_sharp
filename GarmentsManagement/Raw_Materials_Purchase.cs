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
using System.Text.RegularExpressions;

namespace GarmentsManagement
{
    public partial class Raw_Materials_Purchase : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Raw_Materials_Purchase()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    string type = "Yarn";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 Item_Code from raw_materials_purchase where Item_Name='" + type + "'order by Item_Code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Item_Code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "yrn" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    string type = "Dyes";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 Item_Code from raw_materials_purchase where Item_Name='" + type + "'order by Item_Code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Item_Code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "dys" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    string type = "Chemical and Auxiliaries";
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 Item_Code from raw_materials_purchase where Item_Name='" + type + "'order by Item_Code desc", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string input = dr["Item_Code"].ToString();
                        string angka = input.Substring(input.Length - Math.Min(3, input.Length));
                        int number = Convert.ToInt32(angka);
                        number += 1;
                        string str = number.ToString("D3");

                        textBox_code.Text = "chem" + str;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if (comboBox1.SelectedItem == null)
            {
                textBox_code.Text = "";
            }
        }

        private void Raw_Materials_Purchase_Load(object sender, EventArgs e)
        {
            textBox_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            textBox_time.Text = DateTime.Now.ToString("h:mm:ss tt");

            try
            {
                string status = "available";
                conn.Open();
                OleDbCommand cmd2 = new OleDbCommand("Select [Purchase_Date], [Item_Name], [Item_Code], [Quantity], [Price], [Location], [stock_status] from raw_materials_purchase where Purchase_Date= #" + textBox_date.Text + "# and stock_status='" + status + "'", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd2);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox_status.Text == "" || textBox_location.Text == "" ||
                textBox_date.Text == "" || textBox_code.Text == "" || comboBox1.SelectedItem==null ||
                textBox_quantity.Text == "" || textBox_price.Text == "")
            {
                MessageBox.Show("Textfield cannot be empty..", "Warning");
            }
            else
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into raw_materials_purchase(Purchase_Date, Item_Name, Item_Code,  Quantity, Price, Location, stock_status) values('" + textBox_date.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox_code.Text + "','" + textBox_quantity.Text + "','" + textBox_price.Text + "','" + textBox_location.Text + "','" + textBox_status.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Raw Material Purchase Successfull !!");
                    textBox_code.Text = "";
                    comboBox1.SelectedItem = null;
                    textBox_price.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR !!" + ex);
                }
                conn.Close();
            }

            Raw_Materials_Purchase_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_status.Text = "";
            textBox_location.Text = "";
            textBox_code.Text = "";
            textBox_quantity.Text = "";
            textBox_price.Text = "";
            comboBox1.SelectedItem = null;
        }
    }
}
