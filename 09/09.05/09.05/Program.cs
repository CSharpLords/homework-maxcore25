using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths();
            

        }
        static void Maths()
        {
           
            Console.WriteLine("Здравствуйте! Чтобы закрыть меня, нужно решить задачку:");
            while (true)
            {
                Random random1 = new Random();
                int number1 = random1.Next(15);
                Random random2 = new Random();
                int number2 = random2.Next(20);
                Random random3 = new Random();
                int number3 = random3.Next(25);
                Console.WriteLine("Сколько будет " + number1 + " + " + number2 + " + " + number3 + " ?");
                int guess = int.Parse(Console.ReadLine());
                int sum = number1 + number2 + number3;
                if (guess == sum)
                {   
                    Console.WriteLine("Ну ты и мега-мозг блин! Закрываюсь.");
                    Console.ReadLine();
                    Console.Clear();
                    Environment.Exit(0);
                }
                else if (guess != sum)
                {
                    Console.WriteLine("Не-а! Ну-ка, теперь попробуй решить другую!");
                    
                }
            }
                
            Console.ReadLine();
        }

    }
 }

