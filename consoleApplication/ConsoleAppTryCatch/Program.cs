using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age.

            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("Type your age to know your year of birth: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter int age only, no decimals");
                    if (age < 0)
                    {
                        //throw new Exception();
                        //throw new ArgumentException();
                        throw new FraudException("Age must be greater than 0.");
                    }

                    //Console.WriteLine("Type your age: ");
                    //int age = Convert.ToInt32(Console.ReadLine());
                    //

                    DateTime current = DateTime.Now;
                    Console.WriteLine("It time now is: " + current);

                    DateTime before = current.AddYears(age * -1); //current.AddHours(number);

                    //Display the year the user was born.
                    Console.WriteLine("\nYou was born in: ");
                    Console.WriteLine(string.Format("{0} ", before.Year));
                }
                catch (FraudException) //ArgumentException
                {
                    //Console.WriteLine("Something you entered, was incorrect.");
                    Console.WriteLine("Age must be greater than 0.");
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error ocurred. Please contact your system administrator");
                    Console.ReadLine();
                    return;
                }

            }


            Console.ReadLine();

        }
    }
}
