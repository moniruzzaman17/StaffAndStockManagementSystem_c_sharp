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
    public partial class Attendance : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Attendance()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            textBox_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox_time.Text = DateTime.Now.ToString("h:mm:ss tt");

            textBox_id.Text = "";
            textBox_name.Text = "";
            textBox_status.Text = "";

            label_id_com.Visible = false;
            label_comment.Visible = false;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader rd = null;
                OleDbCommand cm = new OleDbCommand("select * from employee_info Where employee_id='" + textBox_id.Text + "'", conn);

                conn.Open();
                rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    textBox_name.Text = (rd["name"].ToString());

                    if (System.DateTime.Now.Hour < 8)
                    {
                        textBox_status.Text = "On Time";
                    }
                    else
                    {

                        textBox_status.Text = "Late";

                    }
                    conn.Close();

                    label_comment.Visible = true;
                    if (label_comment.Visible==true)
                    {
                        OleDbDataReader rd2 = null;
                        OleDbCommand cm2 = new OleDbCommand("select * from attendance Where em_id='" + textBox_id.Text + "'and em_date=#" + DateTime.Now.ToString("MM/dd/yyyy") + "#", conn);

                        conn.Open();
                        rd2 = cm2.ExecuteReader();
                        if (rd2.HasRows)
                        {
                            var w = new Form() { Size = new Size(0, 0) };
                            Task.Delay(TimeSpan.FromSeconds(2))
                                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                            MessageBox.Show(w, "Attendance for this ID already taken for Today", "Warning");
                        }
                        else
                        {
                            OleDbCommand cmd3 = new OleDbCommand("insert into attendance(em_date, em_time, em_id, em_name, status) values(#" + DateTime.Now.ToString("MM/dd/yyyy") + "#,'" + textBox_time.Text + "','" + textBox_id.Text + "','" + textBox_name.Text + "','" + textBox_status.Text + "')", conn);
                            cmd3.ExecuteNonQuery();

                            var w = new Form() { Size = new Size(0, 0) };
                            Task.Delay(TimeSpan.FromSeconds(2))
                                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                            MessageBox.Show(w, "Attendance Successfully taken for this ID", "Message");

                        }
                        conn.Close();
                        Attendance_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex + "ERROR");
            }
            conn.Close();
        }
    }
}
