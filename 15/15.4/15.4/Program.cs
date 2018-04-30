using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { -43, 10, 9, -23, -54 };
            int signPlus = 0;
            int signMinus = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > 0)
                {
                    signPlus++;
                    signMinus = 0;

                }
                if (integers[i] < 0)
                {
                    signMinus++;
                    signPlus = 0;
                }

                if (signPlus == 2)
                {
                    Console.WriteLine(integers[i - 1] + " " + integers[i]);
                    break;
                }
                if (signMinus == 2)
                {
                    Console.WriteLine(integers[i - 1] + " " + integers[i]);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
