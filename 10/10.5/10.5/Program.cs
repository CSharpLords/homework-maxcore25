using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите число:");
            double number = double.Parse(Console.ReadLine());
            
            while (true)
            {
                if (number > 1)
                {
                    number = number / 3;
                }
                else if (number == 1)
                {
                    Console.WriteLine("Данное число является степенью числа 3.");
                    break;
                }
                else if (number < 1)
                {
                    Console.WriteLine("Данное число не является степенью числа 3.");
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
