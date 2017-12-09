using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int sumOfN = 0;
            double avarageSum = 0;
            for ( int amountRand = 0; amountRand <= 50; amountRand = amountRand + 1)
            {
                
                int n = rand.Next(50);
                sumOfN = sumOfN + n;
                Console.WriteLine(n);
            }

            avarageSum = sumOfN / 50;
            Console.WriteLine("Среднее арифметическое: " + avarageSum);
            Console.ReadLine();
        }
    }
}
