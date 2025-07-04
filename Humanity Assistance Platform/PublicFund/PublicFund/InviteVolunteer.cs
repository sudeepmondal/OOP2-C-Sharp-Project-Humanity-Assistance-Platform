using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;

namespace PublicFund
{
    public partial class InviteVolunteer : Form
    {
        function fn = new function();
        public InviteVolunteer()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtVID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnSearchEID_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtSearchEID.Text.ToString());
            string qurey = "SELECT * FROM Event WHERE eID = " + id + "";
            DataSet ds = fn.getData(qurey);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InviteVolunteer_Load(object sender, EventArgs e)
        {
            string qurey1 = "SELECT * FROM EVENT";
            DataSet ds1 = fn.getData(qurey1);
            dataGridView1.DataSource = ds1.Tables[0];

            string query2 = "SELECT * FROM VOLUNTEER";
            DataSet ds2 = fn.getData(query2);
            dataGridView2.DataSource = ds2.Tables[0];

            string query3 = "SELECT * FROM EVENT_MANAGEMENT";
            DataSet ds3 = fn.getData(query3);
            dataGridView3.DataSource = ds3.Tables[0];
        }

        private void btnSearchArea_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM VOLUNTEER WHERE AREA LIKE '"+txtSearchArea.Text+"%' OR CITY LIKE '"+txtSearchArea.Text+"%'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("NO Data Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtEID.Text != "" && txtVID.Text != "")
            {
                string query = "INSERT INTO EVENT_MANAGEMENT (eID,vID) VALUES ('" + txtEID.Text + "','" + txtVID.Text + "')";
                fn.setData(query);
                txtEID.Clear();
                txtVID.Clear();
            }
            else
            {
                MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEID.Clear();
            txtVID.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
