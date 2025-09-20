using System;

namespace AbstractClassExample
{
    // Abstract class Person with properties and abstract method
    public abstract class Person
    {
        // Properties for first name and last name
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName() - must be implemented in derived classes
        public abstract void SayName();
    }
}
