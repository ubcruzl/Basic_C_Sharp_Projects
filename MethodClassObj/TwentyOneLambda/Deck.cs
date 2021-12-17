using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneLambda
{
    public class Deck
    {
        public Deck()
        {
            /*
            Cards = new List<Card>();   
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suit = "Hearts";
            Cards.Add(cardOne);
            */
            /*
             * Enum
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts","Diamons","Spades"};
            List<string> Faces = new List<string>() 
            {
                "Two","Three", "Four","Five","Six","Seven","Eight","Nine","Ten","Jack", "Queen","King","Ace"
            };
            foreach (string face in Faces)
            {
                // Enum
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    //card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
                //
            }
            */
            Cards = new List<Card>();

            for (int i=0; i<13; i++)
            {
                for (int j=0;j<4;j++)   //there is going be 52 four
                {
                    Card card= new Card();
                    card.Face = (Face)i;              //casting two face
                    card.Suit = (Suits)j;
                    Cards.Add(card);
                }

            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }

}
