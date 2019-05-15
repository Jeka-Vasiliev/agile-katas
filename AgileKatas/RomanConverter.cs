namespace AgileKatas
{
	public class RomanConverter
	{
		public static string Convert(int i)
		{
			if (i == 6)
			{
				return "VI";
			}
			
			return i == 5 ? "V" : new string('I', i);
		}
	}
}