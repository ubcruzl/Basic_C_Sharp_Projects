using System;
using System.Collections.Generic;
using System.Linq;

class ArraySubmission
{
    static void Main()
    {
        //Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display
        //the string at that index on the screen.
        string[] arrayColor = new string[10] { "White", "Black", "Yellow", "Blue", "Red", "Green", "Gray","Marrow","Purple","Pink"};
        Console.WriteLine("enter a number (0-9) to describe a color:");
        int index=int.Parse(Console.ReadLine());    //input a number index
        if (index < 10)     //sentence 
        {
            Console.WriteLine("Your are choise a color: " + arrayColor[index]);
        }
        else                //sentence 
        {
            Console.WriteLine(" selects an index that doesn’t exist, press any key to continue...");
        }

        //Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display
        //the integer at that index on the screen.
        //Add in a message that displays when the user selects an index that doesn’t exist.

        int[] numArray = new int[30];
        int i = 0;
        do          //Loop do while
        {
            numArray[i] = (int)Math.Pow(2, i);      //Fill array whith  integers
            i++;
        }
        while (i < 30);

        Console.WriteLine("\nInput a index array number, 0-29:");
        int index1 = int.Parse(Console.ReadLine());
        if (index1 < 29)                                //sentence if
        {
            Console.WriteLine("Your are choise a number 2 pow index equal: " + numArray[index1]);
        }
        else                                            //sentence
        {
            Console.WriteLine(" selects an index that doesn’t exist, press any key to continue...");
        }
            
        //Create a list of strings. Ask the user to select an index of the list and then display the content at
        //that index on the screen.
        List<string> stringList = new List<string>();
            
        string text="Hello world, what a beautiful day";

        stringList = text.Split(' ').ToList();          //add items to the list
        /*
        foreach (string word in stringList)
        {
            Console.WriteLine(word);
        }
        */
        Console.WriteLine("\nsentence \"Hello world, what a beautiful day\" : ");
        Console.WriteLine("Input index 0-5 ");
        int index2 = int.Parse(Console.ReadLine());     //input a index
        if (index2 < stringList.Count)                                //sentence if index input less than length list
        {
            Console.WriteLine("Your a word in the sentence : " + stringList[index2]);
        }
        else
        {
            Console.WriteLine(" selects an index that doesn’t exist, press any key to continue...");
        }
        Console.ReadLine();
    }

}
