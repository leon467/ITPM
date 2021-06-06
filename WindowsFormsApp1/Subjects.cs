using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.subjectClasses;

namespace WindowsFormsApp1
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        subjectClass s = new subjectClass();

        public void Clear()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            offSem.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox11.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            s.subject_code = textBox2.Text;
            s.sname = textBox1.Text;
            s.semester = offSem.Text;
            s.offered_yr = comboBox2.Text;
            s.lab_hrs = comboBox3.Text;
            s.tute_hrs = comboBox4.Text;
            s.lec_hrs = comboBox5.Text;
            s.evaluation_hrs = comboBox11.Text;

            //Inserting data by calling the insert method
            bool success = s.Insert(s);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New subject added");
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

        private void button14_Click(object sender, EventArgs e)
        {

            s.subject_code = textBox5.Text;
            s.sname = textBox4.Text;
            s.semester = comboBox7.Text;
            s.offered_yr = comboBox6.Text;
            s.lab_hrs = comboBox9.Text;
            s.tute_hrs = comboBox8.Text;
            s.lec_hrs = comboBox10.Text;
            s.evaluation_hrs = comboBox1.Text;

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

        private void button15_Click(object sender, EventArgs e)
        {
            //Get the SID fromthe app
            s.subject_code = textBox5.Text;
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the text boxes
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBox5.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox7.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox9.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            comboBox8.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            comboBox10.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }
        private void Subjects_Load(object sender, EventArgs e)
        {
            //Load Data on data data grid view
            DataTable dt = s.Select();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session se = new Session();
            se.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive c = new consecutive();
            c.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation r = new roomAllocation();
            r.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics st = new statistics();
            st.Show();
        }

        private void Subjects_Load_1(object sender, EventArgs e)
        {
            //Load Data on data data grid view
            DataTable dt = s.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }
    }
}
