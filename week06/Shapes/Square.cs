using System;

// This is the Square class, which inherits from the abstract Shape class.
class Square : Shape
{
    // A private member variable to store the side length of the square.
    private double _side;

    // The constructor for the Square class. It accepts the color and the side.
    // The 'base(color)' part calls the constructor of the parent Shape class.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // This method overrides the abstract GetArea() method from the base class.
    // The 'override' keyword is required to provide a specific implementation
    // for calculating the area of a square.
    public override double GetArea()
    {
        return _side * _side;
    }
}