using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        //print “Person 1” to the screen and get the following details Hourly Rate and Hours worked per week
        Console.WriteLine("\nPerson1");
        Console.WriteLine("Input Hourly Rate:");
        int hourlyRateP1 = Convert.ToInt32(Console.ReadLine()); //Read a input and convert to integer
        Console.WriteLine("\nInput Hours worked per week:");
        int hoursWorkedP1 = Convert.ToInt32(Console.ReadLine()); //Read a input and convert to integer

        //print “Person 2” to the screen and then get the following details from user input: details Hourly Rate and Hours worked per week
        Console.WriteLine("\nPerson2");
        Console.WriteLine("Input Hourly Rate:");
        int hourlyRateP2 = Convert.ToInt32(Console.ReadLine()); //Read a input and convert to integer
        Console.WriteLine("\nInput Hours worked per week:");
        int hoursWorkedP2 = Convert.ToInt32(Console.ReadLine()); //Read a input and convert to integer

        //print to the screen “Annual salary of Person 1:” and display the exact salary below it.
        decimal salaryP1 = hourlyRateP1 * hoursWorkedP1*51; //multiplied hourly Rate BY hours Worked and 51 week Annual
        Console.WriteLine("\nAnnual salary of Person 1:"+ salaryP1);

        //print to the screen “Annual salary of Person 2:” and display the exact salary below it.
        decimal salaryP2 = hourlyRateP2 * hoursWorkedP2 * 51; //multiplied hourly Rate BY hours Worked and 51 week Annual
        Console.WriteLine("\nAnnual salary of Person 1:" + salaryP2);
        
        //print to the screen “Does Person 1 make more money than Person 2?”
        Console.WriteLine("\nDoes Person 1 make more money than Person 2? :" + (salaryP1>salaryP2));    //COMPARISON OPERATOR >
        Console.ReadLine();
    }
}
