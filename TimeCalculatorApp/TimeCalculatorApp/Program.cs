using System;  // Provides basic system functionality such as DateTime and Console

namespace TimeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Print the current date and time to the console
            DateTime currentTime = DateTime.Now; // Get the current system date and time
            Console.WriteLine("The current date and time is: " + currentTime);

            // 2. Ask the user for a number
            Console.WriteLine("\nPlease enter a number of hours to add:");
            string userInput = Console.ReadLine(); // Read the user input as a string

            // Try to safely convert the user input into an integer
            // If input is invalid (not a number), the program will handle it gracefully
            if (int.TryParse(userInput, out int hoursToAdd))
            {
                // 3. Calculate the new time by adding the given hours
                DateTime futureTime = currentTime.AddHours(hoursToAdd);

                // Print the result to the console
                Console.WriteLine($"\nIn {hoursToAdd} hours, the date and time will be: {futureTime}");
            }
            else
            {
                // If the input could not be converted to an integer, show an error message
                Console.WriteLine("\nInvalid input. Please enter a valid whole number.");
            }

            // Keep the console window open until the user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
