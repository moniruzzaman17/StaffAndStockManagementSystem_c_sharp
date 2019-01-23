using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsManagement
{
    public partial class Staff_Home : Form
    {
        public Staff_Home()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.MdiParent = this;
            r.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance a = new Attendance();
            a.MdiParent = this;
            a.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Develper ad = new About_Develper();
            ad.MdiParent = this;
            ad.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Form1 f = new Form1();
            f.Show();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_info pi = new Personal_info();
            pi.MdiParent = this;
            pi.Show();
        }

        private void attendanceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendance_info ai = new attendance_info();
            ai.MdiParent = this;
            ai.Show();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_info_Manager eim = new Employee_info_Manager();
            eim.MdiParent = this;
            eim.Show();
        }
    }
}
