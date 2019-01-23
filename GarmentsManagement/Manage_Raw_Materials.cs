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
    public partial class Manage_Raw_Materials : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string status = "manufactured";
        public string total_out_item;
        public Manage_Raw_Materials()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Manage_Raw_Materials_Load(object sender, EventArgs e)
        {
            dateTimePicker_from.CustomFormat = "MM-dd-yyyy";
            dateTimePicker_to.CustomFormat = "MM-dd-yyyy";
            button_print.Enabled = false;
            button_delete.Enabled = false;


            this.ActiveControl = panel1;



            //code for total quantity of all item
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select SUM(Quantity) AS TotalCount from raw_materials_purchase where stock_out_date between #" + dateTimePicker_from.Value.ToShortDateString() + "# AND #" + dateTimePicker_to.Value.ToShortDateString() + "#", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Get the Sum of Column from Database
                    total_out_item = dr["TotalCount"].ToString() + "     Ton";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();





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
                    label_yarn.Text = dr["TotalCount"].ToString() + "     Ton";
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
                    label_dyes.Text = dr["TotalCount"].ToString() + "     Ton";
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
                    label_chemical.Text = dr["TotalCount"].ToString() + "     Ton";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();





            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select [stock_out_date], [Item_Name], [Item_Code], [Quantity], [stock_status] from raw_materials_purchase Where stock_status='" + status + "'", conn);
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

        }

        private void button_view_Click(object sender, EventArgs e)
        {

            DialogResult msg = MessageBox.Show("Are You Sure want to delete information?","Important Question", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("delete from raw_materials_purchase Where stock_status='" + status + "' AND stock_out_date between #" + dateTimePicker_from.Value.ToShortDateString() + "# AND #" + dateTimePicker_to.Value.ToShortDateString() + "#", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfull");
                    conn.Close();
                    Manage_Raw_Materials_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!! " + ex);
                }
            }
            else if(msg == DialogResult.No)
            {
                return;
            }
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select [stock_out_date], [Item_Name], [Item_Code], [Quantity], [stock_status] from raw_materials_purchase Where stock_out_date between #" + dateTimePicker_from.Value.ToShortDateString() + "# AND #" + dateTimePicker_to.Value.ToShortDateString() + "#", conn);
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button_print.Enabled = true;
                button_delete.Enabled = false;
            }
            else
            {
                button_print.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button_delete.Enabled = true;
                button_print.Enabled = false;
            }
            else
            {
                button_delete.Enabled = false;
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Stored out Raw Materials";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Radial Internation Ltd.", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(350, 100));
            e.Graphics.DrawString("Address: Zirani Bazar, A1001", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(325, 135));
            e.Graphics.DrawString("Total amount of stored out Item: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(340, 175));
            e.Graphics.DrawString(total_out_item, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(590, 175));
            Image i = pictureBox1.Image;
            e.Graphics.DrawImage(i, 225, 85, 100, 100);

            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(50, 50, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 10, 230);
        }
    }
}
