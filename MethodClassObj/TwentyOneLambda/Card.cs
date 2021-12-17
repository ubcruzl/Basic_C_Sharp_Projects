using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Encapsulation, is to make sure that "sensitive" data is hidden from users.

namespace TwentyOneLambda
{             

    public class Card                              //declarar campos / variables como private
    {                
        //Enum
        //public Card()           //constructor
        //{                                       //A constructor is a special method that is used to initialize objects. The advantage of a constructor,
                                                //is that it is called when an object of a class is created.
                                                //It can be used to set initial values for fields:
            //Suit = "Spades";
            //Face = "Two";
        //}
                                               //setters make your object mutable,
        public Suits Suit { get; set; }    //you are creating a Property. 
        public Face Face { get; set; }       //The get method returns the value of the variable name./The set method assigns a value to the name variable
    }
    public enum Suits
    {
        Clubs,Diamons,Hearts,Spades
    }
    public enum Face
    {
        Two,Three, Four, Five, Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Ace
    }
}
