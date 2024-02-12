using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight is greater than 50
        if (weight > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user for package dimensions
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate the total dimensions
        double dimensionsTotal = width + height + length;

        // Check if the dimensions total is greater than 50
        if (dimensionsTotal > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}