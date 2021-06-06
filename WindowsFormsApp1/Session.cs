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
using WindowsFormsApp1.SessionClasses;

namespace WindowsFormsApp1
{
    public partial class Session : Form
    {
        public Session()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation r = new roomAllocation();
            r.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            s.lecturer1 = lec1.Text;
            s.lecturer2 = lec2.Text;
            s.tag = tag.Text;
            s.groupNo = group.Text;
            s.subName = subject.Text;
            s.NoStudents = noSt.Text;
            s.Hrs = dur.Text;

            //Insert data to db using insert method in class created
            bool success = s.Insert(s);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Session added.");
                //Call clear method
                Clear();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = s.Select();
            dgvSes.DataSource = dt;
        }
        SqlConnection conn = new SqlConnection(myconnstrng);
        static string myconnstrng = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.timetableManagementConnectionString"].ConnectionString;
        private void Session_Load(object sender, EventArgs e)
        {
            
                //Load data on data grid view
                DataTable dt0 = s.Select();
                dgvSes.DataSource = dt0;

                //loading lecturers to combo box
                lec1.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select lecture_name from lecturers";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lec1.Items.Add(dr["lecture_name"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                lec2.Items.Clear();
                conn.Open();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select lecture_name from lecturers";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    lec2.Items.Add(dr1["lecture_name"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                tag.Items.Clear();
                conn.Open();
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "Select tagName from tags";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    tag.Items.Add(dr2["tagName"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                group.Items.Clear();
                conn.Open();
                SqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Select groupid from students";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr3 in dt3.Rows)
                {
                    group.Items.Add(dr3["groupid"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                subject.Items.Clear();
                conn.Open();
                SqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "Select sname from subject";
                cmd4.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(dt4);
                foreach (DataRow dr4 in dt4.Rows)
                {
                    subject.Items.Add(dr4["sname"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                lec1edit.Items.Clear();
                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "Select lecture_name from lecturers";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                da5.Fill(dt5);
                foreach (DataRow dr5 in dt5.Rows)
                {
                    lec1edit.Items.Add(dr5["lecture_name"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                lec2edit.Items.Clear();
                conn.Open();
                SqlCommand cmd6 = conn.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "Select lecture_name from lecturers";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                da6.Fill(dt6);
                foreach (DataRow dr6 in dt6.Rows)
                {
                    lec2edit.Items.Add(dr6["lecture_name"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                tag1.Items.Clear();
                conn.Open();
                SqlCommand cmd7 = conn.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "Select tagName from tags";
                cmd7.ExecuteNonQuery();
                DataTable dt7 = new DataTable();
                SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                da7.Fill(dt7);
                foreach (DataRow dr7 in dt7.Rows)
                {
                    tag1.Items.Add(dr7["tagName"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                grp.Items.Clear();
                conn.Open();
                SqlCommand cmd8 = conn.CreateCommand();
                cmd8.CommandType = CommandType.Text;
                cmd8.CommandText = "Select groupid from students";
                cmd8.ExecuteNonQuery();
                DataTable dt8 = new DataTable();
                SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                da8.Fill(dt8);
                foreach (DataRow dr8 in dt8.Rows)
                {
                    grp.Items.Add(dr8["groupid"].ToString());
                }
                conn.Close();

                //loading lecturers to combo box
                sub.Items.Clear();
                conn.Open();
                SqlCommand cmd9 = conn.CreateCommand();
                cmd9.CommandType = CommandType.Text;
                cmd9.CommandText = "Select sname from subject";
                cmd9.ExecuteNonQuery();
                DataTable dt9 = new DataTable();
                SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                da9.Fill(dt9);
                foreach (DataRow dr9 in dt9.Rows)
                {
                    sub.Items.Add(dr9["sname"].ToString());
                }
                conn.Close();
            }
        public void Clear()
        {
            lec1.Text = "";
            lec2.Text = "";
            tag.Text = "";
            group.Text = "";
            subject.Text = "";
            noSt.Text = "";
            dur.Text = "";
        }
        SessionClass s = new SessionClass();

        private void button15_Click(object sender, EventArgs e)
        {

            //Get the SID fromthe app
            s.id = Convert.ToInt32(sesID.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Deleted successfully");
                //Load Data on data data grid view
                DataTable dt = s.Select();
                dgvSes.DataSource = dt;
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            s.id = int.Parse(sesID.Text);
            s.lecturer1 = lec1edit.Text;
            s.lecturer2 = lec2edit.Text;
            s.tag = tag1.Text;
            s.groupNo = grp.Text;
            s.subName = sub.Text;
            s.NoStudents = stu.Text;
            s.Hrs = hrs.Text;
            //Update data in database
            bool success = s.Update(s);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Updated successfully");
                //Load Data on data data grid view
                DataTable dt = s.Select();
                dgvSes.DataSource = dt;
            }
            else
            {
                //Failed to update
                MessageBox.Show("Failed to update");
            }
        }

        private void dgvSes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            sesID.Text = dgvSes.Rows[rowIndex].Cells[0].Value.ToString();
            lec1edit.Text = dgvSes.Rows[rowIndex].Cells[1].Value.ToString();
            lec2edit.Text = dgvSes.Rows[rowIndex].Cells[2].Value.ToString();
            tag1.Text = dgvSes.Rows[rowIndex].Cells[3].Value.ToString();
            grp.Text = dgvSes.Rows[rowIndex].Cells[4].Value.ToString();
            sub.Text = dgvSes.Rows[rowIndex].Cells[5].Value.ToString();
            stu.Text = dgvSes.Rows[rowIndex].Cells[6].Value.ToString();
            hrs.Text = dgvSes.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects s = new Subjects();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            student s = new student();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag t = new Tag();
            t.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session s = new Session();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive c = new consecutive();
            c.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics s = new statistics();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
