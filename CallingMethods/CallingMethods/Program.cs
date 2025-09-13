using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number to perform math operations on
            Console.WriteLine("Enter an integer to perform math operations on:");

            // Read the user input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Convert user input into an integer
                int inputNumber = Convert.ToInt32(userInput);

                // Create an instance of the MathOperations class
                MathOperations mathOps = new MathOperations();

                // Call AddTen() and display result
                int result1 = mathOps.AddTen(inputNumber);
                Console.WriteLine($"{inputNumber} + 10 = {result1}");

                // Call MultiplyByTwo() and display result
                int result2 = mathOps.MultiplyByTwo(inputNumber);
                Console.WriteLine($"{inputNumber} * 2 = {result2}");

                // Call SubtractFive() and display result
                int result3 = mathOps.SubtractFive(inputNumber);
                Console.WriteLine($"{inputNumber} - 5 = {result3}");
            }
            catch (FormatException ex)
            {
                // Handles case where input is not a valid integer
                Console.WriteLine("Invalid input. Please enter a valid integer. Error: " + ex.Message);
            }
            finally
            {
                // Ensures this always prints, confirming program continuation
                Console.WriteLine("\nThe program has finished executing.");
            }

            // Prevents console window from closing until user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
