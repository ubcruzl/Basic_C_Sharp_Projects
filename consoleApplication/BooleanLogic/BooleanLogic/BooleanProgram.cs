using System;

class BooleanProgram
{
    static void Main()
    {
        Console.WriteLine("BOOLEAN LOGIC SUBMISSION ASSIGNMENT.");
        Console.WriteLine("determine whether or not the applicant qualified for car insurance.");
        Console.WriteLine("\nWhat is your age?");
        short ageNumber = short.Parse(Console.ReadLine());               //input a string and convert to short number
        Console.WriteLine("\nHave you ever had a DUI? Please answer \"true\" or \"false.\" ");
        bool DUI = bool.Parse(Console.ReadLine());
        Console.WriteLine("\nHow many speeding tickets do you have??");
        short speedingTickets = short.Parse(Console.ReadLine());  //input a string and convert to short number -32,768 through 32,767        

        //bool reqAge= ageNumber>15;    //Applicants must be over 15 years old.
        //bool reqDUI = DUI == false;   //Applicants must not have any DUI’s.
        //bool reqSpeedingTickets = 3>speedingTickets; //Applicants must not have more than 3 speeding tickets.

        //BOOLEAN LOGIC COMBINING && AND
        bool result_qualification = (ageNumber > 15 && (DUI == false)&& (speedingTickets<=3));
        Console.WriteLine("\nQualified? "+ result_qualification);




        Console.ReadLine();
    }
}
