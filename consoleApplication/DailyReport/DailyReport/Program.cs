using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("\nStudent Daily Report.");
        Console.WriteLine("\nWhat is your name?");
        string name = Console.ReadLine();               //String data type to hold multiple characters without the array management overhead of Char()
        Console.WriteLine("\nWhat course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("\nWhat page number?");
        short pagepageNumber = short.Parse(Console.ReadLine());   //o not need the full range,  Short data type, which can hold integers from -32,768 through 32,767        
        Console.WriteLine("\nDo you need help with anything? Please answer “true” or “false.”");
        bool needHelp = bool.Parse(Console.ReadLine());     //o contain two-state values such as true/false.
        Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
        string experiences = Console.ReadLine();
        Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("\nHow many hours did you study today?");
        byte hoursStudy = byte.Parse(Console.ReadLine());       //Holds unsigned 8-bit (1-byte) integers that range in value from 0 through 255.
        Console.WriteLine("\nThank you for your answers. \nAn Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}
