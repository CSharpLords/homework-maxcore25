using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите свой возраст:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10)
            {
                Console.WriteLine("Поздравляю! Ты - подросток. Устрой дестрой, порядок - это отстой!");
            }
            else
            {
                Console.WriteLine("К сожалению, ты мелкий...");
                if (age > 20)
                {
                    Console.WriteLine("Эх, ты уже сишком стар. Ты - не подросток");
                }
                else
                {
                    Console.WriteLine("Поздравляю, ты - подросток. Устрой дестрой, порядок - это отстой!");
                }
            }
            Console.ReadLine();
        }
    }
}
