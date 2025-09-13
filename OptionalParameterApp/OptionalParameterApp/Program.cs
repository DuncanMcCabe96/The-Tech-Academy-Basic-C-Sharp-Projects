using System;

namespace OptionalParameterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask user for the first number
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // Ask user for the second number (optional)
            Console.Write("Enter the second number (or press Enter to skip): ");
            string secondInput = Console.ReadLine();

            int result;

            // If the user entered a second number, parse and pass both numbers
            if (!string.IsNullOrWhiteSpace(secondInput))
            {
                int secondNumber = Convert.ToInt32(secondInput);
                result = mathOps.DoMath(firstNumber, secondNumber);
            }
            else
            {
                // If no second number, call method with only the first number
                result = mathOps.DoMath(firstNumber);
            }

            // Display the result of the math operation
            Console.WriteLine("Result of operation: " + result);

            // Pause so user can read result before program closes
            Console.ReadLine();
        }
    }
}
