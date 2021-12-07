using System;

class Program
{
    static void Main()
    {
        /*
         //ELSE STATEMENTS
        bool xx = true;
        if (xx)
        {
            Console.WriteLine("Hello!");
            
        }
        if (1 == 1)
        {
            Console.WriteLine("1 equals to 1!");
        }
        else
        {
            Console.WriteLine("1 does not equals to 1!");
        }
        string name = "Adam";
        if (name=="Jesee")
        {
            Console.WriteLine("Your name is Jesse!");
        }
        else if (name == "Brett")
        {
            Console.WriteLine("Your name is not Jesse!");
        }
        else
        {
            Console.WriteLine("Your name is not Jesse, your name is not brett");
        }
        Console.ReadLine();

        string name1 = "Erick";
        if (name1 == "Jesee")
        {
            Console.WriteLine("Your name is Jesse!");
        }
        else if (name1 == "Brett")
        {
            Console.WriteLine("Your name is not Jesse!");
        }
        else
        {
            Console.WriteLine("Your name is Adam");
        }

        string name2 = "Adam";
        if (name2 == "Jesse")
        {
            Console.WriteLine("Your name is Jesse!");
        }
        if (name2 == "Brett")
        {
            Console.WriteLine("Your name is not Jesse!");
        }
        if (name2 == "Adam")
        {
            Console.WriteLine("Your name is Adam!");
        }
        Console.ReadLine();
        
        //OPERATOR !=
        string name = "Adam";
        if (name != "Jesse")
        {
            Console.WriteLine("Your name is not Jesse.");
            Console.ReadLine();
        }
        if (1 != 2)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Not good!");
        }
        
        //GREATER THAN OPERATOR
        int num1 = 12;
        int num2 = 14;
        if (num1 > num2)
        {
            Console.WriteLine("The first number is larger!");
            
        }
        else
        {
            Console.WriteLine("The second number is larger!");
        }
        int age = 19;
        if (age < 21)
        {
            Console.WriteLine("Not, you may not purchase that bottle of wine!");
        }
        else
        {
            Console.WriteLine("That will be $23.71!");
        }
        //LESSER THAN OR EQUAL TO OPERATOR

        int age1 = 20;
        if (age1 >= 25)
        {
            Console.WriteLine("Yes, you may rent a car from us!");
        }
        else
        {
            Console.WriteLine("Not, you may not rent a car from us!!");
        }

        //THE AND OPERATOR
        int num1a = 7;
        int num2a = 18;
        int num3a = 12;
        if(num2a>num1a && num3a < num2a)
        {
            Console.WriteLine("The second number is larger than the  others!");
        }

        int num4a = 7;
        if(true && true && true && true && num4a == 20)
        {
            Console.WriteLine("Everything was true!");
        }
        else
        {
            Console.WriteLine("There was a false somwhere!");
        }

        int packageWeight = 50;
        int packageLenght = 25;
        if (packageWeight > 40 && packageLenght > 20)
        {
            Console.WriteLine("This package is too big to ship.!");
        }
        //THE AND OPERATOR
        int num1c = 7;
        //int num2c = 18;
        //int num3c = 12;
        if (num1c > 7 || num1c == 12)
        {
            Console.WriteLine("At least one value is true.");

        }
        if (num1c==12 || num1c == 18)
        {
            Console.WriteLine("At least one value is true.");
        }
        else
        {
            Console.WriteLine("No value is true.");
        }
        if (num1c == 12 || num1c == 18 || num1c == 20 || num1c == 7)
        {
            Console.WriteLine("Something is true.");
        }
        string role = "admin";
        if (role == "admin" || role == "administrator")
        {
            Console.WriteLine("You may have access to the entire software system.");
        }
        
        //TERNARY OPERATOR
        //the ternary operator is represented by the symbol “?:”
        int num1d = 7;
        int num2d = 12;
        Console.WriteLine("num1d = 7, num2d = 12");
        string result = num1d > num2d ? "Num1 is greather than num2":"num1 is not greater than num2";
        Console.WriteLine(result);
        Console.ReadLine();
        */
        /*
        int currentTemperature = 80;
        int roomTemperature = 70;
        if (currentTemperature == roomTemperature)
        {
            Console.WriteLine("Its is exactly room temperature!");
        }
        else if (currentTemperature > roomTemperature)
        {
            Console.WriteLine("Its warmer than room temperature!");
        }
        else if (roomTemperature > currentTemperature)
        {
            Console.WriteLine("room temperature is warmer than current temperature!");
        }
        else
        {
            Console.WriteLine("It is not exactly room temperature!");
        }
        Console.ReadLine();
        
        int currentTemperature1 = 80;
        int roomTemperature1 = 70;
        string comparisionResult = currentTemperature1 == roomTemperature1 ? "Its is room temperature" : "It is not temperature";
        Console.WriteLine(comparisionResult);
        Console.ReadLine();
        */
        /*
        int roomTemperature2 = 70;
        Console.WriteLine("Hi, what is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("Hi, "+name+ ", what is the temperature where you are?");
        int currentTemperature2 = Convert.ToInt32(Console.ReadLine());
        if (currentTemperature2 == roomTemperature2)
        {
            Console.WriteLine("It is exactly room temperature.");
        }
        else if (currentTemperature2>roomTemperature2)
        {
            Console.WriteLine("It is warmer than room temperature.");
        }
        else if (roomTemperature2 > currentTemperature2)
        {
            Console.WriteLine("It is colder than room temperature.");
        }
        else
        {
            Console.WriteLine("Uhhhhhh..... something went wrong.");
        }
        Console.ReadLine();
        */

        Console.WriteLine("What is your favorite number?");
        int favNumber = Convert.ToInt32(Console.ReadLine());
        string result = favNumber == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";
        Console.WriteLine("result: "+result);
        Console.ReadLine();
    }
}
