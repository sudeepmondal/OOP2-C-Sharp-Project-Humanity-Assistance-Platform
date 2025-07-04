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
    public partial class UpdateEvent : Form
    {
        function fn = new function();
        public UpdateEvent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtEventID.Text.ToString());
            string qurey = "SELECT * FROM Event WHERE eID = " + id + "";
            DataSet ds = fn.getData(qurey);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDate.Text = ds.Tables[0].Rows[0][2].ToString();
                txtArea.Text = ds.Tables[0].Rows[0][3].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                txtName.Clear();
                txtDate.ResetText();
                txtArea.Clear();  
                txtCity.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEventID.Clear();
            txtName.Clear();
            txtDate.ResetText();
            txtArea.Clear();
            txtCity.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE EVENT SET NAME = '" + txtName.Text + "',DATE='" + txtDate.Text + "',Area ='" + txtArea.Text + "',City  = '" + txtCity.Text + "' WHERE eID =" + txtEventID.Text +"";
            fn.setData(query);
            UpdateEvent_Load(this, null); //Why ?
        }

        private void UpdateEvent_Load(object sender, EventArgs e)
        {
            txtEventID.Clear();
        }
    }
}
