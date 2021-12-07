using System;
using System.Text;

class Program
{
    static void Main()
    {
        string sentence = "Hello World";
        string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
        string filename = @"C:\Users\Ubaldo\Documents\GitHub\VisualStudio\Basic_C_Sharp_Projects\SwitchStatement\SwitchStatement";

        Console.WriteLine("sentence "+ sentence);
        Console.WriteLine("quote " + quote);
        Console.WriteLine("filename " + filename);
        Console.WriteLine("sentence contain \"W\" ?" + sentence.Contains("W"));
        Console.WriteLine("sentence Ends \"d\" ?" + sentence.EndsWith("d"));
        Console.WriteLine("length sentence: " + sentence.Length);
        Console.WriteLine("toUpper sentence: " + sentence.ToUpper());
        Console.WriteLine("toLower sentence: " + sentence.ToLower());


        //use StringBuilder, which is a mutable string class. Mutability means that once an instance of the
        //class has been created, it can be modified by appending, removing, replacing, or inserting characters.
        //A StringBuilder object maintains a buffer to accommodate expansions to the string.
        //New data is appended to the buffer if room is available; otherwise, a new, larger buffer is allocated,
        //data from the original buffer is copied to the new buffer, and the new data is then appended to the new buffer.

       StringBuilder sb = new StringBuilder();
        sb.Append("My name is ubaldo");
        Console.WriteLine("StringBuilder: " + sb);
        Console.ReadLine();
    }
}
