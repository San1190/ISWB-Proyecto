using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestAca.Entities
{
    public partial class Enrollment
    {
 
        public int Id { get; set; }


        public DateTime EnrollmentDate { get; set; }


        public DateTime? CancellationDate { get; set; }


        public bool UniquePayment { get; set; }

  

        [Required]
        public virtual Student Student { get; set; }


        [Required]
        public virtual TaughtCourse TaughtCourse { get; set; }

        // Relación con `Absence` (Una inscripción puede tener múltiples ausencias)
        public virtual ICollection<Absence> Absences { get; set; }

    }
}

