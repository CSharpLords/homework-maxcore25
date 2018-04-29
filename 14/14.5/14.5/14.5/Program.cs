using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Введите номер элемента массива:");
            int elementNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение элемента:");
            int variableValue = int.Parse(Console.ReadLine());
            if (elementNumber <= integers.Length)
            {
                Console.WriteLine("Элемент номер " + elementNumber + " заменён с числа " + integers[elementNumber - 1] + " на число " + variableValue);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();
        }
    }
}
