using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int num1 = GetNumber("Enter number 1: ");
            int num2 = GetNumber("Enter number 2: ");

            Console.WriteLine("Division is {0}", Calculator.Divide(num1, num2));
            }
            catch(CalculatorExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Neparedzēta kļūda!");
            }
            Console.Read();
        }
        static int GetNumber(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();

            if(int.TryParse(input, out int result))
            {
                return result;
            }
            try
            {
                int result1 = int.Parse(input);
                return result;
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number!");
                return GetNumber(text);
            }
        }
    }
}
