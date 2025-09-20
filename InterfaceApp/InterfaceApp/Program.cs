using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Call SayName() method
            emp.SayName();

            // Use polymorphism: assign Employee to an IQuittable reference
            IQuittable quittableEmp = emp;

            // Call Quit() through the interface reference
            quittableEmp.Quit();

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
