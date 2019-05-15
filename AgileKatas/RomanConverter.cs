using System.Text;

namespace AgileKatas
{
	public class RomanConverter
	{
		public static string Convert(int arabic)
		{
			if (arabic >= 5)
			{
				return "V" + Convert(arabic - 5);
			}
			
			return new string('I', arabic);
		}
	}
}