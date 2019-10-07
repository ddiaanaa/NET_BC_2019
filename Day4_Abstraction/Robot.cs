using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    public class Robot : BasePlayer
    {
        public override string GetName()
        {
            return ("ROBOT");
        }
        public override int GuessNumber()
        {
            Random randomNumberGenrator = new Random();
            int CurrentGuess = randomNumberGenrator.Next(1, 500);

            return CurrentGuess;
        }

    }
}
