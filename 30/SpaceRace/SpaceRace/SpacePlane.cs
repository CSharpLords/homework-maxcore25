using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceRace
{
    class SpacePlane
    {
        public int speed;
        public int distance = 6;
        public int x = 0;
        public int y = 10;


        public void FinishLine()
        {

            for (int i = 0; i < 10; i++)
            {
                y -= 1;
                Console.SetCursorPosition(50, y);
                Console.WriteLine("|");

            }
            Console.SetCursorPosition(x, y);

        }



        Random rand = new Random();
        public void Flight()
        {


            for (int i = 0; i < distance; i++)
            {
                speed = rand.Next(3, 7);
                string visualSpeed = "-";
                for (int n = 1; n < speed; n++)
                {
                    visualSpeed = visualSpeed + "-";
                    Console.Write(visualSpeed);
                }


                Thread.Sleep(1000);


                if (i >= distance)
                {
                    WriteFinal();
                    break;
                }
            }

        }
        public void WriteFinal()
        {
            Console.WriteLine("Final!!!");
        }
    }
}
