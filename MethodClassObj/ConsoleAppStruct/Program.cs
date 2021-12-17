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
            //number.Amount = 12.4334m;
            //Print this amount to the console.
            Console.WriteLine("Struct Amount "+ number.Amount);

            // Create value type
            MyStruct testStruct = new MyStruct { MyProperty = "initial value" };
            testStruct.ChangeMyStruct(testStruct);
            // Value of testStruct.MyProperty is still "initial value"
            // - the method changed a new copy of the structure.

            Console.WriteLine(testStruct.MyProperty);

            // Create reference type
            MyClass testClass = new MyClass { MyProperty = "initial value" };
            testClass.ChangeMyClass(testClass);
            // Value of testClass.MyProperty is now "new value" 
            // - the method changed the instance passed.
            Console.WriteLine(testClass.MyProperty);
            Console.ReadLine();
        }
    }
    //Create a struct called Number

    public struct Number
    {
        //give it the property “Amount” and have it be of data type decimal.
        public decimal Amount;
        public string MyProperty { get; set; }

        public void ChangeMyStruct(Number input)
        {
            input.MyProperty = "new value";
        }
    }

    public struct MyStruct
    {
        public string MyProperty { get; set; }
        public void ChangeMyStruct(MyStruct input)
        {
            input.MyProperty = "new value";
        }
    }

    public class MyClass
    {
        public string MyProperty { get; set; }

        public void ChangeMyClass(MyClass input)
        {
            input.MyProperty = "new value";
        }
    }
}
