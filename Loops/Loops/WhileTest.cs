/*
 * CONSOLE APP SUBMISSION ASSIGNMENT
Welcome to menu, choice option.
 1. Option While:
 2. Menu 1:
 3. Menu 2:
 4. Menu 3:
 5. finish:
1
you have chosen option 1
Print second 0
Second time 10
Second time 11
Second time 12
Second time 13
Second time 14
Second time 15
..............
Second time 50
..............

5
you have chosen to exit.

Done, press any key to exit...
 * */

using System;
using System.Threading;

class WhileTest
{
    
    static void Main()
    {
        int menu = 0;
        DateTime moment;
        do // do it while menu is diferent until you choose the option to exit
        {
            Console.Clear();    //Clear console
            
            int second=0;

            Console.WriteLine("CONSOLE APP SUBMISSION ASSIGNMENT");

            Console.WriteLine("Welcome to menu, choice option.");
            Console.WriteLine(" 1. Option While:");
            Console.WriteLine(" 2. Menu 1:");
            Console.WriteLine(" 3. Menu 2:");
            Console.WriteLine(" 4. Menu 3:");
            Console.WriteLine(" 5. finish:");

            menu = Convert.ToInt32(Console.ReadLine()); //input menu

            switch (menu) //switch statement to select one of many code blocks to be executed.
            {
                case 1:
                    Console.WriteLine("you have chosen option "+ menu);

                    Console.WriteLine("Print second " + second);

                    while (second<50)   //The while loop loops through a block of code as long as a specified condition is true.
                    {
                        moment = DateTime.Now;  //get time machine
                        second = moment.Second; //get second from time
                        Console.WriteLine("Second time " + second);

                        Thread.Sleep(1000); // 1000 milliseconds i.e 1sec   pause time
                    }
                    Console.WriteLine("Finish while...");
                    break;                          //break keyword, it breaks out of the switch block.
                case 2:
                    Console.WriteLine("you have chosen option "+ menu);
                    Console.WriteLine("Done, press any key");
                    break;
                case 3:
                    Console.WriteLine("you have chosen option "+ menu);
                    Console.WriteLine("Done, press any key");
                    break;
                case 4:
                    Console.WriteLine("you have chosen option "+ menu);
                    Console.WriteLine("Done, press any key");
                    break;
                case 5:
                    Console.WriteLine("you have chosen to exit.");
                    menu = 5;
                    break;
                default:
                    Console.WriteLine("you must choose an option from the menu.");
                    Console.WriteLine("choose an option ? ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            
            Console.ReadLine();
        } while (menu != 5);            //The while loop loops through a block of code as long as a specified condition is true
        Console.WriteLine("Done, press any key to exit...");
        Console.ReadLine(); 
    }
}
