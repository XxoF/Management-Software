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
        SqlDataReader MyReader;

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

            /*
            int id = Int32.Parse(textBox2.Text);
            string name = textBox1.Text;
            int price = Int32.Parse(textBox3.Text);
            int quantity = Int32.Parse(textBox4.Text);
            */
            if ((textBox1.Text != "") && (textBox2.Text != "") &&
                (textBox3.Text != "") && (textBox4.Text != ""))
            {
                ListViewItem item = new ListViewItem(textBox2.Text);
                item.SubItems.Add(textBox1.Text);
                item.SubItems.Add(textBox3.Text);
                item.SubItems.Add(textBox4.Text);

                listView1.Items.Add(item);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Missing some value");
            }
           

            /* 
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
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConn);
            con.Open();


            /********* Create new Receive Note and update to database *********/
            // Get new Note ID
            String getIDcommand = "SELECT MAX(ID) FROM tblReceiveNote";
            SqlCommand cmd = new SqlCommand(getIDcommand, con);

            var dr = cmd.ExecuteScalar();
            int receiveID = 0;

            if (dr.ToString() != "") 
                receiveID = Int32.Parse(dr.ToString()) + 1;


            // Create new Receive Note
            DateTime datenow = DateTime.Now;
            string localDate = datenow.ToString("yyyy/MM/dd HH:MM:ss");

            String newReceivecommand = "Insert Into[tblReceiveNote] VALUES(" + receiveID + 
                ",'" + localDate + "');";


            // Update receive note to database
            SqlCommand cmd2 = new SqlCommand(newReceivecommand, con);
            try
            {
                MyReader = cmd2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show(newReceivecommand);
                MessageBox.Show("Save Received Note");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MyReader.Close();



            /********** Update new Receive Product **********/

            foreach (ListViewItem item in listView1.Items)
            {
                string ID = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                string price = item.SubItems[2].Text;
                string quantity = item.SubItems[3].Text;
                //int price = Int32.Parse(item.SubItems[2].Text);
                //int quantity = Int32.Parse(item.SubItems[3].Text);

                //MessageBox.Show(ID + " " + name + " " + price.ToString() + " " + quantity.ToString());
                String updateReceiveProductCMD = "Insert Into[tblReceiveProduct] VALUES("
                    + receiveID + ", '" + ID + "'," + price + "," + quantity + ")";

                // Update receive note to database
                SqlCommand cmd3 = new SqlCommand(updateReceiveProductCMD, con);
                try
                {
                    MessageBox.Show(updateReceiveProductCMD);
                    MyReader = cmd3.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("Saved + product: " + name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Check item: " + updateReceiveProductCMD);
                }

                MyReader.Close();
            }



            /*
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


                MessageBox.Show("Added items: " + id.ToString() + "," + name +
                    "," + price.ToString() + "," + quantity.ToString());
            }

            con.Close();
            */
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
