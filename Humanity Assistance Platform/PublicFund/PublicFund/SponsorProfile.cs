using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class SponsorProfile : Form
    {
        function fn = new function();
        public SponsorProfile()
        {
            InitializeComponent();
        }

        private void SponsorProfile_Load(object sender, EventArgs e)
        {
            string Uname = Login.Text1;
            txtSUserName.Text = Uname;
            string qurey = "SELECT * FROM SPONSOR WHERE Username LIKE '" + Uname + "' ";
            DataSet ds = fn.getData(qurey);

            txtSID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtSEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            txtSGender.Text = ds.Tables[0].Rows[0][7].ToString();
            txtSNID.Text = ds.Tables[0].Rows[0][8].ToString();
            txtSBOD.Text = ds.Tables[0].Rows[0][9].ToString();
            txtSPhone1.Text = ds.Tables[0].Rows[0][10].ToString();
            txtSPhone2.Text = ds.Tables[0].Rows[0][11].ToString();
            txtSBG.Text = ds.Tables[0].Rows[0][12].ToString();
            txtSOccupation.Text = ds.Tables[0].Rows[0][13].ToString();
            txtSArea.Text = ds.Tables[0].Rows[0][14].ToString();
            txtSCity.Text = ds.Tables[0].Rows[0][15].ToString();
            txtSCountry.Text = ds.Tables[0].Rows[0][16].ToString();
            pictureBox1.Image = getPhoto((byte[])ds.Tables[0].Rows[0][17]);  //return image from byte and set into pictureBox
        }

        private Image getPhoto(byte[] photo)  // Convert byte to image
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
