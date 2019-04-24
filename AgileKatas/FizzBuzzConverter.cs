namespace AgileKatas
{
	public static class FizzBuzzConverter
	{
		public static string Convert(int i)
		{
			 return i== 3 || i == 6 ? "fizz" : i.ToString();
		}
	}
}