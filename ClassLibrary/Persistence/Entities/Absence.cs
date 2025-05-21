using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestAca.Entities
{
    public partial class Absence
    {

        public DateTime? Date {  get; set; }


        public int Id { get; set; }


        public virtual Enrollment Enrollment { get; set; }
    }
}

