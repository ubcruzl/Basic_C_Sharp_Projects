using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonLambda
{
    // class called Employee and have it inherit from the Person class.
    class Employee:Person
    {
        public int Id { get; set; }

        //define constructor Employee
        public Employee(int id, string firstName, string lastName) :base(firstName, lastName)
        {
            Id = id;
        }

    }

}
