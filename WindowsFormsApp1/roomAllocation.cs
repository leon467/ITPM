using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.roomAllocations;

namespace WindowsFormsApp1
{
    public partial class roomAllocation : Form
    {
        public roomAllocation()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DataTable rs = r.Select();
            dgvrs.DataSource = rs;
        }

        SqlConnection conn = new SqlConnection(myconnstrng);
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Retieve data on loading form
        private void roomSubject_Load(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable rs = r.Select();
            dgvrs.DataSource = rs;

            DataTable rs1 = rt.Select();
            dgvrt.DataSource = rs1;

            DataTable rs2 = rl.Select();
            dgvlr.DataSource = rs2;

            DataTable rs3 = rg.Select();
            dgvrg.DataSource = rs3;

            DataTable rs4 = rse.Select();
            dgvrse.DataSource = rs4;

            DataTable rs5 = rcs.Select();
            dgvrcn.DataSource = rs5;

            DataTable rs6 = rnr.Select();
            dgcnat.DataSource = rs6;

            //loading rooms to combo box in subjects tab
            comboBox2.Items.Clear();
            conn.Open();
            SqlCommand cmds = conn.CreateCommand();
            cmds.CommandType = CommandType.Text;
            cmds.CommandText = "Select room from locations";
            cmds.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmds);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["room"].ToString());
            }
            conn.Close();

            //loading subjects to combo box
            comboBox1.Items.Clear();
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select sname from subject";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBox1.Items.Add(dr1["sname"].ToString());
            }
            conn.Close();

            //loading rooms to combo box in tags tab
            troom.Items.Clear();
            conn.Open();
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Select room from locations";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                troom.Items.Add(dr2["room"].ToString());
            }
            conn.Close();

            //loading tags to combo box in tags tab
            tag.Items.Clear();
            conn.Open();
            SqlCommand cmd5 = conn.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "Select tagName from tags";
            cmd5.ExecuteNonQuery();
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            foreach (DataRow dr5 in dt5.Rows)
            {
                tag.Items.Add(dr5["tagName"].ToString());
            }
            conn.Close();

            //loading rooms to combo box in lecturers tab
            lroom.Items.Clear();
            conn.Open();
            SqlCommand cmd3 = conn.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "Select room from locations";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                lroom.Items.Add(dr3["room"].ToString());
            }
            conn.Close();

            //loading lecturers to combo box in lecturers tab
            lecturer.Items.Clear();
            conn.Open();
            SqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select lecture_name from lecturers";
            cmd4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt4);
            foreach (DataRow dr4 in dt4.Rows)
            {
                lecturer.Items.Add(dr4["lecture_name"].ToString());
            }
            conn.Close();

            //loading rooms to combo box in lecturers tab
            groom.Items.Clear();
            conn.Open();
            SqlCommand cmd6 = conn.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "Select room from locations";
            cmd6.ExecuteNonQuery();
            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);
            foreach (DataRow dr6 in dt6.Rows)
            {
                groom.Items.Add(dr6["room"].ToString());
            }
            conn.Close();

            //loading groups to combo box in groups/sub groups tab tab
            group.Items.Clear();
            conn.Open();
            SqlCommand cmd7 = conn.CreateCommand();
            cmd7.CommandType = CommandType.Text;
            cmd7.CommandText = "Select groupid from students";
            cmd7.ExecuteNonQuery();
            DataTable dt7 = new DataTable();
            SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
            da7.Fill(dt7);
            foreach (DataRow dr7 in dt7.Rows)
            {
                group.Items.Add(dr7["groupid"].ToString());
            }
            conn.Close();

            //loading subgroups to combo box in groups/sub groups tab tab
            sub.Items.Clear();
            conn.Open();
            SqlCommand cmd8 = conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "Select subgroupId from students";
            cmd8.ExecuteNonQuery();
            DataTable dt8 = new DataTable();
            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            da8.Fill(dt8);
            foreach (DataRow dr8 in dt8.Rows)
            {
                sub.Items.Add(dr8["subgroupId"].ToString());
            }
            conn.Close();

            //loading rooms to combo box in sessions tab
            seroom.Items.Clear();
            conn.Open();
            SqlCommand cmd9 = conn.CreateCommand();
            cmd9.CommandType = CommandType.Text;
            cmd9.CommandText = "Select room from locations";
            cmd9.ExecuteNonQuery();
            DataTable dt9 = new DataTable();
            SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
            da9.Fill(dt9);
            foreach (DataRow dr9 in dt9.Rows)
            {
                seroom.Items.Add(dr9["room"].ToString());
            }
            conn.Close();

            //loading sessions to combo box in sessions tab
            sesion.Items.Clear();
            conn.Open();
            SqlCommand cmd10 = conn.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "Select lecturer1,lecturer2,tag,groupNo,subName,NoStudents, Hrs from sessions";
            cmd10.ExecuteNonQuery();
            DataSet dt10 = new DataSet();
            SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
            da10.Fill(dt10);
            for (int i = 0; i < dt10.Tables[0].Rows.Count; i++)

            {

                sesion.Items.Add(dt10.Tables[0].Rows[i][0] + " " + dt10.Tables[0].Rows[i][1] + " " + dt10.Tables[0].Rows[i][2] + " " + dt10.Tables[0].Rows[i][3] + " " + dt10.Tables[0].Rows[i][4] + " " + dt10.Tables[0].Rows[i][5] + " " + dt10.Tables[0].Rows[i][6]);

            }
            conn.Close();

            //loading rooms to combo box in consecutive sessions tab
            conroom.Items.Clear();
            conn.Open();
            SqlCommand cmd11 = conn.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "Select room from locations";
            cmd11.ExecuteNonQuery();
            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            da11.Fill(dt11);
            foreach (DataRow dr11 in dt11.Rows)
            {
                conroom.Items.Add(dr11["room"].ToString());
            }
            conn.Close();

            //loading sessions to combo box in sessions tab
            conSession.Items.Clear();
            conn.Open();
            SqlCommand cmd12 = conn.CreateCommand();
            cmd12.CommandType = CommandType.Text;
            cmd12.CommandText = "Select session1, session2 from conSession";
            cmd12.ExecuteNonQuery();
            DataSet dt12 = new DataSet();
            SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
            da12.Fill(dt12);
            for (int i = 0; i < dt12.Tables[0].Rows.Count; i++)

            {

                conSession.Items.Add(dt12.Tables[0].Rows[i][0] + " , " + dt12.Tables[0].Rows[i][1]);

            }
            conn.Close();


            //loading rooms to combo box in not researvable times tab
            naroom.Items.Clear();
            conn.Open();
            SqlCommand cmd13 = conn.CreateCommand();
            cmd13.CommandType = CommandType.Text;
            cmd13.CommandText = "Select room from locations";
            cmd13.ExecuteNonQuery();
            DataTable dt13 = new DataTable();
            SqlDataAdapter da13 = new SqlDataAdapter(cmd13);
            da13.Fill(dt13);
            foreach (DataRow dr13 in dt13.Rows)
            {
                naroom.Items.Add(dr13["room"].ToString());
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        roomSub r = new roomSub();

        //Method to clear fields
        public void Clear()
        {
            comboBox2.Text = "";
            comboBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            r.room = comboBox2.Text;
            r.subject = comboBox1.Text;

            //Insert data to db using insert method in class created
            bool success = r.Insert(r);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for subject.");
                //Call clear method
                Clear();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = r.Select();
            dgvrs.DataSource = dt;
        }

        roomTag rt = new roomTag();
        public void ClearRt()
        {
            troom.Text = "";
            tag.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rt.room = troom.Text;
            rt.tag = tag.Text;

            //Insert data to db using insert method in class created
            bool success = rt.Insert(rt);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for tag.");
                //Call clear method
                ClearRt();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rt.Select();
            dgvrt.DataSource = dt;
        }

        public void ClearRl()
        {
            lroom.Text = "";
            lecturer.Text = "";
        }

        roomLec rl = new roomLec();
        private void button3_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rl.room = lroom.Text;
            rl.lecturer = lecturer.Text;

            //Insert data to db using insert method in class created
            bool success = rl.Insert(rl);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for lecturer.");
                //Call clear method
                ClearRl();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rl.Select();
            dgvlr.DataSource = dt;
        }

        private void lecture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void subject_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects s = new Subjects();
            s.Show();
        }

        private void loc_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void stat_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics s = new statistics();
            s.Show();
        }

        public void ClearRg()
        {
            groom.Text = "";
            group.Text = "";
            sub.Text = "";
        }
        roomGrp rg = new roomGrp();
        private void button4_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rg.room = groom.Text;
            rg.grp = group.Text;
            rg.sub = sub.Text;

            //Insert data to db using insert method in class created
            bool success = rg.Insert(rg);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for group/sub group.");
                //Call clear method
                ClearRg();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rg.Select();
            dgvrg.DataSource = dt;
        }
        public void ClearRse()
        {
            seroom.Text = "";
            sesion.Text = "";
        }
        roomSession rse = new roomSession();
        private void button5_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rse.room = seroom.Text;
            rse.session = sesion.Text;

            //Insert data to db using insert method in class created
            bool success = rse.Insert(rse);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for session.");
                //Call clear method
                ClearRse();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rse.Select();
            dgvrse.DataSource = dt;
        }

        roomConSession rcs = new roomConSession();

        private void button6_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rcs.room = conroom.Text;
            rcs.conSessions = conSession.Text;

            //Insert data to db using insert method in class created
            bool success = rcs.Insert(rcs);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for consecutive session.");
                //Call clear method
                ClearRse();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rcs.Select();
            dgvrcn.DataSource = dt;
        }

        roomNotRes rnr = new roomNotRes();
        private void button7_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            rnr.room = naroom.Text;
            rnr.day = day.Text;
            rnr.startt = start.Text;
            rnr.endt = end.Text;

            //Insert data to db using insert method in class created
            bool success = rnr.Insert(rnr);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Room allocated for not reservable time.");
                //Call clear method
                ClearRse();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = rnr.Select();
            dgcnat.DataSource = dt;
        }

        private void sessionOp_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive co = new consecutive();
            co.Show();
        }

        private void wdhs_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
        }

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            student st = new student();
            st.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag t = new Tag();
            t.Show();
        }

        private void session_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session se = new Session();
            se.Show();
        }

        private void rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation ra = new roomAllocation();
            ra.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
