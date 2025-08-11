using System;

// This is the Circle class, which inherits from the abstract Shape class.
class Circle : Shape
{
    // A private member variable to store the radius of the circle.
    private double _radius;

    // The constructor for the Circle class. It accepts the color and the radius.
    // The 'base(color)' part calls the constructor of the parent Shape class.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }


    // This method overrides the abstract GetArea() method from the base class.
    // The 'override' keyword is required to provide a specific implementation
    // for calculating the area of a circle.
    public override double GetArea()
    {
        // The area of a circle is calculated using the formula: pi * r^2
        return Math.PI * _radius * _radius;
    }
}