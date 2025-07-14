using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for .Min() with a condition (for smallest positive)

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1; 

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input); 

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Core Requirement: Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement: Compute the average
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("The list is empty, cannot compute average.");
        }

        // Core Requirement: Find the maximum number
        if (numbers.Count > 0)
        {
            int max = numbers[0]; 
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("The list is empty, cannot find largest number.");
        }

        // Stretch Challenge: Find the smallest positive number
        // Using LINQ's Where and Min methods for a concise solution.
        // First, filter for positive numbers, then find the minimum among them.
        if (numbers.Any(n => n > 0)) // Check if there are any positive numbers
        {
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers in the list.");
        }

        // Stretch Challenge: Sort the numbers and display the new, sorted list
        if (numbers.Count > 0)
        {
            numbers.Sort(); // Sorts the list in ascending order
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("The list is empty, cannot sort.");
        }
    }
}
