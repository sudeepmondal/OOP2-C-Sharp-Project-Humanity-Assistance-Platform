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
    public partial class EventManagement : Form
    {
        function fn = new function();
        public EventManagement()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtVID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void EventManagement_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM EVENT_MANAGEMENT";
            DataSet ds1 = fn.getData(query1);
            dataGridView1.DataSource = ds1.Tables[0];

        }

        private void btnSearchEID_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtSearchEID.Text.ToString());
            string qurey = "SELECT * FROM EVENT_MANAGEMENT WHERE eID = " + id + "";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtEID.Text != "" && txtVID.Text != "" && txtStatus.Text != "")
            {
                string query = "UPDATE EVENT_MANAGEMENT SET STATUS ='" + txtStatus.Text + "' WHERE EID = '" + txtEID.Text + "' AND VID='" + txtVID.Text + "'";
                fn.setData(query);
                txtStatus.ResetText();

                string query2 = "SELECT * FROM EVENT_MANAGEMENT";
                DataSet ds2 = fn.getData(query2);
                dataGridView2.DataSource = ds2.Tables[0];
            }
            else
            {
                MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStatus.ResetText();
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
