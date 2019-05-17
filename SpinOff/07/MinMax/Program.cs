using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax {
	class Program {
		static void Main(string[] args) {
			var finder = new MinMaxWordFinder();
			finder.AddSentence("hello abc world");
			finder.AddSentence("def asdf qwert");
			Console.WriteLine(string.Join(", ", finder.GetShortestWords())); // abc, def
			Console.WriteLine(string.Join(", ", finder.GetLongesttWords())); // hello, qwert, world

			finder.AddSentence("  abc     table    ");
			finder.AddSentence("world");
			finder.AddSentence("def");
			Console.WriteLine(string.Join(", ", finder.GetShortestWords())); // abc, def
			Console.WriteLine(string.Join(", ", finder.GetLongesttWords())); // hello, qwert, table, world

			finder.AddSentence("pool");
			finder.AddSentence("people");
			Console.WriteLine(string.Join(", ", finder.GetShortestWords())); // abc, def
			Console.WriteLine(string.Join(", ", finder.GetLongesttWords())); // people

			Console.ReadLine();
		}
	}
}