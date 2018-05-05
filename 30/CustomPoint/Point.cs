using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint
{
    class Point
    {
        public int x;
        public int y;
        
        public string symbol;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
