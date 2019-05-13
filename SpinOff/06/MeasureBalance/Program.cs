using System;

namespace MeasureBalance
{
	class Program
	{
		static void Main(string[] args)
		{
			var balance = new Balance();
			balance.AddRight(10);
			balance.AddLeft(5);
			balance.AddLeft(5);
			Console.WriteLine(balance.Weigh() == BalanceState.InBalance); // true

			balance.AddLeft(1);
			Console.WriteLine(balance.Weigh() == BalanceState.Left); // true

			balance.AddRight(2);
			Console.WriteLine(balance.Weigh() == BalanceState.Right); // true

			Console.WriteLine(balance.Weigh() is Enum); // true

			Console.ReadLine();
		}
	}
}