using System;
//22 задача исправленная
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        if (n > 0 && m > 0)
        {
            int[,] a = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = random.Next(-100, 50);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[] b = new int[n];
            int[] c = new int[m];
            b = H(a);
            c = L(a);
            Console.WriteLine("Получившийся массив b:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(b[i] + "\t");
            }
            Console.WriteLine("Получившийся массив c:");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(c[i] + "\t");
            }
        }
        else
        {
            Console.WriteLine("В массивах 0 элементов, дальнейшие действия невозможны");
        }
    }
    static int[] H(int[,] k)
    {
        int Count = 0;
        int[] f = new int[k.GetLength(0)];
        for (int i = 0; i < k.GetLength(0); i++)
        {
            for (int j = 0; j < k.GetLength(1); j++)
            {
                if (k[i, j] < 0)
                {
                    Count++;
                }
            }
            f[i] = Count;
            Count = 0;
        }
        return f;
    }
    static int[] L(int[,] k)
    {
        int[] f = new int[k.GetLength(1)];
        int max = 0;
        for (int j = 0; j < k.GetLength(1); j++)
        {
            for (int i = 0; i < k.GetLength(0); i++)
            {
                if (k[i, j] < 0 && max == 0)
                {
                    max = k[i, j];
                }
                if (k[i, j] < 0 && k[i, j] > max)
                {
                    max = k[i, j];
                }
            }
            f[j] = max;
            max = 0;
        }
        return f;
    }
}