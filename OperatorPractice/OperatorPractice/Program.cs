using System;

namespace OperatorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create second Employee object
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Display Employee 1 details
            Console.WriteLine("Employee 1: Id = {0}, Name = {1} {2}",
                emp1.Id, emp1.FirstName, emp1.LastName);

            // Display Employee 2 details
            Console.WriteLine("Employee 2: Id = {0}, Name = {1} {2}",
                emp2.Id, emp2.FirstName, emp2.LastName);

            // Compare employees using overloaded "=="
            Console.WriteLine("\nAre Employee 1 and Employee 2 equal (==)? " + (emp1 == emp2));

            // Compare employees using overloaded "!="
            Console.WriteLine("Are Employee 1 and Employee 2 not equal (!=)? " + (emp1 != emp2));

            // Pause to read results
            Console.ReadLine();
        }
    }
}
