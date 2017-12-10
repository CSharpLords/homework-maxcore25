using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите слово: ");
            string word = Console.ReadLine().ToLower();
            int haveJe = 0;
            for (int je = 0; je < word.Length; je++)
            {
                 if(word[je] == 'ж')
                {
                    haveJe = haveJe + 1;
                }
            }
            if (haveJe >= 1)
            {
                Console.WriteLine("В слове " + word + " есть буква 'Ж'. Количество буквы 'Ж': " + haveJe);
            }
            if (haveJe == 0)
            {
                Console.WriteLine("В слове " + word + " буква 'Ж' не найдена. Количество буквы 'Ж': " + haveJe);
            }
            Console.ReadLine();
        }
    }
}
