using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    /// <summary>
    /// Public class 'User' inherits 'BasePlayer' class.
    /// </summary>
    public class User : BasePlayer
    {
        /// <summary>
        /// Method asks to enter user's name. Returns entered value(string).
        /// </summary>
        /// <returns>Name</returns>
        public override string GetName()
        {
            if(!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetName("Enter your name: ");            
        }
        /// <summary>
        /// Method asks to enter positive integer. Returns entered value(int).
        /// </summary>
        /// <returns>CurrentGuess</returns>
        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("Enter your guess: ");

            return CurrentGuess;
            /*Console.WriteLine("Enter positive integer: ");
            int number = int.Parse(Console.ReadLine());

            return number;*/
        }
    }
}
