namespace AgileKatas
{
	public class RomanConverter
	{
		private static readonly int[] ArabicNumbers = {1, 5, 10, 50, 100};

		private static readonly string[] RomanNumbers = {"I", "V", "X", "L", "C"};

		public static string Convert(int arabic)
		{
			if (arabic == 40)
			{
				var closestArabicNumber = arabic + ArabicNumbers[2];
				return RomanNumbers[2] + Convert(closestArabicNumber);
			}
			
			for (var i = 1; i < ArabicNumbers.Length; i++)
			{
				var closestArabicNumber = arabic + ArabicNumbers[0];
				if (ArabicNumbers[i] == closestArabicNumber) return RomanNumbers[0] + Convert(closestArabicNumber);
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