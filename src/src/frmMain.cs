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
    public partial class frmMain : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public frmMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiveNote receiveNote = new frmReceiveNote();
            receiveNote.ShowDialog();
        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outcomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageProducts mngProducts = new frmManageProducts();
            mngProducts.ShowDialog();
        }
    }
}
