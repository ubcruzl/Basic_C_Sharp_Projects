using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassObjOverloading2
{
    class Numeros
    {
        public int number1 { get; set; }    //you are creating a Property. 
        public int number2 { get; set; }
        //method that will take in an integer,
        //
        //that class, create a method that takes two integers as parameters.
        //Make one of them optional
        public int methodTwo(int numberOne, int numberTwo=1000) 
        {
            //create a math operation for this integer (divided.),
            return numberOne + numberTwo;   //Have the method do a math operation and return an integer result.

        }

    }
}
