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

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            emply.Quit();
            Console.ReadLine();

        }
    }
}
