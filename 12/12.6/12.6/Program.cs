using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите слово:");
            string word = Console.ReadLine();
            for (int letter = 0; letter < word.Length; letter++)
            {
                int end = word.Length - 1;
                Console.WriteLine(word[end - letter]);
            }
                Console.ReadLine();
        }
    }
}
