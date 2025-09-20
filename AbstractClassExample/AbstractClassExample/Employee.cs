using System;

namespace AbstractClassExample
{
    // Employee inherits from Person
    public class Employee : Person
    {
        // Implement the abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
