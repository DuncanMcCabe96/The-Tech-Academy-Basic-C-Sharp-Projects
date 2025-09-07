using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------
            // 1. One-dimensional array of strings
            // -------------------------

            // Create an array of strings with some example values
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to choose an index from the array
            Console.WriteLine("Select an index of the string array (0 to " + (stringArray.Length - 1) + "):");

            // Read the user input
            string stringInput = Console.ReadLine();

            // Try to parse the input into an integer
            if (int.TryParse(stringInput, out int stringIndex))
            {
                // Check if the index is valid (within the bounds of the array)
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    // Display the string at the selected index
                    Console.WriteLine("You selected: " + stringArray[stringIndex]);
                }
                else
                {
                    // If the index is out of range, display an error message
                    Console.WriteLine("That index does not exist in the string array.");
                }
            }
            else
            {
                // If the user did not enter a valid integer
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Empty line for readability

            // -------------------------
            // 2. One-dimensional array of integers
            // -------------------------

            // Create an array of integers with some example values
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to choose an index from the integer array
            Console.WriteLine("Select an index of the integer array (0 to " + (intArray.Length - 1) + "):");

            // Read the user input
            string intInput = Console.ReadLine();

            // Try to parse the input into an integer
            if (int.TryParse(intInput, out int intIndex))
            {
                // Check if the index is valid (within the bounds of the array)
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    // Display the integer at the selected index
                    Console.WriteLine("You selected: " + intArray[intIndex]);
                }
                else
                {
                    // If the index is out of range, display an error message
                    Console.WriteLine("That index does not exist in the integer array.");
                }
            }
            else
            {
                // If the user did not enter a valid integer
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Empty line for readability

            // -------------------------
            // 3. List of strings
            // -------------------------

            // Create a list of strings with some example values
            List<string> stringList = new List<string>() { "Red", "Blue", "Green", "Yellow", "Purple" };

            // Ask the user to choose an index from the list
            Console.WriteLine("Select an index of the string list (0 to " + (stringList.Count - 1) + "):");

            // Read the user input
            string listInput = Console.ReadLine();

            // Try to parse the input into an integer
            if (int.TryParse(listInput, out int listIndex))
            {
                // Check if the index is valid (within the bounds of the list)
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    // Display the string at the selected index
                    Console.WriteLine("You selected: " + stringList[listIndex]);
                }
                else
                {
                    // If the index is out of range, display an error message
                    Console.WriteLine("That index does not exist in the string list.");
                }
            }
            else
            {
                // If the user did not enter a valid integer
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Pause the program so the console window doesn’t close immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
