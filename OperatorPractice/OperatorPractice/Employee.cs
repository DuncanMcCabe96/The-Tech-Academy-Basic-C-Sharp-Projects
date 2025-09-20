using System;

namespace OperatorPractice
{
    // Employee class with properties and operator overloads
    public class Employee
    {
        // Property for unique employee identifier
        public int Id { get; set; }

        // Property for first name
        public string FirstName { get; set; }

        // Property for last name
        public string LastName { get; set; }

        // Overload "==" operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If only one is null, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare Ids for equality
            return emp1.Id == emp2.Id;
        }

        // Overload "!=" operator to match logic of "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals for consistency
        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            if (employee == null) return false;

            return this.Id == employee.Id;
        }

        // Override GetHashCode for consistency with Equals
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
