using System;

// This is the Rectangle class, which inherits from the abstract Shape class.
class Rectangle : Shape
{
    // Private member variables to store the length and width of the rectangle.
    private double _length;
    private double _width;

    // The constructor for the Rectangle class. It accepts the color, length, and width.
    // The 'base(color)' part calls the constructor of the parent Shape class.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }


    // This method overrides the abstract GetArea() method from the base class.
    // The 'override' keyword is required to provide a specific implementation
    // for calculating the area of a rectangle.
    public override double GetArea()
    {
        return _length * _width;
    }
}
