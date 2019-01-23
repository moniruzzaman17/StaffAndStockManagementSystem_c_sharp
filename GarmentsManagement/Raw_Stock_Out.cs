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
    public partial class Raw_Stock_Out : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string status = "available";
        string m_status = "manufactured";
        public Raw_Stock_Out()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Raw_Stock_Out_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";

            textBox_date.Text = "";
            textBox_name.Text = "";
            textBox_quantity.Text = "";
            textBox_code.Text = "";

            //code for showing data to data gridview
            conn.Open();
            try
            {
                OleDbCommand cmd3 = new OleDbCommand("Select [stock_out_date], [Item_Name], [Item_Code], [Quantity], [Price], [Location], [stock_status] from raw_materials_purchase where stock_status='" + m_status + "'", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                DataTable dt;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //code for total quantity of yarn
            try
            {
                string yarn = "Yarn";

                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + yarn + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_yarn_quantity.Text = dr["TotalCount"].ToString() + " Ton";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            



            //code for total cost of yarn
            try
            {
                string yearn = "Yarn";
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + yearn + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_yarn_cost.Text = dr["TotalCount"].ToString() + " $";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //code for total quantity of Dyes
            try
            {
                string dyes = "Dyes";
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + dyes + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_dyes_quantity.Text = dr["TotalCount"].ToString() + " Ton";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //code for total cost of Dyes
            try
            {
                string dyes = "Dyes";
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + dyes + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_dyes_cost.Text = dr["TotalCount"].ToString() + " $";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            




            //code for total quantity of Chemical & Auxilaries
            try
            {
                string chemical = "Chemical and Auxiliaries";
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + chemical + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_chemical_quantity.Text = dr["TotalCount"].ToString() + " Ton";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //code for total cost of Chemical & Auxilaries
            try
            {
                string chemical = "Chemical and Auxiliaries";
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + chemical + "' and stock_status='" + m_status + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    textBox_chemical_cost.Text = dr["TotalCount"].ToString() + " $";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void textBox_code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from raw_materials_purchase where Item_Code='" + textBox_code.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_code_com.Text = "";
                    textBox_name.Text = (dr["Item_Name"].ToString());
                    textBox_quantity.Text = (dr["Quantity"].ToString());
                }
                else
                {
                    label_code_com.Text = "Raw Item Code doesn't Match";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label_code_com.Text != "" || textBox_quantity.Text == "" || textBox_date.Text == "")
            {
                MessageBox.Show("Item Code, Date and Quantity can not be Empty");
            }
            else
            {
                //Code for check product id is available for export or not
                try
                {
                    conn.Open();
                    OleDbDataReader rd = null;
                    OleDbCommand cmd_check = new OleDbCommand("select * from raw_materials_purchase where Item_Code='" + textBox_code.Text + "' and stock_status='" + status + "'", conn);
                    rd = cmd_check.ExecuteReader();
                    if (rd.Read())
                    {
                        //Code for update the export status and exported organization
                        try
                        {
                            OleDbCommand cmd2 = new OleDbCommand("update raw_materials_purchase set stock_status= '" + textBox_status.Text + "', stock_out_date=#" + textBox_date.Text + "# where Item_Code='" + textBox_code.Text + "'", conn);
                            OleDbDataReader dr2 = cmd2.ExecuteReader();
                            if (dr2.Read())
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            conn.Close();
                            Raw_Stock_Out_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR!! " + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, This Raw Item Code is already gone for Manufacturing");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox_date.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
