using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите число:");
            int number = int.Parse(Console.ReadLine());
            int x = 0;
            while (x < number)
            { 
               
                x = x + 1;
                int squaredX = x * x;
                if (squaredX > number)
                {
                    break;
                }
                Console.WriteLine(squaredX);
               
            }
            Console.ReadLine();
        }
    }
}
