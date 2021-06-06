using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.studentClasses;

namespace WindowsFormsApp1
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        studentClass s = new studentClass();
        private void save_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            s.AcademicYS = yearsem.Text;
            s.programme = proa.Text;
            s.groupno = grnumr.Text;
            s.subgroupno = subgroupno.Text;
            s.groupid = gId.Text;
            s.subgroupId = SubGpID.Text;

            //Inserting data by calling the insert method
            bool success = s.Insert(s);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New student group added");
                Clear();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = s.Select();
            dataGridView1.DataSource = dt;
        }

        private void GenID_Click(object sender, EventArgs e)
        {
            String ays = yearsem.Text;
            String progrm = proa.Text;
            String grpNo = grnumr.Text;
            String subGrpNo = subgroupno.Text;
            String grpId = ays + "." + progrm + "." + grpNo;
            gId.Text = grpId;
            String subGrpId = ays + "." + progrm + "." + grpNo + "." + subGrpNo;
            SubGpID.Text = subGrpId;


        }

        public void Clear()
        {
            yearsem.Text = "";
            proa.Text = "";
            grnumr.Text = "";
            subgroupno.Text = "";
            gId.Text = "";
            SubGpID.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {

            //Get data from text boxes
            s.SID = int.Parse(SIDed.Text);
            s.AcademicYS = AYSEDT.Text;
            s.programme = PROMEDT.Text;
            s.groupno = GRNEDT.Text;
            s.subgroupno = SGNEDT.Text;
            s.groupid = GIDEDT.Text;
            s.subgroupId = SGIDEDT.Text;
            //Update data in database
            bool success = s.Update(s);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Updated successfully");
                //Load Data on data data grid view
                DataTable dt = s.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Failed to update
                MessageBox.Show("Failed to update");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            SIDed.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            AYSEDT.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            PROMEDT.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            GRNEDT.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            SGNEDT.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            GIDEDT.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            SGIDEDT.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void Del_Click(object sender, EventArgs e)
        {

            //Get the SID fromthe app
            s.SID = Convert.ToInt32(SIDed.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Deleted successfully");
                //Load Data on data data grid view
                DataTable dt = s.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {

            //Load Data on data data grid view
            DataTable dt = s.Select();
            dataGridView1.DataSource = dt;
        }

        private void Tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag t = new Tag();
            t.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
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
