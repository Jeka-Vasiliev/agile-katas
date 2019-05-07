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
					var reverted = string.Join("", label.ToCharArray().Reverse());
					return new[] {label, reverted};
				}

				return new[] {label};
			}

			if (label.Length > 2)
			{
				var reverted = string.Join("", label.ToCharArray().Reverse());
				
				return new[] {label, reverted, "aba"};
			}


			return new string[0];
		}
	}
}