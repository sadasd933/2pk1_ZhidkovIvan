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

            int[] maxindex = new int[72];
            int[] maxnx = new int[72];
            int[][] arr = new int[9][];

            Console.WriteLine("Ступенчатый массив:");
            for (int a = 0; a < 9; a++)
            {
                arr[a] = new int[r.Next(10, 35)];
                for (int b = 0; b < arr[a].Length; b++)
                {
                    int c = r.Next(65, 91);
                    arr[a][b] = c;
                    Console.Write(Convert.ToChar(c) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Одномерный массив с последними элементами каждой строки: ");
            for (int c = 0; c< arr.Length; c++)
            {
                int last = arr[c].Last();
                Console.Write(Convert.ToChar(last) + " ");
            }
            Console.WriteLine("\n");

            maxnx[0] = -1;

            Console.WriteLine("Одномерный массив с максимальными элементами каждой строки: ");

            for (int i = 0; i < 9; i++)
            {
                for (int x = 0; x < arr[i].Length; x++)
                {
                    if (maxnx[i] <= arr[i][x])
                    {
                        maxnx[i] = arr[i][x];
                        maxindex[i] = x;
                    }
                    if (x >= arr[i].Length - 1)
                    {
                        Console.Write(Convert.ToChar(maxnx[i]) + " ");
                        break;
                    }

                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Ступенчатый массив с изменёнными элементами:");
            for (int i = 0; i < 9; i++)
            {
                for (int x = 0; x < arr[i].Length; x++)
                {
                        var tmp = maxindex[i];
                        arr[i][0] = maxnx[i];
                        arr[i][tmp] = arr[i][0];
                        Console.Write(Convert.ToChar(arr[i][x]) + " ");
                }
                Console.WriteLine();
            }
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