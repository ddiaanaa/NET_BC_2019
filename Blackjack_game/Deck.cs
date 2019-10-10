using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    class Deck
    {
        string[] suits = new[] { "C", "S", "D", "H" };
        string[] ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "D" };

        List<Card> cards;
        public Deck()
        {
            List<Card> cards = new List<Card>();
            foreach(string suit in suits)
            {
                foreach(string rank in ranks)
                {
                    cards.Add(new Card(rank, suit));
                }
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            cards = cards.OrderBy(c => rnd.Next()).ToList();
            //google sameklēt
        }
        public Card GetCard()
        {
            Card card = cards.Last();
            cards.Remove(card);

            return card;
        }
    }
}
