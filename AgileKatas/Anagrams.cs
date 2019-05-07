using System;

namespace AgileKatas
{
	public class Anagrams
	{
		public static string[] Get(string label)
		{
			if (label.Length == 1)
			{
				return new[] {label};
			}

			if (label.Length == 2)
			{
				return new [] {label};
			}

			return new string[0];
		}
	}
}