using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumFirstShop = 0;
            int sumSecondShop = 0;
            int[] pricesOfFirstShop = new int[61];
            Random rand = new Random();
            for (int i = 0; i < pricesOfFirstShop.Length; i++)
            {
                int price = rand.Next(10, 10000);
                pricesOfFirstShop[i] = price;
                sumFirstShop += price;
            }
            int[] pricesOfSecondShop = new int[61];
            for (int i = 0; i < pricesOfSecondShop.Length; i++)
            {
                int price = rand.Next(10, 10000);
                pricesOfSecondShop[i] = price;
                sumSecondShop += price;
            }
            Console.WriteLine("Общая стоимость проданных фирмой товаров за два месяца равна " + (sumFirstShop + sumSecondShop) + " рублей");
            Console.ReadLine();
        }
    }
}
