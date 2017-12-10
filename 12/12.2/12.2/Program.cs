using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            for (double number = 0.1; number < 0.9; number = number + 0.1)
            {
                result = Math.Sqrt(number);
                Console.WriteLine("√" + number + " = " + result);
            }
            Console.ReadLine();
        }
    }
}
