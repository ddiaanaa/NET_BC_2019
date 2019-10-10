using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_game
{
    class Card
    {
        // 2, 3, 4, ..., 10, J, Q, K, D
        string Rank { get; set; }
        //C -Clubs, D-Diamonds, S-Spades, H -Hearts
        string Suit { get; set; }

        public Card(string suit, string rank)
        {
           Rank = rank;
           Suit = suit;
        }
        string GetTitle()
        {
            string title = "";
            //vispirms kārts masts
            switch(Suit)
            {
                case "H": title = "Ercs";
                    break;
                case "D": title = "Kāravs";
                    break;
                case "C": title = "Kreicis";
                    break;
                case "S":
                    title = "Pīķis";
                    break;

            }
            //tad pievieno klāt karts rangu
            switch(Rank)
            {
                case "D": title += " Dūzis";
                    break;
                case "Q": title += " Dāma";
                    break;
                case "K":
                    title += " Karalis";
                    break;
                case "J":
                    title += " Kalps";
                    break;
                case "10":
                    title += " 10";
                    break;
                case "9":
                    title += " 9";
                    break;
                case "8":
                    title += " 8";
                    break;
                case "7":
                    title += " 7";
                    break;
                case "6":
                    title += " 6";
                    break;
                case "5":
                    title += " 5";
                    break;
                case "4":
                    title += " 4";
                    break;
                case "3":
                    title += " 3";
                    break;
                case "2":
                    title += " 2";
                    break;          

            }
            return Suit + Rank;
        }
        int GetPoints()
        {            
            switch(Rank)
            {
                case "D": return 11;
                    
                case "Q":                
                case "K":
                case "J": return 10;
                default: return int.Parse(Rank);    
                
            }  
        }
    }
}
