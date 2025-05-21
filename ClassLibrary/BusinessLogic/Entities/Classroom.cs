using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Classroom
    {
        public Classroom()
        {
            TaughtCourses = new List<TaughtCourse>();
        }

        public Classroom(int maxCapacity, string name) : this()
        {
            this.MaxCapacity = maxCapacity;
            this.Name = name;
        }
    }

}

