using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneAbstract
{
    class TwentyOneGame: Game
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
    }
}
