using System;

namespace OptionalParameterApp
{
    // This class holds our custom math operation method
    public class MathOperations
    {
        // Method that takes two integers, with the second parameter being optional (default = 5)
        public int DoMath(int firstNumber, int secondNumber = 5)
        {
            // Perform a math operation: add the two numbers
            return firstNumber + secondNumber;
        }
    }
}
