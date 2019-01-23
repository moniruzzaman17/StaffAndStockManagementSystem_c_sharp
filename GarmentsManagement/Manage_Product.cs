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
    public partial class Manage_Product : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string available_status = "available";
        string export_status = "exported";
        public Manage_Product()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Manage_Product_Load(object sender, EventArgs e)
        {
            try
            {
                string status = "exported";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select [product_name], [type], [product_code], [exporting_date], [exporting_date], [sleeves], [size], [status] from product_info Where status='" + status + "'", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            this.ActiveControl = panel1;
            //Code for count total available T-Shirt
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where status='" + available_status + "'", conn);
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


            //Code for count total Exported T-Shirt
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select count(*) from product_info where status='" + export_status + "'", conn);
                OleDbDataReader row_reader = cmd.ExecuteReader();
                while (row_reader.Read())
                {
                    label_exported.Text = row_reader.GetInt32(0).ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are You Sure want to delete information?", "Important Question", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    string status = "exported";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("delete from product_info Where status='" + status + "' AND exporting_date between #" + dateTimePicker_from.Value.ToShortDateString() + "# AND #" + dateTimePicker_to.Value.ToShortDateString() + "#", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfull");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else if (msg == DialogResult.No)
            {
                return;
            }
        }
    }
}
