using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceQualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask applicant for their age   
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // Convert.ToInt32() is used to convert the string input from Console.ReadLine() to an integer.

            //Ask applicant if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool hasDui = Convert.ToBoolean(Console.ReadLine());
            //Convert.ToBoolean() is used to convert the string input from Console.ReadLine() to a boolean value.

            //ask the applicant how many speeding tickets they have had
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            // Convert the string input into an integer.

            // apply the qualification rules:
            // 1. Applicant must be older thanm 15
            // 2. Applicant must not have had a DUI
            // 3. Applicant must have had less than 3 speeding tickets
            bool isQualified = (age > 15 && !hasDui && speedingTickets < 3);

            //Display the qualification result
            Console.WriteLine("Qualified? " + isQualified);
        }
    }
}
