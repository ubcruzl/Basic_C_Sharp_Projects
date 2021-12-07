using System;

class Program
{
    static void Main()
    {
        // Get the current date.
        DateTime thisDay = DateTime.Today;
        // Display the date in the default (general) format.
        Console.WriteLine(thisDay.ToString());
        Console.WriteLine();
        // Display the date in a variety of formats.
        Console.WriteLine(thisDay.ToString("d"));
        Console.WriteLine(thisDay.ToString("D"));
        Console.WriteLine(thisDay.ToString("g"));
        //
        //DateTime moment = new DateTime(1999, 1, 13, 3, 57, 32, 11);
        DateTime moment = DateTime.Today;
        // Year gets 1999.
        int year = moment.Year;
        // Month gets 1 (January).
        int month = moment.Month;
        // Day gets 13.
        int day = moment.Day;
        // Hour gets 3.
        int hour = moment.Hour;
        // Minute gets 57.
        int minute = moment.Minute;
        // Second gets 32.
        int second = moment.Second;
        // Millisecond gets 11.
        int millisecond = moment.Millisecond;
        Console.WriteLine("Day: " + day);

        //
        int day1 = 4;
        switch (day1)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        Console.ReadLine();
    }
}
