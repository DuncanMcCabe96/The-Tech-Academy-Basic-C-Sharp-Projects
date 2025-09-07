using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Part 1: Concatenate three strings ---
            string firstName = "Duncan";          // First string
            string middleName = "James";          // Second string
            string lastName = "McCabe";           // Third string

            // Concatenating the three strings into one full name
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the concatenated result
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine();  // Empty line for readability


            // --- Part 2: Convert a string to uppercase ---
            string phrase = "This text will be converted to uppercase.";

            // Using the ToUpper() method to convert all characters to uppercase
            string upperPhrase = phrase.ToUpper();

            // Display the converted string
            Console.WriteLine("Original phrase: " + phrase);
            Console.WriteLine("Uppercase phrase: " + upperPhrase);
            Console.WriteLine();


            // --- Part 3: Use StringBuilder to build a paragraph ---
            // StringBuilder is efficient for building or modifying strings in a loop
            StringBuilder paragraph = new StringBuilder();

            // Appending sentences one at a time
            paragraph.Append("This is the first sentence of the paragraph. ");
            paragraph.Append("Here comes the second sentence, which adds more detail. ");
            paragraph.Append("Finally, this is the third sentence to wrap things up.");

            // Display the completed paragraph
            Console.WriteLine("Paragraph built with StringBuilder:");
            Console.WriteLine(paragraph.ToString());

            // Pause the program so user can read the output before the console closes
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
