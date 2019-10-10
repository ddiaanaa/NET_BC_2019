using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    public class Robot : BasePlayer
    {
        /// <summary>
        /// Method that returns string text 'Robot'
        /// </summary>
        /// <returns>text 'ROBOT'</returns>
        public override string GetName()
        {
            return ("ROBOT");
        }
        /// <summary>
        /// Method that generates random number from 1 to 500 and store it in the variable 'CurrentGuess'. Returns generated number. Speed is 1000 ms. 
        /// </summary>
        /// <returns>int CurrentGuess</returns>
        public override int GuessNumber()
        {
            Thread.Sleep(1000);
            if(NextGuess ==0)
            {
                CurrentGuess = new Random().Next(1, 501);
            }
            else if(NextGuess == -1)
            {
                CurrentGuess = new Random().Next(1, 501);
            }
            else if (NextGuess == 1)
            {
                CurrentGuess = new Random().Next(1, 501);
            }           

            return CurrentGuess;
        }

    }
}
