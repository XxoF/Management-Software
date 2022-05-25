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
    public partial class frmReceiveNote : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        List<int> idList = new List<int>();
        List<string> nameList = new List<string>();
        List<int> priceList = new List<int>();
        List<int> quantityList = new List<int>();


        public frmReceiveNote()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceiveNote_Load(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int id = Int32.Parse(textBox2.Text);
            string name = textBox1.Text;
            int price = Int32.Parse(textBox3.Text);
            int quantity = Int32.Parse(textBox4.Text);

            try {
                idList.Add(id);
                nameList.Add(name);
                priceList.Add(price);
                quantityList.Add(quantity);

                MessageBox.Show("Added to Note");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConn);
            con.Open();

            // Get new Note ID
            String getIDcommand = "SELECT MAX(ID) FROM tblReceiveNote";
            SqlCommand cmd = new SqlCommand(getIDcommand, con);

            var dr = cmd.ExecuteScalar();
            int receiveID = 0;

            if (dr.ToString() != "") 
                receiveID = Int32.Parse(dr.ToString()) + 1;


            // Create new Receive Note and update to database
            DateTime datenow = DateTime.Now;
            string localDate = datenow.ToString("yyyy/MM/dd HH:MM:ss");

            String updateReceivecommand = "Insert Into[tblReceiveNote] VALUES(" + receiveID + 
                ",'" + localDate + "');";


            SqlCommand cmd2 = new SqlCommand(updateReceivecommand, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            SqlDataReader MyReader;

            try
            {
                MyReader = cmd2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show(updateReceivecommand);
                MessageBox.Show("Save Received Note");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // Update Products to Receive Note
            for (int i = 0; i < idList.Count; i++)
            {
                int id = idList[i];
                string name = nameList[i];
                int price = priceList[i];
                int quantity = quantityList[i];

                /*
                String updateProductCommand = "Insert Into[tblReceiveProduct] VALUES(" 
                    + receiveID + ", " + id + "," + quan
                ",'" + localDate + "');";
                */

                MessageBox.Show("Added items: " + id.ToString() + "," + name +
                    "," + price.ToString() + "," + quantity.ToString());
            }

            con.Close();
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
