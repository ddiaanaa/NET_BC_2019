using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    class BasePlayer : IPlayer
    {
        public string Name;
        public int CurrentGuess;
        public bool IsNumberGuessed(int number)
        {
            return false;
        }
        abstract string GetName()
        {

        }
    }
}
