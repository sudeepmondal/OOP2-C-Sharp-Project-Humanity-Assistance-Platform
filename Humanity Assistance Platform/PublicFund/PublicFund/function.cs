using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace PublicFund
{
    internal class function
    {
        /*protected SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source=DESKTOP-3K9MEQ1;database = FUBLIC_FUND_CHARITY;Integrated Security=True";
            cn.ConnectionString = "Data Source=localhost;database = FUBLIC_FUND_CHARITY;Integrated Security=True";
            return cn;
        }*/
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public DataSet getData(string query) //get(View) data from database
        {
            SqlConnection cn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query) //Insert Update Delete into database
        {
            SqlConnection cn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Processed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();
        }
    }
}
