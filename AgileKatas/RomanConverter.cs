using System.Text;

namespace AgileKatas
{
	public class RomanConverter
	{
		public static string Convert(int arabic)
		{
			if (arabic == 4) return "IV";
			
			if (arabic < 5) return RomanNumberI(arabic);
			
			return "V" + Convert(arabic - 5);

		}

		private static string RomanNumberI(int arabic)
		{
			return new string('I', arabic);
		}
	}
}