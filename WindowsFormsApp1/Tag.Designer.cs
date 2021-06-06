
namespace WindowsFormsApp1
{
    partial class Tag
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
            this.Lectures = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Tags = new System.Windows.Forms.Button();
            this.Locations = new System.Windows.Forms.Button();
            this.Sessions = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.tagCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateEDT = new System.Windows.Forms.Button();
            this.DelEDT = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tagname = new System.Windows.Forms.TextBox();
            this.AYS = new System.Windows.Forms.Label();
            this.manstgt = new System.Windows.Forms.Label();
            this.Genarate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PROM = new System.Windows.Forms.Label();
            this.savetag = new System.Windows.Forms.Button();
            this.yearsem = new System.Windows.Forms.TextBox();
            this.gId = new System.Windows.Forms.TextBox();
            this.GroID = new System.Windows.Forms.Label();
            this.academicyearsem = new System.Windows.Forms.Label();
            this.Addstg = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Addtag = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Addtag.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lectures
            // 
            this.Lectures.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Lectures.Location = new System.Drawing.Point(2, 130);
            this.Lectures.Margin = new System.Windows.Forms.Padding(2);
            this.Lectures.Name = "Lectures";
            this.Lectures.Size = new System.Drawing.Size(140, 50);
            this.Lectures.TabIndex = 39;
            this.Lectures.Text = "Lectures";
            this.Lectures.UseVisualStyleBackColor = false;
            this.Lectures.Click += new System.EventHandler(this.Lectures_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button10.Location = new System.Drawing.Point(2, 178);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 50);
            this.button10.TabIndex = 38;
            this.button10.Text = "Subjects";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Students.Location = new System.Drawing.Point(2, 226);
            this.Students.Margin = new System.Windows.Forms.Padding(2);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(140, 50);
            this.Students.TabIndex = 37;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Tags
            // 
            this.Tags.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Tags.Location = new System.Drawing.Point(2, 272);
            this.Tags.Margin = new System.Windows.Forms.Padding(2);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(140, 50);
            this.Tags.TabIndex = 36;
            this.Tags.Text = "Tags";
            this.Tags.UseVisualStyleBackColor = false;
            this.Tags.Click += new System.EventHandler(this.Tags_Click);
            // 
            // Locations
            // 
            this.Locations.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Locations.Location = new System.Drawing.Point(2, 319);
            this.Locations.Margin = new System.Windows.Forms.Padding(2);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(140, 50);
            this.Locations.TabIndex = 35;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = false;
            this.Locations.Click += new System.EventHandler(this.Locations_Click);
            // 
            // Sessions
            // 
            this.Sessions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Sessions.Location = new System.Drawing.Point(2, 365);
            this.Sessions.Margin = new System.Windows.Forms.Padding(2);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(140, 50);
            this.Sessions.TabIndex = 34;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = false;
            this.Sessions.Click += new System.EventHandler(this.Sessions_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(2, 411);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 50);
            this.button5.TabIndex = 33;
            this.button5.Text = "Sessions options";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Rooms.Location = new System.Drawing.Point(2, 455);
            this.Rooms.Margin = new System.Windows.Forms.Padding(2);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(140, 50);
            this.Rooms.TabIndex = 32;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = false;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Statistics.Location = new System.Drawing.Point(2, 499);
            this.Statistics.Margin = new System.Windows.Forms.Padding(2);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(140, 50);
            this.Statistics.TabIndex = 31;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Home.Location = new System.Drawing.Point(2, 36);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(140, 50);
            this.Home.TabIndex = 29;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // tagCode
            // 
            this.tagCode.Location = new System.Drawing.Point(193, 309);
            this.tagCode.Margin = new System.Windows.Forms.Padding(2);
            this.tagCode.Name = "tagCode";
            this.tagCode.Size = new System.Drawing.Size(141, 20);
            this.tagCode.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 174);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // updateEDT
            // 
            this.updateEDT.Location = new System.Drawing.Point(509, 104);
            this.updateEDT.Margin = new System.Windows.Forms.Padding(2);
            this.updateEDT.Name = "updateEDT";
            this.updateEDT.Size = new System.Drawing.Size(72, 34);
            this.updateEDT.TabIndex = 31;
            this.updateEDT.Text = "Update";
            this.updateEDT.UseVisualStyleBackColor = true;
            this.updateEDT.Click += new System.EventHandler(this.updateEDT_Click);
            // 
            // DelEDT
            // 
            this.DelEDT.Location = new System.Drawing.Point(509, 184);
            this.DelEDT.Margin = new System.Windows.Forms.Padding(2);
            this.DelEDT.Name = "DelEDT";
            this.DelEDT.Size = new System.Drawing.Size(74, 36);
            this.DelEDT.TabIndex = 30;
            this.DelEDT.Text = "Delete";
            this.DelEDT.UseVisualStyleBackColor = true;
            this.DelEDT.Click += new System.EventHandler(this.DelEDT_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button12.Location = new System.Drawing.Point(2, 82);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(140, 50);
            this.button12.TabIndex = 40;
            this.button12.Text = "Work days and hours";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tagname
            // 
            this.tagname.Location = new System.Drawing.Point(193, 351);
            this.tagname.Margin = new System.Windows.Forms.Padding(2);
            this.tagname.Name = "tagname";
            this.tagname.Size = new System.Drawing.Size(141, 20);
            this.tagname.TabIndex = 25;
            // 
            // AYS
            // 
            this.AYS.AutoSize = true;
            this.AYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AYS.Location = new System.Drawing.Point(39, 355);
            this.AYS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AYS.Name = "AYS";
            this.AYS.Size = new System.Drawing.Size(65, 13);
            this.AYS.TabIndex = 18;
            this.AYS.Text = "Tag Name";
            // 
            // manstgt
            // 
            this.manstgt.AutoSize = true;
            this.manstgt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manstgt.Location = new System.Drawing.Point(212, 37);
            this.manstgt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manstgt.Name = "manstgt";
            this.manstgt.Size = new System.Drawing.Size(110, 21);
            this.manstgt.TabIndex = 17;
            this.manstgt.Text = "Manage Tags";
            // 
            // Genarate
            // 
            this.Genarate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Genarate.Location = new System.Drawing.Point(2, 541);
            this.Genarate.Margin = new System.Windows.Forms.Padding(2);
            this.Genarate.Name = "Genarate";
            this.Genarate.Size = new System.Drawing.Size(140, 60);
            this.Genarate.TabIndex = 30;
            this.Genarate.Text = "Generate timetables";
            this.Genarate.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tagCode);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.updateEDT);
            this.tabPage2.Controls.Add(this.DelEDT);
            this.tabPage2.Controls.Add(this.tagname);
            this.tabPage2.Controls.Add(this.PROM);
            this.tabPage2.Controls.Add(this.AYS);
            this.tabPage2.Controls.Add(this.manstgt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(696, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Tag";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PROM
            // 
            this.PROM.AutoSize = true;
            this.PROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROM.Location = new System.Drawing.Point(39, 313);
            this.PROM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PROM.Name = "PROM";
            this.PROM.Size = new System.Drawing.Size(62, 13);
            this.PROM.TabIndex = 23;
            this.PROM.Text = "Tag Code";
            // 
            // savetag
            // 
            this.savetag.Location = new System.Drawing.Point(242, 317);
            this.savetag.Margin = new System.Windows.Forms.Padding(2);
            this.savetag.Name = "savetag";
            this.savetag.Size = new System.Drawing.Size(72, 34);
            this.savetag.TabIndex = 16;
            this.savetag.Text = "Save";
            this.savetag.UseVisualStyleBackColor = true;
            this.savetag.Click += new System.EventHandler(this.savetag_Click);
            // 
            // yearsem
            // 
            this.yearsem.Location = new System.Drawing.Point(257, 170);
            this.yearsem.Margin = new System.Windows.Forms.Padding(2);
            this.yearsem.Name = "yearsem";
            this.yearsem.Size = new System.Drawing.Size(141, 20);
            this.yearsem.TabIndex = 10;
            // 
            // gId
            // 
            this.gId.Location = new System.Drawing.Point(257, 106);
            this.gId.Margin = new System.Windows.Forms.Padding(2);
            this.gId.Name = "gId";
            this.gId.Size = new System.Drawing.Size(138, 20);
            this.gId.TabIndex = 9;
            // 
            // GroID
            // 
            this.GroID.AutoSize = true;
            this.GroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroID.Location = new System.Drawing.Point(69, 109);
            this.GroID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroID.Name = "GroID";
            this.GroID.Size = new System.Drawing.Size(62, 13);
            this.GroID.TabIndex = 5;
            this.GroID.Text = "Tag Code";
            // 
            // academicyearsem
            // 
            this.academicyearsem.AutoSize = true;
            this.academicyearsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicyearsem.Location = new System.Drawing.Point(65, 172);
            this.academicyearsem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.academicyearsem.Name = "academicyearsem";
            this.academicyearsem.Size = new System.Drawing.Size(65, 13);
            this.academicyearsem.TabIndex = 1;
            this.academicyearsem.Text = "Tag Name";
            // 
            // Addstg
            // 
            this.Addstg.AutoSize = true;
            this.Addstg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addstg.Location = new System.Drawing.Point(263, 26);
            this.Addstg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addstg.Name = "Addstg";
            this.Addstg.Size = new System.Drawing.Size(72, 21);
            this.Addstg.TabIndex = 0;
            this.Addstg.Text = "Add Tag";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.savetag);
            this.tabPage1.Controls.Add(this.yearsem);
            this.tabPage1.Controls.Add(this.gId);
            this.tabPage1.Controls.Add(this.GroID);
            this.tabPage1.Controls.Add(this.academicyearsem);
            this.tabPage1.Controls.Add(this.Addstg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(696, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Tag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Addtag
            // 
            this.Addtag.Controls.Add(this.tabPage1);
            this.Addtag.Controls.Add(this.tabPage2);
            this.Addtag.Location = new System.Drawing.Point(139, 36);
            this.Addtag.Margin = new System.Windows.Forms.Padding(2);
            this.Addtag.Name = "Addtag";
            this.Addtag.SelectedIndex = 0;
            this.Addtag.Size = new System.Drawing.Size(704, 566);
            this.Addtag.TabIndex = 41;
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 603);
            this.Controls.Add(this.Lectures);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.Sessions);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Genarate);
            this.Controls.Add(this.Addtag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tag";
            this.Text = "Tag";
            this.Load += new System.EventHandler(this.Tag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Addtag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lectures;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Tags;
        private System.Windows.Forms.Button Locations;
        private System.Windows.Forms.Button Sessions;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox tagCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateEDT;
        private System.Windows.Forms.Button DelEDT;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox tagname;
        private System.Windows.Forms.Label AYS;
        private System.Windows.Forms.Label manstgt;
        private System.Windows.Forms.Button Genarate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label PROM;
        private System.Windows.Forms.Button savetag;
        private System.Windows.Forms.TextBox yearsem;
        private System.Windows.Forms.TextBox gId;
        private System.Windows.Forms.Label GroID;
        private System.Windows.Forms.Label academicyearsem;
        private System.Windows.Forms.Label Addstg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Addtag;
    }
}