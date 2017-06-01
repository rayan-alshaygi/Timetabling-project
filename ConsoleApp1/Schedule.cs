using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Schedule
    {

        // Time-space slots, one entry represent one hour in one classroom

        private List<LinkedList<CourseClass>> _slots = new List<LinkedList<CourseClass>>();
        // Class table for chromosome
        // Used to determine first time-space slot used by class
        private Dictionary<CourseClass, int> _classes = new Dictionary<CourseClass, int>();
        public Schedule()
        {
            _slots.Resize(DefineConstants.DAYS_NUM * DefineConstants.DAY_HOURS * Counts.GetInstance().GetNumberOfRooms());


        }
        public void Algorithm()
        {
            // in another class
            // number of time-space slots
            int size = (int)_slots.Count;
            // place classes at random position
            LinkedList<CourseClass> c = Counts.GetInstance().GetCourseClasses();
            for (LinkedList<CourseClass>.Enumerator it = c.GetEnumerator(); it.MoveNext();)
            {
                // determine random position of class
                int nr = Counts.GetInstance().GetNumberOfRooms();
                int dur = it.Current.GetDuration();
                int day = RandomNumbers.NextNumber() % DefineConstants.DAYS_NUM;
                int room = RandomNumbers.NextNumber() % nr;
                int time = RandomNumbers.NextNumber() % (DefineConstants.DAY_HOURS + 1 - dur);
                int pos = day * nr * DefineConstants.DAY_HOURS + room * DefineConstants.DAY_HOURS + time;

                // fill time-space slots, for each hour of class
                for (int i = dur - 1; i >= 0; i--)
                {
                    _slots[pos + i].AddLast(it.Current);
                    //_slots.at(pos + i).push_back(*it);

                }

            }
        }
        public Dictionary<CourseClass, int> GetClasses()
        {
            return _classes;
        }
        public List<LinkedList<CourseClass>> GetSlots()
        {
            return _slots;
        }
    }

}
