using System;

namespace BellRing {
	class Program {
		static void Main(string[] args) {
			var bell = new Bell();
			bell.Sound(); // ding
			bell.Sound(); // dong
			bell.Sound(); // ding
			Console.ReadLine();
		}
	}
}