using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon_v1._0_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.ShowDialog();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
