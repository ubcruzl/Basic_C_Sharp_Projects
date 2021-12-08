using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPolymorphismPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            Employee emply = new Employee();
            emply.firstName = "Sample";
            emply.lastName = "Student";
            //Call the SayName() method on the object.
            emply.SayName();

            //call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

            //
            IQuittable emplQryl = new Employee();   // create an object of type IQuittable 

            ((Employee)emplQryl).firstName = "Sample";
            ((Employee)emplQryl).lastName = "Student";

            emplQryl.Quit(emplQryl);    //call the Quit() method on it.
            Console.ReadLine();

        }
    }
}
