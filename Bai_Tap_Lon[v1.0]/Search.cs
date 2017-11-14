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
    public partial class Search : Form
    {
        String sCnnStr = ConfigurationManager.ConnectionStrings["myCnnStr"].ConnectionString;
        


        public Search()
        {
            InitializeComponent();



            listBox1.Visible = false;
         }

        private void loadAutoText()
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteCustomSource = acsc;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            String sSQL_searchByName = "sp_searchByName";
            DataTable dt = new DataTable();
            String name = txtSearch.Text;
            try
            {
                using(SqlConnection cn = new SqlConnection(sCnnStr))
                {
                    cn.Open();
                    using(SqlCommand cm = new SqlCommand(sSQL_searchByName, cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@search", name);

                        dt.Load(cm.ExecuteReader());
                        
                        foreach(DataRow dr in dt.Rows)
                        {
                            acsc.Add(string.Join(";", dr.ItemArray.Select(item => item.ToString())));
                           
                        }
                        cn.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

      
       
       

        void listBox1_LostFocus(object sender, System.EventArgs e)
        {
            hideResults();
        }

        private void hideResults()
        {
            listBox1.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadAutoText();
            listBox1.Items.Clear();

            if (txtSearch.Text.Length == 0)
            {
                hideResults();
                return;
            }

            foreach (String s in txtSearch.AutoCompleteCustomSource)
            {
                if (s.Contains(txtSearch.Text))
                {
                    listBox1.Items.Add(s);
                    listBox1.Visible = true;
                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSearch.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            hideResults();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView_LoadData();
            hideResults();
        }

        private void dataGridView_LoadData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = getData(txtSearch.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private DataTable getData(String s)
        {
            DataTable dt = new DataTable();
            String sSQL_getDataByName = "sp_search";
            try
            {
                using(SqlConnection cn = new SqlConnection(sCnnStr))
                {
                    using(SqlCommand cm = new SqlCommand(sSQL_getDataByName, cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.AddWithValue("@search", s);

                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            //MessageBox.Show("hi");
                            return dt;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            return null;
        }
    }
}
