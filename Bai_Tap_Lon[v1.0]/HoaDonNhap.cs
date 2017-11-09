using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Bai_Tap_Lon_v1._0_
{
    public partial class HoaDonNhap : Form
    {
        String sCnnStr = ConfigurationManager.ConnectionStrings["myCnnStr"].ConnectionString;
        Boolean isActive;


        //TODO: crystal report -> lam phan IN HOA DON -> subcrystal tim hieu

        public HoaDonNhap()
        {
            InitializeComponent();
            loadCbb();
            disableEdit();
            isActive = true;

            
        }

        private void dataGridView_loadData()
        {
            try
            {
                dataGridView1.DataSource = getData(Int32.Parse(cbbHoaDon.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private DataTable getData(int iSoHD)
        {
            DataTable dt = new DataTable();
            String sSQL_getIsoHD = "sp_getHDXbyID";
            try
            {
                using(SqlConnection cn = new SqlConnection(sCnnStr))
                {
                    using(SqlCommand cm = new SqlCommand(sSQL_getIsoHD,cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.AddWithValue("@iSoHD", iSoHD);
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            return dt;
                        }
                      
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            return null;
        }

       

        public void loadCbb()
        {
            String sSQL_getIsoHD = "sp_getIsoHD";

            try
            {
                using (SqlConnection cn = new SqlConnection(sCnnStr)) 
                {
                    using (SqlCommand cm = new SqlCommand(sSQL_getIsoHD, cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if(dt.Rows.Count > 0)
                            {
                                cbbHoaDon.DataSource = dt;
                                cbbHoaDon.DisplayMember = "iSoHD";
                                cbbHoaDon.ValueMember = "iSoHD";
                                
                                
                                
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        public void initText()
        {
            String sSQL_getInfoBySHD = "sp_getHDXbyID";

            try
            {
                using(SqlConnection cn = new SqlConnection(sCnnStr))
                {
                    cn.Open();
                    using(SqlCommand cm = new SqlCommand(sSQL_getInfoBySHD, cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.AddWithValue("@iSoHD", Int32.Parse(cbbHoaDon.SelectedValue.ToString()));

                        using (SqlDataReader reader = cm.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    txtMaNV.Text = reader[1].ToString();
                                    txtMaSach.Text = reader[4].ToString();
                                    mtxtNgayNhap.Text = reader[2].ToString();
                                    txtGianhap.Text = reader[5].ToString();
                                    txtSoluong.Text = reader[6].ToString();
                               
                                }
                                cn.Close();
                            }
                        }
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void disableEdit()
        {
            txtMaNV.Enabled = false;
            txtMaSach.Enabled = false;
            txtSoluong.Enabled = false;
            txtGianhap.Enabled = false;
            mtxtNgayNhap.Enabled = false;
        }

        public void enableEdit()
        {
            txtMaNV.Enabled = true;
            txtMaSach.Enabled = true;
            txtSoluong.Enabled = true;
            txtGianhap.Enabled = true;
            mtxtNgayNhap.Enabled = true;
        }

        public void clearEdit()
        {
            txtMaNV.Clear();
            txtMaSach.Clear();
            txtSoluong.Clear();
            txtGianhap.Clear();
            mtxtNgayNhap.Clear();
        }


        private void btnEDIT_Click(object sender, EventArgs e)
        {
            String sSQL_UpdateHDXbyID = "sp_updateHDXbyID";

            String iMaNV = txtMaNV.Text;
            String dNgaynhap = mtxtNgayNhap.Text;
            String sMasach = txtMaSach.Text;
            float fGianhap = float.Parse(txtGianhap.Text);
            float fSoluongnhap = float.Parse(txtSoluong.Text);

            if (isActive)
            {
                btnEDIT.Text = "UPDATE";
                isActive = false;
                enableEdit();

            }
            else
            {
                btnEDIT.Text = "EDIT";
                isActive = true;
                disableEdit();

                try
                {
                    using(SqlConnection cn = new SqlConnection(sCnnStr))
                    {
                        cn.Open();
                        using(SqlCommand cm = new SqlCommand(sSQL_UpdateHDXbyID, cn))
                        {
                            cm.CommandType = CommandType.StoredProcedure;

                            cm.Parameters.AddWithValue("@iSoHD1", Int32.Parse(cbbHoaDon.SelectedValue.ToString()));
                            cm.Parameters.AddWithValue("@iSoHD2", Int32.Parse(cbbHoaDon.SelectedValue.ToString()));
                            cm.Parameters.AddWithValue("@iMaNV", iMaNV);
                            cm.Parameters.AddWithValue("@dNgaynhapsach", dNgaynhap);
                            cm.Parameters.AddWithValue("@sMasach", sMasach);
                            cm.Parameters.AddWithValue("@fGianhap", fGianhap);
                            cm.Parameters.AddWithValue("@fSoluongnhap", fSoluongnhap);

                            int check = cm.ExecuteNonQuery();

                            if(check != 0)
                            {
                                MessageBox.Show("Updated Successfully");
                                cn.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }



                }catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            initText();
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            dataGridView_loadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInHoaDon frmInHoaDon = new frmInHoaDon(cbbHoaDon.Text);
            //getcbbHoaDon();
            frmInHoaDon.ShowDialog();
        }
       

        public int getcbbHoaDon()
        {
            return Int32.Parse(cbbHoaDon.SelectedValue.ToString());
        }
    }
}
