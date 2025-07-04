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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void viewVolunteersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolunteerList volunteerList = new VolunteerList();
            volunteerList.Show();
        }

        private void viewSponsorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SponsorList sponsorList = new SponsorList();
            sponsorList.Show();
        }

        private void deleteVolunteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVolunteer deleteVolunteer = new DeleteVolunteer();
            deleteVolunteer.Show();
        }

        private void deleteSponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSponsor deleteSponsor = new DeleteSponsor();
            deleteSponsor.Show();
        }

        private void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event evnt = new Event();
            evnt.Show();
        }

        private void createNewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            deleteEvent.Show();
        }

        private void updateEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEvent updateEvent = new UpdateEvent();
            updateEvent.Show();
        }

        private void btFund_Click(object sender, EventArgs e)
        {
            Funds funds = new Funds();
            funds.Show();
        }

        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void eventManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventManagement eventManagement = new EventManagement();
            eventManagement.Show();
        }

        private void eventStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolunteersPrticipation volunteersPrticipation = new VolunteersPrticipation();
            volunteersPrticipation.Show();
        }

        private void sendInvitationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InviteVolunteer inviteVolunteer = new InviteVolunteer();
            inviteVolunteer.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
