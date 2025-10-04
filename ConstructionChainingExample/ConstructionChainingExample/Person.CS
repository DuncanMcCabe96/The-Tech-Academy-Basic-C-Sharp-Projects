using System;

namespace ConstructorChainingExample
{
    // A simple class to demonstrate constructor chaining
    class Person
    {
        // Properties of the Person class
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor 1: Takes no arguments, sets default values
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Constructor 2: Takes one argument, but also chains to the first constructor
        public Person(string name) : this()
        {
            // The ": this()" part above calls the first constructor
            // Then, we overwrite the default Name with the one provided
            Name = name;
        }

        // A method to display the person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
