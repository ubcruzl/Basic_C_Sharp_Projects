using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable.
            const float pi = 3.141516f;
            Console.WriteLine("El valor de la constante PI es {0}", pi);

            //Create a variable using the keyword “var.”
            var array = new[] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("\nList variable using the keyword “var.”: \n");
            array.ToList().ForEach(number => Console.WriteLine(number));


            //Chain two constructors together.
            Person person = new Person("Carl","Jr");
            Console.WriteLine(person.FName + " " + person.LName + " " + person.Edad);
            Console.ReadLine();
            //Chain two constructors together.

        }
        //Chain two constructors together.
        public class Person
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Edad { get; set; }
            //Calling Constructor from another Constructor
            public Person(string fName, string lName):this(fName, lName,18)
            {
            }
                public Person(string fName, string lName,int edad)
            {
                FName = fName;
                LName = lName;
                Edad = edad;
            }

        }
    }
}
