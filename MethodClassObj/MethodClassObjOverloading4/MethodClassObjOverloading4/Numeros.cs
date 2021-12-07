using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace MethodClassObjOverloading4
{
    class Numeros
    {
        //
        //Create a class. In that class, create a void method that outputs an integer.
        //
        //Have the method divide the data passed to it by 2
        public void methodDivided(int numberIN, out int numberOUT)     // out int numberOUT return/outputs an integer
        {
            numberOUT = numberIN / 2;       //method divide the data passed to it by 2

        }
        //Create a method with output parameters.
        public void methodOut(out int x)
        {
            x = 100;
        }

        //Overload a method.
        //
        public int methodOverloadSum(int x, int y)
        {
            return x + y;
        }
        //Overload a method.
        public int methodOverloadSum(int x, float y)
        {
            return (x + Convert.ToInt32(y));
        }

        public static int methodStaticMult(int x,int y)
        {
            return x * y;
        }
    }
}
