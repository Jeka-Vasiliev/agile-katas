namespace AgileKatas
{
	public class RomanConverter
	{
		private static readonly int[] ArabicNumbers = {4, 10};

		private static readonly string[] RomanNumbers = {"IV", "X"};

		public static string Convert(int arabic)
		{
			for (var i = 0; i < ArabicNumbers.Length; i++)
			{
				var arabicNumber = ArabicNumbers[i];
				if (arabic == arabicNumber) return RomanNumbers[i];
			}

			if (10 <= arabic) return "X" + Convert(arabic - 10);
			if (5 <= arabic) return "V" + Convert(arabic - 5);
			return RomanNumberI(arabic);

		}

		private static string RomanNumberI(int arabic)
		{
			return new string('I', arabic);
		}
	}
}