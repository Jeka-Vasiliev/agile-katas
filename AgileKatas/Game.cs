namespace AgileKatas
{
	public sealed class Game
	{
		private Snapshot _snapshot = new Snapshot(new[]
		{
			"   ",
			"   ",
			"   ",
		});

		public Snapshot Snapshot()
		{
			return _snapshot;
		}

		public void Move(int x, int y)
		{
			_snapshot = new Snapshot(new[]
			{
				"X  ",
				"   ",
				"   ",
			});
		}
	}
}