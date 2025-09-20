using System;

namespace InterfaceApp
{
    // Employee inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Implementation of SayName from Person
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implementation of Quit from IQuittable
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit their job. Goodbye!");
        }
    }
}
