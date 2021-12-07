using System;
using System.Text;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        /*
        int[] testScores = { 2, 4, 5, 6, 7, 8, 9, 12, 13, 15, 16, 18, 3 };

        for (int i=0; i<testScores.Length; i++)
        {
            if (testScores[i] > 8)
            {
                Console.WriteLine("Passing test score "+testScores[i]);
            }
        }
        
        string[] color = { "yellow", "blue", "black", "White", "Red", "Pink","Purple","Marrow"};
        for(int j = 0; j < color.Length; j++)
        {
            if (color[j]=="yellow")
            Console.WriteLine("The color is: " + color[j]);
        }
        Console.ReadLine();
        */
        List<int> testScores = new List<int>();
        testScores.Add(98);
        testScores.Add(34);
        testScores.Add(35);
        testScores.Add(12);
        testScores.Add(87);
        testScores.Add(56);
        testScores.Add(6);

        foreach(int score in testScores)
        {
            if (score > 40)
            {
                Console.WriteLine("Passing test score: "+score);
            }
        }
        

        string[] colors = { "yellow", "blue", "black", "White", "Red", "Pink", "Purple", "Marrow" };

        foreach (string color in colors)
        {
            if (color == "yellow")
            {
                Console.WriteLine("Passing test score: " + color);
            }
        }
        List<int> scores=new List<int>() { 2, 4, 5, 6, 7, 8, 9, 12, 13, 15, 16, 18, 3 };
        List<int> passingScores = new List<int>();
        foreach(int score in scores)
        {
            if (score > 5)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);

        Console.ReadLine();
    }
}