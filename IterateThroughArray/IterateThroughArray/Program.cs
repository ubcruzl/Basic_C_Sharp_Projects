/*
 * SIX-PART ASSIGNMENT
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        int menu;
        string sentence;
        do
        {
            Console.Clear();
            Console.WriteLine("choose an option from the menu");
            Console.WriteLine("\n1. CONSOLE APP PART ONE ASSIGNMENT");
            Console.WriteLine("2. CONSOLE APP PART TWO ASSIGNMENT");
            Console.WriteLine("3. CONSOLE APP PART THREE ASSIGNMENT");
            Console.WriteLine("4. CONSOLE APP PART FOUR ASSIGNMENT");
            Console.WriteLine("5. CONSOLE APP PART FIVE ASSIGNMENT");
            Console.WriteLine("6. CONSOLE APP PART SIX SUBMISSION ASSIGNMENT");
            Console.WriteLine("7. EXIT ASSIGNMENT");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    //CONSOLE APP PART ONE ASSIGNMENT
                    //A one-dimensional array of strings.
                    Console.WriteLine("CONSOLE APP PART ONE ASSIGNMENT");
                    string[] arraystring = {"string 0 ", "string1 ", "string 2 ", "string 3 ", "string 4 ", "string 5 ", "string 6 ", "string 7 ", "string 8 ", "string 9 " };
                    Console.WriteLine("You have an array string: [\"string 0 \", \"string1 \", \"string 2 \", \"string 3 \", \"string 4 \", \"string 5 \", \"string 6 \", \"string 7 \", \"string 8 \", \"string 9 \"]");
                    Console.WriteLine("\nPlease, input some text: ejem. Hello World, today is...");
                    //
                    sentence = Console.ReadLine();      //Ask the user to input some text.
                    string[] sentenceList = sentence.Split(' ');
                    //A loop that iterates through each string in the array
                    for (int i =0; i<arraystring.Length;i++)        //loop foreach
                    {
                        //adds the user's text input to the end of each string
                        //if (sentenceList.Length>i)      //branch validates that the words entered by the user are sufficient to continue adding them to the array
                        //{
                            arraystring[i] = arraystring[i] + sentenceList[i% sentenceList.Length];  //update each array element by appending the user's text
                        //}
                        //else
                        //{
                        //    arraystring[i] = arraystring[i] + "null";   //update each array element by appending  text null
                        //}
                    }
                    foreach(string word in arraystring)
                    {
                        Console.WriteLine(word);
                    }
                    arraystring = sentence.Split(' ');
                    break;
                case 2:
                    //CONSOLE APP PART TWO ASSIGNMENT
                    bool loop = true;
                    Console.WriteLine("CONSOLE APP PART TWO ASSIGNMENT.");
                    Console.WriteLine("cycle that exits when your computer is at 30 seconds.");
                    while (loop)
                    {
                        //
                        Console.WriteLine(" Today is " + DateTime.Now + "  Loop finish second 30 or Ctr + c to break infinite loop ");
                        System.Threading.Thread.Sleep(1000);
                        if (DateTime.Now.Second==30)
                        {
                            loop =false;
                        }
                        //
                    }
                    break;
                case 3:
                    //CONSOLE APP PART THREE ASSIGNMENT
                    
                    Console.WriteLine("CONSOLE APP PART THREE ASSIGNMENT");
                    Console.WriteLine("CONSOLE APP PART THREE ASSIGNMENT");
                    List<double> doubleList = new List<double>();       //list 
                    // loop where the comparison, whether to continue iterating the loop is a “<”
                    for (int j = 0; j < 20; j++)
                    {
                        doubleList.Add(Math.Pow(2,j));          //add elements to list
                    }
                    foreach (int number in doubleList)
                    {

                        Console.WriteLine(" “<” " + number);
                    }
                    //loop where the comparison is a “<=”
                    doubleList.Add(Math.Pow(2, 20));
                    for (int k = 0; k <= (doubleList.Count-1); k++)
                    {
                        Console.WriteLine("<= " + doubleList[k]);
                    }
                    break;
                case 4:
                    //CONSOLE APP PART FOUR ASSIGNMENT
                    //A list of strings where each item in the list is unique.
                    Console.WriteLine("CONSOLE APP PART FOUR ASSIGNMENT");

                    string[] colors = { "yellow", "blue", "black", "white", "red", "pink", "purple", "marrow" };
                    Console.WriteLine("Option colors \"yellow\", \"blue\", \"black\", \"white\", \"red\", \"pink\", \"purple\", \"marrow\" ");
                    Console.WriteLine("input text to search for in the list COLOR");
                    string color= Console.ReadLine();       //Ask the user to input text to search for in the list
                    int? index=null;
                    for (int i=0; i< colors.Length; i++ )
                    {
                        //Console.WriteLine("itera: "+ i);
                        if (colors[i] == color)          
                        {
                            index = i;
                            break;  //that stops it from executing once a match has been found.
                        }
                    }
                    if (index != null)  //displays the index of the list that contains matching text on the screen
                    {
                        Console.WriteLine("\nitem is on index : " + index);
                    }
                    else            //Add code to the loop to check if the user put in text that isn't on the list and,
                    {            //if they did, tells the user their input is not on the list.
                        Console.WriteLine("that item isn't on the list ");
                    }
                    break;
                case 5:
                    //CONSOLE APP PART FIVE ASSIGNMENT
                    //A list of strings where each item in the list is unique.
                    Console.WriteLine("CONSOLE APP PART FOUR ASSIGNMENT");
                    string[] colors5 = { "yellow", "blue", "black", "white", "red", "pink", "purple", "marrow", "dark","ligth","blue"};
                    Console.WriteLine("input text to search for in the list COLOR");
                    Console.WriteLine("Coloroptions array: \"yellow\", \"blue\", \"black\", \"white\", \"red\", \"pink\", \"purple\", \"marrow\", \"dark\",\"ligth\",\"blue\"");
                    string color5 = Console.ReadLine();       //Ask the user to input text to search for in the list
                    List<int> intList = new List<int>();
                    for (int i = 0; i < colors5.Length; i++)
                    {
                        //Console.WriteLine("itera: " + i);
                        if (colors5[i] == color5)
                        {
                            intList.Add(i);
                        }
                    }
                    //Add code to the loop to check if the user put in text that isn't on the list and,
                    //if they did, tells the user their input is not on the list.
                    if (intList!=null)  //displays the index of the list that contains matching text on the screen
                    {
                        Console.WriteLine("\nitems are on index : ");
                        //Create a loop that iterates through the list and then displays the indices of the items matching
                        //the user-selected text.
                        foreach (int item in intList)
                        {
                            Console.WriteLine("index : " + item);
                        }
                    }
                    //check if the user put in text that isn't on the list and, if they did,
                    //tells the user their input is not on the list
                    else            
                    {           
                        Console.WriteLine("that item isn't on the list ");
                    }
                    break;
                case 6:
                    //CONSOLE APP PART SIX SUBMISSION ASSIGNMENT
                    Console.WriteLine("CONSOLE APP PART FOUR ASSIGNMENT.");
                    //Create a list of strings that has at least two identical strings in the list.
                    string[] colors6 = { "yellow", "blue", "black", "white", "red", "pink", "red", "purple", "marrow", "dark", "ligth", "blue", "black", "yellow"};
                    int idx = 0;
                    int? indx = null;
                    Console.WriteLine("option colors \"yellow\", \"blue\", \"black\", \"white\", \"red\", \"pink\", \"red\", \"purple\", \"marrow\", \"dark\", \"ligth\", \"blue\", \"black\", \"yellow\" ");
                    //foreach loop that evaluates each item in the list
                    foreach (string color6_a in colors6)
                    {
                        for (int i= 0; i<idx; i++)
                        {
                            if (color6_a== colors6[i])
                            {
                                indx = i;
                            }
                        }
                        
                        if (indx != null) //and displays a message showing the string and whether or not it has already appeared in the list.
                        {
                            Console.WriteLine("the color "+ color6_a+"  HAS ALREADY appeared in the list");
                        }
                        else
                        {
                            Console.WriteLine("the color " + color6_a + " not it has already appeared in the list");
                        }
                        idx++;
                        indx = null;
                    }
                    break;
                case 7:
                    //Console.WriteLine("Presione any key to finish...");
                    break;
                default:
                    Console.WriteLine("Enter a menu option");
                    break;
            }
            Console.WriteLine("\nInput any key to continue");
            Console.ReadLine();
            //Console.Clear();
        } while (menu != 7);
        
    }
}
