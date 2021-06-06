using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.LecturerClasses;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects f1 = new Subjects();
            f1.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        LecturerClass s = new LecturerClass();

        private void button13_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            s.empId = textBox1.Text;
            s.lecture_name = textBox2.Text;
            s.faculty = comboBox1.Text;
            s.dependent = comboBox2.Text;
            s.center = comboBox3.Text;
            s.building = comboBox4.Text;
            s.lec_level = comboBox5.Text;
            s.rank = textBox3.Text;

            //Inserting data by calling the insert method
            bool success = s.Insert(s);
            if (success == true)
            {
                //Inserted successfully
                MessageBox.Show("New lecturer added");
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
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox3.Text = "";
        }





        private void button14_Click_1(object sender, EventArgs e)
        {
            s.empId = textBox5.Text;
            s.lecture_name = textBox4.Text;
            s.faculty = comboBox7.Text;
            s.dependent = comboBox6.Text;
            s.center = comboBox9.Text;
            s.building = comboBox8.Text;
            s.lec_level = comboBox10.Text;
            s.rank = textBox6.Text;
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

        private void button15_Click_1(object sender, EventArgs e)
        {
            //Get the SID fromthe app
            s.empId = textBox5.Text;
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Subjects s = new Subjects();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            location l = new location();
            l.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
            textBox6.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void GenerateRank_Click_1(object sender, EventArgs e)
        {
            String EID = textBox1.Text;
            String LVL = comboBox5.Text;
            String Rank = LVL + "." + EID;
            textBox3.Text = Rank;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Data on data data grid view
            DataTable dt = s.Select();
            dataGridView1.DataSource = dt;
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
            Session s = new Session();
            s.Show();
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
