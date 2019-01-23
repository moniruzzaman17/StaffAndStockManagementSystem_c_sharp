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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Info ei = new Employee_Info();
            ei.MdiParent = this;
            ei.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration ar = new Registration();
            ar.MdiParent = this;
            ar.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Develper ad = new About_Develper();
            ad.Show();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance a = new Attendance();
            a.MdiParent = this;
            a.Show();
        }

        private void attendanceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendance_info ai = new attendance_info();
            ai.MdiParent = this;
            ai.Show();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_info pi = new Personal_info();
            pi.MdiParent = this;
            pi.Show();
        }

        private void purchesRowMeterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Materials_Purchase rmp = new Raw_Materials_Purchase();
            rmp.MdiParent = this;
            rmp.Show();
        }

        private void rawMeterialStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock_Info rst = new Raw_Stock_Info();
            rst.MdiParent = this;
            rst.Show();
        }

        private void storeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Info_Insert pii = new Product_Info_Insert();
            pii.MdiParent = this;
            pii.Show();
        }

        private void stockInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Info pi = new Product_Info();
            pi.MdiParent = this;
            pi.Show();
        }

        private void manageExportProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Product mp = new Manage_Product();
            mp.MdiParent = this;
            mp.Show();
        }

        private void exportProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Info ei = new Export_Info();
            ei.MdiParent = this;
            ei.Show();
        }

        private void stockOutForManufacturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock_Out rso = new Raw_Stock_Out();
            rso.MdiParent = this;
            rso.Show();
        }

        private void manageStockOutMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Raw_Materials mrm = new Manage_Raw_Materials();
            mrm.MdiParent = this;
            mrm.Show();
        }

        private void rawStockInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock_Out rso = new Raw_Stock_Out();
            rso.MdiParent = this;
            rso.Show();
        }
    }
}
