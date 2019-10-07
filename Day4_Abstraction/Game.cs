using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    class Game
    {
        public int CurrentNumber;
        IPlayer PlayerOne;
        IPlayer PlayerTwo;
        public void StartNewGame()
        {
            Random randomNumberGenrator = new Random();
            int CurrentGuess = randomNumberGenrator.Next(1, 500);
            
            User = PlayerOne;
            Robot = PlayerTwo;
        }
        public void Loop()
        {
            while(true)
            {
                PlayerTurn(PlayerOne);
                if(CurrentNumber == IPlayer.GuessNumber)
                {

                }
                PlayerTurn(PlayerTwo);
            }
        }
        public  void PlayerTurn(IPlayer player)
        {
            IPlayer.GuessNumber();
        }

    }
}
