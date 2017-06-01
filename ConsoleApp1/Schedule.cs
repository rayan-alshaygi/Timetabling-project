using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Schedule
    {

        // Time-space slots, one entry represent one hour in one classroom

        private List<LinkedList<DataRow>> _slots = new List<LinkedList<DataRow>>();
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
            DataTable c = Counts.GetInstance().GetCourseClasses();
            foreach (DataRow row in c.Rows)
            {
                // determine random position of class
                int nr = Counts.GetInstance().GetNumberOfRooms();
                int dur = Int32.Parse(row["duration"].ToString());
                int day = RandomNumbers.NextNumber() % DefineConstants.DAYS_NUM;
                int room = RandomNumbers.NextNumber() % nr;
                int time = RandomNumbers.NextNumber() % (DefineConstants.DAY_HOURS + 1 - dur);
                int pos = day * nr * DefineConstants.DAY_HOURS + room * DefineConstants.DAY_HOURS + time;

                // fill time-space slots, for each hour of class
                for (int i = dur - 1; i >= 0; i--)
                {
                    _slots[pos + i].AddLast(row);
                    //_slots.at(pos + i).push_back(*it);

                }
            }
        }

       /* public void CalculateFitness()
        {
            // chromosome's score
            int score = 0;

            int numberOfRooms = Counts.GetInstance().GetNumberOfRooms();
            int daySize = DefineConstants.DAY_HOURS * numberOfRooms;

            int ci = 0;

            // check criterias and calculate scores for each class in schedule
            for (hash_map<CourseClass*, int>.const_iterator it = _classes.begin(); it != _classes.end(); ++it, ci += 5)
            {
                // coordinate of time-space slot
                int p = it.second;
                int day = p / daySize;
                int time = p % daySize;
                int room = time / DefineConstants.DAY_HOURS;
                time = time % DefineConstants.DAY_HOURS;

                int dur = it.first.GetDuration();

                // check for room overlapping of classes
                bool ro = false;
                for (int i = dur - 1; i >= 0; i--)
                {
                    if (_slots[p + i].Count > 1)
                    {
                        ro = true;
                        break;
                    }
                }

                // on room overlaping
                if (!ro)
                {
                    score++;
                }

                _criteria[ci + 0] = !ro;

                CourseClass cc = it.first;
                Room r = Counts.GetInstance().GetRoomById(room);
                // does current room have enough seats
                _criteria[ci + 1] = r.GetNumberOfSeats() >= cc.GetNumberOfSeats();
                if (_criteria[ci + 1])
                {
                    score++;
                }

                // does current room have computers if they are required
                _criteria[ci + 2] = !cc.IsLabRequired() || (cc.IsLabRequired() && r.IsLab());
                if (_criteria[ci + 2])
                {
                    score++;
                }

                bool po = false;
                bool go = false;
                // check overlapping of classes for professors and student groups
                for (int i = numberOfRooms, t = day * daySize + time; i > 0; i--, t += DefineConstants.DAY_HOURS)
                {
                    // for each hour of class
                    for (int i = dur - 1; i >= 0; i--)
                    {
                        // check for overlapping with other classes at same time
                        LinkedList<CourseClass> cl = _slots[t + i];
                        for (LinkedList<CourseClass>.Enumerator it = cl.GetEnumerator(); it.MoveNext();)
                        {
                            if (cc != it.Current)
                            {
                                // professor overlaps?
                                //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                                if (!po && cc.ProfessorOverlaps(it.Current))
                                {
                                    po = true;
                                }

                                // student group overlaps?
                                //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                                if (!go && cc.GroupsOverlap(it.Current))
                                {
                                    go = true;
                                }

                                // both type of overlapping? no need to check more
                                if (po && go)
                                {
                                    goto total_overlap;
                                }
                            }
                        }
                    }
                }

                total_overlap:

                // professors have no overlaping classes?
                if (!po)
                {
                    score++;
                }
                _criteria[ci + 3] = !po;

                // student groups has no overlaping classes?
                if (!go)
                {
                    score++;
                }
                _criteria[ci + 4] = !go;
            }

            // calculate fitess value based on score
            _fitness = (float)score / (Counts.GetInstance().GetNumberOfCourseClasses() * DefineConstants.DAYS_NUM);
        }
        */

        public Dictionary<CourseClass, int> GetClasses()
        {
            return _classes;
        }
        public List<LinkedList<DataRow>> GetSlots()
        {
            return _slots;
        }


    }
}
