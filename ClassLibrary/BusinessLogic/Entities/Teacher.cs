using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestAca.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            TaughtCourses = new List<TaughtCourse>();
        }

        public Teacher(string Address, string Id, string Name, int ZipCode,  string Ssn) :base(Name, Address, ZipCode)
        {
            this.Ssn = Ssn;
            this.Id = Id;
            TaughtCourses = new List<TaughtCourse>();


        }

        public bool IsScheduleCompatibleWith(TaughtCourse tc)
        {
            foreach (var taughtcourse in this.TaughtCourses)
            {

                DateTime taughtCourseEnd = taughtcourse.StartDateTime.Date.Add(taughtcourse.EndDate.TimeOfDay);

                if (tc.StartDateTime < taughtCourseEnd && tc.StartDateTime >= taughtcourse.StartDateTime)
                {
                    return false;
                }
            }
            return true;
        }





    }
}

