using System;
abstract class Shape
{
    protected double _volume;
    public double Volume => _volume;
    public abstract void Calculate();
    public abstract void Print1();
}

class Sphere : Shape
{
    protected double _radius;

    public Sphere(double radius)
    {
        _radius = radius;
        Calculate();
    }

    public override void Calculate()
    {
        _volume = (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        _volume = Math.Round(_volume, 2);
    }

    public override void Print1()
    {
        Console.WriteLine($"Сфера. Радиус: {_radius}, объем: {_volume}");
    }
}

class Cube : Shape
{
    protected double _sideLength;

    public Cube(double sideLength)
    {
        _sideLength = sideLength;
        Calculate();
    }

    public override void Calculate()
    {
        _volume = Math.Pow(_sideLength, 3);
        _volume = Math.Round(_volume, 2);
    }

    public override void Print1()
    {
        Console.WriteLine($"Куб. Длина стороны: {_sideLength}, объем: {_volume}");
    }
}

class Cylinder : Shape
{
    protected double _radius;
    protected double _height;

    public Cylinder(double radius, double height)
    {
        _radius = radius;
        _height = height;
        Calculate();
    }

    public override void Calculate()
    {
        _volume = Math.PI * Math.Pow(_radius, 2) * _height;
        _volume = Math.Round(_volume, 2);
    }

    public override void Print1()
    {
        Console.WriteLine($"Цилиндр. Радиус: {_radius} , высота: {_height}, объем: {_volume}");
    }
}

class Program
{
    static void Main()
    {
        Shape[] sphere = new Shape[]
        {
      new Sphere(2),
      new Sphere(4),
      new Sphere(6),
      new Sphere(1),
      new Sphere(8)
        };

        Shape[] cube = new Shape[]
        {
      new Cube(6),
      new Cube(8),
      new Cube(2),
      new Cube(5),
      new Cube(4)
        };

        Shape[] cilinder = new Shape[]
        {
      new Cylinder(1, 4),
      new Cylinder(2, 8),
      new Cylinder(4, 9),
      new Cylinder(3, 6),
      new Cylinder(1, 7)
        };

        Sort(sphere);
        Sort(cube);
        Sort(cilinder);

        Console.WriteLine("Сферы:");
        Print2(sphere);

        Console.WriteLine("Кубы:");
        Print2(cube);

        Console.WriteLine("Цилиндры:");
        Print2(cilinder);

        int totalShape = sphere.Length + cube.Length + cilinder.Length;
        Shape[] allShape = new Shape[totalShape];

        int index = 0;
        foreach (var shape in sphere)
        {
            allShape[index] = shape;
            index++;
        }
        foreach (var shape in cube)
        {
            allShape[index] = shape;
            index++;
        }
        foreach (var shape in cilinder)
        {
            allShape[index] = shape;
            index++;
        }
        Sort(allShape);

        Console.WriteLine("Все фигуры:");
        Print2(allShape);
    }

    static void Sort(Shape[] shapes)
    {
        int n = shapes.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (shapes[j].Volume < shapes[j + 1].Volume)
                {
                    Shape t = shapes[j];
                    shapes[j] = shapes[j + 1];
                    shapes[j + 1] = t;
                }
            }
        }
    }

    static void Print2(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Print1();
        }
        Console.WriteLine();
    }
}
