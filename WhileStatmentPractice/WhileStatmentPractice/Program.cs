using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatmentPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {// ------------------------------
            // Example 1: Boolean comparison with a while loop
            // ------------------------------

            int counter = 0; // Declare an integer variable to use as a counter

            // While loop will continue running as long as the condition is true
            // Here: loop runs while counter is less than 5
            while (counter < 5)
            {
                Console.WriteLine("While Loop: Counter is at " + counter); // Print the current counter value
                counter++; // Increment counter by 1 on each loop iteration
            }

            // At this point, counter = 5, so the while condition (counter < 5) is false and loop ends


            // ------------------------------
            // Example 2: Boolean comparison with a do-while loop
            // ------------------------------

            int number = 0; // Declare another integer variable

            // A do-while loop always runs at least once, even if the condition is false at the start
            do
            {
                Console.WriteLine("Do-While Loop: Number is at " + number); // Print the current number
                number++; // Increment number by 1
            }
            while (number < 3); // Condition checked AFTER loop body runs

            // This loop runs 3 times (for number values 0, 1, 2).
            // When number = 3, the condition (number < 3) becomes false, so the loop ends.

            // ------------------------------
            // End of program
            // ------------------------------
            Console.WriteLine("Program finished. Press any key to exit...");
            Console.ReadKey(); // Wait for user to press a key before closing the console window
        }
    }
}
