using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;

namespace PublicFund
{
    public partial class Donation : Form
    {
        function fn = new function();
        public Donation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            txtSUName.Text = Login.Text1;
            string query = "SELECT * FROM EVENT";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Adjusting columns in given window

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Uname = Login.Text1;
            txtSUName.Text = Uname;
            string eID = txtEID.Text;
            string amount = txtAmount.Text;
            string AccNo = txtAccNo.Text;
            string AccName = txtAccName.Text;

            if (txtSUName.Text != "")
            {
                string qurey = "SELECT * FROM SPONSOR WHERE Username LIKE '" + Uname + "' ";
                DataSet ds = fn.getData(qurey);

                string ID = ds.Tables[0].Rows[0][0].ToString();
                Int64 sID = Int64.Parse(ID);
                string query = "Insert into DONATION (Acc_No,Acc_H_Name,Amount,eID,sID) Values  ('" + AccNo + "','" + AccName + "','"+amount+"','" + eID + "','" + sID + "' ) ";
                fn.setData(query);
                Donation_Load(this, null);

            }
            else
            {
                string query = "Insert into DONATION (Acc_No,Acc_H_Name,Amount,eID) Values  ('" + AccNo + "','" + AccName + "','" + amount + "','" + eID + "') ";
                fn.setData(query);
                Donation_Load(this, null);
            }
        }
    }
}
