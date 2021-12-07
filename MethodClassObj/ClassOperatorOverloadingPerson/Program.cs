using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOperatorOverloadingPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object empl1 and empl2
            //
            Employee empl1 = new Employee();
            empl1.Id = 2;                   //assign id empl1

            Employee empl2 = new Employee();
            empl2.Id = 2;                   ////assign id empl2

            //so it checks if two Employee objects are equal by comparing their Id property.
            Console.WriteLine("Compare empl1.Id = 2 and  empl2.Id = 2");
            Console.WriteLine(empl1== empl2);
            empl1.Id = 2;
            empl2.Id = 4;
            Console.WriteLine("Compare empl1.Id = 2 and  empl2.Id = 4");
            Console.WriteLine(empl1 == empl2);

            Console.ReadLine();
        }

    }
}
