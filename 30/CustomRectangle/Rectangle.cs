using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRectangle
{
    class Rectangle
    {
        public int x;
        public int y;
        public int height;
        public int width;
        public string symbol;
        public void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                y += 1;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);


            }
            
            
            for (int j = 1; j < width; j++)
            {

                x += 1;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);
            }
            
            
        }
    }
}
