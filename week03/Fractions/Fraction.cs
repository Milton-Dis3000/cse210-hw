using System;

public class Fraction
{
    // Private attributes for the numerator and denominator.
    // Encapsulation ensures these are accessed only via methods.
    private int _top;
    private int _bottom;

    // Constructor: Initializes the fraction to 1/1 (default).
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor: Initializes the fraction with a whole number (e.g., 5/1).
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor: Initializes the fraction with a given top and bottom number.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the numerator.
    public int GetTop()
    {
        return _top;
    }

    // Setter for the numerator.
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the denominator.
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the denominator. Includes basic validation to prevent division by zero.
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Warning: Denominator cannot be zero. Setting to 1.");
            _bottom = 1; // Default to 1 to avoid errors
        }
    }

    // Returns the fraction as a string (e.g., "3/4").
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction.
    public double GetDecimalValue()
    {
        // Cast to double for floating-point division.
        return (double)_top / (double)_bottom;
    }
}