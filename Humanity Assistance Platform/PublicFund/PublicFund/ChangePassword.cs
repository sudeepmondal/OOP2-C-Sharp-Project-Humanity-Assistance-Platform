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
    public partial class ChangePassword : Form
    {
        public static string newpass;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass.Text))   //using IsNullOrEmpty function for check null value 
            {
                txtNewPass.Focus();    //Focus on this textBox untill some text given
                errorProvider1.SetError(this.txtNewPass, "Please provide a password !");   //SetError(check part, Massage)
            }
            else
            {
                errorProvider1.Clear();   // Clear Error
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == txtConPass.Text)
            {
                newpass = txtConPass.Text;
                MessageBox.Show("New password generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Confirm password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
