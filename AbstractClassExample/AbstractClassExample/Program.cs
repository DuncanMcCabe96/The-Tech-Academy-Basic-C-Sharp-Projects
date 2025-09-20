using System;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set first and last name properties
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Call the SayName method to display the name
            employee.SayName();

            // Keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}
