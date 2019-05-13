using System;

namespace PushButton {
	class Program {
		static void Main(string[] args) {
			var button = new Button();
			button.Click();
			button.Click();
			Console.WriteLine(button.ClickCount); // 2

			button.Click();
			Console.WriteLine(button.ClickCount); // 3

			button.Reset();
			button.Click();
			Console.WriteLine(button.ClickCount); // 1

			// при раскомментировании строки ниже код должен падать
			//button.ClickCount = 5;

			Console.ReadLine();
		}
	}
}