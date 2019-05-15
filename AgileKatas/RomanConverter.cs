namespace AgileKatas
{
	public class RomanConverter
	{
		private static readonly int[] ArabicNumbers = {1, 5, 10, 50};

		private static readonly string[] RomanNumbers = {"I", "V", "X", "L"};

		public static string Convert(int arabic)
		{
			for (var i = 1; i < ArabicNumbers.Length; i++)
			{
				if (ArabicNumbers[i] == arabic + 1) return "I" + Convert(arabic + 1);
			}
			
			for (var i = ArabicNumbers.Length - 1; i >= 0; i--)
			{
				var arabicNumber = ArabicNumbers[i];
				if (arabicNumber <= arabic) return RomanNumbers[i] + Convert(arabic - arabicNumber);
			}
			
			return RomanNumberI(arabic);

		}

		private static string RomanNumberI(int arabic)
		{
			return new string('I', arabic);
		}
	}
}