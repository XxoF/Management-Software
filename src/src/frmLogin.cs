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
    public partial class frmLogin : Form
    {

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConn);
            con.Open();
            string userid = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select userid,password from tblUsers where " +
            "userid = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login success. Welcome!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Wrong username or password!");
            }
            con.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to exit the app");
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
