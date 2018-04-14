using System;

namespace ElementCounter {
	class Program {
		static void Main(string[] args) {
			int count1 = GetElementCount(new int[] { 1, 2, -1, 10, -2, 2, 34, 2 }, 2);
			Console.WriteLine(count1);

			int count2 = GetElementCount(new int[] { 23, 23, 5, 5, -5, 0, 230, 11 }, -3);
			Console.WriteLine(count2);

			Console.ReadLine();
		}
	}
}
