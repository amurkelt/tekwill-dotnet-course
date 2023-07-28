using GeometricShape;
class Program
{
    public static void Main()
    {
        Circle circle = new Circle(2);
        Rectangle rectangle = new Rectangle(10, 7.5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine();

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());

        var shapes = new List<Shape>()
        {
            circle, rectangle,
        };

        Console.WriteLine(shapes.Sum(s => s.CalculatePerimeter()));
        Console.WriteLine(shapes.Sum(s => s.CalculateArea()));
    }
}