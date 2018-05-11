using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory {
	class Robot {
		private static int lastID = 0;
		public Robot() {
			lastID = lastID + 1;
		}

		public int GetID() {
			return lastID;
		}
	}
}
