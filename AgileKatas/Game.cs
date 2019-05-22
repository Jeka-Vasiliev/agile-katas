namespace AgileKatas
{
	public sealed class Game
	{
		public Snapshot Snapshot()
		{
			return new Snapshot(new[]
			{
				"   ",
				"   ",
				"   ",
			});
		}
	}
}