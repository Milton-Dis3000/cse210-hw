using System;

class Program
{
    static void Main(string[] args)
    {
        // Create and test fractions using different constructors.

        // Test default constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine();

        // Test one-parameter constructor (e.g., 5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine();

        // Test two-parameter constructor (e.g., 3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine();

        // Test two-parameter constructor (e.g., 1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Console.WriteLine();

        // Test getters and setters functionality.
        Console.WriteLine("Testing Getters and Setters:");
        Console.WriteLine($"Original fraction1: {fraction1.GetFractionString()}");

        fraction1.SetTop(6);    // Change numerator
        fraction1.SetBottom(7); // Change denominator

        Console.WriteLine($"Modified fraction1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Modified fraction1 decimal: {fraction1.GetDecimalValue()}");

        Console.WriteLine();

        // Another test with getters and setters
        Fraction fraction5 = new Fraction();
        fraction5.SetTop(10);
        fraction5.SetBottom(2);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        Console.WriteLine();

        // Test handling of zero denominator.
        Console.WriteLine("Testing zero denominator handling:");
        Fraction fraction6 = new Fraction(1, 1);
        fraction6.SetBottom(0); // This should trigger the warning in SetBottom
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());
    }
}