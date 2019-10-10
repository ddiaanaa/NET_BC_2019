using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    public class Game
    {
        private int CurrentNumber;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;
        /// <summary>
        /// 1. Method generates a new random number (1 -500) and sets it in a variable "CurrentNumber".
        /// 2. Create variables PlayerOne and PlayerTwo.
        /// 2.1. PlayerOne = User;
        /// 2.2. PlayerTwo = Robot.
        /// </summary>
        public void StartNewGame()
        {
            CurrentNumber = new Random().Next(1, 500);

            PlayerOne = new User();
            PlayerTwo = new Robot();
        }
        /// <summary>
        /// 1. Main game loop which contains PlayerOne turn and PlayerTwo turn:
        /// 1.1. PlayerOne guesses the number:
        /// 1.1.1 If guess is correct, break the loop and PlayerOne wins;
        /// 1.2. PlayerTwo guesses the number:
        /// 1.2.1 If guess is correct, break the loop and PlayerTwo wins.
        /// </summary>
        public void Loop()
        {
            while(true)
            {
                Console.WriteLine("Player one turn: ");
                if(PlayerTurn(PlayerOne))
                {
                    break;
                }
                Console.WriteLine("Player two turn: ");
                if(PlayerTurn(PlayerTwo))
                {
                    break;
                }
            }
        }
        /// <summary>
        /// Bool method which calls IPlayer method 'GuessNumber'. 'GuessNumber' checks and returns bool result if "number" is equal, less or greater to "CurrentGuess".
        /// </summary>
        /// <param name="player">number</param>
        /// <returns>bool true/false</returns>
        private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool IsGuessed = player.IsNumberGuessed(CurrentNumber);

            if(IsGuessed)
            {
                Console.WriteLine("Player {0} wins", player.GetName());
            }
            return IsGuessed;
        }
    }
}