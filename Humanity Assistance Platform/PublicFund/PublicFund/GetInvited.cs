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
    public partial class GetInvited : Form
    {
        function fn = new function();
        public GetInvited()
        {
            InitializeComponent();
        }

        private void GetInvited_Load(object sender, EventArgs e)
        {
            string Uname = Login.Text1;
            string qurey1 = "SELECT * FROM VOLUNTEER WHERE Username LIKE '" + Uname + "' ";
            DataSet ds1 = fn.getData(qurey1);
            string vID = ds1.Tables[0].Rows[0][0].ToString();

            string query2 = "SELECT * FROM EVENT_MANAGEMENT WHERE vID LIKE '" + vID + "' ";
            DataSet ds2 = fn.getData(query2);
            dataGridView1.DataSource = ds2.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Adjusting columns in given window
        }

        private void btnBack_Click(object sender, EventArgs e)
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
