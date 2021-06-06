using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.sessionOptClasses;

namespace WindowsFormsApp1
{
    public partial class consecutive : Form
    {
        public consecutive()
        {
            InitializeComponent();
        }

        Consecutive c = new Consecutive();
        private void savetag_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.session1 = session1.Text;
            c.session2 = session2.Text;

            //Inserting data by calling the insert method
            bool success = c.Insert(c);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New consecutive session added");
                Clear();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = c.Select();
            dgvCs.DataSource = dt;
        }

        public void Clear()
        {
            session1.Text = "";
            session2.Text = "";
        }

        public void ClearPar()
        {
            s1.Text = "";
            s2.Text = "";
            start.Text = "";
            day.Text = "";
            duration.Text = "";
        }

        public void ClearNon()
        {
            nos1.Text = "";
            nos2.Text = "";
            nostart.Text = "";
            noday.Text = "";
            noduration.Text = "";
        }

        public void ClearNat()
        {
            sid.Text = "";
            type.Text = "";
            time.Text = "";
        }

        SqlConnection conn = new SqlConnection(myconnstrng);
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        sessionOptClasses.Parallel p = new sessionOptClasses.Parallel();
        private void button1_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            p.session1 = s1.Text;
            p.session2 = s2.Text;
            p.startTime = start.Text;
            p.day = day.Text;
            p.duration = duration.Text;

            //Inserting data by calling the insert method
            bool success = p.Insert(p);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New parallel session added");
                ClearPar();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = p.Select();
            dgvpar.DataSource = dt;
        }

        private void consecutive_Load(object sender, EventArgs e)
        {
            //Load Data on data data grid view
            DataTable dt = c.Select();
            dgvCs.DataSource = dt;

            DataTable dt4 = p.Select();
            dgvpar.DataSource = dt4;

            DataTable dt5 = no.Select();
            dgvnon.DataSource = dt5;

            DataTable dtn = nat.Select();
            dgvnat.DataSource = dtn;

            //loading sessions to combo box in sessions tab
            session1.Items.Clear();
            s1.Items.Clear();
            nos1.Items.Clear();
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select lecturer1,lecturer2,tag,groupNo,subName,NoStudents, Hrs from sessions";
            cmd1.ExecuteNonQuery();
            DataSet dt1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Tables[0].Rows.Count; i++)

            {

                session1.Items.Add(dt1.Tables[0].Rows[i][0] + " " + dt1.Tables[0].Rows[i][1] + " " + dt1.Tables[0].Rows[i][2] + " " + dt1.Tables[0].Rows[i][3] + " " + dt1.Tables[0].Rows[i][4] + " " + dt1.Tables[0].Rows[i][5] + " " + dt1.Tables[0].Rows[i][6]);

            }

            for (int i = 0; i < dt1.Tables[0].Rows.Count; i++)

            {

                s1.Items.Add(dt1.Tables[0].Rows[i][0] + " " + dt1.Tables[0].Rows[i][1] + " " + dt1.Tables[0].Rows[i][2] + " " + dt1.Tables[0].Rows[i][3] + " " + dt1.Tables[0].Rows[i][4] + " " + dt1.Tables[0].Rows[i][5] + " " + dt1.Tables[0].Rows[i][6]);

            }

            for (int i = 0; i < dt1.Tables[0].Rows.Count; i++)

            {

                nos1.Items.Add(dt1.Tables[0].Rows[i][0] + " " + dt1.Tables[0].Rows[i][1] + " " + dt1.Tables[0].Rows[i][2] + " " + dt1.Tables[0].Rows[i][3] + " " + dt1.Tables[0].Rows[i][4] + " " + dt1.Tables[0].Rows[i][5] + " " + dt1.Tables[0].Rows[i][6]);

            }
            conn.Close();

            //loading sessions to combo box in sessions tab
            session2.Items.Clear();
            s2.Items.Clear();
            nos2.Items.Clear();
            conn.Open();
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Select lecturer1,lecturer2,tag,groupNo,subName,NoStudents, Hrs from sessions";
            cmd2.ExecuteNonQuery();
            DataSet dt2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da1.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)

            {

                session2.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2] + " " + dt2.Tables[0].Rows[i][3] + " " + dt2.Tables[0].Rows[i][4] + " " + dt2.Tables[0].Rows[i][5] + " " + dt2.Tables[0].Rows[i][6]);

            }
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)

            {

                s2.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2] + " " + dt2.Tables[0].Rows[i][3] + " " + dt2.Tables[0].Rows[i][4] + " " + dt2.Tables[0].Rows[i][5] + " " + dt2.Tables[0].Rows[i][6]);

            }

            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {

                nos2.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2] + " " + dt2.Tables[0].Rows[i][3] + " " + dt2.Tables[0].Rows[i][4] + " " + dt2.Tables[0].Rows[i][5] + " " + dt2.Tables[0].Rows[i][6]);

            }
            conn.Close();

            //loading session id to combo box
            sid.Items.Clear();
            conn.Open();
            SqlCommand cmd3 = conn.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "Select id from sessions";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                sid.Items.Add(dr3["id"].ToString());
            }
            conn.Close();

            //loading lecturer, group and subgroup to combo box
            type.Items.Clear();
            conn.Open();
            SqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select l.lecture_name, s.groupid, s.subgroupId from lecturers l, students s";
            cmd4.ExecuteNonQuery();
            DataTable dt6 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt6);
            foreach (DataRow dr4 in dt6.Rows)
            {
                type.Items.Add(dr4["lecture_name"].ToString());
                type.Items.Add(dr4["groupid"].ToString());
                type.Items.Add(dr4["subgroupId"].ToString());
            }
            conn.Close();
        }

        nonOverlap no = new nonOverlap();
        private void button2_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            no.session1 = nos1.Text;
            no.session2 = nos2.Text;
            no.startTime = nostart.Text;
            no.day = noday.Text;
            no.duration = noduration.Text;

            //Inserting data by calling the insert method
            bool success = no.Insert(no);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New non overlap session added");
                ClearNon();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = no.Select();
            dgvnon.DataSource = dt;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        notAvailableTime nat = new notAvailableTime();
        private void button3_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            nat.sessionID = sid.Text;
            nat.type = type.Text;
            nat.time = time.Text;

            //Inserting data by calling the insert method
            bool success = nat.Insert(nat);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New not available time added");
                ClearNat();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dtn = nat.Select();
            dgvnat.DataSource = dtn;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
        }

        private void Lectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects s = new Subjects();
            s.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            student s = new student();
            s.Show();
        }

        private void Tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag t = new Tag();
            t.Show();
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void Sessions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session s = new Session();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive c = new consecutive();
            c.Show();
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation r = new roomAllocation();
            r.Show();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics s = new statistics();
            s.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
