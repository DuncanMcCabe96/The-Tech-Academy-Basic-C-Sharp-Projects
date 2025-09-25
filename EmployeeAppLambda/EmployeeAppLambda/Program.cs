using System;
using System.Collections.Generic;
using System.Linq; // Needed for lambda expressions

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees with at least 10 entries, including at least two named "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Bill", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Sara", LastName = "Miller" },
                new Employee { Id = 6, FirstName = "Mike", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "Anna", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Chris", LastName = "Brown" },
                new Employee { Id = 9, FirstName = "Laura", LastName = "White" },
                new Employee { Id = 10, FirstName = "Tom", LastName = "Clark" }
            };

            // ---------- Using foreach loop ----------
            // Create a new list of employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (Employee emp in employees)
            {
                // Check if the FirstName property equals "Joe"
                if (emp.FirstName == "Joe")
                {
                    joesForeach.Add(emp); // Add to the new list
                }
            }

            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (Employee joe in joesForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // Blank line for readability

            // ---------- Using lambda expression ----------
            // Filter employees with FirstName == "Joe"
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            Console.WriteLine("Employees named Joe (lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // Blank line for readability

            // ---------- Using lambda expression with Id filter ----------
            // Filter employees with Id greater than 5
            List<Employee> idGreaterThan5 = employees.Where(emp => emp.Id > 5).ToList();

            Console.WriteLine("Employees with Id > 5:");
            foreach (Employee emp in idGreaterThan5)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Prevent console from closing immediately
            Console.ReadLine();
        }
    }
}
