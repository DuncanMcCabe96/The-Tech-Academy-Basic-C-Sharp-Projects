using System;
using System.Collections.Generic;

namespace GenericEmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object where T = string
            // "Things" will be a List<string>
            Employee<string> employeeString = new Employee<string>
            {
                Things = new List<string> { "Laptop", "Notebook", "Pen" }
            };

            // Create an Employee object where T = int
            // "Things" will be a List<int>
            Employee<int> employeeInt = new Employee<int>
            {
                Things = new List<int> { 101, 202, 303 }
            };

            // Print out all Things from the Employee<string> object
            Console.WriteLine("Employee<string> Things:");
            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            // Print out all Things from the Employee<int> object
            Console.WriteLine("\nEmployee<int> Things:");
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            // Keep console window open until user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
