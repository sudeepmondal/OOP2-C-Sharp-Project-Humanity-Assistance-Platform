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
    public partial class CreateEvent : Form
    {
        function fn = new function();
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            /*string query = "SELECT MAX(eID) FROM Event";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDate.Text != "" && txtArea.Text != "" && txtCity.Text != "" )
            {
                string name = txtName.Text;
                string date = txtDate.Text;
                string area = txtArea.Text;
                string city = txtCity.Text;

                string query = "INSERT INTO Event (NAME,DATE,AREA,CITY) VALUES ('" + name + "','" + date + "','" + area + "','" + city + "' )";
                fn.setData(query);
                txtName.Clear();
                txtDate.ResetText();
                txtArea.Clear();
                txtCity.Clear();
            }
            else
            {
                MessageBox.Show("Fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtDate.ResetText();
            txtArea.Clear();
            txtCity.Clear();
        }
    }
}
