using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static DateTime Birth(DateTime birtdate)
        {

            Console.WriteLine("Enter your birth date: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthdate))
            {
                return birtdate;
            }
            else
            {
                Console.WriteLine("Invalid date!");                
            }
        }
        static void Gender()
        {

        }
        static void FullName()
        {

        }
    }
}
