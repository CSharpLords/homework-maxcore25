using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Пожалуйста, введите число:");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                Console.WriteLine("Сумма введённых чисел: " + sum);
            }

        }
    }
}
