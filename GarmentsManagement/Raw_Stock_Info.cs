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
    public partial class Raw_Stock_Info : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string status = "available";
        public Raw_Stock_Info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Raw_Stock_Info_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;

            //code for total quantity of yarn
            try
            {
                string yarn = "Yarn";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + yarn + "' and stock_status='" + status + "'", conn);
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
            conn.Close();



            //code for total cost of yarn
            try
            {
                string yearn = "Yarn";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + yearn + "' and stock_status='" + status + "'", conn);
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
            conn.Close();



            //code for total quantity of Dyes
            try
            {
                string dyes = "Dyes";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + dyes + "' and stock_status='" + status + "'", conn);
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
            conn.Close();



            //code for total cost of Dyes
            try
            {
                string dyes = "Dyes";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + dyes + "' and stock_status='" + status + "'", conn);
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
            conn.Close();




            //code for total quantity of Chemical & Auxilaries
            try
            {
                string chemical = "Chemical and Auxiliaries";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where Item_Name='" + chemical + "' and stock_status='" + status + "'", conn);
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
            conn.Close();



            //code for total cost of Chemical & Auxilaries
            try
            {
                string chemical = "Chemical and Auxiliaries";
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Price) AS TotalCount from raw_materials_purchase where Item_Name='" + chemical + "' and stock_status='" + status + "'", conn);
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
    }
}
