using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneLambda
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
            /*
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            */
            /*
            Deck deck = new Deck();
            int count = deck.Cards.Count(x=>x.Face==Face.Ace);
            Console.WriteLine(count);
            */
            /*
            Deck deck = new Deck();
            List<Card> newList = deck.Cards.Where(x=>x.Face==Face.King).ToList();
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face);
            }
            */
            List<int> numberList = new List<int>() { 0, 2, 3, 4, 5, 6};
            int sum = numberList.Sum(x => x + 5);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }

    }
}
