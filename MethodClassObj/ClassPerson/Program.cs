using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ub = new Person();
            ub.FirstName = "ub";
            ub.LastName = "cr";
            ub.SayName();
            // instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee emply = new Employee();
            emply.FirstName = "Sample";
            emply.LastName = "Student";
            //Call the superclass method SayName() on the Employee object.
            emply.SayName();
            Console.ReadLine();
        }
    }
}
