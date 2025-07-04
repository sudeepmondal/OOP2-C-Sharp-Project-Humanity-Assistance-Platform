using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;    //
using System.Net.Mail;  // use this two for mail using smtp
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class AdminForgotPassword : Form
    {
        public static string to;
        public AdminForgotPassword()
        {
            InitializeComponent();
        }

        int vCode =1000;
        private void btnSend_Click(object sender, EventArgs e)
        {
            timVcode.Stop();    
            string to, from, pass, mail;
            to = (txtUserEmail.Text).ToString();
            from = "smdeep137@gmail.com"; // mail account
            mail = vCode.ToString();
            pass = "nrkxecatkisidlol"; // app password [dont change]
            MailMessage message = new MailMessage(); //mailmassage class
            message.To.Add(to);
            message.From = new MailAddress(from);  //mailAddress class
            message.Subject = "Public Fund varification code"; //mail subject
            message.Body = mail;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");  // smtp class
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification code sent to your Email successfully!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information); 
                txtOTP.Enabled = true;
                btnVerify.Enabled = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
            
        }

        private void timVcode_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999) { vCode = 1000; }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text == vCode.ToString()) 
            { 
                ChangePassword changePassword = new ChangePassword(); 
                changePassword.Show();
                this.Close();    

            }
            else
            {
                MessageBox.Show("Invalid verification code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForgotPassword_Load(object sender, EventArgs e)
        {
            txtUserEmail.Text = "smdeep137@gmail.com";
        }
    }
}
