using System;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            char simv1 = 'a';
            char simv2 = 'b';

            if (text.Length % 2 == 1) 
            {
                simv1 = text[(text.Length - 1) / 2]; 
                Console.WriteLine(simv1);
            }
            else if (text.Length % 2 == 0) 
            {
                simv1 = text[text.Length / 2]; 
                simv2 = text[(text.Length / 2) - 1 ];  
                Console.WriteLine($"{simv1}{simv2}");
            }
        }
    }
}
