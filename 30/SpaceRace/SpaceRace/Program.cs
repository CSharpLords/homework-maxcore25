using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    class Program
    {
        static void Main(string[] args)
        {
            SpacePlane spacePlane = new SpacePlane();
            spacePlane.FinishLine();
            spacePlane.Flight();
            /*SpacePlane[] allSpacePlanes = new SpacePlane[10];
            for (int i = 1; i < allSpacePlanes.Length; i++)
            {
                allSpacePlanes[i] = new SpacePlane();
                
                Console.WriteLine("-");
                
                
            }*/
            
            
            
            
            Console.ReadLine();
        }
    }
}
