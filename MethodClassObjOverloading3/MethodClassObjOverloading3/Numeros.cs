using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace MethodClassObjOverloading3
{
    class Numeros
    {

        //
        //create a void method that takes two integers as parameters.
        //
        public static void methodThree(int numberOne, int numberTwo) 
        {
            //Have the method do a math operation on the first integer and display the second integer to the screen
            Console.WriteLine("display the first integer to the screen: " + numberOne);
            Console.WriteLine("display the second integer to the screen: " + numberTwo);
            Console.WriteLine("Math.Pow(numberOne,numberTwo):   " + Convert.ToInt32(Math.Pow(numberOne, numberTwo)));   //math operation.

        }

    }
}
