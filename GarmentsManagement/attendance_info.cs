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
    public partial class attendance_info : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public attendance_info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void attendance_info_Load(object sender, EventArgs e)
        {

            checkBox1_CheckedChanged(sender, e);
            //dateTimePicker_from.CustomFormat = "dd-MM-yyyy";
            //dateTimePicker_to.CustomFormat = "dd-MM-yyyy";
            textBox_date.Text = DateTime.Now.ToString("MM/dd/yyyy");

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select [em_name], [em_id], [em_date], [em_time], [status] from attendance where em_date= #" + textBox_date.Text + "#", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            conn.Close();


            try
            {
                conn.Open();
                OleDbCommand cmd2 = new OleDbCommand("Select [em_name], [em_id], [em_date], [em_time], [status] from attendance where em_date", conn);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                DataTable scores2 = new DataTable();
                da2.Fill(scores2);
                dataGridView2.DataSource = scores2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select count(*) from employee_info", conn);
                OleDbDataReader row_reader = cmd.ExecuteReader();
                while (row_reader.Read())
                {
                    textBox_total.Text = row_reader.GetInt32(0).ToString();
                    textBox_2_total.Text= row_reader.GetInt32(0).ToString();
                }

                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            textBox_present.Text = (dataGridView1.RowCount-1).ToString();

            int total = Convert.ToInt32(textBox_total.Text);
            int present = Convert.ToInt32(textBox_present.Text);
            int absent = total - present;

            textBox_absent.Text = absent.ToString();
        }

        private void button_view_Click(object sender, EventArgs e)
        {

            DialogResult msg = MessageBox.Show("Are You Sure want to delete information?", "Important Question", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Delete from attendance Where em_date between #" + dateTimePicker_from.Value + "# AND #" + dateTimePicker_to.Value + "#", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance information of selecting days Deleted Successfull");

                    conn.Close();
                    attendance_info_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else if (msg == DialogResult.No)
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                label8.Visible = true;
                label7.Visible = true;
                dateTimePicker_from.Visible = true;
                dateTimePicker_to.Visible = true;
                button_view.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label7.Visible = false;
                dateTimePicker_from.Visible = false;
                dateTimePicker_to.Visible = false;
                button_view.Visible = false;
            }
        }
    }
}
