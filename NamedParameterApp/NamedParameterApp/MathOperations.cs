using System;

namespace NamedParameterApp
{
    // This class contains a method that performs a math operation and displays a value
    public class MathOperations
    {
        // Void method that takes two integers
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number: multiply by 2
            int processedFirst = firstNumber * 2;

            // Display the second number to the console
            Console.WriteLine("Second number: " + secondNumber);

            // Display the processed first number
            Console.WriteLine("Processed first number (firstNumber * 2): " + processedFirst);
        }
    }
}
