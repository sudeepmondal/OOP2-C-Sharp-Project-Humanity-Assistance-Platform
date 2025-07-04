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
    public partial class SponsorList : Form
    {
        function fn = new function();
        public SponsorList()
        {
            InitializeComponent();
        }

        private void SponsorList_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SPONSOR";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Adjusting columns in given window
            DataGridViewImageColumn dgv = new DataGridViewImageColumn(); //for view image in DataGridView column 
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[17];  //Convert Image from column[17] to DataGridViewImageColumn by dgv object
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;  //fit the cell layout at stretch   
            dataGridView1.RowTemplate.Height = 50;  //set row height 
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
