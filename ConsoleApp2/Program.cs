using System;

class Sample
{
    public static void Main()
    {
        char b = 'B', c = '\x63', d = '\u0032';
        Console.WriteLine("{0} {1} {2}", b, c, d);
        Console.WriteLine("{0} {1} {2}", char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
        char a;
        do
        {
            Console.Write("Введите символ: ");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введен символ {0}, его код - {1}", a, (int)a);
            if (char.IsLetter(a)) Console.WriteLine("Буква ");
            if (char.IsUpper(a)) Console.WriteLine("Верхний регистр");
            if (char.IsLower(a)) Console.WriteLine("Нижний регистр");
            if (char.IsControl(a)) Console.WriteLine("Управляющий");
            if (char.IsNumber(a)) Console.WriteLine("Число ");
            if (char.IsPunctuation(a)) Console.WriteLine("Разделитель");
            Console.WriteLine("\n");
        }
        while (a != 'q');
    }   
}