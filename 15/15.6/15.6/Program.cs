using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] growths = new int[12];
            for (int i = 0; i < growths.Length; i++)
            {
                Random rand = new Random();
                int exactGrowth = rand.Next(163, 191);
                growths[i] = exactGrowth;
                Console.WriteLine(growths[i]);
            }
            Console.ReadLine();
        }
    }
}
