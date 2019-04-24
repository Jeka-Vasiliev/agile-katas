namespace AgileKatas
{
	public static class FizzBuzzConverter
	{
		public static string Convert(int i)
		{
			if (i % 5 == 0)
			{
				return "buzz";
			}

			return i % 3 == 0 ? "fizz" : i.ToString();
		}
	}
}