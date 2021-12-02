using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TryCatch
{
    static void Main()
    {
        bool option = true;
        do
        {

            // try/catch block
            try
            {
                //Create a list of integers. 
                List<int> numbers = new List<int>() {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
                Console.WriteLine("\n\nYou have a list numbers : 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30");
                Console.WriteLine("Input  a number to divide each number in the list: ");
 
                int numberUser = Convert.ToInt32(Console.ReadLine());   //Ask the user for a number

                foreach (int number in numbers)     //loop that takes each integer in the list, divides it by the number the user entered
                {                                   //displays the result to the screen.
                    Console.WriteLine(number+" divide by "+ numberUser + " equals to " + number/numberUser);
                }
                Console.WriteLine("\n\nYou want to continue with the execution of the program.. input true/false");
                option = bool.Parse(Console.ReadLine());

            }
            catch (FormatException ex)              //display the error message to the screen. 
            {
                Console.WriteLine("\nError when entering integer data type: "+ex.Message + " the program will restart automatically...");
                //return;
            }
            catch (DivideByZeroException ex)        //display the error message to the screen. 
            {
                Console.WriteLine("\nCannot divide by zero: " + ex.Message+ " the program will restart automatically...");
                //return;
            }
            catch (Exception ex)                    //display the error message to the screen. 
            {
                Console.WriteLine(ex.Message+ " the program will restart automatically...");
            }

        } while (option);
    }
}