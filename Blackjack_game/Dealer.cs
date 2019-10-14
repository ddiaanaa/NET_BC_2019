using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    public class Dealer : BasePlayer
    {
        private const string dealerName = "Mr. Dealer";

        public override string GetName()
        {
            return dealerName;
        }

        public override bool WantCard()
        {
            return CountPoints() < 17;
        }
    } 
}
