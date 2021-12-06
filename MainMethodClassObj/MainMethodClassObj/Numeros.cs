using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodClassObj
{
    class Numeros
    {
        public int integer { get; set; }    //you are creating a Property. 
        public int deciml { get; set; }
        //method that will take in an integer,
        //

        public int methodOne(int number) 
        {
            //create a math operation for this integer (addition, subtraction, etc.),
            return number * number;   //return the answer as an integer. 
        }

        public int methodOne(decimal number)
        {
            //create a math operation for this integer (addition, subtraction, etc.),
            return Convert.ToInt32(number+number);   //return the answer as an integer. 
        }
        public int methodOne(string number)
        {
            //create a math operation for this integer (addition, subtraction, etc.),
            try
            {
                return Convert.ToInt32(number+1000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
