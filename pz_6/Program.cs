using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.Write("Введите сумму начального вклада: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите ежегодный процент: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Введите конечную сумму: ");
            double y = double.Parse(Console.ReadLine());
            do
            {
                x = ((x / 100) * p) + x;
                j++;
            }
            while (x < y);
            Console.WriteLine(j);
        }
    }
}