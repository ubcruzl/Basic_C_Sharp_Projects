using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            ConsoleColor color = ConsoleColor.Yellow;//
            DaysOfTheWeek day = DaysOfTheWeek.Friday;//

            Card card = new Card();
            card.Suit = Suits.Diamons;  //Enum
            int underlyingValue = Convert.ToInt32(Suits.Diamons);
            Console.WriteLine("underlyingValue " + underlyingValue);
            */

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }

    }
}
