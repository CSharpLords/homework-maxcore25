using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = {1, -2, 4, -5, -7, 9, -10};
            
            for (int a = 0; a < integers.Length;a++)
            {
                Console.WriteLine("Введите номер элемента массива:");
                int number = int.Parse(Console.ReadLine());
                if (integers[number] > 0)
                {
                    Console.WriteLine("Число положительное!");
                }
               
                else
                {
                    Console.WriteLine("Число отрицательное!");
                }
            }
            Console.ReadLine();
        }
    }
}
