using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction
{
    public class User : BasePlayer
    {
        public override string GetName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        public override int GuessNumber()
        {
            Console.WriteLine("Enter positive integer: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}
