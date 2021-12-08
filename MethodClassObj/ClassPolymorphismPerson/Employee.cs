using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPolymorphismPerson
{
    //class called Employee and have it inherit from the Person class.
    //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
    class Employee : Person, IQuittable
    {
        //Implement the SayName() method inside of the Employee class.

        public override void SayName()
        {
            Console.WriteLine("Welcome employee: ");
            base.SayName(); 
        }

        //Have your Employee class from the previous drill inherit that interface and implement the Quit()
        //method in any way you choose.
        public void Quit(IQuittable quittable)
        {
            Console.WriteLine("\nInterface IQuit from Employee ");
            Console.WriteLine("\nEmployee quit.. ");
            Console.WriteLine( "Try polymorfism... " + this.firstName +" "+this.lastName);
        }
    }
}
