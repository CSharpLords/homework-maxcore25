﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOf7 = 0;
            for(int number = 100; number < 201; number++)
            {
                numberOf7 = number % 7;
                if (numberOf7 == 0)
                {
                    
                    Console.WriteLine(number);
                    
                }
                
                
            }
            Console.ReadLine();
        }
    }
}
