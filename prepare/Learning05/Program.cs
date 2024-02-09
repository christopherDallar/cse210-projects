using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 2);
        double sq_area = square.GetArea();
        string sq_color = square.GetColor();

        Rectangle rectangle = new Rectangle("green", 2, 3);
        double rec_area = rectangle.GetArea();
        string rec_color = rectangle.GetColor();

        Circle circle = new Circle("blue", 2);
        double c_area = circle.GetArea();
        string c_color = circle.GetColor();

        Console.WriteLine($"Square -> Area: {sq_area} Color: {sq_color}");
        Console.WriteLine($"Rectangle ->  Area: {rec_area} Color: {rec_color}");
        Console.WriteLine($"Circle ->  Area: {c_area} Color: {c_color}");

        Console.WriteLine("---- LIST ----");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"Circle ->  Area: {area} Color: {color}");
        }
    }
}