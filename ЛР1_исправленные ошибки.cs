//using System;
//// 1 уровень 4 задача
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            int x = 10;

//            for (int i = 0; i <= 8; i += 1)
//            {
//                double term = 1;

//                for (int j = 0; j < i; j++)
//                {
//                    term *= x;
//                }

//                if (i % 2 == 1)
//                {
//                    term = -term;
//                }

//                sum += Math.Cos((i + 1) * x) / term;
//            }

//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
////1 уровень 5 задача
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int p = 1;
//            int sum = 0;

//            for (int h = 0; h <= 9; h++)
//            {
//                int ph = p + h;
//                sum += ph * ph;
//            }

//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
////1 уровень 6 задача
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double number = 0;
//            for (double i = -4; i <= 4; i += 0.5)
//            {
//                double term = 0.5 * i * 0.5 * i;
//                number = (term - 7 * i);
//                Console.WriteLine($"{number} {i}");
//            }
//        }
//    }
//}
//1.9
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double a = 0;
//        for (int i = 1; i <= 6; i++)
//        {
//            a = (-1) * a * 5 / i;
//            s = s + a;
//        }
//        Console.WriteLine(s);
//    }
//}
//1.12
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double x = Convert.ToDouble(Console.WriteLine());
//        double a = x;
//        for (int i = 0; i <= 10; i++)
//        {
//            a = a / x;
//            s = s + x;
//        }
//        Console.WriteLine(s);
//    }
//}
//using System;
////2 уровень 4 задача
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            double sum = 0;
//            double x = 0.9;
//            double last_sum = 0;
//            double term = 1;

//            for (int n = 1; n <= 10000; n++)
//            {
//                term *= x * x;
//                sum += term;

//                if (term >= 0.0001)
//                {
//                    last_sum = sum;
//                }

//                if (term < 0.0001)
//                {
//                    Console.WriteLine(last_sum);
//                    break;
//                }
//            }
//        }
//    }
//}