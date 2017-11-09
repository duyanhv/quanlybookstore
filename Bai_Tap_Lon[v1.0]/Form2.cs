using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon_v1._0_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String sCnnStr = ConfigurationManager.ConnectionStrings["myCnnStr"].ConnectionString;
            String sSQL_getIsoHD = "sp_getIsoHD";
            CrystalReport1 cr1 = new CrystalReport1();
            

            try
            {
                using (SqlConnection cn = new SqlConnection(sCnnStr))
                {
                    //cn.Open();
                    using (SqlCommand cm = new SqlCommand(sSQL_getIsoHD, cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                    
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            crystalReportViewer1.ReportSource = cr1;
                            //reportViewer.Refresh();
                            crystalReportViewer1.Show();
                            //crystalReportViewer1.Refresh();
                        }
                    }




                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
