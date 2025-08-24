using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();


            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();


            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // -------------------------------
            // 1. Multiply input by 50
            // -------------------------------
            Console.WriteLine("Enter a number to multiply by 50:");
            // Read user input and convert to long to handle very large numbers
            long input1 = Convert.ToInt64(Console.ReadLine());
            long result1 = input1 * 50;
            Console.WriteLine("Result of multiplying by 50: " + result1);

            // -------------------------------
            // 2. Add 25 to input
            // -------------------------------
            Console.WriteLine("\nEnter a number to add 25:");
            long input2 = Convert.ToInt64(Console.ReadLine());
            long result2 = input2 + 25;
            Console.WriteLine("Result of adding 25: " + result2);

            // -------------------------------
            // 3. Divide input by 12.5
            // -------------------------------
            Console.WriteLine("\nEnter a number to divide by 12.5:");
            double input3 = Convert.ToDouble(Console.ReadLine());  // Use double for fractional results
            double result3 = input3 / 12.5;
            Console.WriteLine("Result of dividing by 12.5: " + result3);

            // -------------------------------
            // 4. Check if input is greater than 50
            // -------------------------------
            Console.WriteLine("\nEnter a number to check if it is greater than 50:");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool isGreaterThan50 = input4 > 50;   // true if input > 50, false otherwise
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            // -------------------------------
            // 5. Find remainder when input is divided by 7
            // -------------------------------
            Console.WriteLine("\nEnter a number to find remainder when divided by 7:");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int remainder = input5 % 7;  // % operator gives remainder
            Console.WriteLine("Remainder when divided by 7: " + remainder);

            // Keep console open until user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
