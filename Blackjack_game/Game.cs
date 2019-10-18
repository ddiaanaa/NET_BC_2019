using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;
   
        public void StartNewGame()
        {
            PlayerOne = new Player();//objects un new obligati iekavas aizmugure
            PlayerTwo = new Dealer();
            Deck = new Deck();

            Deck.Shuffle();
            for(int i=0; i<2; i++)
            {
                PlayerOne.GiveCard(Deck.GetCard());
                PlayerTwo.GiveCard(Deck.GetCard());
            }                       

        }
        public void Loop()
        {
            while(!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                //var card = new 
            }

        }

    }
}
