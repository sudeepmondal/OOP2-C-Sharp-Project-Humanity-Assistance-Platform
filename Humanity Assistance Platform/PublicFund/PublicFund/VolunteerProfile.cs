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
using System.IO;
using System.Configuration;

namespace PublicFund
{
    public partial class VolunteerProfile : Form
    {
        function fn = new function();
        public VolunteerProfile()
        {
            InitializeComponent();
        }

        private void VolunteerProfile_Load(object sender, EventArgs e)
        {
            string Uname = Volunteer.Text2;
            txtVUserName.Text = Uname;
            string qurey = "SELECT * FROM VOLUNTEER WHERE Username LIKE '"+Uname+"' ";
            DataSet ds = fn.getData(qurey);

            txtVID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtVName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtVEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            txtVGender.Text = ds.Tables[0].Rows[0][7].ToString();
            txtVNID.Text = ds.Tables[0].Rows[0][8].ToString();
            txtVBOD.Text = ds.Tables[0].Rows[0][9].ToString();
            txtVPhone1.Text = ds.Tables[0].Rows[0][10].ToString();
            txtVPhone2.Text = ds.Tables[0].Rows[0][11].ToString();
            txtVBG.Text = ds.Tables[0].Rows[0][12].ToString();
            txtVOccupation.Text = ds.Tables[0].Rows[0][13].ToString();
            txtVArea.Text = ds.Tables[0].Rows[0][14].ToString();
            txtVCity.Text = ds.Tables[0].Rows[0][15].ToString();
            txtVCountry.Text = ds.Tables[0].Rows[0][16].ToString();
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
