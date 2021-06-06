using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.locationClasses;

namespace WindowsFormsApp1
{
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
        }

        locationClass l = new locationClass();

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stat_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics st = new statistics();
            st.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the value from input field
            l.room = txtroom.Text;
            l.building = txtbuilding.Text;
            l.room_type = txttype.Text;
            l.capacity = roomCapacity.Text;

            //Insert data to db using insert method in class created
            bool success = l.Insert(l);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New location added.");
                //Call clear method
                Clear();
            }
            else
            {
                //Failed to add
                MessageBox.Show("Insertion failed.");
            }
            //Load data on data grid view
            DataTable dt = l.Select();
            DataTable dt1 = l.Select();
            dgvLocation.DataSource = dt;
            dgvLocationEd.DataSource = dt1;
        }

        private void location_Load(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable dt = l.Select();
            dgvLocation.DataSource = dt;
            dgvLocationEd.DataSource = dt;
        }

        //Method to clear fields
        public void Clear()
        {
            txtroom.Text = "";
            txtbuilding.Text = "";
            txttype.Text = "";
            roomCapacity.Text = "";
        }

        //private void editLoc_Click(object sender, EventArgs e)
        //{

        //}

        private void dgvLocationEd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data grid view and load it to the text boxes
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtroomed.Text = dgvLocationEd.Rows[rowIndex].Cells[0].Value.ToString();
            txtbuildinged.Text = dgvLocationEd.Rows[rowIndex].Cells[1].Value.ToString();
            txtrtypeed.Text = dgvLocationEd.Rows[rowIndex].Cells[2].Value.ToString();
            numericUpDown1.Text = dgvLocationEd.Rows[rowIndex].Cells[3].Value.ToString();
        }

        //private void edDeleteLoc_Click(object sender, EventArgs e)
        //{

        //}

        private void dgvLocation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data grid view and load it to the text boxes
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtroom.Text = dgvLocation.Rows[rowIndex].Cells[0].Value.ToString();
            txtbuilding.Text = dgvLocation.Rows[rowIndex].Cells[1].Value.ToString();
            txttype.Text = dgvLocation.Rows[rowIndex].Cells[2].Value.ToString();
            roomCapacity.Text = dgvLocation.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void editLoc_Click_1(object sender, EventArgs e)
        {
            //Get data from text boxes
            l.room = txtroomed.Text;
            l.building = txtbuildinged.Text;
            l.room_type = txtrtypeed.Text;
            l.capacity = numericUpDown1.Text;

            //Update data
            bool success = l.Update(l);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Location successfully updated");
                DataTable dt = l.Select();
                dgvLocation.DataSource = dt;
                dgvLocationEd.DataSource = dt;

                //Call clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void edDeleteLoc_Click_1(object sender, EventArgs e)
        {
            //Get the room from the application
            l.room = txtroomed.Text;
            bool success = l.Delete(l);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Location deleted successfully.");
                DataTable dt = l.Select();
                dgvLocation.DataSource = dt;
                dgvLocationEd.DataSource = dt;
                //Call clear method
                Clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete.");
            }
        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLocationEd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLocationEd_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void lecture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void subject_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects s = new Subjects();
            s.Show();
        }

        private void rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation rs = new roomAllocation();
            rs.Show();
        }

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            student s = new student();
            s.Show();
        }

        private void wdhs_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH w = new workDH();
            w.Show();
        }

        private void sessionOp_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive co = new consecutive();
            co.Show();
        }

        private void session_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session se = new Session();
            se.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag t = new Tag();
            t.Show();
        }

        private void loc_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }



        //private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
