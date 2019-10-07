using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    public abstract class BasePlayer : IPlayer
    {
        public string Name;
        public int CurrentGuess;

        public BasePlayer()
        {
            Name = GetName();
        }
        public virtual bool IsNumberGuessed(int number)
        {
            if(number == CurrentGuess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract string GetName();
        public abstract int GuessNumber();
      
    }
}
