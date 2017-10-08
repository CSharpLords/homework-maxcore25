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
           
                Console.WriteLine("Здавствуйте! Пожалуйста, введите Ваш рост:");
                double growth = double.Parse(Console.ReadLine());
                Console.WriteLine("Пожалуйста, введите Ваш вес:");
                double weight = double.Parse(Console.ReadLine());
                int num = 100;
                double optweight = growth - num;
                Console.WriteLine("Ваш оптимальный вес составляет:" + optweight);
                if (weight > optweight)
                {
                    Console.WriteLine("Вам стоит похудеть.");
                }
                else
                {
                    Console.WriteLine("Вам стоит поправиться");
                }
                Console.ReadLine();
          
        }
    }
}
