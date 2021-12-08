using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //give it the property “Amount” and have it be of data type decimal.
            Number number = new Number();
            number.Amount = 12.4334m;
            number.Amount = 12.4334m;
            //Print this amount to the console.
            Console.WriteLine("Struct Amount "+ number.Amount);
            Console.ReadLine();
        }
    }
    //Create a struct called Number

    public struct Number
    {
        //give it the property “Amount” and have it be of data type decimal.
        public decimal Amount;
    }
}
