using NUnit.Framework;

namespace MinMax.UnitTest
{
	[TestFixture]
    public class MinMaxWordFinderTests
    {
		[Test]
	    public void GetLongestWords_EmptyString()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("");
			Assert.AreEqual(new string[] {}, finder.GetLongestWords().ToArray());
		}

		[Test]
	    public void GetLongestWords_SingleWord()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi");
			Assert.AreEqual(new [] {"hi"}, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_TwoWordsHavingDifferentLen()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi world");
			Assert.AreEqual(new [] { "world" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_TwoEqualWords()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi hi");
			Assert.AreEqual(new [] { "hi" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_TwoWordsHavingSameLenAndAlphabetOrder()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hello world");
			Assert.AreEqual(new [] { "hello", "world" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_TwoWordsHavingSameLenAndReverseOrder()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("world hello");
			Assert.AreEqual(new [] { "world", "hello" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_TwoWordsHavingSameLenAndManySpaces()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("  hello     world    ");
			Assert.AreEqual(new [] { "hello", "world" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetLongestWords_ThreeWordsTwoSentences()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi world");
		    finder.AddSentence("win");
			Assert.AreEqual(new [] { "world" }, finder.GetLongestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_EmptyString()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("");
			Assert.AreEqual(new string[] {}, finder.GetShortestWords().ToArray());
		}

		[Test]
	    public void GetShortestWords_SingleWord()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi");
			Assert.AreEqual(new [] {"hi"}, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_TwoWordsHavingDifferentLen()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi world");
			Assert.AreEqual(new [] { "hi" }, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_TwoEqualWords()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi hi");
			Assert.AreEqual(new [] { "hi" }, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_TwoWordsHavingSameLenAndAlphabetOrder()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hello world");
			Assert.AreEqual(new [] { "hello", "world" }, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_TwoWordsHavingSameLenAndReverseOrder()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("world hello");
			Assert.AreEqual(new [] { "world", "hello" }, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_TwoWordsHavingSameLenAndManySpaces()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("  hello     world    ");
			Assert.AreEqual(new [] { "hello", "world" }, finder.GetShortestWords().ToArray());
	    }

		[Test]
	    public void GetShortestWords_ThreeWordsTwoSentences()
	    {
		    var finder = new MinMaxWordFinder();
		    finder.AddSentence("hi world");
		    finder.AddSentence("win");
			Assert.AreEqual(new [] { "hi" }, finder.GetShortestWords().ToArray());
	    }
	}
}
