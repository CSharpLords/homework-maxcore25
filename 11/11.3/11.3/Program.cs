using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int amountOfTallBoyar = 0;
            for (int amountOfBoyar = 0; amountOfBoyar < 3; amountOfBoyar++) 
            {
                Console.WriteLine("Пожалуйста,введите рост боярина: ");
                int boyarGrowth = int.Parse(Console.ReadLine());
                amountOfBoyar++;
                
            }

            if (amountOfTallBoyar >= 160)
            {
                amountOfTallBoyar = amountOfTallBoyar + 1;
            }

            Console.WriteLine("Котличество тех бояр, которые должны подвергнуться наказанию: " + amountOfTallBoyar);
            
            
            Console.ReadLine();
        }
    }
}
