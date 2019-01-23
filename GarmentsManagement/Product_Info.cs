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
    public partial class Product_Info : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string polo = "Polo";
        string round_neck = "Round Neck";
        string v_neck = "V Neck";
        string status = "available";
        public Product_Info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Product_Info_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;

            //Code for count total available T-Shirt
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where status='" + status + "'", conn);
                OleDbDataReader row_reader = cmd.ExecuteReader();
                while (row_reader.Read())
                {
                    label_available.Text = row_reader.GetInt32(0).ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            //Code for view details in datagrid view
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select [manufacturing_date], [type], [sleeves], [size], [price] from product_info where status='" + status + "'", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            label_long_total.Text = "";
            label_sort_total.Text = "";

            textBox_total.Text = "";
            textBox_m_short_total.Text = "";
            textBox_l_short_total.Text = "";
            textBox_xl_short_total.Text = "";

            textBox_m_long_total.Text = "";
            textBox_l_long_total.Text = "";
            textBox_xl_long_total.Text = "";

            comboBox1.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                label_total_type_name.Text = "Total Polo T-Shirt:-";
                //Code for count total Polo T-Shirt
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //Code for count total Short Sleeves polo T-Shirt
                try
                {
                    string s = "Short";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_sort_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Short Sleeves T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //****************************
                //****************************
                //****************************

                //Code for count total Long Sleeves T-Shirt
                try
                {
                    string s = "Long";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Long Sleeves T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + polo + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("select [manufacturing_date], [type], [sleeves], [size], [price] from product_info Where type='" + polo + "' and status='" + status + "'", conn);
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

            else if (comboBox1.SelectedIndex == 1)
            {
                label_total_type_name.Text = "Total Rond Neck T-Shirt:-";
                //Code for count total Round Neck T-Shirt
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //Code for count total Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Short";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_sort_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //****************************
                //****************************
                //****************************

                //Code for count total Long Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Long";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Long Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves Round Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + round_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("select [manufacturing_date], [type], [sleeves], [size], [price] from product_info Where type='" + round_neck + "' and status='" + status + "'", conn);
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


            else if (comboBox1.SelectedIndex == 2)
            {
                label_total_type_name.Text = "Total V Neck T-Shirt:-";
                //Code for count total V Neck T-Shirt
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //Code for count total Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Short";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_sort_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Short";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_short_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                //****************************
                //****************************
                //****************************

                //Code for count total Long Sleeves T-Shirt
                try
                {
                    string s = "Long";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }


                //Code for count total M Size Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "M";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_m_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total L Size Long Sleeves V Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "L";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_l_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }



                //Code for count total XL Size Short Sleeves V Neck T-Shirt
                try
                {
                    string s = "Long";
                    string sz = "XL";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where sleeves='" + s + "' and [size]='" + sz + "' and type='" + v_neck + "' and status='" + status + "'", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        textBox_xl_long_total.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("select [manufacturing_date], [type], [sleeves], [size], [price] from product_info Where type='" + v_neck + "' and status='" + status + "'", conn);
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
            else
            {
                Product_Info_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_Info_Load(sender, e);
        }
    }
}
