using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            // Ask the user to enter a number to divide each item in the list by
            Console.WriteLine("Please enter a number to divide each number in the list by:");

            try
            {
                // Read the user input from the console
                string userInput = Console.ReadLine();

                // Attempt to convert the user input into an integer
                int divisor = Convert.ToInt32(userInput);

                // Loop through each number in the list
                foreach (int number in numbers)
                {
                    // Perform the division and store the result
                    int result = number / divisor;

                    // Display the result to the screen
                    Console.WriteLine($"{number} divided by {divisor} equals {result}");
                }
            }
            catch (FormatException ex)
            {
                // Handle case where user input is not a valid number
                Console.WriteLine("Input was not a valid number. Error details: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                // Handle case where user enters zero as divisor
                Console.WriteLine("Cannot divide by zero. Error details: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // This block executes regardless of whether an error occurred or not
                Console.WriteLine("\nThe program has emerged from the try/catch block and continued execution.");
            }

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
