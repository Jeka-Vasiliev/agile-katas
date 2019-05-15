namespace AgileKatas
{
	public class RomanConverter
	{
		public static string Convert(int i)
		{
			return i == 5 ? "V" : new string('I', i);
		}
	}
}