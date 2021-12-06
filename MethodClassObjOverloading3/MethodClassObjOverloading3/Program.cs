using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassObjOverloading3
{
    class Program
    {
        static void Main(string[] args)
        {

            //the Main() method of the console app, instantiate the class.

            Numeros nums = new Numeros();   // instantiate the class Numeros.

            Console.WriteLine("\ntest method 3, specifying the parameters by name : ");
            nums.methodThree(numberOne: 5, numberTwo: 3);         //Call the method in the class, specifying the parameters by name.

            Console.WriteLine("\ntest method 3, specifying the parameters by name, diferent order : ");
            nums.methodThree(numberTwo: 3, numberOne: 5);        //Call the method in the class, specifying the parameters by name.

            Console.ReadLine();
        }
    }
}
