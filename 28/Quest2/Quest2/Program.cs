using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static int HP = 10;
        static int DMG = 10;
        static bool haveHorse = true;
        static int money = 0;
        static bool haveSword = false;
        static bool haveArmour = false;
        static int robbersDMG = 80;
        static int robbersHP = 110;
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
            if (answer1 == 1)
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
            Console.WriteLine("3.Купить меч или доспехи");
            Console.WriteLine("4.Прослушать историю");
            Console.WriteLine("5.Купить аптечку");
            int answer = int.Parse(Console.ReadLine());
            if(answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                if (haveHorse == true)
                {
                    haveHorse = false;
                    money += 100;
                    Console.WriteLine("Держи, дарогой, дэньги! А конь-то харощий!");
                    Console.WriteLine("Баланс: " + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Ты чо, дарогой! Сначала коня, а потом ужэ дэньги! Я тэбе просто так дэньги отдавать нэ буду! Я ж врэдный хач!");
                    Shop();
                }
            }
            else if (answer == 3)
            {
                BuyItem();   
            }
            else if (answer == 4)
            {
                Console.WriteLine("Жиль быль у бабущки сэрэнький козлык! От козлыка осталысь толко ножки да рожки! АХАХАХАХАХА");
                Shop();
            }
            else if (answer == 5)
            {
                BuyAidKit();
            }
        }
        static void FieldGuardian()
        {
            string[] stories = { "Наш мир прекрасен, но тут есть много всяких торчков, которых я просто ненавижу и желаю им долгой и мучительной смерти!", "У нас тут есть насекомые, стрекозлы, крокомоты, дикороги и нособразы!", "У нас тут достаточно смешанный мир: есть магия, но и индустриальные машины, общественные движения, революции и войны, которые напоминают антиутопическую картину" };
            Random rand = new Random();
            int exactStory = rand.Next(0, 3);
            Console.WriteLine(stories[exactStory]);
            Greenfields();
        }
        static void ChooseLocation()
        {
            Console.WriteLine("Выбери локацию:");
            Console.WriteLine("1.Зелёные Поля");
            Console.WriteLine("2.Лавка Торговца");
            Console.WriteLine("3.Лес");
            Console.WriteLine("4.Деревня");
            int travelAnswer = int.Parse(Console.ReadLine());
            if (travelAnswer == 1)
            {
                Greenfields();
            }
            else if (travelAnswer == 2)
            {
                Shop();
            }
            else if (travelAnswer == 3)
            {
                Forest();
            }
            else if (travelAnswer == 4)
            {
                Village();
            }
        }
        static void Forest()
        {
            Console.WriteLine("Это страшный и опасный, но в то же время прекрасный лес! Здесь живут разбойники! Ты заметил их бомжарный лагерь!");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Bыбрать локацию");
            Console.WriteLine("2.Aтаковать разбойников");
            int answer = int.Parse(Console.ReadLine());
            if(answer == 1)
            {
                ChooseLocation();
            }
            else if(answer == 2)
            {
                Fight();
            }
        }
        static void Village()
        {

        }
        static void BuyItem()
        {
            Random rand = new Random();
            int product = rand.Next(0, 2);
            if (product == 0)
            {
                if (money >= 50 && haveSword == false)
                {
                    money -= 60;
                    haveSword = true;
                    DMG = 100;
                    Console.WriteLine("Дэржи мэч, дарогой! Руби всэх наздоровье!");
                    Console.WriteLine("Урон: 100");
                    Console.WriteLine("Баланс:" + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Эу, дарогой! Ты что? У тэбя дэнег савсэм нэту! Пшол к чорту!");
                    Shop();
                }
            }
            else if(product == 1)
            {
                if (money >= 60 && haveArmour == false)
                {
                    money -= 50;
                    haveArmour = true;
                    HP = 100;
                    Console.WriteLine("Дэржи мэч, дарогой! Руби всэх наздоровье!");
                    Console.WriteLine("Здоровье: " + HP);
                    Console.WriteLine("Баланс:" + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Эу, дарогой! Ты что? У тэбя дэнег савсэм нэту! Пшол к чорту!");
                    Shop();
                }
            }

        }
        static void BuyAidKit()
        {
            if (money >= 20)
                {
                    money = -20;
                    HP += 20; 
                    Console.WriteLine("Дэржи аптэку, дарогой! Может прыгодыца!");
                    Console.WriteLine("Баланс: " + money);
                    Shop();
                }
            else
            {
                Console.WriteLine("ДЭНЬГИ ДАЙ!!!");
                Shop();
            }
        }
        static void Fight()
        {
            Console.WriteLine("Разбойники атакуют!");
            HP -= robbersDMG;
            Console.WriteLine("Твоё здоровье:" + HP);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
