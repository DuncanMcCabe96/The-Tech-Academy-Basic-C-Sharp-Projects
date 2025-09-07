using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================
            // 1. Array of strings and append user input
            // =========================================
            string[] phrases = { "Hello", "Welcome", "Goodbye", "See you", "Take care" };

            Console.WriteLine("Enter some text to append to each phrase:");
            string userInput = Console.ReadLine();

            // Append user's input to each array element
            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] = phrases[i] + " " + userInput;
            }

            // =========================================
            // 2. Loop using '<' operator
            // =========================================
            Console.WriteLine("\nLoop with '<' operator:");
            for (int i = 0; i < phrases.Length; i++)
            {
                Console.WriteLine($"Index {i}: {phrases[i]}");
            }

            // =========================================
            // 3. Loop using '<=' operator
            // =========================================
            Console.WriteLine("\nLoop with '<=' operator:");
            for (int i = 0; i <= phrases.Length - 1; i++)
            {
                Console.WriteLine($"Index {i}: {phrases[i]}");
            }

            // =========================================
            // 4. Unique list search (first match)
            // =========================================
            List<string> uniqueList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("\nEnter a fruit to search in the unique list:");
            string searchInputUnique = Console.ReadLine();

            bool foundUnique = false;
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i].Equals(searchInputUnique, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i} in unique list!");
                    foundUnique = true;
                    break; // Stop after first match
                }
            }
            if (!foundUnique)
            {
                Console.WriteLine("Your input is not on the unique list.");
            }

            // =========================================
            // 5. Duplicate list search (all matches)
            // =========================================
            List<string> duplicateList = new List<string> { "Red", "Blue", "Green", "Blue", "Yellow", "Red" };

            Console.WriteLine("\nEnter a color to search in the duplicate list:");
            string searchInputDuplicate = Console.ReadLine();

            bool foundDuplicate = false;
            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i].Equals(searchInputDuplicate, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i} in duplicate list!");
                    foundDuplicate = true;
                    // No break; show all matches
                }
            }
            if (!foundDuplicate)
            {
                Console.WriteLine("Your input is not on the duplicate list.");
            }

            // =========================================
            // 6. Foreach loop detecting duplicates
            // =========================================
            List<string> letters = new List<string> { "A", "B", "C", "D", "C", "A" };
            HashSet<string> seenItems = new HashSet<string>();

            Console.WriteLine("\nChecking list items for duplicates:");
            foreach (string letter in letters)
            {
                if (seenItems.Contains(letter))
                {
                    Console.WriteLine($"{letter} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{letter} - this item is unique");
                    seenItems.Add(letter);
                }
            }

            // =========================================
            // 7. Infinite loop fix with exit command
            // =========================================
            string command = "";
            while (command != "exit")
            {
                Console.WriteLine("\nType 'exit' to stop the loop or press Enter to see the updated phrases again:");
                command = Console.ReadLine();

                if (command != "exit")
                {
                    Console.WriteLine("\nUpdated phrases:");
                    foreach (string phrase in phrases)
                    {
                        Console.WriteLine(phrase);
                    }
                }
            }

            Console.WriteLine("Loop ended. Program finished.");
        }
    }
}
