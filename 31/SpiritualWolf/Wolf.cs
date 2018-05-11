using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiritualWolf {
	class Wolf {
		public string[] mantras;
		private Random randGen = new Random();

		public void Wolf(string[] mantras) {
			this.mantras = mantras;
		}

		public void Sing() {
			string mantra = GetRandomMantra();
			Console.WriteLine(mantra);
		}

		void GetRandomMantra() {
			int n = randGen.Next(mantras.Length);
			string mantra = mantras[n];
			return mantra;
		}
	}
}
