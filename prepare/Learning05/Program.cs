using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> _shapes = new List<Shape>();
        Square square1 = new Square("blue", 2);
        Circle circle1 = new Circle("red", 3);
        Rectangle rectangle1 = new Rectangle("white", 4,7);

        _shapes.Add(square1);
        _shapes.Add(circle1);
        _shapes.Add(rectangle1);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine("");
        }
    }
}