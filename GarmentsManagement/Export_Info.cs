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
    public partial class Export_Info : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string available_status = "available";
        string export_status = "exported";
        public Export_Info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Export_Info_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;

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

            dataGridView1.ClearSelection();
            label_ex_date.Text = "";
            label_organization.Text = "";
            label_total_quantity.Text = "";
            label_total_price.Text = "";
            textBox_code.Text = "";
            textBox_or_name.Text = "";
            label_ex_date.Text = "";

            dataGridView1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label_ex_date.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void textBox_code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from product_info where product_code='" + textBox_code.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    button_view.Enabled = true;
                    label_com.Text = "";
                }
                else
                {
                    button_view.Enabled = false;
                    label_com.Text = "Product Code not Match";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if (textBox_or_name.Text != "" || textBox_code.Text != "")
            {
                //Code for check product id is available for export or not
                try
                {
                    conn.Open();
                    OleDbDataReader rd = null;
                    OleDbCommand cmd_check = new OleDbCommand("select * from product_info where product_code='" + textBox_code.Text + "' and status='" + available_status + "'", conn);
                    rd = cmd_check.ExecuteReader();
                    if (rd.Read())
                    {
                        //Code for update the export status and exported organization
                        try
                        {
                            string theDate = dateTimePicker1.Value.ToShortDateString();

                            OleDbCommand cmd2 = new OleDbCommand("update product_info set status= '" + textBox_status.Text + "', exporting_date=#" + theDate + "#, exported_to='" + label_organization.Text + "'where product_code='" + textBox_code.Text + "'", conn);
                            OleDbDataReader dr2 = cmd2.ExecuteReader();
                            if (dr2.Read())
                            {
                                //need to code
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR!! " + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, This Product is not available, it has been already exported");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                //code for showing data to data gridview
                try
                {
                    conn.Open();
                    string Date = dateTimePicker1.Value.ToShortDateString();
                    OleDbCommand cmd3 = new OleDbCommand("select [exporting_date], [exported_to], [type], [product_code], [sleeves], [size], [price] from product_info where exporting_date=#" + Date + "#", conn);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    DataTable dt;
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();


                    //Code for calculate total price from datagrid view cell
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    }
                    label_total_price.Text = sum.ToString() + " $";


                    //Counting total product in datagrid view
                    label_total_quantity.Text = (dataGridView1.RowCount - 1).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Organization Name and Product Code cannot be Empty", "Warning");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Export_Info_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled == true)
            {
                //code for showing data to data gridview
                try
                {
                    conn.Open();
                    string Date = dateTimePicker1.Value.ToShortDateString();
                    OleDbCommand cmd3 = new OleDbCommand("select [exporting_date], [exported_to], [type], [product_code], [sleeves], [size], [price] from product_info where exporting_date=#" + Date + "#", conn);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd3);
                    DataTable dt;
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();

                    //Code for calculate total price from datagrid view cell
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    }
                    label_total_price.Text = sum.ToString() + " $";


                    //Counting total product in datagrid view
                    label_total_quantity.Text = (dataGridView1.RowCount - 1).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!! " + ex);
                }
            }
            else
            {
                MessageBox.Show("Please select the date first", "Warning");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label_ex_date.Text != "" || label_total_quantity.Text != "" || label_total_price.Text != "")
            {
                //Open the print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;
                printDialog.UseEXDialog = true;
                //Get the document
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDocument1.DocumentName = "Export Information";
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("There are no available information for printing out!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Radial Internation Ltd.", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(350, 100));
            e.Graphics.DrawString("Address: Zirani Bazar, A1001", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(325, 135));
            Image i = pictureBox1.Image;
            e.Graphics.DrawImage(i, 225, 85, 100, 100);

            e.Graphics.DrawString("Exported to: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(390, 175));
            e.Graphics.DrawString(label_organization.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(490, 175));


            e.Graphics.DrawString("Exporting Date: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(05, 250));
            e.Graphics.DrawString(label_ex_date.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(150, 250));

            e.Graphics.DrawString("Total Quantity: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(350, 250));
            e.Graphics.DrawString(label_total_quantity.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(485, 250));

            e.Graphics.DrawString("Total Price: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(635, 250));
            e.Graphics.DrawString(label_total_price.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 250));


            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(50, 50, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 40, 300);
        }

        private void textBox_or_name_TextChanged(object sender, EventArgs e)
        {
            label_organization.Text = textBox_or_name.Text;
        }
    }
}
