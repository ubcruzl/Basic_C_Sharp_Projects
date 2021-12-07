using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    class Numeros
    {
        //public int number1 { get; set; }
        //public int number2 { get; set; }

        //methods  will take one integer parameter in and return an integer.
        public int MyMethod1(int millas)    
        {
            //convert miles to kilometers
            int kms = Convert.ToInt32(millas*1.60934);
            return kms;
        }
        //methods  will take one integer parameter in and return an integer.
        public int MyMethod2(int farenheit)
        {
            //	conversion (32 °F − 32) × 5 / 9 = 0 °C
            int centigrados = (32 * farenheit) * 5 / 9;
            return centigrados;
        }
        //methods  will take one integer parameter in and return an integer.
        public int MyMethod3(int pesosMx)
        {
            int tasa_cambio = 22;
            int conversion = pesosMx / tasa_cambio;
            return conversion;
        }
    }
}
