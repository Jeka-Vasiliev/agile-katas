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
			return new Board(coordinate);
		}
	}
}