using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory 
{
	class Robot 
    {
		private static int lastID = 0;
		public Robot() 
        {
			
		}

		public int GetID() 
        {
            lastID = lastID + 1;
			return lastID;
		}
	}
}
