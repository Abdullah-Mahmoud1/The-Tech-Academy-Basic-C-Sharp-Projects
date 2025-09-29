using System;

namespace EmployeeEqualityApp3
{
    // Employee class that compares Ids using overloaded operators and a helper method
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Static helper to compare IDs
        public static bool AreEqual(Employee a, Employee b)
        {
            return a == b; // Use overloaded operator
        }

        public static bool operator ==(Employee a, Employee b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Id == b.Id;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // First employee
            var emp1 = new Employee { Id = 300, FirstName = "Abdullah", LastName = "Mahmoud" };

            // Second employee with same ID
            var emp2 = new Employee { Id = 300, FirstName = "A.", LastName = "Mahmoud" };

            // Use static method to compare
            bool equal = Employee.AreEqual(emp1, emp2);
            Console.WriteLine("Are employees equal (by ID)? " + equal);
        }
    }
}
