namespace AgileKatas
{
	public static class FizzBuzzConverter
	{
		public static string Convert(int i)
		{
			return i % 3 == 0 ? "fizz" : i.ToString();
		}
	}
}