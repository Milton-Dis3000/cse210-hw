using System;

// This is the abstract base class for all shapes.
// An abstract class cannot be instantiated directly.


abstract class Shape
{
    // A private member variable to store the color of the shape.
    private string _color;

    // The constructor for the Shape class.
    public Shape(string color)
    {
        _color = color;
    }

    // A method to get the color of the shape.
    public string GetColor()
    {
        return _color;
    }


    // This is an abstract method. It doesn't have an implementation (a body)
    // in this base class. Any class that inherits from Shape MUST override
    // and provide an implementation for this method.
    public abstract double GetArea();
}