using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maxindex = new int[9];
            char[] max = new char[9];

            char[][] arr = new char[9][];
            
            Console.WriteLine("Ступенчатый массив:");
            for (int a = 0; a < 9; a++)
            {
                arr[a] = new char[r.Next(10, 35)];
                for (int b = 0; b < arr[a].Length; b++)
                {
                    var c = GetRandomChar();
                    arr[a][b] = c;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Одномерный массив с последними элементами каждой строки: ");
            for (int c = 0; c< arr.Length; c++)
            {
                var last = arr[c].Last();
                Console.Write(last + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Одномерный массив с максимальными элементами каждой строки: ");

            foreach (char[] z in arr)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int x = 0; x < arr[i].Length; x++)
                    {
                        int qq = z[0].CompareTo(arr[i][x]);
                        if (x == arr[i].Length - 1)
                        {
                            if (qq > 0)
                            {
                                Console.Write(z[0] + " ");
                                max[i] = z[0];
                                z[0] = arr[i][0];
                                qq = z[0].CompareTo(arr[i][x]);
                                break;
                            }
                        }
                        if (qq < 0)
                        {
                            z[0] = arr[i][x];
                            qq = z[0].CompareTo(arr[i][x]);
                        }
                        
                    }
                }
                break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ступенчатый массив с изменёнными элементами присутствовать не будет потому что у меня уже мозг плавится");
            
        }


        static string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static Random r = new();
        static char GetRandomChar()
        {
            var randchar = r.Next(symbols.Length);
            return symbols[randchar];
        }
    }
}