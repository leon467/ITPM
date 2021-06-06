
namespace WindowsFormsApp1
{
    partial class roomAllocation
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tag = new System.Windows.Forms.ComboBox();
            this.troom = new System.Windows.Forms.ComboBox();
            this.dgvrt = new System.Windows.Forms.DataGridView();
            this.buildinged = new System.Windows.Forms.Label();
            this.roomed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.rtype = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomSub = new System.Windows.Forms.TabPage();
            this.dgvrs = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.lecturer = new System.Windows.Forms.ComboBox();
            this.lroom = new System.Windows.Forms.ComboBox();
            this.dgvlr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sub = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.ComboBox();
            this.groom = new System.Windows.Forms.ComboBox();
            this.dgvrg = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.sesion = new System.Windows.Forms.ComboBox();
            this.seroom = new System.Windows.Forms.ComboBox();
            this.dgvrse = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.conSession = new System.Windows.Forms.ComboBox();
            this.conroom = new System.Windows.Forms.ComboBox();
            this.dgvrcn = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.start = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.ComboBox();
            this.naroom = new System.Windows.Forms.ComboBox();
            this.dgcnat = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrt)).BeginInit();
            this.panel1.SuspendLayout();
            this.roomSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlr)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrg)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrse)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrcn)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcnat)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(222, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Allocate room";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tag);
            this.tabPage2.Controls.Add(this.troom);
            this.tabPage2.Controls.Add(this.dgvrt);
            this.tabPage2.Controls.Add(this.buildinged);
            this.tabPage2.Controls.Add(this.roomed);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(220, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Allocate room";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tag
            // 
            this.tag.FormattingEnabled = true;
            this.tag.Location = new System.Drawing.Point(129, 144);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(121, 21);
            this.tag.TabIndex = 24;
            // 
            // troom
            // 
            this.troom.FormattingEnabled = true;
            this.troom.Location = new System.Drawing.Point(129, 89);
            this.troom.Name = "troom";
            this.troom.Size = new System.Drawing.Size(121, 21);
            this.troom.TabIndex = 23;
            // 
            // dgvrt
            // 
            this.dgvrt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrt.Location = new System.Drawing.Point(279, 89);
            this.dgvrt.Name = "dgvrt";
            this.dgvrt.RowTemplate.Height = 25;
            this.dgvrt.Size = new System.Drawing.Size(273, 182);
            this.dgvrt.TabIndex = 22;
            // 
            // buildinged
            // 
            this.buildinged.AutoSize = true;
            this.buildinged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buildinged.Location = new System.Drawing.Point(26, 146);
            this.buildinged.Name = "buildinged";
            this.buildinged.Size = new System.Drawing.Size(58, 15);
            this.buildinged.TabIndex = 15;
            this.buildinged.Text = "Enter tag";
            // 
            // roomed
            // 
            this.roomed.AutoSize = true;
            this.roomed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roomed.Location = new System.Drawing.Point(26, 91);
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
            this.label4.Text = "Add room for a tag";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panel1.Location = new System.Drawing.Point(5, 38);
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
            // rtype
            // 
            this.rtype.AutoSize = true;
            this.rtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rtype.Location = new System.Drawing.Point(6, 92);
            this.rtype.Name = "rtype";
            this.rtype.Size = new System.Drawing.Size(75, 15);
            this.rtype.TabIndex = 5;
            this.rtype.Text = "Select room";
            // 
            // building
            // 
            this.building.AutoSize = true;
            this.building.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.building.Location = new System.Drawing.Point(6, 144);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(85, 15);
            this.building.TabIndex = 3;
            this.building.Text = "Select subject";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(152, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add room for a subject";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomSub
            // 
            this.roomSub.Controls.Add(this.dgvrs);
            this.roomSub.Controls.Add(this.comboBox2);
            this.roomSub.Controls.Add(this.comboBox1);
            this.roomSub.Controls.Add(this.button1);
            this.roomSub.Controls.Add(this.rtype);
            this.roomSub.Controls.Add(this.building);
            this.roomSub.Controls.Add(this.label3);
            this.roomSub.Location = new System.Drawing.Point(4, 22);
            this.roomSub.Name = "roomSub";
            this.roomSub.Padding = new System.Windows.Forms.Padding(3);
            this.roomSub.Size = new System.Drawing.Size(575, 437);
            this.roomSub.TabIndex = 0;
            this.roomSub.Text = "Subjects";
            this.roomSub.UseVisualStyleBackColor = true;
            this.roomSub.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvrs
            // 
            this.dgvrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrs.Location = new System.Drawing.Point(281, 90);
            this.dgvrs.Name = "dgvrs";
            this.dgvrs.Size = new System.Drawing.Size(288, 189);
            this.dgvrs.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.roomSub);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(155, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 463);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.lecturer);
            this.tabPage3.Controls.Add(this.lroom);
            this.tabPage3.Controls.Add(this.dgvlr);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lecturer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(218, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 32;
            this.button3.Text = "Allocate room";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lecturer
            // 
            this.lecturer.FormattingEnabled = true;
            this.lecturer.Location = new System.Drawing.Point(127, 153);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(121, 21);
            this.lecturer.TabIndex = 31;
            // 
            // lroom
            // 
            this.lroom.FormattingEnabled = true;
            this.lroom.Location = new System.Drawing.Point(127, 98);
            this.lroom.Name = "lroom";
            this.lroom.Size = new System.Drawing.Size(121, 21);
            this.lroom.TabIndex = 30;
            // 
            // dgvlr
            // 
            this.dgvlr.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvlr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlr.Location = new System.Drawing.Point(277, 98);
            this.dgvlr.Name = "dgvlr";
            this.dgvlr.RowTemplate.Height = 25;
            this.dgvlr.Size = new System.Drawing.Size(273, 182);
            this.dgvlr.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter lecturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter room";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(144, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Add room for a lecturer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sub);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.group);
            this.tabPage1.Controls.Add(this.groom);
            this.tabPage1.Controls.Add(this.dgvrg);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 437);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Group/sub group";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.FormattingEnabled = true;
            this.sub.Location = new System.Drawing.Point(127, 205);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(121, 21);
            this.sub.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(24, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Enter sub group";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(218, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 41);
            this.button4.TabIndex = 39;
            this.button4.Text = "Allocate room";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(127, 153);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(121, 21);
            this.group.TabIndex = 38;
            // 
            // groom
            // 
            this.groom.FormattingEnabled = true;
            this.groom.Location = new System.Drawing.Point(127, 98);
            this.groom.Name = "groom";
            this.groom.Size = new System.Drawing.Size(121, 21);
            this.groom.TabIndex = 37;
            // 
            // dgvrg
            // 
            this.dgvrg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrg.Location = new System.Drawing.Point(277, 98);
            this.dgvrg.Name = "dgvrg";
            this.dgvrg.RowTemplate.Height = 25;
            this.dgvrg.Size = new System.Drawing.Size(273, 182);
            this.dgvrg.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Enter group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(24, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Enter room";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(144, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 39);
            this.label9.TabIndex = 33;
            this.label9.Text = "Add room for a group/sub group";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.sesion);
            this.tabPage4.Controls.Add(this.seroom);
            this.tabPage4.Controls.Add(this.dgvrse);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(575, 437);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Session";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(218, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 41);
            this.button5.TabIndex = 39;
            this.button5.Text = "Allocate room";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sesion
            // 
            this.sesion.FormattingEnabled = true;
            this.sesion.Location = new System.Drawing.Point(127, 153);
            this.sesion.Name = "sesion";
            this.sesion.Size = new System.Drawing.Size(121, 21);
            this.sesion.TabIndex = 38;
            // 
            // seroom
            // 
            this.seroom.FormattingEnabled = true;
            this.seroom.Location = new System.Drawing.Point(127, 98);
            this.seroom.Name = "seroom";
            this.seroom.Size = new System.Drawing.Size(121, 21);
            this.seroom.TabIndex = 37;
            // 
            // dgvrse
            // 
            this.dgvrse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrse.Location = new System.Drawing.Point(277, 98);
            this.dgvrse.Name = "dgvrse";
            this.dgvrse.RowTemplate.Height = 25;
            this.dgvrse.Size = new System.Drawing.Size(273, 182);
            this.dgvrse.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(24, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Enter session";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(24, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Enter room";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(144, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 39);
            this.label13.TabIndex = 33;
            this.label13.Text = "Add room for a session";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.conSession);
            this.tabPage5.Controls.Add(this.conroom);
            this.tabPage5.Controls.Add(this.dgvrcn);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(575, 437);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Consecutive session";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(218, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 41);
            this.button6.TabIndex = 46;
            this.button6.Text = "Allocate room";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // conSession
            // 
            this.conSession.FormattingEnabled = true;
            this.conSession.Location = new System.Drawing.Point(161, 129);
            this.conSession.Name = "conSession";
            this.conSession.Size = new System.Drawing.Size(389, 21);
            this.conSession.TabIndex = 45;
            // 
            // conroom
            // 
            this.conroom.FormattingEnabled = true;
            this.conroom.Location = new System.Drawing.Point(161, 78);
            this.conroom.Name = "conroom";
            this.conroom.Size = new System.Drawing.Size(121, 21);
            this.conroom.TabIndex = 44;
            // 
            // dgvrcn
            // 
            this.dgvrcn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrcn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrcn.Location = new System.Drawing.Point(9, 169);
            this.dgvrcn.Name = "dgvrcn";
            this.dgvrcn.RowTemplate.Height = 25;
            this.dgvrcn.Size = new System.Drawing.Size(541, 182);
            this.dgvrcn.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(6, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Enter consecutive session";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(6, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 15);
            this.label15.TabIndex = 41;
            this.label15.Text = "Enter room";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(144, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 39);
            this.label16.TabIndex = 40;
            this.label16.Text = "Add room for a consecutive session";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.start);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.end);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.day);
            this.tabPage6.Controls.Add(this.naroom);
            this.tabPage6.Controls.Add(this.dgcnat);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(575, 437);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Not reservable time";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.FormattingEnabled = true;
            this.start.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.start.Location = new System.Drawing.Point(127, 205);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(121, 21);
            this.start.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(24, 207);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 15);
            this.label21.TabIndex = 49;
            this.label21.Text = "Select start time";
            // 
            // end
            // 
            this.end.FormattingEnabled = true;
            this.end.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.end.Location = new System.Drawing.Point(127, 259);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(121, 21);
            this.end.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(24, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 15);
            this.label20.TabIndex = 47;
            this.label20.Text = "Select end time";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(218, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 41);
            this.button7.TabIndex = 46;
            this.button7.Text = "Allocate room";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.day.Location = new System.Drawing.Point(127, 153);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(121, 21);
            this.day.TabIndex = 45;
            // 
            // naroom
            // 
            this.naroom.FormattingEnabled = true;
            this.naroom.Location = new System.Drawing.Point(127, 98);
            this.naroom.Name = "naroom";
            this.naroom.Size = new System.Drawing.Size(121, 21);
            this.naroom.TabIndex = 44;
            // 
            // dgcnat
            // 
            this.dgcnat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgcnat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcnat.Location = new System.Drawing.Point(277, 98);
            this.dgcnat.Name = "dgcnat";
            this.dgcnat.RowTemplate.Height = 25;
            this.dgcnat.Size = new System.Drawing.Size(273, 182);
            this.dgcnat.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(24, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 42;
            this.label17.Text = "Select day";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(24, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 41;
            this.label18.Text = "Select room";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(144, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(299, 39);
            this.label19.TabIndex = 40;
            this.label19.Text = "Add not reservable times to a room";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "roomAllocation";
            this.Text = "roomSubject";
            this.Load += new System.EventHandler(this.roomSubject_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.roomSub.ResumeLayout(false);
            this.roomSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlr)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrg)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrse)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrcn)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcnat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvrt;
        private System.Windows.Forms.Label buildinged;
        private System.Windows.Forms.Label roomed;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label rtype;
        private System.Windows.Forms.Label building;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage roomSub;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvrs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox tag;
        private System.Windows.Forms.ComboBox troom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox lecturer;
        private System.Windows.Forms.ComboBox lroom;
        private System.Windows.Forms.DataGridView dgvlr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox sub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.ComboBox groom;
        private System.Windows.Forms.DataGridView dgvrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox sesion;
        private System.Windows.Forms.ComboBox seroom;
        private System.Windows.Forms.DataGridView dgvrse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox conSession;
        private System.Windows.Forms.ComboBox conroom;
        private System.Windows.Forms.DataGridView dgvrcn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox end;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.ComboBox naroom;
        private System.Windows.Forms.DataGridView dgcnat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}