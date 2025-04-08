using System;

class Program
{
    static void Main(string[] args)
    {
        // list of shapes
        List<Shape> shapes = new List<Shape>();

        // square
        Square square = new Square("red", 6.85);
        // rectangle
        Rectangle rectangle = new Rectangle("red", 2.85, 1.56);
        // ciricle
        Circle circle = new Circle("red", 4.23);

        // add shapes to list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // iterate through and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }
    }
}