using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This is a list of Shape objects. We can add any class that
        // inherits from Shape into this list.
        List<Shape> shapes = new List<Shape>();

        // Create instances of the different shape classes.
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 5, 6);
        Circle circle = new Circle("Green", 3);

        // Add the shapes to the list. This is where polymorphism allows us
        // to treat all these different types as a generic 'Shape'.
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list of shapes.
        foreach (Shape shape in shapes)
        {
            // For each shape in the list, we can call the methods.
            // Notice that GetColor() is inherited from the base class.
            string color = shape.GetColor();

            // Here is where polymorphism is demonstrated. The program
            // will call the correct GetArea() method for each specific
            // type of object (Square, Rectangle, or Circle) at runtime.
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
