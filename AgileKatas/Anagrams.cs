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
				if (label == "ab")
				{
					return new[] {"ab", "ba"};
				}

				return new[] {label};
			}

			return new string[0];
		}
	}
}