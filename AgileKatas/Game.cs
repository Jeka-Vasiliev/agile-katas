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
			if (x == 1 && y == 1)
			{
				_snapshot = new Snapshot(new[]
				{
					"   ",
					" X ",
					"   ",
				});
				
				return;
			}
			
			_snapshot = new Snapshot(new[]
			{
				"X  ",
				"   ",
				"   ",
			});
		}
	}
}