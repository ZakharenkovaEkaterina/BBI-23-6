//using System;
//// 1 уровень 1 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[6];
//            string s;
//            for (int i = 0; i < 6; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            for (int i = 0; i < 6; i++)
//            {
//                sum += a[i];
//            }
//            Console.WriteLine(sum);
//            if (sum != 0)
//            {
//                for (int i = 0; i < 6; i++)
//                {
//                    a[i] /= sum;
//                }
//                Console.WriteLine("Массив после деления: ");
//                for (int i = 0; i < 6; i++)
//                {
//                    Console.WriteLine(a[i]);
//                }
//            }
//        }
//    }
//}
//using System;
////1 уровень 2 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[8];
//            string s;
//            for (int i = 0; i < 8; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            int t = 0;
//            for (int i = 0; i < 8; i++)
//            {
//                if (a[i] > 0)
//                {
//                    sum += a[i];
//                    t += 1;
//                }
//            }
//            double sr = sum / t;
//            Console.WriteLine("Среднее арифметическое массива: ");
//            Console.WriteLine(sr);
//            for (int i = 0; i < 8; i++)
//            {
//                if (a[i] > 0)
//                {
//                    a[i] = sr;
//                }
//            }
//            Console.WriteLine("Массив после замены: ");
//            for (int i = 0; i < 8; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}
//using System;
////1 уровень 3 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Первый массив: ");
//            double[] a = new double[4];
//            string s;
//            for (int i = 0; i < 4; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            Console.WriteLine("Второй массив: ");
//            double[] b = new double[4];
//            string s1;
//            for (int i = 0; i < 4; i++)
//            {
//                s1 = Console.ReadLine();
//                b[i] = double.Parse(s1);
//            }
//            double[] c = new double[4];
//            for (int i = 0;i < 4; i++)
//            {
//                c[i] = a[i] + b[i]; 
//            }
//            Console.WriteLine("Сумма массивов: ");
//            for (int i = 0; i < 4 ; i++)
//            {
//                Console.WriteLine(c[i]);
//            }
//            double[] d = new double[4];
//            for (int i = 0; i < 4; i++) 
//            {
//                d[i] = a[i] - b[i];
//            }
//            Console.WriteLine("Разность массивов: ");
//            for (int i = 0; i < 4 ; i++)
//            {
//                Console.WriteLine(d[i]);
//            }
//        }
//    }
//}
//using System;
//// 1 уровень 4 задача
//namespace consoleapp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[5];
//            string s;
//            for (int i = 0; i < 5; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            int m = 0;
//            for (int i = 0; i < 5; i++)
//            {                
//                    sum = sum + a[i];
//                    m += 1;
//            }
//            double sr = sum / m;
//            Console.WriteLine("среднее значение: ");
//            Console.WriteLine(sr);
//            for (int i = 0; i < 5; i++)
//            {
//                a[i] -= sr;
//            }
//            Console.WriteLine("получившийся массив: ");
//            foreach (double l in a)
//            {
//                Console.WriteLine(l);
//            }

//        }
//    }
//}
//using System;
////1 уровень 5 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Первый вектор: ");
//            double[] a = new double[4];
//            string s;
//            for (int i = 0; i < 4; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            Console.WriteLine("Второй вектор: ");
//            double[] b = new double[4];
//            string s1;
//            for (int i = 0; i < 4; i++)
//            {
//                s1 = Console.ReadLine();
//                b[i] = double.Parse(s1);
//            }
//            double p = 0;
//            for (int i = 0; i<4; i++)
//            {
//                p += a[i] * b[i];
//            }
//            Console.WriteLine("Скалярное произведение векторов: ");
//            Console.WriteLine(p);
//        }
//    }
//}
//using System;
////1 уровень 6 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[5];
//            string s;
//            for (int i = 0; i < 5; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double L = 0;
//            int x;
//            for (int i = 0; i < 5 ; i++)
//            {
//                L += a[i] * a[i];
//            }
//            L = Math.Sqrt(L);
//            Console.WriteLine("Длина вектора: ");
//            Console.WriteLine(L);
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
//            double[] a = new double[7];
//            string s;
//            for (int i = 0; i < 7; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            int m = 0;
//            for (int i = 0; i < 7; i++)
//            {
//                sum = sum + a[i];
//                m += 1;
//            }
//            double sr = sum / m;
//            Console.WriteLine("среднее значение: ");
//            Console.WriteLine(sr);
//            for (int i = 0;i < 7;i++)
//            {
//                if (a[i] > sr)
//                {
//                    a[i] = 0;
//                }                   
//            }
//            Console.WriteLine("Получившийся массив: ");
//            for (int i = 0; i < 7 ; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}
//using System;
////1 уровень 8 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[6];
//            string s;
//            for (int i = 0; i < 6; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            int n = 0;
//            for (int i = 0; i < 6; i++)
//            {
//                if (a[i] < 0)
//                {
//                    n++;
//                }
//            }
//            Console.WriteLine($"Количество отрицательных элементов: {n}");
//        }
//    }
//}
//using System;
////1 уровень 9 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[8];
//            string s;
//            for (int i = 0; i < 8; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            int m = 0;
//            for (int i = 0; i < 8; i++)
//            {
//                sum = sum + a[i];
//                m += 1;
//            }
//            double sr = sum / m;
//            Console.WriteLine("среднее значение: ");
//            Console.WriteLine(sr);
//            int n = 0;
//            for (int i = 0; i < 8; i++)
//            {
//                if (a[i] > sr)
//                {
//                    n++;
//                }
//            }

//            Console.WriteLine($"Количество элементов больше среднего значения элементов: {n}");

//        }
//    }
//}
//using System;
////1уровень 10 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[10];
//            string s;
//            for (int i = 0; i < 10; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            Console.Write("Введите число P: ");
//            int P = int.Parse(Console.ReadLine());
//            Console.Write("Введите число Q: ");
//            int Q = int.Parse(Console.ReadLine());
//            if (P >= Q)
//            {
//                Console.WriteLine("Q должно быть больше P.");
//                return;
//            }
//            int c = 0;
//            int b = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                if (a[i] == P)
//                {
//                    b = 1;
//                }
//                if (b == 1)
//                {
//                    c++;
//                    if (a[i] == Q)
//                    {
//                        b = 0;
//                    }
//                }
//            }
//            Console.WriteLine($"Количество элементов между {P} и {Q} в массиве: {c}");
//        }
//    }
//}
//using System;
////1 уровень 11 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[10];
//            string s;
//            for (int i = 0; i < 10; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            Console.WriteLine();
//            for (int i = 0;i < 10; i++)
//            {
//                if (a[i] > 0)
//                {
//                    Console.WriteLine(a[i]);
//                }
//            }
//        }
//    }
//}
//using System;
////1 уровень 12 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[8];
//            string s;
//            for (int i = 0; i < 8; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double min = 0;
//            double z = 0;
//            for (int i = 0;i < 8; i++)
//            {
//                if (a[i] < 0)
//                {
//                    min = a[i];
//                    z = i;
//                }              
//            }
//                if (z >= 0)
//                {
//                    Console.WriteLine($"Значение последнего отрицательного элемента: {min}");
//                    Console.WriteLine($"Номер последнего отрицательного элемента: {z}");
//                }                      
//        }
//    }
//}
//using System;
////1 уровень 13 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[10];
//            string s;
//            for (int i = 0; i < 10; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double[] b = new double[5];
//            double[] c = new double[5];
//             for (int i = 0;i < 10; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    b[i / 2] = a[i];
//                }
//                else
//                {
//                    c[i / 2] = a[i];
//                }
//            }
//            Console.WriteLine("Элементы с четными индексами:");
//            foreach (int element in b)
//            {
//                Console.Write(element + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Элементы с нечетными индексами:");
//            foreach (int element in c)
//            {
//                Console.Write(element + " ");
//            }
//        }
//    }
//}
//using System;
////1 уровень 14 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] a = new double[11];
//            string s;
//            for (int i = 0; i < 11; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double sum = 0;
//            for (int i = 0;i < 11;i++)
//            {
//                if (a[i] > 0)
//                {
//                    sum += a[i]*a[i];
//                }
//                if (a[i] < 0)
//                {
//                    break;
//                }
//            }
//            Console.WriteLine("Сумма квадратов элементов: ");
//            Console.WriteLine(sum);
//        }
//    }
//}
//using System;
////1 уровень 15 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] x = new double[10];
//            double[] y = new double[10];
//            string k;
//            Console.WriteLine("Введите массив x");
//            for (int i = 0; i < 10; i++)
//            {
//                k = Console.ReadLine();
//                x[i] = double.Parse(k);
//            }
//            for (int i = 0; i < 10; i++)
//            {
//                y[i] = 0.5 * Math.Log(x[i]);
//            }
//            Console.WriteLine(" ");
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"{x[i]} {y[i]}");
//            }
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
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            double[] a = new double[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amin = a[0];
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < amin)
//                {
//                    amin = a[i];
//                }
//            }
//            Console.WriteLine("Минимальный элемент массива: ");
//            Console.WriteLine(amin);
//            double amin1 = 0;
//            for (int i = 0;i < n; i++)
//            {
//                amin1 = 2* amin;
//            }
//            Console.WriteLine("Удвоенный минимальный элемент массива: ");
//            Console.WriteLine(amin1);
//        }
//    }
//}
//using System;
////2 уровень 2 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            double[] a = new double[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amax = a[0];
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                }
//            }
//            Console.WriteLine("Максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            double s1 = 0;
//            foreach (double x in a)
//            {
//                if (x < amax)
//                {
//                    s1 = s1 + x;
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.WriteLine("Сумма элементов массива до максимального: ");
//            Console.WriteLine(s1);
//        }
//    }
//}
//using System;
////2 уровень 3 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amin = a[0];
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < amin)
//                {
//                    amin = a[i];
//                }
//            }
//            Console.WriteLine("Минимальный элемент массива: ");
//            Console.WriteLine(amin);
//            for (int i = 0;i < n; i++)
//            {
//                if (amin < a[i])
//                {
//                    a[i] *= 2;
//                }
//            }
//            Console.WriteLine("Увеличенные вдвое элементы массива: ");
//            foreach (int element in a)
//            {
//                Console.Write(element + " ");
//            }
//        }
//    }
//}
//using System;
////2 уровень 4 задача
//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        double sum = 0;
//        int m = 0;
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];
//                imax += 1;

//            }
//        }
//        double sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (i >= imax)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}
//using System;
////2 уровень 5 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            double[] a = new double[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amin = a[0];
//            double imin = 0;
//            double amax = a[0];
//            double imax = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < amin)
//                {
//                    amin = a[i];
//                    imin = i;
//                }
//                else if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            Console.WriteLine("Минимальный элемент массива: ");
//            Console.WriteLine(amin);
//            Console.WriteLine("Максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            double[] b = new double[n];
//            int bIndex = 0;
//            if (imin < imax)
//            {
//                for (int i = (int)(imin + 1); i < imax; i++)
//                {
//                    if (a[i] < 0)
//                    {
//                        b[bIndex] = a[i];
//                        bIndex++;
//                    }
//                }
//            }
//            else
//            {
//                for (int i = (int)(imax + 1); i < imin; i++)
//                {
//                    if (a[i] < 0)
//                    {
//                        b[bIndex] = a[i];
//                        bIndex++;
//                    }
//                }
//            }
//            Console.WriteLine("Отрицательные элементы между минимальным и максимальным элементами:");
//            for (int i = 0; i < bIndex; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//        }
//    }
//}
//using System;
////2 уровень 6 задача
//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n + 1];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("Введите число P");
//        double P = Convert.ToDouble(Console.ReadLine());
//        double sr;
//        double sum = 0;
//        int m = 0;
//        double minR = 10000000000000000000;
//        double curD = 0;
//        int ind = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < n; i++)
//        {
//            curD = Math.Abs(sr - a[i]);
//            if (curD < minR)
//            {
//                minR = curD;
//                ind = i;
//            }
//        }
//        for (int i = n; i >= ind + 2; i--)
//        {
//            a[i] = a[i - 1];
//        }
//        a[ind + 1] = P;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n + 1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }
//    }
//}

//using System;
////2 уровень 7 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            for (int i = 0;i < n; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            Console.WriteLine("Максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            if (imax < n - 1)
//            {
//                a[imax + 1] *= 2;
//                Console.WriteLine("Элемент, увеличенный в 2 раза: ");
//                Console.WriteLine(a[imax + 1]);
//            }
//            else
//            {
//                Console.WriteLine("Максимальный элемент находится в последней позиции массива, невозможно увеличить следующий элемент.");
//            }
//        }
//    }
//}
//using System;
////2 уровень 8 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int imax = 0;
//            int imin = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > a[imax])
//                {
//                    imax = i;
//                }
//                if (a[i] < a[imin])
//                {
//                    imin = i;
//                }
//            }
//            if (imax < imin)
//            {
//                int t = a[imax];
//                a[imax] = a[imin];
//                a[imin] = t;
//            }
//            else
//            {
//                int t = a[imin];
//                a[imin] = a[imax];
//                imax = imin;
//                for (int i = imax + 1; i < n; i++)
//                {
//                    if (a[i] < a[imin])
//                    {
//                        imin = i;
//                    }
//                }
//                t = a[imax];
//                a[imax] = a[imin];
//                a[imin] = t;
//            }

//            Console.WriteLine("Массив после замены:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(a[i] + " ");
//            }
//        }
//    }
//}
//using System;
//// 2 уровень 9 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            int amin = a[0];
//            int imin = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//                else if (a[i] < amin)
//                {
//                    amin = a[i];
//                    imin = i;
//                }
//            }
//            Console.WriteLine("Максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            Console.WriteLine("Минимальный элемент массива: ");
//            Console.WriteLine(amin);
//            double sum = 0;
//            int t = 0;
//            int s1, e;
//            if (imin < imax)
//            {
//                s1 = imin;
//                e = imax;
//            }
//            else
//            {
//                s1 = imax;
//                e = imin;
//            }
//            for (int i = s1 + 1; i < e; i++)
//            {
//                sum += a[i];
//                t += 1;
//            }
//            double sr = sum / t;
//            Console.WriteLine("Среднее арифметическое массива: ");
//            Console.WriteLine(sr);
//        }
//    }
//}
//using System;
////2 уровень 10 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите массив: ");
//            double[] a = new double[5];
//            double[] b = new double[4];
//            string s;
//            for (int i = 0; i < 5; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amin = a[0];
//            int imin = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                if (a[i] < amin & (a[i] > 0))
//                {
//                    amin = a[i];
//                    imin = i;
//                }
//            }
//            for (int i = 0; i < imin ; i++)
//            {
//                b[i] = a[i];
//            }
//            for (int i = imin + 1;i < 5 ; i++)
//            {
//                b[i - 1] = a[i];
//            }
//            for (int i = 0; i < b.Length; i++)
//            {
//                Console.WriteLine("{0:f}", b[i]);
//            }
//        }
//    }
//}
//using System;
////2 уровень 11 задача
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        Console.WriteLine("Введите число P: ");
//        int p = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите элементы массива:");
//        int lastIndex = -1; 
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//            if (a[i] > 0)
//            {
//                lastIndex = i;
//            }
//        }
//        if (lastIndex >= 0)
//        {
//            int[] b = new int[n + 1];
//            for (int i = 0; i <= lastIndex; i++)
//            {
//                b[i] = a[i];
//            }
//            b[lastIndex + 1] = p;
//            for (int i = lastIndex + 2; i < n + 1; i++)
//            {
//                b[i] = a[i - 1];
//            }
//            a = b;
//            n++;

//            Console.WriteLine("Массив после вставки:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("{0} ", a[i]);
//            }
//        }
//        else
//        {
//            Console.WriteLine("В массиве нет положительных элементов.");
//        }
//    }
//}
//using System;
////2 уровень 12 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            for (int i = 1; i < n ; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            Console.WriteLine("Максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            int k = -1;
//            for (int i = imax + 1 ;i < n ; i++)
//            {
//                if (a[i] < 0)
//                {
//                    k = i;
//                    break;
//                }
//            }
//            if (k != -1)
//            {
//                int sum = 0;
//                for (int i = k + 1; i < n; i++)
//                {
//                    sum += a[i];
//                }
//                a[k] = sum;
//                Console.WriteLine("Массив после замены:");
//                for (int i = 0; i < n; i++)
//                {
//                    Console.Write(a[i] + " ");
//                }
//            }
//            else
//            {
//                Console.WriteLine("В массиве нет отрицательных элементов после максимального.");
//            }
//        }
//    }
//}
//using System;
////2 уровень 13 задача
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите n: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            for (int i = 0; i < n;i += 2)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            a[imax] = imax;
//            Console.WriteLine("Получившийся массив: ");
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}
//using System;
////2 уровень 14 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        int k = -1;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                k = i;
//                break;
//            }
//        }
//        if (imax >= 0 && k >= 0)
//        {
//            int t = a[imax];
//            a[imax] = a[k];
//            a[k] = t;
//            Console.WriteLine("Получившийся массив:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//        else
//        {
//            Console.WriteLine("В массиве нет максимальных или отрицательных элементов.");
//        }
//    }
//}
//using System;
////2 уровень 15 задача
//class Program
//{
//   static void Main(string[] args)
//   {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        Console.WriteLine("Введите m: ");
//        int m = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] b = new int[m];
//        for (int i = 0; i < m; i++)
//        {
//            string s1 = Console.ReadLine();
//            b[i] = int.Parse(s1);
//        }
//        int[] c = new int[n + m];
//        Console.WriteLine("Введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        for (int i = 0; i <= k; i++)
//        {
//            c[i] = a[i];
//        }
//        for (int i = 0;i < m; i++)
//        {
//            c[k + i + 1] = b[i];
//        }
//        for (int i = k + m + 1; i < m + n; i++)
//        {
//            c[i] = a[i - m];
//        }
//        Console.WriteLine("Получившийся массив: ");
//        for (int i = 0; i < m+n; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//    }
//}
//using System;
////2 уровень 16 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        double sum = 0;
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        double sr = sum / m;
//        Console.WriteLine("среднее значение: ");
//        Console.WriteLine(sr);
//        int count = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < sr)
//            {
//                count++;
//            }
//        }
//        Console.WriteLine(count);
//        int j = 0;
//        int[] b = new int[count];
//        for (int i = 0;i < n;i++)
//        {
//            if (a[i] < sr)
//            {
//                b[j] = i;
//                j++;
//            }
//        }
//        Console.WriteLine("Получившийся массив: ");
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine(b[i]);
//        }
//    }
//}
//using System;
////2 уровень 17 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax = a[0];
//        int imax = 0;
//        int amin = a[0];
//        int imin = 0;
//        for (int i = 0;i < n;i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//            if (a[i] < amin) 
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        double sum = 0;
//        int m = 0;
//        double sr = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (imax < imin)
//            {
//                if (a[i]>0)
//                {
//                    sum += a[i];
//                    m += 1;
//                }
//                 sr = sum / m;
//            }
//            else if (imax > imin)
//            {
//                if (a[i]<0)
//                {
//                    sum += a[i];
//                    m += 1;
//                }
//                sr = sum / m;
//            }
//        }
//        Console.WriteLine("среднее значение: ");
//        Console.WriteLine(sr);
//    }
//}
//using System;
////2 уровень 18 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax1 = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (i % 2 == 0 && a[i] > amax1)
//            {
//                amax1 = a[i];
//            }
//        }
//        Console.WriteLine("Максимальный элемент массива с чётными индексами: ");
//        Console.WriteLine(amax1);
//        int amax2 = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (i % 2 != 0 && a[i] > amax2)
//            {
//                amax2 = a[i];
//            }
//        }
//        Console.WriteLine("Максимальный элемент массива с нечётными индексами: ");
//        Console.WriteLine(amax2);
//            if (amax1 > amax2)
//            {
//                for (int i=0; i<n/2; i++ )
//                {
//                    a[i] = 0;
//                }
//            }
//            if (amax1 < amax2)
//            {
//                for (int i=n/2; i <n; i++ )
//                {
//                    a[i] = 0;
//                }
//            }
//        Console.WriteLine("Получившийся массив: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//using System;
////2 уровень 19 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax = a[0];
//        int imax = 0;
//        for (int i = 1; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;   
//            }
//        }
//        Console.WriteLine("Максимальный элемент массива: ");
//        Console.WriteLine(amax);
//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum += a[i];
//        }
//        Console.WriteLine("Сумма элементов массива: ");
//        Console.WriteLine(sum);
//            if (amax > sum)
//            {
//            a[imax] = 0;
//            }
//            if (amax < sum)
//            {
//                a[imax] *= 2;
//            }
//        Console.WriteLine("Получившийся массив: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//using System;
////2 уровень 20 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amin = a[0];
//        int imin = 0;
//        for (int i = 0;i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        int k = -1;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                k = i;
//                break;
//            }
//        }
//        if (k>imin)
//        {
//            int sum = 0;
//            for (int i = 0; i < n ; i += 2)
//            {
//                sum += a[i];
//            }
//            Console.WriteLine("Сумма элементов с четными индексами: " + sum);
//        }
//        if (k<imin)
//        {
//            int sum = 0;
//            for (int i = 1; i < n; i += 2)
//            {
//                sum += a[i];
//            }
//            Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
//        }
//    }
//}
//using System;
////3 уровень 1 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int[] im = new int[n];
//        int amax = a[0];
//        int k = 0;
//        for (int i = 0;i < n;i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                k = 0;
//                im[k] = i;
//            }
//            else if (a[i] == amax)
//            {
//                k += 1;
//                im[k] = i;
//            }
//        }
//        Console.WriteLine("Полученный массив: ");
//        for (int i = 0; i <= k;i++)
//        {
//            Console.WriteLine(im[i]);
//        }
//    }
//}
//using System;
////3 уровень 2 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax = a[0];
//        int imax = 0;
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//            }
//        }
//        for (int i = 0;i < n; i++)
//        {
//            if (a[i] == amax)
//            {
//                m++;
//                a[i] += m;  
//            }
//        }
//        Console.WriteLine("Полученный массив: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}