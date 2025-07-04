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
    public partial class Sponsor : Form
    {
        public static string txtUN;
        public Sponsor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Sponsor_Load(object sender, EventArgs e)
        {
            txtSUname.Text = Login.Text1;
        }

        private void viewProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SponsorProfile profile = new SponsorProfile();
            profile.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Event evnt = new Event();
            evnt.Show();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            donation.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void updateProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateSponsorProfile profile = new UpdateSponsorProfile();
            profile.Show();
        }

        private void EventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event evnt = new Event();
            evnt.Show();
        }
    }
}
