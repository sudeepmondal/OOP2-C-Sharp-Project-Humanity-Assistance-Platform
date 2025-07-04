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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnVolunteerReg_Click(object sender, EventArgs e)
        {
            VollunteerReg reg = new VollunteerReg();
            reg.Show();
            this.Hide();
        }

        private void btnSponsorReg_Click(object sender, EventArgs e)
        {
            SponsorRegistration sponsor = new SponsorRegistration();
            sponsor.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event @event = new Event();
            @event.Show();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
