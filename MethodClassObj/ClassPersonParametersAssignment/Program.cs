using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Instantiate an Employee object with type “string” as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> emply1 = new Employee<string>();
            emply1.FirstName = "sample1";
            emply1.LastName = "student1";
            emply1.things =new List<string>{"libros","uniforme","materias","th"};
            emply1.SayName();
            //Create a loop that prints all of the Things to the Console.
            foreach (string thing in emply1.things)
            {
                Console.WriteLine("Thing: " + thing);
            }
            //Instantiate an Employee object with type “int” as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> emply2 = new Employee<int>();
            emply2.FirstName = "sample2";
            emply2.LastName = "student2";
            emply2.things = new List<int> { 6, 7, 8, 9};
            emply2.SayName();
            //Create a loop that prints all of the Things to the Console.
            foreach (int thing in emply2.things)
            {
                Console.WriteLine("Thing: " + thing);
            }

            Console.ReadLine();
        }
    }
}
