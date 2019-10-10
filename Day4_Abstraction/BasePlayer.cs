using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    /// <summary>
    /// Create abstract class BasePlayer that inherites IPlayer interface
    /// </summary>
    public abstract class BasePlayer : IPlayer
    {
        /// <summary>
        /// Variable definition
        /// </summary>
        public string Name;
        /// <summary>
        /// Variable definition
        /// </summary>
        protected int CurrentGuess;
        /// <summary>
        /// Variable definition
        /// </summary>
        public int NextGuess;

        /// <summary>
        /// Constructor that sets 'Name' as GetName() returned string
        /// </summary>        
        public BasePlayer()
        {
            Name = GetName();
        }
        /// <summary>
        /// Checks and returns bool result if "number" is equal, less or greater to "CurrentGuess"
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>true/false</returns>
        public virtual bool IsNumberGuessed(int number)
           
        {
            if(number > CurrentGuess)
            {
                Console.WriteLine("{0} is less then number", CurrentGuess);
                NextGuess = 1;
            }
            else if(number<CurrentGuess)
            {
                Console.WriteLine("{0} is greater then number", CurrentGuess);
                NextGuess = -1;
            }
            return number == CurrentGuess;//saīsinājums if (number == CurrentGuess){return true}
        }
        /// <summary>
        /// Abstract method
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();
        /// <summary>
        /// abstract method
        /// </summary>
        /// <returns></returns>
        public abstract int GuessNumber();
      
    }
}
