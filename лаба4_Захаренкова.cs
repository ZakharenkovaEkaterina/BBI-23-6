//using System;
////1 уровень 2 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[5, 7];
//        for (int i = 0; i < 5; i++)
//            for (int j = 0; j < 7; j++)
//            {
//                string s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//                Console.Write("{0:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        double sum = 0;
//        int t = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[i, j] > 0)
//                {
//                    sum += a[i, j];
//                    t += 1;
//                }
//            }
//        }
//        double sr = sum / t;
//        Console.WriteLine("Среднее арифметическое матрицы: ");
//        Console.WriteLine(sr);
//    }
//}
//using System;
////1 уровень 6 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите двумерный массив:");
//        double[,] a = new double[4, 7];
//        int[] b = new int[4];
//        double min, elm;
//        for (int i = 0; i < 4; i++)
//        {
//            min = 100000000;
//            for (int j = 0; j < 7; j++)
//            {
//                Console.WriteLine("[" + i + "," + j + "]");
//                elm = Double.Parse(Console.ReadLine());
//                a[i, j] = elm;
//                if (elm < min)
//                {
//                    min = elm;
//                    b[i] = j;
//                }
//            }
//        }
//        Console.WriteLine();
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(b[i] + " ");
//        }
//    }
//}
//using System;
////1 уровень 10 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[5, 7];
//        Random random = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        int t = 2;
//        int amax = a[0, t];
//        int imax = 0;
//        for (int i = 1; i < 5; i++)
//        {
//            if (a[i, t] > amax)
//            {
//                amax = a[i, t];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент 3 столбца:");
//        Console.WriteLine(amax);   
//        for (int j = 0; j < 7; j++)
//        {
//                int d = a[imax, j];
//                a[imax, j] = a[3, j];
//                a[3, j] = d;
//        }
//        Console.WriteLine("Матрица после замены строк:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////1 уровень 14 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[4, 3];
//        int[] b = new int[3];
//        Random random = new Random();
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                a[i, j] = random.Next(-100,100);
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        for (int j = 0; j < 3; j++)
//        {
//            int count = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                if (a[i, j] < 0)
//                {
//                    count++;
//                    b[j] = count;
//                }
//            }
//        }
//        Console.WriteLine("Получившийся массив: ");
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write(b[i] + " ");
//        }
//    }
//}
//using System;
////1 уровень 18 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите m: ");
//        int m = int.Parse(Console.ReadLine());
//        if (n > 0 && m > 0)
//        {
//            int[,] d = new int[n, m];
//            Random random = new Random();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    d[i, j] = random.Next(-100, 100);
//                }
//            }
//            Console.WriteLine("Исходная матрица D:");
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    Console.Write(d[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 0; i < n; i++)
//            {
//                int max = -1;
//                int j1 = -1;
//                int j2 = -1;
//                bool f = true;
//                for (int j = 0; j < m; j++)
//                {
//                    if (d[i, j] < 0)
//                    {
//                        f = false;
//                        j2 = j;
//                    }
//                    if (d[i, j] > max & f == true)
//                    {
//                        max = d[i, j];
//                        j1 = j;
//                    }
//                }
//                if (j1 != -1 & j2 != -1)
//                {
//                    int t = d[i, j1];
//                    d[i, j1] = d[i, j2];
//                    d[i, j2] = t;
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("Получившаяся матрица: ");
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    Console.Write("{0:d} ", d[i, j]);
//                }
//                Console.WriteLine();
//            }
//        }
//        else
//        {
//            Console.WriteLine("В матрице 0 элементов, дальнейшие действия невозможны");
//        }
//    }
//}
//using System;
////1 уровень 22 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[,] z = new double[6, 8];
//        Random random = new Random();
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                z[i, j] = random.Next(-10,100);
//            }
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write(z[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        double sum = 0;
//        int t = 0;
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                if (z[i, j] > 0)
//                {
//                    sum += z[i, j];
//                    t += 1;
//                }
//            }
//        }
//        double sr = sum / t;
//        Console.WriteLine("Среднее арифметическое матрицы: ");
//        Console.WriteLine(sr);
//        double max = z[0, 0];
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                if (z[i, j] > max)
//                {
//                    max = z[i, j];
//                }
//            }
//        }
//        Console.WriteLine("Максимальный элемент матрицы:");
//        Console.WriteLine(max);
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                if (z[i, j] == max)
//                {
//                    z[i, j] = sr;
//                }
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine("Получившаяся матрица: ");
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write("{0:f2}\t", z[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////1 уровень 26 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[5, 7];
//        Random random = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        Console.WriteLine("Одномерный массив:");
//        int[] b = new int[7];
//        Random random1 = new Random();
//        for (int i = 0; i < 7; i++)
//        {
//            b[i] = random1.Next(10);
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            Console.Write(b[i] + "\t");
//        }
//            int t = 5;
//        int amax = a[0, t];
//        int imax = 0;
//        for (int i = 1; i < 5; i++)
//        {
//            if (a[i, t] > amax)
//            {
//                amax = a[i, t];
//                imax = i;
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Максимальный элемент 6 столбца:");
//        Console.WriteLine(amax);
//        for (int j = 0; j < 7; j++)
//        {
//            a[imax, j] = b[j];
//        }
//        Console.WriteLine("Матрица после замены строк:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////1 уровень 30 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] b = new int[5, 5];
//        Random random = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                b[i, j] = random.Next(-100,100);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(b[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        int amax = b[0, 0];
//        int imax = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (b[i, i] > amax)
//            {
//                amax = b[i, i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент главной диагонали матрицы:");
//        Console.WriteLine(amax);
//        int imax1 = -1;
//        for (int i = 0; i < 5; i++)
//        {
//            if (b[i, 2] < 0)
//            {
//                imax1 = i;
//                break;
//            }
//        }
//        if (imax != -1 &&  imax1 != -1)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                int t = b[imax, j];
//                b[imax, j] = b[imax1, j];
//                b[imax1, j] = t;
//            }
//        }
//        Console.WriteLine("Матрица после замены строк:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write("{0:d} ", b[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////2 уровень 1 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[5, 7];
//        Random random = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            int max = a[i, 0];
//            int maxIndex = 0;
//            for (int j = 1; j < 7; j++)
//            {
//                if (a[i, j] > max)
//                {
//                    max = a[i, j];
//                    maxIndex = j;
//                }
//            }
//            if (maxIndex > 0 && maxIndex < 6)
//            {
//                if (a[i, maxIndex - 1] < a[i, maxIndex + 1])
//                {
//                    a[i, maxIndex - 1] *= 2;
//                }
//                else
//                {
//                    a[i, maxIndex + 1] *= 2;
//                }
//            }
//            else if (maxIndex == 0)
//            {
//                a[i, maxIndex + 1] *= 2;
//            }
//            else
//            {
//                a[i, maxIndex - 1] *= 2;
//            }
//        }
//        Console.WriteLine("Матрица A после обработки:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////2 уровень 5 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[7, 5];
//        Random random = new Random();
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            int maxRowIndex = 0;
//            int maxElement = a[0, i];
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[j, i] > maxElement)
//                {
//                    maxElement = a[j, i];
//                    maxRowIndex = j;
//                }
//            }
//            Console.WriteLine($"Максимальный элемент в столбце {i}: {maxElement}");
//            int halfSum = (a[0, i] + a[6, i]) / 2;
//            if (maxElement < halfSum)
//            {
//                a[maxRowIndex, i] = halfSum;
//            }
//            else
//            {
//                a[maxRowIndex, i] = i;
//            }
//            Console.WriteLine("полусумма:");
//            Console.WriteLine(halfSum);
//        }
//        Console.WriteLine("Матрица A после обработки:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////2 уровень 9 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[6, 7];
//        Random random = new Random();
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            int b = 0;
//            int e = 6;
//            while (b < e)
//            {
//                int temp = a[i, b];
//                a[i, b] = a[i, e];
//                a[i, e] = temp;
//                b++;
//                e--;
//            }
//        }
//        Console.WriteLine("Матрица A после обработки:");
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//using System;
////3 уровень 1 задача
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[7, 5];
//        Random random = new Random();
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                a[i, j] = random.Next(100);
//            }
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        int[] min1 = new int[7];
//        for (int i=0; i < 7; i++) 
//        {
//            int amin = a[i,0];
//            for (int j = 0;j < 5; j++)
//            {
//                if (a[i,j] < amin)
//                {
//                    amin= a[i,j];
//                }
//            }
//            Console.WriteLine($"Минимальный элемент в столбце {i}: {amin}");
//            min1[i] = amin;
//        }
//        for (int i = 0; i < 7 - 1; i++)
//        {
//            for (int j = i + 1; j < 7; j++)
//            {
//                if (min1[j] > min1[i])
//                {
//                    int d = min1[i];
//                    min1[i] = min1[j];
//                    min1[j] = d;
//                    for (int k = 0; k < 5; k++)
//                    {
//                        d = a[i, k];
//                        a[i, k] = a[j, k];
//                        a[j, k] = d;
//                    }
//                }
//            }           
//        }
//        Console.WriteLine("Матрица A после обработки:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(a[i, j] + "\t");
//            }
//            Console.WriteLine();
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
//        if (n > 0)
//        {
//            int[,] a = new int[n, n];
//            Random random = new Random();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    a[i, j] = random.Next(100);
//                }
//            }
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(a[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    if (i == n - 1 || j == 0 || j == n - 1 || i == 0)
//                    {
//                        a[i, j] = 0;
//                    }
//                }
//            }
//            Console.WriteLine("Матрица A после обработки:");
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(a[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//        else
//        {
//            Console.WriteLine("В матрице 0 элементов, дальнейшие действия невозможны");
//        }
//    }
//}