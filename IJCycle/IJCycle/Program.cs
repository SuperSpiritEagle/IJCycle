using System;

namespace IJCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше сообщение");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите количество повторов сообщения");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1} {text}");
            }
        }
    }
}
