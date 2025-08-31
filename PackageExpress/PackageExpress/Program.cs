using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine()); // Convert input string to integer

            // Check if the package weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program if package is too heavy
            }

            // Prompt the user for package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine()); // Convert input string to integer

            // Prompt the user for package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine()); // Convert input string to integer

            // Prompt the user for package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine()); // Convert input string to integer

            // Check if the sum of dimensions exceeds 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program if package is too large
            }

            // Calculate the quote using the formula:
            // quote = (width * height * length * weight) / 100
            int dimensionProduct = width * height * length; // Multiply the dimensions together
            int weightedProduct = dimensionProduct * weight; // Multiply by the weight
            decimal quote = weightedProduct / 100m; // Divide by 100, using 'm' to ensure decimal division

            // Display the shipping quote formatted as a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Thank the user
            Console.WriteLine("Thank you!");

            // Wait for user to press Enter before closing
            Console.ReadLine();
        }
    }
}
