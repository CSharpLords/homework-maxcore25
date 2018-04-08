using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolLine {
	class Program {
		static void Main(string[] args) {
			PrintSymbols("*", 10);
			PrintSymbols("+", 5);

			Console.ReadLine();
		}
        static void PrintSymbols(string symbol, int amount)
        {
            string symbols = symbol;
            for (int i = 1; i < amount; i++)
            {
                symbols = symbols + symbol;
            }
            Console.WriteLine(symbols);
        }
	}
}
