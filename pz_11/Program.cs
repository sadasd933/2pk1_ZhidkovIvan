using System;
using System.Linq;


namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите несколько слов через пробел: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str.Length; i++)
            {
                var tmp = str[0];
                str[0] = str[str.Length -1];
                str[str.Length - 1] = tmp;
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
