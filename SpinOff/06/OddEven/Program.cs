using System;
using System.Collections.Generic;

namespace OddEven {
	class Program {
		static void Main(string[] args) {
			var separator = new OddEvenSeparator();
			separator.AddNumber(1);
			separator.AddNumber(5);
			separator.AddNumber(6);
			separator.AddNumber(8);
			separator.AddNumber(3);
			Console.WriteLine(string.Join(", ", separator.Evens)); // 6, 8
			Console.WriteLine(string.Join(", ", separator.Odds)); // 1, 5, 3

			Console.ReadLine();
		}
	}
}