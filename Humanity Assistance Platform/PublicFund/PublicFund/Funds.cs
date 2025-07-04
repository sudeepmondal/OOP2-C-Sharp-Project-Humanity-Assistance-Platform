using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class Funds : Form
    {
        function fn = new function();
        public Funds()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT SUM(Amount) AS [Total Fund] FROM DONATION";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Text = "Event ID:";
            txtForID.Visible = true;
            txtID.Visible = true;
            btnSearch.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Text = "Event ID:";
            txtForID.Visible = true;
            txtID.Visible = true;
            btnSearch.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Text = "Event ID:";
            txtForID.Visible = true;
            txtID.Visible = true;
            btnSearch.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT eID AS [Event ID], sID AS [Sponsor ID] FROM DONATION";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT MAX(Amount) AS [Highest Amount], sID AS [Sponsor ID] FROM DONATION GROUP BY sID";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                //Int64 id = Int64.Parse(txtID.Text.ToString());
                string query = "select * from DONATION where eID LIKE '" + txtID.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton3.Checked == true)
            {
                //Int64 id = Int64.Parse(txtID.Text.ToString());
                string query = "select SUM(Amount) AS [Total Fund] from DONATION where eID LIKE '" + txtID.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton4.Checked == true)
            {
                //Int64 id = Int64.Parse(txtID.Text.ToString());
                string query = "select MAX(Amount) AS [Highest Amount] from DONATION where eID LIKE '" + txtID.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT * FROM DONATION";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT SUM(Amount) AS [Total Amount], sID AS [Sponsor ID] FROM DONATION GROUP BY sID";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            
            string query = "SELECT TOP 1 SUM(Amount) AS [Highest Amount], sID AS [Sponsor ID] FROM DONATION GROUP BY sID ORDER BY SUM(Amount) DESC";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void Funds_Load(object sender, EventArgs e)
        {

        }
    }
}
