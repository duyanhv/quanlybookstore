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
    public partial class frmInHoaDon : Form
    {
        private String p;

        public frmInHoaDon(String p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            HoaDonNhap hoa = new HoaDonNhap();

           // var param = hoa.getcbbHoaDon();
            

            frmHoaDon frm = new frmHoaDon();

            frm.SetParameterValue(0, Int32.Parse(p));


            crystalReportViewer1.ReportSource = frm;



            crystalReportViewer1.Refresh();
        }
    }
}
