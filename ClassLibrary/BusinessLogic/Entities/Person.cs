using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public abstract partial class Person
    {
        public Person()
        {
            //Coleccionesss

      

        }
        public Person(string name, string address, int zipCode)
        {
            // this.id = id; se lo da la base de datos
            this.Name = name;
            this.Address = address;
            this.ZipCode = zipCode;
        }

    }

}

