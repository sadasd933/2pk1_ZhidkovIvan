using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Fio()
        {
            string fio = Console.ReadLine();
            string[] arr = fio.Split(" ");
            string surname = arr[0];
            char surname1 = surname[0];
            string name = arr[1];
            char name1 = name[0];
            string fathersname = arr[2];
            char fathersname1 = fathersname[0];
            Console.Write(Char.ToUpper(surname1));
            for (int i = 1; i < surname.Length; i++)
            {
                Console.Write(surname[i]);
            }
            Console.WriteLine(" " + Char.ToUpper(name1) + ". " + Char.ToUpper(fathersname1) + ".");
        }
        public static void Main()
        {
            Console.Write("Введите ФИО в полном формате: ");
            Fio();
        }
    }
}