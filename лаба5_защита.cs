using System;
//22 задача
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
            V(b);
            V(c);
            mergeSort(b);
            mergeSort(c);
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
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
    static void V(int[] d)
    {
        Console.WriteLine("Получившийся массив: ");
        for (int i = 0; i < d.Length; i++)
        {
            Console.WriteLine(d[i] + "\t");
        }
    }
    static void mergeSort(int[] a)
    {
        int n = a.Length;
        if (n == 1) { return; }
        int mid = n / 2;
        int[] l = new int[mid];
        int[] r = new int[n - mid];
        for (int i = 0; i < mid; i++)
        {
            l[i] = a[i];
        }
        for (int i = mid; i < n; i++)
        {
            r[i - mid] = a[i];
        }
        mergeSort(l);
        mergeSort(r);
        merge(a, l, r);
    }

    static void merge(int[] a, int[] l, int[] r)
    {
        int left = l.Length;
        int right = r.Length;
        int i = 0;
        int j = 0;
        int idx = 0;

        while (i < left && j < right)
        {
            if (l[i] < r[j])
            {
                a[idx] = l[i];
                i++;
                idx++;
            }
            else
            {
                a[idx] = r[j];
                j++;
                idx++;
            }

        }
        for (int ll = i; ll < left; ll++)
        {
            a[idx++] = l[ll];
        }
        for (int rr = j; rr < right; rr++)
        {
            a[idx++] = r[rr];
        }
    }
}