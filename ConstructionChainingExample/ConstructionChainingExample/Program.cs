using System;

namespace ConstructorChainingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable - this value cannot change during program execution
            const string greetingMessage = "Welcome to the Constructor Chaining Example!";

            // Print the const variable
            Console.WriteLine(greetingMessage);

            // Create a variable using the 'var' keyword
            // The compiler infers the type based on the assigned value (in this case, an int)
            var number = 42;
            Console.WriteLine("The value of 'var' variable is: " + number);

            // Create a new instance of the Person class using the constructor that takes one argument
            // This will call the chained constructor as well
            Person person = new Person("Alice");

            // Print the person's info
            person.DisplayInfo();

            Console.ReadLine();
        }
    }
}
