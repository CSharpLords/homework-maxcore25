using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};
            int sum = 0;

            foreach (int el in numbers)
            {
                sum += el;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
