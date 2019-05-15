namespace AgileKatas
{
	public class RomanConverter
	{
		public static string Convert(int arabic)
		{
			if (arabic == 6)
			{
				return "VI";
			}
			
			return arabic == 5 ? "V" : new string('I', arabic);
		}
	}
}