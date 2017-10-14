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
            Console.WriteLine("Введите имя первого игрока:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг первого игрока:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя второго игрока:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг второго игрока:");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Результаты сортировки: " + name1 + " " + name2);
            }
            else
            {
                Console.WriteLine("Результаты сортировки: " + name2 + " " + name1);
            }
            Console.ReadLine();
        }
    }
}
