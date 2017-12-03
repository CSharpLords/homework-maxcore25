using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите число:");
            int number = int.Parse(Console.ReadLine());
            int squaredNumber = number * number;
            Console.WriteLine("Квадрат данного числа равен " + squaredNumber);
            Console.ReadLine();
        }
    }
}
