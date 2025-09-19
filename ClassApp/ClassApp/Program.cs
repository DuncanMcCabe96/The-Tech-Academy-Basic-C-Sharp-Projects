using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            MathOperations mathOps = new MathOperations();

            // Call Division method
            mathOps.Division(UserNumber);

            // Call MultiplyByTwo method using out parameter
            int doubledNumber;
            mathOps.MultiplyByTwo(UserNumber, out doubledNumber);
            Console.WriteLine("Doubled number: " + doubledNumber);

            double userDouble = 15.5; // example double number
            mathOps.Division(userDouble); // calls the overloaded method

            Helper.PrintWelcomeMessage(); // no need to create an instance

        }
    }
}
