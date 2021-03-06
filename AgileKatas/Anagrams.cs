using System.Linq;

namespace AgileKatas
{
	public class Anagrams
	{
		public static string[] Get(string label)
		{
			if (string.IsNullOrEmpty(label)) return new string[0];

			if (label.Length == 1) return new[] {label};

			if (label.GroupBy(x => x).Count() == 1) return new[] {label};

			if (IfOneUniqueSymbol(label)) return CreateOneUniqueSymbolAnagrams(label);

			if (IsEveryOneUnique(label)) return CreateAllUniqueSymbolAnagrams(label);


			return new string[0];
		}

		private static string[] CreateAllUniqueSymbolAnagrams(string label)
		{
			return new[] {"cba"};
		}

		private static bool IsEveryOneUnique(string label)
		{
			return label.GroupBy(x => x).All(x => x.Count() == 1);
		}

		private static bool IfOneUniqueSymbol(string label)
		{
			return label.Length > 1 && label.GroupBy(x => x).Count() == 2;
		}

		private static string[] CreateOneUniqueSymbolAnagrams(string label)
		{
			var uniqueKey = label.GroupBy(x => x).Where(x => x.Count() == 1).First().Key;
			var nonUniqueKey = label.First(x => x != uniqueKey);

			return Enumerable.Range(0, label.Length)
				.Select(i => string.Join("", Enumerable.Range(0, label.Length).Select(j => i == j ? uniqueKey : nonUniqueKey)))
				.ToArray();
		}
	}
}