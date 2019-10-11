using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    class Program
    {
        /// <summary>
        /// Main method, which calls 3 functions from the 'Game' class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartNewGame();
            game.Loop();
            Console.Read();
       
        }
    }
}
