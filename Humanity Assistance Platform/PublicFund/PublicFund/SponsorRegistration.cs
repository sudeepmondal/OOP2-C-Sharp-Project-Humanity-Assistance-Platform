using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;         //MemoryStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class SponsorRegistration : Form
    {
        function fn = new function();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SponsorRegistration()
        {
            InitializeComponent();
        }

        private void txtPass_Leave(object sender, EventArgs e)   //generating Leave Event
        {
            if (string.IsNullOrEmpty(txtPass.Text))   //using IsNullOrEmpty function for check null value 
            { 
                txtPass.Focus();    //Focus on this textBox untill some text given
                errorProvider1.SetError(this.txtPass,"Please provide a password !");   //SetError(check part, Massage)
            }
            else
            {
                errorProvider1.Clear();   // Clear Error
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConPass.Text)   //check pass and confirm pass equal or not 
            {
                txtConPass.Focus();    //Focus on this textBox untill some text given
                errorProvider1.SetError(this.txtConPass, "Please provide a confirm password !");   //SetError(check part, Massage)
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //Open File Dialog
            ofd.Title= "Select Image";  // Form Title
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif ";  // format filter   [All files(*.*) |*.*]

            if (ofd.ShowDialog() == DialogResult.OK)  // While image selected and pressed OK
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);  // bitmap provide image and filename provide name of file
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
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtUName.Text != "" && txtEmail.Text != "" && txtGender.Text != "" && txtPhone1.Text != "" && txtNID.Text != "" && txtBG.Text != "" && txtCity.Text != "" && txtArea.Text != "" && txtBOD.Text != "" && txtCountry.Text != "" )
            {
                if((txtPass.Text == txtConPass.Text))
                {
                    string name = txtName.Text;
                    string uname = txtUName.Text;
                    string nid = txtNID.Text;
                    string dob = txtBOD.Text;
                    string gender = txtGender.Text;
                    string phone1 = txtPhone1.Text;
                    string phone2 = txtPhone2.Text;
                    string email = txtEmail.Text;
                    string bg = txtBG.Text;
                    string area = txtArea.Text;
                    string city = txtCity.Text;
                    string country = txtCountry.Text;
                    string security = txtSecurityQ.Text;
                    string ans = txtAns.Text;
                    string pass = txtPass.Text;
                    //string cpass = txtConPass.Text;
                    string occ = txtOccupation.Text;
                    SqlConnection cn = new SqlConnection(cs);
                    if (txtPhone2.Text != "")
                    {
                        string query = "INSERT INTO SPONSOR (NAME,Email,Username,Password,Security,Answer,GENDER,NID,DOB,Phone1,Phone2,BLOODGROUP,Occupation,Area,CITY,country,Picture) VALUES ('" + name + "','" + email + "','" + uname + "','" + pass + "','" + security + "','" + ans + "','" + gender + "','" + nid + "','" + dob + "','" + phone1 + "','" + phone2 + "','" + bg + "','" + occ + "','" + area + "','" + city + "','" + country + "',@Photo)";
                        SqlCommand cmd = new SqlCommand(query,cn);
                        cmd.Parameters.AddWithValue("@Photo", savePhoto());
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Processed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        string query = "INSERT INTO SPONSOR (NAME,Email,Username,Password,Security,Answer,GENDER,NID,DOB,Phone1,BLOODGROUP,Occupation,Area,CITY,country,Picture) VALUES ('" + name + "','" + email + "','" + uname + "','" + pass + "','" + security + "','" + ans + "','" + gender + "','" + nid + "','" + dob + "','" + phone1 + "','" + bg + "','" + occ + "','" + area + "','" + city + "','" + country + "',@Photo)";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@Photo", savePhoto());
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Processed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SponsorRegistration_Load(object sender, EventArgs e)
        {
            /*string query = "SELECT MAX(sID) FROM SPONSOR";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtID.Text = (count + 1).ToString();*/
        }
    }
}
