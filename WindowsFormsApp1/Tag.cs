using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.tagClasses;

namespace WindowsFormsApp1
{
    public partial class Tag : Form
    {
        public Tag()
        {
            InitializeComponent();
        }

        tagClass t = new tagClass();
        public void Clear()
        {
            yearsem.Text = "";
            gId.Text = "";
        }
        private void savetag_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            t.tagCode = gId.Text;
            t.tagName = yearsem.Text;

            //Inserting data by calling the insert method
            bool success = t.Insert(t);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New tag added");
                Clear();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = t.Select();
            dataGridView1.DataSource = dt;
        }

        private void updateEDT_Click(object sender, EventArgs e)
        {
            //Get data from text boxes
            t.tagCode = tagCode.Text;
            t.tagName = tagname.Text;
            //Update data in database
            bool success = t.Update(t);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Updated successfully");
                //Load Data on data data grid view
                DataTable dt = t.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Failed to update
                MessageBox.Show("Failed to update");
            }
        }

        private void DelEDT_Click(object sender, EventArgs e)
        {
            //Get the tagCode fromthe app
            t.tagCode = tagCode.Text;
            bool success = t.Delete(t);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Deleted successfully");
                //Load Data on data data grid view
                DataTable dt = t.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            tagCode.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tagname.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            //Load Data on data data grid view
            DataTable dt = t.Select();
            dataGridView1.DataSource = dt;
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
            student st = new student();
            st.Show();
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
            statistics stc = new statistics();
            stc.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
