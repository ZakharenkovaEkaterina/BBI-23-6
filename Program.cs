//using System;
//// 3 уровень 9 задача.
//class Program
//{
//    static void Main()
//    {
//        double a = 0.1;
//        double b = 1;
//        double h = 0.05;

//        double s = 0;

//        double y(double x)
//        {
//            return Math.Atan(x);
//        }

//        double term(int i, double x)
//        {
//            double numerator = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1);
//            double denominator = 2 * i + 1;
//            return numerator / denominator;
//        }

//        double x = a;
//        while (x <= b)
//        {
//            int i = 0;
//            double currentTerm = term(i, x);
//            while (Math.Abs(currentTerm) >= 0.0001)
//            {
//                s += currentTerm;
//                i++;
//                currentTerm = term(i, x);
//            }

//            Console.WriteLine("x = " + x);
//            Console.WriteLine("s = " + s);
//            Console.WriteLine("y = " + y(x));
//            Console.WriteLine();

//            x += h;
//        }
//    }
//}
//using System;
//// 2 уровень 1 задача
//class Program
//{
//    static void Main()
//    {
//        double x = 0.5;
//        double epsilon = 0.0001;
//        double sum = 0;
//        double term = 1;
//        double n = 1;

//        while (Math.Abs(term) >= epsilon)
//        {
//            sum += term;
//            n++;
//            term = Math.Cos(n * x) / (n * n);
//        }

//        Console.WriteLine("Сумма ряда: " + sum);
//    }
//}

//using System;
////2 задача 2 уровень
//class Program
//{
//    static void Main()
//    {
//        int L = 30000;
//        int n = 1;
//        int p = 1;

//        while (p <= L)
//        {
//            n++;
//            p *= n;
//        }
//        n--;
//        Console.WriteLine("Наибольшее значение n: " + n);
//    }
//}

//using System;
////3 задача 2 уровень
//class Program
//{
//    static void Main()
//    {
//        int s = 0, n = 0, m;
//        const int a = 2, h = 3, p = 41;
//        while (s <= p)
//        {
//            m = a + n * h;
//            s = s + m;
//            n = n + 1;
//        }
//        n--;
//        Console.WriteLine($"{n:d}");
//    }
//}
//using System;
//// 2 уровень 4 задача
//class Program
//{
//    static void Main()
//    {
//        double sum = 0;
//        double x = 0.9;
//        double last_sum = 0;
//        for (int n = 1; n <= 10000; n++)
//        {
//            sum += Math.Pow(x, n * 2);
//            if (Math.Pow(x, n * 2) >= 0.0001)
//            {
//                last_sum = sum;
//            }

//            if (Math.Pow(x, n * 2) < 0.0001)
//            {
//                Console.WriteLine(last_sum);
//                break;
//            }
//        }

//    }
//}


//using System;
//// 2 уровень 5 задача
//double res = 0;
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());

//while (n >= m)
//{
//    res += 1;
//    n -= m;
//}
//Console.WriteLine($"частное: {res}");
//if (n < m)
//{
//    if (n > 0)
//    {
//        Console.WriteLine($"остаток:{n}");
//    }
//    if (n == 0)
//    {
//        Console.WriteLine("остаток: 0");
//    }
//}

//using System;
////2 уровень 6 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 1; 
//        int time = 0; 

//        while (n != 105) 
//        {
//            time++; 


//            n += n;


//            if (n > 105)
//            {
//                n = 105;
//            }
//        }

//        Console.WriteLine("Время: " + time);
//        Console.ReadKey();
//    }
//}

//using System;
//// 2 уровень 7.1 задача
//double r = 10;
//double sum = 10;
//for (int kolvo = 1; kolvo < 7; kolvo++)
//{
//    r = r + r * 0.1;
//    sum += r;
//}
//Console.WriteLine(sum);
//using System;
//// 2 уровень 7.2 задача
//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; sum < 100;)
//{
//    r = r + r * 0.1;
//    sum += r;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);
//using System;
//// 2 уровень 7.3 задача
//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; r <= 20;)
//{
//    r = r + r * 0.1;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);

////8 задача 2 уровень
//class Program
//{
//    static void Main()
//    {
//        double s = 10000;
//        int d = 0;
//        double r = 0.08;
//        double s1 = s * 2;
//        while (s < s1)
//        {
//            s += s * r;
//            d++;
//        }
//        Console.WriteLine($"Сумма удвоится через {d} месяцев.");

//    }
//}
////using System;
////// 1 уровень 1 задача.
////namespace ConsoleApp3
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            int sum = 0;
////            for (int i = 2; i < 38; i += 3)
////            {
////                sum = sum + i;
////            }
////            Console.WriteLine(sum);
////        }
////    }
////}
//using System;
//// 1 уровень 2 задача.
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            for (double i = 1; i <= 10; i += 1)
//                sum = sum + (1 / i);
//            Console.WriteLine(sum);
//        }
//    }
//}


////using System;

////1 уровень 3 задача.

////using System;

////public class HelloWorld
////{
////    public static void Main(string[] args)
////    {
////        double A = 0;
////        for (double i = 2; i <= 112; i += 2)
////        {
////            A += (i / (i + 1));
////        }
////        Console.WriteLine(A);
////    }
////}
//using System;
//// 1 уровень 4 задача.
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            int x = 10;
//            for (int i = 0; i <= 8; i += 1)
//            {
//                sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
////1 уровень 5 задача.
//namespace ConsoleApp3
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
//                sum = (int)(sum + Math.Pow(ph, 2));
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
//// 1 уровень 6 задача.
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double number = 0;
//            for (double i = -4; i <= 4; i += 0.5)
//            {
//                number = (Math.Pow(0.5 * i, 2) - 7 * i);
//                Console.WriteLine($"{number} {i}");
//            }
//        }
//    }
//}
//using System;
//// 1 уровень 7 задача
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int proizv = 1;
//            for (int i = 1; i <= 6; i++)
//            {
//                proizv = proizv * i;
//            }
//            Console.WriteLine(proizv);
//        }
//    }
//}

////1 уровень 8 задача.
////using System;

////public class HelloWorld
////{
////    public static void Main(string[] args)
////    {
////        int A = 1;
////        for (int b = 2; b <= 6; b++)
////        {
////            A = A * b;
////        }
////        Console.WriteLine(A);
////    }
////}
//using System;
//// 1 уровень 9 задача
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int Factorial(int n)
//            {
//                if (n == 1) return 1;

//                return n * Factorial(n - 1);
//            }

//            int sum = 0;
//            int number = 0;

//            for (int i = 1; i <= 6; i++)
//            {
//                number = (int)(Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i));
//                sum += number;
//            }
//            Console.WriteLine(number);

//        }
//    }
//}
//using System;
//{
//    // 1 уровень 10 задача
//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int number = 1;
//        for (int i = 1; i <= 7; i++)
//        {
//            number *= 3;
//        }
//        Console.WriteLine(number);
//    }
//} 
//} 


////1 уровень 11.a задача
////public class HelloWorld
////{
////    public static void Main(string[] args)
////    {

////        for (int A = 1; A < 6; A++)
////        {
////            Console.WriteLine(A);
////        }

////    }
////}
////1 уровеень 11b задача
////public class HelloWorld
////{
////    public static void Main(string[] args)
////    {
////        for (int i = 0; i < 4; i++)
////        {
////            for (int j = 0; j < 6; j++)
////            {
////                Console.Write("5 ");
////            }
////        }
////    }
////}
//using System;
// 1 уровень 12 задача
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            int x = 2;
//            for (int i = 0; i <= 10; i++)
//            {
//                sum += 1 / Math.Pow(x, i);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
//// 1 уровень 14 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 8; 

//        int first = 1; 
//        int second = 1; 

//        Console.Write(first + " " + second + " "); 

//        for (int i = 3; i <= n; i++)
//        {
//            int next = first + second; 
//            Console.Write(next + " "); 

//            first = second; 
//            second = next; 
//        }

//        Console.ReadKey();
//    }
//}
//using System;
//// 1 уровень 15 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 5; 

//        int numerator1 = 1; 
//        int denominator1 = 1; 

//        int numerator2 = 2; 
//        int denominator2 = 1; 

//        int numerator = 0; 
//        int denominator = 0; 

//        for (int i = 3; i <= n; i++)
//        {
//            numerator = numerator1 + numerator2; 
//            denominator = denominator1 + denominator2; 

           
//            numerator1 = numerator2;
//            denominator1 = denominator2;
//            numerator2 = numerator;
//            denominator2 = denominator;
//        }

//        Console.WriteLine("5-й член последовательности: " + (double)numerator / denominator);
//        Console.ReadKey();
//    }
//}

