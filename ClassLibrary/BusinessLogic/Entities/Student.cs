using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Student : Person
    {
        public Student() 
        {
            Enrollments = new List<Enrollment>();


        }

        public Student(string address, string id, string name,  int zipCode, string iban):base(name, address, zipCode)
        {
            this.IBAN = iban;
            this.Name = name;
            this.Id = id;
            this.Address = address;
            this.ZipCode = zipCode;
            Enrollments = new List<Enrollment>();
        }
       
    }
}

