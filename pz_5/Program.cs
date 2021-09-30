using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, m, j; 
            char smv = 'd';
            Console.WriteLine("Задание 1:\n");
            for (i = 0; i <= 70; i = i + 2)
            { 
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nЗадание 2:\n");
            n = 0;
            while (n <= 5)
                {
                n += 1;
                Console.Write(smv + " ");
                smv++;
                }
            Console.WriteLine("\n\nЗадание 3:\n");
            n = 5;
            m = 5;
            for (n = 0; n <= 5; n++)
            {
                for (m = 0; m <= 5; m++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадание 4:\n");
            for (i = 0; i <= 100; i++)
            {
                if (i == 0) continue;
                if ((i % 7) != 0) continue;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nЗадание 5:\n");
            i = 2;
            j = 40;
            for (i = 2, j = 40; j - i > 25; i++, j--)
            {
                Console.WriteLine("i и j равны: " + i + " и " + j);
            }
            Console.ReadLine();
        }
    }
}
