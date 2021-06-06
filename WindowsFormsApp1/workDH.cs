using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.timeSlotsClass;
using WindowsFormsApp1.wdhClasses;

namespace WindowsFormsApp1
{
    public partial class workDH : Form
    {
        public workDH()
        {
            InitializeComponent();
        }

        wdhClass w = new wdhClass();
        private void Add_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            w.noOfDays = comboBox1.Text;
            w.workDays = textBox2.Text;
            w.Hours = comboBox2.Text;
            w.Mins = comboBox3.Text;

            //Inserting data by calling the insert method
            bool success = w.insert(w);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New record added");
                Clear();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = w.select();
            dataGridView2.DataSource = dt;
        }

        private void workDH_Load(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable dt = w.select();
            dataGridView2.DataSource = dt;
            DataTable dt1 = t.select();
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from data grid view and load it to the text boxes
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBox1.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox6.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox5.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox4.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void update1_Click(object sender, EventArgs e)
        {
            //Get data from text boxes
            w.Id = int.Parse(textBox1.Text);
            w.noOfDays = comboBox6.Text;
            w.workDays = textBox3.Text;
            w.Hours = comboBox5.Text;
            w.Mins = comboBox4.Text;

            //Update data
            bool success = w.update(w);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Row successfully updated");
                DataTable dt = w.select();
                dataGridView2.DataSource = dt;

                //Call clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void Deleteall_Click(object sender, EventArgs e)
        {
            //Get the room from the application
            w.Id = int.Parse(textBox1.Text);
            bool success = w.delete(w);
            if (success == true)
            {
                //Successfully deleted
                MessageBox.Show("Row deleted successfully.");
                DataTable dt = w.select();
                dataGridView2.DataSource = dt;
                //Call clear method
                Clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete.");
            }
        }

        timeSlots t = new timeSlots();

        public void Clear()
        {
            tId.Text = "";
            comboBox9.Text = "";
            comboBox8.Text = "";
        }

        private void Addtimeslot_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            t.day = comboBox9.Text;
            t.timeSlot = comboBox8.Text;

            //Inserting data by calling the insert method
            bool success = t.insert(t);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New time slot added");
                Clear();
            }
            else
            {
                //Failed insertion
                MessageBox.Show("Insertion failed");
            }

            //Load Data on data data grid view
            DataTable dt = t.select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Addtimeslots_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.select();
            dataGridView1.DataSource = dt1;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects f = new Subjects();
            f.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            student f = new student();
            f.Show();
        }

        private void Tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tag f = new Tag();
            f.Show();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics f = new statistics();
            f.Show();
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation f = new roomAllocation();
            f.Show();
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            location f = new location();
            f.Show();
        }

        private void Workdaysandhours_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
        }

        private void Sessions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session se = new Session();
            se.Show();
        }

        private void Sessionsoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive co = new consecutive();
            co.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
