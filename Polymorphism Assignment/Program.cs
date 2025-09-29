using System;

namespace QuittableApp
{
    // Interface with method definition
    public interface IQuittable
    {
        void Quit(); // Represents quitting action
    }

    // Employee class that implements IQuittable
    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Simulated exit interview during quitting
        public void Quit()
        {
            Console.WriteLine($"Exit interview with {FirstName} {LastName}...");
            Console.WriteLine("Reason for leaving: Career growth.");
            Console.WriteLine("Feedback recorded. Thank you and good luck!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating employee with name
            var emp = new Employee { FirstName = "Abdullah", LastName = "Mahmoud" };

            // Assigning to IQuittable type for polymorphism
            IQuittable quittableEmp = emp;

            // Calling Quit method via interface
            quittableEmp.Quit(); // Simulates an exit interview
        }
    }
}
