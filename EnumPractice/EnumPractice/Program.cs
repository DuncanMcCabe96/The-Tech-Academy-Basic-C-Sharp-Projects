using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (e.g., Monday):");

            // Read user input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Convert the user input into the DaysOfTheWeek enum
                // Enum.Parse attempts to match the string input to an enum value
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                // Output the result to confirm the enum value was assigned
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (Exception)
            {
                // If parsing fails, this block will run
                // Inform the user they need to enter a valid day
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep console open until user presses a key (optional)
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
