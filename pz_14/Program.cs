using System;
using System.IO;
using System.Linq;

namespace pz_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pathToInput = @"C:\Users\ivanz\OneDrive\Рабочий стол\input.txt";
            string pathToOutput = @"C:\Users\ivanz\OneDrive\Рабочий стол\output.txt";
            int[] nums = new int[100];
            File.Delete(pathToInput);

            using (StreamWriter sw = File.AppendText(pathToInput))
            {
                Random rand = new Random();
                for (int i = 0; i < 100; i++)
                {
                    nums[i] = rand.Next(0, 101);
                    sw.WriteLine(nums[i]);
                }
                Console.WriteLine("Числа в файле input.txt сгенерированы.");
            }
            var a = nums.Max();
            var b = nums.Min();
            using (StreamWriter sw = File.AppendText(pathToOutput))
            {
                sw.WriteLine(b);
                sw.WriteLine(a);
            }
            Console.WriteLine($"Максимальное({a}) и минимальное({b}) числа записаны в файл output.txt.");
        }
    }
}