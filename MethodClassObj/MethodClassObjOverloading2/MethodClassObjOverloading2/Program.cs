using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassObjOverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            //the Main() method of the console app, instantiate the class.
            Numeros num1 = new Numeros();
            Console.WriteLine("test method 2, passing an integer an optional parameter : " + num1.methodTwo(500));
            int number1;
            int number2;
            bool option = false;
            do
            {
                try
                {
                    //Ask the user to input two numbers, one at a time.
                    //Let them know they need not enter anything for the second number.
                    Console.WriteLine("Enter two numbers to divide, it is not necessary to enter the second number to calculate the operation.");
                    Console.WriteLine("\nInput number 1: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nInput number 2: ");
                    string num2 = Console.ReadLine();
                    if (Int32.TryParse(num2, out number2))
                    {
                        //Call the method in the class, passing  two numbers entered.
                        Console.WriteLine("test method, passing  TWO numbers entered ADD number1 and number2: " + num1.methodTwo(number1, number2));
                    }
                    else
                    {
                        //Call the method in the class, passing in the one numbers entered.
                        Console.WriteLine("test method, passing  ONE numbers entered ADD number1 and default 1000: " + num1.methodTwo(number1));
                    }
                    
                    Console.WriteLine("\nyou want to continue...type:   true/false");
                    option = Convert.ToBoolean(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }

            Console.ReadLine();
            } while (option == true);

        }
    }
}
