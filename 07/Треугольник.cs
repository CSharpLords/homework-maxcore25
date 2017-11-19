using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Proof();
        }
        static void Proof ()
        {
                Console.WriteLine("Здравствуйте! Введите, пожалуйста, длину первой стороны:");
                int firstSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите, пожалуйста, длину второй стороны:");
                int secondSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите, пожалуйста, длину третьеё стороны:");
                int thirdSide = int.Parse(Console.ReadLine());
                if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
                {
                    Console.WriteLine("Данный треугольник существует.");
                }
                else
                {
                    Console.WriteLine("Данный треугольник не существует.");
                }
                Console.ReadLine();
         }
    }
}
