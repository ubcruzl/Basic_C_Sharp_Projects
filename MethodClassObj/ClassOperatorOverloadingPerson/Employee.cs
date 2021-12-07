using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOperatorOverloadingPerson
{
    //class called Employee and have it inherit from the Person class.
    
    class Employee : Person,IQuittable
    {
        //Implement the SayName() method inside of the Employee class.
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Welcome employee: ");
            base.SayName(); 
        }
        //Have your Employee class from the previous drill inherit that interface and implement the Quit()
        //method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("\nInterface IQuit from Employee ");
            Console.WriteLine("\nEmployee quit.. ");
        }
        //Overload the “==” operator so it checks if two Employee objects
        //are equal by comparing their Id property.
        public static bool operator ==(Employee id1, Employee id2)
        {
            return id1.Id.Equals(id2.Id);
        }
        //Overload the “!=” operator so it checks if two Employee objects
        public static bool operator !=(Employee id1, Employee id2)
        {
            return !(id1.Id == id2.Id); 
        }
    }
}
