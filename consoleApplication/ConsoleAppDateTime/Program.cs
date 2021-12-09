using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            Console.WriteLine("Time now is: "+DateTime.Now);

            //Asks the user for a number.
            Console.WriteLine("Type a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            DateTime current = DateTime.Now;
            //DateTime x30MinsLater = current.AddMinutes(30);
            DateTime later = current.AddHours(number);
            Console.WriteLine("The date in in X hours: ");
            Console.WriteLine(string.Format("{0} ",  later));

            Console.ReadLine();
        }
    }
}
