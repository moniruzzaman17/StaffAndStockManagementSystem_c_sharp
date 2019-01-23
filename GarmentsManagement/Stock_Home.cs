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
    public partial class Stock_Home : Form
    {
        public Stock_Home()
        {
            InitializeComponent();
        }

        private void purchaseRowMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Materials_Purchase rmp = new Raw_Materials_Purchase();
            rmp.MdiParent = this;
            rmp.Show();
        }

        private void rawMaterialStockToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exportProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Info ei = new Export_Info();
            ei.MdiParent = this;
            ei.Show();
        }

        private void manageExportedProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Product mp = new Manage_Product();
            mp.MdiParent = this;
            mp.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Develper ad = new About_Develper();
            ad.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }

        private void rawStockOutInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock_Out rso = new Raw_Stock_Out();
            rso.MdiParent = this;
            rso.Show();
        }

        private void stockOutForManufacturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raw_Stock_Out rso = new Raw_Stock_Out();
            rso.MdiParent = this;
            rso.Show();
        }
    }
}
