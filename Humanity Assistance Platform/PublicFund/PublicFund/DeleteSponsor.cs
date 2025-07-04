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
    public partial class DeleteSponsor : Form
    {
        function fn = new function();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public DeleteSponsor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtSponsorID.Text.ToString());
            string qurey = "SELECT * FROM SPONSOR WHERE sID = " + id + "";
            DataSet ds = fn.getData(qurey);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNID.Text = ds.Tables[0].Rows[0][8].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][7].ToString();
                txtphone1.Text = ds.Tables[0].Rows[0][10].ToString();
                txtphone2.Text = ds.Tables[0].Rows[0][11].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][12].ToString();
                txtArea.Text = ds.Tables[0].Rows[0][14].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][15].ToString();
                txtCountry.Text = ds.Tables[0].Rows[0][16].ToString();
                pictureBox1.Image = getPhoto((byte[])ds.Tables[0].Rows[0][17]);  //return image from byte and set into pictureBox
            }
            else
            {
                MessageBox.Show("Invalid ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image getPhoto(byte[] photo)  // Convert byte to image
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = "DELETE FROM SPONSOR WHERE sID = " + txtSponsorID.Text + "";
                fn.setData(query);
            }
        }

        private void DeleteSponsor_Load(object sender, EventArgs e)
        {

        }

        private void txtSponsorID_TextChanged(object sender, EventArgs e)
        {
            if (txtSponsorID.Text == "")
            {
                txtName.Clear();
                txtEmail.Clear();
                txtNID.Clear();
                txtGender.ResetText();
                txtphone1.Clear();
                txtphone2.Clear();
                txtBloodGroup.ResetText();
                txtArea.Clear();
                txtCity.Clear();
                txtCountry.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSponsorID.Clear();
        }
    }
}
