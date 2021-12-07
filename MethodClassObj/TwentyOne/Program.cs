using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Constructor
            //Card cardOne = new Card();
            //
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //////////////////////////////
            ///
            /*
            Deck deck = new Deck();
            deck.Cards = new List<Card>();

            Card cardOne = new Card();
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";

            deck.Cards.Add(cardOne);
            */
            ///////////////////////////////////
            /*
            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            */
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            //deck = Shuffle(deck,3);
            //deck = Shuffle(deck:deck,times:3);

            int timeShuffled = 0;
            deck = Shuffle(deck, out timeShuffled,3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        /*
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
        

        public static Deck Shuffle(Deck deck, int times)
        {
            for (int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
            }
            return deck;
        }
        */
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times=1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }

            return deck;
        }
    }
}
