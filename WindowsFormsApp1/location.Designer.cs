
namespace WindowsFormsApp1
{
    partial class location
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.roomCapacity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.rcapacity = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.rtype = new System.Windows.Forms.Label();
            this.txtbuilding = new System.Windows.Forms.TextBox();
            this.building = new System.Windows.Forms.Label();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.room = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editLoc = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgvLocationEd = new System.Windows.Forms.DataGridView();
            this.edDeleteLoc = new System.Windows.Forms.Button();
            this.caped = new System.Windows.Forms.Label();
            this.txtrtypeed = new System.Windows.Forms.ComboBox();
            this.rtypeed = new System.Windows.Forms.Label();
            this.txtbuildinged = new System.Windows.Forms.TextBox();
            this.buildinged = new System.Windows.Forms.Label();
            this.txtroomed = new System.Windows.Forms.TextBox();
            this.roomed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCapacity)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationEd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(716, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
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
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 463);
            this.panel1.TabIndex = 7;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(152, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 463);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLocation);
            this.tabPage1.Controls.Add(this.roomCapacity);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rcapacity);
            this.tabPage1.Controls.Add(this.txttype);
            this.tabPage1.Controls.Add(this.rtype);
            this.tabPage1.Controls.Add(this.txtbuilding);
            this.tabPage1.Controls.Add(this.building);
            this.tabPage1.Controls.Add(this.txtroom);
            this.tabPage1.Controls.Add(this.room);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add location";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLocation
            // 
            this.dgvLocation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Location = new System.Drawing.Point(265, 65);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.RowHeadersWidth = 51;
            this.dgvLocation.RowTemplate.Height = 25;
            this.dgvLocation.Size = new System.Drawing.Size(273, 182);
            this.dgvLocation.TabIndex = 23;
            this.dgvLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation_CellContentClick);
            this.dgvLocation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocation_RowHeaderMouseClick);
            // 
            // roomCapacity
            // 
            this.roomCapacity.Location = new System.Drawing.Point(124, 220);
            this.roomCapacity.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.roomCapacity.Name = "roomCapacity";
            this.roomCapacity.Size = new System.Drawing.Size(104, 20);
            this.roomCapacity.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(226, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add location";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rcapacity
            // 
            this.rcapacity.AutoSize = true;
            this.rcapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rcapacity.Location = new System.Drawing.Point(4, 220);
            this.rcapacity.Name = "rcapacity";
            this.rcapacity.Size = new System.Drawing.Size(123, 15);
            this.rcapacity.TabIndex = 8;
            this.rcapacity.Text = "Select room capacity";
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "Lecture hall",
            "Lab"});
            this.txttype.Location = new System.Drawing.Point(124, 166);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(104, 21);
            this.txttype.TabIndex = 7;
            // 
            // rtype
            // 
            this.rtype.AutoSize = true;
            this.rtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rtype.Location = new System.Drawing.Point(4, 168);
            this.rtype.Name = "rtype";
            this.rtype.Size = new System.Drawing.Size(103, 15);
            this.rtype.TabIndex = 5;
            this.rtype.Text = "Select room type";
            // 
            // txtbuilding
            // 
            this.txtbuilding.Location = new System.Drawing.Point(124, 117);
            this.txtbuilding.Name = "txtbuilding";
            this.txtbuilding.Size = new System.Drawing.Size(104, 20);
            this.txtbuilding.TabIndex = 4;
            // 
            // building
            // 
            this.building.AutoSize = true;
            this.building.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.building.Location = new System.Drawing.Point(4, 120);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(84, 15);
            this.building.TabIndex = 3;
            this.building.Text = "Enter building";
            // 
            // txtroom
            // 
            this.txtroom.Location = new System.Drawing.Point(124, 65);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(104, 20);
            this.txtroom.TabIndex = 2;
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.room.Location = new System.Drawing.Point(4, 68);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(70, 15);
            this.room.TabIndex = 1;
            this.room.Text = "Enter room";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(152, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editLoc);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.dgvLocationEd);
            this.tabPage2.Controls.Add(this.edDeleteLoc);
            this.tabPage2.Controls.Add(this.caped);
            this.tabPage2.Controls.Add(this.txtrtypeed);
            this.tabPage2.Controls.Add(this.rtypeed);
            this.tabPage2.Controls.Add(this.txtbuildinged);
            this.tabPage2.Controls.Add(this.buildinged);
            this.tabPage2.Controls.Add(this.txtroomed);
            this.tabPage2.Controls.Add(this.roomed);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Location";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editLoc
            // 
            this.editLoc.BackColor = System.Drawing.Color.White;
            this.editLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editLoc.Location = new System.Drawing.Point(104, 348);
            this.editLoc.Name = "editLoc";
            this.editLoc.Size = new System.Drawing.Size(120, 41);
            this.editLoc.TabIndex = 26;
            this.editLoc.Text = "Edit location";
            this.editLoc.UseVisualStyleBackColor = false;
            this.editLoc.Click += new System.EventHandler(this.editLoc_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(146, 245);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // dgvLocationEd
            // 
            this.dgvLocationEd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLocationEd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocationEd.Location = new System.Drawing.Point(279, 91);
            this.dgvLocationEd.Name = "dgvLocationEd";
            this.dgvLocationEd.RowHeadersWidth = 51;
            this.dgvLocationEd.RowTemplate.Height = 25;
            this.dgvLocationEd.Size = new System.Drawing.Size(273, 182);
            this.dgvLocationEd.TabIndex = 22;
            this.dgvLocationEd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocationEd_CellContentClick);
            this.dgvLocationEd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocationEd_RowHeaderMouseClick);
            this.dgvLocationEd.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvLocationEd_RowHeaderCellChanged);
            // 
            // edDeleteLoc
            // 
            this.edDeleteLoc.BackColor = System.Drawing.Color.White;
            this.edDeleteLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.edDeleteLoc.Location = new System.Drawing.Point(334, 348);
            this.edDeleteLoc.Name = "edDeleteLoc";
            this.edDeleteLoc.Size = new System.Drawing.Size(120, 41);
            this.edDeleteLoc.TabIndex = 21;
            this.edDeleteLoc.Text = "Delete location";
            this.edDeleteLoc.UseVisualStyleBackColor = false;
            this.edDeleteLoc.Click += new System.EventHandler(this.edDeleteLoc_Click_1);
            // 
            // caped
            // 
            this.caped.AutoSize = true;
            this.caped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.caped.Location = new System.Drawing.Point(26, 246);
            this.caped.Name = "caped";
            this.caped.Size = new System.Drawing.Size(123, 15);
            this.caped.TabIndex = 19;
            this.caped.Text = "Select room capacity";
            // 
            // txtrtypeed
            // 
            this.txtrtypeed.FormattingEnabled = true;
            this.txtrtypeed.Items.AddRange(new object[] {
            "Lecture hall",
            "Lab"});
            this.txtrtypeed.Location = new System.Drawing.Point(146, 192);
            this.txtrtypeed.Name = "txtrtypeed";
            this.txtrtypeed.Size = new System.Drawing.Size(104, 21);
            this.txtrtypeed.TabIndex = 18;
            // 
            // rtypeed
            // 
            this.rtypeed.AutoSize = true;
            this.rtypeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rtypeed.Location = new System.Drawing.Point(26, 194);
            this.rtypeed.Name = "rtypeed";
            this.rtypeed.Size = new System.Drawing.Size(103, 15);
            this.rtypeed.TabIndex = 17;
            this.rtypeed.Text = "Select room type";
            // 
            // txtbuildinged
            // 
            this.txtbuildinged.Location = new System.Drawing.Point(146, 143);
            this.txtbuildinged.Name = "txtbuildinged";
            this.txtbuildinged.Size = new System.Drawing.Size(104, 20);
            this.txtbuildinged.TabIndex = 16;
            // 
            // buildinged
            // 
            this.buildinged.AutoSize = true;
            this.buildinged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buildinged.Location = new System.Drawing.Point(26, 146);
            this.buildinged.Name = "buildinged";
            this.buildinged.Size = new System.Drawing.Size(84, 15);
            this.buildinged.TabIndex = 15;
            this.buildinged.Text = "Enter building";
            // 
            // txtroomed
            // 
            this.txtroomed.Location = new System.Drawing.Point(146, 91);
            this.txtroomed.Name = "txtroomed";
            this.txtroomed.Size = new System.Drawing.Size(104, 20);
            this.txtroomed.TabIndex = 14;
            // 
            // roomed
            // 
            this.roomed.AutoSize = true;
            this.roomed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roomed.Location = new System.Drawing.Point(26, 94);
            this.roomed.Name = "roomed";
            this.roomed.Size = new System.Drawing.Size(70, 15);
            this.roomed.TabIndex = 13;
            this.roomed.Text = "Enter room";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(146, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edit location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "location";
            this.Text = "location";
            this.Load += new System.EventHandler(this.location_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCapacity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rcapacity;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.Label rtype;
        private System.Windows.Forms.TextBox txtbuilding;
        private System.Windows.Forms.Label building;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLocationEd;
        private System.Windows.Forms.Button edDeleteLoc;
        private System.Windows.Forms.Label caped;
        private System.Windows.Forms.ComboBox txtrtypeed;
        private System.Windows.Forms.Label rtypeed;
        private System.Windows.Forms.TextBox txtbuildinged;
        private System.Windows.Forms.Label buildinged;
        private System.Windows.Forms.TextBox txtroomed;
        private System.Windows.Forms.Label roomed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown roomCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.Button editLoc;
    }
}