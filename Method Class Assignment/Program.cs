using System;

namespace DifferenceCheckerApp
{
    // Class responsible for performing subtraction and checking number parity
    class DifferenceChecker
    {
        // Method takes two numbers, subtracts 5 from the first, and describes the second
        public void CheckDifference(int baseNumber, int secondaryNumber)
        {
            int difference = baseNumber - 5; // Subtract 5 from the base number
            Console.WriteLine("Base number minus 5: " + difference); // Show the result

            // Check if secondary number is odd or even and display
            string parity = (secondaryNumber % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The second number (" + secondaryNumber + ") is " + parity + ".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a DifferenceChecker instance
            DifferenceChecker checker = new DifferenceChecker();

            // Positional argument method call
            checker.CheckDifference(15, 8);

            // Named argument method call
            checker.CheckDifference(secondaryNumber: 11, baseNumber: 20);
        }
    }
}
