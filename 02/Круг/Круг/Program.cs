using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Формула площади круга: PI * r * r");
            Console.WriteLine("Введите длину радиуса:");
            double radius = double.Parse(Console.ReadLine());
            double area = 3 * radius * radius;
            Console.WriteLine("S=" + area);
            Console.ReadLine();
        }
    }
}

