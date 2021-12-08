using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassParsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //try/catch block  
            try
            {
                //Prompt the user to enter the current day of the week.
                Console.WriteLine("Enter the current day of the week: ");
                string day = Console.ReadLine();
                //Assign the value to a variable of that enum data type you just created.
                DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);    //parse enums day input
                
                String dateTime = DateTime.Now.DayOfWeek.ToString();        //parse enums dateTime

                if (today.ToString() == dateTime)                           //Compare if today is day user input 
                {
                    Console.WriteLine("Today is {0} ", today);              //print true 
                }
                else
                {
                    Console.WriteLine("Today is  NOT {0} ", today);         //print false 
                    Console.WriteLine("Please enter an actual day of the week.\n");
                }
            }
            catch(Exception)                                    //try/catch block           
            {
                Console.WriteLine("Please enter an actual day of the week.\n");
            }
            Console.ReadLine();
        }
    }
    //Create an enum for the days of the week.
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
