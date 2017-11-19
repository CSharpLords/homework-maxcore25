using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMessage("Привет!", false);
            ShowMessage("Внимание! Внимание!", true);
        }
        static void ShowMessage(string message, bool isWarning)
        {
            Console.WriteLine(message);
            if (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadLine();
            }
        }
    }
}
