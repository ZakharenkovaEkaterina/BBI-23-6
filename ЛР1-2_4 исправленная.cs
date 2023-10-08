using System;
//2 уровень 4 задача
namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            double sum = 0;
            double x = 0.9;
            double last_sum = 0;
            double term = 1;

            for (int n = 1; n <= 10000; n++)
            {
                term *= x * x;
                sum += term;

                if (term >= 0.0001)
                {
                    last_sum = sum;
                }
                {
                    Console.WriteLine(last_sum);
                    break;
                }
            }
        }
    }
}
