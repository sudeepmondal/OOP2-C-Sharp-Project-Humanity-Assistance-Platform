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
    public partial class Volunteer : Form
    {
        public static string Text2;
        public Volunteer()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home home=new Home();
            home.Show();
            this.Hide();
        }

        private void Volunteer_Load(object sender, EventArgs e)
        {
            txtVUname.Text = Login.Text1;
        }

        private void viewProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text2 = Login.Text1;
            VolunteerProfile profile = new VolunteerProfile();
            profile.Show();
        }

        private void updateProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateVolunteerProfile updateVolunteerProfile = new UpdateVolunteerProfile();
            updateVolunteerProfile.Show();
        }

        private void EventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event evnt = new Event();
            evnt.Show();
        }

        private void InvitedEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetInvited getInvited = new GetInvited();
            getInvited.Show();
        }

        private void txtVUname_Click(object sender, EventArgs e)
        {

        }

        private void txtVUname_Click_1(object sender, EventArgs e)
        {

        }
    }
}
