using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.TimetableDBDataSetTableAdapters;

namespace ConsoleApp1
{
    class FormDbData
    {
        TimetableDBDataSet timetableDBDS = new TimetableDBDataSet();
        InstructorsTableAdapter ins = new InstructorsTableAdapter();
        CurriculumTableAdapter cur = new CurriculumTableAdapter();
        RoomsTableAdapter room = new RoomsTableAdapter();
        CourseClassTableAdapter cc = new CourseClassTableAdapter();
        CoursesTableAdapter courses = new CoursesTableAdapter();

        public int InsertInstructor(string InstructorName)
        {
            int val;
            return val = ins.InsertInstructor(InstructorName);
        }
        public void InsertCourse(string name, int ns, int duration, bool lab, String Instructor, String Course)
        {
            DataTable s = ins.GetId(Instructor);
            int instructorId = Int32.Parse(s.ToString());
            DataTable x = courses.GetId(Instructor);
            int cid = Int32.Parse(x.ToString());
            cc.InsertQuery(name, ns, duration, lab, instructorId, cid);
        }


        public DataTable ComboInstructorName()
        {
            DataTable dt = ins.GetDataName();
            return dt;
        }
        public DataTable ComboCourseName()
        {
            //string Query = "Select CourseName from CourseTable where ScheduleRow is null and ScheduleColumn is null";
            //SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = cc.GetCoursesNames();
            return dt;
        }
        public DataTable InstructorName(string CourseName)
        {
            DataTable dt = cc.GetClassInstructorName(CourseName);
            return dt;
        }
        //public static DataTable CourseTable()
        //{
        //    string Query = "Select CourseName,InstructorName,ScheduleRow,ScheduleColumn from CourseTable";
        //    SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sds = new SqlDataAdapter(sc);
        //    sds.Fill(dt);
        //    return dt;
        //}

        //Returns pointer to Instructor with specified ID
        // If there is no Instructor with such ID method returns NULL
        public string GetInstructorNameById(int id)
        {
            DataTable name = ins.GetDataById(id);
            return name.ToString();
        }

    }
}
