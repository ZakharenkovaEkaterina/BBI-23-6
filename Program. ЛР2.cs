//using System;
////1 уровень 1 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string inside = "точка внутри круга";
//            string outside = "точка вне круга";
//            double x, y, r;
//            Console.WriteLine("Введите x");
//            x = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите y");
//            y = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите r");
//            r = double.Parse(Console.ReadLine());
//            if (Math.Abs(x * x + y * y - r * r) <= 1 / 10 * 10 * 10)
//                Console.WriteLine(inside);
//            else
//                Console.WriteLine(outside);
//        }
//    }
//}

//using System;
////1 уровень 4 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите значение a:");
//            double a = double.Parse(Console.ReadLine());

//            Console.WriteLine("Введите значение b:");
//            double b = double.Parse(Console.ReadLine());

//            Console.WriteLine("Введите значение c:");
//            double c = double.Parse(Console.ReadLine());

//            double min = Math.Min(a, b); 
//            double z = Math.Max(min, c); 

//            Console.WriteLine(z);

//        }
//    }
//}

//using System;
////1 уровень 7 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double x, y;
//            Console.WriteLine("Введите значение x:");
//            x = double.Parse(Console.ReadLine());
//            if (Math.Abs(x) > 1)
//            {
//                y = 1;
//            }
//            else
//            {
//                y = Math.Abs(x);
//            }
//            Console.WriteLine(y);

//        }
//    }
//}

//using System;
////2 уровень 1 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sr, r, s = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Введите рост ученика");
//                r = double.Parse(Console.ReadLine());
//                s = s + r;
//            }
//            sr = s / 10;
//            Console.WriteLine(sr);
//        }
//    }
//}

//using System;
//2 уровень 4 задача
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите количество точек (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите внутренний радиус (r1): ");
//        double r1 = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите внешний радиус (r2): ");
//        double r2 = double.Parse(Console.ReadLine());

//        int p = 0;

//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine("Введите x");
//            double x = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите y");
//            double y = double.Parse(Console.ReadLine());
//            double d = Math.Sqrt(x * x + y * y);

//            if (d >= r1 && d <= r2)
//            {
//                p++;
//            }
//        }

//        Console.WriteLine($"Из {n} введенных точек {p} попадают в кольцо с радиусами r1 = {r1} и r2 = {r2}.");
//    }
//}
//using System;
//2 уровень 7 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double x, y;
//            int n, Q;
//            int q1 = 0;
//            int q3 = 0;
//            Console.WriteLine("Введите количество точек: ");
//            n = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine("Введите x");
//                x = double.Parse(Console.ReadLine());
//                Console.WriteLine("Введите y");
//                y = double.Parse(Console.ReadLine());
//                switch (x)
//                {
//                    case > 0 when y > 0:
//                        Q = 1;
//                        q1++;
//                        break;
//                    case < 0 when y > 0:
//                        Q = 2;
//                        break;
//                    case < 0 when y < 0:
//                        Q = 3;
//                        q3++;
//                        break;
//                    case > 0 when y < 0:
//                        Q = 4;
//                        break;
//                    default:
//                        Q = 0;
//                        break;
//                }
//                Console.WriteLine($"Точка {i} находится в {Q}-м квадранте.");
//            }
//            Console.WriteLine($"Количество точек в 1-м квадранте: {q1}");
//            Console.WriteLine($"Количество точек в 3-м квадранте: {q3}");
//        }
//    }
//}
