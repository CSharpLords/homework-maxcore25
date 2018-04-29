using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = {84, 54, 13, 45, 22, 68, 54};
            int sumOfInt = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                sumOfInt += integers[i];
            }
            sumOfInt %= 2;
            if(sumOfInt == 0)
            {
                Console.WriteLine("Cумма элементов массива является четным числом");
            }
            else
            {
                Console.WriteLine("Cумма элементов массива не является четным числом");
            }
            
            Console.ReadLine();
        }
    }
}
