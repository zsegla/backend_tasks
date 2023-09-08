using System;

class Shape // this class will be overriden
{
    public string Name { get; set; }

    public virtual double CalculateArea()
    {
        return 0.0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Triangle : Shape
{
    public double Base { get; set; }
    public double TriangleHeight { get; set; }

    public override double CalculateArea()
    {
        return (Base * TriangleHeight) / 2;
    }
}

class Program
{
    static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"Shape Name: {shape.Name}");
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // some tests in the main method will help
        Circle circle = new Circle { Name = "Circle", Radius = 5.0 };
        Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 4.0, Height = 6.0 };
        Triangle triangle = new Triangle { Name = "Triangle", Base = 3.0, TriangleHeight = 4.0 };
        
        // But we can also take user input with conditions

        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
    }
}
