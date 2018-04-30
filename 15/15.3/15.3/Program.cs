using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = {1, 2, 34, 2, 45, 86, 93, 1, 0, 4};
            for (int i = 1; i < integers.Length; i++)
            {
                if(integers[i] > integers[i - 1])
                {
                    Console.WriteLine(integers[i]); 
                }
                
            }
            Console.ReadLine(); 
        }
    }
}
