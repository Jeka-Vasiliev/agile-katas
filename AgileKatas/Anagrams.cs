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

			if (label.Length > 2 && label.GroupBy(x=>x).Count() == 2)
			{
				var uniqueKey = label.GroupBy(x => x).Where(x => x.Count() == 1).Single().Key;
				var nonUniqueKey = label.GroupBy(x => x).Where(x => x.Count() > 1).Single().Key;
				
				return Enumerable.Range(0, label.Length)
					.Select(i => string.Join("", Enumerable.Range(0 , label.Length).Select(j => i == j ? uniqueKey : nonUniqueKey)))
					.ToArray();
			}


			return new string[0];
		}
	}
}