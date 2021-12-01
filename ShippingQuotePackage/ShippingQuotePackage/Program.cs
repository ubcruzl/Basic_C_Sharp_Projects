using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("\nPlease enter the package weight:");
        //input accept decimals
        float packageWeight = float.Parse(Console.ReadLine()); // input convert to float 

        if (packageWeight <= 50)    //If the weight is less than 50 less or equal
        {
            Console.WriteLine("\nPackage can be shipped via Package Express.");

            Console.WriteLine("\nPlease enter the package width:");
            float packageWidth = float.Parse(Console.ReadLine());   // input convert to float 

            Console.WriteLine("\nPlease enter the package height:");
            float packageHeight = float.Parse(Console.ReadLine());  // input convert to float 

            Console.WriteLine("\nPlease enter the package length:");
            float packageLength = float.Parse(Console.ReadLine());  // input convert to float 

            // multiply the three dimensions (height, width, & length) together, and multiply the product by the weight.
            // Finally, divide the outcome by 100.
            float suma = packageWidth + packageHeight + packageLength;  
            if (suma > 50) //If the dimensions total greater than 50
            {               //display the  message
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
            }
            else
            {
                // multiply the three dimensions (height, width, & length) together, and multiply the product by the weight.
                // Finally, divide the outcome by 100.
                //convert float into a decimal
                decimal quote = ((decimal)packageWidth* (decimal)packageHeight * (decimal)packageLength)* (decimal)packageWeight / 100;

                Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote.ToString("0.00"));
                Console.WriteLine("Thank you!");
            }
        }
        else   //If the weight is greater than 50
        {
            Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
        }
        Console.ReadLine();

    }
}
