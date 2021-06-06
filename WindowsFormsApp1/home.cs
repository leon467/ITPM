using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }

        private void wdhs_Click(object sender, EventArgs e)
        {
            this.Hide();
            workDH wd = new workDH();
            wd.Show();
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

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            student s = new student();
            s.Show();
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

        private void session_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session s = new Session();
            s.Show();
        }

        private void sessionOp_Click(object sender, EventArgs e)
        {
            this.Hide();
            consecutive c = new consecutive();
            c.Show();
        }

        private void rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomAllocation r = new roomAllocation();
            r.Show();
        }

        private void stat_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics wd = new statistics();
            wd.Show();
        }
    }
}
