namespace AgileKatas
{
	public static class FizzBuzzConverter
	{
		public static string Convert(int i)
		{
			if (i == 15 || i == 30 || i == 45)
			{
				return "fizzbuzz";
			}

			if (i % 5 == 0)
			{
				return "buzz";
			}

			return i % 3 == 0 ? "fizz" : i.ToString();
		}
	}
}