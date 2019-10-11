using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    /// <summary>
    /// Interface with 3 methods 
    /// </summary>
    public interface IPlayer
    {
        int GuessNumber();
        bool IsNumberGuessed(int number);
        string GetName();
      
    }
}
