using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneOperatorOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Game game = new Game();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";



            //Card card = new Card() {Face="King", Suit="Spades" };

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            ////Console.WriteLine("Times Shuffled: {0}",);
            ///
            /*
            TwentyOneGame game = new TwentyOneGame();
            //Game game = new TwentyOneGame();

            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.Play();
            game.ListPlayers();
            */
            /*
            List<Game> games = new List<Game>();
            TwentyOneGame game = new TwentyOneGame();
            games.Add(game);
            */
            /*
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            */
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player; //game = game + player;
            game -= player; //game = game - player;

            
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            
            Console.ReadLine();
        }
    }
}
