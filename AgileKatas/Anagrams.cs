using System;
using System.Linq;

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

			if (label.GroupBy(x => x).Count() == 1)
			{
				return new[] {label};
			}

			if (label.Length == 2)
			{
				if (label[0] != label[1])
				{
					return new[] {label, string.Join("", label.ToCharArray().Reverse())};
				}

				return new[] {label};
			}

			return new string[0];
		}
	}
}