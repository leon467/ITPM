using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void loc_Click(object sender, EventArgs e)
        {
            this.Hide();
            location st = new location();
            st.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // statistics st = new statistics();

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StCount.Text = st.Select();
        }

        SqlConnection conn = new SqlConnection(myconnstrng);
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private DataSet dataTable;

        private void label5_Click(object sender, EventArgs e)
        {
            //Calculating total lecturer count
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(empId) as empCnt from lecturers";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string empCnt = (string)dr["empCnt"].ToString();
                label5.Text = empCnt;
            }
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Calculating total student group count
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(SID) as grpcount from students";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string grp_count = (string)dr["grpcount"].ToString();
                label6.Text = grp_count;
            }
            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Calculating total subject count
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(subject_code) as subcount from subject";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string subcount = (string)dr["subcount"].ToString();
                label7.Text = subcount;
            }
            conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT subgroupId as sid from students";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string st = "New student group added " + dr["sid"];
                label8.Text = st;
            }
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void stat_Click(object sender, EventArgs e)
        {

        }
    }
}
