using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Course
    {
        public Course()
        {
            TaughtCourses = new List<TaughtCourse>();
        }

        public Course(string description, string name) : this()
        {
            this.Name = name;
            this.Description = description;
        }

    }
}

