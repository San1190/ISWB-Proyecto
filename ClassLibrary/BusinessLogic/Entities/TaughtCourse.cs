using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class TaughtCourse
    {
        public TaughtCourse()
        {
            Enrollments = new List<Enrollment>();
            Teachers = new List<Teacher>();

        }

        public void AssignTeacher(Teacher t)
        {
            this.Teachers.Add(t);
        }


        public TaughtCourse(DateTime endDate, int id, int quotas, int sessionDuration, DateTime startDate, string teachingDay, int totalprice, Course course) : this() 
        {
            this.StartDateTime = startDate;
            this.EndDate = endDate;
            this.Quotas = quotas;
            this.SessionDuration = sessionDuration;
            this.TeachingDay = teachingDay;
            this.TotalPrice = totalprice;
            this.Id = id;
            //Relaciones
            //this.Teacher = teacher;
            this.Course = course;
            //this.Classroom = classroom;


        }

        public override string ToString()
        {
            return this.Course.Name ?? "Unnamed Course"; // Asegúrate de que Course tenga la propiedad Name.
        }

    }
}

