using System;

namespace AgeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell the user what the program does
            Console.WriteLine("Welcome to the Age Calculator!");
            Console.WriteLine("This program will calculate the year you were born based on your age.\n");

            try
            {
                // Prompt user for their age
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                // Convert input to integer
                int age = Convert.ToInt32(input);

                // Validate the input
                if (age <= 0)
                {
                    // Custom error message for invalid ages
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                }
                else
                {
                    // Use AgeCalculator class to compute birth year
                    int birthYear = AgeCalculator.CalculateBirthYear(age);

                    // Display the result
                    Console.WriteLine($"You were born in the year {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // This will catch errors if the user enters text instead of a number
                Console.WriteLine("Error: Please enter a valid numeric value for age.");
            }
            catch (Exception ex)
            {
                // Catch any other unexpected exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Keep the console open until the user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
