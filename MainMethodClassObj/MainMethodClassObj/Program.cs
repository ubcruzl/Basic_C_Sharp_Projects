using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodClassObj
{
    class Program
    {
        static void Main(string[] args)
        {

            //the Main() method of the console app, instantiate the class and call the one method
            Numeros num1 = new Numeros();
            Console.WriteLine("1. try method 1 passing in an integer : " + num1.methodOne(500));

            //the Main() method of the console app, instantiate the class and call the second method
            Console.WriteLine("2. try method 2 passing in a decimal : " + num1.methodOne(1000.43m));    //passing in a decimal. Display the result to the screen.

            //instantiate the class and call the third method,
            Console.WriteLine("3. try method 3 passing in a string : " + num1.methodOne("100")); //passing in a string that equates to an integer
            Console.ReadLine();
        }
    }
}
