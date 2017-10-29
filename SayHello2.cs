using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
       {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите Ваше имя:");
            string Name = Console.ReadLine();
            SayHello(Name);
       }
        static void SayHello(string Name)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Привет," + Name + "!");
            Console.ReadLine();
        }
    }
}
