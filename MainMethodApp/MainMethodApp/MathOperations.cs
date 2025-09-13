using System;

namespace MainMethodApp
{
    // This is our custom class that contains overloaded methods named "DoMath".
    public class MathOperations
    {
        // First method: takes an integer, adds 10, and returns the result.
        public int DoMath(int number)
        {
            return number + 10; // Perform addition and return result
        }

        // Second method: takes a decimal, multiplies by 2, then converts to int.
        public int DoMath(decimal number)
        {
            return (int)(number * 2); // Perform multiplication, cast to int, return result
        }

        // Third method: takes a string, converts it to an int, subtracts 5, and returns the result.
        public int DoMath(string numberString)
        {
            // Try to convert the string to an integer
            int number = Convert.ToInt32(numberString);

            return number - 5; // Perform subtraction and return result
        }
    }
}
