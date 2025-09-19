using System;

namespace PersonEmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and initialize its properties
            Employee employee = new Employee
            {
                FirstName = "Sample",  // Set the first name
                LastName = "Student",  // Set the last name
                Id = 1                 // Set the employee ID
            };

            // Call the SayName() method inherited from the Person class
            employee.SayName();

            // Pause the console so the output stays visible
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
