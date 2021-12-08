using System;
using System.Linq;

namespace pz_18
{
    class Program
    {
        //Задание 1
        static int zxc1(int a1, int d, int n)
        {

            if (n < 0) { Console.WriteLine("Ошибка"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(a1); return a1; }
            else { a1 = a1 + d; n = n - 1; return zxc1(a1, d, n); }

        }
        //Задание 2
        static double zxc2(double b1, double q, int n)
        {
            if (n < 0) { Console.WriteLine("Ошибка"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(b1); return b1; }
            else { b1 = b1 * q; n = n - 1; return zxc2(b1, q, n); }

        }
        //Задание 3
        static int zxc3(int A, int B)
        {
            if (A == B) { Console.WriteLine($"{A}\n"); return 0; }
            else { Console.Write($"{A} "); A += 1; }
            return zxc3(A, B);
        }
        //Задание 4
        static int Summ(int x, int e)
        {
            if (x < 0) { Console.WriteLine("Ошибка!");return 0; }
            if (x == 0) { Console.WriteLine(0); return 0; }
            if (x == 1) { Console.WriteLine($"Сумма чисел = {e + 1 } "); }
            else { e = e + x; x = x - 1; return Summ(x, e); }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Задание №1:");
            int n = Convert.ToInt16(Console.ReadLine());
            zxc1(100, 10, n);
            Console.Write("Задание №2:");
            n = Convert.ToInt16(Console.ReadLine());
            zxc2(4, 0.1, n);
            Console.Write("задание №3:");
            zxc3(5, 65);
            Console.Write("задание №4:");
            n = Convert.ToInt32(Console.ReadLine());
            Summ(n, 0);
        }
    }
}
