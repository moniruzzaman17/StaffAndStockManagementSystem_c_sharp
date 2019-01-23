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
    public partial class Personal_info : Form
    {
        public string e_salary;
        OleDbConnection conn = new OleDbConnection();

        public Personal_info()
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StockManagement.accdb;";
            InitializeComponent();
        }

        private void Personal_info_Load(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            dateTimePicker_from.Visible = false;
            dateTimePicker_to.Visible = false;
            button_view.Visible = false;
            label_id_com.Visible = false;

            dateTimePicker_from.CustomFormat = "dd-MM-yyyy";
            dateTimePicker_to.CustomFormat = "dd-MM-yyyy";
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from employee_info where employee_id='" + textBox_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_id_com.Visible = false;
                    dateTimePicker_from.Visible = true;
                    dateTimePicker_to.Visible = true;
                    button_view.Visible = true;
                }
                else
                {
                    label_id_com.Visible = true;
                    label_id_com.Text = "Your input ID not matched with registred ID";
                }
            }
            catch (Exception ex)
            {
                label_id_com.Visible = true;
                label_id_com.Text = "Something went Wrong";
            }
            conn.Close();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if(label_id_com.Visible==true)
            {
                MessageBox.Show("Something went wrong with input ID, Please check agein", "Warning");
            }
            else if(textBox_holiday.Text=="" || textBox_holiday.BackColor==Color.Red)
            {
                MessageBox.Show("Sorry You cann't leave Authorized holiday field", "Warning");
            }
            else
            {
                try
                {
                    conn.Open();
                    OleDbDataReader dr = null;
                    OleDbCommand cmd = new OleDbCommand("select * from employee_info Where employee_id='" + textBox_id.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        label_name.Text = (dr["name"].ToString());
                        label_type.Text = (dr["em_type"].ToString());
                        label_age.Text = (dr["age"].ToString());
                        label_email.Text = (dr["email"].ToString());
                        label_mobile.Text = (dr["mobile"].ToString());
                        label_address.Text = (dr["address"].ToString());
                        e_salary = (dr["salary"].ToString());
                        label_gender.Text = (dr["gender"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();

                DateTime a, b;

                try
                {
                    a = Convert.ToDateTime(dateTimePicker_from.Value);
                    b = Convert.ToDateTime(dateTimePicker_to.Value);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("select [em_name], [em_date], [em_time], [status] from attendance Where em_id='" + textBox_id.Text+"' AND em_date between #" + a + "# AND #" + b + "#", conn);
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

                try
                {
                    string status_late = "Late";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from attendance Where em_id='" + textBox_id.Text + "'AND status='" + status_late + "' AND em_date between #" + dateTimePicker_from.Value + "# AND #" + dateTimePicker_to.Value + "#", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_late.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {
                    string status_onTime = "On Time";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Select count(*) from attendance Where em_id='" + textBox_id.Text + "'AND status='" + status_onTime + "' AND em_date between #" + dateTimePicker_from.Value + "# AND #" + dateTimePicker_to.Value + "#", conn);
                    OleDbDataReader row_reader = cmd.ExecuteReader();
                    while (row_reader.Read())
                    {
                        label_onTime.Text = row_reader.GetInt32(0).ToString();
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



                //total working day count from between to date
                int t_days =Convert.ToInt16((dateTimePicker_to.Value - dateTimePicker_from.Value).TotalDays+1);
                int holiday = Convert.ToInt32(textBox_holiday.Text);
                int total_days = t_days - holiday;
                label_working.Text = total_days.ToString();

                label_present.Text = (dataGridView1.RowCount-1).ToString();

                int salary = Convert.ToInt32(e_salary);
                int per = salary / 30;
                int total = Convert.ToInt32(label_working.Text);
                int present = Convert.ToInt32(label_present.Text);
                int absent = (total - present);
                int late = Convert.ToInt32(label_late.Text);
                int l;
                int total_absent;

                if (total == present && late < 3) 
                {
                    label_salary.Text = salary.ToString();
                    label_absent.Text = absent.ToString();
                }
                else if (late >= 3)  
                {
                    l = late /3;
                    total_absent = absent + l;
                    label_absent.Text = total_absent.ToString();
                    int cost_cut = total_absent * per;
                    int final_salary = salary - cost_cut;
                    label_salary.Text = final_salary.ToString();
                }
                else
                {
                    label_salary.Text = salary.ToString();
                    label_absent.Text = absent.ToString();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Radial Internation Ltd.", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(350, 100));
            e.Graphics.DrawString("Address: Zirani Bazar, A1001", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(325, 135));
            Image i = pictureBox1.Image;
            e.Graphics.DrawImage(i, 225, 85, 100, 100);


            e.Graphics.DrawString("Name: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(10, 200));
            e.Graphics.DrawString(label_name.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(105, 200));

            e.Graphics.DrawString("Designation: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(10, 220));
            e.Graphics.DrawString(label_type.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(105, 220));

            e.Graphics.DrawString("Email: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(10, 240));
            e.Graphics.DrawString(label_email.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(105, 240));

            e.Graphics.DrawString("Cell: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(10, 260));
            e.Graphics.DrawString(label_mobile.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(105, 260));



            e.Graphics.DrawString("Gender: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(355, 200));
            e.Graphics.DrawString(label_gender.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(455, 200));

            e.Graphics.DrawString("Age: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(355, 220));
            e.Graphics.DrawString(label_age.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(455, 220));

            e.Graphics.DrawString("Address: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(355, 240));
            e.Graphics.DrawString(label_address.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(455, 240));

            e.Graphics.DrawString("Salary: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(355, 260));
            e.Graphics.DrawString(label_salary.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(455, 260));




            e.Graphics.DrawString("Working Day: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(620, 190));
            e.Graphics.DrawString(label_working.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 190));

            e.Graphics.DrawString("Present: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(620, 210));
            e.Graphics.DrawString(label_present.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 210));

            e.Graphics.DrawString("Absent: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(620, 230));
            e.Graphics.DrawString(label_absent.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 230));

            e.Graphics.DrawString("On Time: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(620, 250));
            e.Graphics.DrawString(label_onTime.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 250));

            e.Graphics.DrawString("Late: ", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(620, 270));
            e.Graphics.DrawString(label_late.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(770, 270));



            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(50, 50, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 00, 300);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label_name.Text != "" || label_type.Text != "" || label_email.Text != "")
            {
                //Open the print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;
                printDialog.UseEXDialog = true;
                //Get the document
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDocument1.DocumentName = "Personal Information";
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("There are no available information for printing out!");
            }
        }

        private void textBox_holiday_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox_holiday.Text, "^[0-9]*$").Success)
            {
                textBox_holiday.BackColor = Color.Red;
            }
            else if (textBox_holiday.Text=="")
            {
                textBox_holiday.BackColor = Color.Red;
            }
            else
            {
                textBox_holiday.BackColor = Color.WhiteSmoke;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal_info_Load(sender, e);
        }
    }
}
