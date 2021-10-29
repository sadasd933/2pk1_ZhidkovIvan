using System;

namespace PZ9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[5, 10];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = random.NextDouble() * 100;
                    Console.Write($"a[{i},{j}] = {a[i, j]}\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                double sum = 0;
                for (int j = 0; j < 10; j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine($"Сумма элементов {i + 1}-й строки равна {sum}");
            }
            for (int i = 0; i < 5; i++)
            {
                double mult = 1;
                for (int j = 0; j < 10; j++)
                {
                    mult *= a[i, j];
                }
                Console.WriteLine($"Произведение элементов {i + 1}-й строки равна {mult}");
            }
        }
    }
}