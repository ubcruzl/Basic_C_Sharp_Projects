using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonParametersAssignment
{
    // class called Employee and have it inherit from the Person class.
    class Employee<T>: Person            //Make the Employee class take a generic type paramete
    {
        
        public int Id { get; set; }
        //Add a property to the Employee class called “things”
        //have its data type be a generic list matching the generic type of the class
        public List<T> things { get; set; }     //
    }

}
