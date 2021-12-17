using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneEnum
{
    class TwentyOneGame: Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to 21:  ");
            base.ListPlayers(); 
        }
        public void walkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
