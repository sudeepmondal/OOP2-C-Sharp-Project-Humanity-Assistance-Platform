using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class Login : Form
    {
        public static string Text1;
        function fn = new function();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "admin" || txtUsername.Text == "Admin" || txtUsername.Text == "smdeep137@gmail.com"))
            {
                string pass = ChangePassword.newpass;
                if (txtPassword.Text == pass || txtPassword.Text == "1111")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query1 = "Select * from sponsor where username = '" + txtUsername.Text + "' or email = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                string query2 = "Select * from volunteer where username = '" + txtUsername.Text + "' or email = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                DataSet ds1 = fn.getData(query1);
                DataSet ds2 = fn.getData(query2);

                if (ds1.Tables[0].Rows.Count != 0)
                {
                    Text1 = txtUsername.Text;
                    Sponsor sponsor = new Sponsor();
                    sponsor.Show();
                    this.Hide();
                }
                else if (ds2.Tables[0].Rows.Count != 0)
                {
                    Text1 = txtUsername.Text;
                    Volunteer volunteer = new Volunteer();
                    volunteer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnShow_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnShow.Text == "Show Password")
            {
                btnShow.Text = "Hide Password";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnShow.Text = "Show Password";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnForgotPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsername.Text == "smdeep137@gmail.com")
            {
                AdminForgotPassword forgetPassword = new AdminForgotPassword();
                forgetPassword.Show();
            }
            else
            {
                ForgotPassword adminforgotPassword = new ForgotPassword();
                adminforgotPassword.Show();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
