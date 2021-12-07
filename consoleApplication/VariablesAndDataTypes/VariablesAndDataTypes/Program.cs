using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            
            Console.WriteLine("What is you favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNumb = Convert.ToInt32(favoriteNumber);
            int total = favNumb + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();
            

            bool isStudying =false;
            byte hoursWorked=42;
            sbyte currentTemperature=-23;
            char questionMark = '\u2102';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.30202093;
            float secondLeft = 2.62f;
            short temperatureOnMars = -341;
            string myName = "Jesse";
            */
            /*
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
            */
            int num1 = 32342;
            int num2 = 5489576;

            int resultAdd = num1 + num2;
            int resulSustract = num2 - num1;
            int resultMultiply = num2 * num1;
            double resultDivide = num2/num1;
            int resultModules = num2 % num1;

            Console.WriteLine("num1=32342 + num2=5489576 ");
            Console.WriteLine("Result add num1 and num2 \n" + resultAdd);
            Console.WriteLine("Result subtract  num2 and num1  \n" + resulSustract);
            Console.WriteLine("Result multiply   num1 and num2  \n" + resultAdd);
            Console.WriteLine("Result Divide   num2 and num1  \n" + resultAdd);
            Console.WriteLine("Result modulus   num2 and num1  \n" + resultModules);
            

            int num_i = 893743;
            float num_f = 3.343f;
            float sum = num_i + num_f;
            float suma = num_i + (Int32)num_f;
            Console.WriteLine("Sum integer an float: "+ sum);
            Console.WriteLine("Sum integer an float: " + suma);
            

            double num1a = 7.82753823478324;
            float num2a = 2.2323f;
            float total1 = (float)num1a + num2a;
            Console.WriteLine("Sum double an integer:"+ total1);
            
            decimal num1d = 7.123124214m;
            int num2e = 5;
            decimal totald = num1d + num2e;
            Console.WriteLine("Sum decimal an integer: "+totald);

            decimal num1g = 7.123124214m;
            sbyte num2g = 4;
            decimal totalg = num1g + num2g;
            Console.WriteLine("Sum decimal an sbyte: " + totalg);
            

            string fname = "jean";
            string lname = "pierre";
            Console.WriteLine("string concatenation."+fname + fname+ lname);
            

            string names = "jean";
            int numbers = 343;
            Console.WriteLine("string and number concatenation." + names + numbers);
            

            string hola = "Hello, World,!";
            Console.WriteLine("Char, string: {0}", hola[1]);
            Console.WriteLine("subtring {0}", hola.Substring(3,7));

            int roomTemperature = 70;
            int currentTemperature = 72;
            //bool isWarm = currentTemperature > roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine("currentTemperature > roomTemperature:"+ isWarm);

            string cadena1="Hello, World,!";
            string búsqueda = "e";
            int posicion = 0;
            posicion = cadena1.IndexOf(búsqueda);
            while (posicion > 0)
            {
                Console.WriteLine("cadena encontrada en la posición {0}", posicion);
                posicion = cadena1.IndexOf(búsqueda, posicion + 1);
            }
            Console.WriteLine("fin de la búsqueda");
            Console.ReadLine();
        }
    }
}
