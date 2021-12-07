using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    //Create a class called Person and give it two properties
    class Person
    {
        //properties FirstName, LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //void method called SayName() that takes no parameters
        public void SayName()
        {
            //simply writes the person's full name to the console in the format of: “Name: [full name]”
            Console.WriteLine("Name: [{0} {1}]", FirstName,LastName);
        }
    }
}
