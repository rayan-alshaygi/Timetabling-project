﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class MainForm : Form
    {
        FormDbData c = new FormDbData();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            gbAddCourse.Visible = false;
            gbAddStudent.Visible = false;
            gbMakeSchedule.Visible = false;
            gbAddTeacher.Visible = true;
            gbAddTeacher.Location = new Point(391, 222);
            gbAddTeacher.Size = new System.Drawing.Size(467, 181);
            tbInstructorName.Text = "";

        }

        private void btAddCourse_Click(object sender, EventArgs e)
        {
            gbAddCourse.Visible = true;
            gbAddStudent.Visible = false;
            gbMakeSchedule.Visible = false;
            gbAddTeacher.Visible = false;
            gbAddCourse.Location = new Point(391, 222);
            gbAddCourse.Size = new System.Drawing.Size(467, 181);
            tbInstructorName.Text = "";
            cbIntructorName.Items.Clear();
            DataTable dt = c.ComboInstructorName();
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int index = 0; index < dataGridView1.Rows.Count - 1; index++)
                {
                    cbIntructorName.Items.Add(dataGridView1.Rows[index].Cells[0].Value);
                }
            }
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            gbAddCourse.Visible = false;
            gbAddStudent.Visible = true;
            gbMakeSchedule.Visible = false;
            gbAddTeacher.Visible = false;
            gbAddStudent.Location = new Point(391, 222);
            gbAddStudent.Size = new System.Drawing.Size(467, 181);
            tbStudentID.Text = "";
            CBSelectCourse.Items.Clear();
            DataTable dt =c.ComboCourseName();
            dataGridView2.DataSource = dt;
            if (dataGridView2.Rows.Count > 0)
            {
                for (int index = 0; index < dataGridView2.Rows.Count - 1; index++)
                {
                    CBSelectCourse.Items.Add(dataGridView2.Rows[index].Cells[0].Value);
                }
            }
        }

        private void btMakeSchedule_Click(object sender, EventArgs e)
        {
            gbAddCourse.Visible = false;
            gbAddStudent.Visible = false;
            gbMakeSchedule.Visible = true;
            gbAddTeacher.Visible = false;
            gbMakeSchedule.Location = new Point(391, 222);
            gbMakeSchedule.Size = new System.Drawing.Size(467, 181);
            cbCourseName.Items.Clear();
            DataTable dt = c.ComboCourseName();
            dataGridView4.DataSource = dt;
            if (dataGridView4.Rows.Count > 0)
            {
                for (int index = 0; index < dataGridView4.Rows.Count - 1; index++)
                {
                    cbCourseName.Items.Add(dataGridView4.Rows[index].Cells[0].Value);
                }
            }
            //DataTable dt1 = Counts.RandomNumberList();
            //dataGridView5.DataSource = dt1;

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btInsertTeacher_Click(object sender, EventArgs e)
        {

            string InstructorName = tbInstructorName.Text;
            int val = c.InsertInstructor(InstructorName);
            if (val > 0)
            {
                tbInstructorName.Text = "";
            }
        }

        private void btAddCourseAC_Click(object sender, EventArgs e)
        {
            string CoursName = tbCourseName.Text;
            string InstructorName = cbIntructorName.Text;
            //int val = c.InsertCourse(CoursName, InstructorName);
            //if (val > 0)
            //{
            //    tbCourseName.Text = "";
            //}

        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CourseName = cbCourseName.Text;
            DataTable dt = c.InstructorName(CourseName);
            dataGridView3.DataSource = dt;
            if (dataGridView3.Rows.Count > 0)
            {
                tbInstructorNameMS.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
            }

        }

        private void btMakeScheduleMS_Click(object sender, EventArgs e)
        {
            //List<string> RandomNumberList = new List<string>();
            //DataTable dt = Counts.RandomNumberList();
            //dataGridView5.DataSource = dt;
            //if (dataGridView5.Rows.Count > 0)
            //{
            //    for (int index = 0; index < dataGridView5.Rows.Count - 1; index++)
            //    {
            //        RandomNumberList.Add(dataGridView5.Rows[index].Cells[0].Value.ToString());

            //    }
            //}
            //goto a;
            //a:
            //bool inList = false; ;
            //Random RandomRow = new Random();
            //Random RandomColumn = new Random();
            //int intRow = RandomRow.Next(0, 5);
            //int intColumn = RandomColumn.Next(0, 3);
            //string CombineNumber = intRow.ToString() + intColumn.ToString();
            //for (int index = 0; index < RandomNumberList.Count - 1; index++)
            //{
            //    if (CombineNumber == RandomNumberList[index])
            //    {
            //        inList = true;
            //    }
            //}
            //if (inList == true)
            //{
            //    goto a;
            //}
            //else if (inList == false)
            //{
            //    string CourseName = cbCourseName.Text;
            //    string InstructorName = tbInstructorNameMS.Text;
            //    int val = Counts.UpdateCourseRowColumn(CourseName, InstructorName, intRow.ToString(), intColumn.ToString());
            //    int val2 = Counts.insertRandom(CombineNumber);

            //}

        }

        private void btSeeSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule sc = new Schedule();
            //sc.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
