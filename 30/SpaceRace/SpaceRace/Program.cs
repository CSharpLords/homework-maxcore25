using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceRace
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rand = new Random();
            
            
            
            SpacePlane[] allSpacePlanes = new SpacePlane[10];
            for (int i = 1; i < allSpacePlanes.Length; i++)
            {
                SpacePlane spacePlane = new SpacePlane();
                spacePlane.speed = rand.Next(3, 7);

                allSpacePlanes[i] = spacePlane;
            }
            bool finishGame = false;
            while (finishGame == false)
            {
                Console.Clear();
                for (int i = 1; i < allSpacePlanes.Length; i++)
                {
                    allSpacePlanes[i].Flight();
                    if (allSpacePlanes[i].x >= 50)
                    {
                        finishGame = true;
                        
                        
                    }
   
                }
                
                FinishLine();

                Thread.Sleep(1000);
                
                
            }

            Console.WriteLine("Final!!!");
            
            
            Console.ReadLine();
        }

        static void FinishLine()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(50, i);
                Console.WriteLine("|");
            }
        }
    }
}
