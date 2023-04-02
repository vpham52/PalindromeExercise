using System;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{

		public WordSmith()
		{

		}

		public bool IsAPalindrome(string word)
		{ 
			if (word == null || word.Length == 0)
			{
				return false;
			}

			var reverse = ""; //string.Empty;

			for (int i = word.Length - 1; i >= 0; i--)
			{
				reverse += word.ToLower()[i];
			}

			return reverse == word.ToLower() ? true : false;
		



		}
		
	}
}

