using System;
using System.Collections.Generic;
using System.Linq;

namespace Paragraphs {
	class Program {
		static void Main(string[] args) {
			var lp = new LeftParagraph(8);
			lp.AddWord("abc");
			lp.AddWord("defg");
			lp.AddWord("hi");
			lp.AddWord("jklmnopq");
			lp.AddWord("r");
			lp.AddWord("stuv");
			/* выведется
			abc defg
			hi 
			jklmnopq
			r stuv
			 */
			Console.WriteLine(lp.Get());

			var rp = new RightParagraph(8);
			rp.AddWord("abc");
			rp.AddWord("defg");
			rp.AddWord("hi");
			rp.AddWord("jklmnopq");
			rp.AddWord("r");
			rp.AddWord("stuv");
			/* выведется
			abc defg
				  hi
			jklmnopq
			  r stuv
			 */
			Console.WriteLine(rp.Get());

			Console.ReadLine();
		}
	}
}
