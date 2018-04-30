using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] multiplesOfThree = new int[17];
            int firstNumber = 60;
            for (int i = 0; i < multiplesOfThree.Length; i++)
            {
                int residue = firstNumber % 3;
                if(residue == 0)
                {
                    multiplesOfThree[i] = firstNumber;
                    Console.WriteLine(multiplesOfThree[i]);
                    firstNumber -= 3;
                }
            }
            Console.ReadLine();
        }
    }
}
