using System;

namespace PersonEmployeeApp
{
    // Define the Person class
    public class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }

        // Method to display the person's full name
        public void SayName()
        {
            // Concatenate first and last name and write it to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
