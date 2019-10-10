using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    class BasePlayer : IBlackjackPlayer //inheritance
    {
        public int CountPoints() //in
        {
            int points = Cards.Sum(c => c.GetPoits() == 11);
            }
        }

        public List<Card> GetCards()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void GiveCard(Card card)
        {
           Cards.Add(card);
        }

        public bool IsGameCompleted()
        {
            return CountPoints() > 21;
        }

        public bool WantCard()
        {
            throw new NotImplementedException();
        }
    }
}
