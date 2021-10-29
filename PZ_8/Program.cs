using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int[] A = new int[10];
            int min = int.MaxValue;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                A[i] = rnd.Next(-50, 50);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (A[i] < 0)
                {
                    sum = sum + A[i];
                }
            }
            foreach (int a in A)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            if (sum < 100)
            {
                sum = sum + min;
                Console.WriteLine(sum);
            }
            else
                Console.WriteLine(sum);

        }
    }
}

