using System.Collections.Generic;

namespace GenericEmployeeApp
{
    // Generic Employee class that works with any type "T"
    public class Employee<T>
    {
        // A list of generic type "T" that stores the employee's things
        public List<T> Things { get; set; }
    }
}
