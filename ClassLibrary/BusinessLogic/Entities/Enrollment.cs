using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Enrollment
    {
        public Enrollment() 
        {
            Absences = new List<Absence>();

        }
        public Enrollment(DateTime enrollmentdate, Boolean uniquepayment, Student student, TaughtCourse taughtCourse) : this()
        {
            this.EnrollmentDate = enrollmentdate;
            //this.CancellationDate = cancellationdate;
            this.UniquePayment = uniquepayment;

            //Relaciones a uno
            this.Student = student;
            this.TaughtCourse = taughtCourse;

        }


    }
}

