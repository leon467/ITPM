
namespace WindowsFormsApp1
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.session = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Button();
            this.sessionOp = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.wdhs = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Button();
            this.lecture = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // session
            // 
            this.session.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.session.Location = new System.Drawing.Point(0, 267);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(151, 41);
            this.session.TabIndex = 12;
            this.session.Text = "Sessions";
            this.session.UseVisualStyleBackColor = false;
            this.session.Click += new System.EventHandler(this.session_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.generate.Location = new System.Drawing.Point(0, 420);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(151, 42);
            this.generate.TabIndex = 8;
            this.generate.Text = "Generate timetables";
            this.generate.UseVisualStyleBackColor = false;
            // 
            // stat
            // 
            this.stat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stat.Location = new System.Drawing.Point(0, 380);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(151, 41);
            this.stat.TabIndex = 9;
            this.stat.Text = "Statistics";
            this.stat.UseVisualStyleBackColor = false;
            this.stat.Click += new System.EventHandler(this.stat_Click);
            // 
            // sessionOp
            // 
            this.sessionOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sessionOp.Location = new System.Drawing.Point(0, 304);
            this.sessionOp.Name = "sessionOp";
            this.sessionOp.Size = new System.Drawing.Size(151, 41);
            this.sessionOp.TabIndex = 11;
            this.sessionOp.Text = "Sessions options";
            this.sessionOp.UseVisualStyleBackColor = false;
            this.sessionOp.Click += new System.EventHandler(this.sessionOp_Click);
            // 
            // rooms
            // 
            this.rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rooms.Location = new System.Drawing.Point(0, 342);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(151, 41);
            this.rooms.TabIndex = 10;
            this.rooms.Text = "Rooms";
            this.rooms.UseVisualStyleBackColor = false;
            this.rooms.Click += new System.EventHandler(this.rooms_Click);
            // 
            // wdhs
            // 
            this.wdhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wdhs.Location = new System.Drawing.Point(0, 38);
            this.wdhs.Name = "wdhs";
            this.wdhs.Size = new System.Drawing.Size(151, 41);
            this.wdhs.TabIndex = 7;
            this.wdhs.Text = "Work days and hours";
            this.wdhs.UseVisualStyleBackColor = false;
            this.wdhs.Click += new System.EventHandler(this.wdhs_Click);
            // 
            // loc
            // 
            this.loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loc.Location = new System.Drawing.Point(0, 229);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(151, 41);
            this.loc.TabIndex = 3;
            this.loc.Text = "Locations";
            this.loc.UseVisualStyleBackColor = false;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // tags
            // 
            this.tags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tags.Location = new System.Drawing.Point(0, 191);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(151, 41);
            this.tags.TabIndex = 4;
            this.tags.Text = "Tags";
            this.tags.UseVisualStyleBackColor = false;
            this.tags.Click += new System.EventHandler(this.tags_Click);
            // 
            // lecture
            // 
            this.lecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lecture.Location = new System.Drawing.Point(0, 76);
            this.lecture.Name = "lecture";
            this.lecture.Size = new System.Drawing.Size(151, 41);
            this.lecture.TabIndex = 6;
            this.lecture.Text = "Lecturers";
            this.lecture.UseVisualStyleBackColor = false;
            this.lecture.Click += new System.EventHandler(this.lecture_Click);
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.subject.Location = new System.Drawing.Point(0, 114);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(151, 41);
            this.subject.TabIndex = 5;
            this.subject.Text = "Subjects";
            this.subject.UseVisualStyleBackColor = false;
            this.subject.Click += new System.EventHandler(this.subject_Click);
            // 
            // students
            // 
            this.students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.students.Location = new System.Drawing.Point(0, 153);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(151, 41);
            this.students.TabIndex = 2;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = false;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 42);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.session);
            this.panel1.Controls.Add(this.generate);
            this.panel1.Controls.Add(this.stat);
            this.panel1.Controls.Add(this.sessionOp);
            this.panel1.Controls.Add(this.rooms);
            this.panel1.Controls.Add(this.wdhs);
            this.panel1.Controls.Add(this.loc);
            this.panel1.Controls.Add(this.tags);
            this.panel1.Controls.Add(this.lecture);
            this.panel1.Controls.Add(this.subject);
            this.panel1.Controls.Add(this.students);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 463);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(317, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "WELCOME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.time1;
            this.pictureBox1.Location = new System.Drawing.Point(183, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(739, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button session;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button stat;
        private System.Windows.Forms.Button sessionOp;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button wdhs;
        private System.Windows.Forms.Button loc;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button lecture;
        private System.Windows.Forms.Button subject;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}