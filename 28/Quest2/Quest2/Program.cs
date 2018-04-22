using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У героя нет ничего, кроме верного коня. Даже меча, и того нет! Но он мечтает о подвигах. После долгих дней странствий наткнулся он на заброшенную деревушку. Злобный Великан повадился от скуки крушить и ломать дома крестьян, красть скот, вытаптывать поля.");
            Console.WriteLine("Вот тут вот наша игра и начинается!");
            Greenfields();
            Console.ReadLine();
        }
        static void Greenfields()
        {
            Console.WriteLine("Ты начинаешь своё путешествие с Зелёных Полей. Это мирное место, где сияет солнце, и травка зеленеет.");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Выбрать эту локацию и подойти к лавке торговца");
            Console.WriteLine("2.Послушать историю Хранителя Поля");
            int answer1 = int.Parse(Console.ReadLine());
            if(answer1 == 1)
            {
                Shop();
            }
            if (answer1 == 2)
            {
                FieldGuardian();
            }
        }
        static void Shop()
        {
            Console.WriteLine("Прывэтствую тэбя, мой дарогой гэрой, в сваей самой лучшей лавке! У мэня тут всё есть: всё что захочышь!");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Выбрать локацию");
            Console.WriteLine("2.Продать коня");
            Console.WriteLine("3.Купить меч");
        }
        static void FieldGuardian()
        {
            string[] stories = {"Наш мир прекрасен, но тут есть много всяких торчков, которых я просто ненавижу и желаю им долгой и мучительной смерти!", "У нас тут есть насекомые, стрекозлы, крокомоты, дикороги и нособразы!", "У нас тут достаточно смешанный мир: есть магия, но и индустриальные машины, общественные движения, революции и войны, которые напоминают антиутопическую картину"};
            Random rand = new Random();
            int exactStory = rand.Next(0, 3);
            if(exactStory == 0)
            {
                Console.WriteLine(stories[0]);
            }
            if (exactStory == 1)
            {
                Console.WriteLine(stories[1]);
            }
            if (exactStory == 2)
            {
                Console.WriteLine(stories[2]);
            }
        }
    }
}
