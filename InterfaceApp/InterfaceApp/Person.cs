using System;

namespace InterfaceApp
{
    // Abstract class Person with FirstName and LastName
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void SayName();
    }
}
