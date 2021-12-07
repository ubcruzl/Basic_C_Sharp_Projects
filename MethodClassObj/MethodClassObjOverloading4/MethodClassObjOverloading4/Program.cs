using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassObjOverloading4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOut;
            //In the Main() method, instantiate that class.
            Numeros nums = new Numeros();
            Console.WriteLine("test method 4: ");
            Console.WriteLine("\nInput number to divide by 2 : ");
            //
            int number =Convert.ToInt32(Console.ReadLine());     //Have the user enter a number.
            nums.methodDivided(number, out numberOut);     // Call the method on that number. 
            Console.WriteLine("Result : "+ numberOut);  //Display the output to the screen. It should be the entered number, divided by two.

            //Create a method with output parameters.
            //accessing the method
            nums.methodOut(out int x);
            Console.WriteLine("accessing the method output parameters: " + x);

            //accessing the method Overload a method.
            Console.WriteLine("accessing the Overload   "+ nums.methodOverloadSum(5,5));
            Console.WriteLine("accessing the Overload   " + nums.methodOverloadSum(5, 5.55f));

            //accessing the method static method
            Console.WriteLine("accessing the static method   " + Numeros.methodStaticMult(5,5));

            //accessing the static class
            Console.WriteLine("accessing the static class.  97 IS PRIME?  " + NumerosNaturales.getPrimos(97));
            Console.ReadLine();
        }

    }
}
