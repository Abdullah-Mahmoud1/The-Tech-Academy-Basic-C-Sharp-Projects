using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask user for the package weight
        Console.WriteLine("Please enter the package weight:");
        // Read user input and convert to integer
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight is greater than 50
        if (weight > 50)
        {
            // Display error and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask user for the package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Ask user for the package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Ask user for the package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate total dimensions
        double dimensionTotal = width + height + length;

        // Check if total dimensions are greater than 50
        if (dimensionTotal > 50)
        {
            // Display error and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote using the formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency with two decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
