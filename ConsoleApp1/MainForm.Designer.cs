namespace ConsoleApp1
{
    partial class MainForm
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
            this.btAddTeacher = new System.Windows.Forms.Button();
            this.btAddCourse = new System.Windows.Forms.Button();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btMakeSchedule = new System.Windows.Forms.Button();
            this.btSeeSchedule = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbAddTeacher = new System.Windows.Forms.GroupBox();
            this.tbInstructorName = new System.Windows.Forms.TextBox();
            this.lblInstructorName = new System.Windows.Forms.Label();
            this.btInsertTeacher = new System.Windows.Forms.Button();
            this.gbAddCourse = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.lblInstructorNameAC = new System.Windows.Forms.Label();
            this.btAddCourseAC = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cbIntructorName = new System.Windows.Forms.ComboBox();
            this.gbAddStudent = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.btAddStudentAS = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblSelectCourseAS = new System.Windows.Forms.Label();
            this.CBSelectCourse = new System.Windows.Forms.ComboBox();
            this.gbMakeSchedule = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbInstructorNameMS = new System.Windows.Forms.TextBox();
            this.lblInstructorNameMS = new System.Windows.Forms.Label();
            this.btMakeScheduleMS = new System.Windows.Forms.Button();
            this.lblCourseNameMS = new System.Windows.Forms.Label();
            this.cbCourseName = new System.Windows.Forms.ComboBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbAddTeacher.SuspendLayout();
            this.gbAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbMakeSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Location = new System.Drawing.Point(24, 94);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(177, 39);
            this.btAddTeacher.TabIndex = 0;
            this.btAddTeacher.Text = "Add Teacher";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // btAddCourse
            // 
            this.btAddCourse.Location = new System.Drawing.Point(24, 145);
            this.btAddCourse.Name = "btAddCourse";
            this.btAddCourse.Size = new System.Drawing.Size(177, 39);
            this.btAddCourse.TabIndex = 1;
            this.btAddCourse.Text = "Add Course";
            this.btAddCourse.UseVisualStyleBackColor = true;
            this.btAddCourse.Click += new System.EventHandler(this.btAddCourse_Click);
            // 
            // btAddStudent
            // 
            this.btAddStudent.Location = new System.Drawing.Point(24, 195);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(177, 39);
            this.btAddStudent.TabIndex = 2;
            this.btAddStudent.Text = "Add Student";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // btMakeSchedule
            // 
            this.btMakeSchedule.Location = new System.Drawing.Point(24, 240);
            this.btMakeSchedule.Name = "btMakeSchedule";
            this.btMakeSchedule.Size = new System.Drawing.Size(177, 39);
            this.btMakeSchedule.TabIndex = 3;
            this.btMakeSchedule.Text = "Make Schedule";
            this.btMakeSchedule.UseVisualStyleBackColor = true;
            this.btMakeSchedule.Click += new System.EventHandler(this.btMakeSchedule_Click);
            // 
            // btSeeSchedule
            // 
            this.btSeeSchedule.Location = new System.Drawing.Point(24, 285);
            this.btSeeSchedule.Name = "btSeeSchedule";
            this.btSeeSchedule.Size = new System.Drawing.Size(177, 39);
            this.btSeeSchedule.TabIndex = 4;
            this.btSeeSchedule.Text = "See Schedule";
            this.btSeeSchedule.UseVisualStyleBackColor = true;
            this.btSeeSchedule.Click += new System.EventHandler(this.btSeeSchedule_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(24, 330);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(177, 39);
            this.btLogout.TabIndex = 5;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(24, 375);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(177, 39);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // gbAddTeacher
            // 
            this.gbAddTeacher.Controls.Add(this.tbInstructorName);
            this.gbAddTeacher.Controls.Add(this.lblInstructorName);
            this.gbAddTeacher.Controls.Add(this.btInsertTeacher);
            this.gbAddTeacher.Location = new System.Drawing.Point(207, 18);
            this.gbAddTeacher.Name = "gbAddTeacher";
            this.gbAddTeacher.Size = new System.Drawing.Size(79, 51);
            this.gbAddTeacher.TabIndex = 7;
            this.gbAddTeacher.TabStop = false;
            this.gbAddTeacher.Text = "Add Teacher";
            this.gbAddTeacher.Visible = false;
            // 
            // tbInstructorName
            // 
            this.tbInstructorName.BackColor = System.Drawing.Color.White;
            this.tbInstructorName.ForeColor = System.Drawing.Color.Black;
            this.tbInstructorName.Location = new System.Drawing.Point(142, 61);
            this.tbInstructorName.Name = "tbInstructorName";
            this.tbInstructorName.Size = new System.Drawing.Size(215, 20);
            this.tbInstructorName.TabIndex = 15;
            // 
            // lblInstructorName
            // 
            this.lblInstructorName.AutoSize = true;
            this.lblInstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorName.Location = new System.Drawing.Point(19, 64);
            this.lblInstructorName.Name = "lblInstructorName";
            this.lblInstructorName.Size = new System.Drawing.Size(117, 15);
            this.lblInstructorName.TabIndex = 14;
            this.lblInstructorName.Text = "Instructor Name :";
            // 
            // btInsertTeacher
            // 
            this.btInsertTeacher.BackColor = System.Drawing.Color.White;
            this.btInsertTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsertTeacher.Location = new System.Drawing.Point(161, 125);
            this.btInsertTeacher.Name = "btInsertTeacher";
            this.btInsertTeacher.Size = new System.Drawing.Size(136, 43);
            this.btInsertTeacher.TabIndex = 12;
            this.btInsertTeacher.Text = "Insert Teacher";
            this.btInsertTeacher.UseVisualStyleBackColor = false;
            this.btInsertTeacher.Click += new System.EventHandler(this.btInsertTeacher_Click);
            // 
            // gbAddCourse
            // 
            this.gbAddCourse.Controls.Add(this.dataGridView1);
            this.gbAddCourse.Controls.Add(this.tbCourseName);
            this.gbAddCourse.Controls.Add(this.lblInstructorNameAC);
            this.gbAddCourse.Controls.Add(this.btAddCourseAC);
            this.gbAddCourse.Controls.Add(this.lblCourseName);
            this.gbAddCourse.Controls.Add(this.cbIntructorName);
            this.gbAddCourse.Location = new System.Drawing.Point(436, 12);
            this.gbAddCourse.Name = "gbAddCourse";
            this.gbAddCourse.Size = new System.Drawing.Size(64, 74);
            this.gbAddCourse.TabIndex = 16;
            this.gbAddCourse.TabStop = false;
            this.gbAddCourse.Text = "Add Course";
            this.gbAddCourse.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(29, 16);
            this.dataGridView1.TabIndex = 16;
            // 
            // tbCourseName
            // 
            this.tbCourseName.BackColor = System.Drawing.Color.White;
            this.tbCourseName.ForeColor = System.Drawing.Color.Black;
            this.tbCourseName.Location = new System.Drawing.Point(129, 49);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(215, 20);
            this.tbCourseName.TabIndex = 15;
            // 
            // lblInstructorNameAC
            // 
            this.lblInstructorNameAC.AutoSize = true;
            this.lblInstructorNameAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorNameAC.Location = new System.Drawing.Point(6, 114);
            this.lblInstructorNameAC.Name = "lblInstructorNameAC";
            this.lblInstructorNameAC.Size = new System.Drawing.Size(117, 15);
            this.lblInstructorNameAC.TabIndex = 14;
            this.lblInstructorNameAC.Text = "Instructor Name :";
            // 
            // btAddCourseAC
            // 
            this.btAddCourseAC.BackColor = System.Drawing.Color.White;
            this.btAddCourseAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCourseAC.Location = new System.Drawing.Point(356, 64);
            this.btAddCourseAC.Name = "btAddCourseAC";
            this.btAddCourseAC.Size = new System.Drawing.Size(87, 43);
            this.btAddCourseAC.TabIndex = 12;
            this.btAddCourseAC.Text = "Add Course";
            this.btAddCourseAC.UseVisualStyleBackColor = false;
            this.btAddCourseAC.Click += new System.EventHandler(this.btAddCourseAC_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(16, 50);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(94, 15);
            this.lblCourseName.TabIndex = 13;
            this.lblCourseName.Text = "Course Name";
            // 
            // cbIntructorName
            // 
            this.cbIntructorName.AllowDrop = true;
            this.cbIntructorName.BackColor = System.Drawing.Color.White;
            this.cbIntructorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntructorName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbIntructorName.ForeColor = System.Drawing.Color.Black;
            this.cbIntructorName.FormattingEnabled = true;
            this.cbIntructorName.Location = new System.Drawing.Point(129, 113);
            this.cbIntructorName.Name = "cbIntructorName";
            this.cbIntructorName.Size = new System.Drawing.Size(217, 21);
            this.cbIntructorName.TabIndex = 11;
            // 
            // gbAddStudent
            // 
            this.gbAddStudent.Controls.Add(this.dataGridView2);
            this.gbAddStudent.Controls.Add(this.tbStudentID);
            this.gbAddStudent.Controls.Add(this.btAddStudentAS);
            this.gbAddStudent.Controls.Add(this.lblStudentID);
            this.gbAddStudent.Controls.Add(this.lblSelectCourseAS);
            this.gbAddStudent.Controls.Add(this.CBSelectCourse);
            this.gbAddStudent.Location = new System.Drawing.Point(28, 18);
            this.gbAddStudent.Name = "gbAddStudent";
            this.gbAddStudent.Size = new System.Drawing.Size(88, 51);
            this.gbAddStudent.TabIndex = 17;
            this.gbAddStudent.TabStop = false;
            this.gbAddStudent.Text = "Add Student";
            this.gbAddStudent.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(207, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(41, 17);
            this.dataGridView2.TabIndex = 16;
            // 
            // tbStudentID
            // 
            this.tbStudentID.BackColor = System.Drawing.Color.White;
            this.tbStudentID.ForeColor = System.Drawing.Color.Black;
            this.tbStudentID.Location = new System.Drawing.Point(137, 115);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(215, 20);
            this.tbStudentID.TabIndex = 15;
            // 
            // btAddStudentAS
            // 
            this.btAddStudentAS.BackColor = System.Drawing.Color.White;
            this.btAddStudentAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddStudentAS.Location = new System.Drawing.Point(358, 74);
            this.btAddStudentAS.Name = "btAddStudentAS";
            this.btAddStudentAS.Size = new System.Drawing.Size(88, 43);
            this.btAddStudentAS.TabIndex = 12;
            this.btAddStudentAS.Text = "Add Student";
            this.btAddStudentAS.UseVisualStyleBackColor = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(21, 115);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(74, 15);
            this.lblStudentID.TabIndex = 14;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblSelectCourseAS
            // 
            this.lblSelectCourseAS.AutoSize = true;
            this.lblSelectCourseAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourseAS.Location = new System.Drawing.Point(39, 49);
            this.lblSelectCourseAS.Name = "lblSelectCourseAS";
            this.lblSelectCourseAS.Size = new System.Drawing.Size(96, 15);
            this.lblSelectCourseAS.TabIndex = 13;
            this.lblSelectCourseAS.Text = "Select Course";
            // 
            // CBSelectCourse
            // 
            this.CBSelectCourse.AllowDrop = true;
            this.CBSelectCourse.BackColor = System.Drawing.Color.White;
            this.CBSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSelectCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBSelectCourse.ForeColor = System.Drawing.Color.Black;
            this.CBSelectCourse.FormattingEnabled = true;
            this.CBSelectCourse.Location = new System.Drawing.Point(139, 47);
            this.CBSelectCourse.Name = "CBSelectCourse";
            this.CBSelectCourse.Size = new System.Drawing.Size(217, 21);
            this.CBSelectCourse.TabIndex = 11;
            // 
            // gbMakeSchedule
            // 
            this.gbMakeSchedule.Controls.Add(this.dataGridView5);
            this.gbMakeSchedule.Controls.Add(this.dataGridView4);
            this.gbMakeSchedule.Controls.Add(this.dataGridView3);
            this.gbMakeSchedule.Controls.Add(this.tbInstructorNameMS);
            this.gbMakeSchedule.Controls.Add(this.lblInstructorNameMS);
            this.gbMakeSchedule.Controls.Add(this.btMakeScheduleMS);
            this.gbMakeSchedule.Controls.Add(this.lblCourseNameMS);
            this.gbMakeSchedule.Controls.Add(this.cbCourseName);
            this.gbMakeSchedule.Location = new System.Drawing.Point(372, 228);
            this.gbMakeSchedule.Name = "gbMakeSchedule";
            this.gbMakeSchedule.Size = new System.Drawing.Size(467, 226);
            this.gbMakeSchedule.TabIndex = 17;
            this.gbMakeSchedule.TabStop = false;
            this.gbMakeSchedule.Text = "Make Schedule";
            this.gbMakeSchedule.Visible = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(339, 165);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(49, 32);
            this.dataGridView5.TabIndex = 18;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(193, 165);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(49, 32);
            this.dataGridView4.TabIndex = 17;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(38, 165);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(49, 32);
            this.dataGridView3.TabIndex = 16;
            // 
            // tbInstructorNameMS
            // 
            this.tbInstructorNameMS.BackColor = System.Drawing.Color.White;
            this.tbInstructorNameMS.ForeColor = System.Drawing.Color.Black;
            this.tbInstructorNameMS.Location = new System.Drawing.Point(131, 112);
            this.tbInstructorNameMS.Name = "tbInstructorNameMS";
            this.tbInstructorNameMS.ReadOnly = true;
            this.tbInstructorNameMS.Size = new System.Drawing.Size(202, 20);
            this.tbInstructorNameMS.TabIndex = 15;
            // 
            // lblInstructorNameMS
            // 
            this.lblInstructorNameMS.AutoSize = true;
            this.lblInstructorNameMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorNameMS.Location = new System.Drawing.Point(11, 115);
            this.lblInstructorNameMS.Name = "lblInstructorNameMS";
            this.lblInstructorNameMS.Size = new System.Drawing.Size(117, 15);
            this.lblInstructorNameMS.TabIndex = 14;
            this.lblInstructorNameMS.Text = "Instructor Name :";
            // 
            // btMakeScheduleMS
            // 
            this.btMakeScheduleMS.BackColor = System.Drawing.Color.White;
            this.btMakeScheduleMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMakeScheduleMS.Location = new System.Drawing.Point(359, 73);
            this.btMakeScheduleMS.Name = "btMakeScheduleMS";
            this.btMakeScheduleMS.Size = new System.Drawing.Size(85, 43);
            this.btMakeScheduleMS.TabIndex = 12;
            this.btMakeScheduleMS.Text = "Make Schedule";
            this.btMakeScheduleMS.UseVisualStyleBackColor = false;
            this.btMakeScheduleMS.Click += new System.EventHandler(this.btMakeScheduleMS_Click);
            // 
            // lblCourseNameMS
            // 
            this.lblCourseNameMS.AutoSize = true;
            this.lblCourseNameMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNameMS.Location = new System.Drawing.Point(16, 49);
            this.lblCourseNameMS.Name = "lblCourseNameMS";
            this.lblCourseNameMS.Size = new System.Drawing.Size(94, 15);
            this.lblCourseNameMS.TabIndex = 13;
            this.lblCourseNameMS.Text = "Course Name";
            // 
            // cbCourseName
            // 
            this.cbCourseName.AllowDrop = true;
            this.cbCourseName.BackColor = System.Drawing.Color.White;
            this.cbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCourseName.ForeColor = System.Drawing.Color.Black;
            this.cbCourseName.FormattingEnabled = true;
            this.cbCourseName.Location = new System.Drawing.Point(131, 48);
            this.cbCourseName.Name = "cbCourseName";
            this.cbCourseName.Size = new System.Drawing.Size(202, 21);
            this.cbCourseName.TabIndex = 11;
            this.cbCourseName.SelectedIndexChanged += new System.EventHandler(this.cbCourseName_SelectedIndexChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(317, 105);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(401, 37);
            this.lblHeading.TabIndex = 18;
            this.lblHeading.Text = "Class Scheduling System";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gbMakeSchedule);
            this.Controls.Add(this.gbAddStudent);
            this.Controls.Add(this.gbAddCourse);
            this.Controls.Add(this.gbAddTeacher);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btSeeSchedule);
            this.Controls.Add(this.btMakeSchedule);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.btAddCourse);
            this.Controls.Add(this.btAddTeacher);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbAddTeacher.ResumeLayout(false);
            this.gbAddTeacher.PerformLayout();
            this.gbAddCourse.ResumeLayout(false);
            this.gbAddCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAddStudent.ResumeLayout(false);
            this.gbAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbMakeSchedule.ResumeLayout(false);
            this.gbMakeSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddTeacher;
        private System.Windows.Forms.Button btAddCourse;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btMakeSchedule;
        private System.Windows.Forms.Button btSeeSchedule;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox gbAddTeacher;
        private System.Windows.Forms.TextBox tbInstructorName;
        private System.Windows.Forms.Label lblInstructorName;
        private System.Windows.Forms.Button btInsertTeacher;
        private System.Windows.Forms.GroupBox gbAddCourse;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label lblInstructorNameAC;
        private System.Windows.Forms.Button btAddCourseAC;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cbIntructorName;
        private System.Windows.Forms.GroupBox gbAddStudent;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btAddStudentAS;
        private System.Windows.Forms.Label lblSelectCourseAS;
        private System.Windows.Forms.ComboBox CBSelectCourse;
        private System.Windows.Forms.GroupBox gbMakeSchedule;
        private System.Windows.Forms.TextBox tbInstructorNameMS;
        private System.Windows.Forms.Label lblInstructorNameMS;
        private System.Windows.Forms.Button btMakeScheduleMS;
        private System.Windows.Forms.Label lblCourseNameMS;
        private System.Windows.Forms.ComboBox cbCourseName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}