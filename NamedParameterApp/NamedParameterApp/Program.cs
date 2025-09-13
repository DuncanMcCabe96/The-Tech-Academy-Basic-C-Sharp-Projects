using System;

namespace NamedParameterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the ProcessNumbers method with positional parameters
            mathOps.ProcessNumbers(10, 5);

            Console.WriteLine(); // Blank line for readability

            // Call the ProcessNumbers method with named parameters
            mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 3);

            // Keep the console window open so user can see output
            Console.ReadLine();
        }
    }
}
