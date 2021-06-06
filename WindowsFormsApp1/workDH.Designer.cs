
namespace WindowsFormsApp1
{
    partial class workDH
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Deleteall = new System.Windows.Forms.Button();
            this.update1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Addworkingdaysandhours = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.wdhId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addtimeslot = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Manageworkingdaysandhours = new System.Windows.Forms.TabPage();
            this.Generatetimetables = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.Sessionsoptions = new System.Windows.Forms.Button();
            this.Sessions = new System.Windows.Forms.Button();
            this.Locations = new System.Windows.Forms.Button();
            this.Tags = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Subjects = new System.Windows.Forms.Button();
            this.Lectures = new System.Windows.Forms.Button();
            this.Workdaysandhours = new System.Windows.Forms.Button();
            this.Addtimeslots = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Statistics = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Addworkingdaysandhours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Manageworkingdaysandhours.SuspendLayout();
            this.Addtimeslots.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(356, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(342, 189);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "ID";
            // 
            // Deleteall
            // 
            this.Deleteall.Location = new System.Drawing.Point(404, 334);
            this.Deleteall.Name = "Deleteall";
            this.Deleteall.Size = new System.Drawing.Size(103, 33);
            this.Deleteall.TabIndex = 35;
            this.Deleteall.Text = "Delete all";
            this.Deleteall.UseVisualStyleBackColor = true;
            this.Deleteall.Click += new System.EventHandler(this.Deleteall_Click);
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(229, 334);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(103, 33);
            this.update1.TabIndex = 34;
            this.update1.Text = "update";
            this.update1.UseVisualStyleBackColor = true;
            this.update1.Click += new System.EventHandler(this.update1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Hours";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.comboBox4.Location = new System.Drawing.Point(229, 277);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 24;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox5.Location = new System.Drawing.Point(229, 237);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 23;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox6.Location = new System.Drawing.Point(229, 142);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Working time per day";
            // 
            // Addworkingdaysandhours
            // 
            this.Addworkingdaysandhours.Controls.Add(this.textBox2);
            this.Addworkingdaysandhours.Controls.Add(this.wdhId);
            this.Addworkingdaysandhours.Controls.Add(this.ID);
            this.Addworkingdaysandhours.Controls.Add(this.Add);
            this.Addworkingdaysandhours.Controls.Add(this.label6);
            this.Addworkingdaysandhours.Controls.Add(this.label5);
            this.Addworkingdaysandhours.Controls.Add(this.comboBox3);
            this.Addworkingdaysandhours.Controls.Add(this.comboBox2);
            this.Addworkingdaysandhours.Controls.Add(this.comboBox1);
            this.Addworkingdaysandhours.Controls.Add(this.label4);
            this.Addworkingdaysandhours.Controls.Add(this.label3);
            this.Addworkingdaysandhours.Controls.Add(this.label2);
            this.Addworkingdaysandhours.Controls.Add(this.label1);
            this.Addworkingdaysandhours.Location = new System.Drawing.Point(4, 22);
            this.Addworkingdaysandhours.Name = "Addworkingdaysandhours";
            this.Addworkingdaysandhours.Padding = new System.Windows.Forms.Padding(3);
            this.Addworkingdaysandhours.Size = new System.Drawing.Size(714, 448);
            this.Addworkingdaysandhours.TabIndex = 0;
            this.Addworkingdaysandhours.Text = "Add working days and hours";
            this.Addworkingdaysandhours.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 19;
            // 
            // wdhId
            // 
            this.wdhId.Location = new System.Drawing.Point(260, 75);
            this.wdhId.Name = "wdhId";
            this.wdhId.ReadOnly = true;
            this.wdhId.Size = new System.Drawing.Size(121, 20);
            this.wdhId.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(44, 75);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(346, 316);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 33);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hours";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.comboBox3.Location = new System.Drawing.Point(427, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox2.Location = new System.Drawing.Point(260, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(260, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Working time per day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select working days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select number of work days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add working days and hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Select number of work days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(240, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Add working days and hours";
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(247, 104);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(121, 20);
            this.tId.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(80, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 285);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Addtimeslot
            // 
            this.Addtimeslot.Location = new System.Drawing.Point(247, 334);
            this.Addtimeslot.Name = "Addtimeslot";
            this.Addtimeslot.Size = new System.Drawing.Size(103, 33);
            this.Addtimeslot.TabIndex = 52;
            this.Addtimeslot.Text = "Add time slot";
            this.Addtimeslot.UseVisualStyleBackColor = true;
            this.Addtimeslot.Click += new System.EventHandler(this.Addtimeslot_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "1",
            "0.5"});
            this.comboBox8.Location = new System.Drawing.Point(247, 188);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 41;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox9.Location = new System.Drawing.Point(247, 143);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(80, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Select time slot";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(80, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Select day";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(294, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 21);
            this.label19.TabIndex = 36;
            this.label19.Text = "Add a time slot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select working days";
            // 
            // Manageworkingdaysandhours
            // 
            this.Manageworkingdaysandhours.Controls.Add(this.dataGridView2);
            this.Manageworkingdaysandhours.Controls.Add(this.textBox3);
            this.Manageworkingdaysandhours.Controls.Add(this.textBox1);
            this.Manageworkingdaysandhours.Controls.Add(this.label14);
            this.Manageworkingdaysandhours.Controls.Add(this.Deleteall);
            this.Manageworkingdaysandhours.Controls.Add(this.update1);
            this.Manageworkingdaysandhours.Controls.Add(this.label7);
            this.Manageworkingdaysandhours.Controls.Add(this.label8);
            this.Manageworkingdaysandhours.Controls.Add(this.comboBox4);
            this.Manageworkingdaysandhours.Controls.Add(this.comboBox5);
            this.Manageworkingdaysandhours.Controls.Add(this.comboBox6);
            this.Manageworkingdaysandhours.Controls.Add(this.label9);
            this.Manageworkingdaysandhours.Controls.Add(this.label10);
            this.Manageworkingdaysandhours.Controls.Add(this.label11);
            this.Manageworkingdaysandhours.Controls.Add(this.label12);
            this.Manageworkingdaysandhours.Location = new System.Drawing.Point(4, 22);
            this.Manageworkingdaysandhours.Name = "Manageworkingdaysandhours";
            this.Manageworkingdaysandhours.Padding = new System.Windows.Forms.Padding(3);
            this.Manageworkingdaysandhours.Size = new System.Drawing.Size(714, 448);
            this.Manageworkingdaysandhours.TabIndex = 1;
            this.Manageworkingdaysandhours.Text = "Manage working days and hours";
            this.Manageworkingdaysandhours.UseVisualStyleBackColor = true;
            // 
            // Generatetimetables
            // 
            this.Generatetimetables.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Generatetimetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Generatetimetables.Location = new System.Drawing.Point(3, 492);
            this.Generatetimetables.Name = "Generatetimetables";
            this.Generatetimetables.Size = new System.Drawing.Size(168, 43);
            this.Generatetimetables.TabIndex = 25;
            this.Generatetimetables.Text = "Generate time tables";
            this.Generatetimetables.UseVisualStyleBackColor = false;
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Rooms.Location = new System.Drawing.Point(3, 417);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(168, 43);
            this.Rooms.TabIndex = 23;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = false;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // Sessionsoptions
            // 
            this.Sessionsoptions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Sessionsoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Sessionsoptions.Location = new System.Drawing.Point(3, 378);
            this.Sessionsoptions.Name = "Sessionsoptions";
            this.Sessionsoptions.Size = new System.Drawing.Size(168, 43);
            this.Sessionsoptions.TabIndex = 22;
            this.Sessionsoptions.Text = "Sessions options";
            this.Sessionsoptions.UseVisualStyleBackColor = false;
            this.Sessionsoptions.Click += new System.EventHandler(this.Sessionsoptions_Click);
            // 
            // Sessions
            // 
            this.Sessions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Sessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Sessions.Location = new System.Drawing.Point(3, 338);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(168, 43);
            this.Sessions.TabIndex = 21;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = false;
            this.Sessions.Click += new System.EventHandler(this.Sessions_Click);
            // 
            // Locations
            // 
            this.Locations.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Locations.Location = new System.Drawing.Point(3, 298);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(168, 43);
            this.Locations.TabIndex = 20;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = false;
            this.Locations.Click += new System.EventHandler(this.Locations_Click);
            // 
            // Tags
            // 
            this.Tags.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Tags.Location = new System.Drawing.Point(3, 259);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(168, 43);
            this.Tags.TabIndex = 19;
            this.Tags.Text = "Tags";
            this.Tags.UseVisualStyleBackColor = false;
            this.Tags.Click += new System.EventHandler(this.Tags_Click);
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Students.Location = new System.Drawing.Point(3, 220);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(168, 43);
            this.Students.TabIndex = 18;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Subjects
            // 
            this.Subjects.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Subjects.Location = new System.Drawing.Point(3, 180);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(168, 43);
            this.Subjects.TabIndex = 17;
            this.Subjects.Text = "Subjects";
            this.Subjects.UseVisualStyleBackColor = false;
            this.Subjects.Click += new System.EventHandler(this.Subjects_Click);
            // 
            // Lectures
            // 
            this.Lectures.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Lectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Lectures.Location = new System.Drawing.Point(3, 141);
            this.Lectures.Name = "Lectures";
            this.Lectures.Size = new System.Drawing.Size(168, 43);
            this.Lectures.TabIndex = 16;
            this.Lectures.Text = "Lectures";
            this.Lectures.UseVisualStyleBackColor = false;
            this.Lectures.Click += new System.EventHandler(this.Lectures_Click);
            // 
            // Workdaysandhours
            // 
            this.Workdaysandhours.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Workdaysandhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Workdaysandhours.Location = new System.Drawing.Point(3, 101);
            this.Workdaysandhours.Name = "Workdaysandhours";
            this.Workdaysandhours.Size = new System.Drawing.Size(168, 43);
            this.Workdaysandhours.TabIndex = 15;
            this.Workdaysandhours.Text = "Work days and hours";
            this.Workdaysandhours.UseVisualStyleBackColor = false;
            this.Workdaysandhours.Click += new System.EventHandler(this.Workdaysandhours_Click);
            // 
            // Addtimeslots
            // 
            this.Addtimeslots.Controls.Add(this.tId);
            this.Addtimeslots.Controls.Add(this.label15);
            this.Addtimeslots.Controls.Add(this.dataGridView1);
            this.Addtimeslots.Controls.Add(this.Addtimeslot);
            this.Addtimeslots.Controls.Add(this.comboBox8);
            this.Addtimeslots.Controls.Add(this.comboBox9);
            this.Addtimeslots.Controls.Add(this.label17);
            this.Addtimeslots.Controls.Add(this.label18);
            this.Addtimeslots.Controls.Add(this.label19);
            this.Addtimeslots.Location = new System.Drawing.Point(4, 22);
            this.Addtimeslots.Name = "Addtimeslots";
            this.Addtimeslots.Padding = new System.Windows.Forms.Padding(3);
            this.Addtimeslots.Size = new System.Drawing.Size(714, 448);
            this.Addtimeslots.TabIndex = 2;
            this.Addtimeslots.Text = "Add time slots";
            this.Addtimeslots.UseVisualStyleBackColor = true;
            this.Addtimeslots.Click += new System.EventHandler(this.Addtimeslots_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Addworkingdaysandhours);
            this.tabControl1.Controls.Add(this.Manageworkingdaysandhours);
            this.tabControl1.Controls.Add(this.Addtimeslots);
            this.tabControl1.Location = new System.Drawing.Point(169, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 474);
            this.tabControl1.TabIndex = 26;
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Statistics.Location = new System.Drawing.Point(3, 453);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(168, 43);
            this.Statistics.TabIndex = 24;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Home.Location = new System.Drawing.Point(3, 61);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(168, 43);
            this.Home.TabIndex = 14;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // workDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 536);
            this.Controls.Add(this.Generatetimetables);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Sessionsoptions);
            this.Controls.Add(this.Sessions);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.Lectures);
            this.Controls.Add(this.Workdaysandhours);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.Home);
            this.Name = "workDH";
            this.Text = "workDH";
            this.Load += new System.EventHandler(this.workDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Addworkingdaysandhours.ResumeLayout(false);
            this.Addworkingdaysandhours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Manageworkingdaysandhours.ResumeLayout(false);
            this.Manageworkingdaysandhours.PerformLayout();
            this.Addtimeslots.ResumeLayout(false);
            this.Addtimeslots.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Deleteall;
        private System.Windows.Forms.Button update1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Addworkingdaysandhours;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox wdhId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addtimeslot;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage Manageworkingdaysandhours;
        private System.Windows.Forms.Button Generatetimetables;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.Button Sessionsoptions;
        private System.Windows.Forms.Button Sessions;
        private System.Windows.Forms.Button Locations;
        private System.Windows.Forms.Button Tags;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Subjects;
        private System.Windows.Forms.Button Lectures;
        private System.Windows.Forms.Button Workdaysandhours;
        private System.Windows.Forms.TabPage Addtimeslots;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Home;
    }
}