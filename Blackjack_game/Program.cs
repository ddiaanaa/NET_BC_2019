using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Game game = new Game();
                game.StartNewGame();
                game.Loop();
                Console.Read();

            }
        }
    }
}
