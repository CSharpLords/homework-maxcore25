using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static double HP = 50;
        static double DMG = 10;
        static bool haveHorse = true;
        static double money = 0;
        static bool haveSword = false;
        static bool haveArmour = false;
        static double robbersDMG = 80;
        static double robbersHP = 110;
        static double maxRobbersHP = 110;
        static double giantDMG = 100;
        static double giantHP = 200;
        static double maxGiantHP = 220;
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
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                if (haveHorse == true)
                {
                    haveHorse = false;
                    money = 100;
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
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                FightRobbers();
            }
        }
        static void Village()
        {
            Console.WriteLine("Здесь терроризирует местных жителей великан! Замочи великана и спаси колхозников");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Bыбрать локацию");
            Console.WriteLine("2.Aтаковать великанa");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                FightGiant();
            }
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
            else if (product == 1)
            {
                if (money >= 60 && haveArmour == false)
                {
                    money -= 50;
                    haveArmour = true;
                    HP = 100;
                    Console.WriteLine("Дэржи браню, дарогой! Зашышайся наздоровье!");
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
                money -= 20;
                HP += 20;
                Console.WriteLine("Дэржи аптэку, дарогой! Может прыгодыца!");
                Console.WriteLine("Баланс: " + money);
                Console.WriteLine("Твоё здоровье: " + HP);
                Shop();
            }
            else
            {
                Console.WriteLine("ДЭНЬГИ ДАЙ!!!");
                Shop();
            }
        }
        static void FightRobbers()
        {
            RobbersAttack();
            if (robbersHP > 0)
            {
                if (HP > 0)
                {
                    AskQuestion();
                    HeroAttack();
                }

                else if (HP <= 0)
                {
                    Console.WriteLine("Тебе кинули в лицо серную кислоту! Ты сдох!");
                    End();
                }
            }
            else
            {
                HP = 180;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ты втыкаешь меч в шею одному разбойнику, делаешь сальтуху и втыкаешь в кишки другому! Они умерают от потери крови!");
                Console.WriteLine("Твоё здоровье восстановилось. Прибавилось бонусное здоровье!");
                Console.WriteLine("Теперь твоё здоровье: " + HP);
                ChooseLocation();
            }
        }
        static void RobbersAttack()
        {
            Console.WriteLine("Разбойники атакуют!");
            HP -= robbersDMG;
            robbersDMG = GetReducedAttack(robbersHP, maxRobbersHP, robbersDMG);
            Console.WriteLine("Твоё здоровье:" + HP);
        }
        static void HeroAttack()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ты атакуешь!");
            robbersHP = robbersHP - DMG;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Хп : " + robbersHP);
        }
        static void End()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выбери желание:");
            Console.WriteLine("1.Выйти из игры, т.к. я уже задолбался");
            Console.WriteLine("2.Начать сначала, т.к. это самая лучшая игра");
            int lastAnswer = int.Parse(Console.ReadLine());
            if (lastAnswer == 1)
            {
                Environment.Exit(0);
            }
            else if (lastAnswer == 2)
            {
                Reset();
                Greenfields();
            }
        }
        static void AskQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2.Убежать в Зелёные поля");
            int answerQuestion = int.Parse(Console.ReadLine());

            if (answerQuestion == 1)
            {
                HeroAttack();
                FightRobbers();
            }
            else if (answerQuestion == 2)
            {
                robbersDMG = 80;
                robbersHP = 110;
                Greenfields();
            }
        }
        static void Reset()
        {
            HP = 10;
            DMG = 10;
            haveHorse = true;
            money = 0;
            haveSword = false;
            haveArmour = false;
            robbersDMG = 80;
            robbersHP = 110;
            maxRobbersHP = 110;
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double healthProportion = maxHealth / health;
            double attackProportion = maxAttack / healthProportion;
            return attackProportion;
        }
        static void FightGiant()
        {
            GiantAttack();
            if (giantHP > 0)
            {
                if (HP > 0)
                {
                    AskQuestionFG();
                    HeroAttack();
                }

                else if (HP <= 0)
                {
                    Console.WriteLine("Тебя растоптали в лепёху! Ты сдох!");
                    End();
                }
            }
            else
            {

                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ты втыкаешь меч в ногу великана, прыгаешь ему на спину и отрубаешь огромную рожу! Он умерает от потери головы!");
                
                End();
            }
        }
        static void GiantAttack()
        {
            Console.WriteLine("Великан атакуeт!");
            HP -= giantDMG;
            giantDMG = GetReducedAttack(robbersHP, maxRobbersHP, robbersDMG);
            Console.WriteLine("Твоё здоровье:" + HP);
        }
        static void AskQuestionFG()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2.Убежать в Зелёные поля");
            int answerQuestion = int.Parse(Console.ReadLine());

            if (answerQuestion == 1)
            {
                HeroAttack();
                FightGiant();
            }
            else if (answerQuestion == 2)
            {
                Greenfields();
            }
        }
    }
}
