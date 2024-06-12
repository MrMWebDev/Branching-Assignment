using System;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get package weight from the user
            Console.Write("Please enter the weight of your package: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                return;
            }

            // Get package width from the user
            Console.Write("Please enter the width of your package: ");
            int width = Convert.ToInt32(Console.ReadLine());

            // Get package height from the user
            Console.Write("Please enter the height of your package: ");
            int height = Convert.ToInt32(Console.ReadLine());

            // Get package length from the user
            Console.Write("Please enter the length of your package: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimenttionsTotal = width + height + height + length;
            if (dimenttionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Get quote for the user
            int quote = (width * height * length * weight) / 100;
            Console.WriteLine($"Your estimated total for this shipping is: ${quote:F2}");

            Console.Read();

        }
    }
}
