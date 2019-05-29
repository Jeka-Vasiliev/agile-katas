namespace AgileKatas
{
	public class Game
	{
		public Board Start()
		{
			return new Board();
		}

		public Board Move(Coordinate coordinate)
		{
			if (coordinate.Equals(new Coordinate(new X(0), new Y(0))))
			{
				return new Board(@"
✖⬜⬜
⬜⬜⬜
⬜⬜⬜
");
			}

			return new Board(@"
⬜✖⬜
⬜⬜⬜
⬜⬜⬜
");
		}
	}
}