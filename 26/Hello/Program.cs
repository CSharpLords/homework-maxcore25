using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			SayHello("Маша");
			SayHello("Женя");
			SayHello("Петя");

			Console.ReadLine();
		}

		static void SayHello(string name) 
        {
            
            Random rand = new Random();
            int number = rand.Next(0, 3);
            if (number == 0)
            {
                Console.WriteLine("Привет, " + name);
            }
            
            else if(number == 1)
            {
                Console.WriteLine("Добрый день, " + name);
            }
            
            else if(number == 2)
            {
                Console.WriteLine("Здравствуй, " + name);
            }
           
		}
	}
}
