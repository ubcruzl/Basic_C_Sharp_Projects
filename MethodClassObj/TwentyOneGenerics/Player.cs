using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGenerics
{
    public class Player <T>
    {
        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivePlaying { get; set; }

        //public static Game operator+ (Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}
        //public static Game operator- (Game game, Player player)
        //{
        //    game.Players.Remove(player);
        //    return game;
        //}
    }
}
