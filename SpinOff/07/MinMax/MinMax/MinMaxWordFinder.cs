using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
	public class MinMaxWordFinder
	{
		private List<string> words = new List<string>();

		public void AddSentence(string text)
		{
			words.AddRange(text.Split());
			words = words.Distinct().Where(w => w.Length > 0).ToList();
		}

		public List<string> GetShortestWords()
		{
			if (words.Count == 0)
			{
				return words;
			}

			int min = words.Min(w => w.Length);
			return words.Where(w => w.Length == min).ToList();
		}

		public List<string> GetLongestWords()
		{
			if (words.Count == 0)
			{
				return words;
			}

			int max = words.Max(w => w.Length);
			return words.Where(w => w.Length == max).ToList();
		}
	}
}