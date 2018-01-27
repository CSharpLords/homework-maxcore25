using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            for (int number = 1; number < 11; number++)
            {
                Console.WriteLine("Введите расстояние до города № " + number + " :");
                int distance = int.Parse(Console.ReadLine());
                if (maximum < distance)
                {
                    maximum = distance;
                }
            }
            
            Console.WriteLine("Расстояние до самого удалённого города: " +  maximum);
            Console.ReadLine();
        }
    }
}
