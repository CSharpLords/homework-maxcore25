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

        public int x = 0;
        public int y = 10;



        public void Flight()
        {

            string visualSpeed = "-";
            x += speed;
            for (int n = 1; n < x; n++)
            {

                visualSpeed = visualSpeed + "-";

            }
            Console.WriteLine(visualSpeed);

        }

    }
}
