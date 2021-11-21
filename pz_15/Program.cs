using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {

            float sum = 0;
            string path = @"C:\Users\ivanz\OneDrive\Рабочий стол\input.txt";
            string AllText;
            using (FileStream fs = File.Create(path)) { }
            using (StreamWriter sw = File.AppendText(path))
            {
                Random rand = new Random();
                for (int i = 1; i <= 50; i++)
                {
                    if (i <= 9)
                    {
                        sw.WriteLine("00" + i + " " + rand.Next(1000, 10000) + "," + rand.Next(10, 100));
                    }
                    else if (i > 9)
                    {
                        sw.WriteLine("0" + i + " " + rand.Next(1000, 10000) + "," + rand.Next(10, 100));
                    }
                }
            }
            using (FileStream file = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(file))
                AllText = reader.ReadToEnd();
            string[] lines = AllText.Split(' ', '\n'); 
            float[] lines1 = new float[150];
            for (int i = 0; i < lines.Length-1; i++)
            {
                var a = i+1;
                if (lines[i].StartsWith('0')) 
                {
                    continue;
                }
                else
                {
                    if (i / 2 + 1 == 51)
                    {
                        break;
                    }
                    lines1[i]= float.Parse(lines[i]);
                    sum = sum + lines1[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}