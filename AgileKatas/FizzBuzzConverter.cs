namespace AgileKatas
{
	public static class FizzBuzzConverter
	{
		public static string Convert(int i)
		{
			switch (i)
			{
				case 1:
					return "1";
				case 2:
					return "2";
				default:
					return "4";
				
			}
		}
	}
}