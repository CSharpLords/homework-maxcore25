using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Приветствую тебя, супергерой! Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер! У тебя есть два выбора:");
            Console.WriteLine("1. Поиграть в Доту.");
            Console.WriteLine("2. Узнать, на каком сайте она застряла.");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("2) Известно, что принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер с ссылкой на сайт dontclickme.noob. Решай, что будешь делать:");
            }
            Console.WriteLine("1. Послушаться совета в адресе сайта и поиграть в Доту.");
            Console.WriteLine("2. Перейти на сайт.");
            Console.WriteLine("3. Обновить антивирус, а потом перейти на сайт");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("Ты - слишком послушный человек, и, к сожалению, другой хакер спас принцессу. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (b == 2)
            {
                Console.WriteLine("Ты заразился тем же вирусом, что и принцесса. Ты застрял на том же сайте со сломанным компьютером. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (b == 3)
            {
                Console.WriteLine("3) Ты встречаешь противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2? Варианты поведения:");
            }
            Console.WriteLine("1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            Console.WriteLine("2. Проверить исходный код Капча-Монстра.");
            Console.WriteLine("3. Я решил. Ответ: 6.");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("Ты поленился посчитать лёгкий пример. Ты проиграл - другой хакер спас принцессу. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (c == 3)
            {
                Console.WriteLine("Ты слишком наивный - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2). Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (c == 2)
            {
                Console.WriteLine("4) Ты вскрываешь код Капча-Монстра и видишь, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне! Варианты поведения:");
            }
            Console.WriteLine("1. Круто, пойду попробую так в своей программе!");
            Console.WriteLine("2. Ответить монстру: 6.");
            Console.WriteLine("3. Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра.");
            int d = int.Parse(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("Ты - эгоист. Ты проиграл - принцесса заблудилась во Всемирной Сети, пока ты ковырялся не там, где надо. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (d == 2)
            {
                Console.WriteLine("Ты очень невнимательный. Ты проиграл - зря, что ли, подвох находил??? Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (d == 3)
            {
                Console.WriteLine("5) Капча-Монстр хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2 ) * 2? Варианты поведения:");
            }
            Console.WriteLine("1. Ответить монстру: 8.");
            Console.WriteLine("2. Герою лень считать, и он идет в Доту.");
            int e = int.Parse(Console.ReadLine());
            if (e == 2)
            {
                Console.WriteLine("Ты потерял возможность спасти принцессу - другой хакер спас принцессу. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (e == 1)
            {
                Console.WriteLine("6) Капча-Монстр обиженно сопит: Как ты догадался? Я же спрятал скобки! Отступает и позволяет обновить антивирус. Теперь ты защищен, и может перейти на сайт! Едва ты делаешь это, как получаешь сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock.1.0. Файл-лекарство можно найти здесь: C:Antivirus.cure.exe. Варианты действий:");
            }
            Console.WriteLine("1. Отправить лекарство принцессе по почте и пойти в Доту.");
            Console.WriteLine("2. Записать лекарство на флешку и пойти к принцессе домой.");
            int f = int.Parse(Console.ReadLine());
            if (f == 1)
            {
                Console.WriteLine("Ты проиграл - у нее сломался компьютер, она не может получить твой файл! Принцессу спасает другой хакер. Game over.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (f == 2)
            {
                Console.WriteLine("ПОБЕДА!!! Ты спас принцессу! ПОЗДРАВЛЯЮ! Живите долго и счастливо!");
            }
            Console.ReadLine();
        }
    }
}
