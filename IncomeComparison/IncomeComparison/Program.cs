using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get Person 1 details
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            // Read input, convert from string to decimal for accurate money handling
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            // Read input and convert to decimal as well
            decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            // Get Person 2 details
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            // Calculate annual salary for Person 1
            // Formula: hourly rate * hours per week * 52 weeks in a year
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;

            // Calculate annual salary for Person 2
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // Display Person 1's annual salary
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            // Display Person 2's annual salary
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare salaries and display result
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            // Keep console open until user presses Enter (optional for debugging)
            Console.ReadLine();
        }
    }
}
