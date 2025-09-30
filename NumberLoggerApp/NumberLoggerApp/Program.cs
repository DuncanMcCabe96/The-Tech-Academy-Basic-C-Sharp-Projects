using System;
using System.IO;  // Needed for working with files

namespace NumberLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine(); // Read user input as a string

            // Define a file path where we will save the number
            // (This will create the file in the same folder as the program’s executable)
            string filePath = "numberLog.txt";

            // Write the user’s number into the text file
            File.WriteAllText(filePath, userInput);

            // Read the text file back
            string fileContents = File.ReadAllText(filePath);

            // Print the contents of the file back to the user
            Console.WriteLine("\nThe file contains:");
            Console.WriteLine(fileContents);

            // Keep console open until user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
