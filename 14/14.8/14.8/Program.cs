using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = {12, 12, 45, 63, 2, 6, 63, 65, 97, 194};
            int sumOfInt = 0;
            for (int i = 0; i < 6; i++)
            {
                sumOfInt += integers[i];
            }
            Console.WriteLine("The summ of the first six elements is " + sumOfInt);
            Console.ReadLine();
        }
    }
}
