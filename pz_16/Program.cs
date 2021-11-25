using System;
using System.Linq;

namespace pz_16
{
    class Program
    {
        static void GetMax()
        {
            int a1 = 0;
            string a = "bebra";
            int[] r = new int[a.Length];
            while (a.Length != 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Введите число: ");
                    a = Console.ReadLine();
                    if (a.Length == 0)
                    {
                        break;
                    }
                    r[i] = int.Parse(a);
                }
            }
            for (int c = 0; c < r.Length; c++)
            {
                if(r[c]>a1)
                {
                    a1 = r[c];
                }
            }
            Console.WriteLine(a1);
        }

        static void Main(string[] args)
        {
            GetMax();
        }
    }
}
