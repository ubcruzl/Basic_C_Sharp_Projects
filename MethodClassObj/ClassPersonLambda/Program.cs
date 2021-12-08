using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a list of at least 10 employees. 
            //Each employee should have a first and last name, as well as an Id.
            List<Employee> employeesOne = new List<Employee>();
            employeesOne.Add(new Employee(0, "Jaret", "En."));
            employeesOne.Add(new Employee(1, "Joe", "Jr."));
            employeesOne.Add(new Employee(2, "Michael", "Li."));
            employeesOne.Add(new Employee(3, "Joana", "Adam."));
            employeesOne.Add(new Employee(4, "Mary", "Fr."));
            employeesOne.Add(new Employee(5, "John", "Cl."));
            employeesOne.Add(new Employee(6, "Nicole", "Js."));
            employeesOne.Add(new Employee(7, "Karen", "Iaan."));
            employeesOne.Add(new Employee(8, "Samy", "Hb."));
            employeesOne.Add(new Employee(9, "Richie", "Mr."));
            employeesOne.Add(new Employee(10, "Joe", "Dr."));   //At least two employees should have the first name “Joe”.
            Console.WriteLine("List employeesOne: \n");
            employeesOne.ForEach(emply => Console.WriteLine(emply.Id + " " + emply.FirstName + " " + emply.LastName));

            List<Employee> employeesJoe = new List<Employee>();

            //Using a foreach loop, create a new list of all employees with the first name “Joe”
            foreach (Employee employee in employeesOne)
            {
                if (employee.FirstName== "Joe")
                {
                    employeesJoe.Add(employee);
                }
                
            }

            Console.WriteLine("\nList employeesJoe: \n");
            employeesJoe.ForEach(emply => Console.WriteLine(emply.Id+" "+emply.FirstName+" "+emply.LastName));

            //Perform the same action again, but this time with a lambda expression.

            ////////////////////////////////////////////////////////////////////////////////
            //Perform the same action again, but this time with a lambda expression.

            List<Employee> employeesJoeLambda = new List<Employee>();
            employeesJoeLambda=employeesOne.Where(x =>x.FirstName== "Joe").ToList();

            Console.WriteLine("\nList employeesJoeLambda: \n");
            employeesJoeLambda.ForEach(emply => Console.WriteLine(emply.Id + " " + emply.FirstName + " " + emply.LastName));

            Console.ReadLine();
        }
    }
}
