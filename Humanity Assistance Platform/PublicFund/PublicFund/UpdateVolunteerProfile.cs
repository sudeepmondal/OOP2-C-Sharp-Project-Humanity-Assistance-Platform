using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class UpdateVolunteerProfile : Form
    {
        function fn = new function();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public UpdateVolunteerProfile()
        {
            InitializeComponent();
        }

        private void UpdateVolunteerProfile_Load(object sender, EventArgs e)
        {
            string Uname = Login.Text1;
            txtUName.Text = Uname;
            string qurey = "SELECT * FROM VOLUNTEER WHERE Username LIKE '" + Uname + "' ";
            DataSet ds = fn.getData(qurey);

            txtID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][4].ToString();
            txtSecurityQ.Text = ds.Tables[0].Rows[0][5].ToString();
            txtAns.Text = ds.Tables[0].Rows[0][6].ToString();
            txtGender.Text = ds.Tables[0].Rows[0][7].ToString();
            txtNID.Text = ds.Tables[0].Rows[0][8].ToString();
            txtBOD.Text = ds.Tables[0].Rows[0][9].ToString();
            txtPhone1.Text = ds.Tables[0].Rows[0][10].ToString();
            txtPhone2.Text = ds.Tables[0].Rows[0][11].ToString();
            txtBG.Text = ds.Tables[0].Rows[0][12].ToString();
            txtOccupation.Text = ds.Tables[0].Rows[0][13].ToString();
            txtArea.Text = ds.Tables[0].Rows[0][14].ToString();
            txtCity.Text = ds.Tables[0].Rows[0][15].ToString();
            txtCountry.Text = ds.Tables[0].Rows[0][16].ToString();
            pictureBox1.Image = getPhoto((byte[])ds.Tables[0].Rows[0][17]);  //return image from byte and set into pictureBox
        }

        private Image getPhoto(byte[] photo)  // Convert byte to image
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to update data?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection cn = new SqlConnection(cs);
                string query = "UPDATE VOLUNTEER SET NAME = '" + txtName.Text + "',Email='" + txtEmail.Text + "',Username ='" + txtUName.Text + "',password  = '" + txtPass.Text + "',Security ='" + txtSecurityQ.Text + "',Answer  = '" + txtAns.Text + "',GENDER = '" + txtGender.Text + "', NID = '" + txtNID.Text + "',DOB = '" + txtBOD.Text + "',Phone1 ='" + txtPhone1.Text + "',Phone2  = '" + txtPhone2.Text + "',BLOODGROUP='" + txtBG.Text + "',Occupation ='" + txtOccupation.Text + "',Area  = '" + txtArea.Text + "',CITY = '" + txtCity.Text + "',Country ='" + txtCountry.Text + "',Picture = @photo WHERE vID =" + txtID.Text + "";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Photo", savePhoto());
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Processed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
            }
        }

        private byte[] savePhoto() // sql DB use image in byte formate
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat); // putting image raw file in memory stream
            return ms.GetBuffer();  //getBuffer convert image to byte array 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
