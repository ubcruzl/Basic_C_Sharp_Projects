using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Encapsulation, is to make sure that "sensitive" data is hidden from users.

namespace Casino
{             
    public struct Card                              //declarar campos / variables como private
    {                
        public Suits Suit { get; set; }    //you are creating a Property. 
        public Face Face { get; set; }       //The get method returns the value of the variable name./The set method assigns a value to the name variable

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suits
    {
        Clubs,Diamons,Hearts,Spades
    }
    public enum Face
    {
        Two,Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
}
