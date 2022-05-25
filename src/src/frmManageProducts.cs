using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace src
{
    public partial class frmManageProducts : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public frmManageProducts()
        {
            InitializeComponent();
        }

        private void frmManageGoods_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConn);
            //con.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog='SE_lab_02';Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
