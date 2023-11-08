using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        // Square square = new Square("red", 4);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // Rectangle rectangle = new Rectangle("green", 4, 5);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        // Circle circle = new Circle("blue", 2);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 4));
        shapes.Add(new Rectangle("green", 4, 5));
        shapes.Add(new Circle("blue", 2));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}