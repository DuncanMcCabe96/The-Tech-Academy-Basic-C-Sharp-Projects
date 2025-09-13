using System;

namespace MainMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class so we can call its methods
            MathOperations mathOps = new MathOperations();

            // Call the integer version of DoMath
            int intResult = mathOps.DoMath(15); // Pass in an integer
            Console.WriteLine("Result of integer method: " + intResult);

            // Call the decimal version of DoMath
            int decimalResult = mathOps.DoMath(12.5m); // Pass in a decimal (with 'm' suffix for decimal literal)
            Console.WriteLine("Result of decimal method: " + decimalResult);

            // Call the string version of DoMath
            int stringResult = mathOps.DoMath("20"); // Pass in a string that represents an integer
            Console.WriteLine("Result of string method: " + stringResult);

            // Keep console window open until user presses a key
            Console.ReadLine();
        }
    }
}
