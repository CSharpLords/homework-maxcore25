using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativePrecipitations 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			int[] precipitations = { 23, 4545, 45, 2, -16, 765, 341, 1, -3, 0 };
            Console.WriteLine("Количество осадков за первый месяц: " + precipitations[0]);
			for (int i = 1; i < precipitations.Length; i++) 
            {
				precipitations[i] = precipitations[i] - precipitations[0];
                Console.WriteLine("Изменение количества осадков относительно первого месяца" + precipitations[i]);
			}
			Console.ReadLine();
		}
	}
}
