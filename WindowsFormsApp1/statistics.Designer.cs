
namespace WindowsFormsApp1
{
    partial class statistics
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 463);
            this.panel1.TabIndex = 11;
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
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(151, 41);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(320, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Statistics";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.room.Location = new System.Drawing.Point(565, 205);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(84, 15);
            this.room.TabIndex = 19;
            this.room.Text = "Subject count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(396, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(225, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lecturer count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 73);
            this.label5.TabIndex = 22;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 73);
            this.label6.TabIndex = 23;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 73);
            this.label7.TabIndex = 24;
            this.label7.Text = "0";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 201);
            this.label8.TabIndex = 25;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "What\'s new?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 42);
            this.panel2.TabIndex = 27;
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(740, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "statistics";
            this.Text = "statistics";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
    }
}