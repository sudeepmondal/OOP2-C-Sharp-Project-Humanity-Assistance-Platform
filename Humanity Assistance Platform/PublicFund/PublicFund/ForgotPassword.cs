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
    public partial class ForgotPassword : Form
    {
        public static string txtPass;
        function fn = new function();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string query1 = "Select Password from sponsor where username = '" + txtUser.Text + "' or email = '" + txtUser.Text + "' ";
            string query2 = "Select password from volunteer where username = '" + txtUser.Text + "' or email = '" + txtUser.Text + "' ";
            DataSet ds1 = fn.getData(query1);
            DataSet ds2 = fn.getData(query2);

            if ((txtUser.Text == "admin" || txtUser.Text == "Admin" || txtUser.Text == "smdeep137@gmail.com"))
            {
                this.Close();
                AdminForgotPassword adminForgotPassword = new AdminForgotPassword();
                adminForgotPassword.Show();
            }
            else if (ds1.Tables[0].Rows.Count != 0)
            {
                string password = ds1.Tables[0].Rows[0][0].ToString();
                MessageBox.Show(password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (ds2.Tables[0].Rows.Count != 0)
            {
                string password = ds2.Tables[0].Rows[0][0].ToString();
                MessageBox.Show(password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
