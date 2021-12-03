using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            Numeros nums = new Numeros();

            Console.WriteLine("Select option:");
            Console.WriteLine("1. Conver miles to kilometers. ");
            Console.WriteLine("2. Conver Farenheit to Centigrados. ");
            Console.WriteLine("3. Conver $DLS to $MX. ");
            try                 //try statement allows you to define a block of code to be tested for errors while it is being executed.
            {
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)         //switch statement to select one of many code blocks to be executed.
                {
                    case 1:            //option switch statement
                        Console.WriteLine("\nInput milles to convert. ");
                        int milles = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("to kilometers: " + nums.MyMethod1(milles));
                        break;
                    case 2:             //option switch statement
                        Console.WriteLine("\nInput grades Farenheit to convert. ");
                        int Farenheit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("to Centigrados: " + nums.MyMethod2(Farenheit));
                        break;
                    case 3:             //option switch statement
                        Console.WriteLine("\nInput $DLS to convert. ");
                        int DLS = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("to $MX: " + nums.MyMethod3(DLS));
                        break;
                }
                Console.ReadLine();

            }
            catch (Exception ex)            //The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            {
                Console.WriteLine(ex);
            }
        }

    }
}
