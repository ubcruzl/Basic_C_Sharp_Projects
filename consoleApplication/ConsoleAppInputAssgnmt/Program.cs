using System;
using System.IO;

namespace ConsoleAppInputAssgnmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number.
            Console.WriteLine("Hello, input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //Logs that number to a text file.
            File.WriteAllText(@"log1.txt",Convert.ToString(number));
            //Prints the text file back to the user.
            string text = File.ReadAllText(@"log1.txt");
            Console.WriteLine("Leyendo el archivo de texto ");
            Console.WriteLine();
            Console.WriteLine(text);

        }
    }
}
