using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPolymorphismPerson
{
    //Create an abstract class called Person with two properties.
    public abstract class Person
    {
        //properties: string firstName and string lastName.
        public string firstName { get; set; }
        public string lastName { get; set; }
        //method SayName().

        public virtual void SayName()
        {
            //simply writes the person's full name to the console in the format of: “Name: [full name]”
            Console.WriteLine("Name: [{0} {1}]", firstName, lastName);
        }
    }
}
