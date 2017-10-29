using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.ReadLine(); 
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else if (a == b)
            {
                Console.WriteLine("=");
            }
            Console.ReadLine();
        }
    }
}
