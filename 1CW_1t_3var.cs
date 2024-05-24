using System;

struct Vector //3 вариант номер 1
{
    public struct Dot
    {
        private int _x;
        private int _y;
        private int _z;

        public Dot(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X => _x;
        public int Y => _y;
        public int Z => _z;
    }

    private Dot _points1;
    private Dot _points2;

    public Vector(Dot point1, Dot point2)
    {
        _points1 = point1;
        _points2 = point2;
    }

    public double Length()
    {
        double X = _points2.X - _points1.X;
        double Y = _points2.Y - _points1.Y;
        double Z = _points2.Z - _points1.Z;

        return Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z), 2);
    }

    public void Print()
    {
        Console.WriteLine($"Координаты первой точки: ({_points1.X}, {_points1.Y}, {_points1.Z})");
        Console.WriteLine($"Координаты второй точки: ({_points2.X}, {_points2.Y}, {_points2.Z})");
        Console.WriteLine($"Длина вектора: {Length()}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Vector.Dot[] dots = new Vector.Dot[]
        {
            new Vector.Dot(4, 1, 2),
            new Vector.Dot(1, 2, 7),
            new Vector.Dot(7, 8, 9),
            new Vector.Dot(11, 14, 13),
            new Vector.Dot(13, 14, 15)
        };

        Vector[] vectors = new Vector[5];
        vectors[0] = new Vector(dots[0], dots[1]);
        vectors[1] = new Vector(dots[1], dots[2]);
        vectors[2] = new Vector(dots[2], dots[3]);
        vectors[3] = new Vector(dots[3], dots[4]);
        vectors[4] = new Vector(dots[4], dots[0]);

        for (int i = 0; i < vectors.Length - 1; i++)
        {
            for (int j = 0; j < vectors.Length - 1 - i; j++)
            {
                if (vectors[j].Length() < vectors[j + 1].Length())
                {
                    Vector t = vectors[j];
                    vectors[j] = vectors[j + 1];
                    vectors[j + 1] = t;
                }
            }
        }

        foreach (var vector in vectors)
        {
            vector.Print();
        }
    }
}
