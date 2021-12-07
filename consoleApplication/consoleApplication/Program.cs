using System;

class Program
{
    static void Main()
    {
        /*
        Console.WriteLine("console application");
        //Takes an input from the user, multiplies it by 50, then prints the result to the console.
        Console.WriteLine("\nInput a number, multiplies it by 50: ");
        int num1a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number multiplied  by 50 is: "+ num1a*50);
        //Takes an input from the user, adds 25 to it, then prints the result to the console.
        Console.WriteLine("\nInput another number, to adds 25 : ");
        int num1b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number add  by 25 is: " + (num1b+25));
        //Takes an input from the user, divided it by 12.5, then prints the result to the console.
        Console.WriteLine("\nInput another number, to divided by 12.5: ");
        int num1c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number divided by 12.5 is: " + (num1c / 12.5));

        //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
        Console.WriteLine("\nInput another number, to checks if it is greater than 50: ");
        int num1d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("checks if it is greater than 50: " + (num1d>50));

        //Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
        Console.WriteLine("\nInput another number, to  divides it by 7 and prints the remainder : ");
        int num1e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("checks if it is greater than 50: " + (num1e%7));
        */

        int packageWidth = 10;
        int packageHeight = 25;
        //BOOLEAN LOGIC (&&)
        bool tooBigAnd = (packageHeight > 25 && packageWidth > 25);
        Console.WriteLine("Are both the package height and the package width greater than 25?" + tooBigAnd);
        Console.ReadLine();

        //BOOLEAN LOGIC (||)
        bool tooBigOr = (packageHeight > 25 || packageWidth > 25);
        Console.WriteLine("Are either the package height or the package width greater than 25?" + tooBigOr);
        Console.ReadLine();

        String firstName = "Jesse";
        String lastNAme = "Jonhson";
        //BOOLEAN LOGIC MULTIPLE USES OF OR
        String socialSecurutyNumber = "111-11-1111";
        bool isAuthorized = (firstName == "Jesse" && lastNAme == "Jonhson" && socialSecurutyNumber == "111-11-1111");
        Console.WriteLine("Is this person’s first name ‘Jesse’ and his last name ‘Johnson’ and is his social security number ‘111-11-1111’?"+ isAuthorized);
        Console.ReadLine();

        int bankAccountBalance = 500;
        bool isInRockBand = false;
        string name = "Jesse";
        bool isReallyCool = (bankAccountBalance > 500 || isInRockBand|| name == "Jesse");
        Console.WriteLine("Does this person have over a hundred thousand dollars in his bank account or is he in a rock band or is his name Jesse?"+ isReallyCool);
        Console.ReadLine();

        //BOOLEAN LOGIC COMBINING && AND ||
        bool result_a = (true && (true || false));
        Console.WriteLine(result_a);
    }
}
