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
            int cowMass = 0;
            int cowAmount = 0;
            int CowsMass = 0;
            while (true)
            {
                Console.WriteLine("Пожалуйста, введите массу коровы:");
                cowMass = int.Parse(Console.ReadLine());
                CowsMass = CowsMass + cowMass;
                if (CowsMass >= strengthUFO)
                {
                    break;
                }  
                cowAmount = cowAmount + 1;
            }
            Console.WriteLine("Отсек для коров заполнен, взлетаем!");
            Console.WriteLine("Количество коров, размещенных на борту:" + cowAmount);
            Console.ReadLine();
        }
    }
}
