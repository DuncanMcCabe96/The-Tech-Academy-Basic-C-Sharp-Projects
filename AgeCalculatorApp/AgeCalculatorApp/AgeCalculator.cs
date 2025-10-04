using System;

namespace AgeCalculatorApp
{
    // This class is responsible for the logic of calculating birth year
    class AgeCalculator
    {
        // Static method to calculate birth year from given age
        public static int CalculateBirthYear(int age)
        {
            // Get the current year from the system
            int currentYear = DateTime.Now.Year;

            // Subtract the age from the current year to estimate birth year
            return currentYear - age;
        }
    }
}
