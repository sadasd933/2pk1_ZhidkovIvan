using System;

namespace pz_13
{
    class Program
    {
        public enum Rating {
        Very_Bad = 1,
        Bad = 2,
        Good = 3,
        Very_Good = 4,
        Excellent = 5};


        static void Main()
        {
            Console.Write("Введите оценку: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch ((Rating)num)
            { 
                case Rating.Very_Bad: Console.WriteLine($"Характеристика отметки {Rating.Very_Bad}: очень плохо"); break;
                case Rating.Bad: Console.WriteLine($"Характеристика отметки {Rating.Bad}: неудовлетворительно"); break;
                case Rating.Good: Console.WriteLine($"Характеристика отметки {Rating.Good}: удовлетворительно"); break;
                case Rating.Very_Good: Console.WriteLine($"Характеристика отметки {Rating.Very_Good}: хорошо"); break;
                case Rating.Excellent: Console.WriteLine($"Характеристика отметки {Rating.Excellent}: отлично"); break;
                default: Console.WriteLine("Оценка должна быть в пределах от 1 до 5!"); break;

            }
        }
    }
}
