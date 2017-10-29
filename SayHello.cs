using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            Console.ReadLine();
        }
        static void SayHello()
        {
            Console.WriteLine("Пожалуйста, введите Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");
        }
    }
}
