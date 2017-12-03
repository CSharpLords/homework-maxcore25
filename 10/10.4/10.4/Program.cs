using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравстсвуйте! Пожалуйста, введите грузоподъемность НЛО:");
            int strengthUFO = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите массу коров:");
            int cowMass = int.Parse(Console.ReadLine());
            if (strengthUFO > cowMass)
            {
                Console.WriteLine("Отсек для коров заполнен, взлетаем!");
                double cowAmount = strengthUFO / cowMass;
                Console.WriteLine("Количество коров, рзамещенных на борту:" + cowAmount);
            }
            else
            {
                Console.WriteLine("Слишком большой вес коров, отмена охоты!");
            }
            Console.ReadLine();
        }
    }
}
